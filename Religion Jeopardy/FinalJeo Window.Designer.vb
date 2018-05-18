<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalJeoWindow_Form
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
        Me.Intro_Label = New System.Windows.Forms.Label
        Me.FinalJeo_Label = New System.Windows.Forms.Label
        Me.FinalJeoAnswer_TextBox = New System.Windows.Forms.TextBox
        Me.TeamTry_Label = New System.Windows.Forms.Label
        Me.Answer_Button = New System.Windows.Forms.Button
        Me.Timer_Label = New System.Windows.Forms.Label
        Me.FinalJeo_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Intro_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Intro_Label
        '
        Me.Intro_Label.AutoSize = True
        Me.Intro_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Intro_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Intro_Label.Location = New System.Drawing.Point(12, 9)
        Me.Intro_Label.Name = "Intro_Label"
        Me.Intro_Label.Size = New System.Drawing.Size(316, 33)
        Me.Intro_Label.TabIndex = 0
        Me.Intro_Label.Text = "The Final Question is..."
        '
        'FinalJeo_Label
        '
        Me.FinalJeo_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalJeo_Label.ForeColor = System.Drawing.Color.Yellow
        Me.FinalJeo_Label.Location = New System.Drawing.Point(49, 72)
        Me.FinalJeo_Label.Name = "FinalJeo_Label"
        Me.FinalJeo_Label.Size = New System.Drawing.Size(629, 86)
        Me.FinalJeo_Label.TabIndex = 1
        Me.FinalJeo_Label.Text = "God created the world in 6 days(animals, plants, sky, light, etc)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "However, _____" & _
            "__ believes that the world became like that from natural forces, and gorillas tu" & _
            "rned into humans." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FinalJeoAnswer_TextBox
        '
        Me.FinalJeoAnswer_TextBox.Location = New System.Drawing.Point(223, 277)
        Me.FinalJeoAnswer_TextBox.Name = "FinalJeoAnswer_TextBox"
        Me.FinalJeoAnswer_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.FinalJeoAnswer_TextBox.Size = New System.Drawing.Size(245, 20)
        Me.FinalJeoAnswer_TextBox.TabIndex = 2
        '
        'TeamTry_Label
        '
        Me.TeamTry_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamTry_Label.Location = New System.Drawing.Point(190, 247)
        Me.TeamTry_Label.Name = "TeamTry_Label"
        Me.TeamTry_Label.Size = New System.Drawing.Size(314, 27)
        Me.TeamTry_Label.TabIndex = 3
        Me.TeamTry_Label.Text = "Team <Team>, please answer now!"
        Me.TeamTry_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Answer_Button
        '
        Me.Answer_Button.BackColor = System.Drawing.Color.White
        Me.Answer_Button.Location = New System.Drawing.Point(309, 303)
        Me.Answer_Button.Name = "Answer_Button"
        Me.Answer_Button.Size = New System.Drawing.Size(75, 23)
        Me.Answer_Button.TabIndex = 4
        Me.Answer_Button.Text = "Answer It"
        Me.Answer_Button.UseVisualStyleBackColor = False
        '
        'Timer_Label
        '
        Me.Timer_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_Label.Location = New System.Drawing.Point(144, 180)
        Me.Timer_Label.Name = "Timer_Label"
        Me.Timer_Label.Size = New System.Drawing.Size(417, 36)
        Me.Timer_Label.TabIndex = 5
        Me.Timer_Label.Text = "<Seconds> seconds remaining"
        Me.Timer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FinalJeo_Timer
        '
        Me.FinalJeo_Timer.Interval = 1000
        '
        'Intro_Timer
        '
        Me.Intro_Timer.Interval = 1000
        '
        'FinalJeoWindow_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(717, 381)
        Me.Controls.Add(Me.Timer_Label)
        Me.Controls.Add(Me.Answer_Button)
        Me.Controls.Add(Me.TeamTry_Label)
        Me.Controls.Add(Me.FinalJeoAnswer_TextBox)
        Me.Controls.Add(Me.FinalJeo_Label)
        Me.Controls.Add(Me.Intro_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FinalJeoWindow_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinalJeo_Window"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Intro_Label As System.Windows.Forms.Label
    Friend WithEvents FinalJeo_Label As System.Windows.Forms.Label
    Friend WithEvents FinalJeoAnswer_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeamTry_Label As System.Windows.Forms.Label
    Friend WithEvents Answer_Button As System.Windows.Forms.Button
    Friend WithEvents Timer_Label As System.Windows.Forms.Label
    Friend WithEvents FinalJeo_Timer As System.Windows.Forms.Timer
    Friend WithEvents Intro_Timer As System.Windows.Forms.Timer
End Class
