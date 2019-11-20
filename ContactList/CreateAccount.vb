Imports System.IO
Public Class CreateAccount
    Dim fileName = "C:\Users\cwl007\Desktop\test.txt"

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles createbutton.Click
        If usernameinput.Text.Length > 0 And passwordinput.Text.Length > 0 And passwordinput.Text.Equals(TextBox1.Text) Then



            If My.Computer.FileSystem.FileExists(fileName) Then


                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(fileName, True)
                file.WriteLine(Environment.NewLine + usernameinput.Text + "," + passwordinput.Text)
                file.Close()

                Me.Hide()
                ContactViewing.Show()

            ElseIf Not My.Computer.FileSystem.FileExists(fileName) Then

                Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
                    file.WriteLine(usernameinput.Text + "," + passwordinput.Text)
                    file.Close()

                    Me.Hide()
                    ContactViewing.Show()



                ElseIf passwordinput.Text <> TextBox1.Text Then
                    incorrect.Visible = True

            End If
        End If
    End Sub


    Private Sub Existingaccount_Click(sender As Object, e As EventArgs) Handles Existingaccount.Click
        Me.Hide()
        Signinpage.Show()
    End Sub

End Class