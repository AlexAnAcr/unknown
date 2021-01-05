Public Class Booster
    Private Sub Booster_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Label3.Text = "Сканирование:"
        If Main.boost = 300 Then
            If ListBox1.Items.Count = 0 Then
                Dim r As New Random
                ProgressBar1.Value = 1
                For i As Integer = 0 To r.Next(Main.ListBox1.Items.Count)
                    If r.Next(8) = 3 Then
                        ListBox1.Items.Add(Main.ListBox1.Items.Item(i))
                    End If
                Next
                ProgressBar1.Value = 10
            End If
        Else
            ProgressBar1.Value = 10
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Main.boost = 300 Then
            ProgressBar1.Value = 0
            Label3.Text = "Остановка:"
            ListBox1.Items.Clear()
            Main.boost = 0
            Main.BC.Start()
            ProgressBar1.Value = 10
        End If
    End Sub
End Class
