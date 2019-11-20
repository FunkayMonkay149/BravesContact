Imports System.IO
Imports System.Threading

Public Class Signinpage
    Dim fileName As String = "C:\Users\christwalker\Desktop\test.txt"

    'Header Login Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginbutton.Click

        If File.Exists(fileName) Then

            Using MyReader As New Microsoft.VisualBasic.
                        FileIO.TextFieldParser(
                          fileName)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()
                        Dim currentField As String
                        For Each currentField In currentRow
                            If currentRow.Contains(headerusernameinput.Text) And currentRow.Contains(headerpasswordinput.Text) Then
                                Me.Hide()
                                ContactViewing.Show()
                                incorrect2.Visible = False
                            Else
                                incorrect2.Visible = True
                            End If
                        Next
                    Catch ex As Microsoft.VisualBasic.
                  FileIO.MalformedLineException
                        MsgBox("There were issues finding the specified username and password, please call customer support")
                    End Try
                End While
            End Using

        Else
            MsgBox("You have to create an account before you can sign in")

        End If
    End Sub

    'Create Button
    Private Sub createbutton_Click(sender As Object, e As EventArgs) Handles createbutton.Click
        If usernameinput.Text.Length > 0 And passwordinput.Text.Length > 0 And passwordinput.Text.Equals(verifypassword.Text) Then

            incorrect.Visible = False

            If My.Computer.FileSystem.FileExists(fileName) Then

                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(fileName, True)
                file.WriteLine(usernameinput.Text + "," + passwordinput.Text)
                file.Close()
                incorrect.Visible = True
                incorrect.Text = "Account successfully created"
                incorrect.ForeColor = Color.ForestGreen

            ElseIf Not My.Computer.FileSystem.FileExists(fileName) Then
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
                file.WriteLine(usernameinput.Text + "," + passwordinput.Text)
                file.Close()
                incorrect.Visible = True
                incorrect.Text = "Account successfully created"
                incorrect.ForeColor = Color.ForestGreen
            End If

        ElseIf passwordinput.Text <> verifypassword.Text Then
            incorrect.Visible = True
            incorrect.Text = "Passwords Do Not Match!"
            incorrect.ForeColor = Color.DarkRed
        End If
    End Sub
End Class