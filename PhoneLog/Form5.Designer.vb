<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallSearch
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.fcComboBox = New System.Windows.Forms.ComboBox()
        Me.phone_number_txt = New System.Windows.Forms.TextBox()
        Me.CallDataTable = New System.Windows.Forms.DataGridView()
        Me.calls_btn = New System.Windows.Forms.Button()
        Me.menu_btn = New System.Windows.Forms.Button()
        Me.emp_name_txt = New System.Windows.Forms.TextBox()
        CType(Me.CallDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Foreign Company"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(446, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(180, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'fcComboBox
        '
        Me.fcComboBox.FormattingEnabled = True
        Me.fcComboBox.Location = New System.Drawing.Point(196, 29)
        Me.fcComboBox.Name = "fcComboBox"
        Me.fcComboBox.Size = New System.Drawing.Size(121, 21)
        Me.fcComboBox.TabIndex = 5
        '
        'phone_number_txt
        '
        Me.phone_number_txt.Location = New System.Drawing.Point(325, 29)
        Me.phone_number_txt.Name = "phone_number_txt"
        Me.phone_number_txt.Size = New System.Drawing.Size(118, 20)
        Me.phone_number_txt.TabIndex = 6
        '
        'CallDataTable
        '
        Me.CallDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CallDataTable.Location = New System.Drawing.Point(8, 61)
        Me.CallDataTable.Name = "CallDataTable"
        Me.CallDataTable.Size = New System.Drawing.Size(749, 338)
        Me.CallDataTable.TabIndex = 8
        '
        'calls_btn
        '
        Me.calls_btn.Location = New System.Drawing.Point(596, 26)
        Me.calls_btn.Name = "calls_btn"
        Me.calls_btn.Size = New System.Drawing.Size(75, 23)
        Me.calls_btn.TabIndex = 9
        Me.calls_btn.Text = "Calls"
        Me.calls_btn.UseVisualStyleBackColor = True
        '
        'menu_btn
        '
        Me.menu_btn.Location = New System.Drawing.Point(689, 26)
        Me.menu_btn.Name = "menu_btn"
        Me.menu_btn.Size = New System.Drawing.Size(75, 23)
        Me.menu_btn.TabIndex = 10
        Me.menu_btn.Text = "Menu"
        Me.menu_btn.UseVisualStyleBackColor = True
        '
        'emp_name_txt
        '
        Me.emp_name_txt.Location = New System.Drawing.Point(449, 29)
        Me.emp_name_txt.Name = "emp_name_txt"
        Me.emp_name_txt.Size = New System.Drawing.Size(122, 20)
        Me.emp_name_txt.TabIndex = 11
        '
        'CallSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 411)
        Me.Controls.Add(Me.emp_name_txt)
        Me.Controls.Add(Me.menu_btn)
        Me.Controls.Add(Me.calls_btn)
        Me.Controls.Add(Me.CallDataTable)
        Me.Controls.Add(Me.phone_number_txt)
        Me.Controls.Add(Me.fcComboBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CallSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Call Search"
        CType(Me.CallDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents fcComboBox As ComboBox
    Friend WithEvents phone_number_txt As TextBox
    Friend WithEvents CallDataTable As DataGridView
    Friend WithEvents calls_btn As Button
    Friend WithEvents menu_btn As Button
    Friend WithEvents emp_name_txt As TextBox
End Class
