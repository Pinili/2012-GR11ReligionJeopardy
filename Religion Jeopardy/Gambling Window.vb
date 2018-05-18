Public Class Gambling_Window

    Private Sub Gambling_Window_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Team1_Label.Visible = False
        Team2_Label.Visible = False
        Team3_Label.Visible = False
        Team4_Label.Visible = False
        Team5_Label.Visible = False

        Wager1_TextBox.Visible = False
        Wager2_TextBox.Visible = False
        Wager3_TextBox.Visible = False
        Wager4_TextBox.Visible = False
        Wager5_TextBox.Visible = False

        If MainWindow_Form.intNumOfTeams >= 1 And MainWindow_Form.aintTeamScores(0) > 0 Then
            Team1_Label.Visible = True
            Wager1_TextBox.Visible = True
        End If
        If MainWindow_Form.intNumOfTeams >= 2 And MainWindow_Form.aintTeamScores(1) > 0 Then
            Team2_Label.Visible = True
            Wager2_TextBox.Visible = True
        End If
        If MainWindow_Form.intNumOfTeams >= 3 And MainWindow_Form.aintTeamScores(2) > 0 Then
            Team3_Label.Visible = True
            Wager3_TextBox.Visible = True
        End If
        If MainWindow_Form.intNumOfTeams >= 4 And MainWindow_Form.aintTeamScores(3) > 0 Then
            Team4_Label.Visible = True
            Wager4_TextBox.Visible = True
        End If
        If MainWindow_Form.intNumOfTeams >= 5 And MainWindow_Form.aintTeamScores(4) > 0 Then
            Team5_Label.Visible = True
            Wager5_TextBox.Visible = True
        End If
    End Sub

    Private Sub Begin_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Begin_Button.Click
        If Wager1_TextBox.Visible = True Then MainWindow_Form.aintTeamWagers(0) = Wager1_TextBox.Text
        If Wager2_TextBox.Visible = True Then MainWindow_Form.aintTeamWagers(1) = Wager2_TextBox.Text
        If Wager3_TextBox.Visible = True Then MainWindow_Form.aintTeamWagers(2) = Wager3_TextBox.Text
        If Wager4_TextBox.Visible = True Then MainWindow_Form.aintTeamWagers(3) = Wager4_TextBox.Text
        If Wager5_TextBox.Visible = True Then MainWindow_Form.aintTeamWagers(4) = Wager5_TextBox.Text
        Close()
    End Sub
End Class