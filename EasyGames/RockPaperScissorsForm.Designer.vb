<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissorsForm
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.grpBet = New System.Windows.Forms.GroupBox()
        Me.rbScissors = New System.Windows.Forms.RadioButton()
        Me.rbPaper = New System.Windows.Forms.RadioButton()
        Me.rbRock = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picPCChoice = New System.Windows.Forms.PictureBox()
        Me.grpBet.SuspendLayout()
        CType(Me.picPCChoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(26, 219)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 20)
        Me.lblResult.TabIndex = 21
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(81, 18)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(0, 20)
        Me.lblPlayerName.TabIndex = 20
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(375, 18)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(49, 20)
        Me.lblScore.TabIndex = 19
        Me.lblScore.Text = "0000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Score: "
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(267, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 55)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.Location = New System.Drawing.Point(23, 271)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(173, 55)
        Me.btnRock.TabIndex = 1
        Me.btnRock.Text = "Rock, Paper, Scissors"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'grpBet
        '
        Me.grpBet.Controls.Add(Me.rbScissors)
        Me.grpBet.Controls.Add(Me.rbPaper)
        Me.grpBet.Controls.Add(Me.rbRock)
        Me.grpBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBet.Location = New System.Drawing.Point(23, 65)
        Me.grpBet.Name = "grpBet"
        Me.grpBet.Size = New System.Drawing.Size(173, 138)
        Me.grpBet.TabIndex = 0
        Me.grpBet.TabStop = False
        Me.grpBet.Text = "Choose your bet: "
        '
        'rbScissors
        '
        Me.rbScissors.AutoSize = True
        Me.rbScissors.Location = New System.Drawing.Point(20, 100)
        Me.rbScissors.Name = "rbScissors"
        Me.rbScissors.Size = New System.Drawing.Size(95, 24)
        Me.rbScissors.TabIndex = 2
        Me.rbScissors.TabStop = True
        Me.rbScissors.Text = "Scissors"
        Me.rbScissors.UseVisualStyleBackColor = True
        '
        'rbPaper
        '
        Me.rbPaper.AutoSize = True
        Me.rbPaper.Location = New System.Drawing.Point(20, 63)
        Me.rbPaper.Name = "rbPaper"
        Me.rbPaper.Size = New System.Drawing.Size(74, 24)
        Me.rbPaper.TabIndex = 1
        Me.rbPaper.TabStop = True
        Me.rbPaper.Text = "Paper"
        Me.rbPaper.UseVisualStyleBackColor = True
        '
        'rbRock
        '
        Me.rbRock.AutoSize = True
        Me.rbRock.Location = New System.Drawing.Point(20, 28)
        Me.rbRock.Name = "rbRock"
        Me.rbRock.Size = New System.Drawing.Size(68, 24)
        Me.rbRock.TabIndex = 0
        Me.rbRock.TabStop = True
        Me.rbRock.Text = "Rock"
        Me.rbRock.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Player: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(93, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 20)
        Me.lblName.TabIndex = 22
        '
        'picPCChoice
        '
        Me.picPCChoice.Location = New System.Drawing.Point(230, 65)
        Me.picPCChoice.Name = "picPCChoice"
        Me.picPCChoice.Size = New System.Drawing.Size(194, 199)
        Me.picPCChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPCChoice.TabIndex = 17
        Me.picPCChoice.TabStop = False
        '
        'RockPaperScissorsForm
        '
        Me.AcceptButton = Me.btnRock
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(445, 347)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPCChoice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.grpBet)
        Me.Controls.Add(Me.Label3)
        Me.Name = "RockPaperScissorsForm"
        Me.Text = "Rock Paper Scissors"
        Me.grpBet.ResumeLayout(False)
        Me.grpBet.PerformLayout()
        CType(Me.picPCChoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picPCChoice As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents grpBet As System.Windows.Forms.GroupBox
    Friend WithEvents rbScissors As System.Windows.Forms.RadioButton
    Friend WithEvents rbPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rbRock As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
