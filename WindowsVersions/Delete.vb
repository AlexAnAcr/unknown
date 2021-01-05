Public Class Delete
    Private Sub Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Main.ListBox1.SelectedItem
        RadioButton1.Checked = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Dim r As New Random
            If r.Next(4) = 1 Then
                Main.ListBox1.Items.RemoveAt(Main.ListBox1.SelectedIndex)
                Array.Resize(Main.file, Main.file.Length - 1)
                For i As Integer = 0 To Main.ListBox1.Items.Count - 1
                    Main.file(i) = Main.ListBox1.Items.Item(i)
                Next
                IO.File.WriteAllLines(Application.StartupPath + "\file.cmf", Main.file)
                Me.Close()
            Else
                MsgBox("Нет доступа к компоненту!", , "Ошибка")
            End If
        Else
            Dim r As New Random
            If r.Next(8) = 4 Then
                Main.ListBox1.Items.RemoveAt(Main.ListBox1.SelectedIndex)
                Array.Resize(Main.file, Main.file.Length - 1)
                For i As Integer = 0 To Main.ListBox1.Items.Count - 1
                    Main.file(i) = Main.ListBox1.Items.Item(i)
                Next
                IO.File.WriteAllLines(Application.StartupPath + "\file.cmf", Main.file)
                Me.Close()
            Else
                MsgBox("Нет доступа к компоненту! Попробуйте изменить режим удаления.", , "Ошибка")
            End If
        End If
    End Sub
End Class
