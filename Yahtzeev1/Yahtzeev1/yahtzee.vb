Public Class yahtzee
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("SCORES") '& ControlChars.Tab & ControlChars.Tab & "You" & ControlChars.Tab & "AI")
        ListBox1.Items.Add("Ones")
        ListBox1.Items.Add("Twos")
        ListBox1.Items.Add("Threes")
        ListBox1.Items.Add("Fours")
        ListBox1.Items.Add("Fives")
        ListBox1.Items.Add("Sixes")
        ListBox1.Items.Add("Sum")
        ListBox1.Items.Add("Bonus")
        ListBox1.Items.Add("3-kind")
        ListBox1.Items.Add("4-kind")
        ListBox1.Items.Add("House")
        ListBox1.Items.Add("S Straight")
        ListBox1.Items.Add("L Straight")
        ListBox1.Items.Add("Chance")
        ListBox1.Items.Add("YAHTZEE")
        ListBox1.Items.Add("TOTAL")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub
End Class
