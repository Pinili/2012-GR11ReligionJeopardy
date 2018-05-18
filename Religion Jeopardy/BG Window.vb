Public Class BGWindow_Form

    Private Sub BG_Window_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
    End Sub
End Class