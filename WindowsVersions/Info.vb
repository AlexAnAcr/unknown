Public Class Info
    Dim random As New Random
    Dim random1 As New Random
    Private Sub Info_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "\Data\" + Main.ListBox1.SelectedItem + ".dat") = True Then
            Dim dat() As String = IO.File.ReadAllLines(Application.StartupPath + "\Data\" + Main.ListBox1.SelectedItem + ".dat")
            Label1.Text = "Влияние объекта на систему: " & dat(0) & "%"
            ProgressBar1.Value = dat(0)
            Label2.Text = "Доступ: " & dat(1) & "%"
            ProgressBar2.Value = dat(1)
            If dat(2) = 0 Then
                Label3.Text = "Использование: не используется"
            ElseIf dat(2) = 1 Then
                Label3.Text = "Использование: используется"
            ElseIf dat(2) = 2 Then
                Label3.Text = "Использование: используется"
            ElseIf dat(2) = 3 Then
                Label3.Text = "Использование: часто используется"
            ElseIf dat(2) = 4 Then
                Label3.Text = "Использование: часто используется"
            ElseIf dat(2) = 5 Then
                Label3.Text = "Использование: часто используется"
            End If
            If dat(3) = 0 Then
                Label6.Text = "Тип: сторонний"
            ElseIf dat(3) = 1 Then
                Label6.Text = "Тип: системный"
            ElseIf dat(3) = 2 Then
                Label6.Text = "Тип: системный"
            End If
        Else
            If Main.ListBox1.SelectedIndex > -1 Then
                Dim dat(3) As String
                Label4.Text = "Компонент: " & Main.ListBox1.SelectedItem
                Dim number As Integer = random.Next(0, 50)
                Label1.Text = "Влияние объекта на систему: " & number & "%"
                ProgressBar1.Value = number
                dat(0) = number
                number = random1.Next(0, 95)
                Label2.Text = "Доступ: " & number & "%"
                ProgressBar2.Value = number
                dat(1) = number
                number = random.Next(0, 6)
                dat(2) = number
                If number = 0 Then
                    Label3.Text = "Использование: не используется"
                ElseIf number = 1 Then
                    Label3.Text = "Использование: используется"
                ElseIf number = 2 Then
                    Label3.Text = "Использование: используется"
                ElseIf number = 3 Then
                    Label3.Text = "Использование: часто используется"
                ElseIf number = 4 Then
                    Label3.Text = "Использование: часто используется"
                ElseIf number = 5 Then
                    Label3.Text = "Использование: часто используется"
                End If
                number = random1.Next(0, 3)
                dat(3) = number
                If number = 0 Then
                    Label6.Text = "Тип: сторонний"
                ElseIf number = 1 Then
                    Label6.Text = "Тип: системный"
                ElseIf number = 2 Then
                    Label6.Text = "Тип: системный"
                End If
                IO.File.WriteAllLines(Application.StartupPath + "\Data\" + Main.ListBox1.SelectedItem + ".dat", dat)
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class