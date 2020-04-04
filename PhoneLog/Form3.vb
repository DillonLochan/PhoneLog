Imports System.Text.RegularExpressions

Public Class ForeignCompany
    Public Property Session As String ' Used to create a session using user ID
    Public Property FcID As String ' Stores selected foreign company ID
    ' Page load
    Private Sub ForeignCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using plcontext As New PhoneLogEntities1
            save_fc_btn.Hide() ' Hides save button
            delete_fc_btn.Hide() ' Hides delete button
            ' Displays update message using foreign company ID
            If FcID <> "" Then
                Dim fcdate = From fc In plcontext.ForeignCompanies Where fc.ID = FcID Select fc
                MessageBox.Show(fcdate.First.FName & " Updated Successfully")
            End If
            ' Populates foreign companies combobox
            Dim fcData = From fc In plcontext.ForeignCompanies Select fc
            fcComboBox.DataSource = fcData.ToList
            fcComboBox.DisplayMember = "FName" ' Sets combo box to display foreign company name 
            fcComboBox.ValueMember = "ID" ' Set to foreign company ID
            fcComboBox.SelectedIndex = -1 ' creates a blank space in combobox
            'Set AutoCompleteMode.
            fcComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
            fcComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        End Using
    End Sub
    ' Menu button event
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles menu_btn.Click
        Me.Hide()
        Dim m As Menu = New Menu()
        m.Session = Session
        m.Show()
    End Sub
    ' When items in foreign companies combobox is selected
    Private Sub fcComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fcComboBox.SelectedIndexChanged
        If fcComboBox.ValueMember <> String.Empty And fcComboBox.SelectedValue IsNot Nothing Then
            Using plcontext As New PhoneLogEntities1
                Dim eid As Integer
                ' Gets record of select foreign company
                Dim fcData = From fc In plcontext.ForeignCompanies Where fc.ID = fcComboBox.SelectedValue.ToString Select fc
                ' Populates foreign company form  
                id_lb.Text = fcComboBox.SelectedValue.ToString
                company_name_txt.Text = fcData.First.FName
                phone_number_txt.Text = fcData.First.PhoneNumber
                city_txt.Text = fcData.First.City
                country_txt.Text = fcData.First.Country
                ' Checks if employee ID exist
                If fcData.First.EmployeeID IsNot Nothing Then
                    eid = fcData.First.EmployeeID
                    Dim unInfo = From emp In plcontext.Employees Where emp.Username <> "admin" Select emp
                    ' Linq query used to get all employees in the database
                    Dim uni = From emp In plcontext.Employees Where emp.ID = eid And emp.Username <> "admin" Select emp
                    ' Populates employee comboboc if foreign company has employee ID
                    If uni.Any Then
                        Dim name = uni.First.Name
                        empComboBox.DataSource = unInfo.ToList ' Creates a list from the query results and sets it as the datasource of the combobox
                        empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
                        empComboBox.ValueMember = "ID" ' Sets the value of the list item
                        ' Sets index on empployee combobox to foreign company employee ID
                        For i = 0 To empComboBox.Items.Count - 1
                            Dim obj As Employee = empComboBox.Items(i)
                            Dim empName = obj.Name
                            If empName = name Then
                                empComboBox.SelectedIndex = i
                                Exit For
                            End If
                        Next i
                        'Set AutoCompleteMode.
                        empComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
                        empComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
                    End If
                Else
                    ' If foreign company does not have and associated employee 
                    MessageBox.Show("Employee Does Not exsit, Please select new employee") ' prompts user 
                    Dim unInfo = From emp In plcontext.Employees Where emp.Username <> "admin" Select emp
                    empComboBox.DataSource = unInfo.ToList ' Creates a list from the query results and sets it as the datasource of the combobox
                    empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
                    empComboBox.ValueMember = "ID" ' Sets the value of the list item
                    empComboBox.SelectedIndex = -1 ' Sets combo box to blank
                    save_fc_btn.Show() ' Shows save button
                End If
                ' Shows save and delete button
                save_fc_btn.Show()
                delete_fc_btn.Show()
            End Using
        End If
    End Sub
    ' Save button event
    Private Sub save_fc_btn_Click(sender As Object, e As EventArgs) Handles save_fc_btn.Click
        Dim strOutput As String
        strOutput = ""
        'Validates - Checks if company name, phone number, city, country fields and employee combobox are not empty
        If company_name_txt.Text IsNot String.Empty And phone_number_txt.Text IsNot String.Empty And city_txt.Text IsNot String.Empty And country_txt.Text IsNot String.Empty And empComboBox.SelectedValue IsNot Nothing Then
            Using plcontext As New PhoneLogEntities1
                If id_lb.Text Is String.Empty Then
                    ' Validates - Checks if company name and phone number alreay exist
                    Dim fcName = From fc In plcontext.ForeignCompanies Where fc.FName = company_name_txt.Text Select fc.FName
                    Dim fcPn = From fc In plcontext.ForeignCompanies Where fc.PhoneNumber = phone_number_txt.Text Select fc.PhoneNumber
                    If fcName.Any Then
                        strOutput = "Company Name" & vbNewLine
                    ElseIf fcPn.Any Then
                        strOutput = String.Concat(strOutput, "Phone Number" & vbNewLine)
                    ElseIf strOutput <> "" Then
                        strOutput = String.Concat(strOutput, " Already exsist, please reenter")
                    Else
                        ' Saves foreign company to database
                        Dim Fc As New ForeignCompany
                        ' Sets values to be saved
                        Fc.FName = company_name_txt.Text
                        Fc.PhoneNumber = phone_number_txt.Text
                        Fc.City = city_txt.Text
                        Fc.Country = country_txt.Text
                        Fc.EmployeeID = empComboBox.SelectedValue.ToString
                        plcontext.ForeignCompanies.Add(Fc) ' Adds record to be saved
                        Dim ask As MsgBoxResult = MsgBox("Confirm Save", MsgBoxStyle.YesNo)
                        If ask = MsgBoxResult.Yes Then
                            plcontext.SaveChanges() ' Inserts record into database
                            ' Gets foreign company ID
                            Dim fcData = From f In plcontext.ForeignCompanies Where f.FName = company_name_txt.Text Select f
                            FcID = fcData.First.ID
                        ElseIf ask = MsgBoxResult.No Then
                            Refresh()
                        End If
                        ' Redirects user and display update message box
                        Me.Hide()
                        Dim fcForm As ForeignCompany = New ForeignCompany()
                        fcForm.Session = Session ' Sets session ID
                        fcForm.FcID = FcID ' Sets using foreign company ID
                        fcForm.Show()
                    End If
                ElseIf id_lb.Text <> "" Then
                    ' If foreign company is selected and being updated
                    FcID = id_lb.Text
                    ' Validates - Checks if company name and phone number alreay exist excluding selected foreign company
                    Dim fcName = From fc In plcontext.ForeignCompanies Where fc.FName = company_name_txt.Text And fc.ID <> FcID Select fc.FName
                    Dim fcPn = From fc In plcontext.ForeignCompanies Where fc.PhoneNumber = phone_number_txt.Text And fc.ID <> FcID Select fc.PhoneNumber
                    ' Dim fcEmp = From fc In plcontext.ForeignCompanies Where fc.EmployeeID = empComboBox.SelectedValue And fc.ID <> fcID Select fc.EmployeeID
                    If fcName.Any Then
                        strOutput = "Company Name" & vbNewLine
                    ElseIf fcPn.Any Then
                        strOutput = String.Concat(strOutput, "Phone Number" & vbNewLine)
                    ElseIf strOutput <> "" Then
                        strOutput = String.Concat(strOutput, "Already exsis, please reenter")
                        ' If company name and phone number does not exist update 
                    ElseIf fcName.Count = 0 And fcPn.Count = 0 Then
                        ' Get selected foreign company record
                        Dim FcData = (From fc In plcontext.ForeignCompanies Where fc.ID = FcID Select fc).FirstOrDefault
                        ' Get call records associated with selected foreign company
                        Dim callUp = From c In plcontext.Calls Where c.ForeignCompanyID = FcID Select c
                        Dim callList As List(Of [Call])
                        callList = callUp.ToList
                        ' sets values
                        FcData.FName = company_name_txt.Text
                        FcData.PhoneNumber = phone_number_txt.Text
                        FcData.City = city_txt.Text
                        FcData.Country = country_txt.Text
                        FcData.EmployeeID = empComboBox.SelectedValue.ToString
                        Dim ask As MsgBoxResult = MsgBox("Confirm Save", MsgBoxStyle.YesNo)
                        If ask = MsgBoxResult.Yes Then
                            plcontext.SaveChanges() ' Updates record  in database
                            If callUp.Any Then
                                ' Changes company name in associated calls
                                If callUp.First.ForeignCompanyName.ToString <> company_name_txt.Text Then
                                    If callUp IsNot Nothing And callUp.First.ForeignCompanyID = FcID Then
                                        For Each item In callList
                                            If callUp.First.ForeignCompanyID = item.ForeignCompanyID Then
                                                item.ForeignCompanyName = company_name_txt.Text
                                                plcontext.SaveChanges()
                                            End If
                                        Next
                                    End If
                                End If
                            End If
                        ElseIf ask = MsgBoxResult.No Then
                            Refresh()
                        End If
                        Me.Hide()
                        Dim fcForm As ForeignCompany = New ForeignCompany()
                        fcForm.Session = Session
                        fcForm.FcID = FcID
                        fcForm.Show()
                    End If
                End If
            End Using
        Else
            ' Validation - checks for empty values
            strOutput = "Please " & vbNewLine
            If company_name_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Select a Company" & vbNewLine)
            End If
            If phone_number_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Enter a Phone Number" & vbNewLine)
            End If
            If city_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Enter a City" & vbNewLine)
            End If
            If country_txt.Text Is String.Empty Then
                strOutput = String.Concat(strOutput, "Enter a Country" & vbNewLine)
            End If
            If empComboBox.SelectedValue Is Nothing Then
                strOutput = String.Concat(strOutput, "Select an Employee")
            End If
            MessageBox.Show(strOutput)
        End If
        If strOutput <> "" Then
            MessageBox.Show(strOutput)
        End If
    End Sub
    ' Delete button event
    Private Sub delete_fc_btn_Click(sender As Object, e As EventArgs) Handles delete_fc_btn.Click
        Using plcontext As New PhoneLogEntities1
            ' Gets selcted foreign company associated call records
            Dim callData = From c In plcontext.Calls Where c.ForeignCompanyID = id_lb.Text Select c
            Dim callList As List(Of [Call])
            callList = callData.ToList
            If callData.Any Then
                'Prompts user that foreign company is linked to calls and they wish to delete
                Dim ask As MsgBoxResult = MsgBox("This emplyee is linked to calls, Do wish to delete", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then
                    ' Second delete comformation prompt
                    Dim ask2 As MsgBoxResult = MsgBox("Confirm Delete", MsgBoxStyle.YesNo)
                    If ask2 = MsgBoxResult.Yes Then
                        ' Deletes foreign company ID from  associated calls in iteration
                        If callData.Any And callData.First.ForeignCompanyID = id_lb.Text Then
                            For Each item In callList
                                If callData.First.ForeignCompanyID = item.ForeignCompanyID Then
                                    item.ForeignCompanyID = Nothing
                                    plcontext.SaveChanges()
                                End If
                            Next
                            Dim fcDel = (From fc In plcontext.ForeignCompanies Where fc.ID = id_lb.Text Select fc).FirstOrDefault
                            ' Deletes selected foreign company
                            If fcDel IsNot Nothing Then
                                plcontext.ForeignCompanies.Remove(fcDel)
                                plcontext.SaveChanges()
                            End If
                        End If
                    ElseIf ask2 = MsgBoxResult.No Then
                        Refresh()
                    End If
                ElseIf ask = MsgBoxResult.No Then
                    Refresh()
                End If
            Else
                ' If foreign company is not associated to any calls
                Dim ask As MsgBoxResult = MsgBox("Confirm Delete", MsgBoxStyle.YesNo)
                If ask = MsgBoxResult.Yes Then
                    Dim fcDel = (From fc In plcontext.ForeignCompanies Where fc.ID = id_lb.Text Select fc).FirstOrDefault
                    ' Deletes selected foreign company
                    If fcDel IsNot Nothing Then
                        plcontext.ForeignCompanies.Remove(fcDel)
                        plcontext.SaveChanges()
                    End If
                ElseIf ask = MsgBoxResult.No Then
                    Refresh()
                End If
            End If
        End Using
        Me.Hide()
        Dim fcForm As ForeignCompany = New ForeignCompany()
        fcForm.Session = Session
        fcForm.Show()
    End Sub
    ' Create button event
    Private Sub create_new_btn_Click(sender As Object, e As EventArgs) Handles create_new_fc_btn.Click
        Label1.Hide() ' Hides label
        fcComboBox.Hide() ' Hides employee select combobox  
        Label2.Hide() ' Hides employee ID label 
        id_lb.Hide() ' Hides ID label
        company_name_txt.Clear() ' Clears company name
        phone_number_txt.Clear() ' Clears employee name text field
        city_txt.Clear() ' Clears employee extension text field
        country_txt.Clear() ' Clears  Country
        empComboBox.SelectedIndex = -1 ' Sets employee combobox index
        save_fc_btn.Show() ' Shows Save button 
        delete_fc_btn.Hide() ' Hides delete button
        Using plcontext As New PhoneLogEntities1
            ' Populates employee combo box
            Dim empData = From emp In plcontext.Employees Where emp.Username <> "admin" Select emp
            If empData IsNot Nothing Then
                ' Prompts user that there are no employees
                MessageBox.Show("There are no Employees")
                ' Redirects user to employee maintanence form
                Me.Hide()
                Dim emp As EmployeeMaintenance = New EmployeeMaintenance()
                emp.Session = Session
                emp.Show()
            Else
                empComboBox.DataSource = empData.ToList ' Creates a list from the query results and sets it as the datasource of the combobox
                empComboBox.DisplayMember = "Name" ' Sets employee names to be displayed on combobox
                empComboBox.ValueMember = "ID" ' Sets the value of the list item
                empComboBox.SelectedIndex = -1
                'Set AutoCompleteMode.
                empComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
                empComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
            End If
        End Using
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Me.Hide()
        Dim fc As ForeignCompany = New ForeignCompany()
        fc.Session = Session
        fc.Show()
    End Sub
    ' Ensure there are only numbers in phone number field for copy and paste
    Private Sub phone_number_txt_TextChanged(sender As Object, e As EventArgs) Handles phone_number_txt.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        phone_number_txt.Text = digitsOnly.Replace(phone_number_txt.Text, "")
    End Sub
    ' Ensure there are only numbers in phone number field when typing
    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class