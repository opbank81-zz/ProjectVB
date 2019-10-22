Public Class LoginForm

    Dim YN As Boolean
    Dim lo As Point

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        Close1.Image = My.Resources.Cancel1
        Minimize.Image = My.Resources.minimize
        Me.Panel2.Controls.Add(New loginPage)
    End Sub

    Private Sub Close1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close1.Click
        Timer1.Start()
    End Sub

    Private Sub Close1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close1.MouseHover
        Close1.Image = My.Resources.cancel2
    End Sub

    Private Sub Close1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close1.MouseLeave
        Close1.Image = My.Resources.Cancel1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (Me.Opacity > 0.0) Then
            Me.Opacity -= 0.05
        Else
            Timer1.Stop()
            End
        End If
    End Sub

    Private Sub Minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimize_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimize.MouseHover
        Minimize.Image = My.Resources.minimize1
    End Sub

    Private Sub Minimize_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimize.MouseLeave
        Minimize.Image = My.Resources.minimize
    End Sub

    Private Sub Title_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Title.MouseDown
        If e.Button = MouseButtons.Left Then
            YN = True
            Me.Cursor = Cursors.Default
            lo = e.Location
        End If
    End Sub

    Private Sub Title_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Title.MouseMove
        If YN Then
            Me.Location = Me.Location + (e.Location - lo)
        End If
    End Sub

    Private Sub Title_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Title.MouseUp
        If e.Button = MouseButtons.Left Then
            YN = False
            Me.Cursor = Cursors.Default
        End If
    End Sub


End Class