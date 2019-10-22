Imports System.Data.OleDb

Public Class AddDatapage

    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dv As DataView

    Dim i As Integer

    Private Sub AddDatapage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Account.Text = "Account"
        Data.Text = "Data"
        DataAccount.Text = "DataAccount"

        connect()
        ACDataShow()
        DataShow()
        AccountShow()
    End Sub

    Private Sub Add_Click(sender As System.Object, e As System.EventArgs) Handles Add.Click

        SelectPage.ShowDialog()
    End Sub

    Private Sub Del_Click(sender As System.Object, e As System.EventArgs) Handles Del.Click
        DeletData.ShowDialog()
    End Sub

    Public Sub ACDataShow()
        Dim strSQL As String = "SELECT * FROM Query2"
        da.SelectCommand = New OleDbCommand(strSQL, con)

        Try
            da.Fill(ds, "Query2")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        dv = New DataView(ds.Tables("Query2"))
        QData.DataSource = dv
    End Sub

    Public Sub DataShow()

        Dim strSQL As String = "SELECT Firstname,Lastname,Email,Tel FROM NameData"
        da.SelectCommand = New OleDbCommand(strSQL, con)

        Try
            da.Fill(ds, "NameData")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        dv = New DataView(ds.Tables("NameData"))
        NDData.DataSource = dv
    End Sub

    Public Sub AccountShow()

        Dim strSQL As String = "SELECT Account.Username, Account.[Password], TypeAccount.Type FROM (Account INNER JOIN TypeAccount ON Account.TypeID = TypeAccount.TypeID)"
        da.SelectCommand = New OleDbCommand(strSQL, con)

        Try
            da.Fill(ds, "Account")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        dv = New DataView(ds.Tables("Account"))
        ACData.DataSource = dv
    End Sub
End Class
