Public Class MainForm

    Dim YN As Boolean
    Dim lo As Point

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        LoginForm.Hide()
        Me.Mainpage.Controls.Add(New Homepage)

        Close1.Image = My.Resources.Cancel1
        Minimize.Image = My.Resources.minimize
        LogoMenu.Image = My.Resources.LogoProject
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

    Private Sub Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If (Me.Opacity > 0.0) Then
            Me.Opacity -= 0.05
        Else
            Timer2.Stop()
            Me.Close()
            LoginForm.Show()
            LoginForm.Panel2.Controls.Add(New loginPage)
            con.Close()
        End If
    End Sub

    Private Sub Profile_Click(sender As System.Object, e As System.EventArgs) Handles Profile.Click
        Dim prop As New ProfilePage()
        Mainpage.Controls.Clear()
        Me.Mainpage.Controls.Add(prop)
    End Sub

    Private Sub Games_Click(sender As System.Object, e As System.EventArgs) Handles Games.Click
        Mainpage.Controls.Clear()
        Me.Mainpage.Controls.Add(New Gamepage)
    End Sub

    Private Sub Midia_Click(sender As System.Object, e As System.EventArgs) Handles Midia.Click
        Mainpage.Controls.Clear()
        Me.Mainpage.Controls.Add(New Video)
    End Sub

    Private Sub AddData_Click(sender As System.Object, e As System.EventArgs) Handles AddData.Click
        Mainpage.Controls.Clear()
        Me.Mainpage.Controls.Add(New AddDatapage)
    End Sub

    Private Sub Account1_Click(sender As System.Object, e As System.EventArgs) Handles Account1.Click
        Mainpage.Controls.Clear()
        Me.Mainpage.Controls.Add(New Account1)
    End Sub

    Private Sub Contect_Click(sender As System.Object, e As System.EventArgs) Handles Contect.Click
        Mainpage.Controls.Clear()
        Me.Mainpage.Controls.Add(New Contect)
    End Sub
End Class
