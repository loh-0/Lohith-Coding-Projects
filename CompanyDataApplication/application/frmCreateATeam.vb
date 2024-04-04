Public Class frmCreateATeam
    Dim intTaskReference As Integer 'Integer that will hold the index of the selected task for later reference in the code
    Dim strOutput As String 'String that will hold the text to display the team report
    Public intNumRequired As Integer 'Integer that holds the number of staff required for the team, taken from tblTaskList
    Public intStaffinTeam As Integer 'Integer that holds the number of staff in the team as employees are added, when an employee is added this is increased by 1
    Dim bolTaskReady As Boolean 'Boolean that indicates whether the task has been selected or not, when this is true, other aspects of the form will be visible.
    Public arrEmployees(30) As String 'Array that holds the indexes of the selected employees from the data set, when a new employee is selected, it is compared to the index of the previous one and if it's the same, the user is informed they can't select the same employee twice.
    Public arrEmployeeReference(30) As Integer 'An integer array that stores all the index references of the employees from tblEmployeeData. With the indexes stored, they are used for writing the report and writing the file. 
    Public bolTeamFinalised As Boolean
    Public strTaskName As String 'String that holds task name        ' Because the Task is deleted on finalisation, for the task to be referred to the team generation report, the details of the task has to be stored in variables
    Public intTaskDuration As Integer 'Integer that holds Task duration
    Public intStaff As Integer ' Integer that holds Staff Required
    Public strCompany As String ' String that holds Company Name


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide() 'Hides the current form
        frmMainMenu.Show() 'Shows the main menu form 
    End Sub

    Private Sub frmCreateATeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmployee.Visible = False 'Changing the visibillity settings of various things as they are not meant to be accessible to the user right away.
        btnSelectEmp.Visible = False
        lblNote.Visible = False
        btnSelectID.Visible = False
        lblEmployees.Visible = False

        Me.Width = 225 'Width of the Form adjusted so that the user only sees the Login Screen
        Me.Height = 399 'After the login is complete, the widths will change and allow the whole screen to be displayed

        lblLoginHeader.Visible = True 'Displays the login screen objects to the user 
        lblUsername.Visible = True
        lblPassword.Visible = True
        txtCompanyPass.Visible = True
        txtCompanyUser.Visible = True
        lblPlease.Visible = True


        btnTeamGenerateReport.Enabled = False 'prevents the use of buttons for report creation until the team can be created to prevent erros
        btnSaveReport.Enabled = False
        btnAvailabillityReport.Enabled = False
        btnSaveAvail.Enabled = False

        intTaskReference = 0 'sets the task reference (that's used to write the reports later) to zero for a refresh start when loading 

        lblInstruct1.Visible = True   'Changes the instructions that is displayed the user, based on the stage in the application use they're on
        lblInstruct2.Visible = False

        btnSelectTask.Enabled = True 'enables the button for selection employees and tasks 
        btnSelectEmp.Enabled = True
        btnSelectID.Enabled = True
        btnNewTaskList.Enabled = False
        btnFinaliseTeam.Enabled = False


    End Sub

    Private Sub btnSelectTask_Click(sender As Object, e As EventArgs) Handles btnSelectTask.Click

        'This subroutine is responsible for selecting the task the user chooses, when the user inputs a desired task, the application first, does a search
        ' verifing whether or not this Task is part of the system. After this is done, the other information related to the task (time, staff needed etc.) is drawn
        ' from the data set and is displayed on the Output textbox for visual confirmation. Basic validation is done to ensure that the input is formatted correctly
        ' as no task can have numbers in it or can be blank (IsNumeric and IsNullOrEmpty used). RTrim, is used to remove any trailing blanks that could lead to a failed search. Searching is done by looking through
        ' colTaskName in the table from the data set and returns the row number which is stored in a variable to be references later for writing reports. 
        Dim strSearchItem As String 'variable to hold input
        strSearchItem = RTrim(txtTask.Text) 'takes the text box text and stores in the string, RTrims the data to remove trailing spaces
        Dim intFound As Integer = LinearSearchcolTaskname(strSearchItem) 'intFound holds the row index of the search item, -1 being not found


        If String.IsNullOrEmpty(strSearchItem) = True Then 'String.IsNullOrEmpty returns a true or false answer on whether or not the string is empty or null, if the string is empty the search won't proceed
            MsgBox("Please Enter a Task, Remember to Refer to the Company Lists to View Available tasks.") ' Error message prompt 

        ElseIf IsNumeric(strSearchItem) = True Then 'IsNumeric returns a true or false on whether or not the string is numeric (is a number) 
            MsgBox("Error, task names cannot contain numbers. Please Enter a Task Name. To check available tasks, check Company Lists. ") 'Error message prompt
        Else
            If intFound = -1 Then 'When intFound is -1, the target could not be found hence the index is -1
                MsgBox("The task you are seeking is not in the database. Please check for spelling errors and make sure the task is in the compnay")

            Else
                intTaskReference = intFound 'stores the index of the found row so it can be removed later
                intTaskDuration = frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colWeeks) 'Because the task is going to be removed fromm the list on team finalisation, we are storing all the information of the task in a variable so we can still use it for writing.
                intStaff = frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colStaff)
                strCompany = frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colCompany)
                strTaskName = frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colTaskName)


                strOutput = "Task Name: " & frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colTaskName) & vbNewLine 'Code for formatting strOutput, displaying the task information 
                strOutput += "Staff Required: " & frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colStaff)

                txtOutput.Text = strOutput
                lblRequiredEmps.Text = "Required Employees: " & frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colStaff)

                intNumRequired = CInt(frmMainMenu.tblTaskList.Rows(intFound).Item(frmMainMenu.colStaff)) 'Takes the Integer of the Staff Required column

                txtEmployee.Visible = True 'once the task is selected, employee selection is made available and task selection is disabled 
                btnSelectEmp.Visible = True
                btnSelectID.Visible = True
                lblEmployees.Visible = True
                lblNote.Visible = True
                btnSelectID.Enabled = True
                btnSelectEmp.Enabled = True

                lblInstruct1.Visible = False
                lblInstruct2.Visible = True
                btnSelectTask.Enabled = False

            End If

        End If
    End Sub

    Private Sub btnSelectEmp_Click(sender As Object, e As EventArgs) Handles btnSelectEmp.Click

        ' This subroutine is reponsible for selecting the employee the user chooses. When the user inputs a last name, the application first, does a search 
        ' verifying whether or not the Employee is in the database. After this, the information related to the employee (first name, skillset, department etc.) is drawn 
        ' and key information is displayed for visual confirmation in the StrOutput textbox.  Basic validation is done to ensure that the input is formatted correctly
        ' as no name can have numbers in it or can be blank (IsNumeric and IsNullOrEmpty used). RTrim, is used to remove any trailing blanks that could lead to a failed search for convienence. Searching is done by looking through
        ' colLastName in the table from the data set and returns the row number which is stored in a variable to be references later for writing reports. 

        Dim strSearchItem As String 'A string that will hold the string inputted by the user that will be searched 
        strSearchItem = RTrim(txtEmployee.Text) 'assigns the user input text to the string, RTrim formats the input to remove trailing String 
        Dim intFound As Integer = LinearSearchcolLastname(strSearchItem) 'intFound takes the value of the found row, the function identifies which row the item was on, the row number is being returned and stored into intFound 

        '  employees that have gone into the team, if the employee is found, that means it's a repeated emplyoee and the code will not proceed


        If String.IsNullOrEmpty(strSearchItem) = True Then 'String.IsNullOrEmpty returns a true or false answer on whether or not the string is empty or null, if the string is empty the search won't proceed
            MsgBox("Please Enter an Employee's Last Name, Remember to Refer to the Company Lists and Employee Search Forms to view Employees.")  ' Error message prompt 

        ElseIf IsNumeric(strSearchItem) = True Then 'IsNumeric returns a true or false on whether or not the string is numeric (is a number) 
            MsgBox("Please Enter an Employee's Last name, not a number")  ' Error message prompt 
        Else


            If intFound = -1 Then 'if the function returns -1, then the target was not found and no row was identified, hence -1 will be what is needed for a negative result / response 

                MsgBox("The employee you are looking for is not in the database. Please ID and make sure the person you are looking for is in the company!") 'error message

            Else
                Dim intValidation As Integer = LinearValidation(arrEmployees, frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colID)) 'variable that will be used to validate the same employee being addded more than once. It searches the input employee with an array that stores


                If intValidation <> -1 Then
                    MsgBox("This Employee is already in the team")
                ElseIf frmMainMenu.tblAvailabillity.Rows(intFound).Item(frmMainMenu.colStatus) = "No" Then 'Checks to see if the employee is available or not
                    MsgBox("Error, employee is not available, please refer to the availabillity report to check availabillity status")
                Else
                    arrEmployees(intStaffinTeam) = frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colID) 'Stores the employee in the array so we can validate further inputs later
                    arrEmployeeReference(intStaffinTeam) = intFound 'The index of the employee is also stored in an array, so it can be referenced later when writing reports 

                    intStaffinTeam += 1 'The number of people in the team is incremented by one as an employee is added

                    strOutput += vbNewLine & vbNewLine & "Employee " & intStaffinTeam & ": " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colFirstname) & " " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colLastname) 'when choosing what number row it is, we use intFound as it holds the row number of the target element, this is formatted into the output message 

                    txtOutput.Text = strOutput 'Makes the output text 

                    If intStaffinTeam = intNumRequired Then 'Code when the number of employees in the team reaches the employees required 
                        btnSelectEmp.Enabled = False 'When the team is full, the .enabled of buttons are changed to reflect new changes to features that can be used
                        btnFinaliseTeam.Enabled = True
                        lblInstruct2.Visible = False
                        btnSelectID.Enabled = False
                        MsgBox("The team is now at its maximum capacity")
                    End If

                End If

            End If


        End If


    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        If bolTeamFinalised = False Then
            ' Button that will restart the entire team creation process, buttons will be reverted to their status when the form was first opened allowing for the process to be restarted.
            txtOutput.Clear()
            txtEmployee.Clear()
            txtTask.Clear()

            Array.Clear(arrEmployeeReference, 0, arrEmployeeReference.Length) 'Clears the array, removing all the data from it 
            Array.Clear(arrEmployees, 0, arrEmployees.Length) 'Clears the array, removing all the data from it 

            lblRequiredEmps.Text = "Required Employees: " 'changes label text
            txtEmployee.Visible = False 'hides textbox for employees
            btnSelectEmp.Visible = False ' hides button to select employees
            lblNote.Visible = False 'hides instruction note label
            btnSelectID.Visible = False 'hides button to select ID 
            lblEmployees.Visible = False
            intStaffinTeam = 0 'ensures these variables start at 0 as the tool is being restarted, they should be 0 
            intNumRequired = 0
            lblInstruct1.Visible = True
            lblInstruct2.Visible = False

            'Buttons that should not be able to be used have their ,enabled set to false
            btnTeamGenerateReport.Enabled = False
            btnSaveReport.Enabled = False
            btnAvailabillityReport.Enabled = False
            btnSaveAvail.Enabled = False
            btnSelectTask.Enabled = True
            btnSelectEmp.Enabled = True
            btnSelectID.Enabled = True
            btnFinaliseTeam.Enabled = False
            btnNewTaskList.Enabled = False
            bolTeamFinalised = False 'Boolean for whether or not the Team is Finalised is set back to false 


        End If

        If bolTeamFinalised = True Then 'The Following is made as a warning message for the user. The purpose of this is to prevent accidentally restarting the team creator without saving any reports. By Using the boolean for TeamFinalised to indicate whether or not the task has been already removed
            'from the system. This message box confirm acts as a way to double check if the user is sure they want to restart the team creator
            ' this is only in place when the task list is created. Any instances of this button being clicked before the team creation will not prompt this box. 
            Dim YesOrNo As DialogResult = MessageBox.Show("Are you sure you want to restart the team creator? If you restart the team creator now, you won't be able to save any reports for this Assignment and the Task will already be gone from the Task List.", "Are you sure", MessageBoxButtons.YesNoCancel) 'Dimensions a variable that holds the response selected by the dilaog result of th message box.

            If YesOrNo = DialogResult.Yes Then 'If the user still chooses yes
                ' Button that will restart the entire team creation process, buttons will be reverted to their status when the form was first opened allowing for the process to be restarted.
                txtOutput.Clear()
                txtEmployee.Clear()
                txtTask.Clear()

                Array.Clear(arrEmployeeReference, 0, arrEmployeeReference.Length) 'Clears the array, removing all the data from it 
                Array.Clear(arrEmployees, 0, arrEmployees.Length) 'Clears the array, removing all the data from it 

                lblRequiredEmps.Text = "Required Employees: " 'changes label text
                txtEmployee.Visible = False 'hides textbox for employees
                btnSelectEmp.Visible = False ' hides button to select employees
                lblNote.Visible = False 'hides instruction note label
                btnSelectID.Visible = False 'hides button to select ID 
                lblEmployees.Visible = False
                intStaffinTeam = 0 'ensures these variables start at 0 as the tool is being restarted, they should be 0 
                intNumRequired = 0
                lblInstruct1.Visible = True
                lblInstruct2.Visible = False

                'Buttons that should not be able to be used have their ,enabled set to false
                btnTeamGenerateReport.Enabled = False
                btnSaveReport.Enabled = False
                btnAvailabillityReport.Enabled = False
                btnSaveAvail.Enabled = False
                btnSelectTask.Enabled = True
                btnSelectEmp.Enabled = True
                btnSelectID.Enabled = True
                btnFinaliseTeam.Enabled = False
                btnNewTaskList.Enabled = False
                bolTeamFinalised = False 'Boolean for whether or not the Team is Finalised is set back to false 

            ElseIf YesOrNo <> DialogResult.Yes Then 'ANy action the user takes that is not clicking Yes will cancel the restart
                MsgBox("Action Canceled")

            End If

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectID.Click

        ' This subroutine is reponsible for selecting the employee the user chooses. When the user inputs an Employee's ID, the application first, does a search 
        ' verifying whether or not the Employee is in the database. After this, the information related to the employee (first name, skillset, department etc.) is drawn 
        ' and key information is displayed for visual confirmation in the StrOutput textbox.  Basic validation is done to ensure that the input is formatted correctly
        ' as no name can have numbers in it or can be blank (IsNumeric and IsNullOrEmpty used). The character count is also checked since an ID can only be 4 characters long. RTrim, is used to remove any trailing blanks that could lead to a failed search for convienence. Searching is done by looking through
        ' colID in the table from the data set and returns the row number which is stored in a variable to be references later for writing reports. 

        Dim strSearchItem As String 'variable that will store the user input
        strSearchItem = InputBox("Please Enter The Employee ID", "ID Selection") 'user input taken from the inputbox result 
        strSearchItem = RTrim(strSearchItem) 'removes trailing characters
        Dim intFound As Integer = LinearSearchcolID(strSearchItem) 'holds the row index of the searched item
        Dim intValidation As Integer 'intValidation holds the returned value from the validation function

        If String.IsNullOrEmpty(strSearchItem) = True Then 'If the input is blank, the input is rejected
            MsgBox("No Input Detected. Please Enter an Employee's ID, remember to refer to the Searcher and Company List when obtaining and Employee's ID")
        ElseIf IsNumeric(strSearchItem) = False Then 'If the Input is not numeric, it's a number and so is rejected
            MsgBox("Error, an Employee Number can't contain Letters! Please Enter an Employee ID number, these can be found via the search function or the lists, Employee IDs are 4 digits long")


        Else

            If strSearchItem.Length = 4 Then 'Validation to ensure the user is inputting a number that is only 4 digits long. Code only runs under this condition
                If intFound = -1 Then 'if the function returns -1, then the target was not found and no row was identified, hence -1 will be what is needed for a negative result / response 

                    MsgBox("The employee you are looking for is not in the database. Please ID and make sure the person you are looking for is in the company!")

                Else

                    intValidation = LinearValidation(arrEmployees, frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colID)) 'Validation search is run to determine if the employee is already in the team (the array)

                    If intValidation <> -1 Then 'when any value that is not -1 is returned, an employee was found, hence a message is shown
                        MsgBox("This employee is already in the team")
                    ElseIf frmMainMenu.tblAvailabillity.Rows(intFound).Item(frmMainMenu.colStatus) = "No" Then
                        MsgBox("Error, employee is not available, please refer to the availabillity report to check availabillity status")
                    Else 'If it's -1, a new employee is being added and the code proceeds
                        arrEmployees(intStaffinTeam) = frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colID) 'Assigns the new employee to the array of employees so we can validate whether or not that employee is already in the term when we use intValidation
                        arrEmployeeReference(intStaffinTeam) = intFound 'arrEmployeeReference holds the indexs of all selected employees so reports can be written later displaying all relevant information from these rows
                        intStaffinTeam += 1

                        strOutput += vbNewLine & vbNewLine & "Employee " & intStaffinTeam & ": " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colFirstname) & " " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colLastname) 'when choosing what number row it is, we use intFound as it holds the row number of the target element, this is formatted into the output message 
                        ' Updated strOutput, which demonstrates a basic on screen preview of the team
                        txtOutput.Text = strOutput

                        If intStaffinTeam = intNumRequired Then 'Checks if the team is at its capacity 

                            btnSelectEmp.Enabled = False 'Employees can no longer be selected as team is full
                            btnFinaliseTeam.Enabled = True 'Button for finalisng the team is shown now sicne the team is complete
                            lblInstruct2.Visible = False 'instruction not relevant anymore is hidden
                            btnSelectID.Enabled = False 'Other form of emmployee selection is also disabled
                            MsgBox("The team is now at its maximum capacity")
                        End If


                    End If

                End If

            Else
                MsgBox("Error, Employee Numbers should be for 4 numbers long. Please refer to the Company Lists or Search Page to Double check the ID you're looking for.") 'Message Box Error if the Characters are longer than 4
            End If
        End If

    End Sub

    Private Sub btnCompanySignIn_Click(sender As Object, e As EventArgs) Handles btnCompanySignIn.Click
        Dim strCompUser As String 'string that holds the input in txtCompanyUser which will be treated as the Username
        Dim strCompPass As String 'string that holds the input in txtCompanyPass which will be treated as the Password 

        strCompUser = RTrim(txtCompanyUser.Text) 'The Trimed Text from txtCompUser.Text is stored in a string 
        strCompPass = RTrim(txtCompanyPass.Text) 'The Trimed Text from txtCompPass.Text is stored in a string 


        If String.IsNullOrEmpty(strCompUser) = True And String.IsNullOrEmpty(strCompPass) = True Then 'If both Username nand Password is not entered, both are considered NullOrEmpty (will return true) and the check won't go through
            MsgBox("Please Enter a Username and Password")
        ElseIf String.IsNullOrEmpty(strCompUser) = True Then 'If the Company Username is not entered, it is considered NullOREmpty (will return True), the check won't go through
            MsgBox("Please Enter a Username")

        ElseIf String.IsNullOrEmpty(strCompPass) = True Then 'If the password is null or empty, entry is rejected
            MsgBox("Please Enter a Password")

        Else

            If strCompUser = "Admin" And strCompPass = "Admin" Then 'string is compared with expected password and username
                Me.Width = 1041 'makes the rest of the Form accessible if correct
                Me.Height = 624 'changes the width and height to show the rest of the form
                lblLoginHeader.Visible = False 'changes the login header to invisible
                lblUsername.Visible = False 'changes the username label header to invisible
                lblPassword.Visible = False 'changes the password label header to invisible
                txtCompanyPass.Visible = False 'text box for company password to invisible
                txtCompanyUser.Visible = False ' text box company username to invisible 
                lblPlease.Visible = False ' Instruction label set to invisible
                btnCompanySignIn.Visible = False 'Company Sign In button set to invisible

            ElseIf strCompUser = "ManagerKar" And strCompPass = "Infoysys123" Then 'string is compared with expected password and username
                Me.Width = 1041 'makes the rest of the Form accessible if correct
                Me.Height = 624 'changes the width and height to show the rest of the form
                lblLoginHeader.Visible = False 'changes the login header to invisible
                lblUsername.Visible = False 'changes the username label header to invisible
                lblPassword.Visible = False 'changes the password label header to invisible
                txtCompanyPass.Visible = False 'text box for company password to invisible
                txtCompanyUser.Visible = False ' text box company username to invisible 
                lblPlease.Visible = False ' Instruction label set to invisible
                btnCompanySignIn.Visible = False 'Company Sign In button set to invisible
                btnCompanySignIn.Visible = False
            ElseIf strCompUser = "MrSteel" And strCompPass = "Rox123" Then 'string is compared with expected password and username
                Me.Width = 1041 'makes the rest of the Form accessible if correct
                Me.Height = 624 'changes the width and height to show the rest of the form
                lblLoginHeader.Visible = False 'changes the login header to invisible
                lblUsername.Visible = False 'changes the username label header to invisible
                lblPassword.Visible = False 'changes the password label header to invisible
                txtCompanyPass.Visible = False 'text box for company password to invisible
                txtCompanyUser.Visible = False ' text box company username to invisible 
                lblPlease.Visible = False ' Instruction label set to invisible
                btnCompanySignIn.Visible = False 'Company Sign In button set to invisible
            Else
                MsgBox("Incorrect Username or Password") 'informs the user the details are incorrect and clears the text for another attempt 
                txtCompanyUser.Clear() 'textboxes cleared
                txtCompanyPass.Clear()
            End If
        End If
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnTeamGenerateReport.Click
        'Generates a simple on screen message box of the task that will be completed and its team members. 
        ' This is done by assigning the information from the data set using the stored indexes for references to a string and displaying that string

        Dim strOutput As String 'String that holds output
        Dim intCtr As Integer 'Integer Counter


        strOutput = "Task Name: " & strTaskName & vbNewLine 'Places the information for the report in strOutput
        'These variables contain the task information that was selected. They are used rather than a row index from the task list data because the entry is removed. Variables hold the soon to be deleted data when the
        ' task is selected so it can be referenced now
        strOutput += "Client Company: " & strCompany & vbNewLine 'new line after each piece of info written

        strOutput += "Staff Required: " & intStaff & vbNewLine

        strOutput += "Task Duration: " & intTaskDuration & " Weeks" & vbNewLine




        For intCtr = 0 To intNumRequired - 1 'Uses the number of staff required and subtracts one (the array / data set starts at 0) to write out all the employees in the team
            strOutput += "Employee " & intCtr + 1 & ": " & frmMainMenu.tblEmployeeData.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colFirstname) & " " & frmMainMenu.tblEmployeeData.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colLastname) & vbNewLine
        Next
        MsgBox(strOutput)
    End Sub

    Private Sub btnSaveReport_Click(sender As Object, e As EventArgs) Handles btnSaveReport.Click 'Event that will prompt the save file dialogue to save the team report to a csv file. This is done by using the export subroutine whereby the delimiting character is passed 
        Dim strFileName As String 'String for the filename

        strFileName = "" 'strFileName is blank by default 
        sfdCompanyReport.Filter = "Text File (*.csv)|*.csv" 'sets the file to be made as a csv by default 
        If sfdCompanyReport.ShowDialog = DialogResult.OK Then ' if the prompt is accepted, the code is run
            strFileName = sfdCompanyReport.FileName 'string takes the file name from the selected file from the sfd
            ExportCSVCompanyReport(",", strFileName) 'exporting subroutine is called                                
        Else
            MsgBox("Cannot proceed. No file selected") 'basic error message 
        End If


    End Sub

    Private Sub btnSaveAvail_Click(sender As Object, e As EventArgs) Handles btnSaveAvail.Click 'Event that will prompt the save file dialogue to save the availabillity to a csv file. This is done by using the export subroutine whereby the delimiting character is passed 

        Dim strFileName As String 'String for the file name

        strFileName = ""  'strFileName is blank by default 
        sfdAvailabillityChanges.Filter = "Text File (*.csv)|*.csv" 'sets the file to be made as a csv by default 

        MsgBox("Please Name the File with the Keyword 'Availability' so the system can detect the file later.")

        If sfdAvailabillityChanges.ShowDialog = DialogResult.OK Then ' if the prompt is accepted, the code is run
            strFileName = sfdAvailabillityChanges.FileName 'string takes the file name from the selected file from the sfd
            ExportAvailabillityChanges(",", strFileName) 'exporting subroutine is called 
        Else
            MsgBox("Cannot proceed. No file selected")

        End If

    End Sub

    Sub ExportCSVCompanyReport(ByVal chrDelimiter As Char, ByVal strFileName As String) 'Subroutine that is responsible for writing the file, it will write all the relevant task information and all the employees that will be working on the team
        Dim filSaveFile As New System.IO.StreamWriter(strFileName) 'Stream writer is used to write the file for exporting 

        Dim intCtr As Integer
        ' The File starts with first writing the variables there were stored in the strings when the task was selected. This is essential because once the task is removed from the table, it can no longer be accessed. This method of storing the info in strings allow the data 
        ' to be referenced later on.
        filSaveFile.WriteLine(strTaskName) ' Writes Task Name
        filSaveFile.WriteLine(strCompany) 'Writes the task information that has been selected (Writes Company Name)
        filSaveFile.WriteLine(intStaff) 'Writes the number of staff
        filSaveFile.WriteLine(intTaskDuration) 'Writes the number of weeks it will take



        For intCtr = 0 To intNumRequired - 1 'using an intCounter and the number of employeed that were needed for the team to write them into the file 
            filSaveFile.Write(frmMainMenu.tblEmployeeData.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colFirstname) & chrDelimiter) 'chrDelimter, which is the comma, is placed at the end to delimit the information. a coma between their first name and last name 
            filSaveFile.WriteLine(frmMainMenu.tblEmployeeData.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colLastname)) 'writes the employees first name and then a delimiter and their last name.
        Next
        filSaveFile.Close() 'file is closed and disposed when the writing is done
        filSaveFile.Dispose()
    End Sub

    Sub ExportAvailabillityChanges(ByVal chrDelimter As Char, ByVal strFileName As String) 'Subroutine that is responsible for writing the file, it will write all information  required for an availabillity report, the employee name, status and return date. This file created will be a csv and can be reread into the system
        Dim filSaveFile As New System.IO.StreamWriter(strFileName) 'Stream writer is used for exporting, writing to the new file

        Dim thisDate As Date 'Dimensions a date 
        thisDate = Today ' Takes today's date and stores it into thisDate
        Dim intCtr As Integer 'Creates an integer counter for the for loop

        Dim intdays As Integer 'Intdays holds then number of days the task will take to complete for calculations 

        intdays = intTaskDuration * 7 'takes the number of weeks from the task column, and multiplies by 7 for days, used to calculate the return date.

        Dim returndate As Date ' creates a variable date that will hold the return date

        returndate = thisDate.AddDays(intdays) 'Return date is simply the current date but the number of days the task will task added on
        'Effectively rewrites the table availability. This is so that the changes whereby status' were updated are reflected in the system in future uses of the system. 
        For intCtr = 0 To frmMainMenu.tblAvailabillity.Rows.Count - 1 'takes the number of rows of the existing availability table and subtracts one since intCtr will start from 0
            filSaveFile.Write(frmMainMenu.tblAvailabillity.Rows(intCtr).Item(frmMainMenu.colFName) & chrDelimter) 'the delimiting character, comma, is put after each field of data 
            filSaveFile.Write(frmMainMenu.tblAvailabillity.Rows(intCtr).Item(frmMainMenu.colLName) & chrDelimter) 'Prints the information into the file
            filSaveFile.Write(frmMainMenu.tblAvailabillity.Rows(intCtr).Item(frmMainMenu.colStatus) & chrDelimter) 'Writes the First Name, Last Name, Employee Status and Return Date, each delimited by a comma
            filSaveFile.WriteLine(frmMainMenu.tblAvailabillity.Rows(intCtr).Item(frmMainMenu.colDate))

        Next
        filSaveFile.Close() 'Once this is done, the file is closed and disposed as it is no longer being used. THis prevents data corruption.
        filSaveFile.Dispose()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAvailabillityReport.Click 'Event that creates a simple onscreen message version of the availabillity that is going to be saved to the file 
        Dim strOutput As String 'String that will be displayed in the message box 
        Dim intCtr As Integer

        Dim thisDate As Date 'A variable date that will hold today's date is dimensioned 
        thisDate = Today 'variable takes today's date
        Dim intdays As Integer 'integer that will hold the number of days the task will take
        intdays = intTaskDuration * 7 'takes the number of weeks the task takes to complete and multiplies it by 7 to calculate the days 
        Dim returndate As Date 'variable date that will hold the date that the task ends

        returndate = thisDate.AddDays(intdays) 'task duration in days is added to today's date to calculate the return date

        strOutput = "Employees No Longer Available | Return Date" & vbNewLine 'Header for the message box 

        For intCtr = 0 To intNumRequired - 1 ''using an intCounter and the number of employeed that were needed for the team to write them into the file 
            strOutput += frmMainMenu.tblEmployeeData.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colFirstname) & " " & frmMainMenu.tblEmployeeData.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colLastname) & "  " & returndate.ToString("dd/MM/yy") & vbNewLine ' for the return date column, formats it so it's just the date and not the time too
        Next
        MsgBox(strOutput) 'displayed in message box
    End Sub

    Private Sub btnFinaliseTeam_Click(sender As Object, e As EventArgs) Handles btnFinaliseTeam.Click 'Event that finialises the creation of the team, removing the selected task from the data set, and enabling buttons that allow functionality for finished team reports. 

        Dim taskDataRows As DataRowCollection = frmMainMenu.tblTaskList.Rows 'Dimensions a collection of data rows as the rows from the table Task Lists,
        Dim deletionRow As DataRow = taskDataRows(intTaskReference) 'Dimensions a row (the row that will be deleted) as a row from taskDataRows (from table TaskListData) as the row indexed by inTaskReference



        taskDataRows.Remove(deletionRow) 'This row is deleted from tblTaskListData
        ' Changes button availabillity 
        btnTeamGenerateReport.Enabled = True
        btnSaveReport.Enabled = True
        btnAvailabillityReport.Enabled = True
        btnSaveAvail.Enabled = True
        btnFinaliseTeam.Enabled = False
        btnNewTaskList.Enabled = True
        bolTeamFinalised = True
        Dim thisDate As Date 'A variable date that will hold today's date is dimensioned 
        thisDate = Today 'variable takes today's date
        Dim intdays As Integer 'integer that will hold the number of days the task will take
        intdays = intTaskDuration * 7 'takes the number of weeks the task takes to complete and multiplies it by 7 to calculate the days 
        Dim returndate As Date 'variable date that will hold the date that the task ends

        returndate = thisDate.AddDays(intdays) 'task duration in days is added to today's date to calculate the return date

        Dim intCtr As Integer 'creates an integer counter
        'Loop used to update all the necessary parts of the employee availability table. Since arrEmployeeReference (starting at 0) holds the reference number of each employee added as they were added, we can use that array paired with intCounter to update all the employees who 
        ' are no longer considered avaialble, changing their status and their date.
        For intCtr = 0 To intNumRequired - 1 ''using an intCounter and the number of employeed that were needed for the team to write them into the file. 
            frmMainMenu.tblAvailabillity.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colStatus) = "No" 'arrEmployeReference paired with intcounter to only get the references of the employees that are working on the team.
            frmMainMenu.tblAvailabillity.Rows(arrEmployeeReference(intCtr)).Item(frmMainMenu.colDate) = returndate.ToString("dd/MM/yy")
        Next

        MsgBox("The team has been finalised and this task has been removed from the List of Available Tasks. Employees also have their Availability Status changed and their return dates updated. To save the new list of tasks, please export the new list by clicking on 'Save Task List'. To save the new Availability list please export the new lsit by clicking on the save New Availability List Button. To generate other reports, use the buttons on screen.")

    End Sub


    Sub ExportNewTaskList(ByVal chrDelimter As Char, ByVal strFileName As String)
        Dim filSaveFile As New System.IO.StreamWriter(strFileName) 'StreamWriter is used to create the new task list file, which will be saved as csv.
        Dim intCtr As Integer 'Creates an integer counter

        ' The Task List is rewritten, it takes the number of rows from the data set and writes the tasks into the files. As a result of the selected task being removed, it will not be written in the new file
        For intCtr = 0 To frmMainMenu.tblTaskList.Rows.Count - 1 'takes the number of rows of the existing availability table and subtracts one since intCtr will start from 0
            filSaveFile.Write(frmMainMenu.tblTaskList.Rows(intCtr).Item(frmMainMenu.colTaskName) & chrDelimter) 'the delimiting character, comma, is put after each field of data 
            filSaveFile.Write(frmMainMenu.tblTaskList.Rows(intCtr).Item(frmMainMenu.colCompany) & chrDelimter) 'Prrints the data into the file
            filSaveFile.Write(frmMainMenu.tblTaskList.Rows(intCtr).Item(frmMainMenu.colStaff) & chrDelimter) 'Task Name, Company, Staff and Weeks are rewritten into the file, each delimited by a comma
            filSaveFile.WriteLine(frmMainMenu.tblTaskList.Rows(intCtr).Item(frmMainMenu.colWeeks))

        Next
        filSaveFile.Close() 'once this is done, the file is closed and disposed as it is no longer being used. 
        filSaveFile.Dispose()
    End Sub

    Private Sub btnNewTaskList_Click(sender As Object, e As EventArgs) Handles btnNewTaskList.Click 'Event that will prompt the save file dialogue to save the availabillity to a csv file. This is done by using the export subroutine whereby the delimiting character is passed 
        MsgBox("Please Name the File With the Keyword 'Task' so the system can detect the file later.")
        Dim strFileName As String 'String that holds the name of the file 

        strFileName = "" 'string is made blank at first 
        sfdTaskListChanges.Filter = "Text File (*.csv)|*.csv" 'sets the file to be made as a csv by default 
        If sfdTaskListChanges.ShowDialog = DialogResult.OK Then 'f the user responds to the sfd (OK) then the code is run
            strFileName = sfdTaskListChanges.FileName 'chosen file name is assigned to strFileName
            ExportNewTaskList(",", strFileName) 'the file name and the delmiting character is passed to the subroutine
        Else
            MsgBox("Cannot proceed. No file selected") 'error message

        End If

    End Sub


End Class

