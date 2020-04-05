<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForeignCompany
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
        Me.menu_btn = New System.Windows.Forms.Button()
        Me.create_new_fc_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fcComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id_lb = New System.Windows.Forms.Label()
        Me.company_name_txt = New System.Windows.Forms.TextBox()
        Me.phone_number_txt = New System.Windows.Forms.TextBox()
        Me.city_txt = New System.Windows.Forms.TextBox()
        Me.country_txt = New System.Windows.Forms.TextBox()
        Me.empComboBox = New System.Windows.Forms.ComboBox()
        Me.save_fc_btn = New System.Windows.Forms.Button()
        Me.delete_fc_btn = New System.Windows.Forms.Button()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        'create_new_fc_btn
        '
        Me.create_new_fc_btn.Location = New System.Drawing.Point(661, 29)
        Me.create_new_fc_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.create_new_fc_btn.Name = "create_new_fc_btn"
        Me.create_new_fc_btn.Size = New System.Drawing.Size(331, 55)
        Me.create_new_fc_btn.TabIndex = 1
        Me.create_new_fc_btn.Text = "Create New Company"
        Me.create_new_fc_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Plase Select a Company"
        '
        'fcComboBox
        '
        Me.fcComboBox.FormattingEnabled = True
        Me.fcComboBox.Location = New System.Drawing.Point(373, 148)
        Me.fcComboBox.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.fcComboBox.Name = "fcComboBox"
        Me.fcComboBox.Size = New System.Drawing.Size(612, 39)
        Me.fcComboBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Caompany ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 351)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Company Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 448)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 537)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 632)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 32)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Country:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 727)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 32)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Employee:"
        '
        'id_lb
        '
        Me.id_lb.AutoSize = True
        Me.id_lb.Location = New System.Drawing.Point(328, 260)
        Me.id_lb.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.id_lb.Name = "id_lb"
        Me.id_lb.Size = New System.Drawing.Size(0, 32)
        Me.id_lb.TabIndex = 10
        '
        'company_name_txt
        '
        Me.company_name_txt.Location = New System.Drawing.Point(336, 343)
        Me.company_name_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.company_name_txt.Name = "company_name_txt"
        Me.company_name_txt.Size = New System.Drawing.Size(559, 38)
        Me.company_name_txt.TabIndex = 11
        '
        'phone_number_txt
        '
        Me.phone_number_txt.Location = New System.Drawing.Point(336, 432)
        Me.phone_number_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.phone_number_txt.Name = "phone_number_txt"
        Me.phone_number_txt.Size = New System.Drawing.Size(559, 38)
        Me.phone_number_txt.TabIndex = 12
        '
        'city_txt
        '
        Me.city_txt.Location = New System.Drawing.Point(336, 520)
        Me.city_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(559, 38)
        Me.city_txt.TabIndex = 13
        '
        'country_txt
        '
        Me.country_txt.Location = New System.Drawing.Point(336, 615)
        Me.country_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.country_txt.Name = "country_txt"
        Me.country_txt.Size = New System.Drawing.Size(559, 38)
        Me.country_txt.TabIndex = 14
        '
        'empComboBox
        '
        Me.empComboBox.FormattingEnabled = True
        Me.empComboBox.Location = New System.Drawing.Point(336, 708)
        Me.empComboBox.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.empComboBox.Name = "empComboBox"
        Me.empComboBox.Size = New System.Drawing.Size(559, 39)
        Me.empComboBox.TabIndex = 15
        '
        'save_fc_btn
        '
        Me.save_fc_btn.Location = New System.Drawing.Point(277, 777)
        Me.save_fc_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.save_fc_btn.Name = "save_fc_btn"
        Me.save_fc_btn.Size = New System.Drawing.Size(200, 55)
        Me.save_fc_btn.TabIndex = 16
        Me.save_fc_btn.Text = "Save "
        Me.save_fc_btn.UseVisualStyleBackColor = True
        '
        'delete_fc_btn
        '
        Me.delete_fc_btn.Location = New System.Drawing.Point(493, 777)
        Me.delete_fc_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.delete_fc_btn.Name = "delete_fc_btn"
        Me.delete_fc_btn.Size = New System.Drawing.Size(200, 55)
        Me.delete_fc_btn.TabIndex = 17
        Me.delete_fc_btn.Text = "Delete"
        Me.delete_fc_btn.UseVisualStyleBackColor = True
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(373, 29)
        Me.search_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(200, 55)
        Me.search_btn.TabIndex = 18
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'ForeignCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 861)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.delete_fc_btn)
        Me.Controls.Add(Me.save_fc_btn)
        Me.Controls.Add(Me.empComboBox)
        Me.Controls.Add(Me.country_txt)
        Me.Controls.Add(Me.city_txt)
        Me.Controls.Add(Me.phone_number_txt)
        Me.Controls.Add(Me.company_name_txt)
        Me.Controls.Add(Me.id_lb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fcComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.create_new_fc_btn)
        Me.Controls.Add(Me.menu_btn)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "ForeignCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foreign Company Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_btn As Button
    Friend WithEvents create_new_fc_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents fcComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents id_lb As Label
    Friend WithEvents company_name_txt As TextBox
    Friend WithEvents phone_number_txt As TextBox
    Friend WithEvents city_txt As TextBox
    Friend WithEvents country_txt As TextBox
    Friend WithEvents empComboBox As ComboBox
    Friend WithEvents save_fc_btn As Button
    Friend WithEvents delete_fc_btn As Button
    Friend WithEvents search_btn As Button
End Class
