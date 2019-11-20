Public Class Signinpage
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Pleassignin.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Usernamelabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        Me.Hide()
        ContactViewing.Show()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles newusertext.Click
        CreateAccount.Show()
        Me.Hide()
    End Sub
End Class
