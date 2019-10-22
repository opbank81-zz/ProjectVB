Imports System.Data.OleDb

Public Class DeletData

    Dim YN As Boolean
    Dim lo As Point

    Dim cmd, cmd1 As New OleDbCommand

    Dim i As Integer

    Private Sub DeletData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        con.Close()
    End Sub

    Private Sub Title_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            YN = True
            Me.Cursor = Cursors.Default
            lo = e.Location
        End If
    End Sub

    Private Sub Title_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If YN Then
            Me.Location = Me.Location + (e.Location - lo)
        End If
    End Sub

    Private Sub Title_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            YN = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Del1_Click(sender As System.Object, e As System.EventArgs) Handles Del1.Click

        con.Open()
        Dim str As String = "DELETE * FROM Account WHERE ID =" & Me.Index1.Text
        Dim str1 As String = "DELETE * FROM NameData WHERE IDName =" & Me.Index1.Text

        cmd = New OleDbCommand(str, con)
        cmd1 = New OleDbCommand(str1, con)

        cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()

        cmd.Dispose()
        cmd1.Dispose()

        Me.Close()


    End Sub

    Private Sub BteBack_Click(sender As System.Object, e As System.EventArgs) Handles BteBack.Click
        Me.Close()
    End Sub

    Private Sub Index1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Index1.Enter
        If Index1.Text = "Record Index" And Index1.Text <> String.Empty Then
            Index1.Text = ""
        End If
    End Sub

    Private Sub Index1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Index1.MouseLeave
        If Index1.Text = "" Then
            Index1.Text = "Record Index"
        End If
    End Sub
End Class