Public Class Player

    Private Token As Image
    Private X As Integer
    Private Y As Integer
    Private Color As String
    Private Location As Integer
    Private TurnStatus As Boolean

    Public Sub New(ByVal playerToken As Bitmap, ByVal playerColor As String)
        Token = playerToken
        Color = playerColor
        TurnStatus = False
        X = 0
        Y = 360
        Location = -1
    End Sub

    Public Sub Move(ByVal Spaces As Integer, ByVal picture As PictureBox)

        Dim RowParity As Boolean = (picture.Location.Y / 40) Mod 2

        picture.Visible = True
        Location += Spaces
        For i = 0 To Spaces - 1
            If RowParity Then 'Even Rows
                If (picture.Location.X + 40) <= 360 Then  'do stuff with Y
                    picture.Left += 40
                Else
                    picture.Top -= 40
                    RowParity = Not RowParity
                End If
            Else   ' Odd Rows
                If (picture.Location.X + 40) > 40 Then 'do stuff with Y
                    picture.Left -= 40
                Else
                    picture.Top -= 40
                    RowParity = Not RowParity
                End If
            End If
        Next
        FrmMain.WriteToLog("Player " + Color + " has moved forward " + Spaces.ToString() + " spaces! Current Position = " + getLocation().ToString())
    End Sub

    Public Function getX() As Integer
        Return X
    End Function
    Public Function getY() As Integer
        Return Y
    End Function

    Public Function getImage() As Image
        Return Token
    End Function

    Public Function getTurnStatus() As Boolean
        Return TurnStatus
    End Function
    Public Sub setTurnStatus(ByVal turn As Boolean)
        TurnStatus = turn
    End Sub

    Public Function getLocation() As Integer
        Return Location
    End Function
    Public Sub setLocation(ByVal loc As Integer)
        Location = loc
    End Sub

    Public Sub setLocation(ByVal loc As Integer, ByVal picture As PictureBox)
        Dim tens As Integer = loc \ 10
        Dim ones As Integer = loc Mod 10

        Location = loc

        If tens Mod 2 = 0 Then 'even row
            picture.Location = New Point((ones * 40), 360 - tens * 40)
        Else 'odd row
            picture.Location = New Point((10 - ones) * 40, 360 - (tens * 40))
        End If
        picture.BringToFront()
        FrmMain.Refresh()
    End Sub

    Public Function getColor() As String
        Return Color
    End Function

    Public Function Spin(ByVal picture As PictureBox) As Integer
        Dim Rand As New Random
        Dim tiles As Integer = Rand.Next(1, 7)
        Move(tiles, picture)
        If CheckChute(picture) Then
            FrmMain.WriteToLog("Player " + getColor().ToString + " has fallen down a CHUTE!")
        ElseIf CheckLadder(picture) Then
            FrmMain.WriteToLog("Player " + getColor().ToString + " has climbed a LADDER!")
        ElseIf CheckWin(picture) Then
            FrmMain.WriteToLog("")
            FrmMain.WriteToLog("")
            FrmMain.WriteToLog("Player " + getColor().ToString + " has WON the game!")
            FrmMain.WriteToLog("")
            FrmMain.WriteToLog("")

            'This is what happens after a win
            FrmMain.BtnStartGame.Enabled = True
            FrmMain.NumPlayers.Enabled = True
            FrmMain.BtnSpin.Enabled = False
            FrmMain.BtnReset.Enabled = False
        End If
        Return tiles
    End Function

    Public Function CheckWin(ByVal picture As PictureBox)
        If Location >= 100 Then
            picture.Location = New Point(0, 0)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckChute(ByVal picture As PictureBox)
        Select Case Location
            Case 17
                setLocation(7, picture)
                Return True
            Case 54
                setLocation(34, picture)
                Return True
            Case 62
                setLocation(19, picture)
                Return True
            Case 64
                setLocation(60, picture)
                Return True
            Case 87
                setLocation(24, picture)
                Return True
            Case 93
                setLocation(73, picture)
                Return True
            Case 95
                setLocation(75, picture)
                Return True
            Case 98
                setLocation(79, picture)
                Return True
        End Select
        Return False
    End Function

    Public Function CheckLadder(ByVal picture As PictureBox)
        Select Case Location
            Case 1
                setLocation(38, picture)
                Return True
            Case 4
                setLocation(14, picture)
                Return True
            Case 9
                setLocation(31, picture)
                Return True
            Case 21
                setLocation(42, picture)
                Return True
            Case 28
                setLocation(84, picture)
                Return True
            Case 51
                setLocation(67, picture)
                Return True
            Case 71
                setLocation(91, picture)
                Return True
            Case 80
                setLocation(100, picture)
                Return True
        End Select
        Return False
    End Function
End Class