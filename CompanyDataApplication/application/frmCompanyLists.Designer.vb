<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyLists
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvEmployeeData = New System.Windows.Forms.DataGridView()
        Me.lblEmpData = New System.Windows.Forms.Label()
        Me.lblfrmheader = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblTaskList = New System.Windows.Forms.Label()
        Me.lblAvailabillity = New System.Windows.Forms.Label()
        Me.lblReturn = New System.Windows.Forms.Button()
        Me.dgvTaskList = New System.Windows.Forms.DataGridView()
        Me.dgvAvailabillity = New System.Windows.Forms.DataGridView()
        Me.lblInstructions = New System.Windows.Forms.Label()
        CType(Me.dgvEmployeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAvailabillity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployeeData
        '
        Me.dgvEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeData.Location = New System.Drawing.Point(12, 237)
        Me.dgvEmployeeData.Name = "dgvEmployeeData"
        Me.dgvEmployeeData.ReadOnly = True
        Me.dgvEmployeeData.Size = New System.Drawing.Size(517, 269)
        Me.dgvEmployeeData.TabIndex = 0
        '
        'lblEmpData
        '
        Me.lblEmpData.AutoSize = True
        Me.lblEmpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpData.Location = New System.Drawing.Point(216, 195)
        Me.lblEmpData.Name = "lblEmpData"
        Me.lblEmpData.Size = New System.Drawing.Size(138, 24)
        Me.lblEmpData.TabIndex = 2
        Me.lblEmpData.Text = "Employee Data"
        '
        'lblfrmheader
        '
        Me.lblfrmheader.AutoSize = True
        Me.lblfrmheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrmheader.Location = New System.Drawing.Point(595, 20)
        Me.lblfrmheader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfrmheader.Name = "lblfrmheader"
        Me.lblfrmheader.Size = New System.Drawing.Size(356, 75)
        Me.lblfrmheader.TabIndex = 3
        Me.lblfrmheader.Text = "Infosys Project Manager Application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 "
        Me.lblfrmheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblfrmheader.UseWaitCursor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(683, 70)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(202, 25)
        Me.lblHeader.TabIndex = 4
        Me.lblHeader.Text = "Company Lists        "
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblHeader.UseWaitCursor = True
        '
        'lblTaskList
        '
        Me.lblTaskList.AutoSize = True
        Me.lblTaskList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskList.Location = New System.Drawing.Point(734, 195)
        Me.lblTaskList.Name = "lblTaskList"
        Me.lblTaskList.Size = New System.Drawing.Size(82, 24)
        Me.lblTaskList.TabIndex = 5
        Me.lblTaskList.Text = "Task List"
        '
        'lblAvailabillity
        '
        Me.lblAvailabillity.AutoSize = True
        Me.lblAvailabillity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailabillity.Location = New System.Drawing.Point(1214, 195)
        Me.lblAvailabillity.Name = "lblAvailabillity"
        Me.lblAvailabillity.Size = New System.Drawing.Size(132, 24)
        Me.lblAvailabillity.TabIndex = 6
        Me.lblAvailabillity.Text = "Availabillity List"
        '
        'lblReturn
        '
        Me.lblReturn.Location = New System.Drawing.Point(54, 554)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(129, 44)
        Me.lblReturn.TabIndex = 7
        Me.lblReturn.Text = "Return to Menu"
        Me.lblReturn.UseVisualStyleBackColor = True
        '
        'dgvTaskList
        '
        Me.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskList.Location = New System.Drawing.Point(552, 237)
        Me.dgvTaskList.Name = "dgvTaskList"
        Me.dgvTaskList.ReadOnly = True
        Me.dgvTaskList.Size = New System.Drawing.Size(462, 269)
        Me.dgvTaskList.TabIndex = 8
        '
        'dgvAvailabillity
        '
        Me.dgvAvailabillity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailabillity.Location = New System.Drawing.Point(1061, 237)
        Me.dgvAvailabillity.Name = "dgvAvailabillity"
        Me.dgvAvailabillity.ReadOnly = True
        Me.dgvAvailabillity.Size = New System.Drawing.Size(454, 269)
        Me.dgvAvailabillity.TabIndex = 9
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(453, 120)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(636, 25)
        Me.lblInstructions.TabIndex = 10
        Me.lblInstructions.Text = "Click the Label at top of a Column to Sort the Grid by that Column"
        '
        'frmCompanyLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1527, 630)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.dgvAvailabillity)
        Me.Controls.Add(Me.dgvTaskList)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.lblAvailabillity)
        Me.Controls.Add(Me.lblTaskList)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblfrmheader)
        Me.Controls.Add(Me.lblEmpData)
        Me.Controls.Add(Me.dgvEmployeeData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCompanyLists"
        Me.Text = "frmCompanyLists"
        CType(Me.dgvEmployeeData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAvailabillity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEmployeeData As DataGridView
    Friend WithEvents lblEmpData As Label
    Friend WithEvents lblfrmheader As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblTaskList As Label
    Friend WithEvents lblAvailabillity As Label
    Friend WithEvents lblReturn As Button
    Friend WithEvents dgvTaskList As DataGridView
    Friend WithEvents dgvAvailabillity As DataGridView
    Friend WithEvents lblInstructions As Label
End Class
