Public Class Java_kod
    Private Sub Java_kod_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Java_Progress1.Value = 0
        TextBox1.Enabled = True
        Button1.Enabled = True
        TextBox1.Text = My.Resources.Java_kod1
        JPB.Start()
    End Sub
    Private Sub JPB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JPB.Tick
        If Java_Progress1.Value = 128 Then
            JPB.Stop()
            PictureBox1.Visible = False
            Java_Progress1.Visible = False
            TextBox1.Visible = True
            Button1.Visible = True
            TextBox1.Enabled = True
            Button1.Enabled = True
        Else
            Java_Progress1.Value += 4
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Java_Progress1.Value = 0
        PictureBox1.Visible = True
        Java_Progress1.Visible = True
        TextBox1.Enabled = False
        Button1.Enabled = False
        JPB.Start()
    End Sub
End Class
