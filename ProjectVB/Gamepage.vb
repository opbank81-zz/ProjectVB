Imports System.Data.OleDb
Imports System.IO

Public Class Gamepage

    Dim file As String = My.Computer.FileSystem.CurrentDirectory & "\img\picture\"
    Dim Picture As String = file
    Dim Games As String() = {"OverWatch", "Monster-Hunter", "Minecraft", "Slither.io", "Grand-Theft-Auto-V", "Pangya", "PlayerUnknown's-Battlegrounds",
                            "Squad", "The-Sims4"}

    Dim blnUsed As Boolean() = New Boolean(Games.GetUpperBound(0)) {}
    Dim Count As Integer = 1
    Dim score As Integer
    Dim P1, p2 As String

    Private Sub Gamepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connect()

        Array.Sort(Games)
        DropItem.DataSource = Games
        DisplayGame()

    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        Dim strResponse As String = Convert.ToString(DropItem.SelectedValue)
        If strResponse = P1 Then
            score += 1
            Label2.Text = score
            Count += 1
            DisplayGame()
        Else
            MsgBox("คำตอบผิด")
            Count += 1
            DisplayGame()
        End If

        If Count = 10 Then
            MsgBox("Game Over")
            btn_next.Visible = False
        End If
    End Sub

    Function BuildPathName() As String
        Dim output As String = P1
        output &= ".jpg"
        output = Picture & output
        Return output
    End Function

    Function GetRandomNum() As Integer
        Dim ObjRandom As Random = New Random
        Dim intRandom As Integer
        Do
            intRandom = ObjRandom.Next(0, blnUsed.Length)
        Loop Until blnUsed(intRandom) = False
        blnUsed(intRandom) = True
        Return intRandom

    End Function

    Sub DisplayGame()
        Dim intRandom As Integer = GetRandomNum()
        P1 = Games(intRandom)
        Dim Path As String = BuildPathName()
        PictureBox1.Image = Image.FromFile(Path)
        Me.Text = "ผลท้าย : ครั้งที่ " & Count
    End Sub


End Class
