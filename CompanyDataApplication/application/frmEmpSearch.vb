Public Class frmEmpSearch
    Private Sub frmEmpSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Clears Input Boxes on Form Load 
        txtLastInput.Clear() 'Clears text from textbox
        txtFirstInput.Clear() 'Clears text from textbox
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide() 'hides form 
        frmMainMenu.Show() 'reveals main menu 
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnLastSearch.Click

        Dim strSearchItem As String 'A string that will hold the string inputted by the user that will be searched 
        strSearchItem = RTrim(txtLastInput.Text) 'assigns the user input text to the string 
        Dim intFound As Integer = intFindcolLastnames(strSearchItem) 'intFound takes the value of the found row, the function identifies which row the item was on, the row number is being returned and stored into intFound 

        If String.IsNullOrEmpty(strSearchItem) = True Then 'Validates whether the Input String is Empty, if it returns true, the string is empty and an error message is displayed 
            MsgBox("Please Enter an Employee's Last name.")
            txtLastInput.Clear()

        ElseIf IsNumeric(strSearchItem) = True Then 'Validates whether the Input String is Numeric, if it returns true, the string is empty and an error message is displayed. Employee Names cannot have numbers in them 
            MsgBox("Error, An Employee Name can't have a number! Please Enter a First Name.")
            txtLastInput.Clear()

        Else
            If intFound = -1 Then 'if the function returns -1, then the target was not found and no row was identified, hence -1 will be what is needed for a negative result / response 

                MsgBox("The employee you are looking for is not in the database. Please check for spelling errors and make sure the person you are looking for is in the company!")
                txtLastInput.Clear() 'Clears the text after a search was not found for user convenience

            End If

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearchLogs.Text = "First | Last | Department | Skillset | ID"  'the clear button will change the text box to just those categories on screen, clearing the searches 
    End Sub

    Private Sub btnFirstSearch_Click(sender As Object, e As EventArgs) Handles btnFirstSearch.Click
        Dim strSearchItem As String 'A string that will hold the string inputted by the user that will be searched 
        strSearchItem = RTrim(txtFirstInput.Text) 'assigns the user input text to the string 
        Dim intFound As Integer = intFindFirstname(strSearchItem) 'intFound takes the value of the found row, the function identifies which row the item was on, the row number is being returned and stored into intFound 

        If String.IsNullOrEmpty(strSearchItem) = True Then 'Validates whether the Input String is Empty, if it returns true, the string is empty and an error message is displayed 
            MsgBox("Please Enter an Employee's First Name.")
            txtFirstInput.Clear()

        ElseIf IsNumeric(strSearchItem) = True Then 'Validates whether the Input String is Numeric, if it returns true, the string is empty and an error message is displayed. Employee Names cannot have numbers in them 
            MsgBox("Error, An Employee Name can't have a number! Please Enter a First Name.")
            txtFirstInput.Clear()
        Else


            If intFound = -1 Then 'if the function returns -1, then the target was not found and no row was identified, hence -1 will be what is needed for a negative result / response 

                MsgBox("The employee you are looking for is not in the database. Please check for spelling errors and make sure the person you are looking for is in the company!")
                txtFirstInput.Clear() 'Clears the text after a search was not found for user convenience

            End If

        End If

    End Sub
End Class