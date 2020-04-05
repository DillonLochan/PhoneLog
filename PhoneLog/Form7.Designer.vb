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
        Me.add_user_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Select an Employee"
        '
        'empComboBox
        '
        Me.empComboBox.FormattingEnabled = True
        Me.empComboBox.Location = New System.Drawing.Point(445, 227)
        Me.empComboBox.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.empComboBox.Name = "empComboBox"
        Me.empComboBox.Size = New System.Drawing.Size(540, 39)
        Me.empComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(437, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add User"
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(373, 689)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(200, 55)
        Me.save_btn.TabIndex = 3
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 341)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 444)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 541)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Confirm Password:"
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(421, 334)
        Me.username_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(527, 38)
        Me.username_txt.TabIndex = 7
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(421, 427)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(527, 38)
        Me.password_txt.TabIndex = 8
        '
        'password_confirm_txt
        '
        Me.password_confirm_txt.Location = New System.Drawing.Point(421, 525)
        Me.password_confirm_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.password_confirm_txt.Name = "password_confirm_txt"
        Me.password_confirm_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_confirm_txt.Size = New System.Drawing.Size(527, 38)
        Me.password_confirm_txt.TabIndex = 9
        '
        'msg_lb
        '
        Me.msg_lb.AutoSize = True
        Me.msg_lb.Location = New System.Drawing.Point(413, 579)
        Me.msg_lb.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.msg_lb.Name = "msg_lb"
        Me.msg_lb.Size = New System.Drawing.Size(102, 32)
        Me.msg_lb.TabIndex = 10
        Me.msg_lb.Text = "Label6"
        '
        'menu_btn
        '
        Me.menu_btn.Location = New System.Drawing.Point(32, 21)
        Me.menu_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.menu_btn.Name = "menu_btn"
        Me.menu_btn.Size = New System.Drawing.Size(200, 55)
        Me.menu_btn.TabIndex = 11
        Me.menu_btn.Text = "Menu"
        Me.menu_btn.UseVisualStyleBackColor = True
        '
        'edit_user_btn
        '
        Me.edit_user_btn.Location = New System.Drawing.Point(792, 21)
        Me.edit_user_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.edit_user_btn.Name = "edit_user_btn"
        Me.edit_user_btn.Size = New System.Drawing.Size(200, 55)
        Me.edit_user_btn.TabIndex = 12
        Me.edit_user_btn.Text = "Edit Users"
        Me.edit_user_btn.UseVisualStyleBackColor = True
        '
        'userChk
        '
        Me.userChk.AutoSize = True
        Me.userChk.Location = New System.Drawing.Point(413, 389)
        Me.userChk.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.userChk.Name = "userChk"
        Me.userChk.Size = New System.Drawing.Size(102, 32)
        Me.userChk.TabIndex = 13
        Me.userChk.Text = "Label6"
        '
        'add_user_btn
        '
        Me.add_user_btn.Location = New System.Drawing.Point(409, 21)
        Me.add_user_btn.Name = "add_user_btn"
        Me.add_user_btn.Size = New System.Drawing.Size(215, 55)
        Me.add_user_btn.TabIndex = 14
        Me.add_user_btn.Text = "Add User"
        Me.add_user_btn.UseVisualStyleBackColor = True
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 861)
        Me.Controls.Add(Me.add_user_btn)
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
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
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
    Friend WithEvents add_user_btn As Button
End Class
