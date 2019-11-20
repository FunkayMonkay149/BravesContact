Imports System.IO
Public Class ContactViewing
    Dim fileName As String = "C:\Users\cwl007\Desktop\contacts.txt"


    Private Sub LogOff_Click(sender As Object, e As EventArgs) Handles LogOff.Click
        Me.Hide()
        Signinpage.Show()
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

        If FirstInput.Text.Length > 0 And MiddleInput.Text.Length > 0 And LastInput.Text.Length > 0 And EmailInput.Text.Length > 0 Then
            Dim file As System.IO.StreamWriter

            If Not EmailInput.Text.Contains("@") And Not EmailInput.Text.Contains(".com" Or ".org" Or ".net") Then
                MsgBox("The email address must be in this format: www.example.com")

            ElseIf My.Computer.FileSystem.FileExists(fileName) Then
                file = My.Computer.FileSystem.OpenTextFileWriter(fileName, True)
                file.WriteLine(Environment.NewLine + FirstInput.Text + "," + MiddleInput.Text + "," + LastInput.Text + "," + EmailInput.Text)
                file.Close()
                MsgBox("successfully added")
            Else
                file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
                file.WriteLine(FirstInput.Text + "," + MiddleInput.Text + "," + LastInput.Text + "," + EmailInput.Text)
                file.Close()
                MsgBox("successfully added")
            End If


            FirstInput.Text = ""
            MiddleInput.Text = ""
            LastInput.Text = ""
            EmailInput.Text = ""

        End If
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


                            If currentRow.Contains(Firstinput2.Text) Or currentField.Contains(MiddleInput2.Text) Or currentField.Contains(lastinput2.Text) Or currentField.Contains(emailinput2.Text) Then
                                If Not Contactlist.Items.Contains(currentRow(3).ToString) Then
                                    Contactlist.Items.Add(currentRow(0) + "," + currentRow(1).ToString + "," + currentRow(2).ToString + "," + currentRow(3).ToString)
                                End If


                            Else
                                MsgBox("The person could not be found in the contact list")

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Contactlist.Items.RemoveAt(Contactlist.SelectedIndex)

    End Sub
End Class