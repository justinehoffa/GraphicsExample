Public Class GraphicsForm
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Click
        'DrawLine()
        'DrawCircle()
        'DrawRectangle()
        DrawString()
    End Sub

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, 0, 0, 150, 50)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.HotPink)
        g.DrawEllipse(pen, 50, 50, 300, 300)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim aBrush As SolidBrush = New SolidBrush(Color.SteelBlue)
        Dim pen As New Pen(Color.Black)
        g.DrawRectangle(pen, 50, 50, 200, 200)
        g.FillRectangle(aBrush, 50, 50, 200, 200)
        pen.Dispose()
        g.Dispose()
        aBrush.Dispose()
    End Sub

    Public Sub DrawString()
        Dim drawString As String = "Justine Hoffa"
        Dim y As Single = 50.0
        Dim x As Single = 150.0

        Dim g As Graphics = Me.CreateGraphics()
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim drawFormat As New StringFormat '???

        g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat)

        drawFont.Dispose()
        drawBrush.Dispose()
        g.Dispose()
    End Sub
End Class
