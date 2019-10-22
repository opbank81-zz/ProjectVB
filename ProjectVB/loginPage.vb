Imports System.Data.OleDb

Public Class loginPage

    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim da As New OleDbDataAdapter

    Private Sub loginPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.LogoProject
        connect()
    End Sub


    Private Sub Username_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.Enter
        If Username.Text = "Username" And Username.Text <> String.Empty Then
            Username.Text = ""
        End If
    End Sub

    Private Sub Username_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.Leave
        If Username.Text = "" Then
            Username.Text = "Username"
        End If
    End Sub

    Private Sub Password_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.Enter
        If Password.Text = "Password" And Password.Text <> String.Empty Then
            Password.Text = ""
        End If
    End Sub

    Private Sub Password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.Leave
        If Password.Text = "" Then
            Password.Text = "Password"
        End If
    End Sub

    Private Sub Password_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            loginData()
        End If
    End Sub

    Private Sub Loginbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loginbutton.Click
        loginData()
    End Sub

    Private Sub Register1_Click(sender As System.Object, e As System.EventArgs) Handles Register1.Click
        LoginForm.Panel2.Controls.Clear()
        LoginForm.Panel2.Controls.Add(New RegisterPage)
    End Sub

    Public Sub loginData()
        da = New OleDbDataAdapter("SELECT * FROM Account WHERE Username = '" & Me.Username.Text & "' AND [Password] = '" & Me.Password.Text & "'", con)
        ds = New DataSet

        da.Fill(ds, "Account")

        If ds.Tables("Account").Rows.Count <= 0 Then
            MsgBox("กรอกข้อมูลผิด")
            Username.Text = "Username"
            Password.Text = "Password"
        Else
            Dim IDnumber1 As Integer = ds.Tables("Account").Rows(0)("ID")
            If ds.Tables("Account").Rows(0)("TypeID") = 1 Then
                Me.Hide()
                MainForm.Show()
                IDsend(IDnumber1)
            Else
                Me.Hide()
                MainForm.AddData.Visible = False
                MainForm.Show()
                IDsend(IDnumber1)
            End If
        End If
    End Sub
End Class
