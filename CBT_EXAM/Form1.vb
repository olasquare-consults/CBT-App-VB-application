Public Class Homepage
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim enteredID = Trim(UsernamTxt.Text)
        Dim enteredPass = Trim(passwordTxt.Text)
        Dim password = Trim(My.Settings.password)
        Dim adminId = Trim(My.Settings.adminUser)
        Dim adminpassword = Trim(My.Settings.adminPass)

        If enteredID.Length = 0 Or enteredPass.Length = 0 Then
            MsgBox("Please enter both username and password")
        Else
            If enteredID = adminId Then
                If enteredPass = adminpassword Then
                    Me.Hide()
                    AdminPage.Show()
                Else
                    MsgBox("Oops!.. Login credentials is incorrect", MsgBoxStyle.Critical)
                End If
            ElseIf password = enteredPass Then
                My.Settings.username = enteredID
                My.Settings.Save()
                Me.Hide()
                Landpage.Show()
            Else
                MsgBox("Oops!.. Login credentials is incorrect", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = MsgBox("You are about to close the Application, do you want to proceed to close?", MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
