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
    'Button handler to show the score box early if player wishes to score before 3x rolls
    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        GbxScore.Visible = True
    End Sub

    'Button handler for submitting the player selected score option for scoring
    Private Sub btnMarkScore_Click(sender As Object, e As EventArgs) Handles btnMarkScore.Click
        'Doing some trickery here to pull the current tagged value of the dice from the Roll Row back
        'This builds the array to work out of for comparing scores below
        Dim DiceToScore() As Integer = {CInt(btnRollDie1.Tag), CInt(btnRollDie2.Tag), CInt(btnRollDie3.Tag), CInt(btnRollDie4.Tag), CInt(btnRollDie5.Tag)}
        Dim intTotal As Integer

        'The First coded score is Yahtzee, need to add more in this If Statement as ElseIfs
        'And follow similar convention with unique subroutines (for concise-ness?)
        If rdbYahtzee.Checked And rdbYahtzee.Visible = True Then
            Call ScoreYahtzee(DiceToScore)

        ElseIf rdbChance.Checked And rdbChance.Visible = True Then
            Call ScoreChance(DiceToScore)

        ElseIf rdbLgStraight.Checked And rdbLgStraight.Visible = True Then
            Call ScoreLargeStraight(DiceToScore)

        ElseIf rdbSixes.Checked And rdbSixes.Visible = True Then
            intTotal = (ScoreSameFace(DiceToScore, 6) * 6)

            If intTotal > 0 Then
                lstScores.Items(6) = "Sixes" & ControlChars.Tab & ControlChars.Tab & intTotal
            Else
                lstScores.Items(6) = "Sixes" & ControlChars.Tab & ControlChars.Tab & "0"
            End If
            rdbSixes.Visible = False

        ElseIf rdbFives.Checked And rdbFives.Visible = True Then
            intTotal = (ScoreSameFace(DiceToScore, 5) * 5)

            If intTotal > 0 Then
                lstScores.Items(5) = "Fives" & ControlChars.Tab & ControlChars.Tab & intTotal
            Else
                lstScores.Items(5) = "Fives" & ControlChars.Tab & ControlChars.Tab & "0"
            End If
            rdbFives.Visible = False

        ElseIf rdbFours.Checked And rdbFours.Visible = True Then
            intTotal = (ScoreSameFace(DiceToScore, 4) * 4)

            If intTotal > 0 Then
                lstScores.Items(4) = "Fours" & ControlChars.Tab & ControlChars.Tab & intTotal
            Else
                lstScores.Items(4) = "Fours" & ControlChars.Tab & ControlChars.Tab & "0"
            End If
            rdbFours.Visible = False

        ElseIf rdbThrees.Checked And rdbThrees.Visible = True Then
            intTotal = (ScoreSameFace(DiceToScore, 3) * 3)

            If intTotal > 0 Then
                lstScores.Items(3) = "Threes" & ControlChars.Tab & ControlChars.Tab & intTotal
            Else
                lstScores.Items(3) = "Threes" & ControlChars.Tab & ControlChars.Tab & "0"
            End If
            rdbThrees.Visible = False

        ElseIf rdbTwos.Checked And rdbTwos.Visible = True Then
            intTotal = (ScoreSameFace(DiceToScore, 2) * 2)

            If intTotal > 0 Then
                lstScores.Items(2) = "Twos" & ControlChars.Tab & ControlChars.Tab & intTotal
            Else
                lstScores.Items(2) = "Twos" & ControlChars.Tab & ControlChars.Tab & "0"
            End If
            rdbTwos.Visible = False

        ElseIf rdbOnes.Checked And rdbOnes.Visible = True Then
            intTotal = (ScoreSameFace(DiceToScore, 1) * 1)

            If intTotal > 0 Then
                lstScores.Items(1) = "Ones" & ControlChars.Tab & ControlChars.Tab & intTotal
            Else
                lstScores.Items(1) = "Ones" & ControlChars.Tab & ControlChars.Tab & "0"
            End If
            rdbOnes.Visible = False

        End If
        GbxScore.Visible = False
    End Sub

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

        'Added to enable debug menu
        If cbxDebug.Checked = True Then
            btnDebugRoll.Visible = True
            txtDie1.Visible = True
            txtDie2.Visible = True
            txtDie3.Visible = True
            txtDie4.Visible = True
            txtDie5.Visible = True
            grpDice.Size = New Size(300, 160)
        Else
            btnDebugRoll.Visible = False
            txtDie1.Visible = False
            txtDie2.Visible = False
            txtDie3.Visible = False
            txtDie4.Visible = False
            txtDie5.Visible = False
            grpDice.Size = New Size(300, 135)
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Debug Roll handler to feed values into the dice for testing
    Private Sub btnDebugRoll_Click(sender As Object, e As EventArgs) Handles btnDebugRoll.Click
        Dim strInputError As String = "Dice must be a number 1-6"

        'Checks if debug mode is enabled and shows the player input boxes if so

        If IsNumeric(txtDie1.Text) Then
                If CInt(txtDie1.Text) > 0 And CInt(txtDie1.Text) < 7 Then
                    btnRollDie1.Tag = txtDie1.Text
                    btnKeepDie1.Tag = txtDie1.Text
                Call DiceFace(btnKeepDie1)
                Call DiceFace(btnRollDie1)
            Else
                    MsgBox("Dice 1: " & strInputError)
                End If
            Else
                MsgBox("Dice 1: " & strInputError)
            End If

        If IsNumeric(txtDie2.Text) Then
                If CInt(txtDie2.Text) > 0 And CInt(txtDie2.Text) < 7 Then
                    btnRollDie2.Tag = txtDie2.Text
                    btnKeepDie2.Tag = txtDie2.Text
                Call DiceFace(btnKeepDie2)
                Call DiceFace(btnRollDie2)
            Else
                    MsgBox("Dice 2: " & strInputError)
                End If
            Else
                MsgBox("Dice 2: " & strInputError)
            End If

        If IsNumeric(txtDie3.Text) Then
                If CInt(txtDie3.Text) > 0 And CInt(txtDie3.Text) < 7 Then
                    btnRollDie3.Tag = txtDie3.Text
                    btnKeepDie3.Tag = txtDie3.Text
                Call DiceFace(btnKeepDie3)
                Call DiceFace(btnRollDie3)
            Else
                    MsgBox("Dice 3: " & strInputError)
                End If
            Else
                MsgBox("Dice 3: " & strInputError)
            End If

        If IsNumeric(txtDie4.Text) Then
                If CInt(txtDie4.Text) > 0 And CInt(txtDie4.Text) < 7 Then
                    btnRollDie4.Tag = txtDie4.Text
                    btnKeepDie4.Tag = txtDie4.Text
                Call DiceFace(btnKeepDie4)
                Call DiceFace(btnRollDie4)
            Else
                    MsgBox("Dice 4: " & strInputError)
                End If
            Else
                MsgBox("Dice 4: " & strInputError)
            End If

        If IsNumeric(txtDie5.Text) Then
                If CInt(txtDie5.Text) > 0 And CInt(txtDie5.Text) < 7 Then
                    btnRollDie5.Tag = txtDie5.Text
                    btnKeepDie5.Tag = txtDie5.Text
                Call DiceFace(btnKeepDie5)
                Call DiceFace(btnRollDie5)
            Else
                    MsgBox("Dice 5: " & strInputError)
                End If
            Else
                MsgBox("Dice 5: " & strInputError)
            End If

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
                'this will show what dice are kept by player can be removed
                'MsgBox("you are keeping " & objDice(IntX).Tag)
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
        'MsgBox("Dice rolls are as follows 1-5: " & " " & CStr(btnRollDie1.Tag) & ", " & CStr(btnRollDie2.Tag) & ", " & CStr(btnRollDie3.Tag) & ", " & CStr(btnRollDie4.Tag) & ", " & CStr(btnRollDie5.Tag))
    End Sub

    '10 HANDLERS TO CONTROL KEEP/ROLL STATE OF DICE BUTTONS
    'Button Handler to keep First die
    Private Sub btnRollDie1_Click(sender As Object, e As EventArgs) Handles btnRollDie1.Click
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

    Private Function RandomizeDice(intDie) As Integer
        Dim intDieChoice As Integer

        intDieChoice = CInt(Math.Ceiling(Rnd(0) * 6))
        Randomize(Now.Millisecond)

        Return intDieChoice
    End Function

    Private Sub delay()
        Dim count As Integer = 1
        For count = 1 To 10000000
            count = count + 1
        Next
    End Sub

    'Subroutine to score ones - sixes
    'can feed any number, will hunt for that number in the given array and will score accordingly
    Private Function ScoreSameFace(intDiceArray() As Integer, intNumberToFind As Integer) As Integer
        Dim intOccurrences As Integer

        For intX = 0 To intDiceArray.Length - 1

            If intDiceArray(intX) = intNumberToFind Then

                intOccurrences += 1

            End If

        Next

        Return intOccurrences

    End Function

    'Subroutine called when Large Straight is marked for scoring
    Private Sub ScoreLargeStraight(intDiceArray)

        Dim blnPositiveStraight As Boolean
        Dim blnNegativeStraight As Boolean

        'this is WIP and is not yet functional
        'used -2 to prevent overload of comparison of next object in array out of array bounds
        For intX = 0 To intDiceArray.Length - 2
            If intDiceArray(intX) > intDiceArray(intX + 1) Then
                blnNegativeStraight = True

            Else blnNegativeStraight = False
            End If

            If intDiceArray(intX) < intDiceArray(intX + 1) Then
                blnPositiveStraight = True

            Else blnPositiveStraight = False
            End If


        Next


        If blnPositiveStraight Or blnNegativeStraight = True Then
            lstScores.Items(13) = "L Straight" & ControlChars.Tab & ControlChars.Tab & "40"
        Else
            lstScores.Items(13) = "L Straight" & ControlChars.Tab & ControlChars.Tab & "0"
        End If

        'Setting the radio button to invisible so player can only play 1x
        rdbLgStraight.Visible = False
    End Sub

    'Subroutine called when Yahtzee is marked and needs to validate for scoring
    Private Sub ScoreYahtzee(intDiceArray)
        'boolean used in test loop to validate if all die are the same
        Dim blnValidYahtzee As Boolean

        'this steps through the array and compares each value to the first value
        For intX = 0 To intDiceArray.Length - 1

            If intDiceArray(intX) <> intDiceArray(0) Then
                blnValidYahtzee = False

            Else
                blnValidYahtzee = True

            End If

        Next

        'sets the score for yahtzee index to 50 or 0 if the play is correct
        If blnValidYahtzee = True Then
            lstScores.Items(15) = "YAHTZEE" & ControlChars.Tab & "50"
        Else
            lstScores.Items(15) = "YAHTZEE" & ControlChars.Tab & "0"
        End If

        'Setting the radio button to invisible so player can only play 1x
        rdbYahtzee.Visible = False
    End Sub

    'Subroutine called when Chance is marked for scoring
    Private Sub ScoreChance(intDiceArray)
        'To store the total of all die faces added up for chance
        Dim intTotal As Integer


        'this steps through the array and keeps a running total to add to chance score
        For intX = 0 To intDiceArray.Length - 1

            intTotal += intDiceArray(intX)
        Next

        lstScores.Items(14) = "Chance" & ControlChars.Tab & ControlChars.Tab & CStr(intTotal)

        'Setting the radio button to invisible so player can only play 1x
        rdbChance.Visible = False
    End Sub
End Class
