Imports System.IO
Public Class ContactViewing
    Dim fileName As String = "C:\Users\christwalker\Desktop\contacts.txt"

    'Log off Button
    Private Sub LogOff_Click(sender As Object, e As EventArgs) Handles LogOff.Click
        Me.Hide()
        Signinpage.Show()
        Signinpage.incorrect.Visible = False
        Signinpage.incorrect2.Visible = False
        Signinpage.headerpasswordinput.Text = ""
        Signinpage.headerusernameinput.Text = ""
        Signinpage.usernameinput.Text = ""
        Signinpage.passwordinput.Text = ""
        Signinpage.verifypassword.Text = ""

    End Sub

    'Delete Button
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        ContactList.Items.RemoveAt(ContactList.SelectedIndex)
    End Sub

    'Search Button
    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles search1.Click

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

                            If (nameinput.Text.Length > 0 And EmailInput.Text.Length > 0) Then

                                If currentField.Contains(nameinput.Text) OrElse currentField.Contains(EmailInput.Text) Then

                                    ContactList.Items.Add(currentRow(0) + "," + currentRow(1).ToString)
                                    nameinput.Text = ""
                                    EmailInput.Text = ""

                                    Exit Sub

                                ElseIf MyReader.EndOfData Then
                                    MsgBox(nameinput.Text + " could not be be found in the contact list")
                                    Exit Sub
                                End If
                            End If
                        Next
                    Catch ex As Microsoft.VisualBasic.
                  FileIO.MalformedLineException
                        MsgBox("contact list is corrupted, please call customer support")
                    End Try
                End While
            End Using

        Else
            MsgBox("Your contact list is empty")
        End If
    End Sub

    'Create Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Create.Click
        If nameinput.Text.Length > 0 And EmailInput.Text.Length > 0 Then
            Dim file As System.IO.StreamWriter


            If My.Computer.FileSystem.FileExists(fileName) Then
                file = My.Computer.FileSystem.OpenTextFileWriter(fileName, True)
                file.WriteLine(Environment.NewLine + nameinput.Text + "," + EmailInput.Text)
                file.Close()
                MsgBox(nameinput.Text + " was successfully added")
            Else
                file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
                file.WriteLine(nameinput.Text + "," + EmailInput.Text)
                file.Close()
                MsgBox(nameinput.Text + " was successfully added")
            End If


            nameinput.Text = ""
            EmailInput.Text = ""

        End If
    End Sub
End Class