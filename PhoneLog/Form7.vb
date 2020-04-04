Public Class AddUser
    Public Property Session As String ' Used to create a session using user ID
    Public Property EmpID As String ' Stores selected employee ID
    ' Page load
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hides alerts messages 
        msg_lb.Hide()
        userChk.Hide()
        Using plcontext As New PhoneLogEntities1
            'Populates employee combo box with employees who are not users
            Dim unInfo = From emp In plcontext.Employees Where emp.Username <> "admin" And emp.Username Is Nothing Select emp ' Linq query used to get all employees in the database
            empComboBox.DataSource = unInfo.ToList ' Creates a list from the query results and sets it as the datasource of the combobox
            empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
            empComboBox.ValueMember = "ID" ' Sets the value of the list item
            empComboBox.SelectedIndex = -1 ' creates a blank space in combobox
            'Set AutoCompleteMode.
            empComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
            empComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
            ' If an employee is added or edited
            If EmpID IsNot Nothing Then
                Label2.Text = "Add User"
                Dim strOutput As String
                strOutput = ""
                Dim checkInfo = From emp In plcontext.Employees Where emp.ID = EmpID Select emp
                strOutput = checkInfo.First.Name & " Record has been updated"
                MessageBox.Show(strOutput)
            End If
        End Using
    End Sub
    ' Save button event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        ' Stores the message to be propted
        Dim strOutput As String
        strOutput = ""
        ' Checks of user name is less than 5 characters
        If username_txt.Text.Count < 5 Then
            MessageBox.Show("Username must be 5 Charateers or more")
        End If
        ' Checks of password is less than 5 characters
        If password_txt.Text.Count < 5 Then
            MessageBox.Show("Password must be 5 Charateers or more")
        End If
        ' If username, password and confirm password not empty
        If username_txt.Text IsNot String.Empty And password_txt.Text IsNot String.Empty And password_confirm_txt.Text IsNot String.Empty Then
            Using plcontext As New PhoneLogEntities1
                ' Checks if password and confirm password are the same
                If password_txt.Text <> password_confirm_txt.Text Then
                    MessageBox.Show("Passwords does not match")
                ElseIf empComboBox.SelectedValue.ToString <> "" Then
                    ' Checks to see if entered username already exist
                    Dim unChk = From emp In plcontext.Employees Where emp.ID <> empComboBox.SelectedValue.ToString And emp.Username = username_txt.Text Select emp
                    If unChk.Count > 0 Then
                        MessageBox.Show("Username already exsit")
                    Else
                        ' I username name does not exist get employee record
                        Dim empData = From emp In plcontext.Employees Where emp.ID = empComboBox.SelectedValue.ToString Select emp
                        'Sets employee username and password                                                                                       
                        empData.First.Username = username_txt.Text
                        empData.First.Password = password_txt.Text
                        ' Prompts user to confirm save
                        Dim ask As MsgBoxResult = MsgBox("Confirm Save", MsgBoxStyle.YesNo)
                        If ask = MsgBoxResult.Yes Then
                            plcontext.SaveChanges() ' updates employee record
                        ElseIf ask = MsgBoxResult.No Then
                            Refresh()
                        End If
                        ' Refreshes the form
                        Me.Hide()
                        Dim adForm As AddUser = New AddUser()
                        adForm.Session = Session
                        adForm.EmpID = empData.First.ID
                        adForm.Show()
                    End If
                Else
                End If
            End Using
        Else
            ' If any feild is empty, prompt user to enter feild information
            strOutput = "Please "
            If username_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Enter user name" & vbNewLine)
            ElseIf password_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Enter Password" & vbNewLine)
            ElseIf password_confirm_txt Is String.Empty Then
                strOutput = String.Concat(strOutput, "Comfirm password" & vbNewLine)
            End If
            MessageBox.Show(strOutput)
        End If
    End Sub
    ' Password confirm text xhange event, checks if confirm password is the same as password and display a message under feild
    Private Sub password_confirm_txt_TextChanged(sender As Object, e As EventArgs) Handles password_confirm_txt.TextChanged
        If password_confirm_txt.Text.Count >= password_txt.Text.Count Then
            If password_confirm_txt.Text <> password_txt.Text Then
                msg_lb.ForeColor = Color.Red
                msg_lb.Text = "Does not match"
            ElseIf password_confirm_txt.Text = password_txt.Text And password_confirm_txt.Text <> "" Then
                msg_lb.ForeColor = Color.Green
                msg_lb.Text = "Match"
            End If
            msg_lb.Show()
        End If
    End Sub
    ' Menu event button
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles menu_btn.Click
        Me.Hide()
        Dim m As Menu = New Menu()
        m.Session = Session
        m.Show()
    End Sub
    ' Edit button event
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles edit_user_btn.Click
        Label2.Text = "Edit User"
        Using plcontext As New PhoneLogEntities1
            ' Gets record of all employees who are users
            Dim unInfo = From emp In plcontext.Employees Where emp.Username <> "admin" And emp.Username <> Nothing And emp.Password <> Nothing Select emp ' Linq query used to get all employees in the database
            ' Populates employee combobox
            empComboBox.DataSource = unInfo.ToList ' Creates a list from the query results and sets it as the datasource of the combobox
            empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
            empComboBox.ValueMember = "ID" ' Sets the value of the list item
            empComboBox.SelectedIndex = -1 ' creates a blank space in combobox
            'Set AutoCompleteMode.
            empComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
            empComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        End Using
        ' Clears all feilds on form
        username_txt.Clear()
        password_txt.Clear()
        password_confirm_txt.Clear()
        userChk.Hide()
        msg_lb.Hide()
    End Sub
    ' Username text change event, checks to see if user name exsist as the user enters into the username feild 
    Private Sub username_txt_TextChanged(sender As Object, e As EventArgs) Handles username_txt.TextChanged
        Using plcontext As New PhoneLogEntities1
            ' Gets record of employees by user name, if any exist with entered username
            Dim unInfo = From emp In plcontext.Employees Where emp.Username = username_txt.Text Select emp
            'Displays a message under username feild if username already exist
            If unInfo.Count <> 0 Then
                If unInfo.First.Username.ToString IsNot String.Empty Then
                    userChk.ForeColor = Color.Red
                    userChk.Text = "User Already exist"
                    userChk.Show()
                Else
                    userChk.Hide()
                End If
            Else
                userChk.Hide()
            End If
        End Using
    End Sub
    ' Employee  combo box selected
    Private Sub empComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles empComboBox.SelectedIndexChanged
        If empComboBox.ValueMember <> String.Empty And empComboBox.SelectedValue IsNot Nothing Then
            Using plcontext As New PhoneLogEntities1
                ' Gets selected employee record
                Dim empData = From emp In plcontext.Employees Where emp.ID = empComboBox.SelectedValue.ToString Select emp
                ' Populates feilds with employee user information                                                                                            
                username_txt.Text = empData.First.Username
                password_txt.Text = empData.First.Password
                password_confirm_txt.Text = empData.First.Password
            End Using
        End If
    End Sub
End Class