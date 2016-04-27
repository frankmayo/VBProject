Public Class CubileteForm
    'Cubilete is a game when the figures have ascending value
    ' As > K > Qundangos > Jevas > Gallegos > Negritos
    ' or Ace > King > Queen > J > 8 > 7  according to the figures
    ' the objective of the game is to get as many as possible
    ' with the same figure
    ' in three rolls.
    ' As(Ace)(RED DOT) is the top figure and it is a wildcard for any one of the others
    ' This is a simplified version of the game....

    Public Property Score As Integer
    Dim ChosenFigure As Integer


    ' Declare an array to store the six faces of the dice
    Dim Dice(5) As System.Drawing.Image

    ' Times you throw the dice, three is the maximum
    Dim roll As Integer

    ' keep values of dice in an array to calculate the score
    Dim Cubilete(4) As Integer


    Private Sub ButtonRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim index As Integer
        Dim rand As New Random
        Dim intScore As Integer
        Dim countAces As Integer
        Dim countChosen As Integer

        countAces = 0
        countChosen = 0
        intScore = 0

        ' increment the roll number
        ' up to three allowed
        roll = roll + 1

        ' you cannot roll more than three
        If roll > 3 Then
            MessageBox.Show("GAME OVER! only three rolls allowed", _
            "GAME OVER!", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation, _
            MessageBoxDefaultButton.Button1)
            'For i As Integer = 0 To 4
            '    intScore = intScore + ((Cubilete(i) + 1) * 10)
            'Next
            'Score = intScore
            'lblScore.Text = CStr(intScore)


        Else
            ' simulation of the throwing with random numbers
            ' every dice that is still rolling gets a random figure

            ' if the button is enabled is still rolling
            If btnDie0.Enabled = True Then
                index = rand.Next(6)
                btnDie0.BackgroundImage = Dice(index)
                Cubilete(0) = index
            End If

            If btnDie1.Enabled = True Then
                index = rand.Next(6)
                btnDie1.BackgroundImage = Dice(index)
                Cubilete(1) = index
            End If

            If btnDie2.Enabled = True Then
                index = rand.Next(6)
                btnDie2.BackgroundImage = Dice(index)
                Cubilete(2) = index
            End If

            If btnDie3.Enabled = True Then
                index = rand.Next(6)
                btnDie3.BackgroundImage = Dice(index)
                Cubilete(3) = index
            End If

            If btnDie4.Enabled = True Then
                index = rand.Next(6)
                btnDie4.BackgroundImage = Dice(index)
                Cubilete(4) = index
            End If

            If roll = 3 Then  ' It is the last roll and the score is calculated

                ' count how many aces (As)
                For i As Integer = 0 To 4
                    If Cubilete(i) = 5 Then
                        countAces = countAces + 1
                    End If
                Next

                If ChosenFigure = 5 Then
                    If countAces = 5 Then ' you are the best 5 aces!!!!
                        Score = 20000
                        lblScore.Text = "20000"
                        Return
                    End If
                Else '  the chosen figure for the dice is any other
                    For i As Integer = 0 To 4 ' count how many match the chosen
                        If Cubilete(i) = ChosenFigure Then
                            countChosen = countChosen + 1
                        End If
                    Next


                    ' if the 5 dice are the same figure with aces as wildcards
                    ' you get more points
                    If (countChosen + countAces) = 5 Then
                        Select Case ChosenFigure
                            Case 0
                                Score = 5000
                                lblScore.Text = CStr(Score)
                            Case 1
                                Score = 6000
                                lblScore.Text = CStr(Score)
                            Case 2
                                Score = 7000
                                lblScore.Text = CStr(Score)
                            Case 3
                                Score = 8000
                                lblScore.Text = CStr(Score)
                            Case 4
                                Score = 10000
                                lblScore.Text = CStr(Score)
                        End Select
                    Else
                        Score = (ChosenFigure + 1) * 200 * (countChosen + countAces)
                        lblScore.Text = CStr(Score)
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub CubileteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' initialize the rolls
        roll = 0
        'score is zero
        Score = 0
        ' figure for the cubilete
        ' I set chosenfigure = As, because it is the wildcard
        ChosenFigure = 5
        ' initialize the array of images with the faces
        Dice(0) = EasyGames.My.Resources.Resources.negrito
        Dice(1) = EasyGames.My.Resources.Resources.gallego
        Dice(2) = EasyGames.My.Resources.Resources.jeva
        Dice(3) = EasyGames.My.Resources.Resources.qundango
        Dice(4) = EasyGames.My.Resources.Resources.K
        Dice(5) = EasyGames.My.Resources.Resources._As

        lblPlayerName.Text = MainForm.PlayerName
    End Sub

    Private Sub btnDie0_Click(sender As Object, e As EventArgs) Handles btnDie0.Click
        If ChosenFigure = 5 Then
            ChosenFigure = Cubilete(0)
        End If

        If roll > 0 Then
            btnDie0.Enabled = Not ((Cubilete(0) = ChosenFigure) Or (Cubilete(0) = 5))
        End If
    End Sub

    Private Sub btnDie1_Click(sender As Object, e As EventArgs) Handles btnDie1.Click
        If ChosenFigure = 5 Then
            ChosenFigure = Cubilete(1)
        End If

        If roll > 0 Then
            btnDie1.Enabled = (Cubilete(1) <> ChosenFigure) And (Cubilete(1) <> 5)
        End If
    End Sub

    Private Sub btnDie2_Click(sender As Object, e As EventArgs) Handles btnDie2.Click
        If ChosenFigure = 5 Then
            ChosenFigure = Cubilete(2)
        End If

        If roll > 0 Then
            btnDie2.Enabled = (Cubilete(2) <> ChosenFigure) And (Cubilete(2) <> 5)
        End If
    End Sub

    Private Sub btnDie3_Click(sender As Object, e As EventArgs) Handles btnDie3.Click
        If ChosenFigure = 5 Then
            ChosenFigure = Cubilete(3)
        End If

        If roll > 0 Then
            btnDie3.Enabled = (Cubilete(3) <> ChosenFigure) And (Cubilete(3) <> 5)
        End If
    End Sub

    Private Sub btnDie4_Click(sender As Object, e As EventArgs) Handles btnDie4.Click
        If ChosenFigure = 5 Then
            ChosenFigure = Cubilete(4)
        End If

        If roll > 0 Then
            btnDie4.Enabled = (Cubilete(4) <> ChosenFigure) And (Cubilete(4) <> 5)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        ' rolls of cubilete equals zero
        roll = 0

        ' the player must stick to the same figure she chose first
        ' Aces are wildcards, can be any other figure
        ' I set chosenfigure = As, because it is the wildcard
        ChosenFigure = 5

        btnDie0.BackgroundImage = EasyGames.My.Resources.Resources.blank
        btnDie0.Enabled = True

        btnDie1.BackgroundImage = EasyGames.My.Resources.Resources.blank
        btnDie1.Enabled = True

        btnDie2.BackgroundImage = EasyGames.My.Resources.Resources.blank
        btnDie2.Enabled = True

        btnDie3.BackgroundImage = EasyGames.My.Resources.Resources.blank
        btnDie3.Enabled = True

        btnDie4.BackgroundImage = EasyGames.My.Resources.Resources.blank
        btnDie4.Enabled = True
    End Sub
End Class