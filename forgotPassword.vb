Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class forgotPassword
    Dim connectionString As String = "Data Source=localhost;database=e-voting_db;user=root;password="

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim username As String = tbUsername.Text
        Dim newPassword As String = tbPassword.Text
        Dim confirmPassword As String = tbConfirmPassword.Text

        ' Check if any of the textboxes are empty
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(newPassword) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            errorMsg.Visible = True
            errorMsg.Text = "Please fill in all required fields."
            Return
        End If

        ' Check if the password and confirm password match
        If newPassword <> confirmPassword Then
            errorMsg.Visible = True
            errorMsg.Text = "Passwords do not match."
            Return
        End If

        ' Check if the username exists in the database
        If Not DoesUsernameExist(username) Then
            errorMsg.Visible = True
            errorMsg.Text = "Username doesn't exist."
            Return
        End If

        ' Update the password in the database
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Hash the new password with bcrypt
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(newPassword, BCrypt.Net.BCrypt.GenerateSalt())

                ' Create the SQL update command
                Dim updateCommand As New MySqlCommand("UPDATE voters SET voter_password = @password WHERE voter_username = @username", connection)
                updateCommand.Parameters.AddWithValue("@password", hashedPassword)
                updateCommand.Parameters.AddWithValue("@username", username)

                ' Execute the update command
                updateCommand.ExecuteNonQuery()

                ' Password updated successfully
                errorMsg.Visible = True
                errorMsg.Text = "Password updated successfully."
            Catch ex As Exception
                ' Handle any errors
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function DoesUsernameExist(username As String) As Boolean
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New MySqlCommand("SELECT COUNT(*) FROM voters WHERE voter_username = @username", connection)
                command.Parameters.AddWithValue("@username", username)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            Catch ex As Exception
                ' Handle any errors
                MessageBox.Show("Error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Dispose()
    End Sub
End Class
