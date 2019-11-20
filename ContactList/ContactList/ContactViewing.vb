Public Class ContactViewing
    Private Sub background2_Click(sender As Object, e As EventArgs) Handles background2.Click

    End Sub

    Private Sub Pleassignin_Click(sender As Object, e As EventArgs) Handles Welcometext.Click

    End Sub

    Private Sub Usernamelabel_Click(sender As Object, e As EventArgs) Handles firstname.Click

    End Sub

    Private Sub LogOff_Click(sender As Object, e As EventArgs) Handles LogOff.Click
        Me.Hide()
        Signinpage.Show()
    End Sub

    Private Sub EmailInput_TextChanged(sender As Object, e As EventArgs) Handles EmailInput.TextChanged

    End Sub

    Private Sub Middle_Click(sender As Object, e As EventArgs) Handles Middle.Click

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        firstname.Show()
        Middle.Show()
        Last.Show()
        Emailaddress.Show()
        FirstInput.Show()
        MiddleInput.Show()
        LastInput.Show()
        EmailInput.Show()
        X1.Show()
    End Sub

    Private Sub X1_Click(sender As Object, e As EventArgs) Handles X1.Click
        firstname.Hide()
        Middle.Hide()
        Last.Hide()
        Emailaddress.Hide()
        FirstInput.Hide()
        MiddleInput.Hide()
        LastInput.Hide()
        EmailInput.Hide()
        X1.Hide()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        First2.Show()
        Middle2.Show()
        Last2.Show()
        emailaddress2.Show()
        Firstinput2.Show()
        MiddleInput2.Show()
        lastinput2.Show()
        emailinput2.Show()
        X2.Show()
    End Sub

    Private Sub X2_Click(sender As Object, e As EventArgs) Handles X2.Click
        First2.Hide()
        Middle2.Hide()
        Last2.Hide()
        emailaddress2.Hide()
        Firstinput2.Hide()
        MiddleInput2.Hide()
        lastinput2.Hide()
        emailinput2.Hide()
        X2.Hide()
    End Sub
End Class