Public Class Form1
    Dim Graph1 As Graphics
    Dim Pen1 As New Pen(Color.Red, 3)
    Dim Brush1 As New SolidBrush(Color.Black)
    Dim i As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Brush1.Color = Color.FromArgb(77, 35, 35)           ' Цвет дома
        Graph1.FillRectangle(Brush1, 417, 126, 266, 215)    ' Дом
        Brush1.Color = Color.FromArgb(41, 41, 41)           ' Цвет дороги
        Graph1.FillRectangle(Brush1, 0, 338, 800, 112)      ' Дорога
        Brush1.Color = Color.FromArgb(250, 232, 32)         ' SunColor
        Graph1.FillEllipse(Brush1, 25, 25, 125, 125)        ' Sun
        Brush1.Color = Color.FromArgb(240, 240, 240)
        Graph1.FillEllipse(Brush1, 186, 69, 143, 70)
        Graph1.FillEllipse(Brush1, 347, 12, 133, 85)
        Graph1.FillEllipse(Brush1, 662, 27, 126, 70)
        Brush1.Color = Color.FromArgb(31, 0, 0)
        Pen1.Color = Color.FromArgb(31, 0, 0)
        Pen1.Width = 15
        Graph1.DrawLine(Pen1, 417, 126, 546, 5)
        Graph1.DrawLine(Pen1, 546, 5, 680, 126)
        Brush1.Color = Color.FromArgb(31, 0, 0)
        Pen1.Width = 5
        Graph1.DrawEllipse(Pen1, 527, 69, 40, 40)
        Graph1.DrawLine(Pen1, 547, 69, 547, 112)
        Graph1.DrawLine(Pen1, 527, 90, 570, 90)
        Graph1.FillRectangle(Brush1, 646, 56, 34, 50)
        Graph1.FillRectangle(Brush1, 665, 56, 15, 65)
        Pen1.Color = Color.FromArgb(255, 255, 255)
        Graph1.DrawLine(Pen1, 662, 12, 662, 47)
        Graph1.DrawLine(Pen1, 682, 12, 662, 50)
        Graph1.DrawLine(Pen1, 642, 12, 662, 47)
        Pen1.Color = Color.FromArgb(126, 222, 62)
        Pen1.Width = 10
        Graph1.DrawLine(Pen1, 0, 337, 800, 337)
        Pen1.Color = Color.FromArgb(0, 0, 0)
        Pen1.Width = 5
        Brush1.Color = Color.FromArgb(0, 0, 0)
        Graph1.FillEllipse(Brush1, 25, 206, 54, 54)
        Brush1.Color = Color.FromArgb(255, 255, 255)
        Graph1.FillEllipse(Brush1, 35, 220, 15, 15)
        Graph1.FillEllipse(Brush1, 53, 220, 15, 15)
        Graph1.DrawLine(Pen1, 50, 260, 50, 295)
        Graph1.DrawLine(Pen1, 50, 260, 65, 295)
        Graph1.DrawLine(Pen1, 50, 260, 35, 295)
        Graph1.DrawLine(Pen1, 50, 294, 65, 330)
        Graph1.DrawLine(Pen1, 50, 294, 35, 330)
        '----------------------------------------'
        Graph1.FillRectangle(Brush1, 442, 183, 77, 150)
        Brush1.Color = Color.FromArgb(0, 0, 0)
        Graph1.FillEllipse(Brush1, 496, 266, 19, 18)
        Brush1.Color = Color.FromArgb(31, 203, 222)
        Graph1.FillRectangle(Brush1, 547, 183, 106, 77)
        Pen1.Color = Color.FromArgb(0, 0, 0)
        Graph1.DrawLine(Pen1, 224, 37, 244, 59)
        Graph1.DrawLine(Pen1, 264, 37, 244, 59) ' 61, 112, 64

        Graph1.DrawLine(Pen1, 304, 27, 324, 49)
        Graph1.DrawLine(Pen1, 344, 27, 324, 49)

        Pen1.Color = Color.FromArgb(61, 112, 64)
        Graph1.DrawLine(Pen1, 735, 224, 735, 332)

        Pen1.Color = Color.FromArgb(126, 222, 62)
        Pen1.Width = 3
        For i = 10 To 10000 Step 10
            Graph1.DrawLine(Pen1, 0 + i, 338, 10 + i, 320)
        Next
        Pen1.Color = Color.FromArgb(54, 89, 51)
        Pen1.Width = 3
        For i = 10 To 70 Step 10
            Graph1.DrawLine(Pen1, 736, 230 + i, 716, 245 + i)
        Next

        For i = 10 To 70 Step 10
            Graph1.DrawLine(Pen1, 736, 230 + i, 756, 245 + i)
        Next

        Pen1.Width = 10
        Pen1.Color = Color.FromArgb(255, 255, 255)


    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Graph1 = Me.PictureBox1.CreateGraphics()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
