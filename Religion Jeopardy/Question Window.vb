Public Class QuestionWindow_Form

    Dim blnOtherTeamsTry As Boolean 'Checks if the other teams are answering the question, or if a specific team is.
    Dim blnTryTeamAnswer(MainWindow_Form.intNumOfTeams) As Boolean
    Dim intTeamAttempt As Integer
    Dim btnTeamTry As New List(Of Button)

    Private Sub QuestionWindow_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Question_Timer.Enabled = False
        Try_Timer.Enabled = False
    End Sub

    Private Sub QuestionWindow_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Adds all "Team Try" buttons to a list
        btnTeamTry.Add(Team1Try_Button)
        btnTeamTry.Add(Team2Try_Button)
        btnTeamTry.Add(Team3Try_Button)
        btnTeamTry.Add(Team4Try_Button)
        btnTeamTry.Add(Team5Try_Button)

        'Default Settings
        ShortAns_TextBox.Text = ""
        MultChoice_GroupBox.Visible = False
        TrueFalse_GroupBox.Visible = False
        ShortAns_TextBox.Visible = False

        Answer_Button.Visible = False
        TeamTry_Label.Visible = False
        Hurry_Label.Visible = False 'Hides Hurry_Label
        intTeamAttempt = MainWindow_Form.intCurTeam
        blnOtherTeamsTry = False
        For i = 0 To MainWindow_Form.intNumOfTeams - 1
            For Each TeamButton In btnTeamTry
                If TeamButton.Name.Substring(4, 1) = i + 1 Then TeamButton.Visible = True
            Next
        Next


        'Displays Question
        Display_Label.Text = "Your Question for " & MainWindow_Form.strReligion & " for " & MainWindow_Form.intPoints & " points is..."
        Question_Label.Text = MainWindow_Form.strQuestion
        If MainWindow_Form.strTypeAnswer = "MC" Then
            MultChoice_GroupBox.Visible = True
            'Displays Multiple Choice Questions
            Dim strMChoice() As String = MainWindow_Form.strPossAnswer.Split("|"c)
            A_RadioButton.Text = "A) " & strMChoice(0)
            B_RadioButton.Text = "B) " & strMChoice(1)
            C_RadioButton.Text = "C) " & strMChoice(2)
            D_RadioButton.Text = "D) " & strMChoice(3)
        ElseIf MainWindow_Form.strTypeAnswer = "TrueFalse" Then
            TrueFalse_GroupBox.Visible = True
            'Displays True or False Question
            True_RadioButton.Text = "A) True"
            False_RadioButton.Text = "B) False"
        ElseIf MainWindow_Form.strTypeAnswer = "ShortAns" Then
            'Display Short Answer
            ShortAns_TextBox.Visible = True
        End If

        'Configs Timer
        Timer_Label.Text = MainWindow_Form.intTimerSeconds
        Timer_ProgressBar.Maximum = MainWindow_Form.intTimerSeconds
        Timer_ProgressBar.Value = MainWindow_Form.intTimerSeconds
        If MainWindow_Form.strTypeAnswer = "ShortAns" Then
            Timer_Label.Text += 5
            Timer_ProgressBar.Maximum += 5
            Timer_ProgressBar.Value += 5
        End If

        Question_Timer.Enabled = True 'Enables the timer
        If MainWindow_Form.blnTimerEnabled = False Then 'Disables the timer due to user request
            Question_Timer.Enabled = False
            Timer_Label.Visible = False
            TimerDisplay_Label.Visible = False
            Timer_ProgressBar.Visible = False
        End If
    End Sub

    Private Sub Hurry_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hurry_Timer.Tick
        If Hurry_Label.Visible = False Then
            Hurry_Label.Visible = True
        ElseIf Hurry_Label.Visible = True Then
            Hurry_Label.Visible = False
        End If
    End Sub



    'The current team gets a certain amount of time to answer
    Private Sub Question_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Question_Timer.Tick
        Question_Timer.Interval = 1000
        Timer_ProgressBar.Value -= 1
        Timer_Label.Text -= 1
        Call WaitForTeams()
    End Sub


    'Similar to the Question Timer, but every other team gets a chance
    Private Sub Try_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Try_Timer.Tick
        Timer_ProgressBar.Value -= 1
        Timer_Label.Text -= 1
        If Timer_ProgressBar.Value <= Timer_ProgressBar.Minimum Then
            If MainWindow_Form.strTypeAnswer = "MC" Then
                MainWindow_Form.aintTeamScores(intTeamAttempt - 1) -= MainWindow_Form.intPoints 'Lose Points
                blnTryTeamAnswer(intTeamAttempt - 1) = True 'Lose their chance
                My.Computer.Audio.Play(My.Resources.Jeopardy_time, AudioPlayMode.Background) 'Plays "out of time"
                TeamTry_Label.Visible = False
                Hurry_Timer.Enabled = False
                Try_Timer.Enabled = False
                Timer_Label.Text = 8
                Timer_ProgressBar.Maximum = 8
                Timer_ProgressBar.Value = 8
                Question_Timer.Enabled = True

                Answer_Button.Visible = False
                Hurry_Timer.Enabled = False
                Hurry_Label.Text = "TIMES UP! Other teams may choose now!"
                Hurry_Label.Visible = True
                Call ShowOtherTeams()
            ElseIf MainWindow_Form.strTypeAnswer = "TrueFalse" Then
                MainWindow_Form.aintTeamScores(intTeamAttempt - 1) -= MainWindow_Form.intPoints 'Lose Points
                My.Computer.Audio.Play(My.Resources.Jeopardy_time, AudioPlayMode.Background) 'Plays "out of time"
                Hurry_Label.Text = "TIMES UP!"
                Hurry_Label.Visible = True
                Call GotoNextWindow()
            ElseIf MainWindow_Form.strTypeAnswer = "ShortAns" Then
                MainWindow_Form.aintTeamScores(intTeamAttempt - 1) -= MainWindow_Form.intPoints 'Lose Points
                blnTryTeamAnswer(intTeamAttempt - 1) = True 'Lose their chance
                My.Computer.Audio.Play(My.Resources.Jeopardy_time, AudioPlayMode.Background) 'Plays "out of time"
                TeamTry_Label.Visible = False
                Hurry_Timer.Enabled = False
                Try_Timer.Enabled = False
                Timer_Label.Text = 8
                Timer_ProgressBar.Maximum = 8
                Timer_ProgressBar.Value = 8
                Question_Timer.Enabled = True

                Answer_Button.Visible = False
                Hurry_Timer.Enabled = False
                Hurry_Label.Text = "TIMES UP! Other teams may choose now!"
                Hurry_Label.Visible = True
                Call ShowOtherTeams()
            End If
        End If
    End Sub



    'Checks if the team got it right or wrong
    Private Sub Answer_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer_Button.Click

        If MainWindow_Form.strTypeAnswer = "MC" Then
            Dim strMCAns() As String = MainWindow_Form.strPossAnswer.Split("|"c)
            If MainWindow_Form.strAnswer = "A" And A_RadioButton.Checked = False Or MainWindow_Form.strAnswer = "B" And B_RadioButton.Checked = False Or MainWindow_Form.strAnswer = "C" And C_RadioButton.Checked = False Or MainWindow_Form.strAnswer = "D" And D_RadioButton.Checked = False Then
                MainWindow_Form.aintTeamScores(intTeamAttempt - 1) -= MainWindow_Form.intPoints 'Lose Points
                blnTryTeamAnswer(intTeamAttempt - 1) = True 'Lose their chance
                My.Computer.Audio.Play(My.Resources.NOSORRY, AudioPlayMode.Background) 'Plays "wrong"
                TeamTry_Label.Visible = False
                Hurry_Timer.Enabled = False
                Try_Timer.Enabled = False
                Timer_Label.Text = 8
                Timer_ProgressBar.Maximum = 8
                Timer_ProgressBar.Value = 8
                Question_Timer.Enabled = True
                Answer_Button.Visible = False
                Hurry_Label.Text = "WRONG! Other teams may choose now!"
                Hurry_Label.Visible = True
                blnOtherTeamsTry = True
                Call ShowOtherTeams()
            Else 'If the current team answered correctly
                Call TeamIsCorrect()
            End If
        ElseIf MainWindow_Form.strTypeAnswer = "TrueFalse" Then
            If MainWindow_Form.strAnswer = "A" And True_RadioButton.Checked = False Or MainWindow_Form.strAnswer = "B" And False_RadioButton.Checked = False Then
                MainWindow_Form.aintTeamScores(intTeamAttempt - 1) -= MainWindow_Form.intPoints 'Lose Points
                My.Computer.Audio.Play(My.Resources.NOSORRY, AudioPlayMode.Background) 'Plays "wrong"
                Hurry_Label.Text = "Nope, that is incorrect!"
                Hurry_Label.Visible = True
                Call GotoNextWindow()
            Else 'If the current team answered correctly
                Call TeamIsCorrect()
            End If
        Else
            'Work on this (Short Answer Debugging)
            If Not String.Compare(MainWindow_Form.strAnswer, ShortAns_TextBox.Text, True) = 0 Then
                MainWindow_Form.aintTeamScores(intTeamAttempt - 1) -= MainWindow_Form.intPoints 'Lose Points
                blnTryTeamAnswer(intTeamAttempt - 1) = True 'Lose their chance
                My.Computer.Audio.Play(My.Resources.NOSORRY, AudioPlayMode.Background) 'Plays "wrong"
                TeamTry_Label.Visible = False
                Hurry_Timer.Enabled = False
                Try_Timer.Enabled = False
                Timer_Label.Text = 8
                Timer_ProgressBar.Maximum = 8
                Timer_ProgressBar.Value = 8
                Question_Timer.Enabled = True
                Answer_Button.Visible = False
                Hurry_Label.Text = "WRONG! Other teams may choose now!"
                Hurry_Label.Visible = True
                blnOtherTeamsTry = True
                Call ShowOtherTeams()
            Else 'If the current team answered correctly
                Call TeamIsCorrect()
            End If


        End If
    End Sub


    '--------------Special Methods

    Private Sub ShowOtherTeams()
        For i = 0 To MainWindow_Form.intNumOfTeams - 1
            For Each TeamButton In btnTeamTry
                If TeamButton.Name.Substring(4, 1) = i + 1 Then TeamButton.Visible = True
            Next
        Next
        For i = 0 To MainWindow_Form.intNumOfTeams - 1
            For Each TeamButton In btnTeamTry
                If blnTryTeamAnswer(i) = True Then
                    If TeamButton.Name.Substring(4, 1) = i + 1 Then
                        TeamButton.Visible = False
                    End If
                End If
            Next
        Next
        Dim intNumOfTeamsLeft As Integer = 0
        For Each TeamButton In btnTeamTry
            If TeamButton.Visible = True Then intNumOfTeamsLeft += 1
        Next
        If intNumOfTeamsLeft = 0 Then

            Call GotoNextWindow()
        End If
    End Sub

    Private Sub DisableTeams()
        For Each TeamButton In btnTeamTry
            TeamButton.Visible = False
        Next
    End Sub

    Private Sub TeamIsCorrect()
        MainWindow_Form.aintTeamScores(intTeamAttempt - 1) += MainWindow_Form.intPoints 'Gains Points
        MainWindow_Form.intCurTeam = intTeamAttempt 'The team that answered the question, is now the current team
        TeamTry_Label.Visible = False
        Question_Timer.Enabled = False
        Hurry_Timer.Enabled = False
        Hurry_Label.Text = "Correct!"
        Hurry_Label.Visible = True
        GotoNextWindow()
    End Sub

    Private Sub WaitForTeams()
        If Timer_ProgressBar.Value = 5 Then
            Hurry_Label.Text = "HURRY~!"
            Hurry_Timer.Enabled = True
        ElseIf Timer_ProgressBar.Value <= Timer_ProgressBar.Minimum Then
            My.Computer.Audio.Play(My.Resources.Jeopardy_time, AudioPlayMode.Background) 'Plays "out of time"
            Hurry_Timer.Enabled = False
            Hurry_Label.Text = "TIME IS UP!"
            Hurry_Label.Visible = True
            Question_Timer.Enabled = False
            Hurry_Timer.Enabled = False
            Call DisableTeams()
            Call GotoNextWindow()
        End If
    End Sub

    Private Sub GotoNextWindow()
        Question_Timer.Enabled = False
        Hurry_Timer.Enabled = False
        Try_Timer.Enabled = False
        Me.Refresh()
        Threading.Thread.Sleep(2500)

        For i = 0 To MainWindow_Form.intNumOfTeams - 1
            blnTryTeamAnswer(i) = False
        Next
        Close()
    End Sub

    '----------------------------



    



    Private Sub QuestionWindow_Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'For pushing a button to attempt question
        If e.KeyCode = Keys.A Then 'Team 1
            intTeamAttempt = 1
        ElseIf e.KeyCode = Keys.D Then 'Team 2
            intTeamAttempt = 2
        ElseIf e.KeyCode = Keys.G Then 'Team 3
            intTeamAttempt = 3
        ElseIf e.KeyCode = Keys.J Then 'Team 4
            intTeamAttempt = 4
        ElseIf e.KeyCode = Keys.L Then 'Team 5
            intTeamAttempt = 5
        End If
        TeamTry()
    End Sub

    Private Sub QuestionWindow_Form_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub TeamsTry_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Team1Try_Button.Click, Team2Try_Button.Click, Team3Try_Button.Click, Team4Try_Button.Click, Team5Try_Button.Click
        'For clicking the team try buttons
        Dim teambutton As String = sender.name
        intTeamAttempt = teambutton.Substring(4, 1)
        TeamTry()
    End Sub


    Private Sub TeamTry()
        'This is the main code for the team trying to answer the question
        TeamTry_Label.Visible = True
        TeamTry_Label.Text = "What is your answer Team " & intTeamAttempt & "?" 'Displays who is answering the question
        blnTryTeamAnswer(intTeamAttempt - 1) = True 'Lose their chance
        Answer_Button.Visible = True

        Hurry_Timer.Enabled = False
        Question_Timer.Enabled = False

        Timer_Label.Text = 8
        Timer_ProgressBar.Maximum = 8
        Timer_ProgressBar.Value = 8
        Try_Timer.Enabled = True

        Call DisableTeams()
    End Sub
End Class