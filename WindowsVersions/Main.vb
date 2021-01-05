Public Class Main
    Public file() As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        file = IO.File.ReadAllLines(Application.StartupPath + "\file.cmf")
        For Each file1 As String In file
            ListBox1.Items.Add(file1)
        Next
    End Sub
    Private Sub Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "\file.cmf") <> True Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\file.cmf", "", False)
            Dim dat(0) As String
            Dim i As Integer = 1
            file = IO.Directory.GetFiles("C:\Windows\System32", "*.exe")
            For Each file1 As String In file
                Array.Resize(dat, i)
                dat(i - 1) = Mid(file1, file1.LastIndexOf("\") + 2, file1.Length - file1.LastIndexOf("\") - 5)
                i += 1
            Next
            IO.File.WriteAllLines(Application.StartupPath + "\file.cmf", dat)
        End If
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\Data") <> True Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\Data")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex > -1 Then
            Delete.ShowDialog()
        Else
            MsgBox("Java Edit can be called without a thorough item!", , "Error")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex > -1 Then
            Info.ShowDialog()
        Else
            MsgBox("Java Edit can be called without a thorough item!", , "Error")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox1.SelectedIndex > -1 Then
            Java_kod.Show()
        Else
            MsgBox("Java Edit can be called without a thorough item!", , "Error")
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ListBox1.Items.Count > 0 Then
            Booster.ShowDialog()
        Else
            MsgBox("Java Edit can be called without a thorough item!", , "Error")
        End If
    End Sub
    Public boost As Short = 300
    Private Sub BC_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BC.Tick
        If boost = 300 Then
            BC.Stop()
        Else
            boost += 1
        End If
    End Sub
End Class
