<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpSearch
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
        Me.lblLoginfrmheader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLastSearch = New System.Windows.Forms.Button()
        Me.lblSearchLast = New System.Windows.Forms.Label()
        Me.txtLastInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchLogs = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblSearchFirst = New System.Windows.Forms.Label()
        Me.txtFirstInput = New System.Windows.Forms.TextBox()
        Me.btnFirstSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLoginfrmheader
        '
        Me.lblLoginfrmheader.AutoSize = True
        Me.lblLoginfrmheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginfrmheader.Location = New System.Drawing.Point(249, 19)
        Me.lblLoginfrmheader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLoginfrmheader.Name = "lblLoginfrmheader"
        Me.lblLoginfrmheader.Size = New System.Drawing.Size(262, 60)
        Me.lblLoginfrmheader.TabIndex = 1
        Me.lblLoginfrmheader.Text = "Infosys Project Manager Application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 "
        Me.lblLoginfrmheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginfrmheader.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 60)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'btnLastSearch
        '
        Me.btnLastSearch.Location = New System.Drawing.Point(535, 172)
        Me.btnLastSearch.Name = "btnLastSearch"
        Me.btnLastSearch.Size = New System.Drawing.Size(76, 20)
        Me.btnLastSearch.TabIndex = 3
        Me.btnLastSearch.Text = "Search"
        Me.btnLastSearch.UseVisualStyleBackColor = True
        '
        'lblSearchLast
        '
        Me.lblSearchLast.AutoSize = True
        Me.lblSearchLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSearchLast.Location = New System.Drawing.Point(166, 164)
        Me.lblSearchLast.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchLast.Name = "lblSearchLast"
        Me.lblSearchLast.Size = New System.Drawing.Size(144, 17)
        Me.lblSearchLast.TabIndex = 4
        Me.lblSearchLast.Text = "Search by Last Name"
        Me.lblSearchLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSearchLast.UseWaitCursor = True
        '
        'txtLastInput
        '
        Me.txtLastInput.Location = New System.Drawing.Point(337, 164)
        Me.txtLastInput.Name = "txtLastInput"
        Me.txtLastInput.Size = New System.Drawing.Size(141, 20)
        Me.txtLastInput.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(232, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search Log"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.UseWaitCursor = True
        '
        'txtSearchLogs
        '
        Me.txtSearchLogs.Location = New System.Drawing.Point(235, 254)
        Me.txtSearchLogs.Multiline = True
        Me.txtSearchLogs.Name = "txtSearchLogs"
        Me.txtSearchLogs.ReadOnly = True
        Me.txtSearchLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSearchLogs.Size = New System.Drawing.Size(310, 213)
        Me.txtSearchLogs.TabIndex = 7
        Me.txtSearchLogs.Text = "First | Last | Department | Skillset | ID"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(35, 435)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(98, 32)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return to Menu"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(653, 438)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 27)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear Searches"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblSearchFirst
        '
        Me.lblSearchFirst.AutoSize = True
        Me.lblSearchFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSearchFirst.Location = New System.Drawing.Point(166, 122)
        Me.lblSearchFirst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchFirst.Name = "lblSearchFirst"
        Me.lblSearchFirst.Size = New System.Drawing.Size(144, 17)
        Me.lblSearchFirst.TabIndex = 10
        Me.lblSearchFirst.Text = "Search by First Name"
        Me.lblSearchFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSearchFirst.UseWaitCursor = True
        '
        'txtFirstInput
        '
        Me.txtFirstInput.Location = New System.Drawing.Point(337, 121)
        Me.txtFirstInput.Name = "txtFirstInput"
        Me.txtFirstInput.Size = New System.Drawing.Size(141, 20)
        Me.txtFirstInput.TabIndex = 11
        '
        'btnFirstSearch
        '
        Me.btnFirstSearch.Location = New System.Drawing.Point(535, 120)
        Me.btnFirstSearch.Name = "btnFirstSearch"
        Me.btnFirstSearch.Size = New System.Drawing.Size(76, 20)
        Me.btnFirstSearch.TabIndex = 12
        Me.btnFirstSearch.Text = "Search"
        Me.btnFirstSearch.UseVisualStyleBackColor = True
        '
        'frmEmpSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(812, 510)
        Me.Controls.Add(Me.btnFirstSearch)
        Me.Controls.Add(Me.txtFirstInput)
        Me.Controls.Add(Me.lblSearchFirst)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.txtSearchLogs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastInput)
        Me.Controls.Add(Me.lblSearchLast)
        Me.Controls.Add(Me.btnLastSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLoginfrmheader)
        Me.Name = "frmEmpSearch"
        Me.Text = "frmEmpSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoginfrmheader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLastSearch As Button
    Friend WithEvents lblSearchLast As Label
    Friend WithEvents txtLastInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearchLogs As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSearchFirst As Label
    Friend WithEvents txtFirstInput As TextBox
    Friend WithEvents btnFirstSearch As Button
End Class
