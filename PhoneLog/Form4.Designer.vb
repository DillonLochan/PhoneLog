<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calls
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
        Me.create_new_call_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.phone_number_txt = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.fcComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.duration_txt = New System.Windows.Forms.TextBox()
        Me.empComboBox = New System.Windows.Forms.ComboBox()
        Me.delete_call_btn = New System.Windows.Forms.Button()
        Me.save_call_btn = New System.Windows.Forms.Button()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hrComboBox = New System.Windows.Forms.ComboBox()
        Me.minComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'menu_btn
        '
        Me.menu_btn.Location = New System.Drawing.Point(12, 12)
        Me.menu_btn.Name = "menu_btn"
        Me.menu_btn.Size = New System.Drawing.Size(75, 23)
        Me.menu_btn.TabIndex = 0
        Me.menu_btn.Text = "Menu"
        Me.menu_btn.UseVisualStyleBackColor = True
        '
        'create_new_call_btn
        '
        Me.create_new_call_btn.Location = New System.Drawing.Point(277, 12)
        Me.create_new_call_btn.Name = "create_new_call_btn"
        Me.create_new_call_btn.Size = New System.Drawing.Size(95, 23)
        Me.create_new_call_btn.TabIndex = 1
        Me.create_new_call_btn.Text = "Create New Call"
        Me.create_new_call_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Select a Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Foreign Company:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Duration:"
        '
        'phone_number_txt
        '
        Me.phone_number_txt.Location = New System.Drawing.Point(118, 108)
        Me.phone_number_txt.Name = "phone_number_txt"
        Me.phone_number_txt.Size = New System.Drawing.Size(254, 20)
        Me.phone_number_txt.TabIndex = 9
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(59, 195)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(184, 20)
        Me.DateTimePicker.TabIndex = 10
        '
        'fcComboBox
        '
        Me.fcComboBox.FormattingEnabled = True
        Me.fcComboBox.Location = New System.Drawing.Point(119, 150)
        Me.fcComboBox.Name = "fcComboBox"
        Me.fcComboBox.Size = New System.Drawing.Size(253, 21)
        Me.fcComboBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Employee:"
        '
        'duration_txt
        '
        Me.duration_txt.Location = New System.Drawing.Point(119, 229)
        Me.duration_txt.Name = "duration_txt"
        Me.duration_txt.Size = New System.Drawing.Size(253, 20)
        Me.duration_txt.TabIndex = 13
        '
        'empComboBox
        '
        Me.empComboBox.FormattingEnabled = True
        Me.empComboBox.Location = New System.Drawing.Point(118, 270)
        Me.empComboBox.Name = "empComboBox"
        Me.empComboBox.Size = New System.Drawing.Size(254, 21)
        Me.empComboBox.TabIndex = 14
        '
        'delete_call_btn
        '
        Me.delete_call_btn.Location = New System.Drawing.Point(188, 314)
        Me.delete_call_btn.Name = "delete_call_btn"
        Me.delete_call_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_call_btn.TabIndex = 15
        Me.delete_call_btn.Text = "Delete"
        Me.delete_call_btn.UseVisualStyleBackColor = True
        '
        'save_call_btn
        '
        Me.save_call_btn.Location = New System.Drawing.Point(107, 314)
        Me.save_call_btn.Name = "save_call_btn"
        Me.save_call_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_call_btn.TabIndex = 16
        Me.save_call_btn.Text = "Save"
        Me.save_call_btn.UseVisualStyleBackColor = True
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(143, 12)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(75, 23)
        Me.search_btn.TabIndex = 17
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Time:"
        '
        'hrComboBox
        '
        Me.hrComboBox.FormattingEnabled = True
        Me.hrComboBox.Location = New System.Drawing.Point(275, 195)
        Me.hrComboBox.Margin = New System.Windows.Forms.Padding(1)
        Me.hrComboBox.Name = "hrComboBox"
        Me.hrComboBox.Size = New System.Drawing.Size(43, 21)
        Me.hrComboBox.TabIndex = 19
        '
        'minComboBox
        '
        Me.minComboBox.FormattingEnabled = True
        Me.minComboBox.Location = New System.Drawing.Point(329, 195)
        Me.minComboBox.Margin = New System.Windows.Forms.Padding(1)
        Me.minComboBox.Name = "minComboBox"
        Me.minComboBox.Size = New System.Drawing.Size(42, 21)
        Me.minComboBox.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 196)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = ":"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(254, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Calls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 354)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.minComboBox)
        Me.Controls.Add(Me.hrComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.save_call_btn)
        Me.Controls.Add(Me.delete_call_btn)
        Me.Controls.Add(Me.empComboBox)
        Me.Controls.Add(Me.duration_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fcComboBox)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.phone_number_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.create_new_call_btn)
        Me.Controls.Add(Me.menu_btn)
        Me.Name = "Calls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Call Maintenace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_btn As Button
    Friend WithEvents create_new_call_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents phone_number_txt As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents fcComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents duration_txt As TextBox
    Friend WithEvents empComboBox As ComboBox
    Friend WithEvents delete_call_btn As Button
    Friend WithEvents save_call_btn As Button
    Friend WithEvents search_btn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents hrComboBox As ComboBox
    Friend WithEvents minComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
