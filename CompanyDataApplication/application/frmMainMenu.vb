Public Class frmMainMenu
    Dim strFileName As String 'string that holds the user input name of the file 
    Dim bolEmpDataRead As Boolean 'Boolean that holds whether or not employee data is in the system
    Dim bolTaskDataRead As Boolean 'Boolean that holds  whether or not task data is in the system
    Dim bolAvailabillityDataRead As Boolean 'Boolean that holds whether or not availabillity data is in the system
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 175 'changes the wdith so only part of the form can be seen
        btnCreateTeam.Visible = False 'hides all the buttons that change the forms
        btnFrmLists.Visible = False
        btnfrmSearch.Visible = False
    End Sub

    Private Sub btnSelectEmpData_Click(sender As Object, e As EventArgs) Handles btnSelectEmpData.Click
        If ofdSelectFile.ShowDialog <> DialogResult.Cancel Then 'Code that forces the open file dialogue prompt, if this is not cancelled then the following code is run 
            strFileName = ofdSelectFile.FileName 'strFileName takes the name of the file selected from the openfiledialogue

            If ofdSelectFile.FileName.Contains("Employee") Then 'If the selected file has the word employee in it, it is the appropriate data and the code can proceed

                DisplayEmpFileUsingSplit(",") 'runs the reading subroutine
                btnSelectEmpData.Visible = False 'hides the button
                bolEmpDataRead = True 'marks the data as in the system

                If bolEmpDataRead And bolTaskDataRead = True And bolAvailabillityDataRead = True Then 'Code executed if all the data is in the system, the width is adjusted and the form change buttons are visible for use, the whole main menu is displayed now.
                    Me.Width = 733 'Width is changed to show the rest of the form
                    lblPleaseSelectFiles.Visible = False 'label hidden
                    'Buttons that show other forms are shown now
                    btnCreateTeam.Visible = True
                    btnFrmLists.Visible = True
                    btnfrmSearch.Visible = True

                End If

            Else
                MsgBox("Incorrect File Selected, please choose the Employee Data FIle") 'Error message preventing the selection to go any further if the incorrect file was selected 
            End If

        Else
            MsgBox("Can not proceed, no file selected.") 'error message

        End If
    End Sub


    Sub DisplayEmpFileUsingSplit(ByVal strDelimiter As String) 'This subroutine is responsible for reading the employee file into the system. The data is read into a data set. The files being read are CSV files and hence the delimter "," is taken from the event that calls the subroutine
        ' A string is dimensioned which will hold each line read in, an array is also dimensioned to temporarily store the data from the file to place into the data set. 
        ' 'Row Input' is a variable dimensioned as a data row 
        ' StreamReader is dimensioned 
        ' .EndoFStream is used to loop through, reading data until the file end is reached 

        Dim strEmployeeLine As String
        Dim arrEmployeeDataRecord() As String
        Dim rowinput As DataRow

        Dim filRead As New System.IO.StreamReader(strFileName) 'StreamReader used to read in the information from the file 

        While Not filRead.EndOfStream 'While the end of the file has not been reached 

            rowinput = tblEmployeeData.NewRow 'RowINput is a new row in the table for Employeee Data 
            strEmployeeLine = filRead.ReadLine 'the string holds a line from the text file 
            arrEmployeeDataRecord = strEmployeeLine.Split(strDelimiter) 'the string is broken up based on the delimiting character, the , and is stored into an array 

            'The information from the array is taken and stored into the relevant columns from the table.
            'An Input in the row is an entry in the array that was created by delimiting the string line and placing each piece of information into an array
            rowinput(colFirstname) = arrEmployeeDataRecord(0)
            rowinput(colLastname) = arrEmployeeDataRecord(1)
            rowinput(colDepartment) = arrEmployeeDataRecord(2)
            rowinput(colSkillset) = arrEmployeeDataRecord(3)
            rowinput(colID) = arrEmployeeDataRecord(4)
            tblEmployeeData.Rows.Add(rowinput) 'add the end of each entry, a new row is added for the next line of data 

        End While

        filRead.Close() 'file is closed and disposed since we are no longer using it. 
        filRead.Dispose()

    End Sub

    Sub DisplayTaskFileUsingSplit(ByVal strDelimiter As String) 'This subroutine is responsible for reading the task data file into the system. The data is read into a data set. The files being read are CSV files and hence the delimter "," is taken from the event that calls the subroutine
        ' A string is dimensioned which will hold each line read in, an array is also dimensioned to temporarily store the data from the file to place into the data set. 
        ' 'Row Input' is a variable dimensioned as a data row 
        ' StreamReader is dimensioned 
        ' .EndoFStream is used to loop through, reading data until the file end is reached
        Dim strTaskLine As String
        Dim arrTaskDataRecord() As String
        Dim rowinput As DataRow

        Dim filRead As New System.IO.StreamReader(strFileName)  'StreamReader used to read in the information from the file 

        While Not filRead.EndOfStream 'While the end of the file has not been reached 

            rowinput = tblTaskList.NewRow 'RowInput is a new row in the table for Task List Data 
            strTaskLine = filRead.ReadLine 'the string holds a line from the text file 
            arrTaskDataRecord = strTaskLine.Split(strDelimiter) 'the string is broken up based on the delimiting character, the , and is stored into an array 

            'The information from the array is taken and stored into the relevant columns from the table.
            'An Input in the row is an entry in the array that was created by delimiting the string line and placing each piece of information into an array
            rowinput(colTaskName) = arrTaskDataRecord(0)
            rowinput(colCompany) = arrTaskDataRecord(1)
            rowinput(colStaff) = arrTaskDataRecord(2)
            rowinput(colWeeks) = arrTaskDataRecord(3)
            tblTaskList.Rows.Add(rowinput) 'add the end of each entry, a new row is added for the next line of data 


        End While

        filRead.Close() 'file is closed and disposed since we are no longer using it. 
        filRead.Dispose()

    End Sub

    Private Sub btnSelectTaskData_Click(sender As Object, e As EventArgs) Handles btnSelectTaskData.Click 'Button that will prompt the open file dialog enabling the user select the file they want to be read into the system.
        If ofdSelectFile.ShowDialog <> DialogResult.Cancel Then 'Forces the open file dialog to show and executes the code if this message is not cancelled 
            strFileName = ofdSelectFile.FileName

            If ofdSelectFile.FileName.Contains("Task") Then 'Validation to ensure that the user selects a file name with "Task List", if the user selects the incorrect file, this could cause the program to crash as it fails to read the file, with its data being in an incorrect format. Hence this code is in place to validate file selection

                DisplayTaskFileUsingSplit(",") 'provides the reading subroutine with the delimiting character the , 
                btnSelectTaskData.Visible = False ' once the file has been succesful read into the system, the button is no longer needed and is hidden
                bolTaskDataRead = True

                If bolEmpDataRead = True And bolTaskDataRead = True And bolAvailabillityDataRead = True Then 'Does a check to see if all the booleans indicating whether or not the data has been read is true or not, if it is true then the code is run to change the screen to show the main menu 
                    Me.Width = 733                    'Updates Width to show the rest of the form
                    lblPleaseSelectFiles.Visible = False 'Hides label
                    'Shows the Form Change Buttons 
                    btnCreateTeam.Visible = True
                    btnFrmLists.Visible = True
                    btnfrmSearch.Visible = True
                End If

            Else
                MsgBox("Incorrect File Selected, Please choose the Task Data File.") ' Basic Error message 
            End If
        Else
            MsgBox("Can not proceed, no file selected.") 'Basic Error message
        End If
    End Sub


    Sub DisplayAvailabillityFileUsingSplit(ByVal strDelimiter As String) 'This subroutine is responsible for reading the availabillity file into the system. The data is read into a data set. The files being read are CSV files and hence the delimter "," is taken from the event that calls the subroutine
        ' A string is dimensioned which will hold each line read in, an array is also dimensioned to temporarily store the data from the file to place into the data set. 
        ' 'Row Input' is a variable dimensioned as a data row 
        ' StreamReader is dimensioned 
        ' .EndoFStream is used to loop through, reading data until the file end is reached

        Dim strAvailabillityLine As String
        Dim arrAvailabillityDataRecord() As String
        Dim rowinput As DataRow

        Dim filRead As New System.IO.StreamReader(strFileName) 'StreamReader used to read in the information from the file 

        While Not filRead.EndOfStream 'While the end of the file has not been reached 

            rowinput = tblAvailabillity.NewRow 'RowInput is a new row in the table for Availabillity Data 
            strAvailabillityLine = filRead.ReadLine 'the string holds a line from the text file 
            arrAvailabillityDataRecord = strAvailabillityLine.Split(strDelimiter) 'the string is broken up based on the delimiting character, the , and is stored into an array 

            'The information from the array is taken and stored into the relevant columns from the table.
            'An Input in the row is an entry in the array that was created by delimiting the string line and placing each piece of information into an array
            rowinput(colFName) = arrAvailabillityDataRecord(0)
            rowinput(colLName) = arrAvailabillityDataRecord(1)
            rowinput(colStatus) = arrAvailabillityDataRecord(2)
            rowinput(colDate) = arrAvailabillityDataRecord(3)


            tblAvailabillity.Rows.Add(rowinput) 'add the end of each entry, a new row is added for the next line of data 

        End While

        filRead.Close() 'file is closed and disposed since we are no longer using it. 
        filRead.Dispose()
    End Sub

    Private Sub btnSelectAvailabillityData_Click(sender As Object, e As EventArgs) Handles btnSelectAvailabillityData.Click 'Button that will prompt the open file dialog enabling the user select the file they want to be read into the system.

        If ofdSelectFile.ShowDialog <> DialogResult.Cancel Then 'Forces the open file dialog to show and executes the code if this message is not cancelled 

            strFileName = ofdSelectFile.FileName

            If ofdSelectFile.FileName.Contains("Availability") Then 'Validation to ensure that the user selects a file name with "Availabillity", if the user selects the incorrect file, this could cause the program to crash as it fails to read the file, with its data being in an incorrect format. Hence this code is in place to validate file selection

                DisplayAvailabillityFileUsingSplit(",") 'provides the reading subroutine with the delimiting character the , 
                btnSelectAvailabillityData.Visible = False
                bolAvailabillityDataRead = True ' once the file has been succesful read into the system, the button is no longer needed and is hidden


                If bolEmpDataRead And bolTaskDataRead = True And bolAvailabillityDataRead = True Then 'Does a check to see if all the booleans indicating whether or not the data has been read is true or not, if it is true then the code is run to change the screen to show the main menu 
                    Me.Width = 733 'width adjusted to show the rest of main menu
                    lblPleaseSelectFiles.Visible = False 'Label hidden
                    'Form Nagivation Buttons shown
                    btnCreateTeam.Visible = True
                    btnFrmLists.Visible = True
                    btnfrmSearch.Visible = True
                End If


            Else
                MsgBox("Incorrect File Selected, please choose the Availability file") ' Basic Error message 
            End If


        Else
            MsgBox("Can not proceed, no file selected.") ' Basic Error message 
        End If
    End Sub

    Private Sub btnfrmSearch_Click(sender As Object, e As EventArgs) Handles btnfrmSearch.Click 'Hides the main menu form and shows the Employee Search Form
        Me.Hide() 'Hides current form
        frmEmpSearch.Show() 'Shows Employee Search

    End Sub

    Private Sub btnFrmLists_Click(sender As Object, e As EventArgs) Handles btnFrmLists.Click 'Hides the main menu form and shows the Company Lists Form
        Me.Hide() 'Hides Current Form
        frmCompanyLists.Show() 'Shows Company Lists
    End Sub

    Private Sub btnCreateTeam_Click(sender As Object, e As EventArgs) Handles btnCreateTeam.Click 'Hides the main menu form and shows the Create a Team Form
        Me.Hide() 'Hides Current Form 
        frmCreateATeam.Show() 'Shows Create a Team
    End Sub

    Private Sub btnReselectData_Click(sender As Object, e As EventArgs) Handles btnReselectData.Click 'Event that will clear all the information stored in the data set.
        'This hides all the buttons for main form use and changes the width to hide the rest of the form
        ' The buttons that are used to read files into the system are visible once again. 
        dstProjectManager.Clear() 'wipes the data set 
        btnSelectAvailabillityData.Visible = True
        btnSelectEmpData.Visible = True
        btnSelectTaskData.Visible = True
        lblPleaseSelectFiles.Visible = True
        Me.Width = 175
        bolEmpDataRead = False
        bolTaskDataRead = False
        bolAvailabillityDataRead = False
        btnCreateTeam.Visible = False
        btnFrmLists.Visible = False
        btnfrmSearch.Visible = False


        'Clears all Existing Create a Team Processes Going On, Direct Copy and Paste from Restart Team Creator Button. This is to prevent any crashes from occuring if the user attempts to continue
        ' Working on the team with a different file with missing data. 

        frmCreateATeam.txtOutput.Clear()
        frmCreateATeam.txtEmployee.Clear()
        frmCreateATeam.txtTask.Clear()

        Array.Clear(frmCreateATeam.arrEmployeeReference, 0, frmCreateATeam.arrEmployeeReference.Length) 'Clears the array, removing all the data from it 
        Array.Clear(frmCreateATeam.arrEmployees, 0, frmCreateATeam.arrEmployees.Length) 'Clears the array, removing all the data from it 

        'Essentially restarts all the team creation progress in the Create a Team form. All buttons have their visibility restored to when the task needed to be selected first. Arrays are reset
        ' so there's no previous data held in them to cause errors and any booleans used to indicate stages of the team creation process are set back to false for a fresh start
        frmCreateATeam.lblRequiredEmps.Text = "Required Employees: "
        frmCreateATeam.txtEmployee.Visible = False
        frmCreateATeam.btnSelectEmp.Visible = False
        frmCreateATeam.lblNote.Visible = False
        frmCreateATeam.btnSelectID.Visible = False
        frmCreateATeam.lblEmployees.Visible = False
        frmCreateATeam.intStaffinTeam = 0 'ensures these variables start at 0 as the tool is being restarted, they should be 0 
        frmCreateATeam.intNumRequired = 0                                            ' This is a direct copy and paste from the Create a Team Form
        ' Various buttons have their visibiliy and .enabled changed to match the start of the team being created
        frmCreateATeam.lblInstruct1.Visible = True
        frmCreateATeam.lblInstruct2.Visible = False
        frmCreateATeam.btnTeamGenerateReport.Enabled = False
        frmCreateATeam.btnSaveReport.Enabled = False
        frmCreateATeam.btnAvailabillityReport.Enabled = False
        frmCreateATeam.btnSaveAvail.Enabled = False
        frmCreateATeam.btnSelectTask.Enabled = True
        frmCreateATeam.btnSelectEmp.Enabled = True
        frmCreateATeam.btnSelectID.Enabled = True
        frmCreateATeam.btnFinaliseTeam.Enabled = False
        frmCreateATeam.btnNewTaskList.Enabled = False
        frmCreateATeam.bolTeamFinalised = False
    End Sub

End Class