Public Class AnswerWindow_Form

    Private Sub AnswerWindow_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Default Display
        Answer_Label.Visible = False
        Back_Button.Visible = False
        Display_Button.Visible = True

        If MainWindow_Form.intNumOfTeams >= 1 Then
            Team1Correct_Button.Visible = True
            Team1Wrong_Button.Visible = True
            Team1Points_Label.Visible = True
            Team1Points_Label.Text = MainWindow_Form.aintTeamScores(0)
        End If
        If MainWindow_Form.intNumOfTeams >= 2 Then
            Team2Correct_Button.Visible = True
            Team2Wrong_Button.Visible = True
            Team2Points_Label.Visible = True
            Team2Points_Label.Text = MainWindow_Form.aintTeamScores(1)
        End If
        If MainWindow_Form.intNumOfTeams >= 3 Then
            Team3Correct_Button.Visible = True
            Team3Wrong_Button.Visible = True
            Team3Points_Label.Visible = True
            Team3Points_Label.Text = MainWindow_Form.aintTeamScores(2)
        End If
        If MainWindow_Form.intNumOfTeams >= 4 Then
            Team4Correct_Button.Visible = True
            Team4Wrong_Button.Visible = True
            Team4Points_Label.Visible = True
            Team4Points_Label.Text = MainWindow_Form.aintTeamScores(3)
        End If
        If MainWindow_Form.intNumOfTeams >= 5 Then
            Team5Correct_Button.Visible = True
            Team5Wrong_Button.Visible = True
            Team5Points_Label.Visible = True
            Team5Points_Label.Text = MainWindow_Form.aintTeamScores(4)
        End If
    End Sub

    Private Sub Display_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display_Button.Click
        Display_Button.Visible = False
        If MainWindow_Form.strTypeAnswer = "MC" Then
            Dim strMCAns() As String = MainWindow_Form.strPossAnswer.Split("|"c)
            If MainWindow_Form.strAnswer = "A" Then Answer_Label.Text = "A) " & strMCAns(0)
            If MainWindow_Form.strAnswer = "B" Then Answer_Label.Text = "B) " & strMCAns(1)
            If MainWindow_Form.strAnswer = "C" Then Answer_Label.Text = "C) " & strMCAns(2)
            If MainWindow_Form.strAnswer = "D" Then Answer_Label.Text = "D) " & strMCAns(3)
        ElseIf MainWindow_Form.strTypeAnswer = "TrueFalse" Then
            If MainWindow_Form.strAnswer = "A" Then Answer_Label.Text = "A) True"
            If MainWindow_Form.strAnswer = "B" Then Answer_Label.Text = "B) False"
        Else
            Answer_Label.Text = MainWindow_Form.strAnswer
        End If


        Answer_Label.Visible = True
        Back_Button.Visible = True
    End Sub

    Private Sub TeamsCorrect_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Team1Correct_Button.Click, Team2Correct_Button.Click, Team3Correct_Button.Click, Team4Correct_Button.Click, Team5Correct_Button.Click
        Dim intTeam As String = sender.name
        For i = 0 To 4
            If intTeam.Substring(4, 1) = i + 1 Then MainWindow_Form.aintTeamScores(i) += MainWindow_Form.intPoints
        Next
        UpdateScores() 'Updates Scores
    End Sub

    Private Sub TeamsWrong_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Team1Wrong_Button.Click, Team2Wrong_Button.Click, Team3Wrong_Button.Click, Team4Wrong_Button.Click, Team5Wrong_Button.Click
        Dim intTeam As String = sender.name
        For i = 0 To 4
            If intTeam.Substring(4, 1) = i + 1 Then MainWindow_Form.aintTeamScores(i) -= MainWindow_Form.intPoints
        Next
        UpdateScores() 'Updates Scores
    End Sub

    Private Sub UpdateScores()
        'Updates the scores after the scores have been changed
        Team1Points_Label.Text = MainWindow_Form.aintTeamScores(0)
        Team2Points_Label.Text = MainWindow_Form.aintTeamScores(1)
        Team3Points_Label.Text = MainWindow_Form.aintTeamScores(2)
        Team4Points_Label.Text = MainWindow_Form.aintTeamScores(3)
        Team5Points_Label.Text = MainWindow_Form.aintTeamScores(4)
    End Sub

    Private Sub Back_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back_Button.Click
        Close()
    End Sub
End Class