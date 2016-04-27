<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CubileteForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDie4 = New System.Windows.Forms.Button()
        Me.btnDie3 = New System.Windows.Forms.Button()
        Me.btnDie2 = New System.Windows.Forms.Button()
        Me.btnDie1 = New System.Windows.Forms.Button()
        Me.btnDie0 = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDie4)
        Me.Panel1.Controls.Add(Me.btnDie3)
        Me.Panel1.Controls.Add(Me.btnDie2)
        Me.Panel1.Controls.Add(Me.btnDie1)
        Me.Panel1.Controls.Add(Me.btnDie0)
        Me.Panel1.Location = New System.Drawing.Point(16, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 142)
        Me.Panel1.TabIndex = 3
        '
        'btnDie4
        '
        Me.btnDie4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDie4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDie4.Location = New System.Drawing.Point(422, 34)
        Me.btnDie4.Name = "btnDie4"
        Me.btnDie4.Size = New System.Drawing.Size(75, 73)
        Me.btnDie4.TabIndex = 4
        Me.btnDie4.TabStop = False
        Me.btnDie4.UseVisualStyleBackColor = False
        '
        'btnDie3
        '
        Me.btnDie3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDie3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDie3.Location = New System.Drawing.Point(319, 34)
        Me.btnDie3.Name = "btnDie3"
        Me.btnDie3.Size = New System.Drawing.Size(75, 73)
        Me.btnDie3.TabIndex = 3
        Me.btnDie3.TabStop = False
        Me.btnDie3.UseVisualStyleBackColor = False
        '
        'btnDie2
        '
        Me.btnDie2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDie2.Location = New System.Drawing.Point(216, 34)
        Me.btnDie2.Name = "btnDie2"
        Me.btnDie2.Size = New System.Drawing.Size(75, 73)
        Me.btnDie2.TabIndex = 2
        Me.btnDie2.TabStop = False
        Me.btnDie2.UseVisualStyleBackColor = False
        '
        'btnDie1
        '
        Me.btnDie1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDie1.Location = New System.Drawing.Point(118, 34)
        Me.btnDie1.Name = "btnDie1"
        Me.btnDie1.Size = New System.Drawing.Size(75, 73)
        Me.btnDie1.TabIndex = 1
        Me.btnDie1.TabStop = False
        Me.btnDie1.UseVisualStyleBackColor = False
        '
        'btnDie0
        '
        Me.btnDie0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDie0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDie0.Location = New System.Drawing.Point(23, 34)
        Me.btnDie0.Name = "btnDie0"
        Me.btnDie0.Size = New System.Drawing.Size(75, 73)
        Me.btnDie0.TabIndex = 0
        Me.btnDie0.TabStop = False
        Me.btnDie0.UseVisualStyleBackColor = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(164, 203)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(218, 47)
        Me.btnRoll.TabIndex = 4
        Me.btnRoll.Text = "Roll the Cubilete!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnExit.Location = New System.Drawing.Point(452, 203)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 47)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(22, 203)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(89, 47)
        Me.btnNewGame.TabIndex = 8
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(77, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 20)
        Me.lblName.TabIndex = 14
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(490, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(49, 20)
        Me.lblScore.TabIndex = 13
        Me.lblScore.Text = "0000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(418, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Score: "
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(77, 9)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(0, 20)
        Me.lblPlayerName.TabIndex = 15
        '
        'CubileteForm
        '
        Me.AcceptButton = Me.btnRoll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(564, 275)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CubileteForm"
        Me.Text = "Cubilete"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDie4 As System.Windows.Forms.Button
    Friend WithEvents btnDie3 As System.Windows.Forms.Button
    Friend WithEvents btnDie2 As System.Windows.Forms.Button
    Friend WithEvents btnDie1 As System.Windows.Forms.Button
    Friend WithEvents btnDie0 As System.Windows.Forms.Button
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
End Class
