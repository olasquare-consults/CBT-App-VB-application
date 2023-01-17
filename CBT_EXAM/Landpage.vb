Public Class Landpage
    Public score As Integer = 0
    Public writeExamCheck As Boolean = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = welcomeTab
    End Sub
    Public user As String
    Private Sub Landpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = My.Settings.username
        UserGreetingsLB.Text = "Hey " + user + " !"
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If writeExamCheck = False Then
            MsgBox("Hey!..Its look like you have not taking any Exam...Here is the record of last examiner")
            Dim lastScore = My.Settings.score
            Label10.Text = My.Settings.lastExaminer
            If lastScore = 0 Then
                Label1.Visible = True
            End If
            If lastScore < 10 Then
                scoreLB.Text = "0" & lastScore
            Else
                scoreLB.Text = lastScore
            End If
        Else
            Label10.Text = user
            If score = 0 Then
                Label1.Visible = True
            End If
            If score < 10 Then
                scoreLB.Text = "0" & score
            Else
                scoreLB.Text = score
            End If
        End If
        TabControl1.SelectedTab = scoreTab

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If writeExamCheck Then
            MsgBox("You can only take Exam once... Thanks!", MsgBoxStyle.Exclamation)
        Else
            Dim x = MsgBox("You are about to start exam, do you want to proceed to exam page ?", MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                Dashboard.Show()
                Me.Hide()
                writeExamCheck = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If writeExamCheck Then
            Dim x = MsgBox("Have you check your score and write it down, Do you want to proceed to logout ?", MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                Homepage.Show()
                Me.Close()
            End If
        Else
            Homepage.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateLB.Text = DateAndTime.Now.ToLongDateString
    End Sub
End Class