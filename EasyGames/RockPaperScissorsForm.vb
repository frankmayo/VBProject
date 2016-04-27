Public Class RockPaperScissorsForm
    Public Property Score As Integer
    Dim Hand(2) As System.Drawing.Image



    Private Sub RockPaperScissorsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Score = 0
        ' initialize the array of images with the objects pictures
        Hand(0) = EasyGames.My.Resources.Resources.rock
        Hand(1) = EasyGames.My.Resources.Resources.paper
        Hand(2) = EasyGames.My.Resources.Resources.scissors

        lblName.Text = MainForm.PlayerName
    End Sub

    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Dim rnd As New Random
        Dim intPCChoice As Integer

        intPCChoice = rnd.Next(3)

        picPCChoice.Image = Hand(intPCChoice)

        Select Case intPCChoice
            Case 0
                If rbPaper.Checked Then
                    Score = Score + 1000
                    lblResult.Text = "You Win!!!"
                ElseIf rbRock.Checked Then
                    Score = Score + 500
                    lblResult.Text = "Tie!!!"
                Else
                    Score = Score - 1000
                    lblResult.Text = "You Lose!!!"
                End If
            Case 1
                If rbScissors.Checked Then
                    Score = Score + 1000
                    lblResult.Text = "You Win!!!"
                ElseIf rbPaper.Checked Then
                    Score = Score + 500
                    lblResult.Text = "Tie!!!"
                Else
                    Score = Score - 1000
                    lblResult.Text = "You Lose!!!"
                End If
            Case 2
                If rbRock.Checked Then
                    Score = Score + 1000
                    lblResult.Text = "You Win!!!"
                ElseIf rbScissors.Checked Then
                    Score = Score + 500
                    lblResult.Text = "Tie!!!"
                Else
                    Score = Score - 1000
                    lblResult.Text = "You Lose!!!"
                End If
            Case Else
                Score = Score - 1000
                lblResult.Text = "Que pinga es esto!!!"
        End Select

        lblScore.Text = CStr(Score)


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class