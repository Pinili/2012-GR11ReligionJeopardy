<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinnerWindow_Form
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
        Me.Winner_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Title_Label = New System.Windows.Forms.Label
        Me.Winner_Label = New System.Windows.Forms.Label
        Me.Congrats_Label = New System.Windows.Forms.Label
        Me.Exit_Button = New System.Windows.Forms.Button
        Me.Points_Label = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Winner_Timer
        '
        Me.Winner_Timer.Interval = 2000
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(12, 9)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(199, 31)
        Me.Title_Label.TabIndex = 0
        Me.Title_Label.Text = "The winner is..."
        Me.Title_Label.Visible = False
        '
        'Winner_Label
        '
        Me.Winner_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winner_Label.Location = New System.Drawing.Point(56, 63)
        Me.Winner_Label.Name = "Winner_Label"
        Me.Winner_Label.Size = New System.Drawing.Size(580, 80)
        Me.Winner_Label.TabIndex = 1
        Me.Winner_Label.Text = "Team <team>"
        Me.Winner_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Winner_Label.Visible = False
        '
        'Congrats_Label
        '
        Me.Congrats_Label.Font = New System.Drawing.Font("Poor Richard", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Congrats_Label.Location = New System.Drawing.Point(191, 221)
        Me.Congrats_Label.Name = "Congrats_Label"
        Me.Congrats_Label.Size = New System.Drawing.Size(508, 32)
        Me.Congrats_Label.TabIndex = 2
        Me.Congrats_Label.Text = "Congratulations! To claim your prize, see Justin. "
        Me.Congrats_Label.Visible = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(18, 230)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit Game"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Points_Label
        '
        Me.Points_Label.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Points_Label.Location = New System.Drawing.Point(178, 128)
        Me.Points_Label.Name = "Points_Label"
        Me.Points_Label.Size = New System.Drawing.Size(337, 32)
        Me.Points_Label.TabIndex = 4
        Me.Points_Label.Text = "with <points> points"
        Me.Points_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Points_Label.Visible = False
        '
        'WinnerWindow_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 270)
        Me.Controls.Add(Me.Points_Label)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Congrats_Label)
        Me.Controls.Add(Me.Winner_Label)
        Me.Controls.Add(Me.Title_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WinnerWindow_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Winner Window"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Winner_Timer As System.Windows.Forms.Timer
    Friend WithEvents Title_Label As System.Windows.Forms.Label
    Friend WithEvents Winner_Label As System.Windows.Forms.Label
    Friend WithEvents Congrats_Label As System.Windows.Forms.Label
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents Points_Label As System.Windows.Forms.Label
End Class
