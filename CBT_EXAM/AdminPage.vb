Public Class AdminPage
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim min = Trim(MinLb.Text)
        Dim sec = Trim(MinLb.Text)
        If min.Length = 0 Or sec.Length = 0 Then
            MsgBox("Please enter both Minutes and Seconds", MsgBoxStyle.Information)
        Else
            My.Settings.minutes = MinLb.Text
            My.Settings.seconds = secLB.Text
            My.Settings.Save()
            MsgBox("Exam Duration set sucessful", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = setDuration
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = update
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim username = Trim(UsernamTxt.Text)
        Dim password = Trim(passwordTxt.Text)
        If username.Length <> 0 Or password.Length <> 0 Then
            My.Settings.adminUser = username
            My.Settings.adminPass = password
            My.Settings.Save()
            MsgBox("Profile Update Succesful", MsgBoxStyle.Information)
        Else
            MsgBox("Please filled both fields", MsgBoxStyle.Critical)
        End If
    End Sub
End Class