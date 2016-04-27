Public Class CoinForm
    Public Property Score As Integer



    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim rand As New Random
        Dim index As Integer

        '0 means HEADS 
        '1 means TAILS
        index = rand.Next(2)

        ' show the coin side
        If index = 0 Then
            picCoin.Image = EasyGames.My.Resources.Resources.heads
        Else
            picCoin.Image = EasyGames.My.Resources.Resources.tails
        End If



        ' check if it is a match and update score
        If (rbHeads.Checked) And (index = 0) Then
            Score += 100
            lblScore.Text = CStr(Score)
            lblScore.Visible = True

            lblResult.Text = "You Win!!!"
            lblResult.Visible = True

        ElseIf (rbTails.Checked) And (index = 1) Then
            Score += 100
            lblScore.Text = CStr(Score)
            lblScore.Visible = True

            lblResult.Text = "You Win!!!"
            lblResult.Visible = True
        Else
            Score -= 100
            lblScore.Text = CStr(Score)
            lblScore.Visible = True

            lblResult.Text = "You Lose!!!"
            lblResult.Visible = True
        End If


    End Sub


    Private Sub CoinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        Score = 0
        lblPlayerName.Text = MainForm.PlayerName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class