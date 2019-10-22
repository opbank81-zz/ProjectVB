Imports System.Data.OleDb

Module ConnectDB
    Public con As OleDbConnection

    Public Sub connect()
        Try
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & "ProjectVB.mdb")
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

        Catch ex As Exception
            MsgBox("Connect Failed", "Warning")
        End Try
    End Sub
End Module
