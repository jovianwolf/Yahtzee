'-------------------------------------------------------------------------------------------------
'Program: Lab 3 – Yahtzee
'Author: Ian Morse, Patrick Reynolds
'Date: December 11, 2020
'Description: Program to emulate a single-player version of the popular dice game "Yahtzee"
'-------------------------------------------------------------------------------------------------
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



    '-------------------------------------------------------------------------------------------------
    'Subroutine: yahtzee_Load
    'Author: Ian Morse
    'Date: December 06, 2020
    'Description: On load event to set the headers in the listbox for scoring 
    '-------------------------------------------------------------------------------------------------
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
        'Disabling "score" button on start so that user can't score after 0 rolls
        btnScore.Enabled = False
    End Sub

    '----------------
    'BUTTON HANDLERS
    '----------------

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnScore_Click
    'Author: Patrick Reynolds
    'Date: December 07, 2020
    'Description: Makes the scoring groupbox visible
    '-------------------------------------------------------------------------------------------------
    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        GbxScore.Visible = True
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnMarkScore_Click
    'Author: Patrick Reynolds, Ian Morse
    'Date: December 10, 2020
    'Description: Button handler For submitting the player selected score Option For scoring
    '             and applies that score to the listbox
    '-------------------------------------------------------------------------------------------------
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
            intTotal = AddFaces(DiceToScore)
            lstScores.Items(14) = "Chance" & ControlChars.Tab & ControlChars.Tab & CStr(intTotal)
            rdbChance.Visible = False

        ElseIf rdbSmStraight.Checked And rdbSmStraight.Visible = True Then
            Call ScoreSmallStraight(DiceToScore)
            rdbSmStraight.Visible = False

        ElseIf rdbLgStraight.Checked And rdbLgStraight.Visible = True Then
            Call ScoreLargeStraight(DiceToScore)

        ElseIf rdb4OfKind.Checked And rdb4OfKind.Visible = True Then
            Call Score4OfKind(DiceToScore)
            rdb4OfKind.Visible = False

        ElseIf rdb3OfKind.Checked And rdb3OfKind.Visible = True Then
            Call Score3OfKind(DiceToScore)
            rdb3OfKind.Visible = False

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

        'Re-enable roll button (has been disabled in btnRoll_Click if 3rd roll)
        btnRoll.Enabled = True
        'Hide score group
        GbxScore.Visible = False
        'Set roll number back to 0
        intRollNum = 0
        'Disable buttons until after first roll
        btnRollDie1.Enabled = False
        btnRollDie2.Enabled = False
        btnRollDie3.Enabled = False
        btnRollDie4.Enabled = False
        btnRollDie5.Enabled = False
        btnKeepDie1.Enabled = False
        btnKeepDie2.Enabled = False
        btnKeepDie3.Enabled = False
        btnKeepDie4.Enabled = False
        btnKeepDie5.Enabled = False
        'Disable "score" button until after first roll
        btnScore.Enabled = False
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnMenu_Click
    'Author: Ian Morse, Patrick Reynolds
    'Date: December 08, 2020
    'Description: Button handler opening and closing the menu to access Exit, Restart (not implemented) or Debug
    '-------------------------------------------------------------------------------------------------
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

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnExit_Click
    'Author: Ian Morse
    'Date: December 03, 2020
    'Description: Button handler to close the program
    '-------------------------------------------------------------------------------------------------
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnDebugRoll_Click
    'Author: Patrick Reynolds
    'Date: December 07, 2020
    'Description: Debug Roll handler to feed values into the dice for testing
    '-------------------------------------------------------------------------------------------------
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

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnRoll_Click
    'Author: Ian Morse, Patrick Reynolds
    'Date: December 10, 2020
    'Description: Debug Roll handler to feed values into the dice for testing
    '-------------------------------------------------------------------------------------------------
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim intDice(5) As Integer

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

        'Disable roll button on 3rd roll to force user to score their rolls
        If intRollNum = 3 Then
            btnRoll.Enabled = False
            btnScore.PerformClick()
        End If

        'Re-enable all buttons (after they were disabled by mark score button)
        If intRollNum = 1 Then
            btnRollDie1.Enabled = True
            btnRollDie2.Enabled = True
            btnRollDie3.Enabled = True
            btnRollDie4.Enabled = True
            btnRollDie5.Enabled = True
            btnKeepDie1.Enabled = True
            btnKeepDie2.Enabled = True
            btnKeepDie3.Enabled = True
            btnKeepDie4.Enabled = True
            btnKeepDie5.Enabled = True
            're-enable score button
            btnScore.Enabled = True
        End If

    End Sub

    '----------------
    '10 HANDLERS TO CONTROL KEEP/ROLL STATE OF DICE BUTTONS
    '----------------

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnRollDie1_Click
    'Author: Ian Morse, Patrick Reynolds
    'Date: December 07, 2020
    'Description: Clones the tag applied to the button to the associated kept die and sets the dice face on the Kept die. 
    '             Will then swap visibility of Roll vs Keep
    '-------------------------------------------------------------------------------------------------
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

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnRollDie2_Click
    'Author: Ian Morse, Patrick Reynolds
    'Date: December 07, 2020
    'Description: Clones the tag applied to the button to the associated kept die and sets the dice face on the Kept die. 
    '             Will then swap visibility of Roll vs Keep
    '-------------------------------------------------------------------------------------------------
    Private Sub btnRollDie2_Click(sender As Object, e As EventArgs) Handles btnRollDie2.Click
        'Button Handler to keep Second die
        If intRollNum <> 0 Then
            btnKeepDie2.Tag = btnRollDie2.Tag
            Call DiceFace(btnKeepDie2)
            btnKeepDie2.Visible = True
            btnRollDie2.Visible = False
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnRollDie3_Click
    'Author: Ian Morse, Patrick Reynolds
    'Date: December 07, 2020
    'Description: Clones the tag applied to the button to the associated kept die and sets the dice face on the Kept die. 
    '             Will then swap visibility of Roll vs Keep
    '-------------------------------------------------------------------------------------------------
    Private Sub btnRollDie3_Click(sender As Object, e As EventArgs) Handles btnRollDie3.Click
        'Button Handler to keep Third die
        If intRollNum <> 0 Then
            btnKeepDie3.Tag = btnRollDie3.Tag
            Call DiceFace(btnKeepDie3)
            btnKeepDie3.Visible = True
            btnRollDie3.Visible = False
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnRollDie4_Click
    'Author: Ian Morse, Patrick Reynolds
    'Date: December 07, 2020
    'Description: Clones the tag applied to the button to the associated kept die and sets the dice face on the Kept die. 
    '             Will then swap visibility of Roll vs Keep
    '-------------------------------------------------------------------------------------------------
    Private Sub btnRollDie4_Click(sender As Object, e As EventArgs) Handles btnRollDie4.Click
        'Button Handler to keep Fourth die
        If intRollNum <> 0 Then
            btnKeepDie4.Tag = btnRollDie4.Tag
            Call DiceFace(btnKeepDie4)
            btnKeepDie4.Visible = True
            btnRollDie4.Visible = False
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnRollDie5_Click
    'Author: Ian Morse, Patrick Reynolds
    'Date: December 07, 2020
    'Description: Clones the tag applied to the button to the associated kept die and sets the dice face on the Kept die. 
    '             Will then swap visibility of Roll vs Keep
    '-------------------------------------------------------------------------------------------------
    Private Sub btnRollDie5_Click(sender As Object, e As EventArgs) Handles btnRollDie5.Click
        If intRollNum <> 0 Then
            'Button Handler to keep Fifth die
            btnKeepDie5.Tag = btnRollDie5.Tag
            Call DiceFace(btnKeepDie5)
            btnKeepDie5.Visible = True
            btnRollDie5.Visible = False
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnKeepDie1_Click
    'Author: Patrick Reynolds
    'Date: December 04, 2020
    'Description: Changes visibility of the selected kept die and makes the corresponding roll die number visible. 
    '-------------------------------------------------------------------------------------------------
    Private Sub btnKeepDie1_Click(sender As Object, e As EventArgs) Handles btnKeepDie1.Click
        'Button Handler to roll First die
        btnKeepDie1.Visible = False
        btnRollDie1.Visible = True
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnKeepDie2_Click
    'Author: Patrick Reynolds
    'Date: December 04, 2020
    'Description: Changes visibility of the selected kept die and makes the corresponding roll die number visible. 
    '-------------------------------------------------------------------------------------------------
    Private Sub btnKeepDie2_Click(sender As Object, e As EventArgs) Handles btnKeepDie2.Click
        'Button Handler to roll Second die
        btnKeepDie2.Visible = False
        btnRollDie2.Visible = True
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnKeepDie3_Click
    'Author: Patrick Reynolds
    'Date: December 04, 2020
    'Description: Changes visibility of the selected kept die and makes the corresponding roll die number visible. 
    '-------------------------------------------------------------------------------------------------
    Private Sub btnKeepDie3_Click(sender As Object, e As EventArgs) Handles btnKeepDie3.Click
        'Button Handler to roll Third die
        btnKeepDie3.Visible = False
        btnRollDie3.Visible = True
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnKeepDie4_Click
    'Author: Patrick Reynolds
    'Date: December 04, 2020
    'Description: Changes visibility of the selected kept die and makes the corresponding roll die number visible. 
    '-------------------------------------------------------------------------------------------------
    Private Sub btnKeepDie4_Click(sender As Object, e As EventArgs) Handles btnKeepDie4.Click
        'Button Handler to roll Fourth die
        btnKeepDie4.Visible = False
        btnRollDie4.Visible = True
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: btnKeepDie5_Click
    'Author: Patrick Reynolds
    'Date: December 04, 2020
    'Description: Changes visibility of the selected kept die and makes the corresponding roll die number visible. 
    '-------------------------------------------------------------------------------------------------
    Private Sub btnKeepDie5_Click(sender As Object, e As EventArgs) Handles btnKeepDie5.Click
        'Button Handler to roll Fifth die
        btnKeepDie5.Visible = False
        btnRollDie5.Visible = True
    End Sub

    '----------------------
    'SUBROUTINES/FUNCTIONS
    '----------------------


    '-------------------------------------------------------------------------------------------------
    'Subroutine: DiceFace
    'Author: Patrick Reynolds
    'Date: December 06, 2020
    'Description: Sets the dice face image to the associated button from the above roll logic
    '-------------------------------------------------------------------------------------------------
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

    '-------------------------------------------------------------------------------------------------
    'Function: RandomizeDice
    'Author: Patrick Reynolds
    'Date: December 04, 2020
    'Description: Chooses a random number within bounds of a 6 headed dice - returns the random number
    '-------------------------------------------------------------------------------------------------
    Private Function RandomizeDice(intDie) As Integer
        Dim intDieChoice As Integer

        intDieChoice = CInt(Math.Ceiling(Rnd(0) * 6))
        Randomize(Now.Millisecond)

        Return intDieChoice
    End Function

    '-------------------------------------------------------------------------------------------------
    'Subroutine: delay
    'Author: Ian Morse
    'Date: December 04, 2020
    'Description: Counts to a high number to ensure that the millisecond time seed used for 
    '             random number is more random on higher end / quicker computers.
    '-------------------------------------------------------------------------------------------------
    Private Sub delay()
        Dim count As Integer = 1
        For count = 1 To 10000000
            count = count + 1
        Next
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Function: ScoreSameFace
    'Author: Patrick Reynolds
    'Date: December 09, 2020
    'Description: Subroutine to score Ones – Sixes; Feed the array of dice numbers as well as a number  
    '             into the function to search for number of occurrences of that number - returns occurrence count
    '-------------------------------------------------------------------------------------------------
    Private Function ScoreSameFace(intDiceArray() As Integer, intNumberToFind As Integer) As Integer
        Dim intOccurrences As Integer

        For intX = 0 To intDiceArray.Length - 1

            If intDiceArray(intX) = intNumberToFind Then

                intOccurrences += 1

            End If

        Next

        Return intOccurrences

    End Function

    '-------------------------------------------------------------------------------------------------
    'Subroutine: Score3OfKind
    'Author: Patrick Reynolds
    'Date: December 13, 2020
    'Description: Will check the array for at least 3 occurrences of any valid number and score 25 points if true.
    '-------------------------------------------------------------------------------------------------

    Private Sub Score3OfKind(intDiceArray)
        Dim bln3OfKind As Boolean = False

        For IntX = 1 To intDiceArray.Length
            If ScoreSameFace(intDiceArray, 1) >= 3 Then
                bln3OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 2) >= 3 Then
                bln3OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 3) >= 3 Then
                bln3OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 4) >= 3 Then
                bln3OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 5) >= 3 Then
                bln3OfKind = True

            End If

        Next

        If bln3OfKind = True Then
            lstScores.Items(9) = "3-Kind" & ControlChars.Tab & ControlChars.Tab & CStr(AddFaces(intDiceArray))

        Else
            lstScores.Items(9) = "3-Kind" & ControlChars.Tab & ControlChars.Tab & "0"

        End If

    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: Score4OfKind
    'Author: Patrick Reynolds
    'Date: December 13, 2020
    'Description: Will check the array for at least 3 occurrences of any valid number and score 25 points if true.
    '-------------------------------------------------------------------------------------------------

    Private Sub Score4OfKind(intDiceArray)
        Dim bln4OfKind As Boolean = False

        For IntX = 1 To intDiceArray.Length
            If ScoreSameFace(intDiceArray, 1) >= 4 Then
                bln4OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 2) >= 4 Then
                bln4OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 3) >= 4 Then
                bln4OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 4) >= 4 Then
                bln4OfKind = True

            ElseIf ScoreSameFace(intDiceArray, 5) >= 4 Then
                bln4OfKind = True

            End If

        Next

        If bln4OfKind = True Then

            lstScores.Items(10) = "4-Kind" & ControlChars.Tab & ControlChars.Tab & CStr(AddFaces(intDiceArray))

        Else
            lstScores.Items(10) = "4-Kind" & ControlChars.Tab & ControlChars.Tab & "0"

        End If

    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: ScoreSmallStraight
    'Author: Patrick Reynolds
    'Date: December 13, 2020
    'Description: Looks for a sequence of 4 numbers in order and scores the game accordingly
    '-------------------------------------------------------------------------------------------------
    Private Sub ScoreSmallStraight(intDiceArray)

        Dim blnSmStraight As Boolean

        'Sorted the array to measure previous value to next value to evaluate straight
        Array.Sort(intDiceArray)

        If intDiceArray(0) < intDiceArray(1) And
           intDiceArray(0) = (intDiceArray(1) - 1) And
           intDiceArray(1) < intDiceArray(2) And
           intDiceArray(1) = (intDiceArray(2) - 1) And
           intDiceArray(2) < intDiceArray(3) And
           intDiceArray(2) = (intDiceArray(3) - 1) Then

            blnSmStraight = True

        Else
            If intDiceArray(1) < intDiceArray(2) And
               intDiceArray(1) = (intDiceArray(2) - 1) And
               intDiceArray(2) < intDiceArray(3) And
               intDiceArray(2) = (intDiceArray(3) - 1) And
               intDiceArray(3) < intDiceArray(4) And
               intDiceArray(3) = (intDiceArray(4) - 1) Then

                blnSmStraight = True

            Else
                blnSmStraight = False

            End If
        End If


        If blnSmStraight = True Then
            lstScores.Items(12) = "S Straight" & ControlChars.Tab & ControlChars.Tab & "30"
        Else
            lstScores.Items(12) = "S Straight" & ControlChars.Tab & ControlChars.Tab & "0"
        End If

        'Setting the radio button to invisible so player can only play 1x
        rdbLgStraight.Visible = False
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: ScoreLargeStraight
    'Author: Patrick Reynolds
    'Date: December 13, 2020
    'Description: Looks for a sequence of 5 numbers in order and scores the game accordingly
    '-------------------------------------------------------------------------------------------------
    Private Sub ScoreLargeStraight(intDiceArray)

        Dim blnLgStraight As Boolean

        'Sorted the array to measure previous value to next value to evaluate straight
        Array.Sort(intDiceArray)

        If intDiceArray(0) < intDiceArray(1) And
           intDiceArray(0) = (intDiceArray(1) - 1) And
           intDiceArray(1) < intDiceArray(2) And
           intDiceArray(1) = (intDiceArray(2) - 1) And
           intDiceArray(2) < intDiceArray(3) And
           intDiceArray(2) = (intDiceArray(3) - 1) And
           intDiceArray(3) < intDiceArray(4) And
           intDiceArray(3) = (intDiceArray(4) - 1) Then

            blnLgStraight = True

        Else
            blnLgStraight = False

        End If


        If blnLgStraight = True Then
            lstScores.Items(13) = "L Straight" & ControlChars.Tab & ControlChars.Tab & "40"
        Else
            lstScores.Items(13) = "L Straight" & ControlChars.Tab & ControlChars.Tab & "0"
        End If

        'Setting the radio button to invisible so player can only play 1x
        rdbLgStraight.Visible = False
    End Sub

    '-------------------------------------------------------------------------------------------------
    'Subroutine: ScoreYahtzee
    'Author: Patrick Reynolds
    'Date: December 07, 2020
    'Description: Will check for yahtzee score condition from current array of dice values and apply
    '             score to listbox (needs a rewrite for fixing end game scoring later but out of time)
    '-------------------------------------------------------------------------------------------------
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

    '-------------------------------------------------------------------------------------------------
    'Subroutine: AddFaces
    'Author: Patrick Reynolds
    'Date: December 08, 2020
    'Description: Will check all dice values and add together then apply that score to listbox 
    '             (needs a rewrite for fixing end game scoring later but out of time)
    '-------------------------------------------------------------------------------------------------
    Private Function AddFaces(intDiceArray) As Integer
        'To store the total of all die faces added up
        Dim intTotal As Integer

        'this steps through the array and keeps a running total
        For intX = 0 To intDiceArray.Length - 1

            intTotal += intDiceArray(intX)
        Next

        Return intTotal

    End Function
End Class
