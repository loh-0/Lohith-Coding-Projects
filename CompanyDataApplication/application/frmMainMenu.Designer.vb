<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.lblPleaseSelectFiles = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelectEmpData = New System.Windows.Forms.Button()
        Me.btnSelectTaskData = New System.Windows.Forms.Button()
        Me.btnSelectAvailabillityData = New System.Windows.Forms.Button()
        Me.btnfrmSearch = New System.Windows.Forms.Button()
        Me.btnFrmLists = New System.Windows.Forms.Button()
        Me.btnCreateTeam = New System.Windows.Forms.Button()
        Me.ofdSelectFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReselectData = New System.Windows.Forms.Button()
        Me.dstProjectManager = New System.Data.DataSet()
        Me.tblEmployeeData = New System.Data.DataTable()
        Me.colFirstname = New System.Data.DataColumn()
        Me.colLastname = New System.Data.DataColumn()
        Me.colDepartment = New System.Data.DataColumn()
        Me.colSkillset = New System.Data.DataColumn()
        Me.colID = New System.Data.DataColumn()
        Me.tblTaskList = New System.Data.DataTable()
        Me.colTaskName = New System.Data.DataColumn()
        Me.colCompany = New System.Data.DataColumn()
        Me.colStaff = New System.Data.DataColumn()
        Me.colWeeks = New System.Data.DataColumn()
        Me.tblAvailabillity = New System.Data.DataTable()
        Me.colFName = New System.Data.DataColumn()
        Me.colLName = New System.Data.DataColumn()
        Me.colStatus = New System.Data.DataColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbxIcon = New System.Windows.Forms.PictureBox()
        Me.colDate = New System.Data.DataColumn()
        CType(Me.dstProjectManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEmployeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblAvailabillity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPleaseSelectFiles
        '
        Me.lblPleaseSelectFiles.AutoSize = True
        Me.lblPleaseSelectFiles.Location = New System.Drawing.Point(22, 37)
        Me.lblPleaseSelectFiles.Name = "lblPleaseSelectFiles"
        Me.lblPleaseSelectFiles.Size = New System.Drawing.Size(99, 26)
        Me.lblPleaseSelectFiles.TabIndex = 0
        Me.lblPleaseSelectFiles.Text = "Please Select Files " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Application Use"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Infosys Project Manager Application " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Main Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSelectEmpData
        '
        Me.btnSelectEmpData.Location = New System.Drawing.Point(12, 98)
        Me.btnSelectEmpData.Name = "btnSelectEmpData"
        Me.btnSelectEmpData.Size = New System.Drawing.Size(122, 45)
        Me.btnSelectEmpData.TabIndex = 2
        Me.btnSelectEmpData.Text = "Select Employee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data"
        Me.btnSelectEmpData.UseVisualStyleBackColor = True
        '
        'btnSelectTaskData
        '
        Me.btnSelectTaskData.Location = New System.Drawing.Point(12, 167)
        Me.btnSelectTaskData.Name = "btnSelectTaskData"
        Me.btnSelectTaskData.Size = New System.Drawing.Size(122, 45)
        Me.btnSelectTaskData.TabIndex = 3
        Me.btnSelectTaskData.Text = "Select Task " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSelectTaskData.UseVisualStyleBackColor = True
        '
        'btnSelectAvailabillityData
        '
        Me.btnSelectAvailabillityData.Location = New System.Drawing.Point(12, 244)
        Me.btnSelectAvailabillityData.Name = "btnSelectAvailabillityData"
        Me.btnSelectAvailabillityData.Size = New System.Drawing.Size(122, 45)
        Me.btnSelectAvailabillityData.TabIndex = 4
        Me.btnSelectAvailabillityData.Text = "Select Availabillity " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSelectAvailabillityData.UseVisualStyleBackColor = True
        '
        'btnfrmSearch
        '
        Me.btnfrmSearch.Location = New System.Drawing.Point(25, 94)
        Me.btnfrmSearch.Name = "btnfrmSearch"
        Me.btnfrmSearch.Size = New System.Drawing.Size(79, 53)
        Me.btnfrmSearch.TabIndex = 5
        Me.btnfrmSearch.Text = "Employee Search"
        Me.btnfrmSearch.UseVisualStyleBackColor = True
        '
        'btnFrmLists
        '
        Me.btnFrmLists.Location = New System.Drawing.Point(25, 167)
        Me.btnFrmLists.Name = "btnFrmLists"
        Me.btnFrmLists.Size = New System.Drawing.Size(79, 53)
        Me.btnFrmLists.TabIndex = 6
        Me.btnFrmLists.Text = "Company Information Lists"
        Me.btnFrmLists.UseVisualStyleBackColor = True
        '
        'btnCreateTeam
        '
        Me.btnCreateTeam.Location = New System.Drawing.Point(25, 240)
        Me.btnCreateTeam.Name = "btnCreateTeam"
        Me.btnCreateTeam.Size = New System.Drawing.Size(79, 53)
        Me.btnCreateTeam.TabIndex = 7
        Me.btnCreateTeam.Text = "Create a Team" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCreateTeam.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 78)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnReselectData
        '
        Me.btnReselectData.Location = New System.Drawing.Point(563, 320)
        Me.btnReselectData.Name = "btnReselectData"
        Me.btnReselectData.Size = New System.Drawing.Size(63, 43)
        Me.btnReselectData.TabIndex = 9
        Me.btnReselectData.Text = "Reselect Data"
        Me.btnReselectData.UseVisualStyleBackColor = True
        '
        'dstProjectManager
        '
        Me.dstProjectManager.DataSetName = "NewDataSet"
        Me.dstProjectManager.Tables.AddRange(New System.Data.DataTable() {Me.tblEmployeeData, Me.tblTaskList, Me.tblAvailabillity})
        '
        'tblEmployeeData
        '
        Me.tblEmployeeData.Columns.AddRange(New System.Data.DataColumn() {Me.colFirstname, Me.colLastname, Me.colDepartment, Me.colSkillset, Me.colID})
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
        'colID
        '
        Me.colID.ColumnName = "Employee ID"
        '
        'tblTaskList
        '
        Me.tblTaskList.Columns.AddRange(New System.Data.DataColumn() {Me.colTaskName, Me.colCompany, Me.colStaff, Me.colWeeks})
        Me.tblTaskList.TableName = "Task List"
        '
        'colTaskName
        '
        Me.colTaskName.ColumnName = "Task Name"
        '
        'colCompany
        '
        Me.colCompany.ColumnName = "Company"
        '
        'colStaff
        '
        Me.colStaff.ColumnName = "Staff Needed"
        Me.colStaff.DataType = GetType(Integer)
        '
        'colWeeks
        '
        Me.colWeeks.ColumnName = "Weeks"
        Me.colWeeks.DataType = GetType(Integer)
        '
        'tblAvailabillity
        '
        Me.tblAvailabillity.Columns.AddRange(New System.Data.DataColumn() {Me.colFName, Me.colLName, Me.colStatus, Me.colDate})
        Me.tblAvailabillity.TableName = "Availabillity List"
        '
        'colFName
        '
        Me.colFName.ColumnName = "First Name"
        '
        'colLName
        '
        Me.colLName.ColumnName = "Last Name"
        '
        'colStatus
        '
        Me.colStatus.ColumnName = "Available "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.database_app.My.Resources.Resources.Infosys__4911287704_
        Me.PictureBox1.Location = New System.Drawing.Point(164, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'pbxIcon
        '
        Me.pbxIcon.Image = Global.database_app.My.Resources.Resources.infosys_logo_PNG
        Me.pbxIcon.Location = New System.Drawing.Point(463, 12)
        Me.pbxIcon.Name = "pbxIcon"
        Me.pbxIcon.Size = New System.Drawing.Size(221, 115)
        Me.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxIcon.TabIndex = 10
        Me.pbxIcon.TabStop = False
        '
        'colDate
        '
        Me.colDate.ColumnName = "Return Date"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(717, 404)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbxIcon)
        Me.Controls.Add(Me.btnReselectData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateTeam)
        Me.Controls.Add(Me.btnFrmLists)
        Me.Controls.Add(Me.btnfrmSearch)
        Me.Controls.Add(Me.btnSelectAvailabillityData)
        Me.Controls.Add(Me.btnSelectTaskData)
        Me.Controls.Add(Me.btnSelectEmpData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPleaseSelectFiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmMainMenu"
        CType(Me.dstProjectManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEmployeeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblAvailabillity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPleaseSelectFiles As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelectEmpData As Button
    Friend WithEvents btnSelectTaskData As Button
    Friend WithEvents btnSelectAvailabillityData As Button
    Friend WithEvents btnfrmSearch As Button
    Friend WithEvents btnFrmLists As Button
    Friend WithEvents btnCreateTeam As Button
    Friend WithEvents ofdSelectFile As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReselectData As Button
    Friend WithEvents dstProjectManager As DataSet
    Friend WithEvents tblEmployeeData As DataTable
    Friend WithEvents colFirstname As DataColumn
    Friend WithEvents colLastname As DataColumn
    Friend WithEvents colDepartment As DataColumn
    Friend WithEvents colSkillset As DataColumn
    Friend WithEvents tblTaskList As DataTable
    Friend WithEvents colTaskName As DataColumn
    Friend WithEvents colCompany As DataColumn
    Friend WithEvents colStaff As DataColumn
    Friend WithEvents colWeeks As DataColumn
    Friend WithEvents colID As DataColumn
    Friend WithEvents tblAvailabillity As DataTable
    Friend WithEvents colFName As DataColumn
    Friend WithEvents colLName As DataColumn
    Friend WithEvents colStatus As DataColumn
    Friend WithEvents pbxIcon As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents colDate As DataColumn
End Class
