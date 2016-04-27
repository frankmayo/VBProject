<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuGames = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGamesCoin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGamesNumber = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGamesTicTacToe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGamesCubilete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettingsPlayer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettingsReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCubileteScore = New System.Windows.Forms.Label()
        Me.lblRockPaperScissorsScore = New System.Windows.Forms.Label()
        Me.lblNumberScore = New System.Windows.Forms.Label()
        Me.lblCoinScore = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGames, Me.mnuSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(405, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuGames
        '
        Me.mnuGames.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGamesCoin, Me.mnuGamesNumber, Me.mnuGamesTicTacToe, Me.mnuGamesCubilete})
        Me.mnuGames.Name = "mnuGames"
        Me.mnuGames.Size = New System.Drawing.Size(55, 20)
        Me.mnuGames.Text = "&Games"
        '
        'mnuGamesCoin
        '
        Me.mnuGamesCoin.Name = "mnuGamesCoin"
        Me.mnuGamesCoin.Size = New System.Drawing.Size(177, 22)
        Me.mnuGamesCoin.Text = "&Coin Toss"
        '
        'mnuGamesNumber
        '
        Me.mnuGamesNumber.Name = "mnuGamesNumber"
        Me.mnuGamesNumber.Size = New System.Drawing.Size(177, 22)
        Me.mnuGamesNumber.Text = "&Number Guessing"
        '
        'mnuGamesTicTacToe
        '
        Me.mnuGamesTicTacToe.Name = "mnuGamesTicTacToe"
        Me.mnuGamesTicTacToe.Size = New System.Drawing.Size(177, 22)
        Me.mnuGamesTicTacToe.Text = "&Rock Paper Scissors"
        '
        'mnuGamesCubilete
        '
        Me.mnuGamesCubilete.Name = "mnuGamesCubilete"
        Me.mnuGamesCubilete.Size = New System.Drawing.Size(177, 22)
        Me.mnuGamesCubilete.Text = "C&ubilete"
        '
        'mnuSettings
        '
        Me.mnuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSettingsPlayer, Me.mnuSettingsReset, Me.ExitToolStripMenuItem})
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnuSettings.Text = "&Settings"
        '
        'mnuSettingsPlayer
        '
        Me.mnuSettingsPlayer.Name = "mnuSettingsPlayer"
        Me.mnuSettingsPlayer.Size = New System.Drawing.Size(141, 22)
        Me.mnuSettingsPlayer.Text = "&Player Name"
        '
        'mnuSettingsReset
        '
        Me.mnuSettingsReset.Name = "mnuSettingsReset"
        Me.mnuSettingsReset.Size = New System.Drawing.Size(141, 22)
        Me.mnuSettingsReset.Text = "&Reset Scores"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel4)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblPlayerName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(18, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 463)
        Me.Panel1.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(94, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 20)
        Me.lblName.TabIndex = 13
        '
        'lblCubileteScore
        '
        Me.lblCubileteScore.AutoSize = True
        Me.lblCubileteScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCubileteScore.Location = New System.Drawing.Point(3, 137)
        Me.lblCubileteScore.Name = "lblCubileteScore"
        Me.lblCubileteScore.Size = New System.Drawing.Size(25, 25)
        Me.lblCubileteScore.TabIndex = 12
        Me.lblCubileteScore.Text = "0"
        '
        'lblRockPaperScissorsScore
        '
        Me.lblRockPaperScissorsScore.AutoSize = True
        Me.lblRockPaperScissorsScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRockPaperScissorsScore.Location = New System.Drawing.Point(3, 162)
        Me.lblRockPaperScissorsScore.Name = "lblRockPaperScissorsScore"
        Me.lblRockPaperScissorsScore.Size = New System.Drawing.Size(32, 25)
        Me.lblRockPaperScissorsScore.TabIndex = 11
        Me.lblRockPaperScissorsScore.Text = "0 "
        '
        'lblNumberScore
        '
        Me.lblNumberScore.AutoSize = True
        Me.lblNumberScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberScore.Location = New System.Drawing.Point(3, 162)
        Me.lblNumberScore.Name = "lblNumberScore"
        Me.lblNumberScore.Size = New System.Drawing.Size(25, 25)
        Me.lblNumberScore.TabIndex = 10
        Me.lblNumberScore.Text = "0"
        '
        'lblCoinScore
        '
        Me.lblCoinScore.AutoSize = True
        Me.lblCoinScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinScore.Location = New System.Drawing.Point(3, 137)
        Me.lblCoinScore.Name = "lblCoinScore"
        Me.lblCoinScore.Size = New System.Drawing.Size(25, 25)
        Me.lblCoinScore.TabIndex = 9
        Me.lblCoinScore.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cubilete        "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 50)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Rock, Paper, Scissors:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 50)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Number Guessing  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Coin Toss"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(88, 12)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(0, 20)
        Me.lblPlayerName.TabIndex = 3
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblCoinScore)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(18, 45)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(152, 192)
        Me.FlowLayoutPanel1.TabIndex = 14
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.lblNumberScore)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(18, 253)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(152, 194)
        Me.FlowLayoutPanel2.TabIndex = 15
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.PictureBox3)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel3.Controls.Add(Me.lblRockPaperScissorsScore)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(196, 48)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(157, 189)
        Me.FlowLayoutPanel3.TabIndex = 16
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.PictureBox4)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel4.Controls.Add(Me.lblCubileteScore)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(196, 256)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(157, 191)
        Me.FlowLayoutPanel4.TabIndex = 17
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.EasyGames.My.Resources.Resources.cubilete_head_main
        Me.PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(149, 106)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.EasyGames.My.Resources.Resources.RockPaperScissors_3015010k
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(149, 106)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.EasyGames.My.Resources.Resources.GuessMyNumber
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EasyGames.My.Resources.Resources.iStock_coin_tosses
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "EasyGames"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuGames As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGamesCoin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGamesNumber As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGamesTicTacToe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGamesCubilete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettingsPlayer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettingsReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCubileteScore As System.Windows.Forms.Label
    Friend WithEvents lblRockPaperScissorsScore As System.Windows.Forms.Label
    Friend WithEvents lblNumberScore As System.Windows.Forms.Label
    Friend WithEvents lblCoinScore As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
