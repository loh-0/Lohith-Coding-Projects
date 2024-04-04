<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateATeam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLoginfrmheader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoginHeader = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtCompanyUser = New System.Windows.Forms.TextBox()
        Me.txtCompanyPass = New System.Windows.Forms.TextBox()
        Me.btnCompanySignIn = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.btnSelectTask = New System.Windows.Forms.Button()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.btnSelectEmp = New System.Windows.Forms.Button()
        Me.lblTask = New System.Windows.Forms.Label()
        Me.lblEmployees = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblOutlook = New System.Windows.Forms.Label()
        Me.lblRequiredEmps = New System.Windows.Forms.Label()
        Me.btnTeamGenerateReport = New System.Windows.Forms.Button()
        Me.btnSaveReport = New System.Windows.Forms.Button()
        Me.dstProjectManager = New System.Data.DataSet()
        Me.tblEmployeeData = New System.Data.DataTable()
        Me.colFirstname = New System.Data.DataColumn()
        Me.colLastname = New System.Data.DataColumn()
        Me.colDepartment = New System.Data.DataColumn()
        Me.colSkillset = New System.Data.DataColumn()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.btnSelectID = New System.Windows.Forms.Button()
        Me.lblPlease = New System.Windows.Forms.Label()
        Me.sfdCompanyReport = New System.Windows.Forms.SaveFileDialog()
        Me.btnSaveAvail = New System.Windows.Forms.Button()
        Me.sfdAvailabillityChanges = New System.Windows.Forms.SaveFileDialog()
        Me.btnAvailabillityReport = New System.Windows.Forms.Button()
        Me.lblInstruct1 = New System.Windows.Forms.Label()
        Me.lblInstruct2 = New System.Windows.Forms.Label()
        Me.btnFinaliseTeam = New System.Windows.Forms.Button()
        Me.btnNewTaskList = New System.Windows.Forms.Button()
        Me.sfdTaskListChanges = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dstProjectManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEmployeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLoginfrmheader
        '
        Me.lblLoginfrmheader.AutoSize = True
        Me.lblLoginfrmheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginfrmheader.Location = New System.Drawing.Point(386, 9)
        Me.lblLoginfrmheader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLoginfrmheader.Name = "lblLoginfrmheader"
        Me.lblLoginfrmheader.Size = New System.Drawing.Size(262, 60)
        Me.lblLoginfrmheader.TabIndex = 2
        Me.lblLoginfrmheader.Text = "Infosys Project Manager Application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 "
        Me.lblLoginfrmheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginfrmheader.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Create A Team               "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'lblLoginHeader
        '
        Me.lblLoginHeader.AutoSize = True
        Me.lblLoginHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginHeader.Location = New System.Drawing.Point(25, 35)
        Me.lblLoginHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLoginHeader.Name = "lblLoginHeader"
        Me.lblLoginHeader.Size = New System.Drawing.Size(155, 20)
        Me.lblLoginHeader.TabIndex = 4
        Me.lblLoginHeader.Text = "Company Login         "
        Me.lblLoginHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginHeader.UseWaitCursor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(12, 92)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 124)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'txtCompanyUser
        '
        Me.txtCompanyUser.Location = New System.Drawing.Point(73, 89)
        Me.txtCompanyUser.Name = "txtCompanyUser"
        Me.txtCompanyUser.Size = New System.Drawing.Size(100, 20)
        Me.txtCompanyUser.TabIndex = 7
        '
        'txtCompanyPass
        '
        Me.txtCompanyPass.Location = New System.Drawing.Point(73, 124)
        Me.txtCompanyPass.Name = "txtCompanyPass"
        Me.txtCompanyPass.Size = New System.Drawing.Size(100, 20)
        Me.txtCompanyPass.TabIndex = 8
        Me.txtCompanyPass.UseSystemPasswordChar = True
        '
        'btnCompanySignIn
        '
        Me.btnCompanySignIn.Location = New System.Drawing.Point(61, 162)
        Me.btnCompanySignIn.Name = "btnCompanySignIn"
        Me.btnCompanySignIn.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanySignIn.TabIndex = 9
        Me.btnCompanySignIn.Text = "Sign In"
        Me.btnCompanySignIn.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(29, 498)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(128, 51)
        Me.btnRestart.TabIndex = 10
        Me.btnRestart.Text = "Restart Team Creator"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(284, 184)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(135, 20)
        Me.txtTask.TabIndex = 11
        '
        'btnSelectTask
        '
        Me.btnSelectTask.Location = New System.Drawing.Point(468, 181)
        Me.btnSelectTask.Name = "btnSelectTask"
        Me.btnSelectTask.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectTask.TabIndex = 12
        Me.btnSelectTask.Text = "Select"
        Me.btnSelectTask.UseVisualStyleBackColor = True
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(599, 184)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(124, 20)
        Me.txtEmployee.TabIndex = 13
        '
        'btnSelectEmp
        '
        Me.btnSelectEmp.Location = New System.Drawing.Point(769, 184)
        Me.btnSelectEmp.Name = "btnSelectEmp"
        Me.btnSelectEmp.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectEmp.TabIndex = 14
        Me.btnSelectEmp.Text = "Select"
        Me.btnSelectEmp.UseVisualStyleBackColor = True
        '
        'lblTask
        '
        Me.lblTask.AutoSize = True
        Me.lblTask.Location = New System.Drawing.Point(281, 145)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(70, 13)
        Me.lblTask.TabIndex = 15
        Me.lblTask.Text = "Choose Task"
        '
        'lblEmployees
        '
        Me.lblEmployees.AutoSize = True
        Me.lblEmployees.Location = New System.Drawing.Point(596, 145)
        Me.lblEmployees.Name = "lblEmployees"
        Me.lblEmployees.Size = New System.Drawing.Size(157, 13)
        Me.lblEmployees.TabIndex = 16
        Me.lblEmployees.Text = "Choose Employees (Last Name)"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(284, 354)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(179, 219)
        Me.txtOutput.TabIndex = 17
        '
        'lblOutlook
        '
        Me.lblOutlook.AutoSize = True
        Me.lblOutlook.Location = New System.Drawing.Point(281, 323)
        Me.lblOutlook.Name = "lblOutlook"
        Me.lblOutlook.Size = New System.Drawing.Size(74, 13)
        Me.lblOutlook.TabIndex = 18
        Me.lblOutlook.Text = "Team Outlook"
        '
        'lblRequiredEmps
        '
        Me.lblRequiredEmps.AutoSize = True
        Me.lblRequiredEmps.Location = New System.Drawing.Point(791, 145)
        Me.lblRequiredEmps.Name = "lblRequiredEmps"
        Me.lblRequiredEmps.Size = New System.Drawing.Size(107, 13)
        Me.lblRequiredEmps.TabIndex = 19
        Me.lblRequiredEmps.Text = "Required Employees:"
        '
        'btnTeamGenerateReport
        '
        Me.btnTeamGenerateReport.Location = New System.Drawing.Point(696, 384)
        Me.btnTeamGenerateReport.Name = "btnTeamGenerateReport"
        Me.btnTeamGenerateReport.Size = New System.Drawing.Size(87, 58)
        Me.btnTeamGenerateReport.TabIndex = 20
        Me.btnTeamGenerateReport.Text = "Generate Team Report"
        Me.btnTeamGenerateReport.UseVisualStyleBackColor = True
        '
        'btnSaveReport
        '
        Me.btnSaveReport.Location = New System.Drawing.Point(696, 448)
        Me.btnSaveReport.Name = "btnSaveReport"
        Me.btnSaveReport.Size = New System.Drawing.Size(87, 57)
        Me.btnSaveReport.TabIndex = 21
        Me.btnSaveReport.Text = "Save Team Report"
        Me.btnSaveReport.UseVisualStyleBackColor = True
        '
        'dstProjectManager
        '
        Me.dstProjectManager.DataSetName = "NewDataSet"
        Me.dstProjectManager.Tables.AddRange(New System.Data.DataTable() {Me.tblEmployeeData})
        '
        'tblEmployeeData
        '
        Me.tblEmployeeData.Columns.AddRange(New System.Data.DataColumn() {Me.colFirstname, Me.colLastname, Me.colDepartment, Me.colSkillset})
        Me.tblEmployeeData.TableName = "Employee Data"
        '
        'colFirstname
        '
        Me.colFirstname.ColumnName = "Firstname"
        '
        'colLastname
        '
        Me.colLastname.ColumnName = "Lastname"
        '
        'colDepartment
        '
        Me.colDepartment.ColumnName = "Department"
        '
        'colSkillset
        '
        Me.colSkillset.ColumnName = "Skillset"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(15, 295)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(103, 41)
        Me.btnReturn.TabIndex = 22
        Me.btnReturn.Text = "Return to Menu"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(585, 246)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(259, 52)
        Me.lblNote.TabIndex = 24
        Me.lblNote.Text = "Note: If the desired employee has the same last name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as someone else in the data" &
    " base, please use " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "their Employee ID instead to specify which employee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you're " &
    "referring to upon selection."
        '
        'btnSelectID
        '
        Me.btnSelectID.Location = New System.Drawing.Point(872, 244)
        Me.btnSelectID.Name = "btnSelectID"
        Me.btnSelectID.Size = New System.Drawing.Size(70, 54)
        Me.btnSelectID.TabIndex = 25
        Me.btnSelectID.Text = "Select ID"
        Me.btnSelectID.UseVisualStyleBackColor = True
        '
        'lblPlease
        '
        Me.lblPlease.AutoSize = True
        Me.lblPlease.Location = New System.Drawing.Point(2, 240)
        Me.lblPlease.Name = "lblPlease"
        Me.lblPlease.Size = New System.Drawing.Size(204, 26)
        Me.lblPlease.TabIndex = 26
        Me.lblPlease.Text = "Please Enter your Company Login Details " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Before Using the Team Creator"
        '
        'btnSaveAvail
        '
        Me.btnSaveAvail.Location = New System.Drawing.Point(803, 448)
        Me.btnSaveAvail.Name = "btnSaveAvail"
        Me.btnSaveAvail.Size = New System.Drawing.Size(95, 57)
        Me.btnSaveAvail.TabIndex = 27
        Me.btnSaveAvail.Text = "Save New Availability List With Changes"
        Me.btnSaveAvail.UseVisualStyleBackColor = True
        '
        'btnAvailabillityReport
        '
        Me.btnAvailabillityReport.Location = New System.Drawing.Point(803, 384)
        Me.btnAvailabillityReport.Name = "btnAvailabillityReport"
        Me.btnAvailabillityReport.Size = New System.Drawing.Size(95, 58)
        Me.btnAvailabillityReport.TabIndex = 28
        Me.btnAvailabillityReport.Text = "Generate Availability Report"
        Me.btnAvailabillityReport.UseVisualStyleBackColor = True
        '
        'lblInstruct1
        '
        Me.lblInstruct1.AutoSize = True
        Me.lblInstruct1.Location = New System.Drawing.Point(267, 89)
        Me.lblInstruct1.Name = "lblInstruct1"
        Me.lblInstruct1.Size = New System.Drawing.Size(330, 13)
        Me.lblInstruct1.TabIndex = 29
        Me.lblInstruct1.Text = "To begin, please select the task you would like your team to work on"
        '
        'lblInstruct2
        '
        Me.lblInstruct2.AutoSize = True
        Me.lblInstruct2.Location = New System.Drawing.Point(267, 70)
        Me.lblInstruct2.Name = "lblInstruct2"
        Me.lblInstruct2.Size = New System.Drawing.Size(304, 39)
        Me.lblInstruct2.TabIndex = 30
        Me.lblInstruct2.Text = "Select the employees you would like to be on your team" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remember to choose the co" &
    "rrect amount of employees that the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "task needs."
        '
        'btnFinaliseTeam
        '
        Me.btnFinaliseTeam.Location = New System.Drawing.Point(526, 418)
        Me.btnFinaliseTeam.Name = "btnFinaliseTeam"
        Me.btnFinaliseTeam.Size = New System.Drawing.Size(90, 58)
        Me.btnFinaliseTeam.TabIndex = 31
        Me.btnFinaliseTeam.Text = "Finalise Team"
        Me.btnFinaliseTeam.UseVisualStyleBackColor = True
        '
        'btnNewTaskList
        '
        Me.btnNewTaskList.Location = New System.Drawing.Point(751, 511)
        Me.btnNewTaskList.Name = "btnNewTaskList"
        Me.btnNewTaskList.Size = New System.Drawing.Size(82, 62)
        Me.btnNewTaskList.TabIndex = 32
        Me.btnNewTaskList.Text = "Save New Task List"
        Me.btnNewTaskList.UseVisualStyleBackColor = True
        '
        'frmCreateATeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(982, 585)
        Me.Controls.Add(Me.btnNewTaskList)
        Me.Controls.Add(Me.btnFinaliseTeam)
        Me.Controls.Add(Me.lblInstruct2)
        Me.Controls.Add(Me.lblInstruct1)
        Me.Controls.Add(Me.btnAvailabillityReport)
        Me.Controls.Add(Me.btnSaveAvail)
        Me.Controls.Add(Me.lblPlease)
        Me.Controls.Add(Me.btnSelectID)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSaveReport)
        Me.Controls.Add(Me.btnTeamGenerateReport)
        Me.Controls.Add(Me.lblRequiredEmps)
        Me.Controls.Add(Me.lblOutlook)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblEmployees)
        Me.Controls.Add(Me.lblTask)
        Me.Controls.Add(Me.btnSelectEmp)
        Me.Controls.Add(Me.txtEmployee)
        Me.Controls.Add(Me.btnSelectTask)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnCompanySignIn)
        Me.Controls.Add(Me.txtCompanyPass)
        Me.Controls.Add(Me.txtCompanyUser)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblLoginHeader)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLoginfrmheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCreateATeam"
        Me.Text = "frmCreateATeam"
        CType(Me.dstProjectManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEmployeeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoginfrmheader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLoginHeader As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtCompanyUser As TextBox
    Friend WithEvents txtCompanyPass As TextBox
    Friend WithEvents btnCompanySignIn As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents txtTask As TextBox
    Friend WithEvents btnSelectTask As Button
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents btnSelectEmp As Button
    Friend WithEvents lblTask As Label
    Friend WithEvents lblEmployees As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblOutlook As Label
    Friend WithEvents lblRequiredEmps As Label
    Friend WithEvents btnTeamGenerateReport As Button
    Friend WithEvents btnSaveReport As Button
    Friend WithEvents dstProjectManager As DataSet
    Friend WithEvents tblEmployeeData As DataTable
    Friend WithEvents colFirstname As DataColumn
    Friend WithEvents colLastname As DataColumn
    Friend WithEvents colDepartment As DataColumn
    Friend WithEvents colSkillset As DataColumn
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblNote As Label
    Friend WithEvents btnSelectID As Button
    Friend WithEvents lblPlease As Label
    Friend WithEvents sfdCompanyReport As SaveFileDialog
    Friend WithEvents btnSaveAvail As Button
    Friend WithEvents sfdAvailabillityChanges As SaveFileDialog
    Friend WithEvents btnAvailabillityReport As Button
    Friend WithEvents lblInstruct1 As Label
    Friend WithEvents lblInstruct2 As Label
    Friend WithEvents btnFinaliseTeam As Button
    Friend WithEvents btnNewTaskList As Button
    Friend WithEvents sfdTaskListChanges As SaveFileDialog
End Class
