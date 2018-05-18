<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupWindow_Form
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Teams_NumUpDown = New System.Windows.Forms.NumericUpDown
        Me.Timer_CheckBox = New System.Windows.Forms.CheckBox
        Me.Seconds_NumUpDown = New System.Windows.Forms.NumericUpDown
        Me.Seconds_Label = New System.Windows.Forms.Label
        Me.Start_Button = New System.Windows.Forms.Button
        CType(Me.Teams_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Seconds_NumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number Of Teams:"
        '
        'Teams_NumUpDown
        '
        Me.Teams_NumUpDown.Location = New System.Drawing.Point(171, 12)
        Me.Teams_NumUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Teams_NumUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Teams_NumUpDown.Name = "Teams_NumUpDown"
        Me.Teams_NumUpDown.Size = New System.Drawing.Size(45, 20)
        Me.Teams_NumUpDown.TabIndex = 1
        Me.Teams_NumUpDown.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Timer_CheckBox
        '
        Me.Timer_CheckBox.AutoSize = True
        Me.Timer_CheckBox.Checked = True
        Me.Timer_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Timer_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_CheckBox.ForeColor = System.Drawing.Color.White
        Me.Timer_CheckBox.Location = New System.Drawing.Point(15, 42)
        Me.Timer_CheckBox.Name = "Timer_CheckBox"
        Me.Timer_CheckBox.Size = New System.Drawing.Size(79, 22)
        Me.Timer_CheckBox.TabIndex = 2
        Me.Timer_CheckBox.Text = "Timer?"
        Me.Timer_CheckBox.UseVisualStyleBackColor = True
        '
        'Seconds_NumUpDown
        '
        Me.Seconds_NumUpDown.Location = New System.Drawing.Point(100, 45)
        Me.Seconds_NumUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.Seconds_NumUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Seconds_NumUpDown.Name = "Seconds_NumUpDown"
        Me.Seconds_NumUpDown.Size = New System.Drawing.Size(44, 20)
        Me.Seconds_NumUpDown.TabIndex = 3
        Me.Seconds_NumUpDown.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Seconds_Label
        '
        Me.Seconds_Label.AutoSize = True
        Me.Seconds_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds_Label.ForeColor = System.Drawing.Color.White
        Me.Seconds_Label.Location = New System.Drawing.Point(150, 47)
        Me.Seconds_Label.Name = "Seconds_Label"
        Me.Seconds_Label.Size = New System.Drawing.Size(54, 13)
        Me.Seconds_Label.TabIndex = 4
        Me.Seconds_Label.Text = "seconds"
        '
        'Start_Button
        '
        Me.Start_Button.BackColor = System.Drawing.Color.White
        Me.Start_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Button.Location = New System.Drawing.Point(15, 79)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(206, 70)
        Me.Start_Button.TabIndex = 5
        Me.Start_Button.Text = "Lets do this!"
        Me.Start_Button.UseVisualStyleBackColor = False
        '
        'StartupWindow_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(233, 161)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.Seconds_Label)
        Me.Controls.Add(Me.Seconds_NumUpDown)
        Me.Controls.Add(Me.Timer_CheckBox)
        Me.Controls.Add(Me.Teams_NumUpDown)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartupWindow_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Religion Jeopardy - Startup Window"
        Me.TopMost = True
        CType(Me.Teams_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Seconds_NumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Teams_NumUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Seconds_NumUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Seconds_Label As System.Windows.Forms.Label
    Friend WithEvents Start_Button As System.Windows.Forms.Button
End Class
