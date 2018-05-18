Public Class WinnerWindow_Form

    Dim intTimer As Integer = 0
    Dim intWinningTeam As Integer = 0
    Dim intScoreOfWinTeam As Integer

    Private Sub WinnerWindow_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Winner_Timer.Enabled = True

        My.Computer.Audio.Play(My.Resources.this_is_jeopardy, AudioPlayMode.Background)

        Dim intWinner, intWinnerOfPoints As Integer
        For i = 0 To MainWindow_Form.intNumOfTeams - 1
            For Each TeamScore In MainWindow_Form.aintTeamScores
                If MainWindow_Form.aintTeamScores(i) = TeamScore Then
                    If intWinnerOfPoints < TeamScore Then
                        intWinnerOfPoints = TeamScore 'Finds highes points
                        intWinner = i
                    End If
                End If
            Next
        Next

        Winner_Label.Text = "Team " & intWinner + 1
        Points_Label.Text = "with " & intWinnerOfPoints & " point(s)"
    End Sub

    Private Sub Winner_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Winner_Timer.Tick
        intTimer += 1
        If intTimer = 1 Then
            Title_Label.Visible = True
        ElseIf intTimer = 2 Then
            Winner_Label.Visible = True
        ElseIf intTimer = 3 Then
            Points_Label.Visible = True
        ElseIf intTimer = 4 Then
            Winner_Timer.Enabled = False
            Congrats_Label.Visible = True
        End If
    End Sub

    Private Sub Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        End 'Ends the game
    End Sub
End Class