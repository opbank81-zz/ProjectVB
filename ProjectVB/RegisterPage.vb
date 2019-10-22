Imports System.Data.OleDb

Public Class RegisterPage

    Dim Str As String
    Dim cmd, cmd1 As New OleDbCommand
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim dv As DataView
    Dim pass, pass1 As String
    Dim Gender As Integer

    Private Sub RegisterPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "ยืนยันการเพิ่มข้อมูล"
        Check1.Checked = False
    End Sub

    Private Sub BteBack_Click(sender As System.Object, e As System.EventArgs) Handles BteBack.Click
        LoginForm.Panel2.Controls.Clear()
        LoginForm.Panel2.Controls.Add(New loginPage)
    End Sub

    Private Sub BtnRegis_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegis.Click
        pass = Password.Text
        pass1 = Password1.Text

        If Male.Checked = True Then
            Gender = 1
        ElseIf FM.Checked = True Then
            Gender = 2
        End If

        If Check1.Checked = True Then
            If pass = pass1 Then
                Dim InsertQuery As String = "INSERT INTO NameData (Firstname, Lastname, Gender, Email, Tel)" & _
                "VALUES ('" & Firstname.Text & "','" & Lastname.Text & "','" & Gender & "','" & Email.Text & "','" & Tel.Text & "')"

                Dim InsertQuery1 As String = "INSERT INTO Account (Username, [Password], TypeID)" & _
                                            "VALUES ('" & Username.Text & "','" & pass & "','2')"

                cmd = New OleDbCommand(InsertQuery, con)
                cmd1 = New OleDbCommand(InsertQuery1, con)

                If pass = pass1 Then
                    With cmd
                        cmd.ExecuteNonQuery()
                        cmd1.ExecuteNonQuery()
                    End With
                    loginData()
                End If
            Else
                clearpassword()
                MsgBox("รหัสผ่านไม่ตรงกัน")
            End If
        End If

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

    Private Sub clearpassword()
        Password.Text = "password"
        Password1.Text = "password"
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

    Private Sub Firstname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Firstname.Enter
        If Firstname.Text = "Firstname" And Firstname.Text <> String.Empty Then
            Firstname.Text = ""
        End If
    End Sub

    Private Sub Firstname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Firstname.Leave
        If Firstname.Text = "" Then
            Firstname.Text = "Firstname"
        End If
    End Sub

    Private Sub Tel_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel.Enter
        If Tel.Text = "Tel" And Tel.Text <> String.Empty Then
            Tel.Text = ""
        End If
    End Sub

    Private Sub Tel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tel.Leave
        If Tel.Text = "" Then
            Tel.Text = "Tel"
        End If
    End Sub

    Private Sub Lastname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lastname.Enter
        If Lastname.Text = "Lastname" And Lastname.Text <> String.Empty Then
            Lastname.Text = ""
        End If
    End Sub

    Private Sub Lastname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lastname.Leave
        If Lastname.Text = "" Then
            Lastname.Text = "Lastname"
        End If
    End Sub

    Private Sub Email_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Email.Enter
        If Email.Text = "Email" And Email.Text <> String.Empty Then
            Email.Text = ""
        End If
    End Sub

    Private Sub Email_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Email.Leave
        If Email.Text = "" Then
            Email.Text = "Email"
        End If
    End Sub

    Private Sub Password1_Leave(sender As System.Object, e As System.EventArgs) Handles Password1.Leave
        If Password1.Text = "" Then
            Password1.Text = "Password"
        End If
    End Sub

    Private Sub Password1_Enter(sender As System.Object, e As System.EventArgs) Handles Password1.Enter
        If Password1.Text = "Password" And Password1.Text <> String.Empty Then
            Password1.Text = ""
        End If
    End Sub
End Class
