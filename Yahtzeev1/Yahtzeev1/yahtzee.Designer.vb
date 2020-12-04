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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.grpDice = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDice.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 115)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 77)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "(dice visual)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 115)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 77)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "(dice visual)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(270, 115)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 77)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "(dice visual)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(186, 115)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 77)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "(dice visual)"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(354, 115)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 77)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "(dice visual)"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'grpDice
        '
        Me.grpDice.Controls.Add(Me.Button6)
        Me.grpDice.Controls.Add(Me.Button7)
        Me.grpDice.Controls.Add(Me.Button8)
        Me.grpDice.Controls.Add(Me.Button9)
        Me.grpDice.Controls.Add(Me.Button10)
        Me.grpDice.Controls.Add(Me.Button5)
        Me.grpDice.Controls.Add(Me.Button3)
        Me.grpDice.Controls.Add(Me.Button4)
        Me.grpDice.Controls.Add(Me.Button2)
        Me.grpDice.Controls.Add(Me.Button1)
        Me.grpDice.Location = New System.Drawing.Point(345, 231)
        Me.grpDice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDice.Name = "grpDice"
        Me.grpDice.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDice.Size = New System.Drawing.Size(450, 231)
        Me.grpDice.TabIndex = 5
        Me.grpDice.TabStop = False
        Me.grpDice.Text = "Dice"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(354, 29)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 77)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "(dice visual)"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(270, 29)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 77)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "(dice visual)"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(186, 29)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 77)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "(dice visual)"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(102, 29)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 77)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "(dice visual)"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(18, 29)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 77)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "(dice visual)"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
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
        'yahtzee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents grpDice As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents lstScores As ListBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
