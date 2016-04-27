Public Class MainForm

    Public Property PlayerName As String

    Dim CoinScore As Integer
    Dim NumberScore As Integer
    Dim CubileteScore As Integer
    Dim RockPaperScissorsScore As Integer

    Private Sub mnuGamesCoin_Click(sender As Object, e As EventArgs) Handles mnuGamesCoin.Click, PictureBox1.Click
        Dim frmCoin As New CoinForm
        frmCoin.ShowDialog()

        If frmCoin.Score > CoinScore Then
            lblCoinScore.Text = CStr(frmCoin.Score)
            CoinScore = frmCoin.Score
        End If
    End Sub

    Private Sub mnuGamesNumber_Click(sender As Object, e As EventArgs) Handles mnuGamesNumber.Click, PictureBox2.Click
        Dim frmGuess As New GuessForm
        frmGuess.ShowDialog()
        If (NumberScore = 0 Or (frmGuess.Score < NumberScore And frmGuess.Score <> 0)) Then
            NumberScore = frmGuess.Score
            lblNumberScore.Text = CStr(frmGuess.Score)
        End If
    End Sub

    Private Sub mnuGamesRockPaperScissors_Click(sender As Object, e As EventArgs) Handles mnuGamesTicTacToe.Click, PictureBox3.Click
        Dim frmRockPaperScissors As New RockPaperScissorsForm
        frmRockPaperScissors.ShowDialog()
        If frmRockPaperScissors.Score > RockPaperScissorsScore Then
            lblRockPaperScissorsScore.Text = CStr(frmRockPaperScissors.Score)
            RockPaperScissorsScore = frmRockPaperScissors.Score
        End If
    End Sub

    Private Sub mnuGamesCubilete_Click(sender As Object, e As EventArgs) Handles mnuGamesCubilete.Click, PictureBox4.Click
        Dim frmCubilete As New CubileteForm
        frmCubilete.ShowDialog()
        If frmCubilete.Score > CubileteScore Then
            lblCubileteScore.Text = CStr(frmCubilete.Score)
            CubileteScore = frmCubilete.Score
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mnuSettingsReset_Click(sender As Object, e As EventArgs) Handles mnuSettingsReset.Click
        CoinScore = 0
        NumberScore = 0
        CubileteScore = 0
        RockPaperScissorsScore = 0
        lblCubileteScore.Text = "0"
        lblNumberScore.Text = "0"
        lblCoinScore.Text = "0"
        lblRockPaperScissorsScore.Text = "0"
    End Sub

    Private Sub mnuSettingsPlayer_Click(sender As Object, e As EventArgs) Handles mnuSettingsPlayer.Click
        Dim frmName As New NameForm
        frmName.ShowDialog()
        PlayerName = frmName.PlayerName
        lblPlayerName.Text = PlayerName
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerName = ""

    End Sub


End Class
