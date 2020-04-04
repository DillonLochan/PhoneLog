<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.empComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.password_confirm_txt = New System.Windows.Forms.TextBox()
        Me.msg_lb = New System.Windows.Forms.Label()
        Me.menu_btn = New System.Windows.Forms.Button()
        Me.edit_user_btn = New System.Windows.Forms.Button()
        Me.userChk = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Select an Employee"
        '
        'empComboBox
        '
        Me.empComboBox.FormattingEnabled = True
        Me.empComboBox.Location = New System.Drawing.Point(167, 95)
        Me.empComboBox.Name = "empComboBox"
        Me.empComboBox.Size = New System.Drawing.Size(205, 21)
        Me.empComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add User"
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(140, 289)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 3
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Confirm Password:"
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(158, 140)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(200, 20)
        Me.username_txt.TabIndex = 7
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(158, 179)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(200, 20)
        Me.password_txt.TabIndex = 8
        '
        'password_confirm_txt
        '
        Me.password_confirm_txt.Location = New System.Drawing.Point(158, 220)
        Me.password_confirm_txt.Name = "password_confirm_txt"
        Me.password_confirm_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_confirm_txt.Size = New System.Drawing.Size(200, 20)
        Me.password_confirm_txt.TabIndex = 9
        '
        'msg_lb
        '
        Me.msg_lb.AutoSize = True
        Me.msg_lb.Location = New System.Drawing.Point(155, 243)
        Me.msg_lb.Name = "msg_lb"
        Me.msg_lb.Size = New System.Drawing.Size(39, 13)
        Me.msg_lb.TabIndex = 10
        Me.msg_lb.Text = "Label6"
        '
        'menu_btn
        '
        Me.menu_btn.Location = New System.Drawing.Point(12, 9)
        Me.menu_btn.Name = "menu_btn"
        Me.menu_btn.Size = New System.Drawing.Size(75, 23)
        Me.menu_btn.TabIndex = 11
        Me.menu_btn.Text = "Menu"
        Me.menu_btn.UseVisualStyleBackColor = True
        '
        'edit_user_btn
        '
        Me.edit_user_btn.Location = New System.Drawing.Point(297, 9)
        Me.edit_user_btn.Name = "edit_user_btn"
        Me.edit_user_btn.Size = New System.Drawing.Size(75, 23)
        Me.edit_user_btn.TabIndex = 12
        Me.edit_user_btn.Text = "Edit Users"
        Me.edit_user_btn.UseVisualStyleBackColor = True
        '
        'userChk
        '
        Me.userChk.AutoSize = True
        Me.userChk.Location = New System.Drawing.Point(155, 163)
        Me.userChk.Name = "userChk"
        Me.userChk.Size = New System.Drawing.Size(39, 13)
        Me.userChk.TabIndex = 13
        Me.userChk.Text = "Label6"
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.userChk)
        Me.Controls.Add(Me.edit_user_btn)
        Me.Controls.Add(Me.menu_btn)
        Me.Controls.Add(Me.msg_lb)
        Me.Controls.Add(Me.password_confirm_txt)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.empComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents empComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents username_txt As TextBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents password_confirm_txt As TextBox
    Friend WithEvents msg_lb As Label
    Friend WithEvents menu_btn As Button
    Friend WithEvents edit_user_btn As Button
    Friend WithEvents userChk As Label
End Class
