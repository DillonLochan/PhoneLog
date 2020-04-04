Public Class Menu
    Public Property session As String

    ' On page load
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using plcontext As New PhoneLogEntities1

            ' Gets record of current user
            Dim unInfo = From emp In plcontext.Employees Where emp.ID = session Select emp
            If unInfo.Any Then
                ' Display user name
                userDisplay.Text = unInfo.First.Name
                add_user_btn.Hide()
                ' Only shows add user button if user is admin
                If unInfo.First.Username = "admin" Then
                    add_user_btn.Show()
                End If
            End If

        End Using

    End Sub

    ' Employee button event, redirects user to Employee Maintenace from
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles employees_btn.Click
        Me.Hide()
        Dim emp As EmployeeMaintenace = New EmployeeMaintenace()
        emp.session = session
        emp.Show()

    End Sub

    ' Foreign company event, redirects user to Foreign Company form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles foreign_company_btn.Click
        Me.Hide()
        Dim fc As ForeignCompany = New ForeignCompany()
        fc.session = session
        fc.Show()

    End Sub

    ' Call button event, redirects user to Call form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calls_btn.Click
        Me.Hide()
        Dim c As Calls = New Calls()
        c.session = session
        c.Show()

    End Sub

    Private Sub add_user_btn_Click(sender As Object, e As EventArgs) Handles add_user_btn.Click
        Me.Hide()
        Dim c As AddUser = New AddUser()
        c.session = session
        c.Show()
    End Sub

    ' Log out button event, Logs user out back to login form
    Private Sub log_out_Click(sender As Object, e As EventArgs) Handles log_out_btn.Click
        Me.Hide()
        Dim lp As LoginPage = New LoginPage()
        lp.Show()

    End Sub
End Class