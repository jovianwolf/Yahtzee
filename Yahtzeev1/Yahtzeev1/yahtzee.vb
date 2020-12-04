Public Class yahtzee
    'boolean to determine if the menu is shown or not
    Dim blnMenu As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRollDie1.Click
        lstScores.Items.Add("SCORES") '& ControlChars.Tab & ControlChars.Tab & "You" & ControlChars.Tab & "AI")
        lstScores.Items.Add("Ones")
        lstScores.Items.Add("Twos")
        lstScores.Items.Add("Threes")
        lstScores.Items.Add("Fours")
        lstScores.Items.Add("Fives")
        lstScores.Items.Add("Sixes")
        lstScores.Items.Add("Sum")
        lstScores.Items.Add("Bonus")
        lstScores.Items.Add("3-kind")
        lstScores.Items.Add("4-kind")
        lstScores.Items.Add("House")
        lstScores.Items.Add("S Straight")
        lstScores.Items.Add("L Straight")
        lstScores.Items.Add("Chance")
        lstScores.Items.Add("YAHTZEE")
        lstScores.Items.Add("TOTAL")
        'wow look this is a change to the code
        'look it is yet another comment that I have added
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'menu button handler
        If blnMenu = False Then
            'show/hide objects
            lstScores.Hide()
            grpDice.Hide()
            btnRoll.Hide()
            grpMenu.Show()
            'set menu group to correct position (since it's under the dice group in the design viewer for ease of access)
            grpMenu.Location = New Point(230, 150)
            'switch boolean so handler knows that menu is on
            blnMenu = True
        ElseIf blnMenu = True Then
            'show/hide objects
            lstScores.Show()
            grpDice.Show()
            btnRoll.Show()
            grpMenu.Hide()
            'swithc boolean so handler knows that menu is off
            blnMenu = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
