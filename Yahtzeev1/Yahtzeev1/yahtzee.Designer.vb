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
        Me.grpDice.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRollDie1
        '
        Me.btnRollDie1.Location = New System.Drawing.Point(12, 75)
        Me.btnRollDie1.Name = "btnRollDie1"
        Me.btnRollDie1.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie1.TabIndex = 0
        Me.btnRollDie1.UseVisualStyleBackColor = True
        '
        'btnRollDie2
        '
        Me.btnRollDie2.Location = New System.Drawing.Point(68, 75)
        Me.btnRollDie2.Name = "btnRollDie2"
        Me.btnRollDie2.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie2.TabIndex = 1
        Me.btnRollDie2.UseVisualStyleBackColor = True
        '
        'btnRollDie4
        '
        Me.btnRollDie4.Location = New System.Drawing.Point(180, 75)
        Me.btnRollDie4.Name = "btnRollDie4"
        Me.btnRollDie4.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie4.TabIndex = 3
        Me.btnRollDie4.UseVisualStyleBackColor = True
        '
        'btnRollDie3
        '
        Me.btnRollDie3.Location = New System.Drawing.Point(124, 75)
        Me.btnRollDie3.Name = "btnRollDie3"
        Me.btnRollDie3.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie3.TabIndex = 2
        Me.btnRollDie3.UseVisualStyleBackColor = True
        '
        'btnRollDie5
        '
        Me.btnRollDie5.Location = New System.Drawing.Point(236, 75)
        Me.btnRollDie5.Name = "btnRollDie5"
        Me.btnRollDie5.Size = New System.Drawing.Size(50, 50)
        Me.btnRollDie5.TabIndex = 4
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
        Me.grpDice.Location = New System.Drawing.Point(230, 150)
        Me.grpDice.Name = "grpDice"
        Me.grpDice.Size = New System.Drawing.Size(300, 150)
        Me.grpDice.TabIndex = 5
        Me.grpDice.TabStop = False
        Me.grpDice.Text = "Dice"
        '
        'btnKeepDie5
        '
        Me.btnKeepDie5.Location = New System.Drawing.Point(236, 19)
        Me.btnKeepDie5.Name = "btnKeepDie5"
        Me.btnKeepDie5.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie5.TabIndex = 9
        Me.btnKeepDie5.UseVisualStyleBackColor = True
        Me.btnKeepDie5.Visible = False
        '
        'btnKeepDie4
        '
        Me.btnKeepDie4.Location = New System.Drawing.Point(180, 19)
        Me.btnKeepDie4.Name = "btnKeepDie4"
        Me.btnKeepDie4.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie4.TabIndex = 8
        Me.btnKeepDie4.UseVisualStyleBackColor = True
        Me.btnKeepDie4.Visible = False
        '
        'btnKeepDie3
        '
        Me.btnKeepDie3.Location = New System.Drawing.Point(124, 19)
        Me.btnKeepDie3.Name = "btnKeepDie3"
        Me.btnKeepDie3.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie3.TabIndex = 7
        Me.btnKeepDie3.UseVisualStyleBackColor = True
        Me.btnKeepDie3.Visible = False
        '
        'btnKeepDie2
        '
        Me.btnKeepDie2.Location = New System.Drawing.Point(68, 19)
        Me.btnKeepDie2.Name = "btnKeepDie2"
        Me.btnKeepDie2.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie2.TabIndex = 6
        Me.btnKeepDie2.UseVisualStyleBackColor = True
        Me.btnKeepDie2.Visible = False
        '
        'btnKeepDie1
        '
        Me.btnKeepDie1.Location = New System.Drawing.Point(12, 19)
        Me.btnKeepDie1.Name = "btnKeepDie1"
        Me.btnKeepDie1.Size = New System.Drawing.Size(50, 50)
        Me.btnKeepDie1.TabIndex = 5
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
        Me.btnMenu.Location = New System.Drawing.Point(230, 121)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 13
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.btnReset)
        Me.grpMenu.Controls.Add(Me.btnExit)
        Me.grpMenu.Location = New System.Drawing.Point(260, 300)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(88, 150)
        Me.grpMenu.TabIndex = 14
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Menu"
        Me.grpMenu.Visible = False
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
        Me.lblKeep.Location = New System.Drawing.Point(537, 169)
        Me.lblKeep.Name = "lblKeep"
        Me.lblKeep.Size = New System.Drawing.Size(48, 13)
        Me.lblKeep.TabIndex = 15
        Me.lblKeep.Text = "To Keep"
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Location = New System.Drawing.Point(537, 225)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(41, 13)
        Me.lblRoll.TabIndex = 16
        Me.lblRoll.Text = "To Roll"
        '
        'yahtzee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.grpMenu.ResumeLayout(False)
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
End Class
