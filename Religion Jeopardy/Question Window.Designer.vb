<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionWindow_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Display_Label = New System.Windows.Forms.Label
        Me.Question_Label = New System.Windows.Forms.Label
        Me.A_RadioButton = New System.Windows.Forms.RadioButton
        Me.MultChoice_GroupBox = New System.Windows.Forms.GroupBox
        Me.D_RadioButton = New System.Windows.Forms.RadioButton
        Me.C_RadioButton = New System.Windows.Forms.RadioButton
        Me.B_RadioButton = New System.Windows.Forms.RadioButton
        Me.TrueFalse_GroupBox = New System.Windows.Forms.GroupBox
        Me.False_RadioButton = New System.Windows.Forms.RadioButton
        Me.True_RadioButton = New System.Windows.Forms.RadioButton
        Me.ShortAns_TextBox = New System.Windows.Forms.TextBox
        Me.Timer_Label = New System.Windows.Forms.Label
        Me.TimerDisplay_Label = New System.Windows.Forms.Label
        Me.Timer_ProgressBar = New System.Windows.Forms.ProgressBar
        Me.Answer_Button = New System.Windows.Forms.Button
        Me.Hurry_Label = New System.Windows.Forms.Label
        Me.Question_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Hurry_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Team1Try_Button = New System.Windows.Forms.Button
        Me.Try_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Team2Try_Button = New System.Windows.Forms.Button
        Me.Team3Try_Button = New System.Windows.Forms.Button
        Me.Team4Try_Button = New System.Windows.Forms.Button
        Me.Team5Try_Button = New System.Windows.Forms.Button
        Me.TeamTry_Label = New System.Windows.Forms.Label
        Me.MultChoice_GroupBox.SuspendLayout()
        Me.TrueFalse_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Display_Label
        '
        Me.Display_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display_Label.ForeColor = System.Drawing.Color.White
        Me.Display_Label.Location = New System.Drawing.Point(12, 9)
        Me.Display_Label.Name = "Display_Label"
        Me.Display_Label.Size = New System.Drawing.Size(690, 47)
        Me.Display_Label.TabIndex = 0
        Me.Display_Label.Text = "Your Question for <Religion> for <Points> points is..."
        '
        'Question_Label
        '
        Me.Question_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_Label.ForeColor = System.Drawing.Color.White
        Me.Question_Label.Location = New System.Drawing.Point(12, 45)
        Me.Question_Label.Name = "Question_Label"
        Me.Question_Label.Size = New System.Drawing.Size(685, 56)
        Me.Question_Label.TabIndex = 1
        Me.Question_Label.Text = "<The Question>"
        Me.Question_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A_RadioButton
        '
        Me.A_RadioButton.AutoSize = True
        Me.A_RadioButton.Checked = True
        Me.A_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.A_RadioButton.Location = New System.Drawing.Point(6, 19)
        Me.A_RadioButton.Name = "A_RadioButton"
        Me.A_RadioButton.Size = New System.Drawing.Size(42, 20)
        Me.A_RadioButton.TabIndex = 2
        Me.A_RadioButton.TabStop = True
        Me.A_RadioButton.Text = "A) "
        Me.A_RadioButton.UseVisualStyleBackColor = True
        '
        'MultChoice_GroupBox
        '
        Me.MultChoice_GroupBox.Controls.Add(Me.D_RadioButton)
        Me.MultChoice_GroupBox.Controls.Add(Me.C_RadioButton)
        Me.MultChoice_GroupBox.Controls.Add(Me.B_RadioButton)
        Me.MultChoice_GroupBox.Controls.Add(Me.A_RadioButton)
        Me.MultChoice_GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultChoice_GroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MultChoice_GroupBox.Location = New System.Drawing.Point(230, 115)
        Me.MultChoice_GroupBox.Name = "MultChoice_GroupBox"
        Me.MultChoice_GroupBox.Size = New System.Drawing.Size(257, 129)
        Me.MultChoice_GroupBox.TabIndex = 3
        Me.MultChoice_GroupBox.TabStop = False
        Me.MultChoice_GroupBox.Text = "Multiple Choice"
        Me.MultChoice_GroupBox.Visible = False
        '
        'D_RadioButton
        '
        Me.D_RadioButton.AutoSize = True
        Me.D_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_RadioButton.Location = New System.Drawing.Point(6, 97)
        Me.D_RadioButton.Name = "D_RadioButton"
        Me.D_RadioButton.Size = New System.Drawing.Size(43, 20)
        Me.D_RadioButton.TabIndex = 5
        Me.D_RadioButton.Text = "D) "
        Me.D_RadioButton.UseVisualStyleBackColor = True
        '
        'C_RadioButton
        '
        Me.C_RadioButton.AutoSize = True
        Me.C_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_RadioButton.Location = New System.Drawing.Point(6, 71)
        Me.C_RadioButton.Name = "C_RadioButton"
        Me.C_RadioButton.Size = New System.Drawing.Size(42, 20)
        Me.C_RadioButton.TabIndex = 4
        Me.C_RadioButton.Text = "C) "
        Me.C_RadioButton.UseVisualStyleBackColor = True
        '
        'B_RadioButton
        '
        Me.B_RadioButton.AutoSize = True
        Me.B_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B_RadioButton.Location = New System.Drawing.Point(6, 45)
        Me.B_RadioButton.Name = "B_RadioButton"
        Me.B_RadioButton.Size = New System.Drawing.Size(42, 20)
        Me.B_RadioButton.TabIndex = 3
        Me.B_RadioButton.Text = "B) "
        Me.B_RadioButton.UseVisualStyleBackColor = True
        '
        'TrueFalse_GroupBox
        '
        Me.TrueFalse_GroupBox.Controls.Add(Me.False_RadioButton)
        Me.TrueFalse_GroupBox.Controls.Add(Me.True_RadioButton)
        Me.TrueFalse_GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrueFalse_GroupBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TrueFalse_GroupBox.Location = New System.Drawing.Point(224, 126)
        Me.TrueFalse_GroupBox.Name = "TrueFalse_GroupBox"
        Me.TrueFalse_GroupBox.Size = New System.Drawing.Size(257, 80)
        Me.TrueFalse_GroupBox.TabIndex = 5
        Me.TrueFalse_GroupBox.TabStop = False
        Me.TrueFalse_GroupBox.Text = "True or False"
        Me.TrueFalse_GroupBox.Visible = False
        '
        'False_RadioButton
        '
        Me.False_RadioButton.AutoSize = True
        Me.False_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.False_RadioButton.Location = New System.Drawing.Point(6, 45)
        Me.False_RadioButton.Name = "False_RadioButton"
        Me.False_RadioButton.Size = New System.Drawing.Size(60, 20)
        Me.False_RadioButton.TabIndex = 3
        Me.False_RadioButton.Text = "False"
        Me.False_RadioButton.UseVisualStyleBackColor = True
        '
        'True_RadioButton
        '
        Me.True_RadioButton.AutoSize = True
        Me.True_RadioButton.Checked = True
        Me.True_RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.True_RadioButton.Location = New System.Drawing.Point(6, 19)
        Me.True_RadioButton.Name = "True_RadioButton"
        Me.True_RadioButton.Size = New System.Drawing.Size(54, 20)
        Me.True_RadioButton.TabIndex = 2
        Me.True_RadioButton.TabStop = True
        Me.True_RadioButton.Text = "True"
        Me.True_RadioButton.UseVisualStyleBackColor = True
        '
        'ShortAns_TextBox
        '
        Me.ShortAns_TextBox.Location = New System.Drawing.Point(208, 92)
        Me.ShortAns_TextBox.Multiline = True
        Me.ShortAns_TextBox.Name = "ShortAns_TextBox"
        Me.ShortAns_TextBox.Size = New System.Drawing.Size(279, 28)
        Me.ShortAns_TextBox.TabIndex = 10
        Me.ShortAns_TextBox.Visible = False
        '
        'Timer_Label
        '
        Me.Timer_Label.AutoSize = True
        Me.Timer_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_Label.ForeColor = System.Drawing.Color.White
        Me.Timer_Label.Location = New System.Drawing.Point(82, 149)
        Me.Timer_Label.Name = "Timer_Label"
        Me.Timer_Label.Size = New System.Drawing.Size(44, 31)
        Me.Timer_Label.TabIndex = 6
        Me.Timer_Label.Text = "20"
        '
        'TimerDisplay_Label
        '
        Me.TimerDisplay_Label.AutoSize = True
        Me.TimerDisplay_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerDisplay_Label.ForeColor = System.Drawing.Color.White
        Me.TimerDisplay_Label.Location = New System.Drawing.Point(37, 186)
        Me.TimerDisplay_Label.Name = "TimerDisplay_Label"
        Me.TimerDisplay_Label.Size = New System.Drawing.Size(137, 24)
        Me.TimerDisplay_Label.TabIndex = 7
        Me.TimerDisplay_Label.Text = "second(s) left..."
        '
        'Timer_ProgressBar
        '
        Me.Timer_ProgressBar.Location = New System.Drawing.Point(506, 160)
        Me.Timer_ProgressBar.Maximum = 20
        Me.Timer_ProgressBar.Name = "Timer_ProgressBar"
        Me.Timer_ProgressBar.Size = New System.Drawing.Size(186, 23)
        Me.Timer_ProgressBar.TabIndex = 8
        Me.Timer_ProgressBar.Value = 20
        '
        'Answer_Button
        '
        Me.Answer_Button.BackColor = System.Drawing.Color.White
        Me.Answer_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer_Button.Location = New System.Drawing.Point(617, 288)
        Me.Answer_Button.Name = "Answer_Button"
        Me.Answer_Button.Size = New System.Drawing.Size(75, 47)
        Me.Answer_Button.TabIndex = 9
        Me.Answer_Button.Text = "Answer It!"
        Me.Answer_Button.UseVisualStyleBackColor = False
        '
        'Hurry_Label
        '
        Me.Hurry_Label.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hurry_Label.ForeColor = System.Drawing.Color.White
        Me.Hurry_Label.Location = New System.Drawing.Point(493, 196)
        Me.Hurry_Label.Name = "Hurry_Label"
        Me.Hurry_Label.Size = New System.Drawing.Size(209, 73)
        Me.Hurry_Label.TabIndex = 11
        Me.Hurry_Label.Text = "HURRY~!"
        Me.Hurry_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Question_Timer
        '
        Me.Question_Timer.Interval = 2000
        '
        'Hurry_Timer
        '
        Me.Hurry_Timer.Interval = 500
        '
        'Team1Try_Button
        '
        Me.Team1Try_Button.BackColor = System.Drawing.Color.DarkCyan
        Me.Team1Try_Button.Location = New System.Drawing.Point(177, 289)
        Me.Team1Try_Button.Name = "Team1Try_Button"
        Me.Team1Try_Button.Size = New System.Drawing.Size(66, 47)
        Me.Team1Try_Button.TabIndex = 12
        Me.Team1Try_Button.Text = "Team 1"
        Me.Team1Try_Button.UseVisualStyleBackColor = False
        Me.Team1Try_Button.Visible = False
        '
        'Try_Timer
        '
        Me.Try_Timer.Interval = 1000
        '
        'Team2Try_Button
        '
        Me.Team2Try_Button.BackColor = System.Drawing.Color.DarkCyan
        Me.Team2Try_Button.Location = New System.Drawing.Point(249, 289)
        Me.Team2Try_Button.Name = "Team2Try_Button"
        Me.Team2Try_Button.Size = New System.Drawing.Size(66, 47)
        Me.Team2Try_Button.TabIndex = 13
        Me.Team2Try_Button.Text = "Team 2"
        Me.Team2Try_Button.UseVisualStyleBackColor = False
        Me.Team2Try_Button.Visible = False
        '
        'Team3Try_Button
        '
        Me.Team3Try_Button.BackColor = System.Drawing.Color.DarkCyan
        Me.Team3Try_Button.Location = New System.Drawing.Point(321, 289)
        Me.Team3Try_Button.Name = "Team3Try_Button"
        Me.Team3Try_Button.Size = New System.Drawing.Size(66, 47)
        Me.Team3Try_Button.TabIndex = 14
        Me.Team3Try_Button.Text = "Team 3"
        Me.Team3Try_Button.UseVisualStyleBackColor = False
        Me.Team3Try_Button.Visible = False
        '
        'Team4Try_Button
        '
        Me.Team4Try_Button.BackColor = System.Drawing.Color.DarkCyan
        Me.Team4Try_Button.Location = New System.Drawing.Point(393, 289)
        Me.Team4Try_Button.Name = "Team4Try_Button"
        Me.Team4Try_Button.Size = New System.Drawing.Size(66, 47)
        Me.Team4Try_Button.TabIndex = 15
        Me.Team4Try_Button.Text = "Team 4"
        Me.Team4Try_Button.UseVisualStyleBackColor = False
        Me.Team4Try_Button.Visible = False
        '
        'Team5Try_Button
        '
        Me.Team5Try_Button.BackColor = System.Drawing.Color.DarkCyan
        Me.Team5Try_Button.Location = New System.Drawing.Point(465, 289)
        Me.Team5Try_Button.Name = "Team5Try_Button"
        Me.Team5Try_Button.Size = New System.Drawing.Size(66, 47)
        Me.Team5Try_Button.TabIndex = 16
        Me.Team5Try_Button.Text = "Team 5"
        Me.Team5Try_Button.UseVisualStyleBackColor = False
        Me.Team5Try_Button.Visible = False
        '
        'TeamTry_Label
        '
        Me.TeamTry_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamTry_Label.ForeColor = System.Drawing.Color.White
        Me.TeamTry_Label.Location = New System.Drawing.Point(227, 247)
        Me.TeamTry_Label.Name = "TeamTry_Label"
        Me.TeamTry_Label.Size = New System.Drawing.Size(260, 23)
        Me.TeamTry_Label.TabIndex = 17
        Me.TeamTry_Label.Text = "What is your answer <team>?"
        Me.TeamTry_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuestionWindow_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(706, 347)
        Me.Controls.Add(Me.ShortAns_TextBox)
        Me.Controls.Add(Me.TeamTry_Label)
        Me.Controls.Add(Me.Team5Try_Button)
        Me.Controls.Add(Me.Team4Try_Button)
        Me.Controls.Add(Me.Team3Try_Button)
        Me.Controls.Add(Me.TrueFalse_GroupBox)
        Me.Controls.Add(Me.Team2Try_Button)
        Me.Controls.Add(Me.Team1Try_Button)
        Me.Controls.Add(Me.Hurry_Label)
        Me.Controls.Add(Me.Answer_Button)
        Me.Controls.Add(Me.Timer_ProgressBar)
        Me.Controls.Add(Me.TimerDisplay_Label)
        Me.Controls.Add(Me.Timer_Label)
        Me.Controls.Add(Me.MultChoice_GroupBox)
        Me.Controls.Add(Me.Question_Label)
        Me.Controls.Add(Me.Display_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "QuestionWindow_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question Window"
        Me.TopMost = True
        Me.MultChoice_GroupBox.ResumeLayout(False)
        Me.MultChoice_GroupBox.PerformLayout()
        Me.TrueFalse_GroupBox.ResumeLayout(False)
        Me.TrueFalse_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Display_Label As System.Windows.Forms.Label
    Friend WithEvents Question_Label As System.Windows.Forms.Label
    Friend WithEvents A_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MultChoice_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents D_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents C_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents B_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TrueFalse_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents False_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents True_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Timer_Label As System.Windows.Forms.Label
    Friend WithEvents TimerDisplay_Label As System.Windows.Forms.Label
    Friend WithEvents Timer_ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Answer_Button As System.Windows.Forms.Button
    Friend WithEvents ShortAns_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hurry_Label As System.Windows.Forms.Label
    Friend WithEvents Question_Timer As System.Windows.Forms.Timer
    Friend WithEvents Hurry_Timer As System.Windows.Forms.Timer
    Friend WithEvents Team1Try_Button As System.Windows.Forms.Button
    Friend WithEvents Try_Timer As System.Windows.Forms.Timer
    Friend WithEvents Team2Try_Button As System.Windows.Forms.Button
    Friend WithEvents Team3Try_Button As System.Windows.Forms.Button
    Friend WithEvents Team4Try_Button As System.Windows.Forms.Button
    Friend WithEvents Team5Try_Button As System.Windows.Forms.Button
    Friend WithEvents TeamTry_Label As System.Windows.Forms.Label
End Class
