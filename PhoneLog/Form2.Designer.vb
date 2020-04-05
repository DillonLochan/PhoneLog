<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeMaintenance
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
        Me.save_employee_btn = New System.Windows.Forms.Button()
        Me.menu_btn = New System.Windows.Forms.Button()
        Me.empComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.create_new_emp_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.emp_name_txt = New System.Windows.Forms.TextBox()
        Me.ext_txt = New System.Windows.Forms.TextBox()
        Me.id_lb = New System.Windows.Forms.Label()
        Me.delete_employee_btn = New System.Windows.Forms.Button()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'save_employee_btn
        '
        Me.save_employee_btn.Location = New System.Drawing.Point(373, 563)
        Me.save_employee_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.save_employee_btn.Name = "save_employee_btn"
        Me.save_employee_btn.Size = New System.Drawing.Size(291, 55)
        Me.save_employee_btn.TabIndex = 12
        Me.save_employee_btn.Text = "Save Employee"
        Me.save_employee_btn.UseVisualStyleBackColor = True
        '
        'menu_btn
        '
        Me.menu_btn.Location = New System.Drawing.Point(32, 29)
        Me.menu_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.menu_btn.Name = "menu_btn"
        Me.menu_btn.Size = New System.Drawing.Size(200, 55)
        Me.menu_btn.TabIndex = 0
        Me.menu_btn.Text = "Menu"
        Me.menu_btn.UseVisualStyleBackColor = True
        '
        'empComboBox
        '
        Me.empComboBox.DisplayMember = "0"
        Me.empComboBox.FormattingEnabled = True
        Me.empComboBox.Items.AddRange(New Object() {"Please Select"})
        Me.empComboBox.Location = New System.Drawing.Point(400, 138)
        Me.empComboBox.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.empComboBox.Name = "empComboBox"
        Me.empComboBox.Size = New System.Drawing.Size(585, 39)
        Me.empComboBox.TabIndex = 1
        Me.empComboBox.Text = "Please Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Select an employee"
        '
        'create_new_emp_btn
        '
        Me.create_new_emp_btn.Location = New System.Drawing.Point(659, 29)
        Me.create_new_emp_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.create_new_emp_btn.Name = "create_new_emp_btn"
        Me.create_new_emp_btn.Size = New System.Drawing.Size(333, 55)
        Me.create_new_emp_btn.TabIndex = 3
        Me.create_new_emp_btn.Text = "Create New Employee"
        Me.create_new_emp_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 365)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Employee Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 460)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Extension:"
        '
        'emp_name_txt
        '
        Me.emp_name_txt.Location = New System.Drawing.Point(309, 358)
        Me.emp_name_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.emp_name_txt.Name = "emp_name_txt"
        Me.emp_name_txt.Size = New System.Drawing.Size(553, 38)
        Me.emp_name_txt.TabIndex = 7
        '
        'ext_txt
        '
        Me.ext_txt.Location = New System.Drawing.Point(309, 453)
        Me.ext_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ext_txt.Name = "ext_txt"
        Me.ext_txt.Size = New System.Drawing.Size(553, 38)
        Me.ext_txt.TabIndex = 8
        '
        'id_lb
        '
        Me.id_lb.AutoSize = True
        Me.id_lb.Location = New System.Drawing.Point(301, 260)
        Me.id_lb.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.id_lb.Name = "id_lb"
        Me.id_lb.Size = New System.Drawing.Size(0, 32)
        Me.id_lb.TabIndex = 9
        '
        'delete_employee_btn
        '
        Me.delete_employee_btn.Location = New System.Drawing.Point(373, 649)
        Me.delete_employee_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.delete_employee_btn.Name = "delete_employee_btn"
        Me.delete_employee_btn.Size = New System.Drawing.Size(291, 55)
        Me.delete_employee_btn.TabIndex = 11
        Me.delete_employee_btn.Text = "Delete Employee"
        Me.delete_employee_btn.UseVisualStyleBackColor = True
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(347, 29)
        Me.search_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(200, 55)
        Me.search_btn.TabIndex = 13
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'EmployeeMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 861)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.save_employee_btn)
        Me.Controls.Add(Me.delete_employee_btn)
        Me.Controls.Add(Me.id_lb)
        Me.Controls.Add(Me.ext_txt)
        Me.Controls.Add(Me.emp_name_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.create_new_emp_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.empComboBox)
        Me.Controls.Add(Me.menu_btn)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "EmployeeMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_btn As Button
    Friend WithEvents empComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents create_new_emp_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents emp_name_txt As TextBox
    Friend WithEvents ext_txt As TextBox
    Friend WithEvents id_lb As Label
    Friend WithEvents delete_employee_btn As Button
    Friend WithEvents save_employee_btn As Button
    Friend WithEvents search_btn As Button
End Class
