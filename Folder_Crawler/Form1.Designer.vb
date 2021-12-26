<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirPastaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.LimparProjectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnalisarPastaSeleccionadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportarHTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificarFicheirosIndividuaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slProjectFolder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slCurrentFolder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slTempo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtExt = New System.Windows.Forms.ToolStripTextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RoundProgress3 = New Folder_Crawler.RoundProgress()
        Me.RoundProgress2 = New Folder_Crawler.RoundProgress()
        Me.RoundProgress1 = New Folder_Crawler.RoundProgress()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "aiff")
        Me.ImageList1.Images.SetKeyName(1, "rartargzip")
        Me.ImageList1.Images.SetKeyName(2, "asp")
        Me.ImageList1.Images.SetKeyName(3, "bin")
        Me.ImageList1.Images.SetKeyName(4, "ccd")
        Me.ImageList1.Images.SetKeyName(5, "cmd")
        Me.ImageList1.Images.SetKeyName(6, "com")
        Me.ImageList1.Images.SetKeyName(7, "css")
        Me.ImageList1.Images.SetKeyName(8, "_Default")
        Me.ImageList1.Images.SetKeyName(9, "ttf")
        Me.ImageList1.Images.SetKeyName(10, "img")
        Me.ImageList1.Images.SetKeyName(11, "inf")
        Me.ImageList1.Images.SetKeyName(12, "ini")
        Me.ImageList1.Images.SetKeyName(13, "iso")
        Me.ImageList1.Images.SetKeyName(14, "mdf")
        Me.ImageList1.Images.SetKeyName(15, "mds")
        Me.ImageList1.Images.SetKeyName(16, "midimid")
        Me.ImageList1.Images.SetKeyName(17, "mov")
        Me.ImageList1.Images.SetKeyName(18, "mpc")
        Me.ImageList1.Images.SetKeyName(19, "mpg")
        Me.ImageList1.Images.SetKeyName(20, "php")
        Me.ImageList1.Images.SetKeyName(21, "png")
        Me.ImageList1.Images.SetKeyName(22, "sys")
        Me.ImageList1.Images.SetKeyName(23, "wav")
        Me.ImageList1.Images.SetKeyName(24, "wma")
        Me.ImageList1.Images.SetKeyName(25, "wmv")
        Me.ImageList1.Images.SetKeyName(26, "rarblock")
        Me.ImageList1.Images.SetKeyName(27, "3pg")
        Me.ImageList1.Images.SetKeyName(28, "7zip")
        Me.ImageList1.Images.SetKeyName(29, "ace")
        Me.ImageList1.Images.SetKeyName(30, "ai")
        Me.ImageList1.Images.SetKeyName(31, "aif")
        Me.ImageList1.Images.SetKeyName(32, "arm")
        Me.ImageList1.Images.SetKeyName(33, "asx")
        Me.ImageList1.Images.SetKeyName(34, "avi")
        Me.ImageList1.Images.SetKeyName(35, "bat")
        Me.ImageList1.Images.SetKeyName(36, "bmp")
        Me.ImageList1.Images.SetKeyName(37, "bup")
        Me.ImageList1.Images.SetKeyName(38, "cab")
        Me.ImageList1.Images.SetKeyName(39, "cache")
        Me.ImageList1.Images.SetKeyName(40, "cbr")
        Me.ImageList1.Images.SetKeyName(41, "cda")
        Me.ImageList1.Images.SetKeyName(42, "cdl")
        Me.ImageList1.Images.SetKeyName(43, "cdr")
        Me.ImageList1.Images.SetKeyName(44, "chm")
        Me.ImageList1.Images.SetKeyName(45, "cs")
        Me.ImageList1.Images.SetKeyName(46, "dat")
        Me.ImageList1.Images.SetKeyName(47, "db")
        Me.ImageList1.Images.SetKeyName(48, "divx")
        Me.ImageList1.Images.SetKeyName(49, "dll")
        Me.ImageList1.Images.SetKeyName(50, "dmg")
        Me.ImageList1.Images.SetKeyName(51, "docx")
        Me.ImageList1.Images.SetKeyName(52, "dss")
        Me.ImageList1.Images.SetKeyName(53, "dvf")
        Me.ImageList1.Images.SetKeyName(54, "eps")
        Me.ImageList1.Images.SetKeyName(55, "exe")
        Me.ImageList1.Images.SetKeyName(56, "gif")
        Me.ImageList1.Images.SetKeyName(57, "html")
        Me.ImageList1.Images.SetKeyName(58, "indd")
        Me.ImageList1.Images.SetKeyName(59, "jpgjpeg")
        Me.ImageList1.Images.SetKeyName(60, "lnk")
        Me.ImageList1.Images.SetKeyName(61, "log")
        Me.ImageList1.Images.SetKeyName(62, "mp4")
        Me.ImageList1.Images.SetKeyName(63, "ogg")
        Me.ImageList1.Images.SetKeyName(64, "pdf")
        Me.ImageList1.Images.SetKeyName(65, "pptx")
        Me.ImageList1.Images.SetKeyName(66, "ps")
        Me.ImageList1.Images.SetKeyName(67, "psd")
        Me.ImageList1.Images.SetKeyName(68, "res")
        Me.ImageList1.Images.SetKeyName(69, "rm")
        Me.ImageList1.Images.SetKeyName(70, "rtf")
        Me.ImageList1.Images.SetKeyName(71, "sln")
        Me.ImageList1.Images.SetKeyName(72, "ss")
        Me.ImageList1.Images.SetKeyName(73, "swf")
        Me.ImageList1.Images.SetKeyName(74, "tga")
        Me.ImageList1.Images.SetKeyName(75, "tif")
        Me.ImageList1.Images.SetKeyName(76, "tor")
        Me.ImageList1.Images.SetKeyName(77, "txt")
        Me.ImageList1.Images.SetKeyName(78, "vb")
        Me.ImageList1.Images.SetKeyName(79, "vcd")
        Me.ImageList1.Images.SetKeyName(80, "wpd")
        Me.ImageList1.Images.SetKeyName(81, "xmal")
        Me.ImageList1.Images.SetKeyName(82, "xtm")
        Me.ImageList1.Images.SetKeyName(83, "zip")
        Me.ImageList1.Images.SetKeyName(84, "mp3")
        Me.ImageList1.Images.SetKeyName(85, "xlsx")
        Me.ImageList1.Images.SetKeyName(86, "ico")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem, Me.ProcessoToolStripMenuItem, Me.OpçõesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1307, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator6, Me.SairToolStripMenuItem})
        Me.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        Me.FicheiroToolStripMenuItem.Size = New System.Drawing.Size(38, 19)
        Me.FicheiroToolStripMenuItem.Text = "File"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(177, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem.Text = "Exit"
        '
        'ProcessoToolStripMenuItem
        '
        Me.ProcessoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirPastaToolStripMenuItem, Me.ToolStripSeparator7, Me.LimparProjectoToolStripMenuItem, Me.ToolStripSeparator8, Me.AnalisarPastaSeleccionadaToolStripMenuItem, Me.ToolStripSeparator9, Me.ExportarHTMLToolStripMenuItem})
        Me.ProcessoToolStripMenuItem.Name = "ProcessoToolStripMenuItem"
        Me.ProcessoToolStripMenuItem.Size = New System.Drawing.Size(59, 19)
        Me.ProcessoToolStripMenuItem.Text = "Project"
        '
        'AbrirPastaToolStripMenuItem
        '
        Me.AbrirPastaToolStripMenuItem.Name = "AbrirPastaToolStripMenuItem"
        Me.AbrirPastaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AbrirPastaToolStripMenuItem.Text = "Select Folder"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(198, 6)
        '
        'LimparProjectoToolStripMenuItem
        '
        Me.LimparProjectoToolStripMenuItem.Name = "LimparProjectoToolStripMenuItem"
        Me.LimparProjectoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.LimparProjectoToolStripMenuItem.Text = "Clean Project"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(198, 6)
        '
        'AnalisarPastaSeleccionadaToolStripMenuItem
        '
        Me.AnalisarPastaSeleccionadaToolStripMenuItem.Name = "AnalisarPastaSeleccionadaToolStripMenuItem"
        Me.AnalisarPastaSeleccionadaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AnalisarPastaSeleccionadaToolStripMenuItem.Text = "Analize selected folder"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(198, 6)
        '
        'ExportarHTMLToolStripMenuItem
        '
        Me.ExportarHTMLToolStripMenuItem.Name = "ExportarHTMLToolStripMenuItem"
        Me.ExportarHTMLToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ExportarHTMLToolStripMenuItem.Text = "Export HTML"
        '
        'OpçõesToolStripMenuItem
        '
        Me.OpçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerificarFicheirosIndividuaisToolStripMenuItem})
        Me.OpçõesToolStripMenuItem.Name = "OpçõesToolStripMenuItem"
        Me.OpçõesToolStripMenuItem.Size = New System.Drawing.Size(62, 19)
        Me.OpçõesToolStripMenuItem.Text = "Options"
        '
        'VerificarFicheirosIndividuaisToolStripMenuItem
        '
        Me.VerificarFicheirosIndividuaisToolStripMenuItem.Checked = True
        Me.VerificarFicheirosIndividuaisToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VerificarFicheirosIndividuaisToolStripMenuItem.Name = "VerificarFicheirosIndividuaisToolStripMenuItem"
        Me.VerificarFicheirosIndividuaisToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerificarFicheirosIndividuaisToolStripMenuItem.Text = "Verify Each File"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.slProjectFolder, Me.ToolStripStatusLabel3, Me.slCurrentFolder, Me.ToolStripStatusLabel2, Me.slTotal, Me.ToolStripStatusLabel4, Me.slSize, Me.ToolStripStatusLabel5, Me.slTempo})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 777)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1307, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(98, 19)
        Me.ToolStripStatusLabel1.Text = "Selected Folder"
        '
        'slProjectFolder
        '
        Me.slProjectFolder.Name = "slProjectFolder"
        Me.slProjectFolder.Size = New System.Drawing.Size(160, 19)
        Me.slProjectFolder.Text = "Select a folder and execute"
        Me.slProjectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(92, 19)
        Me.ToolStripStatusLabel3.Text = "Current Folder"
        Me.ToolStripStatusLabel3.Visible = False
        '
        'slCurrentFolder
        '
        Me.slCurrentFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.slCurrentFolder.Name = "slCurrentFolder"
        Me.slCurrentFolder.Size = New System.Drawing.Size(843, 19)
        Me.slCurrentFolder.Spring = True
        Me.slCurrentFolder.Text = "Process Stoped"
        Me.slCurrentFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.slCurrentFolder.Visible = False
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(35, 19)
        Me.ToolStripStatusLabel2.Text = "Files"
        '
        'slTotal
        '
        Me.slTotal.Name = "slTotal"
        Me.slTotal.Size = New System.Drawing.Size(14, 19)
        Me.slTotal.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(39, 19)
        Me.ToolStripStatusLabel4.Text = "Used"
        '
        'slSize
        '
        Me.slSize.Name = "slSize"
        Me.slSize.Size = New System.Drawing.Size(25, 19)
        Me.slSize.Text = "0 B"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(39, 19)
        Me.ToolStripStatusLabel5.Text = "Time"
        '
        'slTempo
        '
        Me.slTempo.Name = "slTempo"
        Me.slTempo.Size = New System.Drawing.Size(31, 19)
        Me.slTempo.Text = "0:00"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripSeparator10, Me.ToolStripLabel1, Me.txtExt})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.ShowItemToolTips = False
        Me.ToolStrip1.Size = New System.Drawing.Size(1307, 39)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Enabled = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 36)
        Me.ToolStripLabel1.Text = "Ignore Extensions"
        '
        'txtExt
        '
        Me.txtExt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(300, 39)
        '
        'PrintDocument1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 64)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(1307, 713)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File"
        Me.ColumnHeader1.Width = 233
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Size"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Blocks"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Location"
        Me.ColumnHeader5.Width = 400
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Path"
        Me.ColumnHeader6.Width = 0
        '
        'RoundProgress3
        '
        Me.RoundProgress3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RoundProgress3.BackColor = System.Drawing.Color.Transparent
        Me.RoundProgress3.CasingColor = System.Drawing.Color.Black
        Me.RoundProgress3.GradientColorEnd = System.Drawing.Color.White
        Me.RoundProgress3.GradientColorStart = System.Drawing.Color.DodgerBlue
        Me.RoundProgress3.Location = New System.Drawing.Point(18, 635)
        Me.RoundProgress3.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.RoundProgress3.Max = CType(100, Long)
        Me.RoundProgress3.Name = "RoundProgress3"
        Me.RoundProgress3.RoundProgressColor = System.Drawing.Color.DodgerBlue
        Me.RoundProgress3.ShowPercentage = False
        Me.RoundProgress3.Size = New System.Drawing.Size(130, 130)
        Me.RoundProgress3.TabIndex = 7
        Me.RoundProgress3.Value = CType(50, Long)
        '
        'RoundProgress2
        '
        Me.RoundProgress2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoundProgress2.BackColor = System.Drawing.Color.Transparent
        Me.RoundProgress2.CasingColor = System.Drawing.Color.Black
        Me.RoundProgress2.GradientColorEnd = System.Drawing.Color.White
        Me.RoundProgress2.GradientColorStart = System.Drawing.Color.DodgerBlue
        Me.RoundProgress2.Location = New System.Drawing.Point(1130, 238)
        Me.RoundProgress2.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.RoundProgress2.Max = CType(100, Long)
        Me.RoundProgress2.Name = "RoundProgress2"
        Me.RoundProgress2.RoundProgressColor = System.Drawing.Color.DodgerBlue
        Me.RoundProgress2.ShowPercentage = False
        Me.RoundProgress2.Size = New System.Drawing.Size(164, 164)
        Me.RoundProgress2.TabIndex = 6
        Me.RoundProgress2.Value = CType(50, Long)
        '
        'RoundProgress1
        '
        Me.RoundProgress1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoundProgress1.BackColor = System.Drawing.Color.Transparent
        Me.RoundProgress1.CasingColor = System.Drawing.Color.Black
        Me.RoundProgress1.GradientColorEnd = System.Drawing.Color.White
        Me.RoundProgress1.GradientColorStart = System.Drawing.Color.DodgerBlue
        Me.RoundProgress1.Location = New System.Drawing.Point(1130, 69)
        Me.RoundProgress1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RoundProgress1.Max = CType(100, Long)
        Me.RoundProgress1.Name = "RoundProgress1"
        Me.RoundProgress1.RoundProgressColor = System.Drawing.Color.DodgerBlue
        Me.RoundProgress1.ShowPercentage = False
        Me.RoundProgress1.Size = New System.Drawing.Size(165, 165)
        Me.RoundProgress1.TabIndex = 5
        Me.RoundProgress1.Value = CType(50, Long)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1307, 801)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.RoundProgress3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RoundProgress2)
        Me.Controls.Add(Me.RoundProgress1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "FileCrawler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirPastaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LimparProjectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnalisarPastaSeleccionadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportarHTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slProjectFolder As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slCurrentFolder As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slSize As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slTempo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RoundProgress1 As Folder_Crawler.RoundProgress
    Friend WithEvents RoundProgress2 As Folder_Crawler.RoundProgress
    Friend WithEvents RoundProgress3 As Folder_Crawler.RoundProgress
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificarFicheirosIndividuaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtExt As System.Windows.Forms.ToolStripTextBox

End Class
