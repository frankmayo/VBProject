<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpBet = New System.Windows.Forms.GroupBox()
        Me.rbTails = New System.Windows.Forms.RadioButton()
        Me.rbHeads = New System.Windows.Forms.RadioButton()
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.picCoin = New System.Windows.Forms.PictureBox()
        Me.grpBet.SuspendLayout()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player: "
        '
        'grpBet
        '
        Me.grpBet.Controls.Add(Me.rbTails)
        Me.grpBet.Controls.Add(Me.rbHeads)
        Me.grpBet.Location = New System.Drawing.Point(18, 59)
        Me.grpBet.Name = "grpBet"
        Me.grpBet.Size = New System.Drawing.Size(163, 113)
        Me.grpBet.TabIndex = 0
        Me.grpBet.TabStop = False
        Me.grpBet.Text = "Choose your bet: "
        '
        'rbTails
        '
        Me.rbTails.AutoSize = True
        Me.rbTails.Location = New System.Drawing.Point(23, 72)
        Me.rbTails.Name = "rbTails"
        Me.rbTails.Size = New System.Drawing.Size(47, 17)
        Me.rbTails.TabIndex = 1
        Me.rbTails.TabStop = True
        Me.rbTails.Text = "Tails"
        Me.rbTails.UseVisualStyleBackColor = True
        '
        'rbHeads
        '
        Me.rbHeads.AutoSize = True
        Me.rbHeads.Location = New System.Drawing.Point(23, 38)
        Me.rbHeads.Name = "rbHeads"
        Me.rbHeads.Size = New System.Drawing.Size(56, 17)
        Me.rbHeads.TabIndex = 0
        Me.rbHeads.TabStop = True
        Me.rbHeads.Text = "Heads"
        Me.rbHeads.UseVisualStyleBackColor = True
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(80, 280)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(101, 23)
        Me.btnToss.TabIndex = 1
        Me.btnToss.Text = "Toss the Coin!"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(308, 280)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Score: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(376, 12)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(49, 20)
        Me.lblScore.TabIndex = 8
        Me.lblScore.Text = "0000"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(76, 12)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(0, 20)
        Me.lblPlayerName.TabIndex = 11
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(21, 213)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(91, 20)
        Me.lblResult.TabIndex = 12
        Me.lblResult.Text = "You Win!!!"
        Me.lblResult.Visible = False
        '
        'picCoin
        '
        Me.picCoin.Location = New System.Drawing.Point(225, 59)
        Me.picCoin.Name = "picCoin"
        Me.picCoin.Size = New System.Drawing.Size(194, 194)
        Me.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoin.TabIndex = 6
        Me.picCoin.TabStop = False
        '
        'CoinForm
        '
        Me.AcceptButton = Me.btnToss
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(469, 342)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCoin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Controls.Add(Me.grpBet)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CoinForm"
        Me.Text = "Coin Toss"
        Me.grpBet.ResumeLayout(False)
        Me.grpBet.PerformLayout()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpBet As System.Windows.Forms.GroupBox
    Friend WithEvents rbTails As System.Windows.Forms.RadioButton
    Friend WithEvents rbHeads As System.Windows.Forms.RadioButton
    Friend WithEvents btnToss As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picCoin As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
