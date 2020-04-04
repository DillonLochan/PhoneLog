Imports System.Text.RegularExpressions

Public Class EmployeeMaintenance
    Public Property Session As String ' Used to create a session using user ID
    Public Property EmpID As String ' Stores selected employee ID
    ' Page load
    Private Sub EmployeeMaintenace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using plcontext As New PhoneLogEntities1
            save_employee_btn.Hide() ' Hides save button on page load
            delete_employee_btn.Hide() ' Hides delete button on page load
            ' Displays update message using employee ID
            If EmpID <> "" Then
                Dim empdate = From emp In plcontext.Employees Where emp.ID = EmpID Select emp
                MessageBox.Show(empdate.First.Name & " Updated Successfully")
            End If
            ' Populates employees combobox by selecting all users except admin
            Dim unInfo = From emp In plcontext.Employees Where emp.Username <> "admin" Select emp
            If unInfo.Any Then
                empComboBox.DataSource = unInfo.ToList
                empComboBox.DisplayMember = "Name" ' Employee Name
                empComboBox.ValueMember = "ID" ' EMployee ID
                empComboBox.SelectedIndex = -1 ' Set combo box to display blank
                'Set AutoCompleteMode.
                empComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
                empComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
            Else
                ' Prompts user that there are no employees 
                Dim ask As MsgBoxResult = MsgBox("There are no Employees, Do you wish to add a new Employee ", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then
                    create_new_emp_btn.PerformClick()
                Else ask = MsgBoxResult.No
                    Refresh()
                End If
            End If
        End Using
    End Sub
    ' Menu button function
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu_btn.Click
        Me.Hide() ' Hides current window
        Dim m As Menu = New Menu() ' Creates a new instance of Menu window
        m.Session = Session ' saves session value
        m.Show() ' shows Menu window
    End Sub
    ' When items in employee combobox is selected
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles empComboBox.SelectedIndexChanged
        If empComboBox.ValueMember <> String.Empty And empComboBox.SelectedValue IsNot Nothing Then
            Using plcontext As New PhoneLogEntities1
                ' Get record of select employee ID
                Dim empData = From emp In plcontext.Employees Where emp.ID = empComboBox.SelectedValue.ToString Select emp
                ' Display record onto form 
                If empData.Any Then
                    id_lb.Text = empComboBox.SelectedValue.ToString
                    emp_name_txt.Text = empData.First.Name
                    ext_txt.Text = empData.First.Extension
                    save_employee_btn.Show()
                    delete_employee_btn.Show()
                End If
            End Using
        End If
    End Sub
    ' Create button event
    Private Sub create_new_Click(sender As Object, e As EventArgs) Handles create_new_emp_btn.Click
        Label1.Hide() ' Hides employee ID label 
        empComboBox.Hide() ' Hides employee select combobox  
        Label2.Hide() ' Hides Employee name label
        id_lb.Hide() ' Hides ID label
        save_employee_btn.Show() ' Shows Save button 
        delete_employee_btn.Hide() ' Hides delete button
        emp_name_txt.Clear() ' Clears employee name text field
        ext_txt.Clear() ' Clears employee extension text field
    End Sub
    ' Save button event
    Private Sub save_employee_btn_Click(sender As Object, e As EventArgs) Handles save_employee_btn.Click
        ' Validates, checks if employee name and extension is empty 
        If emp_name_txt.Text <> String.Empty And ext_txt.Text <> String.Empty Then
            Using plcontext As New PhoneLogEntities1
                'Checks if selected employee ID is empty
                If id_lb.Text Is String.Empty Then
                    ' Validation checks database records to see if employee name and extension already exist 
                    Dim empName = From emp In plcontext.Employees Where emp.Name = emp_name_txt.Text Select emp.Name
                    Dim empExt = From emp In plcontext.Employees Where emp.Extension = ext_txt.Text Select emp.Extension
                    Dim empData = From emp In plcontext.Employees Where emp.Name = emp_name_txt.Text And emp.Extension = ext_txt.Text Select emp
                    If empName.Count > 0 Then
                        If (empName.FirstOrDefault.Count > 0) Then
                            MessageBox.Show("Name already take, Enter again") ' Prompt user 
                            EmpID = Nothing
                        End If
                    ElseIf empExt.Count > 0 Then
                        If (empExt.FirstOrDefault.Count > 0) Then
                            MessageBox.Show("Extension in use, Enter again") ' Prompt user 
                            EmpID = Nothing
                        End If
                    ElseIf empData.Count > 0 Then
                        If (empData.FirstOrDefault.Name.Count > 0) Then
                            MessageBox.Show("Employee and extension already exsist, Enter again") ' Prompt user 
                            EmpID = Nothing
                        End If
                    Else
                        ' Save Employee to database 
                        If id_lb.Text Is String.Empty Then
                            Dim emp As New Employee()
                            'Sets values
                            emp.Name = emp_name_txt.Text
                            emp.Extension = ext_txt.Text
                            plcontext.Employees.Add(emp) ' Adds record to be save
                            Dim ask As MsgBoxResult = MsgBox("Confirm Save", MsgBoxStyle.YesNo)
                            If ask = MsgBoxResult.Yes Then
                                plcontext.SaveChanges() ' Inserts record into database
                                ' Gets employee ID of newly saved employee
                                Dim en = From n In plcontext.Employees Where n.Name = emp_name_txt.Text Select n.ID
                                EmpID = en.First
                            ElseIf ask = MsgBoxResult.No Then
                                Refresh()
                            End If
                        End If
                        ' Redirects back to employee page and display update prompt
                        Me.Hide()
                        Dim empForm As EmployeeMaintenance = New EmployeeMaintenance()
                        empForm.Session = Session
                        empForm.EmpID = EmpID
                        empForm.Show()
                    End If
                    ' If an Employee was selected and is being updated
                ElseIf id_lb.Text IsNot String.Empty Then
                    EmpID = id_lb.Text
                    ' Validation checks database records to see if employee name and extension already exist excluding selected record
                    Dim empName = From emp In plcontext.Employees Where emp.Name = emp_name_txt.Text And emp.ID <> EmpID Select emp.Name
                    Dim empExt = From emp In plcontext.Employees Where emp.Extension = ext_txt.Text And emp.ID <> EmpID Select emp.Extension
                    Dim empData = From emp In plcontext.Employees Where emp.Name = emp_name_txt.Text And emp.Extension = ext_txt.Text Select emp
                    If empName.Count > 0 Then
                        If (empName.FirstOrDefault.Count > 0) Then
                            MessageBox.Show("Name already take, Enter again")  ' Prompt user 
                        End If
                    ElseIf empExt.Count > 0 Then
                        If (empExt.FirstOrDefault.Count > 0) Then
                            MessageBox.Show("Extension in use, Enter again")  ' Prompt user 
                        End If
                    ElseIf empData.Count > 0 Then
                        If (empData.FirstOrDefault.Name.Count > 0) Then
                            MessageBox.Show("Employee and extension already exsist, Enter again") ' Prompt user 
                        End If
                    Else
                        'Updates employee record
                        Dim empUp = (From emp In plcontext.Employees Where emp.ID = EmpID Select emp).FirstOrDefault
                        ' Gets any call records associated with the selected employee
                        Dim callUp = From c In plcontext.Calls Where c.EmployeeID = EmpID Select c
                        Dim callList As List(Of [Call])
                        callList = callUp.ToList
                        If empUp IsNot Nothing Then
                            ' Sets values
                            empUp.Name = emp_name_txt.Text
                            empUp.Extension = ext_txt.Text
                            Dim ask As MsgBoxResult = MsgBox("Confirm Save", MsgBoxStyle.YesNo)
                            If ask = MsgBoxResult.Yes Then
                                plcontext.SaveChanges() ' Updates record in data base
                                ' Checks if employee name exist in call records 
                                If callUp.Any Then
                                    If callUp.First.EmployeeName <> emp_name_txt.Text Then
                                        ' iterates call records and updates employee name
                                        For Each item In callList
                                            If callUp.First.EmployeeID = item.EmployeeID Then
                                                item.EmployeeName = emp_name_txt.Text
                                                plcontext.SaveChanges()
                                            End If
                                        Next
                                    End If
                                End If
                            ElseIf ask = MsgBoxResult.No Then
                                Refresh()
                            End If
                        End If
                        ' Redirects back to employee page and display update prompt
                        Me.Hide()
                        Dim empForm As EmployeeMaintenance = New EmployeeMaintenance()
                        empForm.Session = Session ' Sets seesion
                        empForm.EmpID = EmpID ' Sets empID with employee ID
                        empForm.Show()
                    End If
                End If
            End Using
        Else
            MessageBox.Show("Please enter Name and Extension")
        End If
    End Sub
    ' Delete button event
    Private Sub delete_employee_btn_Click(sender As Object, e As EventArgs) Handles delete_employee_btn.Click
        Dim empID As New Integer
        empID = id_lb.Text
        Using plcontext As New PhoneLogEntities1
            ' Gets reccords of companies associted with employee using employee ID
            Dim fcData = From fc In plcontext.ForeignCompanies Where fc.EmployeeID = empID Select fc
            ' Get records of calls associted with employee using employee ID
            Dim callData = From c In plcontext.Calls Where c.EmployeeID = empID Select c
            Dim fcList As List(Of ForeignCompany)
            fcList = fcData.ToList
            Dim callList As List(Of [Call])
            callList = callData.ToList
            If fcData.Any Or callData.Any Then
                '  Propmts user that employee is associated with companies and call
                Dim ask1 As MsgBoxResult = MsgBox("This emplyee is linked to a Company and calls, Do wish to delete", MsgBoxStyle.YesNo)
                If ask1 = MsgBoxResult.Yes Then
                    ' Second comfirmation of delete
                    Dim ask2 As MsgBoxResult = MsgBox("Confirm Delete", MsgBoxStyle.YesNo)
                    If ask2 = MsgBoxResult.Yes Then
                        ' Deletes employee ID form company records
                        If fcData.Any Then
                            If fcData.First.EmployeeID = empID Then
                                For Each item In fcList
                                    If fcData.First.EmployeeID = item.EmployeeID Then
                                        item.EmployeeID = Nothing
                                        plcontext.SaveChanges()
                                    End If
                                Next
                            End If
                        End If
                        ' Deletes employee ID from call  records
                        If callData.Any And callData.First.EmployeeID = empID Then
                            For Each item In callList
                                If callData.First.EmployeeID = item.EmployeeID Then
                                    item.EmployeeID = Nothing
                                    plcontext.SaveChanges()
                                End If
                            Next
                        End If
                        ' Gets selected employee record
                        Dim empDel = (From emp In plcontext.Employees Where emp.ID = empID Select emp).FirstOrDefault
                        ' Deletes employee record
                        If empDel IsNot Nothing Then
                            plcontext.Employees.Remove(empDel)
                            plcontext.SaveChanges()
                        End If
                    ElseIf ask2 = MsgBoxResult.No Then

                    End If
                ElseIf ask1 = MsgBoxResult.No Then

                End If
            Else
                ' If employee is not associted with foreign companies or calls
                Dim ask As MsgBoxResult = MsgBox("Confirm ", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then
                    ' Gets selected employee record
                    Dim empDel = (From emp In plcontext.Employees Where emp.ID = empID Select emp).FirstOrDefault
                    ' Deletes employee record
                    If empDel IsNot Nothing Then
                        plcontext.Employees.Remove(empDel)
                        plcontext.SaveChanges()
                    ElseIf ask = MsgBoxResult.No Then

                    End If
                End If
            End If
        End Using
        '  Refresh the employee maintenace
        Me.Hide()
        Dim empForm As EmployeeMaintenance = New EmployeeMaintenance()
        empForm.Session = Session
        empForm.ShowDialog()
    End Sub
    ' Search button event, refreshes form
    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Me.Hide()
        Dim emp As EmployeeMaintenance = New EmployeeMaintenance()
        emp.Session = Session
        emp.Show()
    End Sub
    ' Ensure there are only numbers in extension field for copy and paste
    Private Sub ext_txt_TextChanged(sender As Object, e As EventArgs) Handles ext_txt.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        ext_txt.Text = digitsOnly.Replace(ext_txt.Text, "")
    End Sub
    ' Ensure there are only numbers in extension field when typing
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ext_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class