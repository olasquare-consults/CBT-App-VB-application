Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinLB.Text = My.Settings.minutes
        secLB.Text = My.Settings.seconds
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim x = MsgBox("You are about to start the exam!, Are you ready?", vbYesNo)
        If x = MsgBoxResult.Yes Then
            TabControl1.Visible = True
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        secLB.Text = Val(secLB.Text) - 1
        If Val(secLB.Text) < 10 Then
            secLB.Text = "0" & Val(secLB.Text)
        End If
        If Val(secLB.Text) = 0 Then
            MinLB.Text = Val(MinLB.Text) - 1
            secLB.Text = 60
        End If
        If Val(MinLB.Text) = 0 Then
            Timer1.Stop()
            Timer1.Enabled = False
            secLB.Text = 0
            MinLB.Text = 0
            MsgBox("Ooops time up... your exam has been recorded.. thanks")
            My.Settings.lastExaminer = Landpage.user
            My.Settings.score = getResult()
            My.Settings.Save()
            Landpage.writeExamCheck = True
            Landpage.Show()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Label1.Text = TabControl1.SelectedIndex.ToString() + 1
        answeredCheck()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Timer1.Enabled = True Then
            Dim x = MsgBox("You are about to submit,do you want to proceed to submit ?", MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                Landpage.score = getResult()
                Timer1.Enabled = False
                MinLB.Text = "0"
                secLB.Text = "0"
                My.Settings.lastExaminer = Landpage.user
                My.Settings.score = getResult()
                My.Settings.Save()
                Landpage.writeExamCheck = True
                Landpage.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (TabControl1.SelectedIndex >= 1 And TabControl1.SelectedIndex <> 0) Then
            TabControl1.SelectedIndex -= 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TabControl1.SelectedIndex <> 30) Then
            TabControl1.SelectedIndex += 1
        End If
    End Sub
End Class