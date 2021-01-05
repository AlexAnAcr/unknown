Public Class Java_Progress
    Dim v As UShort
    Public Property Value() As UShort
        Get
            Return v
        End Get
        Set(ByVal value As UShort)
            v = value
            If value <= 128 Then
                PictureBox1.CreateGraphics.Clear(Color.White)
                PictureBox1.CreateGraphics.FillRectangle(Brushes.DarkRed, 0, 0, value, 30)
            End If
        End Set
    End Property
End Class
