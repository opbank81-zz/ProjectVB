Imports System.Data.OleDb

Public Class Account1
    Dim da, da1 As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Account1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim iCri As Integer = ListBox1.SelectedIndex
        Dim rows() As DataRow = ds.Tables("TypeAccount").Rows(iCri).GetChildRows("TypeID")
        ListBox2.Items.Clear()
        ListBox2.Items.Add("--------------------------------------------------------------------------------------")
        ListBox2.Items.Add("ID" & ControlChars.Tab & ControlChars.Tab & "ผู้ใช้")
        ListBox2.Items.Add("--------------------------------------------------------------------------------------")
        For Each row As DataRow In rows
            ListBox2.Items.Add(row("ID").ToString & ControlChars.Tab & "" & ControlChars.Tab & (row("Username").ToString))
        Next
        ListBox2.Items.Add("")
    End Sub

    Public Sub loadData()
        Dim read As String = "SELECT * FROM Account"
        da.SelectCommand = New OleDbCommand(read, con)

        Dim read1 As String = "SELECT * FROM TypeAccount"
        da1.SelectCommand = New OleDbCommand(read1, con)

        Try

            'แก้ให้ตรงกับในตาราง
            '----------------------'
            da.Fill(ds, "Account")
            da1.Fill(ds, "TypeAccount")
            '----------------------'

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim table1 As DataColumn = ds.Tables("TypeAccount").Columns("TypeID")
        Dim table2 As DataColumn = ds.Tables("Account").Columns("TypeID")

        Dim relation As DataRelation = New DataRelation("TypeID", table1, table2)
        ds.Relations.Add(relation)

        ListBox1.DataSource = ds.Tables("TypeAccount")
        ListBox1.DisplayMember = "Type"

    End Sub
End Class
