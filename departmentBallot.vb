Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class departmentBallot
    Public Property LoggedInUsername As String
    Private connectionString As String = "Data Source=localhost;database=e-voting_db;user=root;password="

    Private Sub ballotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide tab buttons
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        CheckVotingStatus()
        LoadCandidatesByPosition("PRESIDENT", presidentPanel)
        LoadCandidatesByPosition("VICE PRESIDENT", vicePresidentPanel)
        LoadCandidatesByPosition("SECRETARY", secretaryPanel)
        LoadCandidatesByPosition("TREASURER", treasurerPanel)
        LoadCandidatesByPosition("AUDITOR", auditorPanel)
        LoadCandidatesByPosition("BUSINESS MANAGER", bmPanel)
        LoadCandidatesByPosition("REPRESENTATIVE", repPanel)
        LoadCandidatesByPosition("CABINET MEMBER", cabinetPanel)
        LoadPresidentCandidates()
        LoadVicePresidentCandidates()
        LoadSecretaryCandidates()
        LoadTreasurerCandidates()
        LoadAuditorCandidates()
        LoadBusinessManagerCandidates()
        LoadRepresentativesCandidates()
        LoadCabinetMemberCandidates()
    End Sub

    Private Sub CheckVotingStatus()
        ' Check the voting status of the logged-in user
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim checkStatusQuery As String = "SELECT voting_status FROM voters WHERE voter_username = @Username"
            Using cmd As New MySqlCommand(checkStatusQuery, connection)
                cmd.Parameters.AddWithValue("@Username", LoggedInUsername)
                Dim votingStatus As String = cmd.ExecuteScalar().ToString()

                If votingStatus = "DONE" Then
                    TabControl1.SelectedIndex = 1

                    ' Dictionary to map positions to labels
                    Dim positionLabels As Dictionary(Of String, Label) = New Dictionary(Of String, Label) From {
                    {"voted_president", lblPresident},
                    {"voted_vicePresident", lblVicePresident},
                    {"voted_secretary", lblSecretary},
                    {"voted_treasurer", lblTreasurer},
                    {"voted_auditor", lblAuditor},
                    {"voted_businessManager", lblBusinessManager},
                    {"voted_representative", lblRepresentative},
                    {"voted_cabinetMember", lblCabinetMember}
                }

                    ' Create a connection to the database
                    Using dbConnection As New MySqlConnection(connectionString) ' Rename the inner connection variable
                        dbConnection.Open()

                        ' Iterate through the positions and retrieve the candidate names
                        For Each position As String In positionLabels.Keys
                            Dim query As String = "SELECT " & position & " FROM votecount WHERE " & position & " IS NOT NULL AND voter_username = @Username"

                            Using command As New MySqlCommand(query, dbConnection) ' Use the inner connection here
                                command.Parameters.AddWithValue("@Username", LoggedInUsername)

                                Using reader As MySqlDataReader = command.ExecuteReader()
                                    If reader.Read() Then
                                        Dim candidateName As String = reader(position).ToString()
                                        If positionLabels.ContainsKey(position) Then
                                            positionLabels(position).Text = candidateName
                                        End If
                                    End If
                                End Using
                            End Using
                        Next
                    End Using
                End If
            End Using
        End Using
    End Sub


    Private Sub LoadCandidatesByPosition(position As String, containerPanel As Panel)
        ' Clear the existing controls in the specified panel
        containerPanel.Controls.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_image, candidate_fname, candidate_lname, candidate_position FROM candidates WHERE candidate_position = @Position"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Position", position)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Retrieve candidate data
                        Dim candidateImage As Byte() = DirectCast(reader("candidate_image"), Byte())
                        Dim candidateFName As String = reader("candidate_fname").ToString()
                        Dim candidateLName As String = reader("candidate_lname").ToString()
                        Dim candidatePosition As String = reader("candidate_position").ToString()

                        ' Create PictureBox
                        Dim pictureBox As New PictureBox()
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                        pictureBox.Width = 80 ' Set your desired width
                        pictureBox.Height = 80 ' Set your desired height
                        pictureBox.Location = New Point(25, 0)
                        pictureBox.Image = Image.FromStream(New MemoryStream(candidateImage))

                        ' Create Label
                        Dim lblName As New Label()
                        lblName.AutoSize = True
                        lblName.Text = $"{candidateFName} {candidateLName}"
                        lblName.Font = New Font("Arial", 10) ' Set your desired font
                        lblName.Location = New Point(0, 80)
                        lblName.TextAlign = ContentAlignment.MiddleCenter

                        Dim lblPosition As New Label()
                        lblPosition.AutoSize = True
                        lblPosition.Text = candidatePosition
                        lblPosition.Font = New Font("Arial", 8, FontStyle.Bold)
                        lblPosition.Location = New Point(0, 100)
                        lblPosition.TextAlign = ContentAlignment.MiddleCenter

                        ' Create Panel for components
                        Dim objectPanel As New Panel()
                        objectPanel.AutoSize = True
                        objectPanel.Controls.Add(pictureBox)
                        objectPanel.Controls.Add(lblName)
                        objectPanel.Controls.Add(lblPosition)

                        ' Add the objectPanel to the specified container panel
                        containerPanel.Controls.Add(objectPanel)
                    End While
                End Using
            End Using
        End Using
    End Sub
    ' Load the candidates with a 'PRESIDENT' position into the ComboBox
    Private Sub LoadPresidentCandidates()
        ' Clear the ComboBox
        cbPresident.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'PRESIDENT'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Concatenate the first and last names and add them to the ComboBox
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbPresident.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub
    ' Load the candidates with a 'VICE PRESIDENT' position into the ComboBox
    Private Sub LoadVicePresidentCandidates()
        cbVicePresident.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'VICE PRESIDENT'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbVicePresident.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Load the candidates with a 'SECRETARY' position into the ComboBox
    Private Sub LoadSecretaryCandidates()
        cbSecretary.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'SECRETARY'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbSecretary.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Load the candidates with a 'TREASURER' position into the ComboBox
    Private Sub LoadTreasurerCandidates()
        cbTreasurer.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'TREASURER'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbTreasurer.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Load the candidates with an 'AUDITOR' position into the ComboBox
    Private Sub LoadAuditorCandidates()
        cbAuditor.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'AUDITOR'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbAuditor.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Load the candidates with an 'BUSINESS MANAGER' position into the ComboBox
    Private Sub LoadBusinessManagerCandidates()
        cbBusinessManager.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'BUSINESS MANAGER'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbBusinessManager.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Load the candidates with an 'REPRESENTATIVE' position into the ComboBox
    Private Sub LoadRepresentativesCandidates()
        cbRep.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'REPRESENTATIVE'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbRep.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Load the candidates with an 'CABINET MEMBER' position into the ComboBox
    Private Sub LoadCabinetMemberCandidates()
        cbCabinetMember.Items.Clear()

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT candidate_fname, candidate_lname FROM candidates WHERE candidate_position = 'CABINET MEMBER'"

            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim candidateName As String = $"{reader("candidate_fname")} {reader("candidate_lname")}"
                        cbCabinetMember.Items.Add(candidateName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cbPresident_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPresident.SelectedIndexChanged
        Dim selectedCandidateName As String = cbPresident.SelectedItem.ToString()
    End Sub

    Private Sub cbVicePresident_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVicePresident.SelectedIndexChanged
        Dim selectedCandidateName As String = cbVicePresident.SelectedItem.ToString()
    End Sub

    Private Sub cbSecretary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSecretary.SelectedIndexChanged
        Dim selectedCandidateName As String = cbSecretary.SelectedItem.ToString()
    End Sub

    Private Sub cbTreasurer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTreasurer.SelectedIndexChanged
        Dim selectedCandidateName As String = cbTreasurer.SelectedItem.ToString()
    End Sub

    Private Sub cbAuditor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAuditor.SelectedIndexChanged
        Dim selectedCandidateName As String = cbAuditor.SelectedItem.ToString()
    End Sub

    Private Sub cbBusinessManager_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBusinessManager.SelectedIndexChanged
        Dim selectedCandidateName As String = cbBusinessManager.SelectedItem.ToString()
    End Sub

    Private Sub cbRep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRep.SelectedIndexChanged
        Dim selectedCandidateName As String = cbRep.SelectedItem.ToString()
    End Sub

    Private Sub cbCabinetMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCabinetMember.SelectedIndexChanged
        Dim selectedCandidateName As String = cbCabinetMember.SelectedItem.ToString()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub ViewResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewResultToolStripMenuItem.Click
        resultsForm.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        resultsForm.Show()
    End Sub

    Private Sub voteBtn_Click(sender As Object, e As EventArgs) Handles voteBtn.Click
        ' Get the selected values from the ComboBoxes
        Dim president As String = cbPresident.SelectedItem?.ToString()
        Dim vicePresident As String = cbVicePresident.SelectedItem?.ToString()
        Dim secretary As String = cbSecretary.SelectedItem?.ToString()
        Dim treasurer As String = cbTreasurer.SelectedItem?.ToString()
        Dim auditor As String = cbAuditor.SelectedItem?.ToString()
        Dim businessManager As String = cbBusinessManager.SelectedItem?.ToString()
        Dim representative As String = cbRep.SelectedItem?.ToString()
        Dim cabinetMember As String = cbCabinetMember.SelectedItem?.ToString()

        ' Check if any ComboBox is empty
        If String.IsNullOrEmpty(president) OrElse
           String.IsNullOrEmpty(vicePresident) OrElse
           String.IsNullOrEmpty(secretary) OrElse
           String.IsNullOrEmpty(treasurer) OrElse
           String.IsNullOrEmpty(auditor) OrElse
           String.IsNullOrEmpty(businessManager) OrElse
           String.IsNullOrEmpty(representative) OrElse
           String.IsNullOrEmpty(cabinetMember) Then
            MessageBox.Show("Please select a candidate for each position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to cast your vote with these selections?", "Confirm Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmation = DialogResult.Yes Then
                ' The user confirmed their vote, proceed to record the vote
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO votecount (voted_president, voted_vicePresident, voted_secretary, voted_treasurer, voted_auditor, voted_businessManager, voted_representative, voted_cabinetMember, voter_username) VALUES (@President, @VicePresident, @Secretary, @Treasurer, @Auditor, @BusinessManager, @Representative, @CabinetMember, @Username)"

                    Using cmd As New MySqlCommand(query, connection)
                        ' Replace "username" with the actual username variable or property that contains the logged-in username.
                        cmd.Parameters.AddWithValue("@Username", LoggedInUsername)
                        cmd.Parameters.AddWithValue("@President", president)
                        cmd.Parameters.AddWithValue("@VicePresident", vicePresident)
                        cmd.Parameters.AddWithValue("@Secretary", secretary)
                        cmd.Parameters.AddWithValue("@Treasurer", treasurer)
                        cmd.Parameters.AddWithValue("@Auditor", auditor)
                        cmd.Parameters.AddWithValue("@BusinessManager", businessManager)
                        cmd.Parameters.AddWithValue("@Representative", representative)
                        cmd.Parameters.AddWithValue("@CabinetMember", cabinetMember)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Your vote has been recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim updateStatusQuery As String = "UPDATE voters SET voting_status = 'DONE', vote_date = CURDATE() WHERE voter_username = @Username"
                        Using updateCmd As New MySqlCommand(updateStatusQuery, connection)
                            updateCmd.Parameters.AddWithValue("@Username", LoggedInUsername)
                            updateCmd.ExecuteNonQuery()
                            CheckVotingStatus()
                        End Using
                    End Using
                End Using
            Else
                ' The user decided not to cast the vote
                ' You can handle this case as needed
            End If
        End If
    End Sub
End Class
