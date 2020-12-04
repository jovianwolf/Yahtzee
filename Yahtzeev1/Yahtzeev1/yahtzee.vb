Public Class yahtzee
    'boolean to determine if the menu is shown or not
    Dim blnMenu As Boolean = False

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

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'Dim intDice(1, 2, 3, 4, 5, 6) As Integer

        'Declare 5 integer vars to store the dice roll in for each die
        Dim intRandomDice1 As Integer
        Dim intRandomDice2 As Integer
        Dim intRandomDice3 As Integer
        Dim intRandomDice4 As Integer
        Dim intRandomDice5 As Integer

        'Setting a random number on roll to each of the 5 dice
        '!!need to add logic to catch if the button is visible then to roll for that dice
        intRandomDice1 = CInt(Math.Ceiling(Rnd(0) * 7))
        intRandomDice2 = CInt(Math.Ceiling(Rnd(0) * 7))
        intRandomDice3 = CInt(Math.Ceiling(Rnd(0) * 7))
        intRandomDice4 = CInt(Math.Ceiling(Rnd(0) * 7))
        intRandomDice5 = CInt(Math.Ceiling(Rnd(0) * 7))



    End Sub

    Private Sub yahtzee_Load(sender As Object, e As EventArgs) Handles Me.Load
        'On load event to randomize the seed for dice throw
        Randomize()

        'Moved the initialization of the scoreboard into on load event
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

    Private Sub btnRollDie1_Click(sender As Object, e As EventArgs) Handles btnRollDie1.Click
        'Button Handler to keep First die
        btnKeepDie1.Visible = True
        btnRollDie1.Visible = False
    End Sub

    Private Sub btnRollDie2_Click(sender As Object, e As EventArgs) Handles btnRollDie2.Click
        'Button Handler to keep Second die
        btnKeepDie2.Visible = True
        btnRollDie2.Visible = False
    End Sub

    Private Sub btnRollDie3_Click(sender As Object, e As EventArgs) Handles btnRollDie3.Click
        'Button Handler to keep Third die
        btnKeepDie3.Visible = True
        btnRollDie3.Visible = False
    End Sub

    Private Sub btnRollDie4_Click(sender As Object, e As EventArgs) Handles btnRollDie4.Click
        'Button Handler to keep Fourth die
        btnKeepDie4.Visible = True
        btnRollDie4.Visible = False
    End Sub

    Private Sub btnRollDie5_Click(sender As Object, e As EventArgs) Handles btnRollDie5.Click
        'Button Handler to keep Fifth die
        btnKeepDie5.Visible = True
        btnRollDie5.Visible = False
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
End Class
