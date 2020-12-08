<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yahtzee
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
        Me.btnRollDie1 = New System.Windows.Forms.Button()
        Me.btnRollDie2 = New System.Windows.Forms.Button()
        Me.btnRollDie4 = New System.Windows.Forms.Button()
        Me.btnRollDie3 = New System.Windows.Forms.Button()
        Me.btnRollDie5 = New System.Windows.Forms.Button()
        Me.grpDice = New System.Windows.Forms.GroupBox()
        Me.btnKeepDie5 = New System.Windows.Forms.Button()
        Me.btnKeepDie4 = New System.Windows.Forms.Button()
        Me.btnKeepDie3 = New System.Windows.Forms.Button()
        Me.btnKeepDie2 = New System.Windows.Forms.Button()
        Me.btnKeepDie1 = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblKeep = New System.Windows.Forms.Label()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.GbxScore = New System.Windows.Forms.GroupBox()
        Me.btnMarkScore = New System.Windows.Forms.Button()
        Me.rdbOnes = New System.Windows.Forms.RadioButton()
        Me.rdbTwos = New System.Windows.Forms.RadioButton()
        Me.rdbThrees = New System.Windows.Forms.RadioButton()
        Me.rdbFours = New System.Windows.Forms.RadioButton()
        Me.rdbFives = New System.Windows.Forms.RadioButton()
        Me.rdbSixes = New System.Windows.Forms.RadioButton()
        Me.rdb3OfKind = New System.Windows.Forms.RadioButton()
        Me.rdb4OfKind = New System.Windows.Forms.RadioButton()
        Me.rdbFullHouse = New System.Windows.Forms.RadioButton()
        Me.rdbSmStraight = New System.Windows.Forms.RadioButton()
        Me.rdbLgStraight = New System.Windows.Forms.RadioButton()
        Me.rdbYahtzee = New System.Windows.Forms.RadioButton()
        Me.rdbChance = New System.Windows.Forms.RadioButton()
        Me.grpDice.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        Me.GbxScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRollDie1
        '
        Me.btnRollDie1.Location = New System.Drawing.Point(18, 115)
        Me.btnRollDie1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRollDie1.Name = "btnRollDie1"
        Me.btnRollDie1.Size = New System.Drawing.Size(75, 77)
        Me.btnRollDie1.TabIndex = 0
        Me.btnRollDie1.TabStop = False
        Me.btnRollDie1.UseVisualStyleBackColor = True
        '
        'btnRollDie2
        '
        Me.btnRollDie2.Location = New System.Drawing.Point(102, 115)
        Me.btnRollDie2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRollDie2.Name = "btnRollDie2"
        Me.btnRollDie2.Size = New System.Drawing.Size(75, 77)
        Me.btnRollDie2.TabIndex = 1
        Me.btnRollDie2.TabStop = False
        Me.btnRollDie2.UseVisualStyleBackColor = True
        '
        'btnRollDie4
        '
        Me.btnRollDie4.Location = New System.Drawing.Point(270, 115)
        Me.btnRollDie4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRollDie4.Name = "btnRollDie4"
        Me.btnRollDie4.Size = New System.Drawing.Size(75, 77)
        Me.btnRollDie4.TabIndex = 3
        Me.btnRollDie4.TabStop = False
        Me.btnRollDie4.UseVisualStyleBackColor = True
        '
        'btnRollDie3
        '
        Me.btnRollDie3.Location = New System.Drawing.Point(186, 115)
        Me.btnRollDie3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRollDie3.Name = "btnRollDie3"
        Me.btnRollDie3.Size = New System.Drawing.Size(75, 77)
        Me.btnRollDie3.TabIndex = 2
        Me.btnRollDie3.TabStop = False
        Me.btnRollDie3.UseVisualStyleBackColor = True
        '
        'btnRollDie5
        '
        Me.btnRollDie5.Location = New System.Drawing.Point(354, 115)
        Me.btnRollDie5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRollDie5.Name = "btnRollDie5"
        Me.btnRollDie5.Size = New System.Drawing.Size(75, 77)
        Me.btnRollDie5.TabIndex = 4
        Me.btnRollDie5.TabStop = False
        Me.btnRollDie5.UseVisualStyleBackColor = True
        '
        'grpDice
        '
        Me.grpDice.Controls.Add(Me.btnKeepDie5)
        Me.grpDice.Controls.Add(Me.btnKeepDie4)
        Me.grpDice.Controls.Add(Me.btnKeepDie3)
        Me.grpDice.Controls.Add(Me.btnKeepDie2)
        Me.grpDice.Controls.Add(Me.btnKeepDie1)
        Me.grpDice.Controls.Add(Me.btnRollDie5)
        Me.grpDice.Controls.Add(Me.btnRollDie4)
        Me.grpDice.Controls.Add(Me.btnRollDie3)
        Me.grpDice.Controls.Add(Me.btnRollDie2)
        Me.grpDice.Controls.Add(Me.btnRollDie1)
        Me.grpDice.Location = New System.Drawing.Point(345, 231)
        Me.grpDice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDice.Name = "grpDice"
        Me.grpDice.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDice.Size = New System.Drawing.Size(450, 231)
        Me.grpDice.TabIndex = 5
        Me.grpDice.TabStop = False
        Me.grpDice.Text = "Dice"
        '
        'btnKeepDie5
        '
        Me.btnKeepDie5.Location = New System.Drawing.Point(354, 29)
        Me.btnKeepDie5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKeepDie5.Name = "btnKeepDie5"
        Me.btnKeepDie5.Size = New System.Drawing.Size(75, 77)
        Me.btnKeepDie5.TabIndex = 9
        Me.btnKeepDie5.TabStop = False
        Me.btnKeepDie5.UseVisualStyleBackColor = True
        Me.btnKeepDie5.Visible = False
        '
        'btnKeepDie4
        '
        Me.btnKeepDie4.Location = New System.Drawing.Point(270, 29)
        Me.btnKeepDie4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKeepDie4.Name = "btnKeepDie4"
        Me.btnKeepDie4.Size = New System.Drawing.Size(75, 77)
        Me.btnKeepDie4.TabIndex = 8
        Me.btnKeepDie4.TabStop = False
        Me.btnKeepDie4.UseVisualStyleBackColor = True
        Me.btnKeepDie4.Visible = False
        '
        'btnKeepDie3
        '
        Me.btnKeepDie3.Location = New System.Drawing.Point(186, 29)
        Me.btnKeepDie3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKeepDie3.Name = "btnKeepDie3"
        Me.btnKeepDie3.Size = New System.Drawing.Size(75, 77)
        Me.btnKeepDie3.TabIndex = 7
        Me.btnKeepDie3.TabStop = False
        Me.btnKeepDie3.UseVisualStyleBackColor = True
        Me.btnKeepDie3.Visible = False
        '
        'btnKeepDie2
        '
        Me.btnKeepDie2.Location = New System.Drawing.Point(102, 29)
        Me.btnKeepDie2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKeepDie2.Name = "btnKeepDie2"
        Me.btnKeepDie2.Size = New System.Drawing.Size(75, 77)
        Me.btnKeepDie2.TabIndex = 6
        Me.btnKeepDie2.TabStop = False
        Me.btnKeepDie2.UseVisualStyleBackColor = True
        Me.btnKeepDie2.Visible = False
        '
        'btnKeepDie1
        '
        Me.btnKeepDie1.Location = New System.Drawing.Point(18, 29)
        Me.btnKeepDie1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKeepDie1.Name = "btnKeepDie1"
        Me.btnKeepDie1.Size = New System.Drawing.Size(75, 77)
        Me.btnKeepDie1.TabIndex = 5
        Me.btnKeepDie1.TabStop = False
        Me.btnKeepDie1.UseVisualStyleBackColor = True
        Me.btnKeepDie1.Visible = False
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 20
        Me.lstScores.Location = New System.Drawing.Point(51, 89)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstScores.MultiColumn = True
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(258, 464)
        Me.lstScores.TabIndex = 11
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(682, 186)
        Me.btnRoll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(112, 35)
        Me.btnRoll.TabIndex = 12
        Me.btnRoll.Text = "Roll!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMenu.Location = New System.Drawing.Point(345, 186)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 35)
        Me.btnMenu.TabIndex = 13
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.btnReset)
        Me.grpMenu.Controls.Add(Me.btnExit)
        Me.grpMenu.Location = New System.Drawing.Point(390, 462)
        Me.grpMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpMenu.Size = New System.Drawing.Size(132, 231)
        Me.grpMenu.TabIndex = 14
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Menu"
        Me.grpMenu.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(9, 74)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 35)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset Game"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(9, 29)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 35)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblKeep
        '
        Me.lblKeep.AutoSize = True
        Me.lblKeep.Location = New System.Drawing.Point(803, 260)
        Me.lblKeep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKeep.Name = "lblKeep"
        Me.lblKeep.Size = New System.Drawing.Size(68, 20)
        Me.lblKeep.TabIndex = 15
        Me.lblKeep.Text = "To Keep"
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Location = New System.Drawing.Point(803, 403)
        Me.lblRoll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(58, 20)
        Me.lblRoll.TabIndex = 16
        Me.lblRoll.Text = "To Roll"
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(516, 186)
        Me.btnScore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(112, 35)
        Me.btnScore.TabIndex = 17
        Me.btnScore.Text = "Score"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'GbxScore
        '
        Me.GbxScore.Controls.Add(Me.rdbChance)
        Me.GbxScore.Controls.Add(Me.rdbYahtzee)
        Me.GbxScore.Controls.Add(Me.rdbLgStraight)
        Me.GbxScore.Controls.Add(Me.rdbSmStraight)
        Me.GbxScore.Controls.Add(Me.rdbFullHouse)
        Me.GbxScore.Controls.Add(Me.rdb4OfKind)
        Me.GbxScore.Controls.Add(Me.rdb3OfKind)
        Me.GbxScore.Controls.Add(Me.rdbSixes)
        Me.GbxScore.Controls.Add(Me.rdbFives)
        Me.GbxScore.Controls.Add(Me.rdbFours)
        Me.GbxScore.Controls.Add(Me.rdbThrees)
        Me.GbxScore.Controls.Add(Me.rdbTwos)
        Me.GbxScore.Controls.Add(Me.rdbOnes)
        Me.GbxScore.Controls.Add(Me.btnMarkScore)
        Me.GbxScore.Location = New System.Drawing.Point(882, 89)
        Me.GbxScore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GbxScore.Name = "GbxScore"
        Me.GbxScore.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GbxScore.Size = New System.Drawing.Size(293, 482)
        Me.GbxScore.TabIndex = 18
        Me.GbxScore.TabStop = False
        Me.GbxScore.Text = "Yahtzee Scoring"
        Me.GbxScore.Visible = False
        '
        'btnMarkScore
        '
        Me.btnMarkScore.Location = New System.Drawing.Point(119, 447)
        Me.btnMarkScore.Name = "btnMarkScore"
        Me.btnMarkScore.Size = New System.Drawing.Size(75, 27)
        Me.btnMarkScore.TabIndex = 0
        Me.btnMarkScore.Text = "Button1"
        Me.btnMarkScore.UseVisualStyleBackColor = True
        '
        'rdbOnes
        '
        Me.rdbOnes.AutoSize = True
        Me.rdbOnes.Location = New System.Drawing.Point(7, 39)
        Me.rdbOnes.Name = "rdbOnes"
        Me.rdbOnes.Size = New System.Drawing.Size(72, 24)
        Me.rdbOnes.TabIndex = 1
        Me.rdbOnes.TabStop = True
        Me.rdbOnes.Text = "Ones"
        Me.rdbOnes.UseVisualStyleBackColor = True
        '
        'rdbTwos
        '
        Me.rdbTwos.AutoSize = True
        Me.rdbTwos.Location = New System.Drawing.Point(6, 69)
        Me.rdbTwos.Name = "rdbTwos"
        Me.rdbTwos.Size = New System.Drawing.Size(71, 24)
        Me.rdbTwos.TabIndex = 2
        Me.rdbTwos.TabStop = True
        Me.rdbTwos.Text = "Twos"
        Me.rdbTwos.UseVisualStyleBackColor = True
        '
        'rdbThrees
        '
        Me.rdbThrees.AutoSize = True
        Me.rdbThrees.Location = New System.Drawing.Point(6, 97)
        Me.rdbThrees.Name = "rdbThrees"
        Me.rdbThrees.Size = New System.Drawing.Size(83, 24)
        Me.rdbThrees.TabIndex = 3
        Me.rdbThrees.TabStop = True
        Me.rdbThrees.Text = "Threes"
        Me.rdbThrees.UseVisualStyleBackColor = True
        '
        'rdbFours
        '
        Me.rdbFours.AutoSize = True
        Me.rdbFours.Location = New System.Drawing.Point(7, 127)
        Me.rdbFours.Name = "rdbFours"
        Me.rdbFours.Size = New System.Drawing.Size(75, 24)
        Me.rdbFours.TabIndex = 4
        Me.rdbFours.TabStop = True
        Me.rdbFours.Text = "Fours"
        Me.rdbFours.UseVisualStyleBackColor = True
        '
        'rdbFives
        '
        Me.rdbFives.AutoSize = True
        Me.rdbFives.Location = New System.Drawing.Point(7, 157)
        Me.rdbFives.Name = "rdbFives"
        Me.rdbFives.Size = New System.Drawing.Size(71, 24)
        Me.rdbFives.TabIndex = 5
        Me.rdbFives.TabStop = True
        Me.rdbFives.Text = "Fives"
        Me.rdbFives.UseVisualStyleBackColor = True
        '
        'rdbSixes
        '
        Me.rdbSixes.AutoSize = True
        Me.rdbSixes.Location = New System.Drawing.Point(7, 187)
        Me.rdbSixes.Name = "rdbSixes"
        Me.rdbSixes.Size = New System.Drawing.Size(72, 24)
        Me.rdbSixes.TabIndex = 6
        Me.rdbSixes.TabStop = True
        Me.rdbSixes.Text = "Sixes"
        Me.rdbSixes.UseVisualStyleBackColor = True
        '
        'rdb3OfKind
        '
        Me.rdb3OfKind.AutoSize = True
        Me.rdb3OfKind.Location = New System.Drawing.Point(6, 244)
        Me.rdb3OfKind.Name = "rdb3OfKind"
        Me.rdb3OfKind.Size = New System.Drawing.Size(144, 24)
        Me.rdb3OfKind.TabIndex = 7
        Me.rdb3OfKind.TabStop = True
        Me.rdb3OfKind.Text = "Three-of-a-Kind"
        Me.rdb3OfKind.UseVisualStyleBackColor = True
        '
        'rdb4OfKind
        '
        Me.rdb4OfKind.AutoSize = True
        Me.rdb4OfKind.Location = New System.Drawing.Point(6, 274)
        Me.rdb4OfKind.Name = "rdb4OfKind"
        Me.rdb4OfKind.Size = New System.Drawing.Size(136, 24)
        Me.rdb4OfKind.TabIndex = 8
        Me.rdb4OfKind.TabStop = True
        Me.rdb4OfKind.Text = "Four-of-a-Kind"
        Me.rdb4OfKind.UseVisualStyleBackColor = True
        '
        'rdbFullHouse
        '
        Me.rdbFullHouse.AutoSize = True
        Me.rdbFullHouse.Location = New System.Drawing.Point(7, 304)
        Me.rdbFullHouse.Name = "rdbFullHouse"
        Me.rdbFullHouse.Size = New System.Drawing.Size(110, 24)
        Me.rdbFullHouse.TabIndex = 9
        Me.rdbFullHouse.TabStop = True
        Me.rdbFullHouse.Text = "Full House"
        Me.rdbFullHouse.UseVisualStyleBackColor = True
        '
        'rdbSmStraight
        '
        Me.rdbSmStraight.AutoSize = True
        Me.rdbSmStraight.Location = New System.Drawing.Point(7, 334)
        Me.rdbSmStraight.Name = "rdbSmStraight"
        Me.rdbSmStraight.Size = New System.Drawing.Size(133, 24)
        Me.rdbSmStraight.TabIndex = 10
        Me.rdbSmStraight.TabStop = True
        Me.rdbSmStraight.Text = "Small Straight"
        Me.rdbSmStraight.UseVisualStyleBackColor = True
        '
        'rdbLgStraight
        '
        Me.rdbLgStraight.AutoSize = True
        Me.rdbLgStraight.Location = New System.Drawing.Point(7, 364)
        Me.rdbLgStraight.Name = "rdbLgStraight"
        Me.rdbLgStraight.Size = New System.Drawing.Size(135, 24)
        Me.rdbLgStraight.TabIndex = 11
        Me.rdbLgStraight.TabStop = True
        Me.rdbLgStraight.Text = "Large Straight"
        Me.rdbLgStraight.UseVisualStyleBackColor = True
        '
        'rdbYahtzee
        '
        Me.rdbYahtzee.AutoSize = True
        Me.rdbYahtzee.Location = New System.Drawing.Point(7, 394)
        Me.rdbYahtzee.Name = "rdbYahtzee"
        Me.rdbYahtzee.Size = New System.Drawing.Size(98, 24)
        Me.rdbYahtzee.TabIndex = 12
        Me.rdbYahtzee.TabStop = True
        Me.rdbYahtzee.Text = "Yahtzee!"
        Me.rdbYahtzee.UseVisualStyleBackColor = True
        '
        'rdbChance
        '
        Me.rdbChance.AutoSize = True
        Me.rdbChance.Location = New System.Drawing.Point(7, 424)
        Me.rdbChance.Name = "rdbChance"
        Me.rdbChance.Size = New System.Drawing.Size(89, 24)
        Me.rdbChance.TabIndex = 13
        Me.rdbChance.TabStop = True
        Me.rdbChance.Text = "Chance"
        Me.rdbChance.UseVisualStyleBackColor = True
        '
        'yahtzee
        '
        Me.AcceptButton = Me.btnRoll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnMenu
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.GbxScore)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.lblRoll)
        Me.Controls.Add(Me.lblKeep)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.grpDice)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "yahtzee"
        Me.Text = "Yahtzee"
        Me.grpDice.ResumeLayout(False)
        Me.grpMenu.ResumeLayout(False)
        Me.GbxScore.ResumeLayout(False)
        Me.GbxScore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRollDie1 As Button
    Friend WithEvents btnRollDie2 As Button
    Friend WithEvents btnRollDie4 As Button
    Friend WithEvents btnRollDie3 As Button
    Friend WithEvents btnRollDie5 As Button
    Friend WithEvents grpDice As GroupBox
    Friend WithEvents btnKeepDie5 As Button
    Friend WithEvents btnKeepDie4 As Button
    Friend WithEvents btnKeepDie3 As Button
    Friend WithEvents btnKeepDie2 As Button
    Friend WithEvents btnKeepDie1 As Button
    Friend WithEvents lstScores As ListBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblKeep As Label
    Friend WithEvents lblRoll As Label
    Friend WithEvents btnScore As Button
    Friend WithEvents GbxScore As GroupBox
    Friend WithEvents rdbChance As RadioButton
    Friend WithEvents rdbYahtzee As RadioButton
    Friend WithEvents rdbLgStraight As RadioButton
    Friend WithEvents rdbSmStraight As RadioButton
    Friend WithEvents rdbFullHouse As RadioButton
    Friend WithEvents rdb4OfKind As RadioButton
    Friend WithEvents rdb3OfKind As RadioButton
    Friend WithEvents rdbSixes As RadioButton
    Friend WithEvents rdbFives As RadioButton
    Friend WithEvents rdbFours As RadioButton
    Friend WithEvents rdbThrees As RadioButton
    Friend WithEvents rdbTwos As RadioButton
    Friend WithEvents rdbOnes As RadioButton
    Friend WithEvents btnMarkScore As Button
End Class
