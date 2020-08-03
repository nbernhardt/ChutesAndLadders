Public Class FrmMain

    Public PlayerList As New ArrayList(4)
    Public TokenList As New ArrayList(4)
    Public PlayerCount As Integer
    Public currentIndex As Integer

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PlayerList.Add(New Player(My.Resources.BlackPlayerTile, "Black"))
        PlayerList.Add(New Player(My.Resources.BluePlayerTile, "Blue"))
        PlayerList.Add(New Player(My.Resources.GrayPlayerTile, "Gray"))
        PlayerList.Add(New Player(My.Resources.PurplePlayerTile, "Purple"))
        PlayerList.Add(New Player(My.Resources.YellowPlayerTile, "Yellow"))

        TokenList.Add(PictureBox1)
        TokenList.Add(PictureBox2)
        TokenList.Add(PictureBox3)
        TokenList.Add(PictureBox4)
        TokenList.Add(PictureBox5)

        BtnSpin.Enabled = False
        BtnReset.Enabled = False
        NumPlayers.Enabled = True
    End Sub


    Private Sub BtnSpin_Click(sender As Object, e As EventArgs) Handles BtnSpin.Click

        Dim currentPlayer As Player = getCurrentPlayer()
        Dim currentPicBox As PictureBox = TokenList(currentIndex)
        TokenList(currentIndex).Image = currentPlayer.getImage

        Dim spaces As Integer = currentPlayer.Spin(currentPicBox)

        ' Turn change logic
        For i = 0 To PlayerCount - 1
            If PlayerList(i).getTurnStatus() Then
                PlayerList(i).setTurnStatus(False)
                If PlayerCount > i + 1 Then
                    PlayerList(i + 1).setTurnStatus(True)
                Else
                    PlayerList(0).setTurnStatus(True)
                End If
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BtnStartGame_Click(sender As Object, e As EventArgs) Handles BtnStartGame.Click
        If Not Integer.TryParse(NumPlayers.Text, PlayerCount) Then
            MessageBox.Show("Please Enter a Number Between 2 and 5")
            Exit Sub
        End If
        If PlayerCount < 2 Or PlayerCount > 5 Then
            MessageBox.Show("Please Enter a Number Between 2 and 5")
            Exit Sub
        End If

        ResetBoard()

        For i = 0 To PlayerCount - 1
            TokenList(i).visible = True
        Next

        EventLog.Items.Clear()
        BtnStartGame.Enabled = False
        Dim Rand As New Random
        Dim StartingPlayerNum = Rand.Next(1, PlayerCount + 1)
        PlayerList(StartingPlayerNum - 1).setTurnStatus(True)
        TokenList(StartingPlayerNum - 1).BringToFront()
        WriteToLog("Player " + PlayerList(StartingPlayerNum - 1).getColor() + " has been randomly selected to go first!")
        NumPlayers.Enabled = False
        BtnSpin.Enabled = True
        BtnReset.Enabled = True
    End Sub

    Public Sub WriteToLog(ByVal msg As String)
        EventLog.Items.Add(msg)
        EventLog.TopIndex = EventLog.Items.Count - 1
    End Sub

    Private Function getCurrentPlayer() As Player

        For i = 0 To PlayerCount - 1
            If PlayerList(i).getTurnStatus() Then
                currentIndex = i
                Return PlayerList(i)
            End If
        Next
        Return Nothing
    End Function

    Private Sub ResetBoard()
        For i = 0 To PlayerList.Count - 1
            PlayerList(i).setLocation(0)
            PlayerList(i).setTurnStatus(False)
            TokenList(i).location = New Point(0, 360)
            TokenList(i).visible = False
        Next
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ResetBoard()
        BtnStartGame.Enabled = True
        NumPlayers.Enabled = True
        BtnSpin.Enabled = False
        BtnReset.Enabled = False

        WriteToLog("")
        WriteToLog("")
        WriteToLog("RESETTING GAME")
        WriteToLog("")
        WriteToLog("")
    End Sub
End Class
