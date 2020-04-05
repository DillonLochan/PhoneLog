<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.calls_btn = New System.Windows.Forms.Button()
        Me.employees_btn = New System.Windows.Forms.Button()
        Me.foreign_company_btn = New System.Windows.Forms.Button()
        Me.log_out_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.welcome_lb = New System.Windows.Forms.Label()
        Me.userDisplay = New System.Windows.Forms.Label()
        Me.add_user_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calls_btn
        '
        Me.calls_btn.Location = New System.Drawing.Point(219, 141)
        Me.calls_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.calls_btn.Name = "calls_btn"
        Me.calls_btn.Size = New System.Drawing.Size(600, 95)
        Me.calls_btn.TabIndex = 0
        Me.calls_btn.Text = "Calls"
        Me.calls_btn.UseVisualStyleBackColor = True
        '
        'employees_btn
        '
        Me.employees_btn.Location = New System.Drawing.Point(219, 272)
        Me.employees_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.employees_btn.Name = "employees_btn"
        Me.employees_btn.Size = New System.Drawing.Size(600, 95)
        Me.employees_btn.TabIndex = 1
        Me.employees_btn.Text = "Employees"
        Me.employees_btn.UseVisualStyleBackColor = True
        '
        'foreign_company_btn
        '
        Me.foreign_company_btn.Location = New System.Drawing.Point(219, 408)
        Me.foreign_company_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.foreign_company_btn.Name = "foreign_company_btn"
        Me.foreign_company_btn.Size = New System.Drawing.Size(600, 95)
        Me.foreign_company_btn.TabIndex = 2
        Me.foreign_company_btn.Text = "Foreign Company"
        Me.foreign_company_btn.UseVisualStyleBackColor = True
        '
        'log_out_btn
        '
        Me.log_out_btn.Location = New System.Drawing.Point(373, 725)
        Me.log_out_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.log_out_btn.Name = "log_out_btn"
        Me.log_out_btn.Size = New System.Drawing.Size(267, 107)
        Me.log_out_btn.TabIndex = 3
        Me.log_out_btn.Text = "Log out"
        Me.log_out_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please Select"
        '
        'welcome_lb
        '
        Me.welcome_lb.AutoSize = True
        Me.welcome_lb.Location = New System.Drawing.Point(376, 21)
        Me.welcome_lb.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.welcome_lb.Name = "welcome_lb"
        Me.welcome_lb.Size = New System.Drawing.Size(141, 32)
        Me.welcome_lb.TabIndex = 5
        Me.welcome_lb.Text = "Welcome:"
        '
        'userDisplay
        '
        Me.userDisplay.AutoSize = True
        Me.userDisplay.Location = New System.Drawing.Point(512, 21)
        Me.userDisplay.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.userDisplay.Name = "userDisplay"
        Me.userDisplay.Size = New System.Drawing.Size(74, 32)
        Me.userDisplay.TabIndex = 6
        Me.userDisplay.Text = "User"
        '
        'add_user_btn
        '
        Me.add_user_btn.Location = New System.Drawing.Point(219, 546)
        Me.add_user_btn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.add_user_btn.Name = "add_user_btn"
        Me.add_user_btn.Size = New System.Drawing.Size(600, 95)
        Me.add_user_btn.TabIndex = 7
        Me.add_user_btn.Text = "Users"
        Me.add_user_btn.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 861)
        Me.Controls.Add(Me.add_user_btn)
        Me.Controls.Add(Me.userDisplay)
        Me.Controls.Add(Me.welcome_lb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.log_out_btn)
        Me.Controls.Add(Me.foreign_company_btn)
        Me.Controls.Add(Me.employees_btn)
        Me.Controls.Add(Me.calls_btn)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calls_btn As Button
    Friend WithEvents employees_btn As Button
    Friend WithEvents foreign_company_btn As Button
    Friend WithEvents log_out_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents welcome_lb As Label
    Friend WithEvents userDisplay As Label
    Friend WithEvents add_user_btn As Button
End Class
