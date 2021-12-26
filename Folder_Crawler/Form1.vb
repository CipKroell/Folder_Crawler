Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D

Public Class Form1

    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader
    Private Tmr As Integer = 0

    Private DoCancel As Boolean = False

    Private PB1Value, PB2Value, PB3Value As Integer
    Private PB1Maximum, PB2Maximum, PB3Maximum As Integer

    Private tFile As String = ""

    Dim stpw As Stopwatch

    Private Sub PrintDetails(ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim LvSubjEnrolled As ListView = ListView1

        Static LastIndex As Integer = 0
        Static CurrentPage As Integer = 0

        Dim Fnt As New Font("Arial", 9, FontStyle.Bold)

        Dim ps As New PaperSize("A4", 850, 1100) With {
            .PaperName = CType(PaperKind.A4, String)
        }
        e.PageSettings.PaperSize = ps
        e.PageSettings.Landscape = True

        'Getting the current dpi so the textleftpad 
        'will be the same on a different dpi than 
        'the 96 i'm using.  Won't make much of a difference though.
        Dim DpiGraphics As Graphics = Me.CreateGraphics
        Dim DpiX As Integer = CInt(DpiGraphics.DpiX)
        Dim DpiY As Integer = CInt(DpiGraphics.DpiY)

        DpiGraphics.Dispose()

        Dim X, Y As Integer
        Dim ImageWidth As Integer
        Dim TextRect As Rectangle = Rectangle.Empty
        Dim TextLeftPad As Single = CSng(1 * (DpiX / 96)) '4 pixel pad on the left.
        Dim ColumnHeaderHeight As Single = CSng(LvSubjEnrolled.Font.Height + (5 * (DpiX / 96))) '5 pixel pad on the top an bottom
        Dim StringFormat As New StringFormat
        Dim PageNumberWidth As Single = e.Graphics.MeasureString(CStr(CurrentPage), Fnt).Width

        'Specify the text should be drawn in the center of the line and
        'that the text should not be wrapped and the text should show
        'ellipsis would cut off.
        StringFormat.FormatFlags = StringFormatFlags.NoWrap
        StringFormat.Trimming = StringTrimming.EllipsisCharacter
        StringFormat.LineAlignment = StringAlignment.Center

        CurrentPage += 1
        Dim xFormat As New StringFormat

        If CurrentPage = 1 Then

            Dim MSs As SizeF

            xFormat.Alignment = StringAlignment.Center
            xFormat.LineAlignment = StringAlignment.Center

            MSs = e.Graphics.MeasureString("File Crawler", New Font("Arial", 50, FontStyle.Bold))

            Dim pts() As Point = {New Point(CInt(e.PageBounds.Width / 2 - MSs.Width / 2), CInt(e.PageBounds.Height / 2 - MSs.Height / 2))}
            e.Graphics.Transform.TransformPoints(pts)
            e.Graphics.RotateTransform(-45, MatrixOrder.Append)
            e.Graphics.TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

            e.Graphics.DrawString("File Crawler", New Font("Arial", 50, FontStyle.Bold), Brushes.Black, New Point(0, 0))

            e.HasMorePages = True
            StringFormat.Dispose()

            e.Graphics.ResetTransform()

            Exit Sub
        End If

        'Start the x and  y at the top left margin.
        X = CInt(e.MarginBounds.X / 2)
        Y = CInt(e.MarginBounds.Y / 2)

        Dim TMP As Integer

        'Draw the column headers
        For ColumnIndex As Integer = 0 To LvSubjEnrolled.Columns.Count - 2
            TextRect.X = X
            TextRect.Y = Y

            If ColumnIndex = LvSubjEnrolled.Columns.Count - 2 Then
                TMP = 0
                For i As Integer = 0 To ColumnIndex - 2
                    TMP += LvSubjEnrolled.Columns(i).Width
                Next

                If TMP + LvSubjEnrolled.Columns(ColumnIndex).Width > e.MarginBounds.Width Then
                    TextRect.Width = Math.Abs(TMP - e.MarginBounds.Width) + e.MarginBounds.X
                Else
                    TextRect.Width = LvSubjEnrolled.Columns(ColumnIndex).Width
                End If
            Else
                TextRect.Width = LvSubjEnrolled.Columns(ColumnIndex).Width
            End If

            TextRect.Height = CInt(ColumnHeaderHeight)
            e.Graphics.FillRectangle(Brushes.LightGray, TextRect)
            e.Graphics.DrawRectangle(Pens.DarkGray, TextRect)

            'TextLeftPad adds a little padding from the gridline.
            'Add it to the left and subtract it from the right.
            TextRect.X += CInt(TextLeftPad)
            TextRect.Width -= CInt(TextLeftPad)
            e.Graphics.DrawString(LvSubjEnrolled.Columns(ColumnIndex).Text, Fnt, Brushes.Black, TextRect, StringFormat)

            'Move the x position over the width of the column width.
            'Since I subtracted some padding add the padding back
            'when offsetting.
            X += CInt(TextRect.Width + TextLeftPad)
        Next

        'Just drew the headers.  Move the Y down the height
        'of the column headers.
        Y += CInt(ColumnHeaderHeight)

        'Now draw the items.  If this is the first page then the 
        'last index will be zero.  If its not then the last index
        'will be the last index we tried to draw but had no room.
        For i = LastIndex To LvSubjEnrolled.Items.Count - 1
            With LvSubjEnrolled.Items(i)

                'Start the x at the pages left margin.
                X = CInt(e.MarginBounds.X / 2)

                'Check for Last Line
                If Y + .Bounds.Height > e.MarginBounds.Bottom Then

                    'This item won't fit.
                    'subtract 1 from i so the next time this sub
                    'is entered we can start with this item.
                    LastIndex = i - 1
                    e.HasMorePages = True
                    StringFormat.Dispose()

                    'Draw the current page number before leaving.
                    e.Graphics.DrawString(CStr(CurrentPage), Fnt, Brushes.Black, (e.PageBounds.Width - PageNumberWidth) / 2, e.PageBounds.Bottom - LvSubjEnrolled.Font.Height * 2)
                    Exit Sub
                End If

                'Print Images.
                'The image width is used so we can draw the gridline
                'around the image about to be drawn.  You'll see it 
                'below.
                ImageWidth = 0
                If LvSubjEnrolled.SmallImageList IsNot Nothing Then

                    'If the image key is set then draw the image
                    'with the key .  If not draw the image with the
                    'index.  A tiny bit of validation would be good.
                    If Not String.IsNullOrEmpty(.ImageKey) Then
                        e.Graphics.DrawImage(LvSubjEnrolled.SmallImageList.Images(.ImageKey), X, Y)
                    ElseIf .ImageIndex >= 0 Then
                        e.Graphics.DrawImage(LvSubjEnrolled.SmallImageList.Images(.ImageIndex), X, Y)
                    End If
                    ImageWidth = LvSubjEnrolled.SmallImageList.ImageSize.Width
                End If

                'Now draw the subitems.  using the columns count so the 
                'grid lines can be drawn.  If used the subitems count then
                'the table would not be full if some subitems where less
                'than others.
                For ColumnIndex As Integer = 0 To LvSubjEnrolled.Columns.Count - 2
                    TextRect.X = X
                    TextRect.Y = Y

                    If ColumnIndex = LvSubjEnrolled.Columns.Count - 2 Then
                        TMP = 0
                        For o As Integer = 0 To ColumnIndex - 2
                            TMP += LvSubjEnrolled.Columns(o).Width
                        Next

                        If TMP + LvSubjEnrolled.Columns(ColumnIndex).Width > e.MarginBounds.Width Then
                            TextRect.Width = Math.Abs(TMP - e.MarginBounds.Width) + e.MarginBounds.X
                        Else
                            TextRect.Width = LvSubjEnrolled.Columns(ColumnIndex).Width
                        End If
                    Else
                        TextRect.Width = LvSubjEnrolled.Columns(ColumnIndex).Width
                    End If

                    TextRect.Height = .Bounds.Height
                    If LvSubjEnrolled.GridLines Then
                        e.Graphics.DrawRectangle(Pens.DarkGray, TextRect)
                    End If

                    'If an image is drawn then shift over the x to 
                    'accomadate its width. If this was shifted before
                    'now then the gridline with draw rect above would be
                    ' on the wrong side of the image.
                    If ColumnIndex = 0 Then TextRect.X += ImageWidth

                    'Add a little padding from the gridline.
                    TextRect.X += CInt(TextLeftPad)
                    TextRect.Width -= CInt(TextLeftPad)
                    If ColumnIndex < .SubItems.Count Then
                        'This item has at least the same number of
                        'subitems as the current column index.
                        e.Graphics.DrawString(.SubItems(ColumnIndex).Text, Fnt, Brushes.Black, TextRect, StringFormat)
                    End If

                    'Shift the x of the width of this subitem.
                    'Add some padding to the left side of the text
                    'so need to add it back.
                    X += CInt(TextRect.Width + TextLeftPad)
                Next

                'Set the next line
                Y += .Bounds.Height
            End With
        Next

        xformat.Alignment = StringAlignment.Center
        xformat.LineAlignment = StringAlignment.Center

        'draw totals
        e.Graphics.DrawString("Ficheiros: " & slTotal.Text & " Ocupado: " & slSize.Text, Fnt, Brushes.Black, (e.PageBounds.Width - PageNumberWidth) / 2, e.PageBounds.Bottom - LvSubjEnrolled.Font.Height * 4, xFormat)

        'Draw the final page number.
        e.Graphics.DrawString(CStr(CurrentPage), Fnt, Brushes.Black, (e.PageBounds.Width - PageNumberWidth) / 2, e.PageBounds.Bottom - LvSubjEnrolled.Font.Height * 2)
        StringFormat.Dispose()
        LastIndex = 0
        CurrentPage = 0
    End Sub

    Private Function SolveSizes(TheSize As Single) As String
        Dim CalculatedSize As Decimal
        Dim SizeType As String = ""

        If TheSize < 1024 Then
            CalculatedSize = CDec(TheSize)
            SizeType = "B"
        ElseIf TheSize > 1024 AndAlso TheSize < (1024 ^ 2) Then 'KB
            CalculatedSize = CDec(Math.Round((TheSize / 1024), 2))
            SizeType = "KB"

        ElseIf TheSize > (1024 ^ 2) AndAlso TheSize < (1024 ^ 3) Then 'MB
            CalculatedSize = CDec(Math.Round((TheSize / (1024 ^ 2)), 2))
            SizeType = "MB"

        ElseIf TheSize > (1024 ^ 3) AndAlso TheSize < (1024 ^ 4) Then 'GB
            CalculatedSize = CDec(Math.Round((TheSize / (1024 ^ 3)), 2))
            SizeType = "GB"

        ElseIf TheSize > (1024 ^ 4) Then 'TB
            CalculatedSize = CDec(Math.Round((TheSize / (1024 ^ 4)), 2))
            SizeType = "TB"
        End If

        Return CalculatedSize & " " & SizeType
    End Function

    Private Sub OpenFile(K As String)
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo(K) With {
            .UseShellExecute = True,
            .WindowStyle = ProcessWindowStyle.Normal
        }

        p.StartInfo = s
        p.Start()
    End Sub

#Region "Open Folder"
    Private Sub AbrirPastaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirPastaToolStripMenuItem.Click
        With FolderBrowserDialog1
            .ShowDialog()

            If .SelectedPath.Length = 0 Then Exit Sub

            slProjectFolder.Text = .SelectedPath
        End With
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        AbrirPastaToolStripMenuItem_Click(sender, Nothing)
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        AbrirPastaToolStripMenuItem_Click(sender, Nothing)
    End Sub
#End Region

#Region "Analizar Pastas"
    Private Sub AnalisarPastaSeleccionadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalisarPastaSeleccionadaToolStripMenuItem.Click
        Dim Files() As String
        Dim SubFolders() As String

        Dim MainList As New ArrayList
        Dim TempList As New ArrayList

        If Not Directory.Exists(slProjectFolder.Text) Then
            MsgBox("Select a folder before continue....")
            Exit Sub
        End If

        Dim MLIndex As Integer = 0
        Dim FI As FileInfo
        Dim DI As DirectoryInfo
        Dim RarPartFound As Boolean = False
        Dim SizeTot As Single = 0
        Dim iconFound As Boolean = False
        Dim IconName As String = ""
        Dim tSize As Double = 0
        Dim st() As String
        Dim isMediaFileFound As Boolean = False

        PB1Maximum = 0

        ListView1.Items.Clear()

        ListView1.Visible = False
        MainList.Add(slProjectFolder.Text)

        Me.Invalidate()

        DoCancel = False

        ToolStripButton3.Enabled = True

        Tmr = 0
        stpw = Stopwatch.StartNew

        Do
            If MainList.Count > PB1Maximum Then PB1Maximum = MainList.Count
            PB1Value = MainList.Count

            RoundProgress3.Max = PB1Maximum
            RoundProgress3.Value = PB1Value

            PB2Maximum = MainList.Count
            PB2Value = MLIndex

            RoundProgress1.Max = MainList.Count
            RoundProgress1.Value = MLIndex

            slTempo.Text = stpw.Elapsed.Hours.ToString("00") & ":" & stpw.Elapsed.Minutes.ToString("00") & ":" & stpw.Elapsed.Seconds.ToString("00")
            Application.DoEvents()

            slCurrentFolder.Text = CType(MainList(MLIndex), String)

            Me.Invalidate()

            'get all the folders
            Try
                If InStr(CType(MainList(MLIndex), String), "winsxs") <> 0 Then Exit Try

                SubFolders = Directory.GetDirectories(CType(MainList(MLIndex), String))
                If SubFolders.Length > 0 Then
                    RoundProgress2.Max = SubFolders.Length
                    RoundProgress2.Value = 0

                    For Each fldr As String In SubFolders
                        If DoCancel Then Exit Do

                        TempList.Add(fldr)
                        RoundProgress2.Value += 1

                        If PB3Value Mod 10 = 0 Then
                            Me.Invalidate()
                            Application.DoEvents()
                        End If
                    Next

                    If TempList.Count > PB1Maximum Then PB1Maximum = TempList.Count
                    RoundProgress3.Value = TempList.Count

                    Me.Invalidate()
                End If
            Catch ex As Exception : End Try

            'get all the files
            Try
                If InStr(CType(MainList(MLIndex), String), "winsxs") <> 0 Then Exit Try

                Files = Directory.GetFiles(CType(MainList(MLIndex), String))
                If Files.Length > 0 Then
                    RoundProgress2.Max = Files.Length
                    RoundProgress2.Value = 0

                    RarPartFound = False

                    For Each fl As String In Files
                        If DoCancel Then Exit Do

                        If Strings.InStr(fl, ".part") <> 0 Then
                            RarPartFound = True
                            Exit For
                        End If
                    Next

                    Select Case RarPartFound
                        Case False
                            If VerificarFicheirosIndividuaisToolStripMenuItem.Checked Then

                                For Each fl As String In Files

                                    tFile = fl

                                    If DoCancel Then Exit Do

                                    FI = New FileInfo(fl)
                                    DI = New DirectoryInfo(CType(MainList(MLIndex), String))

                                    If FI.Extension <> "" Then

                                        st = Split(FI.Name, ".")

                                        With ListView1.Items.Add(st(0))
                                            .SubItems.Add(Replace(FI.Extension, ".", "").ToUpper)
                                            .SubItems.Add(SolveSizes(FI.Length))
                                            .SubItems.Add("1")
                                            .SubItems.Add(Strings.Right(CType(MainList(MLIndex), String), Len(MainList(MLIndex)) - (Len(slProjectFolder.Text))))
                                            .SubItems.Add(FI.FullName)

                                            tSize += FI.Length

                                            IconName = "_Default"
                                            For Each img As String In ImageList1.Images.Keys
                                                If Strings.InStr(img.ToUpper, Replace(FI.Extension, ".", "").ToUpper) <> 0 Then
                                                    IconName = img
                                                    Exit For
                                                End If
                                            Next

                                            .ImageKey = IconName

                                        End With

                                    End If

                                    RoundProgress2.Value += 1
                                    If RoundProgress2.Value Mod 2 = 0 Then
                                        Application.DoEvents()
                                        slTotal.Text = CType(ListView1.Items.Count, String)
                                        Me.Invalidate()
                                    End If

                                Next
                            Else
                                isMediaFileFound = False

                                For Each fl As String In Files
                                    FI = New FileInfo(fl)

                                    If DoCancel Then Exit Do

                                    If Strings.InStr("avi.mpg.mpeg.wmv.divx.mkv.mp4.wav.mp3.wma.mid.midi.jpg.jpeg.png.bmp.gif", Replace(FI.Extension.ToLower, ".", "")) <> 0 Then
                                        isMediaFileFound = True
                                        Exit For
                                    End If
                                Next

                                Select Case isMediaFileFound
                                    Case False
                                        SizeTot = 0
                                        For Each fl As String In Files
                                            If DoCancel Then Exit Do

                                            tFile = fl

                                            FI = New FileInfo(fl)

                                            SizeTot += FI.Length
                                            tSize += FI.Length

                                            RoundProgress2.Value += 1
                                            If RoundProgress2.Value Mod 2 = 0 Then
                                                Application.DoEvents()
                                                slTotal.Text = CType(ListView1.Items.Count, String)
                                                Me.Invalidate()
                                            End If

                                        Next

                                        DI = New DirectoryInfo(CType(MainList(MLIndex), String))

                                        With ListView1.Items.Add(DI.Name)
                                            .SubItems.Add("NON Media")
                                            .SubItems.Add(SolveSizes(SizeTot))
                                            .SubItems.Add(Files.Length.ToString)
                                            .SubItems.Add(Strings.Right(CType(MainList(MLIndex), String), Len(MainList(MLIndex)) - (Len(slProjectFolder.Text))))
                                            .SubItems.Add("")

                                            .ImageKey = "rarblock"
                                        End With
                                    Case True
                                        For Each fl As String In Files

                                            tFile = fl

                                            If DoCancel Then Exit Do

                                            FI = New FileInfo(fl)
                                            DI = New DirectoryInfo(CType(MainList(MLIndex), String))

                                            If FI.Extension <> "" And Strings.InStr(txtExt.Text.ToLower, FI.Extension.Replace(".", "").ToLower) = 0 Then

                                                st = Split(FI.Name, ".")

                                                With ListView1.Items.Add(st(0))
                                                    .SubItems.Add(Replace(FI.Extension, ".", "").ToUpper)
                                                    .SubItems.Add(SolveSizes(FI.Length))
                                                    .SubItems.Add("1")
                                                    .SubItems.Add(Strings.Right(CType(MainList(MLIndex), String), Len(MainList(MLIndex)) - (Len(slProjectFolder.Text))))
                                                    .SubItems.Add(FI.FullName)

                                                    tSize += FI.Length

                                                    IconName = "_Default"
                                                    For Each img As String In ImageList1.Images.Keys
                                                        If Strings.InStr(img.ToUpper, Replace(FI.Extension, ".", "").ToUpper) <> 0 Then
                                                            IconName = img
                                                            Exit For
                                                        End If
                                                    Next

                                                    .ImageKey = IconName

                                                End With

                                            End If

                                            RoundProgress2.Value += 1
                                            If RoundProgress2.Value Mod 2 = 0 Then
                                                Application.DoEvents()
                                                slTotal.Text = CType(ListView1.Items.Count, String)
                                                Me.Invalidate()
                                            End If

                                        Next
                                End Select
                            End If

                            Me.Invalidate()
                        Case True
                            SizeTot = 0
                            For Each fl As String In Files
                                If DoCancel Then Exit Do

                                tFile = fl

                                FI = New FileInfo(fl)

                                SizeTot += FI.Length
                                tSize += FI.Length

                                RoundProgress2.Value += 1
                                If RoundProgress2.Value Mod 2 = 0 Then
                                    Application.DoEvents()
                                    slTotal.Text = CType(ListView1.Items.Count, String)
                                    Me.Invalidate()
                                End If

                            Next

                            DI = New DirectoryInfo(CType(MainList(MLIndex), String))

                            With ListView1.Items.Add(DI.Name)
                                .SubItems.Add("RAR Block")
                                .SubItems.Add(SolveSizes(SizeTot))
                                .SubItems.Add(Files.Length.ToString)
                                .SubItems.Add(Strings.Right(CType(MainList(MLIndex), String), Len(MainList(MLIndex)) - (Len(slProjectFolder.Text) + 1)))
                                .SubItems.Add("")

                                .ImageKey = "rarblock"
                            End With
                    End Select
                End If

                slSize.Text = SolveSizes(CSng(tSize))
            Catch ex As Exception

            End Try

            If DoCancel Then Exit Do

            Me.Invalidate()

            MLIndex += 1
            If MLIndex > MainList.Count - 1 Then
                MainList.Clear()

                If TempList.Count <> 0 Then
                    For i As Integer = 0 To TempList.Count - 1
                        If DoCancel Then Exit Do

                        MainList.Add(TempList(i))
                    Next
                End If

                MLIndex = 0
                TempList.Clear()
            End If
        Loop Until MainList.Count = 0 Or DoCancel

        slCurrentFolder.Text = CType(IIf(DoCancel, "Canceled by user!", "Organizing Columns"), String)
        Application.DoEvents()

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.Columns(5).Width = 0

        ListView1.Visible = True

        slCurrentFolder.Text = "Completed!"

        ToolStripButton3.Enabled = False

        stpw.Stop()

        PB1Value = pb1Maximum
        pb2Value = pb2Maximum
        pb3Value = pb3Maximum
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        AnalisarPastaSeleccionadaToolStripMenuItem_Click(sender, Nothing)
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        AnalisarPastaSeleccionadaToolStripMenuItem_Click(sender, e)
    End Sub
#End Region

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure that you want to exit from program?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If

        Me.Dispose()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintDetails(e)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        DoCancel = True
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        PrintDocument1.Print()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        With e.Graphics
            Dim xFormat As New StringFormat
            Dim xSIze As SizeF

            xFormat.Alignment = StringAlignment.Center
            xFormat.LineAlignment = StringAlignment.Center

            xSIze = .MeasureString("Searching for files and folders...", New Font("Arial", 25, FontStyle.Bold))

            Dim pts() As Point = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2))}
            .Transform.TransformPoints(pts)
            .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

            .DrawString("Processing files and folders...", New Font("Arial", 25, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)

            pts = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2 + xSIze.Height))}
            .ResetTransform()
            .Transform.TransformPoints(pts)
            .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

            .DrawString(slCurrentFolder.Text, New Font("Arial", 15, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)

            xSIze = .MeasureString(PB1Value & "/" & PB1Maximum & " - " & _
                                    PB2Value & "/" & PB2Maximum & " - " & _
                                    PB3Value & "/" & PB3Maximum, New Font("Arial", 25, FontStyle.Bold))

            Try
                Dim FL As New FileInfo(tFile)

                pts = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2 + (xSIze.Height * 2)))}
                .ResetTransform()
                .Transform.TransformPoints(pts)
                .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

                .DrawString(Math.Round(FL.Length / 1024 / 1024, 2) & " MB", New Font("Arial", 15, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)

                pts = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2 + (xSIze.Height * 3)))}
                .ResetTransform()
                .Transform.TransformPoints(pts)
                .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

                .DrawString(FL.Name, New Font("Arial", 15, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)

                pts = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2 + (xSIze.Height * 4)))}
                .ResetTransform()
                .Transform.TransformPoints(pts)
                .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

                .DrawString(FL.LastWriteTime.ToShortDateString, New Font("Arial", 15, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)
            Catch ex As Exception
                pts = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2 + (xSIze.Height * 2)))}
                .ResetTransform()
                .Transform.TransformPoints(pts)
                .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

                .DrawString(" ", New Font("Arial", 15, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)

                pts = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2 + (xSIze.Height * 3)))}
                .ResetTransform()
                .Transform.TransformPoints(pts)
                .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

                .DrawString(" ", New Font("Arial", 15, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)

                pts = {New Point(CInt(Me.Width / 2), CInt(Me.Height / 2 + (xSIze.Height * 4)))}
                .ResetTransform()
                .Transform.TransformPoints(pts)
                .TranslateTransform(pts(0).X, pts(0).Y, MatrixOrder.Append)

                .DrawString(" ", New Font("Arial", 15, FontStyle.Bold), Brushes.Gray, New Point(0, 0), xFormat)
            End Try
        End With
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.Invalidate()
    End Sub

    Private Sub LimparProjectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparProjectoToolStripMenuItem.Click
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub DoTheSortThing(K As Integer)
        Dim new_sorting_column As ColumnHeader = ListView1.Columns(K)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder

        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text = _
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        ListView1.ListViewItemSorter = New  _
            ListViewComparer(K, sort_order)

        ' Sort.
        ListView1.Sort()
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs)
        DoTheSortThing(e.Column)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Tmr += 1
        slTempo.Text = Int(Tmr / 60).ToString & ":" & (Tmr Mod 60).ToString("00")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VerificarFicheirosIndividuaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarFicheirosIndividuaisToolStripMenuItem.Click
        VerificarFicheirosIndividuaisToolStripMenuItem.Checked = Not VerificarFicheirosIndividuaisToolStripMenuItem.Checked
    End Sub

    Private Sub ListView1_KeyUp(sender As Object, e As KeyEventArgs) Handles ListView1.KeyUp
        If e.KeyCode = Keys.Delete Then
            For Each i As ListViewItem In ListView1.SelectedItems
                ListView1.Items.Remove(i)
            Next
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If Not (ListView1.SelectedItems(0).SubItems(1).Text = "NON Media" Or ListView1.SelectedItems(0).SubItems(1).Text = "RAR Block") Then
            OpenFile(ListView1.SelectedItems(0).SubItems(5).Text)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ImprimirToolStripMenuItem_Click(sender, Nothing)
    End Sub
End Class
