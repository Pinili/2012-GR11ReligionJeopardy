Public Class StartupWindow_Form

    Private Sub Timer_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_CheckBox.CheckedChanged
        If Timer_CheckBox.Checked = True Then
            Seconds_NumUpDown.Visible = True
            Seconds_Label.Visible = True
        Else
            Seconds_NumUpDown.Visible = False
            Seconds_Label.Visible = False
        End If
    End Sub

    Private Sub Start_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Button.Click
        MainWindow_Form.Show()
        MainWindow_Form.intNumOfTeams = Teams_NumUpDown.Value
        If Timer_CheckBox.Checked = True Then MainWindow_Form.blnTimerEnabled = True
        If Timer_CheckBox.Checked = False Then MainWindow_Form.blnTimerEnabled = False
        MainWindow_Form.intTimerSeconds = Seconds_NumUpDown.Value
        Me.Close()
    End Sub
End Class