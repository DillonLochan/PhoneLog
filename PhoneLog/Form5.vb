Public Class CallSearch
    Public Property session As String
    Public Property callDate As String ' saves selected date value
    Public Property callID As String
    ' On page load
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using plContext As New PhoneLogEntities1
            ' Display record of newly added call 
            If callID IsNot Nothing Then
                Dim callInfo = From cs In plContext.Calls Where cs.ID = callID Select cs.ID, cs.Date, cs.ForeignCompanyName, cs.PhoneNumber, cs.Time, cs.Duration, cs.EmployeeName
                ' Set datagrid to be display results 
                CallDataTable.DataSource = callInfo.ToList
            End If

            ' Populates foreign company combo bx
            Dim fcData = From fc In plContext.ForeignCompanies Select fc
            fcComboBox.DataSource = fcData.ToList
            fcComboBox.DisplayMember = "FName"
            fcComboBox.ValueMember = "ID"
            fcComboBox.SelectedIndex = -1 ' creates a blank space in combobox

            'Set AutoCompleteMode.
            fcComboBox.AutoCompleteMode = AutoCompleteMode.Suggest
            fcComboBox.AutoCompleteSource = AutoCompleteSource.ListItems

            ' Sets data picker to select date from call form
            DateTimePicker1.Value = callDate
            ' Formats data to be used in query
            Dim myFormat = "yyyy-MM-dd"
            Dim myDate = Format(CDate(callDate), myFormat)
            ' Get records of calls that have select date
            Dim callData = From cs In plContext.Calls Where cs.Date = myDate Select cs.ID, cs.Date, cs.ForeignCompanyName, cs.PhoneNumber, cs.Time, cs.Duration, cs.EmployeeName
            ' Set datagrid to be display results 
            CallDataTable.DataSource = callData.ToList

        End Using
    End Sub

    ' Menu button to redirect user back to menu form
    Private Sub menu_btn_Click(sender As Object, e As EventArgs) Handles menu_btn.Click
        Me.Hide()
        Dim m As Menu = New Menu()
        m.session = session
        m.Show()
    End Sub

    ' Call button to redirect user back to call form
    Private Sub calls_btn_Click(sender As Object, e As EventArgs) Handles calls_btn.Click
        Me.Hide()
        Dim c As Calls = New Calls()
        c.session = session
        c.Show()
    End Sub

    Private Sub CallDataTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CallDataTable.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As New DataGridViewRow
        selectedRow = CallDataTable.Rows(index)

        '  CallDataTable.ClearSelection()
        ' CallDataTable.CurrentCell = CallDataTable.Rows(0).Cells(0)
        '  CallDataTable.Rows(0).Selected = True

        Me.Hide()
        Dim cs As Calls = New Calls()
        cs.session = session
        cs.callID = selectedRow.Cells(0).Value.ToString
        cs.Show()

    End Sub

    ' When a date is selected from date picker
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Using plContext As New PhoneLogEntities1
            ' Formats date to be used in query
            Dim myFormat = "yyyy-MM-dd"
            Dim dt As String
            dt = DateTimePicker1.Value.ToString
            Dim myDate = Format(CDate(dt), myFormat)

            'If foreign company combo box has no value
            If fcComboBox.SelectedValue Is Nothing Then
                ' Gets all records with selected date
                Dim callData = From cs In plContext.Calls Where cs.Date = myDate Select cs.ID, cs.Date, cs.ForeignCompanyName, cs.PhoneNumber, cs.Time, cs.Duration, cs.EmployeeName
                If callData IsNot Nothing Then
                    CallDataTable.DataSource = callData.ToList ' Displays results
                End If
            Else
                ' If foreign company combo box has a value get records with selected date and selected foreign company
                Dim callData = From cs In plContext.Calls Where cs.Date = myDate And cs.ForeignCompanyID = fcComboBox.SelectedValue.ToString Select cs.ID, cs.Date, cs.ForeignCompanyName, cs.PhoneNumber, cs.Time, cs.Duration, cs.EmployeeName
                If callData.Any Then
                    phone_number_txt.Text = callData.First.PhoneNumber ' Sets foreign company phone number
                    emp_name_txt.Text = callData.First.EmployeeName ' Sets employee associated with foreign company
                    CallDataTable.DataSource = callData.ToList ' Displays results
                End If
            End If

        End Using
    End Sub

    ' When a foreign company is select from combo box
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fcComboBox.SelectedIndexChanged
        Using plContext As New PhoneLogEntities1
            ' Fromats selected date to used in query
            Dim myFormat = "yyyy-MM-dd"
            Dim dt As String
            dt = DateTimePicker1.Value.ToString
            Dim myDate = Format(CDate(dt), myFormat)

            ' Checks if foreign company combo box has no value
            If fcComboBox.SelectedValue Is Nothing Then
                ' Gets all records with selected date
                Dim callData = From cs In plContext.Calls Where cs.Date = myDate Select cs.ID, cs.Date, cs.ForeignCompanyName, cs.PhoneNumber, cs.Time, cs.Duration, cs.EmployeeName
                If callData.Any Then
                    CallDataTable.DataSource = callData.ToList ' Displays reuslts
                End If
            ElseIf fcComboBox.ValueMember <> "" Then
                ' If foreign company combo box has a value get records with selected date and selected foreign company
                Dim callData = From cs In plContext.Calls Where cs.Date = myDate And cs.ForeignCompanyID = fcComboBox.SelectedValue.ToString Select cs.ID, cs.Date, cs.ForeignCompanyName, cs.PhoneNumber, cs.Time, cs.Duration, cs.EmployeeName
                If callData.Count > 0 Then
                    phone_number_txt.Text = callData.First.PhoneNumber ' Sets foreign company phone number
                    emp_name_txt.Text = callData.First.EmployeeName ' Sets employee associated with foreign company
                    CallDataTable.DataSource = callData.ToList ' Displays results
                End If
            End If
        End Using
    End Sub

End Class