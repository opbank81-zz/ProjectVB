Imports System.Data.OleDb
Imports System.IO

Public Class ProfilePage

    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dv As DataView
    Dim rd As OleDbDataReader
    Dim dt As DataTable

    Private Sub Profile_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim strSQL As String = "SELECT * FROM Query2"
        da.SelectCommand = New OleDbCommand(strSQL, con)

        Try
            da.Fill(ds, "Query2")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        dv = New DataView(ds.Tables("Query2"))
        dv.RowFilter = "ID=" & ID1 & ""
        Username.DataBindings.Add("Text", dv, "Username")
        Password.DataBindings.Add("Text", dv, "Password")
        Fname.DataBindings.Add("Text", dv, "Firstname")
        Lname.DataBindings.Add("Text", dv, "Lastname")
        Email.DataBindings.Add("Text", dv, "Email")
        Tel.DataBindings.Add("Text", dv, "Tel")

    End Sub

    Private Sub Update1_Click(sender As System.Object, e As System.EventArgs) Handles Update1.Click
        connect()
        Dim cmd As New OleDbCommand

        Dim strSQL1 As String = "UPDATE Query2 SET Username ='" & Username.Text & "', [Password] ='" & Password.Text & "'" & _
            ", Firstname ='" & Fname.Text & "', Lastname ='" & Lname.Text & "', Email ='" & Email.Text & "', Tel ='" & Tel.Text & "' WHERE ID = " & ID1 & ""

        cmd = New OleDbCommand(strSQL1, con)

        Try
            With cmd
                cmd.ExecuteNonQuery()
            End With
            MsgBox("Record Updated")
        Catch ex As Exception
            MsgBox("Record can not update")
        End Try

        cmd.Dispose()
        con.Close()

    End Sub
End Class