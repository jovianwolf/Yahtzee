Public Class yahtzee
    'boolean to determine if the menu is shown or not
    Dim blnMenu As Boolean = False
    'integer between 0 and 3 for how many times they've rolled
    Dim intRollNum As Integer = 0
    'Adding variables to keep track of player roll choice
    Dim blnRollDie1 As Boolean
    Dim blnRollDie2 As Boolean
    Dim blnRollDie3 As Boolean
    Dim blnRollDie4 As Boolean
    Dim blnRollDie5 As Boolean

    '-----------
    'LOAD EVENT
    '-----------
    Private Sub yahtzee_Load(sender As Object, e As EventArgs) Handles Me.Load
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
    End Sub

    '----------------
    'BUTTON HANDLERS
    '----------------
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'menu button handler
        If blnMenu = False Then
            'show/hide objects
            lstScores.Hide()
            grpDice.Hide()
            btnRoll.Hide()
            lblKeep.Hide()
            lblRoll.Hide()
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
            lblKeep.Show()
            lblRoll.Show()
            grpMenu.Hide()
            'switch boolean so handler knows that menu is off
            blnMenu = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'Will need to change this to be an array that can dynamically change depending on the visibility of the buttons
        'Example, if user is only re-rolling 2 dice, we shouldn't roll 6 randoms
        Dim intDice(6) As Integer

        'This is probably where we should add the cloned die facing to the held dice button row -may remove this comment later if dumb idea...
        If btnRollDie1.Visible = True Then
            blnRollDie1 = True
        Else
            blnRollDie1 = False
        End If

        If btnRollDie2.Visible = True Then
            blnRollDie2 = True
        Else
            blnRollDie2 = False
        End If

        If btnRollDie3.Visible = True Then
            blnRollDie3 = True
        Else
            blnRollDie3 = False
        End If

        If btnRollDie4.Visible = True Then
            blnRollDie4 = True
        Else
            blnRollDie4 = False
        End If

        If btnRollDie5.Visible = True Then
            blnRollDie5 = True
        Else
            blnRollDie5 = False
        End If

        'Created an array to keep all 5 roll choices after the If statements to properly populate the array
        Dim blnDiceRoll() As Boolean = {blnRollDie1, blnRollDie2, blnRollDie3, blnRollDie4, blnRollDie5}

        'Array of buttons to add the number tag to
        Dim objDice() As Object = {btnRollDie1, btnRollDie2, btnRollDie3, btnRollDie4, btnRollDie5}


        'This had to be a pre-test loop array to catch is player was holding on to the dice in order to work correctly
        For IntX = 0 To blnDiceRoll.Length - 1
            If blnDiceRoll(IntX) = False Then
                MsgBox("you are keeping " & objDice(IntX).Tag)
            Else
                intDice(IntX) = RandomizeDice(IntX)
                Randomize(Now.Millisecond)
                delay()
                objDice(IntX).Tag = intDice(IntX)
            End If
            'Call subroutine to set the dice button face
            Call DiceFace(objDice(IntX))
        Next

        'increment roll counter by 1 & reset if big, set dice visibility
        intRollNum = intRollNum + 1
        If intRollNum = 4 Then
            intRollNum = 0
            btnKeepDie1.Visible = False
            btnRollDie1.Visible = True
            blnRollDie1 = True
            btnKeepDie2.Visible = False
            btnRollDie2.Visible = True
            blnRollDie2 = True
            btnKeepDie3.Visible = False
            btnRollDie3.Visible = True
            blnRollDie3 = True
            btnKeepDie4.Visible = False
            btnRollDie4.Visible = True
            blnRollDie4 = True
            btnKeepDie5.Visible = False
            btnRollDie5.Visible = True
            blnRollDie5 = True
        End If

        'This comment can be removed at a later time, was here for debug testing before images were applied
        MsgBox("Dice rolls are as follows 1-5: " & " " & CStr(btnRollDie1.Tag) & ", " & CStr(btnRollDie2.Tag) & ", " & CStr(btnRollDie3.Tag) & ", " & CStr(btnRollDie4.Tag) & ", " & CStr(btnRollDie5.Tag))
    End Sub

    '10 HANDLERS TO CONTROL KEEP/ROLL STATE OF DICE BUTTONS
    Private Sub btnRollDie1_Click(sender As Object, e As EventArgs) Handles btnRollDie1.Click
        'Button Handler to keep First die
        'clones the tag from the roll on to the keep button and sets the die face
        If intRollNum <> 0 Then
            btnKeepDie1.Tag = btnRollDie1.Tag
            Call DiceFace(btnKeepDie1)
            btnKeepDie1.Visible = True
            btnRollDie1.Visible = False
        End If
    End Sub

    Private Sub btnRollDie2_Click(sender As Object, e As EventArgs) Handles btnRollDie2.Click
        'Button Handler to keep Second die
        If intRollNum <> 0 Then
            btnKeepDie2.Tag = btnRollDie2.Tag
            Call DiceFace(btnKeepDie2)
            btnKeepDie2.Visible = True
            btnRollDie2.Visible = False
        End If
    End Sub

    Private Sub btnRollDie3_Click(sender As Object, e As EventArgs) Handles btnRollDie3.Click
        'Button Handler to keep Third die
        If intRollNum <> 0 Then
            btnKeepDie3.Tag = btnRollDie3.Tag
            Call DiceFace(btnKeepDie3)
            btnKeepDie3.Visible = True
            btnRollDie3.Visible = False
        End If
    End Sub

    Private Sub btnRollDie4_Click(sender As Object, e As EventArgs) Handles btnRollDie4.Click
        'Button Handler to keep Fourth die
        If intRollNum <> 0 Then
            btnKeepDie4.Tag = btnRollDie4.Tag
            Call DiceFace(btnKeepDie4)
            btnKeepDie4.Visible = True
            btnRollDie4.Visible = False
        End If
    End Sub

    Private Sub btnRollDie5_Click(sender As Object, e As EventArgs) Handles btnRollDie5.Click
        If intRollNum <> 0 Then
            'Button Handler to keep Fifth die
            btnKeepDie5.Tag = btnRollDie5.Tag
            Call DiceFace(btnKeepDie5)
            btnKeepDie5.Visible = True
            btnRollDie5.Visible = False
        End If
    End Sub

    Private Sub btnKeepDie1_Click(sender As Object, e As EventArgs) Handles btnKeepDie1.Click
        'Button Handler to roll First die
        btnKeepDie1.Visible = False
        btnRollDie1.Visible = True
    End Sub

    Private Sub btnKeepDie2_Click(sender As Object, e As EventArgs) Handles btnKeepDie2.Click
        'Button Handler to roll Second die
        btnKeepDie2.Visible = False
        btnRollDie2.Visible = True
    End Sub

    Private Sub btnKeepDie3_Click(sender As Object, e As EventArgs) Handles btnKeepDie3.Click
        'Button Handler to roll Third die
        btnKeepDie3.Visible = False
        btnRollDie3.Visible = True
    End Sub

    Private Sub btnKeepDie4_Click(sender As Object, e As EventArgs) Handles btnKeepDie4.Click
        'Button Handler to roll Fourth die
        btnKeepDie4.Visible = False
        btnRollDie4.Visible = True
    End Sub

    Private Sub btnKeepDie5_Click(sender As Object, e As EventArgs) Handles btnKeepDie5.Click
        'Button Handler to roll Fifth die
        btnKeepDie5.Visible = False
        btnRollDie5.Visible = True
    End Sub

    '----------------------
    'SUBROUTINES/FUNCTIONS
    '----------------------

    'Subroutine for setting the dice face image to the associated button from the above roll logic
    'This does not yet account for held dice row of buttons above
    Private Sub DiceFace(objButton)
        If objButton.Tag = "1" Then
            objButton.BackgroundImage = Image.FromFile("..\Images\Die_Roll_1.png")
            objButton.BackgroundImageLayout = ImageLayout.Stretch

        ElseIf objButton.Tag = "2" Then
            objButton.BackgroundImage = Image.FromFile("..\Images\Die_Roll_2.png")
            objButton.BackgroundImageLayout = ImageLayout.Stretch

        ElseIf objButton.Tag = "3" Then
            objButton.BackgroundImage = Image.FromFile("..\Images\Die_Roll_3.png")
            objButton.BackgroundImageLayout = ImageLayout.Stretch

        ElseIf objButton.Tag = "4" Then
            objButton.BackgroundImage = Image.FromFile("..\Images\Die_Roll_4.png")
            objButton.BackgroundImageLayout = ImageLayout.Stretch

        ElseIf objButton.Tag = "5" Then
            objButton.BackgroundImage = Image.FromFile("..\Images\Die_Roll_5.png")
            objButton.BackgroundImageLayout = ImageLayout.Stretch

        ElseIf objButton.Tag = "6" Then
            objButton.BackgroundImage = Image.FromFile("..\Images\Die_Roll_6.png")
            objButton.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Function RandomizeDice(intDie) As Integer
        Dim intDieChoice As Integer

        intDieChoice = CInt(Math.Ceiling(Rnd(0) * 6))
        Randomize(Now.Millisecond)

        Return intDieChoice
    End Function

    Sub delay()
        Dim count As Integer = 1
        For count = 1 To 10000000
            count = count + 1
        Next
    End Sub
End Class
