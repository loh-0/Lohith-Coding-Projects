
Module Searching

    Function LinearSearchcolLastname(ByVal strSearchItem As String) 'Function that is used to search through the data set and return the index of the row on the table. This function is used many times to find and display information from the tables by searching one column 
        'strSearchItem is used, the user gives this value by inputting it into the textbox and is used for searching here

        Dim intSearchItemRowIndex As Integer = -1 'the default row index number is created, given the value of -1 to begin as other values (like 0) index a row, and thus -1 
        Dim intCtr As Integer 'integer counter

        While intCtr <= frmMainMenu.tblEmployeeData.Rows.Count - 1 'takes the total number of rows and minus one (since we're counting from 0), when the counter is not equal to the row count

            If frmMainMenu.tblEmployeeData.Rows(intCtr).Item(frmMainMenu.colLastname) = strSearchItem Then 'if the target matches the data entry then 
                intSearchItemRowIndex = intCtr 'the row takes the value of int counter as it contains the row that the target is found on
            End If

            intCtr += 1 'counter is incremented by one when searching through

        End While

        Return (intSearchItemRowIndex) 'value with the row number is returned 
    End Function


    Function LinearSearchcolID(ByVal strSearchItem As String) 'Function that is used to search through the data set and return the index of the row on the table. This function is used many times to find and display information from the tables by searching one column
        'strSearchItem is used, the user gives this value by inputting it into the textbox and is used for searching here

        Dim intSearchItemRowIndex As Integer = -1 'the default row index number is created, given the value of -1 to begin as other values (like 0) index a row, and thus -1 
        Dim intCtr As Integer 'integer counter

        While intCtr <= frmMainMenu.tblEmployeeData.Rows.Count - 1 'takes the total number of rows and minus one (since we're counting from 0), when the counter is not equal to the row count

            If frmMainMenu.tblEmployeeData.Rows(intCtr).Item(frmMainMenu.colID) = strSearchItem Then 'if the target matches the data entry then 
                intSearchItemRowIndex = intCtr 'the row takes the value of int counter as it contains the row that the target is found on
            End If

            intCtr += 1 'counter is incremented by one when searching through

        End While

        Return (intSearchItemRowIndex) 'value with the row number is returned 
    End Function


    Function LinearSearchcolFirstname(ByVal strSearchItem As String) 'Function that is used to search through the data set and return the index of the row on the table. This function is used many times to find and display information from the tables by searching one column

        Dim intSearchItemRowIndex As Integer = -1 'the default row index number is created, given the value of -1 to begin as other values (like 0) index a row, and thus -1 
        Dim intCtr As Integer 'integer counter

        While intCtr <= frmMainMenu.tblEmployeeData.Rows.Count - 1 'takes the total number of rows and minus one (since we're counting from 0), when the counter is not equal to the row count

            If frmMainMenu.tblEmployeeData.Rows(intCtr).Item(frmMainMenu.colFirstname) = strSearchItem Then 'if the target matches the data entry then 
                intSearchItemRowIndex = intCtr 'the row takes the value of int counter as it contains the row that the target is found on
            End If

            intCtr += 1 'counter is incremented by one when searching through

        End While

        Return (intSearchItemRowIndex) 'value with the row number is returned 



    End Function


    Function LinearSearchcolTaskname(ByVal strSearchItem As String) 'Function that is used to search through the data set and return the index of the row on the table. This function is used many times to find and display information from the tables by searching one column

        Dim intSearchItemRowIndex As Integer = -1 'the default row index number is created, given the value of -1 to begin as other values (like 0) index a row, and thus -1 
        Dim intCtr As Integer 'integer counter

        While intCtr <= frmMainMenu.tblTaskList.Rows.Count - 1 'takes the total number of rows and minus one (since we're counting from 0), when the counter is not equal to the row count

            If frmMainMenu.tblTaskList.Rows(intCtr).Item(frmMainMenu.colTaskName) = strSearchItem Then 'if the target matches the data entry then 
                intSearchItemRowIndex = intCtr 'the row takes the value of int counter as it contains the row that the target is found on
            End If

            intCtr += 1 'counter is incremented by one when searching through

        End While

        Return (intSearchItemRowIndex) 'value with the row number is returned 

    End Function


    Function intFindcolLastnames(ByVal strSearchItem As String) As Integer 'Function that is used to search through the data set and return the index of the row on the table. This function is used many times to find and display information from the tables by searching one column, this one is different to previous searches as it returns more than one row found if there's more than one person with the same last name

        Dim intSearchItemRowIndex As Integer = -1 'the default row index number is created, given the value of -1 to begin as other values (like 0) index a row, and thus -1 
        Dim intCtr As Integer 'integer counter

        While intCtr <= frmMainMenu.tblEmployeeData.Rows.Count - 1 'takes the total number of rows and minus one (since we're counting from 0), when the counter is not equal to the row count

            If frmMainMenu.tblEmployeeData.Rows(intCtr).Item(frmMainMenu.colLastname) = strSearchItem Then 'if the target matches the data entry then 
                intSearchItemRowIndex = 1000000 'The Index is set to a really high number outside the rows of the table, this done because we are using ShowResults(intCtr) where found row index is passsed to the fucntion that will display the results, and then the loop will continue. This will enable us to show all people with the same last name. 
                ShowResults(intCtr)
            End If

            intCtr += 1 'counter is incremented by one when searching through

        End While

        Return (intSearchItemRowIndex) 'value with the row number is returned 

    End Function
    Sub ShowResults(ByVal intFound As Integer) 'Sub routine that takes the found row from the searches (intCtr) and uses it to format results that is displayed on the Search Form. This is done by using a Message Box, and with the index, all relevant information can be drawn and placed in a string that will be displayed.
        Dim strOutput As String

        strOutput = "First Name: " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colFirstname) & vbNewLine 'when choosing what number row it is, we use intFound as it holds the row number of the target element, this is formatted into the output message 
        strOutput += "Last Name: " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colLastname) & vbNewLine            'formatting strOutput, making it contain each of the relevant information and will display it in a message box 
        strOutput += "Department: " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colDepartment) & vbNewLine 'Writes the FirstName, LastName, Department, Skillset, ID 
        strOutput += "Skillset: " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colSkillset) & vbNewLine
        strOutput += "ID: " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colID)

        frmEmpSearch.txtSearchLogs.Text += vbNewLine & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colFirstname) & " | " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colLastname) & " | " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colDepartment) & " | " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colSkillset) & " | " & frmMainMenu.tblEmployeeData.Rows(intFound).Item(frmMainMenu.colID) 'writes the data with pipes to separate them

        frmEmpSearch.txtLastInput.Clear() 'Clears the text boxes for convenience

        frmEmpSearch.txtFirstInput.Clear()

        MsgBox(strOutput)
    End Sub


    Function intFindFirstname(ByVal strSearchItem As String) 'Function that is used to search through the data set and return the index of the row on the table. This function is used many times to find and display information from the tables by searching one column, this one is different to previous searches as it returns more than one row found if there's more than one person with the same first name

        Dim intSearchItemRowIndex As Integer = -1 'the default row index number is created, given the value of -1 to begin as other values (like 0) index a row, and thus -1 
        Dim intCtr As Integer 'integer counter

        While intCtr <= frmMainMenu.tblEmployeeData.Rows.Count - 1 'takes the total number of rows and minus one (since we're counting from 0), when the counter is not equal to the row count

            If frmMainMenu.tblEmployeeData.Rows(intCtr).Item(frmMainMenu.colFirstname) = strSearchItem Then 'if the target matches the data entry then 
                intSearchItemRowIndex = 1000000 'The Index is set to a really high number outside the rows of the table, this done because we are using ShowResults(intCtr) where found row index is passsed to the fucntion that will display the results, and then the loop will continue. This will enable us to show all people with the same first name. 
                ShowResults(intCtr)
            End If

            intCtr += 1 'counter is incremented by one when searching through

        End While

        Return (intSearchItemRowIndex) 'value with the row number is returned 

    End Function

    Function LinearValidation(ByVal arrList() As String, ByVal strSearchItem As String) As Integer 'Function that searches through an array, instead of a data set, Array 

        Dim intCtr As Integer 'integer counter is defined as an integer 

        While intCtr <= arrList.Length - 1 'Goes through the array, subtracts the array's length by one as arrays start at 0 as the first index 
            If arrList(intCtr) = strSearchItem Then 'if the target is found the value of intCtr is returned
                Return intCtr
            End If

            intCtr += 1 '1 added to intCtr
        End While

        Return -1 'Negative one is the number returned if the desired target was NOT located.

    End Function

End Module
