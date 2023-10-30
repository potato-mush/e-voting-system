Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class adminLoginForm
    Private connectionString As String = "Data Source=localhost;database=e-voting_db;user=root;password="

    Private Sub tbUsername_Enter(sender As Object, e As EventArgs) Handles tbUsername.Enter
        tbUsername.ForeColor = Color.Black
        If tbUsername.Text = "Username" Then
            tbUsername.Text = ""
        End If
    End Sub
    Private Sub tbUsername_Leave(sender As Object, e As EventArgs) Handles tbUsername.Leave
        If tbUsername.Text = "" Then
            tbUsername.Text = "Username"
            tbUsername.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub tbPassword_Enter(sender As Object, e As EventArgs) Handles tbPassword.Enter
        tbPassword.UseSystemPasswordChar = True
        tbPassword.ForeColor = Color.Black
        If tbPassword.Text = "Password" Then
            tbPassword.Text = ""
        End If
    End Sub
    Private Sub tbPassword_Leave(sender As Object, e As EventArgs) Handles tbPassword.Leave
        If tbPassword.Text = "" Then
            tbPassword.UseSystemPasswordChar = False
            tbPassword.Text = "Password"
            tbPassword.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        ' Retrieve the username and password entered by the user
        Dim username As String = tbUsername.Text
        Dim password As String = tbPassword.Text

        ' Check if any of the textboxes are empty
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in both Username and Password fields.")
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Create a SQL query to retrieve the hashed password for the given username
                Dim query As String = "SELECT admin_password FROM admin WHERE admin_username = @Username"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", username)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim hashedPassword As String = reader.GetString(0)

                            ' Verify the entered password with the hashed password
                            If BCrypt.Net.BCrypt.Verify(password, hashedPassword) Then
                                ' Authentication successful
                                MessageBox.Show("Login successful.")
                                tbUsername.Text = "Username"
                                tbUsername.ForeColor = Color.Silver
                                tbPassword.Text = "Password"
                                tbPassword.UseSystemPasswordChar = False
                                tbPassword.ForeColor = Color.Silver
                                Me.Hide()
                                adminDashboard.Show()
                            Else
                                ' Authentication failed
                                errorMsg.Visible = True
                                errorMsg.Text = "Login failed. Please check your credentials."
                            End If
                        Else
                            ' Username not found in the database
                            errorMsg.Visible = True
                            errorMsg.Text = "Username does not exist."
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If showPassword.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        loginForm.Show()
        tbUsername.Text = "Username"
        tbUsername.ForeColor = Color.Silver
        tbPassword.Text = "Password"
        tbPassword.UseSystemPasswordChar = False
        tbPassword.ForeColor = Color.Silver
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Get the current time
        Dim currentTime As DateTime = DateTime.Now

        ' Format the time in 12-hour format with AM/PM
        Dim formattedTime As String = currentTime.ToString("h:mm tt")

        ' Update the Label text with the formatted time
        lblTime.Text = "Current Time: " & formattedTime
    End Sub

    Private Sub adminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
