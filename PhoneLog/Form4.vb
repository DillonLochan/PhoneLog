Imports System.Text.RegularExpressions

Public Class Calls
    Public Property Session As String ' Stores user session ID
    Public Property CallID As String ' Stores call ID after saving
    Public Property CallUpID As String ' Stores call ID after editing
    ' On page load
    Private Sub Calls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using plcontext As New PhoneLogEntities1
            If CallUpID IsNot Nothing Then
                Dim callData = (From c In plcontext.Calls Where c.ID = CallUpID Select c).First
                MessageBox.Show(callData.PhoneNumber & vbNewLine & callData.ForeignCompanyName & vbNewLine & callData.Date & " " & callData.Time.ToString & "Updated Successfully")
            End If
            ' Hides button on page load
            save_call_btn.Hide()
            delete_call_btn.Hide()
            ' Shows Date picker and sets the value to blank
            DateTimePicker1.Show()
            DateTimePicker1.CustomFormat = " "
            DateTimePicker1.Format = DateTimePickerFormat.Custom
            ' Populates the hour combo box
            For i As Integer = 0 To 24
                hrComboBox.Items.Add(i)
            Next
            ' Populates the mintues combo box
            For i As Integer = 0 To 60
                minComboBox.Items.Add(i)
            Next
            ' If a call is selected
            If CallID IsNot Nothing Then
                ' Gets selected call record
                Dim callData = (From cl In plcontext.Calls Where cl.ID = CallID Select cl).FirstOrDefault
                ' Checks if call has a time set hour and minutes combo boxes
                If callData.Time IsNot Nothing Then
                    Dim time As TimeSpan
                    Dim tm As String
                    time = callData.Time
                    tm = time.ToString
                    Dim words As String() = tm.Split(":")
                    Dim hr As String = words(0)
                    Dim min As String = words(1)
                    ' Sets hour and mintues combo box 
                    For i As Integer = 0 To 24
                        hrComboBox.Items.Add(i)
                        If i = hr Then
                            hrComboBox.SelectedIndex = i - 1
                        End If
                    Next
                    For i As Integer = 0 To 60
                        minComboBox.Items.Add(i)
                        If i = min Then
                            minComboBox.SelectedIndex = i - 1
                        End If
                    Next
                    ' Sets Phone number, date and duration of call to the form
                    phone_number_txt.Text = callData.PhoneNumber
                    DateTimePicker.Value = callData.Date
                    duration_txt.Text = callData.Duration
                End If
                ' If the call has an employee ID
                If callData.EmployeeID IsNot Nothing Then
                    ' Gets employee records
                    Dim empInfo = From emp In plcontext.Employees Where emp.Username <> "admin" Select emp
                    ' Gets record of employee stored in call
                    Dim empData = From emp In plcontext.Employees Where emp.ID = callData.EmployeeID And emp.Username <> "admin" Select emp
                    ' If employe record is not empty
                    If empData.Any Then
                        Dim name = empData.First.Name
                        ' Populates employee como box with employee records
                        empComboBox.DataSource = empInfo.ToList ' Creates a list from the query results and sets it as the datasource of the combobox
                        empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
                        empComboBox.ValueMember = "ID" ' Sets the value of the list item
                        ' Set combo box intial value to display the employee stored in selected call
                        For i = 0 To empComboBox.Items.Count - 1
                            Dim obj As Employee = empComboBox.Items(i)
                            Dim empName = obj.Name
                            If empName = name Then
                                empComboBox.SelectedIndex = i
                                Exit For
                            End If
                        Next i
                        ' Show save and delete buttons
                        If callData.ForeignCompanyID IsNot Nothing Then
                            ' If there is no foreign company ID the record would not be editable 
                            save_call_btn.Show()
                        End If
                        delete_call_btn.Show()
                    End If
                Else
                    If callData.EmployeeName IsNot Nothing Then
                        ' If employee has been deleted display employee name 
                        empComboBox.SelectedText = callData.EmployeeName
                        delete_call_btn.Show()
                    Else
                        ' If there is no employee saved in the call recored, user will be prompted 
                        MessageBox.Show("Employee Does Not exsit, Please select new employee")
                        Dim empData = From emp In plcontext.Employees Where emp.Username <> "admin" Select emp
                        empComboBox.DataSource = empData.ToList() ' Creates a list from the query results and sets it as the datasource of the combobox
                        empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
                        empComboBox.ValueMember = "ID" ' Sets the value of the list item
                        empComboBox.SelectedIndex = -1 '  Sets combo box to blank
                        ' Shows save and delete button
                        save_call_btn.Show()
                        delete_call_btn.Show()
                    End If
                End If
            Else
                phone_number_txt.AutoCompleteMode = AutoCompleteMode.Suggest
                phone_number_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                ' Populates foreign company combo box
                Dim fcData = From fc In plcontext.ForeignCompanies Select fc
                fcComboBox.DataSource = fcData.ToList
                fcComboBox.DisplayMember = "FName"
                fcComboBox.ValueMember = "ID"
                fcComboBox.SelectedIndex = -1
                'Set AutoCompleteMode.
                fcComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
                fcComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
                ' Populates employee combo box
                Dim empData = From emp In plcontext.Employees Where emp.Username <> "admin" Select emp
                empComboBox.DataSource = empData.ToList
                empComboBox.DisplayMember = "Name"
                empComboBox.ValueMember = "ID"
                empComboBox.SelectedIndex = -1
                'Set AutoCompleteMode.
                empComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
                empComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
            End If
        End Using
    End Sub
    ' Menu button event, redirects user to menu screen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles menu_btn.Click
        Me.Hide()
        Dim m As Menu = New Menu()
        m.Session = Session
        m.Show()
    End Sub
    ' Triggers when a number is entered or pasted into phonenumber feild
    Private Sub phone_number_txt_TextChanged(sender As Object, e As EventArgs) Handles phone_number_txt.TextChanged
        'Removes any characters that are not numbers 
        Dim digitsOnly As Regex = New Regex("[^\d]")
        phone_number_txt.Text = digitsOnly.Replace(phone_number_txt.Text, "")
        If phone_number_txt.Text <> "" Then
            Using plcontext As New PhoneLogEntities1
                ' Sets foreign company index to the company that the phone number entered blongs to
                Dim fcData = From fc In plcontext.ForeignCompanies Where fc.PhoneNumber = phone_number_txt.Text Select fc
                If fcData.Any Then
                    For i = 0 To fcComboBox.Items.Count - 1
                        Dim obj As ForeignCompany = fcComboBox.Items(i)
                        Dim ph = obj.PhoneNumber
                        If phone_number_txt.Text = ph Then
                            fcComboBox.SelectedIndex = i
                            Exit For
                        End If
                    Next i
                ElseIf phone_number_txt.Text.Length > 9 Then
                    If CallID Is Nothing Then
                        ' If there are companies with entered phone number, user will be propted to add a new foreign company
                        Dim ask As MsgBoxResult = MsgBox("No Company with this number exist, Create new Company", MsgBoxStyle.YesNo)
                        If ask = MsgBoxResult.Yes Then
                            Me.Hide()
                            Dim fc As ForeignCompany = New ForeignCompany()
                            fc.Session = Session
                            fc.Show()
                        ElseIf ask = MsgBoxResult.No Then
                            Refresh()
                        End If
                    Else
                        ' Prompts user that the foreign company associated with this call no longer exist and it cannot be edited only able to delete
                        MessageBox.Show("Company associated with this call no longer exist, Call cannot be edited")
                        Dim callData = (From c In plcontext.Calls Where c.ID = CallID Select c).First
                        fcComboBox.SelectedText = callData.ForeignCompanyName
                        save_call_btn.Hide()
                    End If
                End If
            End Using
        End If
    End Sub
    ' Allows only numbers to be entered into phone number text feild
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    ' Create new button event
    Private Sub create_new_call_btn_Click(sender As Object, e As EventArgs) Handles create_new_call_btn.Click
        ' Clears selected call ID 
        CallID = Nothing ' Sets CallID to nothing, 
        CallUpID = Nothing ' Sets CallUpID to nothing
        ' Hides lable and date picker 
        Label1.Hide()
        DateTimePicker1.Hide()
        ' Clears all feilds and sets comoboxes to blank      
        duration_txt.Clear()
        save_call_btn.Show()
        Using plContext As New PhoneLogEntities1
            Dim fcData = From fc In plContext.ForeignCompanies Select fc
            fcComboBox.DataSource = fcData.ToList
            fcComboBox.DisplayMember = "FName"
            fcComboBox.ValueMember = "ID"
            fcComboBox.SelectedIndex = -1
            'Set AutoCompleteMode.
            fcComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
            fcComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
            ' Populates employee combo box
            Dim empData = From emp In plContext.Employees Where emp.Username <> "admin" Select emp
            empComboBox.DataSource = empData.ToList
            empComboBox.DisplayMember = "Name"
            empComboBox.ValueMember = "ID"
            empComboBox.SelectedIndex = -1
            'Set AutoCompleteMode.
            empComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
            empComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        End Using
        phone_number_txt.Clear()
    End Sub
    ' Save button event
    Private Sub save_call_btn_Click(sender As Object, e As EventArgs) Handles save_call_btn.Click
        Dim strOutput As String ' Stores message to propt user
        Dim time As String ' Stores time seleced form hour and minutes combo boxes
        strOutput = ""
        ' Validation checks if feild are not empty
        If phone_number_txt.Text IsNot String.Empty And fcComboBox.SelectedValue IsNot Nothing And duration_txt.Text IsNot String.Empty And empComboBox.SelectedValue IsNot Nothing And hrComboBox.SelectedItem IsNot Nothing And minComboBox.SelectedItem IsNot Nothing Then
            time = hrComboBox.SelectedItem.ToString & ":" & minComboBox.SelectedItem.ToString
            Using plContext As New PhoneLogEntities1
                ' Gets employee record of emplyee selected from combo box
                Dim empData = From emp In plContext.Employees Where emp.ID = empComboBox.SelectedValue.ToString Select emp
                ' Gets foreign company record of foreign company selected from combo box
                Dim fcData = From fc In plContext.ForeignCompanies Where fc.ID = fcComboBox.SelectedValue.ToString Select fc
                ' Saves new call, checks if call ID is empty
                If CallID Is Nothing Then
                    ' Sets Data to stores in to new call record using data from form feilds
                    Dim callData As New [Call]
                    ' Sets valuse to be saved
                    callData.PhoneNumber = phone_number_txt.Text
                    callData.ForeignCompanyID = fcComboBox.SelectedValue
                    callData.ForeignCompanyName = fcData.First.FName
                    callData.Date = DateTimePicker.Value
                    callData.Time = TimeSpan.Parse(time)
                    callData.Duration = duration_txt.Text
                    callData.EmployeeID = empComboBox.SelectedValue
                    callData.EmployeeName = empData.First.Name
                    plContext.Calls.Add(callData) ' sets record to be inserted 
                    ' Prompts user to confirm save
                    Dim ask As MsgBoxResult = MsgBox("Confirm Save", MsgBoxStyle.YesNo)
                    If ask = MsgBoxResult.Yes Then
                        plContext.SaveChanges() ' inserts record to database
                        Dim callup = (From c In plContext.Calls Select c.ID).Max()
                        CallUpID = callup
                    ElseIf ask = MsgBoxResult.No Then
                        Refresh()
                    End If
                    ' Redriects user back to call form
                    Me.Hide()
                    Dim cForm As Calls = New Calls()
                    cForm.Session = Session
                    cForm.Show()
                Else
                    ' If a call is selected and is being updated
                    ' Gets selected call record
                    Dim callData = (From cl In plContext.Calls Where cl.ID = CallID Select cl).FirstOrDefault
                    If callData IsNot Nothing Then
                        ' sets data to be updated
                        callData.PhoneNumber = phone_number_txt.Text
                        callData.ForeignCompanyID = fcComboBox.SelectedValue
                        callData.ForeignCompanyName = fcData.First.FName
                        callData.Date = DateTimePicker.Value
                        callData.Time = TimeSpan.Parse(time)
                        callData.Duration = duration_txt.Text
                        callData.EmployeeID = empComboBox.SelectedValue
                        callData.EmployeeName = empData.First.Name
                        ' Propmts user to confrim save
                        Dim ask As MsgBoxResult = MsgBox("Confirm Save", MsgBoxStyle.YesNo)
                        If ask = MsgBoxResult.Yes Then
                            plContext.SaveChanges() ' updates record in database
                            CallUpID = CallID
                        ElseIf ask = MsgBoxResult.No Then
                            Refresh()
                        End If
                        Me.Hide()
                        Dim c As Calls = New Calls()
                        c.Session = Session
                        c.Show()
                    End If
                End If
            End Using
        Else
            ' If any specified feild is empty, strOutput will concatante error message according to which feidis empty
            strOutput = "Please " & vbNewLine
            If phone_number_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Enter a Phone Number" & vbNewLine)
            End If
            If fcComboBox.SelectedValue Is Nothing Then
                strOutput = String.Concat(strOutput, "Select a Company Name" & vbNewLine)
            End If
            If DateTimePicker.Value = Nothing Then
                strOutput = String.Concat(strOutput, "Select a Date" & vbNewLine)
            End If
            If hrComboBox.SelectedItem Is Nothing Or minComboBox.SelectedItem Is Nothing Then
                strOutput = String.Concat(strOutput, "Enter Time" & vbNewLine)
            End If
            If duration_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Enter a Duration" & vbNewLine)
            End If
            If empComboBox.SelectedValue Is Nothing Then
                strOutput = String.Concat(strOutput, "Select an Employee")
            End If
        End If
        ' If strOutput is not empty user will get a prompt showing empty fields and save is stopped 
        If strOutput IsNot String.Empty Then
            MessageBox.Show(strOutput)
        End If
    End Sub
    ' When a foreign company is selected from combo box
    Private Sub fcComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fcComboBox.SelectedIndexChanged
        If fcComboBox.ValueMember <> String.Empty And fcComboBox.SelectedValue IsNot Nothing Then
            Using plContext As New PhoneLogEntities1
                Dim fcData = From fc In plContext.ForeignCompanies Where fc.ID = fcComboBox.SelectedValue.ToString Select fc
                Dim empID As Integer
                empID = fcData.First.EmployeeID
                'Populates employee combobox with employee that belongs to selected company
                Dim empData = From emp In plContext.Employees Where emp.ID = empID Select emp
                If fcData.Any Then
                    empComboBox.DataSource = empData.ToList ' Creates a list from the query results and sets it as the datasource of the combobox
                    empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
                    empComboBox.ValueMember = "ID" ' Sets the value of the list item
                    empComboBox.SelectedIndex = 0
                    phone_number_txt.Text = fcData.First.PhoneNumber ' Sets phone number text to the selected company phone number
                End If
            End Using
        End If
    End Sub
    ' Event when a date is selected from DateTimePicker1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value.ToString <> "" Then
            ' User is redriected to call search page where they search and select a call
            Me.Hide()
            Dim cs As CallSearch = New CallSearch()
            cs.Session = Session ' sets session ID
            cs.CallDate = DateTimePicker1.Value.ToString ' Sets data value to be used in call search from
            cs.Show()
        End If
    End Sub
    ' Refreshes call form after a call has been selected
    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Me.Hide()
        Dim c As Calls = New Calls()
        c.Session = Session
        c.Show()
    End Sub
    'Delete button events
    Private Sub delete_call_btn_Click(sender As Object, e As EventArgs) Handles delete_call_btn.Click
        ' Prompts user to confirm delete
        Dim ask As MsgBoxResult = MsgBox("Confirm Delete", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Using plcontext As New PhoneLogEntities1
                ' Gets selected user record
                Dim cDel = (From c In plcontext.Calls Where c.ID = CallID Select c).FirstOrDefault
                If cDel IsNot Nothing Then
                    plcontext.Calls.Remove(cDel) ' Sets record to be removed
                    plcontext.SaveChanges() ' Removes record from database
                End If
            End Using
        ElseIf ask = MsgBoxResult.No Then
            Refresh()
        End If
        ' Redirects back to call form
        Me.Hide()
        Dim cForm As Calls = New Calls()
        cForm.Session = Session
        cForm.Show()
    End Sub
    ' Only allows numbers to be entered into phone number text feild
    Private Sub duration_txt_TextChanged(sender As Object, e As EventArgs) Handles duration_txt.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        duration_txt.Text = digitsOnly.Replace(duration_txt.Text, "")
    End Sub
End Class