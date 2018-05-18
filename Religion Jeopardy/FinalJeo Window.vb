Public Class FinalJeoWindow_Form

    Dim intTimerCount As Integer = 0
    Dim intSeconds As Integer = 30
    Dim intTeamTry As Integer = -1

    Dim blnStartAnswers As Boolean = False


    Private Sub FinalJeo_Window_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer_Label.Text = "Get Ready!"
        Intro_Label.Visible = False
        FinalJeo_Label.Visible = False
        Timer_Label.Visible = True
        TeamTry_Label.Visible = False
        FinalJeoAnswer_TextBox.Visible = False
        Answer_Button.Visible = False

        Intro_Timer.Enabled = True
    End Sub

    Private Sub FinalJeo_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalJeo_Timer.Tick
        FinalJeo_Timer.Interval = 1000
        intSeconds -= 1
        Timer_Label.Text = intSeconds & " second(s) remaining"


        If blnStartAnswers = True Then
            TeamTry_Label.Visible = True
            FinalJeoAnswer_TextBox.Visible = True
            Answer_Button.Visible = True
            TeamTry_Label.Text = "Team " & intTeamTry + 1 & ", please answer now!"
            If intSeconds <= 1 Then
                intTeamTry += 1
                intSeconds = 20
                FinalJeoAnswer_TextBox.Text = ""
                Do
                    intTeamTry += 1
                Loop While MainWindow_Form.aintTeamScores(intTeamTry) <= 0 And intTeamTry < 4
            End If
        ElseIf blnStartAnswers = False Then
            If intSeconds <= 1 Then
                blnStartAnswers = True
                intSeconds = 20
                Do
                    intTeamTry += 1
                Loop While MainWindow_Form.aintTeamScores(intTeamTry) <= 0 And intTeamTry < 4
            End If
        End If
        If intTeamTry >= 4 And intSeconds <= 0 Then
            FinalJeo_Timer.Enabled = False
            If String.Compare(MainWindow_Form.astrTeamAns(0), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(0), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(0) += MainWindow_Form.aintTeamWagers(0)
            Else
                MainWindow_Form.aintTeamScores(0) -= MainWindow_Form.aintTeamWagers(0)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(1), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(1), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(1) += MainWindow_Form.aintTeamWagers(1)
            Else
                MainWindow_Form.aintTeamScores(1) -= MainWindow_Form.aintTeamWagers(1)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(2), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(2), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(2) += MainWindow_Form.aintTeamWagers(2)
            Else
                MainWindow_Form.aintTeamScores(2) -= MainWindow_Form.aintTeamWagers(2)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(3), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(3), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(3) += MainWindow_Form.aintTeamWagers(3)
            Else
                MainWindow_Form.aintTeamScores(3) -= MainWindow_Form.aintTeamWagers(3)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(4), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(4), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(4) += MainWindow_Form.aintTeamWagers(4)
            Else
                MainWindow_Form.aintTeamScores(4) -= MainWindow_Form.aintTeamWagers(4)
            End If
            Close()
        End If
    End Sub

    Private Sub Intro_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Intro_Timer.Tick
        intTimerCount += 1
        If intTimerCount = 1 Then
            Timer_Label.Text = "3"
        ElseIf intTimerCount = 2 Then
            Timer_Label.Text = "2"
        ElseIf intTimerCount = 3 Then
            Timer_Label.Text = "1"
        ElseIf intTimerCount = 4 Then
            Timer_Label.Text = ""
            Intro_Label.Visible = True
            Intro_Timer.Interval = 2500
        ElseIf intTimerCount = 5 Then
            FinalJeo_Label.Visible = True
        ElseIf intTimerCount = 6 Then
            Timer_Label.Visible = True
            My.Computer.Audio.Play(My.Resources.Think_Music, AudioPlayMode.BackgroundLoop)
            FinalJeo_Timer.Enabled = True

            Intro_Timer.Enabled = False
        End If
    End Sub

    Private Sub Answer_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer_Button.Click
        MainWindow_Form.astrTeamAns(intTeamTry) = FinalJeoAnswer_TextBox.Text
        intSeconds = 20
        FinalJeoAnswer_TextBox.Text = ""
        Do
            intTeamTry += 1
        Loop While MainWindow_Form.aintTeamScores(intTeamTry) <= 0 And intTeamTry < 4
        TeamTry_Label.Text = "Team " & intTeamTry + 1 & ", please answer now!"
        If intTeamTry >= 4 Then
            FinalJeo_Timer.Enabled = False
            If String.Compare(MainWindow_Form.astrTeamAns(0), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(0), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(0) += MainWindow_Form.aintTeamWagers(0)
            Else
                MainWindow_Form.aintTeamScores(0) -= MainWindow_Form.aintTeamWagers(0)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(1), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(1), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(1) += MainWindow_Form.aintTeamWagers(1)
            Else
                MainWindow_Form.aintTeamScores(1) -= MainWindow_Form.aintTeamWagers(1)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(2), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(2), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(2) += MainWindow_Form.aintTeamWagers(2)
            Else
                MainWindow_Form.aintTeamScores(2) -= MainWindow_Form.aintTeamWagers(2)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(3), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(3), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(3) += MainWindow_Form.aintTeamWagers(3)
            Else
                MainWindow_Form.aintTeamScores(3) -= MainWindow_Form.aintTeamWagers(3)
            End If
            If String.Compare(MainWindow_Form.astrTeamAns(4), "Science", True) = 0 Or String.Compare(MainWindow_Form.astrTeamAns(4), "Scientists", True) = 0 Then
                MainWindow_Form.aintTeamScores(4) += MainWindow_Form.aintTeamWagers(4)
            Else
                MainWindow_Form.aintTeamScores(4) -= MainWindow_Form.aintTeamWagers(4)
            End If
            Close()
        End If
    End Sub
End Class