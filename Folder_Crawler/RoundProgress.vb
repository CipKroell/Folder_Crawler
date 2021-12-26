Imports System.Drawing.Drawing2D
Imports System.Math
Imports System.ComponentModel

Public Class RoundProgress

    Private _ColorStart As Color = Color.Wheat
    Private _ColorEnd As Color = Color.Black
    Private _CasingColor As Color = Color.Black
    Private _RoundProgressColor As Color = Color.DodgerBlue

    Private _Value As Long = 50
    Private _Max As Long = 100
    Private _ShowPercentage As Boolean = True
    Private _ShowGradientCenter As Boolean = True

#Region "Propriedades"
    <DefaultValue(50)> _
    Public Property Value As Long
        Get
            Return _Value
        End Get
        Set(value As Long)
            _Value = value

            Invalidate()
        End Set
    End Property

    <DefaultValue(100)> _
    Public Property Max As Long
        Get
            Return _Max
        End Get
        Set(value As Long)
            _Max = value

            Invalidate()
        End Set
    End Property

    <DefaultValue(True)> _
    Public Property ShowPercentage As Boolean
        Get
            Return _ShowPercentage
        End Get
        Set(value As Boolean)
            _ShowPercentage = value

            Invalidate()
        End Set
    End Property

    <DefaultValue(True)> _
    Public Property ShowGradientCenter As Boolean
        Get
            Return _ShowGradientCenter
        End Get
        Set(value As Boolean)
            _ShowGradientCenter = value

            Invalidate()
        End Set
    End Property

    Public Property GradientColorStart As Color
        Get
            Return _ColorStart
        End Get
        Set(value As Color)
            _ColorStart = value

            Invalidate()
        End Set
    End Property

    Public Property GradientColorEnd As Color
        Get
            Return _ColorEnd
        End Get
        Set(value As Color)
            _ColorEnd = value

            Invalidate()
        End Set
    End Property

    Public Property CasingColor As Color
        Get
            Return _CasingColor
        End Get
        Set(value As Color)
            _CasingColor = value

            Invalidate()
        End Set
    End Property

    Public Property RoundProgressColor As Color
        Get
            Return _RoundProgressColor
        End Get
        Set(value As Color)
            _RoundProgressColor = value

            Invalidate()
        End Set
    End Property

#End Region

    Private Function SetProgress(Value As Long, Max As Long) As Long
        If Value <> 0 Then
            Return CLng(Round((Value * 360) / Max, 0))
        Else
            Return 0
        End If
    End Function

    Private Sub RoundProgress_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Pens
        Dim Pen As Pen = New Pen(_CasingColor, 4)
        Dim pen2 As Pen = New Pen(_RoundProgressColor, 9)
        Dim Pen3 As Pen = New Pen(_CasingColor, 7)

        'rectangles
        Dim Rect As Rectangle = New Rectangle(5, 5, Me.Width - 10, Me.Height - 10)
        Dim Rect2 As Rectangle = New Rectangle(11, 11, Me.Width - 22, Me.Height - 22)
        Dim Rect3 As Rectangle = New Rectangle(17, 17, Me.Width - 34, Me.Height - 34)
        Dim Rect4 As Rectangle = New Rectangle(11, 11, Me.Width - 22, Me.Height - 22)
        Dim Rect5 As Rectangle = New Rectangle(19, 19, Me.Width - 38, Me.Height - 38)
        Dim BaseRect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'gradient
        Dim Fill As New LinearGradientBrush(BaseRect, _ColorStart, _ColorEnd, LinearGradientMode.BackwardDiagonal)

        'text declarations
        Dim drawFont As New Font("Arial", 25, FontStyle.Bold)
        Dim DrawBrush As New SolidBrush(Color.Black)
        Dim stringFormat As New StringFormat()

        'draw quality 
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        'progress casing
        e.Graphics.DrawArc(Pen, Rect, SetProgress(_Value, _Max) + 10, SetProgress(_Value, _Max))
        e.Graphics.DrawArc(Pen3, Rect2, (SetProgress(_Value, _Max) + 10) - 360, SetProgress(_Value, _Max) - 360)
        e.Graphics.DrawArc(Pen, Rect3, SetProgress(_Value, _Max) + 10, SetProgress(_Value, _Max))

        'progress
        e.Graphics.DrawArc(pen2, Rect4, SetProgress(_Value, _Max) + 10, SetProgress(_Value, _Max))

        'center background
        If _ShowGradientCenter Then e.Graphics.FillEllipse(Fill, Rect5)

        If _ShowPercentage Then
            'text formatting
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center

            'calculate percentage
            Dim Perc As Integer = CInt(Int((_Value * 100) / _Max))

            'text
            e.Graphics.DrawString(Perc.ToString, drawFont, DrawBrush, New Rectangle(0, CInt(Me.Height / 3.5), Me.Width, CInt(Me.Height / 2)), stringFormat)
        End If
    End Sub

    Private Sub RoundProgress_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = Me.Height
    End Sub
End Class
