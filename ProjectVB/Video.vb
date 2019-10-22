Public Class Video

    Private Sub Video_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_play.Image = My.Resources.play_button1
        btn_provious.Image = My.Resources.previous
        btn_next.Image = My.Resources.skip
        btn_stop.Image = My.Resources._stop
        openfile.Image = My.Resources.folder
    End Sub

    Private Sub btn_play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_play.Click
        If Media.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Media.Ctlcontrols.pause()
        Else
            Media.Ctlcontrols.play()
        End If
    End Sub

    Private Sub btn_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        Media.Ctlcontrols.stop()
    End Sub

    Private Sub btn_provious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_provious.Click
        Media.Ctlcontrols.fastReverse()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Media.Ctlcontrols.fastForward()
    End Sub

    Private Sub openfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openfile.Click
        OpenFileDialog1.Filter = "Video Type (*aiv,*mp4,*wma,*mov,*mkv)|*AIV;*MP4;*WMA;*MOV;*MKV|Music (*mp3)|*MP3;|All File (*)|*; "
        OpenFileDialog1.FileName = ""
        Timer1.Stop()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Media.Controls.Clear()
            Media.Ctlcontrols.stop()
            Dim Video1 = OpenFileDialog1.FileName
            Dim FileVideo As Object = Video1

            Media.URL = FileVideo
            btn_play.Image = My.Resources.pause1
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Sidebar.MaximumValue = Media.currentMedia.duration
        For i As Integer = 0 To Media.Ctlcontrols.currentPosition
            Sidebar.Value = Media.Ctlcontrols.currentPosition
        Next i

        Label1.Text = SecondsToTime(Media.Ctlcontrols.currentPosition)
        Label2.Text = SecondsToTime(Media.currentMedia.duration - Media.Ctlcontrols.currentPosition)
    End Sub

    Private Sub btn_play_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_play.MouseHover
        If Media.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            btn_play.Image = My.Resources.pause
        Else
            btn_play.Image = My.Resources.play
        End If
    End Sub

    Private Sub btn_play_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_play.MouseLeave
        If Media.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            btn_play.Image = My.Resources.pause1
        Else
            btn_play.Image = My.Resources.play_button1
        End If
    End Sub

    Private Sub btn_provious_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_provious.MouseHover
        btn_provious.Image = My.Resources.back
    End Sub

    Private Sub btn_provious_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_provious.MouseLeave
        btn_provious.Image = My.Resources.previous
    End Sub

    Private Sub btn_next_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.MouseHover
        btn_next.Image = My.Resources.skip1
    End Sub

    Private Sub btn_next_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.MouseLeave
        btn_next.Image = My.Resources.skip
    End Sub

    Private Sub btn_stop_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.MouseHover
        btn_stop.Image = My.Resources.stop__1_
    End Sub

    Private Sub btn_stop_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.MouseLeave
        btn_stop.Image = My.Resources._stop
    End Sub

    Private Sub openfile_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openfile.MouseHover
        openfile.Image = My.Resources.folder__1_
    End Sub

    Private Sub openfile_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openfile.MouseLeave
        openfile.Image = My.Resources.folder
    End Sub

    Public Function SecondsToTime(ByVal plngSeconds As Long) As String
        Dim lngMinutes As Long
        Dim lngSeconds As Long

        lngMinutes = plngSeconds \ 60
        lngSeconds = plngSeconds Mod 60
        SecondsToTime = Format(lngMinutes, "00") & ":" & Format(lngSeconds, "00")
    End Function
End Class
