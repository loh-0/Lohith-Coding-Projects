<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAppLogin
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
        Me.lblEnterAppLoginDetails = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAppUsername = New System.Windows.Forms.TextBox()
        Me.txtAppPassword = New System.Windows.Forms.TextBox()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLoginfrmheader
        '
        Me.lblLoginfrmheader.AutoSize = True
        Me.lblLoginfrmheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginfrmheader.Location = New System.Drawing.Point(122, 36)
        Me.lblLoginfrmheader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLoginfrmheader.Name = "lblLoginfrmheader"
        Me.lblLoginfrmheader.Size = New System.Drawing.Size(262, 20)
        Me.lblLoginfrmheader.TabIndex = 0
        Me.lblLoginfrmheader.Text = "Infosys Project Manager Application"
        Me.lblLoginfrmheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginfrmheader.UseWaitCursor = True
        '
        'lblEnterAppLoginDetails
        '
        Me.lblEnterAppLoginDetails.AutoSize = True
        Me.lblEnterAppLoginDetails.Location = New System.Drawing.Point(51, 123)
        Me.lblEnterAppLoginDetails.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnterAppLoginDetails.Name = "lblEnterAppLoginDetails"
        Me.lblEnterAppLoginDetails.Size = New System.Drawing.Size(151, 13)
        Me.lblEnterAppLoginDetails.TabIndex = 1
        Me.lblEnterAppLoginDetails.Text = "Enter Application Login Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 222)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'txtAppUsername
        '
        Me.txtAppUsername.Location = New System.Drawing.Point(148, 178)
        Me.txtAppUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAppUsername.Name = "txtAppUsername"
        Me.txtAppUsername.Size = New System.Drawing.Size(147, 20)
        Me.txtAppUsername.TabIndex = 4
        '
        'txtAppPassword
        '
        Me.txtAppPassword.Location = New System.Drawing.Point(148, 218)
        Me.txtAppPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAppPassword.Name = "txtAppPassword"
        Me.txtAppPassword.Size = New System.Drawing.Size(147, 20)
        Me.txtAppPassword.TabIndex = 5
        Me.txtAppPassword.UseSystemPasswordChar = True
        '
        'btnSignin
        '
        Me.btnSignin.Location = New System.Drawing.Point(189, 256)
        Me.btnSignin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(61, 23)
        Me.btnSignin.TabIndex = 6
        Me.btnSignin.Text = "Sign In"
        Me.btnSignin.UseVisualStyleBackColor = True
        '
        'frmAppLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(507, 330)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.txtAppPassword)
        Me.Controls.Add(Me.txtAppUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEnterAppLoginDetails)
        Me.Controls.Add(Me.lblLoginfrmheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmAppLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoginfrmheader As Label
    Friend WithEvents lblEnterAppLoginDetails As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAppUsername As TextBox
    Friend WithEvents txtAppPassword As TextBox
    Friend WithEvents btnSignin As Button
End Class
