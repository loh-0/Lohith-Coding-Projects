Public Class frmAppLogin 'Criterion 6, Project Management System Created by Lohith Karthesan 

    'This is the Infosys Project Manager Application. The purpose of this application was to provide managers with a tool to create their own teams at Infosys. The system works by taking Information from Infosys' Database, and displaying it to 
    ' project managers in a clear and organised way. The Company Files relating to the "Employee Data", "Task List Data" and "Availabillity Data" (for first use, all employees are available) are read into the system using StreamReader. The information is stored 
    ' in a data set, can be used and in various ways. First, the user can search through the Employee Lists, searching by their First or Last Name. Searches are displayed in a search log, so the user can search multiple people and the results are still on screen
    ' In addition, due to the nature of Data Grid Views, information from the tables can be displayed on a DGV granting the user a clear and clean table to view all the data from the files. The data can be sorted alphabetically too, based on the columns. 
    ' The main feature of this System however would be the Create a Team function. This allows project managers to first, select a task, then choose the employees from the data base and put toegether a team. An on screen text box will constantly reflect additions to the
    ' team and a final Message Box can display the team once completed. Upon finalisation of the team, the task will be removed from the Task List, and the user can generate a new task list for future use, saved as CSV and can be read into the system. A csv file that holds all the
    ' task details and employees working on it can also be generated for the purpose of provoding it to the Company however can't be read back into the system. Finally, changes to availabillity, whereby due to the selection and employee is assigned to a team and will be unavailable 
    ' will also be shown in a message box. The msgbox will entail the return date of the employees, and all of them who are leaving. The availbility new list can be saved, and read into the system again, where the table will show the employees, with their status updated (No for Available) and 
    ' their return date. When the team is "finalised" the task will be removed the list and the availability changes are made to the information in the system. AFter the team has been created, changes can be seen when viewing the
    ' compnay lists (data grid views),


    Dim strAppUser As String 'string that holds username
    Dim strAppPass As String ' string that holds the password

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        strAppUser = RTrim(txtAppUsername.Text) ' the username and password, the text of these text boxes first have any trailing spaces removed and the text is stored in the string
        strAppPass = RTrim(txtAppPassword.Text)


        If String.IsNullOrEmpty(strAppUser) = True And String.IsNullOrEmpty(strAppPass) = True Then 'If both Username and Password are NullOrEmpty, entry is rejected
            MsgBox("Please Enter a Username and Password")

        ElseIf String.IsNullOrEmpty(strAppPass) = True Then 'If Username is Empty, entry is rejected
            MsgBox("Please Enter a Passowrd") '

        ElseIf String.IsNullOrEmpty(strAppUser) = True Then 'If password is empty
            MsgBox("Please Enter a Username")

        Else

            If strAppUser = "Admin" And strAppPass = "Admin" Then 'string is compared with expected password and username
                frmMainMenu.Show() 'takes the user to the next form if correct
                Me.Hide()

            ElseIf strAppUser = "Kar" And strAppPass = "Infoysys123" Then 'string is compared with expected password and username
                frmMainMenu.Show() 'takes the user to the next form if correct
                Me.Hide()

            ElseIf strAppUser = "LohAdmin" And strAppPass = "Mazenod123" Then 'string is compared with expected password and username
                frmMainMenu.Show() 'takes the user to the next form if correct
                Me.Hide()

            Else
                MsgBox("Incorrect Username or Password") 'informs the user the details are incorrect and clears the text for another attempt 
                txtAppUsername.Clear() 'Clears text textbox
                txtAppPassword.Clear() 'Clears text in textbox
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmMainMenu.Show() 'Shows the Main Menu Form
        Me.Hide() 'hides current form
    End Sub

End Class
