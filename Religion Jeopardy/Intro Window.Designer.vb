<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntroWindow_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IntroWindow_Form))
        Me.Intro_Label = New System.Windows.Forms.Label
        Me.Jeoprady_PictureBox = New System.Windows.Forms.PictureBox
        Me.Intro_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Start_Button = New System.Windows.Forms.Button
        Me.Rules_Button = New System.Windows.Forms.Button
        Me.Exit_Button = New System.Windows.Forms.Button
        Me.Rules_Label = New System.Windows.Forms.Label
        CType(Me.Jeoprady_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Intro_Label
        '
        Me.Intro_Label.AutoSize = True
        Me.Intro_Label.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Intro_Label.ForeColor = System.Drawing.Color.Cyan
        Me.Intro_Label.Location = New System.Drawing.Point(277, 48)
        Me.Intro_Label.Name = "Intro_Label"
        Me.Intro_Label.Size = New System.Drawing.Size(386, 117)
        Me.Intro_Label.TabIndex = 1
        Me.Intro_Label.Text = "Religion"
        Me.Intro_Label.Visible = False
        '
        'Jeoprady_PictureBox
        '
        Me.Jeoprady_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Jeoprady_PictureBox.Image = Global.Religion_Jeopardy.My.Resources.Resources.JeopardyAnimatedTitle3
        Me.Jeoprady_PictureBox.Location = New System.Drawing.Point(88, 206)
        Me.Jeoprady_PictureBox.Name = "Jeoprady_PictureBox"
        Me.Jeoprady_PictureBox.Size = New System.Drawing.Size(766, 244)
        Me.Jeoprady_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Jeoprady_PictureBox.TabIndex = 0
        Me.Jeoprady_PictureBox.TabStop = False
        '
        'Intro_Timer
        '
        Me.Intro_Timer.Interval = 7250
        '
        'Start_Button
        '
        Me.Start_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Start_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Button.Location = New System.Drawing.Point(297, 491)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(109, 35)
        Me.Start_Button.TabIndex = 2
        Me.Start_Button.Text = "Start"
        Me.Start_Button.UseVisualStyleBackColor = False
        '
        'Rules_Button
        '
        Me.Rules_Button.BackColor = System.Drawing.Color.Cyan
        Me.Rules_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rules_Button.Location = New System.Drawing.Point(412, 491)
        Me.Rules_Button.Name = "Rules_Button"
        Me.Rules_Button.Size = New System.Drawing.Size(109, 35)
        Me.Rules_Button.TabIndex = 3
        Me.Rules_Button.Text = "Rules"
        Me.Rules_Button.UseVisualStyleBackColor = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(527, 491)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(109, 35)
        Me.Exit_Button.TabIndex = 4
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Rules_Label
        '
        Me.Rules_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rules_Label.ForeColor = System.Drawing.Color.Yellow
        Me.Rules_Label.Location = New System.Drawing.Point(84, 94)
        Me.Rules_Label.Name = "Rules_Label"
        Me.Rules_Label.Size = New System.Drawing.Size(770, 394)
        Me.Rules_Label.TabIndex = 5
        Me.Rules_Label.Text = resources.GetString("Rules_Label.Text")
        Me.Rules_Label.Visible = False
        '
        'IntroWindow_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(941, 565)
        Me.Controls.Add(Me.Rules_Label)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Rules_Button)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.Intro_Label)
        Me.Controls.Add(Me.Jeoprady_PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IntroWindow_Form"
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intro Window"
        Me.TopMost = True
        CType(Me.Jeoprady_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Jeoprady_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Intro_Label As System.Windows.Forms.Label
    Friend WithEvents Intro_Timer As System.Windows.Forms.Timer
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents Rules_Button As System.Windows.Forms.Button
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents Rules_Label As System.Windows.Forms.Label
End Class
