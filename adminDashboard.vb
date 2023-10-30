Imports MySql.Data.MySqlClient
Imports System.Data

Public Class adminDashboard
    Private studentTable As New DataTable()
    Private dataTable As New DataTable()

    Dim connectionString As String = "Data Source=localhost;database=e-voting_db;user=root;password="
    ' Create an instance of OpenFileDialog
    Dim openFileDialog As New OpenFileDialog()

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
        ' Initialize the DataGridView
        studentData.AutoGenerateColumns = False
        candidateData.AutoGenerateColumns = False
        voterData.AutoGenerateColumns = False

        studentData.DataSource = studentTable

        ' Load data
        LoadStudentData()
        LoadCandidateData()
        LoadVoterData()
        LoadWinnerData()
        LoadEnumValues()
        CheckElectionStatus()
    End Sub
    Private Sub CheckElectionStatus()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve the election status
                Dim query As String = "SELECT election_status FROM election"

                Using cmd As New MySqlCommand(query, connection)
                    Dim electionStatus As String = Convert.ToString(cmd.ExecuteScalar())

                    ' Check the election status and update the button text accordingly
                    If electionStatus = "ONGOING" Then
                        electionBtn.Text = "End Election"
                    Else
                        electionBtn.Text = "Start Election"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking election status: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadStudentData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM students"

                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet)

                    ' Bind the DataGridView to the dataset
                    studentData.DataSource = dataSet.Tables(0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadCandidateData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM candidates"

                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet)

                    ' Bind the DataGridView to the dataset
                    candidateData.DataSource = dataSet.Tables(0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadVoterData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM voters"
                Dim countQuery As String = "SELECT COUNT(*) FROM candidates WHERE candidate_position = 'PRESIDENT'"

                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet)

                    ' Bind the DataGridView to the dataset
                    voterData.DataSource = dataSet.Tables(0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadEnumValues()
        cbPosition.Items.Clear() ' Clear existing items
        cbPosition.DropDownStyle = ComboBoxStyle.DropDownList

        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'e-voting_db' AND TABLE_NAME = 'candidates' AND COLUMN_NAME = 'candidate_position';"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Assume the result is stored in a variable called enumValuesStr
                        Dim enumValuesStr As String = "enum(PRESIDENT,VICE PRESIDENT,SECRETARY,TREASURER,AUDITOR,BUSINESS MANAGER,REPRESENTATIVE,CABINET MEMBER)"

                        ' Remove "enum(" and ")" from the string
                        enumValuesStr = enumValuesStr.Replace("enum(", "").Replace(")", "")

                        ' Split the values into an array
                        Dim enumValues As String() = enumValuesStr.Split(","c)

                        ' Add the values to your ComboBox
                        For Each value As String In enumValues
                            cbPosition.Items.Add(value)
                        Next

                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub LoadWinnerData()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve data from the result table
                Dim query As String = "SELECT winner_id, winner_name, winner_position, vote_count, election_date FROM result"

                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim dataSet As New DataSet()
                    adapter.Fill(dataSet)

                    ' Bind the DataGridView (winnerData) to the dataset
                    winnerData.DataSource = dataSet.Tables(0)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading winner data: " & ex.Message)
        End Try
    End Sub


    Private Sub studentBtn_Click(sender As Object, e As EventArgs) Handles studentBtn.Click, candidateBtn.Click, voterBtn.Click, Button4.Click
        LoadStudentData()
        LoadCandidateData()
        LoadVoterData()
        LoadWinnerData()
        Try
            Dim myBtn = DirectCast(sender, Button)

            Select Case myBtn.Name
                Case "studentBtn"
                    TabControl1.SelectedTab = TabPage1
                Case "candidateBtn"
                    TabControl1.SelectedTab = TabPage2
                    cbPosition.SelectedIndex = 0
                Case "voterBtn"
                    TabControl1.SelectedTab = TabPage3
                Case "Button4"
                    TabControl1.SelectedTab = TabPage4
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub tbStudentID1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStudentID1.KeyPress
        ' Define the maximum allowed length
        Dim maxLength As Integer = 12 ' Change this to your desired maximum length

        ' Check if the length of the text is already at the maximum
        If tbStudentID1.Text.Length >= maxLength Then
            ' If it is, prevent any more characters from being entered
            e.Handled = True
        End If
    End Sub


    Private Sub candidateImg_Click(sender As Object, e As EventArgs) Handles candidateImg.Click
        ' Set the filter to restrict to image files only
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog.Title = "Select an Image"

        ' Show the dialog and check if a file was selected
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim selectedImagePath As String = openFileDialog.FileName

            ' Display the selected image in the PictureBox (candidateImg)
            candidateImg.Image = Image.FromFile(selectedImagePath)

            ' Optionally, save the file path to a variable or database if needed
            ' Dim imagePathToSave As String = selectedImagePath
        End If
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            adminLoginForm.Show()
        Else

        End If

    End Sub
    Private Sub studentData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentData.CellContentClick
        Try
            If studentData.Columns(e.ColumnIndex).Name = "UpdateStudent" Then
                ' Check if any rows are selected
                If studentData.SelectedRows.Count > 0 Then
                    ' Get the first selected row
                    Dim selectedRow As DataGridViewRow = studentData.SelectedRows(0)

                    ' Get the student ID of the selected row
                    Dim studentID As String = selectedRow.Cells("student_id").Value.ToString()

                    ' Get the current values from the DataGridView
                    Dim currentFirstName As String = selectedRow.Cells("student_fname").Value.ToString()
                    Dim currentLastName As String = selectedRow.Cells("student_lname").Value.ToString()

                    ' Update the database with the current values
                    UpdateStudentInDatabase(studentID, currentFirstName, currentLastName)

                    MessageBox.Show("Student information updated in the database.")
                Else
                    MessageBox.Show("No student selected.")
                End If
            ElseIf studentData.Columns(e.ColumnIndex).Name = "DeleteStudent" Then
                Dim selectedRowIndex As Integer = e.RowIndex
                If selectedRowIndex >= 0 Then
                    ' Get the studentID from the selected row
                    Dim studentID As String = studentData.Rows(selectedRowIndex).Cells("student_id").Value.ToString()

                    ' Delete the selected row from the DataGridView
                    studentData.Rows.RemoveAt(selectedRowIndex)

                    ' Delete the corresponding record from the database
                    DeleteStudentFromDatabase(studentID)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addStudentBtn.Click
        Dim studentID As String = tbStudentID1.Text
        Dim firstName As String = tbFirstName1.Text
        Dim lastName As String = tbLastName1.Text

        If String.IsNullOrWhiteSpace(studentID) OrElse String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the data source (DataTable) is null
        If studentData.DataSource Is Nothing Then
            ' Create a new DataTable and set it as the data source
            Dim newDataTable As New DataTable()
            studentData.DataSource = newDataTable
        End If

        ' Get the data source (DataTable)
        Dim dataTable As DataTable = DirectCast(studentData.DataSource, DataTable)

        ' Add a new row to the DataTable
        Dim newRow As DataRow = dataTable.NewRow()
        newRow("student_id") = studentID
        newRow("student_fname") = firstName
        newRow("student_lname") = lastName
        newRow("student_status") = "NOT VOTER"
        dataTable.Rows.Add(newRow)

        ' Insert the values into the "students" table in the database
        InsertStudentIntoDatabase(studentID, firstName, lastName)

        ' Clear the textboxes
        tbStudentID1.Text = ""
        tbFirstName1.Text = ""
        tbLastName1.Text = ""
    End Sub

    Private Sub InsertStudentIntoDatabase(studentID As String, firstName As String, lastName As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to insert a new student into the "students" table
                Dim query As String = "INSERT INTO students (student_id, student_fname, student_lname, student_status) VALUES (@StudentID, @FirstName, @LastName, @Status)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@Status", "NOT VOTER")

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Student added successfully to the database.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateStudentInDatabase(studentID As String, firstName As String, lastName As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to update the student's information in the "students" table
                Dim query As String = "UPDATE students SET student_fname = @FirstName, student_lname = @LastName WHERE student_id = @StudentID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)

                    cmd.ExecuteNonQuery()

                    ' Optionally, refresh the DataGridView to reflect changes
                    LoadStudentData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating the student in the database: " & ex.Message)
        End Try
    End Sub
    Private Sub DeleteStudentFromDatabase(studentID As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Begin a database transaction
                Dim transaction As MySqlTransaction = connection.BeginTransaction()

                Try
                    ' SQL query to delete related records in the "candidates" table
                    Dim deleteCandidatesQuery As String = "DELETE FROM candidates WHERE student_id = @StudentID"

                    Using deleteCandidatesCmd As New MySqlCommand(deleteCandidatesQuery, connection, transaction)
                        deleteCandidatesCmd.Parameters.AddWithValue("@StudentID", studentID)

                        ' Execute the deletion of related records in the "candidates" table
                        deleteCandidatesCmd.ExecuteNonQuery()
                    End Using

                    ' SQL query to delete related records in the "voters" table
                    Dim deleteVotersQuery As String = "DELETE FROM voters WHERE student_id = @StudentID"

                    Using deleteVotersCmd As New MySqlCommand(deleteVotersQuery, connection, transaction)
                        deleteVotersCmd.Parameters.AddWithValue("@StudentID", studentID)

                        ' Execute the deletion of related records in the "voters" table
                        deleteVotersCmd.ExecuteNonQuery()
                    End Using

                    ' SQL query to delete the student from the "students" table
                    Dim deleteStudentQuery As String = "DELETE FROM students WHERE student_id = @StudentID"

                    Using deleteStudentCmd As New MySqlCommand(deleteStudentQuery, connection, transaction)
                        deleteStudentCmd.Parameters.AddWithValue("@StudentID", studentID)

                        ' Execute the deletion of the student record
                        deleteStudentCmd.ExecuteNonQuery()

                        ' Commit the transaction to make changes permanent
                        transaction.Commit()

                        MessageBox.Show("Student and related records deleted.")
                        LoadCandidateData()
                        LoadVoterData()
                    End Using
                Catch ex As Exception
                    ' Roll back the transaction if an error occurs
                    transaction.Rollback()
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub candidateData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles candidateData.CellContentClick
        Try
            If candidateData.Columns(e.ColumnIndex).Name = "UpdateCandidate" Then
                ' Check if any rows are selected
                If candidateData.SelectedRows.Count > 0 Then
                    ' Get the first selected row
                    Dim selectedRow As DataGridViewRow = candidateData.SelectedRows(0)

                    ' Get the student ID of the selected row
                    Dim studentID As String = selectedRow.Cells("candidateStudent_id").Value.ToString()

                    ' Get the current values from the DataGridView
                    Dim currentFirstName As String = selectedRow.Cells("candidate_fname").Value.ToString()
                    Dim currentLastName As String = selectedRow.Cells("candidate_lname").Value.ToString()
                    Dim currentPosition As String = selectedRow.Cells("candidate_position").Value.ToString()

                    ' Update the database with the current values
                    UpdateCandidateInDatabase(studentID, currentFirstName, currentLastName, currentPosition)

                    MessageBox.Show("Candidate information updated in the database.")
                Else
                    MessageBox.Show("No Candidate selected.")
                End If
            ElseIf candidateData.Columns(e.ColumnIndex).Name = "DeleteCandidate" Then
                Dim selectedRowIndex As Integer = e.RowIndex
                If selectedRowIndex >= 0 Then
                    ' Get the studentID from the selected row
                    Dim studentID As String = candidateData.Rows(selectedRowIndex).Cells("candidateStudent_id").Value.ToString()

                    ' Delete the selected row from the DataGridView
                    candidateData.Rows.RemoveAt(selectedRowIndex)

                    ' Delete the corresponding record from the database
                    DeleteCandidateInDatabase(studentID)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub addCandidate_Click(sender As Object, e As EventArgs) Handles addCandidate.Click
        Dim studentId As String = tbStudentId.Text
        Dim candidatePosition As String = cbPosition.Text

        ' Validate the input fields
        If String.IsNullOrWhiteSpace(studentId) OrElse String.IsNullOrWhiteSpace(candidatePosition) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Dim candidateImage As Byte() = Nothing

        ' Check if an image file is selected
        If openFileDialog.FileName <> String.Empty Then
            Dim imagePath As String = openFileDialog.FileName

            ' Read the binary data from the selected image
            Using stream As New IO.FileStream(imagePath, IO.FileMode.Open, IO.FileAccess.Read)
                candidateImage = New Byte(stream.Length - 1) {}
                stream.Read(candidateImage, 0, CInt(stream.Length))
            End Using
        Else
            ' Show a message and return if no image is selected
            MessageBox.Show("Please select an image for the candidate.")
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Query to check if student_id already exists in the candidates table
                Dim checkQuery As String = "SELECT COUNT(*) FROM candidates WHERE student_id = @StudentId"

                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@StudentId", studentId)

                    ' Execute the query
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("This student ID already exists in the candidates table.")
                        Return
                    End If
                End Using

                ' Query to retrieve student's data
                Dim studentQuery As String = "SELECT student_fname, student_lname FROM students WHERE student_id = @StudentId"

                Using studentCmd As New MySqlCommand(studentQuery, connection)
                    studentCmd.Parameters.AddWithValue("@StudentId", studentId)

                    Using studentReader As MySqlDataReader = studentCmd.ExecuteReader()
                        If studentReader.Read() Then
                            ' Extract the student's first and last name
                            Dim candidateFname As String = studentReader.GetString(0)
                            Dim candidateLname As String = studentReader.GetString(1)

                            ' Close the DataReader
                            studentReader.Close()

                            ' Create a SQL query to insert the candidate's data into the candidates table
                            Dim query As String = "INSERT INTO candidates (student_id, candidate_fname, candidate_lname, candidate_position, candidate_image) VALUES (@StudentId, @CandidateFName, @CandidateLName, @CandidatePosition, @CandidateImage)"

                            Using cmd As New MySqlCommand(query, connection)
                                cmd.Parameters.AddWithValue("@StudentId", studentId)
                                cmd.Parameters.AddWithValue("@CandidateFName", candidateFname)
                                cmd.Parameters.AddWithValue("@CandidateLName", candidateLname)
                                cmd.Parameters.AddWithValue("@CandidatePosition", candidatePosition)
                                cmd.Parameters.AddWithValue("@CandidateImage", If(candidateImage, DBNull.Value))

                                cmd.ExecuteNonQuery()

                                MessageBox.Show("Candidate added successfully.")
                                tbStudentId.Text = ""
                                cbPosition.SelectedIndex = 0
                                LoadCandidateData()
                                ' Reset the PictureBox to the default image
                                candidateImg.Image = My.Resources.defaultImage
                            End Using
                        Else
                            MessageBox.Show("Student ID not found.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub UpdateCandidateInDatabase(studentID As String, firstName As String, lastName As String, position As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to update the student's information in the "students" table
                Dim query As String = "UPDATE candidates SET candidate_fname = @FirstName, candidate_lname = @LastName, candidate_position = @Position WHERE student_id = @StudentID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@Position", position)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)

                    cmd.ExecuteNonQuery()

                    ' Optionally, refresh the DataGridView to reflect changes
                    LoadCandidateData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating the candidate in the database: " & ex.Message)
        End Try
    End Sub
    Private Sub DeleteCandidateInDatabase(studentID As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to delete a student from the "students" table
                Dim query As String = "DELETE FROM candidates WHERE student_id = @StudentID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Candidate deleted from the database.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub voterData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles voterData.CellContentClick
        Try
            If voterData.Columns(e.ColumnIndex).Name = "UpdateVoter" Then
                ' Check if any rows are selected
                If voterData.SelectedRows.Count > 0 Then
                    ' Get the first selected row
                    Dim selectedRow As DataGridViewRow = voterData.SelectedRows(0)

                    ' Get the student ID of the selected row
                    Dim studentID As String = selectedRow.Cells("voterStudent_id").Value.ToString()

                    ' Get the current values from the DataGridView
                    Dim currentFirstName As String = selectedRow.Cells("voter_fname").Value.ToString()
                    Dim currentLastName As String = selectedRow.Cells("voter_lname").Value.ToString()
                    Dim currentUserName As String = selectedRow.Cells("voter_username").Value.ToString()

                    ' Update the database with the current values
                    UpdateVoterInDatabase(studentID, currentFirstName, currentLastName, currentUserName)

                    MessageBox.Show("Voter information updated in the database.")
                Else
                    MessageBox.Show("No Voter selected.")
                End If
            ElseIf voterData.Columns(e.ColumnIndex).Name = "DeleteVoter" Then
                Dim selectedRowIndex As Integer = e.RowIndex
                If selectedRowIndex >= 0 Then
                    ' Get the studentID from the selected row
                    Dim studentID As String = voterData.Rows(selectedRowIndex).Cells("voterStudent_id").Value.ToString()

                    ' Delete the selected row from the DataGridView
                    voterData.Rows.RemoveAt(selectedRowIndex)

                    ' Delete the corresponding record from the database
                    DeleteVoterInDatabase(studentID)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateVoterInDatabase(studentID As String, firstName As String, lastName As String, userName As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to update the student's information in the "students" table
                Dim query As String = "UPDATE voters SET voter_fname = @FirstName, voter_lname = @LastName, voter_username = @Username WHERE student_id = @StudentID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@Username", userName)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)

                    cmd.ExecuteNonQuery()

                    ' Optionally, refresh the DataGridView to reflect changes
                    LoadVoterData()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating the voter in the database: " & ex.Message)
        End Try
    End Sub
    Private Sub DeleteVoterInDatabase(studentID As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to delete a student from the "students" table
                Dim query As String = "DELETE FROM voters WHERE student_id = @StudentID"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Voter deleted from the database.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateElectionStatus(status As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to update the election status
                Dim query As String = "UPDATE election SET election_status = @Status"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.ExecuteNonQuery()
                End Using

                ' Check the updated status and set the button text
                If status = "ONGOING" Then
                    electionBtn.Text = "End Election"
                Else
                    electionBtn.Text = "Start Election"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating election status: " & ex.Message)
        End Try
    End Sub

    Private Sub electionBtn_Click(sender As Object, e As EventArgs) Handles electionBtn.Click
        Dim currentStatus As String = GetElectionStatus()

        If currentStatus = "ONGOING" Then
            ' End the election
            UpdateElectionStatus("ENDED")

            ' Determine the winner and insert into the result table
            DetermineAndInsertWinners()
        Else
            ' Start the election
            UpdateElectionStatus("ONGOING")
        End If
    End Sub

    Private Sub DetermineAndInsertWinners()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' List of positions to determine winners for
                Dim positions As String() = {"President", "Vice President", "Secretary", "Treasurer", "Auditor", "Business Manager", "Representative", "Cabinet Member"}

                For Each position As String In positions
                    Dim query As String = "SELECT c.candidate_image, c.candidate_fname, c.candidate_lname, @Position AS winner_position, COUNT(vc.voted_" & position.Replace(" ", "") & ") AS vote_count " &
                        "FROM candidates c " &
                        "LEFT JOIN votecount vc ON CONCAT(c.candidate_fname, ' ', c.candidate_lname) = vc.voted_" & position.Replace(" ", "") & " " &
                        "WHERE c.candidate_position = @Position " &
                        "GROUP BY c.candidate_fname, c.candidate_lname, c.candidate_image " &
                        "ORDER BY vote_count DESC"

                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@Position", position)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim winnerName As String = $"{reader.GetString("candidate_fname")} {reader.GetString("candidate_lname")}"
                                Dim voteCount As Integer = reader.GetInt32("vote_count")
                                Dim winnerPosition As String = reader.GetString("winner_position")

                                ' Insert the winner's information into the result table
                                InsertWinnerIntoResultTable(winnerPosition, winnerName, voteCount)
                            End If
                        End Using
                    End Using
                Next
            End Using

            ' After inserting winners for all positions, refresh the winner data grid
            LoadWinnerData()
        Catch ex As Exception
            MessageBox.Show("Error determining and inserting winners: " & ex.Message)
        End Try
    End Sub

    Private Sub InsertWinnerIntoResultTable(position As String, winnerName As String, voteCount As Integer)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to insert the winner into the result table with the current date
                Dim query As String = "INSERT INTO result (winner_position, winner_name, vote_count, election_date) " &
                        "VALUES (@WinnerPosition, @WinnerName, @VoteCount, CURDATE())"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@WinnerPosition", position)
                    cmd.Parameters.AddWithValue("@WinnerName", winnerName)
                    cmd.Parameters.AddWithValue("@VoteCount", voteCount)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting the winner into the result table: " & ex.Message)
        End Try
    End Sub

    Private Function GetElectionStatus() As String
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' SQL query to retrieve the election status
                Dim query As String = "SELECT election_status FROM election"

                Using cmd As New MySqlCommand(query, connection)
                    Dim electionStatus As String = Convert.ToString(cmd.ExecuteScalar())
                    Return electionStatus
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting election status: " & ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Sub searchStudentBtn_Click(sender As Object, e As EventArgs) Handles searchStudentBtn.Click
        ' Retrieve the search input from the TextBox
        Dim searchKeyword As String = tbStudentSearchBox.Text

        ' Define the search query
        Dim searchQuery As String = "SELECT * FROM students WHERE CONCAT(student_id, student_fname, student_lname) LIKE '%" & searchKeyword & "%'"

        ' Create a MySqlConnection
        Using connection As New MySqlConnection(connectionString)
            Try
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand
                Using command As New MySqlCommand(searchQuery, connection)
                    ' Create a MySqlDataAdapter to execute the query and fill the DataTable
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        If table.Rows.Count = 0 Then
                            ' No matching records found, show a message box
                            MessageBox.Show("No matching records found.")
                        Else
                            ' Bind the search results to the DataGridView or any other data-bound control
                            studentData.DataSource = table
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error searching for students: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub displayStudentBtn_Click(sender As Object, e As EventArgs) Handles displayStudentBtn.Click
        LoadStudentData()
    End Sub

    Private Sub searchCandidateBtn_Click(sender As Object, e As EventArgs) Handles searchCandidateBtn.Click
        ' Retrieve the search input from the TextBox
        Dim searchKeyword As String = tbCandidateSearchBox.Text

        ' Define the search query
        Dim searchQuery As String = "SELECT * FROM candidates WHERE CONCAT(candidate_id, candidate_fname, candidate_lname, student_id) LIKE '%" & searchKeyword & "%'"

        ' Create a MySqlConnection
        Using connection As New MySqlConnection(connectionString)
            Try
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand
                Using command As New MySqlCommand(searchQuery, connection)
                    ' Create a MySqlDataAdapter to execute the query and fill the DataTable
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        If table.Rows.Count = 0 Then
                            ' No matching records found, show a message box
                            MessageBox.Show("No matching records found.")
                        Else
                            ' Bind the search results to the DataGridView or any other data-bound control
                            candidateData.DataSource = table
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error searching for candidates: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub displayCandidateBtn_Click(sender As Object, e As EventArgs) Handles displayCandidateBtn.Click
        LoadCandidateData()
    End Sub

    Private Sub searchVoterBtn_Click(sender As Object, e As EventArgs) Handles searchVoterBtn.Click
        ' Retrieve the search input from the TextBox
        Dim searchKeyword As String = tbVoterSearchBox.Text

        ' Define the search query
        Dim searchQuery As String = "SELECT * FROM voters WHERE CONCAT(voter_id, voter_fname, voter_lname, voter_username, student_id) LIKE '%" & searchKeyword & "%'"

        ' Create a MySqlConnection
        Using connection As New MySqlConnection(connectionString)
            Try
                ' Open the connection
                connection.Open()

                ' Create a MySqlCommand
                Using command As New MySqlCommand(searchQuery, connection)
                    ' Create a MySqlDataAdapter to execute the query and fill the DataTable
                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        If table.Rows.Count = 0 Then
                            ' No matching records found, show a message box
                            MessageBox.Show("No matching records found.")
                        Else
                            ' Bind the search results to the DataGridView or any other data-bound control
                            voterData.DataSource = table
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error searching for voters: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub displayVoterBtn_Click(sender As Object, e As EventArgs) Handles displayVoterBtn.Click
        LoadVoterData()
    End Sub
End Class
