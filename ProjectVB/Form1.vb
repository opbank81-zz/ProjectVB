Public Class Form1

    Dim YN As Boolean
    Dim lo As Point

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Main"
        Label1.ForeColor = Color.FromArgb(255, 0, 255)
        Label1.Font = New Font("Boonjot", 16, FontStyle.Regular)

        Close1.Image = My.Resources.Cancel1
        Minimize.Image = My.Resources.minimize
        LogoMenu.Image = My.Resources.logo
    End Sub

    Private Sub Close1_Click(sender As System.Object, e As System.EventArgs) Handles Close1.Click
        Timer1.Start()
    End Sub

    Private Sub Close1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Close1.MouseHover
        Close1.Image = My.Resources.cancel2
    End Sub

    Private Sub Close1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Close1.MouseLeave
        Close1.Image = My.Resources.Cancel1
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If (Me.Opacity > 0.0) Then
            Me.Opacity -= 0.025
        Else
            Timer1.Stop()
            End
        End If
    End Sub

    Private Sub Minimize_Click(sender As System.Object, e As System.EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimize_MouseHover(sender As System.Object, e As System.EventArgs) Handles Minimize.MouseHover
        Minimize.Image = My.Resources.minimize1
    End Sub

    Private Sub Minimize_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Minimize.MouseLeave
        Minimize.Image = My.Resources.minimize
    End Sub

    Private Sub Title_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Title.MouseDown
        If e.Button = MouseButtons.Left Then
            YN = True
            Me.Cursor = Cursors.Default
            lo = e.Location
        End If
    End Sub

    Private Sub Title_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Title.MouseMove
        If YN Then
            Me.Location = Me.Location + (e.Location - lo)
        End If
    End Sub

    Private Sub Title_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Title.MouseUp
        If e.Button = MouseButtons.Left Then
            YN = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Home_Click(sender As System.Object, e As System.EventArgs) Handles Home.Click
        Dim HP As New HomePage()
        Me.Mainpage.Controls.Add(HP)
    End Sub
End Class
