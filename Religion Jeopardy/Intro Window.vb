Public Class IntroWindow_Form

    Private Sub IntroWindow_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BGWindow_Form.Show()
        My.Computer.Audio.Play(My.Resources.this_is_jeopardy, AudioPlayMode.BackgroundLoop)
        Intro_Timer.Enabled = True
    End Sub

    Private Sub Intro_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Intro_Timer.Tick
        For i = 0.0 To 1.0 Step 0.05
            Me.Opacity = i
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next
        Me.Opacity = 100
        Me.Refresh()
        Intro_Timer.Interval = 3000
        If Intro_Timer.Interval = 3000 Then
            Intro_Timer.Enabled = False
            Intro_Label.Visible = True
        End If
    End Sub

    Private Sub Start_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Button.Click
        My.Computer.Audio.Stop()
        MainWindow_Form.Show()
        Me.Close()
    End Sub

    Private Sub Rules_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rules_Button.Click
        If Rules_Button.Text = "Rules" Then
            Rules_Button.Text = "Back"
            Rules_Label.Visible = True

            Intro_Label.Visible = False
            Jeoprady_PictureBox.Visible = False
            Start_Button.Visible = False
            Exit_Button.Visible = False
        Else
            Rules_Button.Text = "Rules"
            Rules_Label.Visible = False

            Intro_Label.Visible = True
            Jeoprady_PictureBox.Visible = True
            Start_Button.Visible = True
            Exit_Button.Visible = True
        End If
    End Sub

    Private Sub Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        End
    End Sub
End Class