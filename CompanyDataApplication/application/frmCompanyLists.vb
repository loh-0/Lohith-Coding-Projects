Public Class frmCompanyLists
    Private Sub frmCompanyLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmployeeData.DataSource = frmMainMenu.tblEmployeeData 'code that allows the data set from frmMainMenu to be accessed 
        dgvTaskList.DataSource = frmMainMenu.tblTaskList 'code that allows the data set from frmMainMenu to be accessed 
        dgvAvailabillity.DataSource = frmMainMenu.tblAvailabillity 'code that allows the data set from frmMainMenu to be accessed 
    End Sub

    Private Sub lblReturn_Click(sender As Object, e As EventArgs) Handles lblReturn.Click
        Me.Hide() 'hides the current form 
        frmMainMenu.Show() 'reveals the main menu
    End Sub


End Class