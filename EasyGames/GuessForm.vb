Public Class GuessForm
    Public Property Score As Integer
    'Dim Score As Integer
    Dim SecretNumber As Integer



    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim rand As New Random
        Score = 0
        SecretNumber = rand.Next(100) + 1

        lblGuess.Visible = False
        lblSmaller.Visible = False
        lblBigger.Visible = False

        txtNumber.Clear()
        txtNumber.Focus()
        lblScore.Text = "0"
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim GuessNumber As Integer

        If IsNumeric(txtNumber.Text) Then
            GuessNumber = CInt(txtNumber.Text)
        End If

        If (GuessNumber > 100 Or GuessNumber < 1) Then
            MessageBox.Show("The Number must be between 1 - 100 !!!", _
            "NUMBER MUST BE (1-100)", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation, _
            MessageBoxDefaultButton.Button1)
        ElseIf GuessNumber = SecretNumber Then
            Score += 1
            lblGuess.Visible = True
            lblSmaller.Visible = False
            lblBigger.Visible = False
        ElseIf GuessNumber > SecretNumber Then
            Score += 1
            lblGuess.Visible = False
            lblSmaller.Visible = True
            lblBigger.Visible = False
        ElseIf GuessNumber < SecretNumber Then
            Score += 1
            lblGuess.Visible = False
            lblSmaller.Visible = False
            lblBigger.Visible = True
        End If

        lblScore.Text = CStr(Score)
        txtNumber.Focus()
        txtNumber.SelectAll()

    End Sub

    Private Sub GuessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        Dim rand As New Random
        Score = 0
        SecretNumber = rand.Next(100) + 1

        lblGuess.Visible = False
        lblSmaller.Visible = False
        lblBigger.Visible = False

        txtNumber.Text = ""
        txtNumber.Focus()
        lblScore.Text = "0"

        lblPlayerName.Text = MainForm.PlayerName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class