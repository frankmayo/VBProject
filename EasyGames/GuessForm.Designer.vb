<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuessForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBigger = New System.Windows.Forms.Label()
        Me.lblSmaller = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guess a number between 1 - 100"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player: "
        '
        'lblBigger
        '
        Me.lblBigger.AutoSize = True
        Me.lblBigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBigger.ForeColor = System.Drawing.Color.Red
        Me.lblBigger.Location = New System.Drawing.Point(134, 26)
        Me.lblBigger.Name = "lblBigger"
        Me.lblBigger.Size = New System.Drawing.Size(76, 20)
        Me.lblBigger.TabIndex = 2
        Me.lblBigger.Text = "Bigger!!!"
        Me.lblBigger.Visible = False
        '
        'lblSmaller
        '
        Me.lblSmaller.AutoSize = True
        Me.lblSmaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmaller.ForeColor = System.Drawing.Color.Red
        Me.lblSmaller.Location = New System.Drawing.Point(134, 89)
        Me.lblSmaller.Name = "lblSmaller"
        Me.lblSmaller.Size = New System.Drawing.Size(84, 20)
        Me.lblSmaller.TabIndex = 3
        Me.lblSmaller.Text = "Smaller!!!"
        Me.lblSmaller.Visible = False
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(138, 58)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(69, 20)
        Me.txtNumber.TabIndex = 0
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(110, 118)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(146, 50)
        Me.btnGuess.TabIndex = 1
        Me.btnGuess.Text = "Guess!!!"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(282, 118)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 50)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPlayerName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 41)
        Me.Panel1.TabIndex = 15
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(67, 11)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(0, 20)
        Me.lblPlayerName.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(248, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tries:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(320, 11)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(19, 20)
        Me.lblScore.TabIndex = 16
        Me.lblScore.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnNewGame)
        Me.Panel2.Controls.Add(Me.lblGuess)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblBigger)
        Me.Panel2.Controls.Add(Me.lblSmaller)
        Me.Panel2.Controls.Add(Me.btnGuess)
        Me.Panel2.Controls.Add(Me.txtNumber)
        Me.Panel2.Location = New System.Drawing.Point(12, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 184)
        Me.Panel2.TabIndex = 0
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(3, 118)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 50)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGuess.Location = New System.Drawing.Point(213, 58)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(144, 20)
        Me.lblGuess.TabIndex = 6
        Me.lblGuess.Text = "You guessed it!!!"
        Me.lblGuess.Visible = False
        '
        'GuessForm
        '
        Me.AcceptButton = Me.btnGuess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(405, 261)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GuessForm"
        Me.Text = "Guess"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBigger As System.Windows.Forms.Label
    Friend WithEvents lblSmaller As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents lblGuess As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
End Class
