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
        Me.txtDie5 = New System.Windows.Forms.TextBox()
        Me.txtDie4 = New System.Windows.Forms.TextBox()
        Me.txtDie3 = New System.Windows.Forms.TextBox()
        Me.txtDie2 = New System.Windows.Forms.TextBox()
        Me.txtDie1 = New System.Windows.Forms.TextBox()
        Me.btnKeepDie5 = New System.Windows.Forms.Button()
        Me.btnKeepDie4 = New System.Windows.Forms.Button()
        Me.btnKeepDie3 = New System.Windows.Forms.Button()
        Me.btnKeepDie2 = New System.Windows.Forms.Button()
        Me.btnKeepDie1 = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.cbxDebug = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblKeep = New System.Windows.Forms.Label()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.GbxScore = New System.Windows.Forms.GroupBox()
        Me.rdbChance = New System.Windows.Forms.RadioButton()
        Me.rdbYahtzee = New System.Windows.Forms.RadioButton()
        Me.rdbLgStraight = New System.Windows.Forms.RadioButton()
        Me.rdbSmStraight = New System.Windows.Forms.RadioButton()
        Me.rdbFullHouse = New System.Windows.Forms.RadioButton()
        Me.rdb4OfKind = New System.Windows.Forms.RadioButton()
        Me.rdb3OfKind = New System.Windows.Forms.RadioButton()
        Me.rdbSixes = New System.Windows.Forms.RadioButton()
        Me.rdbFives = New System.Windows.Forms.RadioButton()
        Me.rdbFours = New System.Windows.Forms.RadioButton()
        Me.rdbThrees = New System.Windows.Forms.RadioButton()
        Me.rdbTwos = New System.Windows.Forms.RadioButton()
        Me.rdbOnes = New System.Windows.Forms.RadioButton()
        Me.btnMarkScore = New System.Windows.Forms.Button()
        Me.btnDebugRoll = New System.Windows.Forms.Button()
        Me.grpDice.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        Me.GbxScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRollDie1
        '
        Me.btnRollDie1.Location = New System.Drawing.Point(12, 75)
        Me.btnRollDie1.Name = "btnRollDie1"
        Me.btnRollDie1.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie1.TabIndex = 0
        Me.btnRollDie1.TabStop = False
        Me.btnRollDie1.UseVisualStyleBackColor = True
        '
        'btnRollDie2
        '
        Me.btnRollDie2.Location = New System.Drawing.Point(68, 75)
        Me.btnRollDie2.Name = "btnRollDie2"
        Me.btnRollDie2.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie2.TabIndex = 1
        Me.btnRollDie2.TabStop = False
        Me.btnRollDie2.UseVisualStyleBackColor = True
        '
        'btnRollDie4
        '
        Me.btnRollDie4.Location = New System.Drawing.Point(180, 75)
        Me.btnRollDie4.Name = "btnRollDie4"
        Me.btnRollDie4.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie4.TabIndex = 3
        Me.btnRollDie4.TabStop = False
        Me.btnRollDie4.UseVisualStyleBackColor = True
        '
        'btnRollDie3
        '
        Me.btnRollDie3.Location = New System.Drawing.Point(124, 75)
        Me.btnRollDie3.Name = "btnRollDie3"
        Me.btnRollDie3.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie3.TabIndex = 2
        Me.btnRollDie3.TabStop = False
        Me.btnRollDie3.UseVisualStyleBackColor = True
        '
        'btnRollDie5
        '
        Me.btnRollDie5.Location = New System.Drawing.Point(236, 75)
        Me.btnRollDie5.Name = "btnRollDie5"
        Me.btnRollDie5.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie5.TabIndex = 4
        Me.btnRollDie5.TabStop = False
        Me.btnRollDie5.UseVisualStyleBackColor = True
        '
        'grpDice
        '
        Me.grpDice.Controls.Add(Me.txtDie5)
        Me.grpDice.Controls.Add(Me.txtDie4)
        Me.grpDice.Controls.Add(Me.txtDie3)
        Me.grpDice.Controls.Add(Me.txtDie2)
        Me.grpDice.Controls.Add(Me.txtDie1)
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
        Me.grpDice.Location = New System.Drawing.Point(230, 150)
        Me.grpDice.Name = "grpDice"
        Me.grpDice.Size = New System.Drawing.Size(300, 135)
        Me.grpDice.TabIndex = 5
        Me.grpDice.TabStop = False
        Me.grpDice.Text = "Dice"
        '
        'txtDie5
        '
        Me.txtDie5.Location = New System.Drawing.Point(236, 130)
        Me.txtDie5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDie5.Name = "txtDie5"
        Me.txtDie5.Size = New System.Drawing.Size(32, 20)
        Me.txtDie5.TabIndex = 14
        Me.txtDie5.Text = "1"
        Me.txtDie5.Visible = False
        '
        'txtDie4
        '
        Me.txtDie4.Location = New System.Drawing.Point(180, 128)
        Me.txtDie4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDie4.Name = "txtDie4"
        Me.txtDie4.Size = New System.Drawing.Size(32, 20)
        Me.txtDie4.TabIndex = 13
        Me.txtDie4.Text = "1"
        Me.txtDie4.Visible = False
        '
        'txtDie3
        '
        Me.txtDie3.Location = New System.Drawing.Point(124, 128)
        Me.txtDie3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDie3.Name = "txtDie3"
        Me.txtDie3.Size = New System.Drawing.Size(32, 20)
        Me.txtDie3.TabIndex = 12
        Me.txtDie3.Text = "1"
        Me.txtDie3.Visible = False
        '
        'txtDie2
        '
        Me.txtDie2.Location = New System.Drawing.Point(68, 128)
        Me.txtDie2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDie2.Name = "txtDie2"
        Me.txtDie2.Size = New System.Drawing.Size(32, 20)
        Me.txtDie2.TabIndex = 11
        Me.txtDie2.Text = "1"
        Me.txtDie2.Visible = False
        '
        'txtDie1
        '
        Me.txtDie1.Location = New System.Drawing.Point(12, 128)
        Me.txtDie1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDie1.Name = "txtDie1"
        Me.txtDie1.Size = New System.Drawing.Size(32, 20)
        Me.txtDie1.TabIndex = 10
        Me.txtDie1.Text = "1"
        Me.txtDie1.Visible = False
        '
        'btnKeepDie5
        '
        Me.btnKeepDie5.Location = New System.Drawing.Point(236, 19)
        Me.btnKeepDie5.Name = "btnKeepDie5"
        Me.btnKeepDie5.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie5.TabIndex = 9
        Me.btnKeepDie5.TabStop = False
        Me.btnKeepDie5.UseVisualStyleBackColor = True
        Me.btnKeepDie5.Visible = False
        '
        'btnKeepDie4
        '
        Me.btnKeepDie4.Location = New System.Drawing.Point(180, 19)
        Me.btnKeepDie4.Name = "btnKeepDie4"
        Me.btnKeepDie4.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie4.TabIndex = 8
        Me.btnKeepDie4.TabStop = False
        Me.btnKeepDie4.UseVisualStyleBackColor = True
        Me.btnKeepDie4.Visible = False
        '
        'btnKeepDie3
        '
        Me.btnKeepDie3.Location = New System.Drawing.Point(124, 19)
        Me.btnKeepDie3.Name = "btnKeepDie3"
        Me.btnKeepDie3.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie3.TabIndex = 7
        Me.btnKeepDie3.TabStop = False
        Me.btnKeepDie3.UseVisualStyleBackColor = True
        Me.btnKeepDie3.Visible = False
        '
        'btnKeepDie2
        '
        Me.btnKeepDie2.Location = New System.Drawing.Point(68, 19)
        Me.btnKeepDie2.Name = "btnKeepDie2"
        Me.btnKeepDie2.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie2.TabIndex = 6
        Me.btnKeepDie2.TabStop = False
        Me.btnKeepDie2.UseVisualStyleBackColor = True
        Me.btnKeepDie2.Visible = False
        '
        'btnKeepDie1
        '
        Me.btnKeepDie1.Location = New System.Drawing.Point(12, 19)
        Me.btnKeepDie1.Name = "btnKeepDie1"
        Me.btnKeepDie1.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie1.TabIndex = 5
        Me.btnKeepDie1.TabStop = False
        Me.btnKeepDie1.UseVisualStyleBackColor = True
        Me.btnKeepDie1.Visible = False
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.Location = New System.Drawing.Point(34, 58)
        Me.lstScores.MultiColumn = True
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(173, 303)
        Me.lstScores.TabIndex = 11
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(455, 121)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 12
        Me.btnRoll.Text = "Roll!"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMenu.Location = New System.Drawing.Point(230, 121)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 13
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.cbxDebug)
        Me.grpMenu.Controls.Add(Me.btnReset)
        Me.grpMenu.Controls.Add(Me.btnExit)
        Me.grpMenu.Location = New System.Drawing.Point(260, 300)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(88, 135)
        Me.grpMenu.TabIndex = 14
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Menu"
        Me.grpMenu.Visible = False
        '
        'cbxDebug
        '
        Me.cbxDebug.AutoSize = True
        Me.cbxDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDebug.Location = New System.Drawing.Point(14, 95)
        Me.cbxDebug.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxDebug.Name = "cbxDebug"
        Me.cbxDebug.Size = New System.Drawing.Size(56, 17)
        Me.cbxDebug.TabIndex = 2
        Me.cbxDebug.Text = "debug"
        Me.cbxDebug.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(6, 48)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset Game"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(6, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblKeep
        '
        Me.lblKeep.AutoSize = True
        Me.lblKeep.Location = New System.Drawing.Point(535, 169)
        Me.lblKeep.Name = "lblKeep"
        Me.lblKeep.Size = New System.Drawing.Size(48, 13)
        Me.lblKeep.TabIndex = 15
        Me.lblKeep.Text = "To Keep"
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Location = New System.Drawing.Point(535, 262)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(41, 13)
        Me.lblRoll.TabIndex = 16
        Me.lblRoll.Text = "To Roll"
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(344, 121)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(75, 23)
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
        Me.GbxScore.Location = New System.Drawing.Point(588, 58)
        Me.GbxScore.Name = "GbxScore"
        Me.GbxScore.Size = New System.Drawing.Size(195, 325)
        Me.GbxScore.TabIndex = 18
        Me.GbxScore.TabStop = False
        Me.GbxScore.Text = "Yahtzee Scoring"
        Me.GbxScore.Visible = False
        '
        'rdbChance
        '
        Me.rdbChance.AutoSize = True
        Me.rdbChance.Location = New System.Drawing.Point(5, 276)
        Me.rdbChance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbChance.Name = "rdbChance"
        Me.rdbChance.Size = New System.Drawing.Size(62, 17)
        Me.rdbChance.TabIndex = 13
        Me.rdbChance.TabStop = True
        Me.rdbChance.Text = "Chance"
        Me.rdbChance.UseVisualStyleBackColor = True
        '
        'rdbYahtzee
        '
        Me.rdbYahtzee.AutoSize = True
        Me.rdbYahtzee.Location = New System.Drawing.Point(5, 256)
        Me.rdbYahtzee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbYahtzee.Name = "rdbYahtzee"
        Me.rdbYahtzee.Size = New System.Drawing.Size(67, 17)
        Me.rdbYahtzee.TabIndex = 12
        Me.rdbYahtzee.TabStop = True
        Me.rdbYahtzee.Text = "Yahtzee!"
        Me.rdbYahtzee.UseVisualStyleBackColor = True
        '
        'rdbLgStraight
        '
        Me.rdbLgStraight.AutoSize = True
        Me.rdbLgStraight.Location = New System.Drawing.Point(5, 237)
        Me.rdbLgStraight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbLgStraight.Name = "rdbLgStraight"
        Me.rdbLgStraight.Size = New System.Drawing.Size(91, 17)
        Me.rdbLgStraight.TabIndex = 11
        Me.rdbLgStraight.TabStop = True
        Me.rdbLgStraight.Text = "Large Straight"
        Me.rdbLgStraight.UseVisualStyleBackColor = True
        '
        'rdbSmStraight
        '
        Me.rdbSmStraight.AutoSize = True
        Me.rdbSmStraight.Location = New System.Drawing.Point(5, 217)
        Me.rdbSmStraight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbSmStraight.Name = "rdbSmStraight"
        Me.rdbSmStraight.Size = New System.Drawing.Size(89, 17)
        Me.rdbSmStraight.TabIndex = 10
        Me.rdbSmStraight.TabStop = True
        Me.rdbSmStraight.Text = "Small Straight"
        Me.rdbSmStraight.UseVisualStyleBackColor = True
        '
        'rdbFullHouse
        '
        Me.rdbFullHouse.AutoSize = True
        Me.rdbFullHouse.Location = New System.Drawing.Point(5, 198)
        Me.rdbFullHouse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbFullHouse.Name = "rdbFullHouse"
        Me.rdbFullHouse.Size = New System.Drawing.Size(75, 17)
        Me.rdbFullHouse.TabIndex = 9
        Me.rdbFullHouse.TabStop = True
        Me.rdbFullHouse.Text = "Full House"
        Me.rdbFullHouse.UseVisualStyleBackColor = True
        '
        'rdb4OfKind
        '
        Me.rdb4OfKind.AutoSize = True
        Me.rdb4OfKind.Location = New System.Drawing.Point(4, 178)
        Me.rdb4OfKind.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdb4OfKind.Name = "rdb4OfKind"
        Me.rdb4OfKind.Size = New System.Drawing.Size(91, 17)
        Me.rdb4OfKind.TabIndex = 8
        Me.rdb4OfKind.TabStop = True
        Me.rdb4OfKind.Text = "Four-of-a-Kind"
        Me.rdb4OfKind.UseVisualStyleBackColor = True
        '
        'rdb3OfKind
        '
        Me.rdb3OfKind.AutoSize = True
        Me.rdb3OfKind.Location = New System.Drawing.Point(4, 159)
        Me.rdb3OfKind.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdb3OfKind.Name = "rdb3OfKind"
        Me.rdb3OfKind.Size = New System.Drawing.Size(98, 17)
        Me.rdb3OfKind.TabIndex = 7
        Me.rdb3OfKind.TabStop = True
        Me.rdb3OfKind.Text = "Three-of-a-Kind"
        Me.rdb3OfKind.UseVisualStyleBackColor = True
        '
        'rdbSixes
        '
        Me.rdbSixes.AutoSize = True
        Me.rdbSixes.Location = New System.Drawing.Point(5, 122)
        Me.rdbSixes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbSixes.Name = "rdbSixes"
        Me.rdbSixes.Size = New System.Drawing.Size(50, 17)
        Me.rdbSixes.TabIndex = 6
        Me.rdbSixes.TabStop = True
        Me.rdbSixes.Text = "Sixes"
        Me.rdbSixes.UseVisualStyleBackColor = True
        '
        'rdbFives
        '
        Me.rdbFives.AutoSize = True
        Me.rdbFives.Location = New System.Drawing.Point(5, 102)
        Me.rdbFives.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbFives.Name = "rdbFives"
        Me.rdbFives.Size = New System.Drawing.Size(50, 17)
        Me.rdbFives.TabIndex = 5
        Me.rdbFives.TabStop = True
        Me.rdbFives.Text = "Fives"
        Me.rdbFives.UseVisualStyleBackColor = True
        '
        'rdbFours
        '
        Me.rdbFours.AutoSize = True
        Me.rdbFours.Location = New System.Drawing.Point(5, 83)
        Me.rdbFours.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbFours.Name = "rdbFours"
        Me.rdbFours.Size = New System.Drawing.Size(51, 17)
        Me.rdbFours.TabIndex = 4
        Me.rdbFours.TabStop = True
        Me.rdbFours.Text = "Fours"
        Me.rdbFours.UseVisualStyleBackColor = True
        '
        'rdbThrees
        '
        Me.rdbThrees.AutoSize = True
        Me.rdbThrees.Location = New System.Drawing.Point(4, 63)
        Me.rdbThrees.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbThrees.Name = "rdbThrees"
        Me.rdbThrees.Size = New System.Drawing.Size(58, 17)
        Me.rdbThrees.TabIndex = 3
        Me.rdbThrees.TabStop = True
        Me.rdbThrees.Text = "Threes"
        Me.rdbThrees.UseVisualStyleBackColor = True
        '
        'rdbTwos
        '
        Me.rdbTwos.AutoSize = True
        Me.rdbTwos.Location = New System.Drawing.Point(4, 45)
        Me.rdbTwos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbTwos.Name = "rdbTwos"
        Me.rdbTwos.Size = New System.Drawing.Size(51, 17)
        Me.rdbTwos.TabIndex = 2
        Me.rdbTwos.TabStop = True
        Me.rdbTwos.Text = "Twos"
        Me.rdbTwos.UseVisualStyleBackColor = True
        '
        'rdbOnes
        '
        Me.rdbOnes.AutoSize = True
        Me.rdbOnes.Location = New System.Drawing.Point(5, 25)
        Me.rdbOnes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdbOnes.Name = "rdbOnes"
        Me.rdbOnes.Size = New System.Drawing.Size(50, 17)
        Me.rdbOnes.TabIndex = 1
        Me.rdbOnes.TabStop = True
        Me.rdbOnes.Text = "Ones"
        Me.rdbOnes.UseVisualStyleBackColor = True
        '
        'btnMarkScore
        '
        Me.btnMarkScore.Location = New System.Drawing.Point(68, 291)
        Me.btnMarkScore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMarkScore.Name = "btnMarkScore"
        Me.btnMarkScore.Size = New System.Drawing.Size(69, 22)
        Me.btnMarkScore.TabIndex = 0
        Me.btnMarkScore.Text = "Mark Score"
        Me.btnMarkScore.UseVisualStyleBackColor = True
        '
        'btnDebugRoll
        '
        Me.btnDebugRoll.Location = New System.Drawing.Point(455, 308)
        Me.btnDebugRoll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDebugRoll.Name = "btnDebugRoll"
        Me.btnDebugRoll.Size = New System.Drawing.Size(74, 27)
        Me.btnDebugRoll.TabIndex = 19
        Me.btnDebugRoll.Text = "DebugRoll"
        Me.btnDebugRoll.UseVisualStyleBackColor = True
        Me.btnDebugRoll.Visible = False
        '
        'yahtzee
        '
        Me.AcceptButton = Me.btnRoll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnMenu
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDebugRoll)
        Me.Controls.Add(Me.GbxScore)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.lblRoll)
        Me.Controls.Add(Me.lblKeep)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.grpDice)
        Me.Name = "yahtzee"
        Me.Text = "Yahtzee"
        Me.grpDice.ResumeLayout(False)
        Me.grpDice.PerformLayout()
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
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
    Friend WithEvents cbxDebug As CheckBox
    Friend WithEvents txtDie5 As TextBox
    Friend WithEvents txtDie4 As TextBox
    Friend WithEvents txtDie3 As TextBox
    Friend WithEvents txtDie2 As TextBox
    Friend WithEvents txtDie1 As TextBox
    Friend WithEvents btnDebugRoll As Button
End Class
