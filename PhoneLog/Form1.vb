Public Class LoginPage

    ' Login button click event start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click

        Dim un As TextBox = username
        Dim pw As TextBox = password

        ' Validation- Checks for empty username and password
        If un.Text = "" And pw.Text = "" Then
            MessageBox.Show("Please enter a username and password")

        ElseIf un.Text = "" Then
            MessageBox.Show("Please enter a username")

        ElseIf pw.Text = "" Then
            MessageBox.Show("Please enter a password")

        End If
        ' Vlidation - Checks if username and password matches 
        Using plcontext As New PhoneLogEntities1
            If un.Text <> "" And pw.Text <> "" Then

                Dim unInfo = From emp In plcontext.Employees Where emp.Username = un.Text And emp.Password = pw.Text Select emp.ID

                If unInfo.Any() Then
                    ' If username and  password match redirect user to menu and set session as user ID
                    Me.Hide()
                    Dim m As Menu = New Menu()
                    m.session = unInfo.First.ToString
                    m.Show()

                Else
                    ' prompts user to try again
                    MessageBox.Show("Invalid Username or Password, Please try again")

                End If

            End If

        End Using

    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
