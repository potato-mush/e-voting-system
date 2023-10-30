<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.displayStudentBtn = New System.Windows.Forms.Button()
        Me.searchStudentBtn = New System.Windows.Forms.Button()
        Me.tbStudentSearchBox = New System.Windows.Forms.TextBox()
        Me.addStudentBtn = New System.Windows.Forms.Button()
        Me.tbLastName1 = New System.Windows.Forms.TextBox()
        Me.tbFirstName1 = New System.Windows.Forms.TextBox()
        Me.tbStudentID1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentData = New System.Windows.Forms.DataGridView()
        Me.student_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateStudent = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteStudent = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.displayCandidateBtn = New System.Windows.Forms.Button()
        Me.searchCandidateBtn = New System.Windows.Forms.Button()
        Me.tbCandidateSearchBox = New System.Windows.Forms.TextBox()
        Me.candidateImg = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addCandidate = New System.Windows.Forms.Button()
        Me.cbPosition = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbStudentId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.candidateData = New System.Windows.Forms.DataGridView()
        Me.candidate_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.candidate_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.candidate_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.candidate_position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.candidateStudent_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateCandidate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteCandidate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.displayVoterBtn = New System.Windows.Forms.Button()
        Me.searchVoterBtn = New System.Windows.Forms.Button()
        Me.tbVoterSearchBox = New System.Windows.Forms.TextBox()
        Me.voterData = New System.Windows.Forms.DataGridView()
        Me.voter_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voter_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voter_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voter_username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voting_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vote_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voterStudent_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateVoter = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteVoter = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.winnerData = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.electionBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.voterBtn = New System.Windows.Forms.Button()
        Me.candidateBtn = New System.Windows.Forms.Button()
        Me.studentBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.studentData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.candidateImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.candidateData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.voterData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.winnerData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 572)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 151)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(886, 421)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.displayStudentBtn)
        Me.TabPage1.Controls.Add(Me.searchStudentBtn)
        Me.TabPage1.Controls.Add(Me.tbStudentSearchBox)
        Me.TabPage1.Controls.Add(Me.addStudentBtn)
        Me.TabPage1.Controls.Add(Me.tbLastName1)
        Me.TabPage1.Controls.Add(Me.tbFirstName1)
        Me.TabPage1.Controls.Add(Me.tbStudentID1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.studentData)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(878, 395)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'displayStudentBtn
        '
        Me.displayStudentBtn.Location = New System.Drawing.Point(513, 10)
        Me.displayStudentBtn.Name = "displayStudentBtn"
        Me.displayStudentBtn.Size = New System.Drawing.Size(75, 20)
        Me.displayStudentBtn.TabIndex = 10
        Me.displayStudentBtn.Text = "Display All"
        Me.displayStudentBtn.UseVisualStyleBackColor = True
        '
        'searchStudentBtn
        '
        Me.searchStudentBtn.Location = New System.Drawing.Point(432, 10)
        Me.searchStudentBtn.Name = "searchStudentBtn"
        Me.searchStudentBtn.Size = New System.Drawing.Size(75, 20)
        Me.searchStudentBtn.TabIndex = 9
        Me.searchStudentBtn.Text = "Search"
        Me.searchStudentBtn.UseVisualStyleBackColor = True
        '
        'tbStudentSearchBox
        '
        Me.tbStudentSearchBox.Location = New System.Drawing.Point(8, 10)
        Me.tbStudentSearchBox.Name = "tbStudentSearchBox"
        Me.tbStudentSearchBox.Size = New System.Drawing.Size(418, 20)
        Me.tbStudentSearchBox.TabIndex = 8
        '
        'addStudentBtn
        '
        Me.addStudentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStudentBtn.Location = New System.Drawing.Point(671, 306)
        Me.addStudentBtn.Name = "addStudentBtn"
        Me.addStudentBtn.Size = New System.Drawing.Size(115, 38)
        Me.addStudentBtn.TabIndex = 7
        Me.addStudentBtn.Text = "ADD"
        Me.addStudentBtn.UseVisualStyleBackColor = True
        '
        'tbLastName1
        '
        Me.tbLastName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLastName1.Location = New System.Drawing.Point(624, 239)
        Me.tbLastName1.Name = "tbLastName1"
        Me.tbLastName1.Size = New System.Drawing.Size(225, 22)
        Me.tbLastName1.TabIndex = 6
        '
        'tbFirstName1
        '
        Me.tbFirstName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFirstName1.Location = New System.Drawing.Point(624, 160)
        Me.tbFirstName1.Name = "tbFirstName1"
        Me.tbFirstName1.Size = New System.Drawing.Size(225, 22)
        Me.tbFirstName1.TabIndex = 5
        '
        'tbStudentID1
        '
        Me.tbStudentID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStudentID1.Location = New System.Drawing.Point(623, 81)
        Me.tbStudentID1.Name = "tbStudentID1"
        Me.tbStudentID1.Size = New System.Drawing.Size(225, 22)
        Me.tbStudentID1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(620, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(620, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(619, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Student ID"
        '
        'studentData
        '
        Me.studentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.student_id, Me.student_fname, Me.student_lname, Me.student_status, Me.UpdateStudent, Me.DeleteStudent})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentData.DefaultCellStyle = DataGridViewCellStyle2
        Me.studentData.Location = New System.Drawing.Point(3, 36)
        Me.studentData.Name = "studentData"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.studentData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.studentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.studentData.Size = New System.Drawing.Size(585, 356)
        Me.studentData.TabIndex = 0
        '
        'student_id
        '
        Me.student_id.DataPropertyName = "student_id"
        Me.student_id.HeaderText = "Student ID"
        Me.student_id.Name = "student_id"
        '
        'student_fname
        '
        Me.student_fname.DataPropertyName = "student_fname"
        Me.student_fname.HeaderText = "First Name"
        Me.student_fname.Name = "student_fname"
        '
        'student_lname
        '
        Me.student_lname.DataPropertyName = "student_lname"
        Me.student_lname.HeaderText = "Last Name"
        Me.student_lname.Name = "student_lname"
        '
        'student_status
        '
        Me.student_status.DataPropertyName = "student_status"
        Me.student_status.HeaderText = "Status"
        Me.student_status.Name = "student_status"
        '
        'UpdateStudent
        '
        Me.UpdateStudent.HeaderText = "Update"
        Me.UpdateStudent.Name = "UpdateStudent"
        Me.UpdateStudent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UpdateStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UpdateStudent.Text = ""
        Me.UpdateStudent.UseColumnTextForButtonValue = True
        '
        'DeleteStudent
        '
        Me.DeleteStudent.HeaderText = "Delete"
        Me.DeleteStudent.Name = "DeleteStudent"
        Me.DeleteStudent.Text = ""
        Me.DeleteStudent.UseColumnTextForButtonValue = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.displayCandidateBtn)
        Me.TabPage2.Controls.Add(Me.searchCandidateBtn)
        Me.TabPage2.Controls.Add(Me.tbCandidateSearchBox)
        Me.TabPage2.Controls.Add(Me.candidateImg)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.addCandidate)
        Me.TabPage2.Controls.Add(Me.cbPosition)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.tbStudentId)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.candidateData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(878, 395)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'displayCandidateBtn
        '
        Me.displayCandidateBtn.Location = New System.Drawing.Point(513, 10)
        Me.displayCandidateBtn.Name = "displayCandidateBtn"
        Me.displayCandidateBtn.Size = New System.Drawing.Size(75, 20)
        Me.displayCandidateBtn.TabIndex = 13
        Me.displayCandidateBtn.Text = "Display All"
        Me.displayCandidateBtn.UseVisualStyleBackColor = True
        '
        'searchCandidateBtn
        '
        Me.searchCandidateBtn.Location = New System.Drawing.Point(432, 10)
        Me.searchCandidateBtn.Name = "searchCandidateBtn"
        Me.searchCandidateBtn.Size = New System.Drawing.Size(75, 20)
        Me.searchCandidateBtn.TabIndex = 12
        Me.searchCandidateBtn.Text = "Search"
        Me.searchCandidateBtn.UseVisualStyleBackColor = True
        '
        'tbCandidateSearchBox
        '
        Me.tbCandidateSearchBox.Location = New System.Drawing.Point(8, 10)
        Me.tbCandidateSearchBox.Name = "tbCandidateSearchBox"
        Me.tbCandidateSearchBox.Size = New System.Drawing.Size(418, 20)
        Me.tbCandidateSearchBox.TabIndex = 11
        '
        'candidateImg
        '
        Me.candidateImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.candidateImg.Image = CType(resources.GetObject("candidateImg.Image"), System.Drawing.Image)
        Me.candidateImg.Location = New System.Drawing.Point(690, 16)
        Me.candidateImg.Name = "candidateImg"
        Me.candidateImg.Size = New System.Drawing.Size(100, 100)
        Me.candidateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.candidateImg.TabIndex = 10
        Me.candidateImg.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(704, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Select Image"
        '
        'addCandidate
        '
        Me.addCandidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.addCandidate.Location = New System.Drawing.Point(708, 312)
        Me.addCandidate.Name = "addCandidate"
        Me.addCandidate.Size = New System.Drawing.Size(115, 38)
        Me.addCandidate.TabIndex = 7
        Me.addCandidate.Text = "Add"
        Me.addCandidate.UseVisualStyleBackColor = True
        '
        'cbPosition
        '
        Me.cbPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cbPosition.FormattingEnabled = True
        Me.cbPosition.Location = New System.Drawing.Point(697, 231)
        Me.cbPosition.Name = "cbPosition"
        Me.cbPosition.Size = New System.Drawing.Size(159, 24)
        Me.cbPosition.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(603, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Position"
        '
        'tbStudentId
        '
        Me.tbStudentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbStudentId.Location = New System.Drawing.Point(697, 171)
        Me.tbStudentId.Name = "tbStudentId"
        Me.tbStudentId.Size = New System.Drawing.Size(159, 22)
        Me.tbStudentId.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(603, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID"
        '
        'candidateData
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.candidateData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.candidateData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.candidateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.candidateData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.candidate_id, Me.candidate_fname, Me.candidate_lname, Me.candidate_position, Me.candidateStudent_id, Me.UpdateCandidate, Me.DeleteCandidate})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.candidateData.DefaultCellStyle = DataGridViewCellStyle7
        Me.candidateData.Location = New System.Drawing.Point(3, 36)
        Me.candidateData.Name = "candidateData"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.candidateData.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.candidateData.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.candidateData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.candidateData.Size = New System.Drawing.Size(585, 356)
        Me.candidateData.TabIndex = 0
        '
        'candidate_id
        '
        Me.candidate_id.DataPropertyName = "candidate_id"
        Me.candidate_id.HeaderText = "Candidate ID"
        Me.candidate_id.Name = "candidate_id"
        Me.candidate_id.Width = 60
        '
        'candidate_fname
        '
        Me.candidate_fname.DataPropertyName = "candidate_fname"
        Me.candidate_fname.HeaderText = "First Name"
        Me.candidate_fname.Name = "candidate_fname"
        '
        'candidate_lname
        '
        Me.candidate_lname.DataPropertyName = "candidate_lname"
        Me.candidate_lname.HeaderText = "Last Name"
        Me.candidate_lname.Name = "candidate_lname"
        '
        'candidate_position
        '
        Me.candidate_position.DataPropertyName = "candidate_position"
        Me.candidate_position.HeaderText = "Position"
        Me.candidate_position.Name = "candidate_position"
        '
        'candidateStudent_id
        '
        Me.candidateStudent_id.DataPropertyName = "student_id"
        Me.candidateStudent_id.HeaderText = "Student ID"
        Me.candidateStudent_id.Name = "candidateStudent_id"
        '
        'UpdateCandidate
        '
        Me.UpdateCandidate.HeaderText = "Update"
        Me.UpdateCandidate.Name = "UpdateCandidate"
        Me.UpdateCandidate.Text = ""
        Me.UpdateCandidate.Width = 60
        '
        'DeleteCandidate
        '
        Me.DeleteCandidate.HeaderText = "Delete"
        Me.DeleteCandidate.Name = "DeleteCandidate"
        Me.DeleteCandidate.Text = ""
        Me.DeleteCandidate.Width = 60
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.displayVoterBtn)
        Me.TabPage3.Controls.Add(Me.searchVoterBtn)
        Me.TabPage3.Controls.Add(Me.tbVoterSearchBox)
        Me.TabPage3.Controls.Add(Me.voterData)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(878, 395)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'displayVoterBtn
        '
        Me.displayVoterBtn.Location = New System.Drawing.Point(513, 10)
        Me.displayVoterBtn.Name = "displayVoterBtn"
        Me.displayVoterBtn.Size = New System.Drawing.Size(75, 20)
        Me.displayVoterBtn.TabIndex = 16
        Me.displayVoterBtn.Text = "Display All"
        Me.displayVoterBtn.UseVisualStyleBackColor = True
        '
        'searchVoterBtn
        '
        Me.searchVoterBtn.Location = New System.Drawing.Point(432, 10)
        Me.searchVoterBtn.Name = "searchVoterBtn"
        Me.searchVoterBtn.Size = New System.Drawing.Size(75, 20)
        Me.searchVoterBtn.TabIndex = 15
        Me.searchVoterBtn.Text = "Search"
        Me.searchVoterBtn.UseVisualStyleBackColor = True
        '
        'tbVoterSearchBox
        '
        Me.tbVoterSearchBox.Location = New System.Drawing.Point(8, 10)
        Me.tbVoterSearchBox.Name = "tbVoterSearchBox"
        Me.tbVoterSearchBox.Size = New System.Drawing.Size(418, 20)
        Me.tbVoterSearchBox.TabIndex = 14
        '
        'voterData
        '
        Me.voterData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.voterData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.voterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.voterData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.voter_id, Me.voter_fname, Me.voter_lname, Me.voter_username, Me.voting_status, Me.vote_date, Me.voterStudent_id, Me.UpdateVoter, Me.DeleteVoter})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.voterData.DefaultCellStyle = DataGridViewCellStyle11
        Me.voterData.Location = New System.Drawing.Point(3, 36)
        Me.voterData.Name = "voterData"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.voterData.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.voterData.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.voterData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.voterData.Size = New System.Drawing.Size(872, 356)
        Me.voterData.TabIndex = 0
        '
        'voter_id
        '
        Me.voter_id.DataPropertyName = "voter_id"
        Me.voter_id.FillWeight = 60.41463!
        Me.voter_id.HeaderText = "Voter ID"
        Me.voter_id.Name = "voter_id"
        '
        'voter_fname
        '
        Me.voter_fname.DataPropertyName = "voter_fname"
        Me.voter_fname.FillWeight = 60.41463!
        Me.voter_fname.HeaderText = "First Name"
        Me.voter_fname.Name = "voter_fname"
        '
        'voter_lname
        '
        Me.voter_lname.DataPropertyName = "voter_lname"
        Me.voter_lname.FillWeight = 60.41463!
        Me.voter_lname.HeaderText = "Last Name"
        Me.voter_lname.Name = "voter_lname"
        '
        'voter_username
        '
        Me.voter_username.DataPropertyName = "voter_username"
        Me.voter_username.FillWeight = 60.41463!
        Me.voter_username.HeaderText = "Username"
        Me.voter_username.Name = "voter_username"
        '
        'voting_status
        '
        Me.voting_status.DataPropertyName = "voting_status"
        Me.voting_status.FillWeight = 60.41463!
        Me.voting_status.HeaderText = "Voting Status"
        Me.voting_status.Name = "voting_status"
        '
        'vote_date
        '
        Me.vote_date.DataPropertyName = "vote_date"
        Me.vote_date.FillWeight = 60.41463!
        Me.vote_date.HeaderText = "Vote Date"
        Me.vote_date.Name = "vote_date"
        '
        'voterStudent_id
        '
        Me.voterStudent_id.DataPropertyName = "student_id"
        Me.voterStudent_id.FillWeight = 60.41463!
        Me.voterStudent_id.HeaderText = "Student ID"
        Me.voterStudent_id.Name = "voterStudent_id"
        '
        'UpdateVoter
        '
        Me.UpdateVoter.FillWeight = 60.41463!
        Me.UpdateVoter.HeaderText = "Update"
        Me.UpdateVoter.Name = "UpdateVoter"
        '
        'DeleteVoter
        '
        Me.DeleteVoter.FillWeight = 60.41463!
        Me.DeleteVoter.HeaderText = "Delete"
        Me.DeleteVoter.Name = "DeleteVoter"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.winnerData)
        Me.TabPage4.Controls.Add(Me.electionBtn)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(878, 395)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        '
        'winnerData
        '
        Me.winnerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.winnerData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.winnerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.winnerData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.winnerData.DefaultCellStyle = DataGridViewCellStyle15
        Me.winnerData.Dock = System.Windows.Forms.DockStyle.Top
        Me.winnerData.Location = New System.Drawing.Point(3, 3)
        Me.winnerData.Name = "winnerData"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.winnerData.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.winnerData.RowsDefaultCellStyle = DataGridViewCellStyle17
        Me.winnerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.winnerData.Size = New System.Drawing.Size(872, 234)
        Me.winnerData.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "winner_id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 93.27411!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Winner ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "winner_name"
        Me.DataGridViewTextBoxColumn2.FillWeight = 93.27411!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Candidate Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "winner_position"
        Me.DataGridViewTextBoxColumn3.FillWeight = 93.27411!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vote_count"
        Me.DataGridViewTextBoxColumn4.FillWeight = 93.27411!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vote Count"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "election_date"
        Me.DataGridViewTextBoxColumn5.FillWeight = 93.27411!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Election Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'electionBtn
        '
        Me.electionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.electionBtn.FlatAppearance.BorderSize = 0
        Me.electionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.electionBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.electionBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.electionBtn.Location = New System.Drawing.Point(351, 315)
        Me.electionBtn.Name = "electionBtn"
        Me.electionBtn.Size = New System.Drawing.Size(176, 41)
        Me.electionBtn.TabIndex = 4
        Me.electionBtn.Text = "Start Election"
        Me.electionBtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.Panel3.Controls.Add(Me.logoutBtn)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.voterBtn)
        Me.Panel3.Controls.Add(Me.candidateBtn)
        Me.Panel3.Controls.Add(Me.studentBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(886, 51)
        Me.Panel3.TabIndex = 1
        '
        'logoutBtn
        '
        Me.logoutBtn.FlatAppearance.BorderSize = 0
        Me.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.LightCoral
        Me.logoutBtn.Location = New System.Drawing.Point(787, 0)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(99, 51)
        Me.logoutBtn.TabIndex = 4
        Me.logoutBtn.Text = "Log Out"
        Me.logoutBtn.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(375, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Election"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'voterBtn
        '
        Me.voterBtn.FlatAppearance.BorderSize = 0
        Me.voterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.voterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.voterBtn.Location = New System.Drawing.Point(250, 0)
        Me.voterBtn.Name = "voterBtn"
        Me.voterBtn.Size = New System.Drawing.Size(125, 51)
        Me.voterBtn.TabIndex = 2
        Me.voterBtn.Text = "Voters"
        Me.voterBtn.UseVisualStyleBackColor = True
        '
        'candidateBtn
        '
        Me.candidateBtn.FlatAppearance.BorderSize = 0
        Me.candidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.candidateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.candidateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.candidateBtn.Location = New System.Drawing.Point(125, 0)
        Me.candidateBtn.Name = "candidateBtn"
        Me.candidateBtn.Size = New System.Drawing.Size(125, 51)
        Me.candidateBtn.TabIndex = 1
        Me.candidateBtn.Text = "Candidates"
        Me.candidateBtn.UseVisualStyleBackColor = True
        '
        'studentBtn
        '
        Me.studentBtn.FlatAppearance.BorderSize = 0
        Me.studentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.studentBtn.Location = New System.Drawing.Point(0, 0)
        Me.studentBtn.Name = "studentBtn"
        Me.studentBtn.Size = New System.Drawing.Size(125, 51)
        Me.studentBtn.TabIndex = 0
        Me.studentBtn.Text = "Students"
        Me.studentBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(886, 100)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(787, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(209, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "E-VOTING DASHBOARD"
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 572)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.studentData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.candidateImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.candidateData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.voterData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.winnerData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents studentBtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents voterBtn As Button
    Friend WithEvents candidateBtn As Button
    Friend WithEvents studentData As DataGridView
    Friend WithEvents candidateData As DataGridView
    Friend WithEvents voterData As DataGridView
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbStudentId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents addCandidate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents logoutBtn As Button
    Friend WithEvents tbLastName1 As TextBox
    Friend WithEvents tbFirstName1 As TextBox
    Friend WithEvents tbStudentID1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents addStudentBtn As Button
    Friend WithEvents candidateImg As PictureBox
    Friend WithEvents student_id As DataGridViewTextBoxColumn
    Friend WithEvents student_fname As DataGridViewTextBoxColumn
    Friend WithEvents student_lname As DataGridViewTextBoxColumn
    Friend WithEvents student_status As DataGridViewTextBoxColumn
    Friend WithEvents UpdateStudent As DataGridViewButtonColumn
    Friend WithEvents DeleteStudent As DataGridViewButtonColumn
    Friend WithEvents winnerData As DataGridView
    Friend WithEvents electionBtn As Button
    Friend WithEvents voter_id As DataGridViewTextBoxColumn
    Friend WithEvents voter_fname As DataGridViewTextBoxColumn
    Friend WithEvents voter_lname As DataGridViewTextBoxColumn
    Friend WithEvents voter_username As DataGridViewTextBoxColumn
    Friend WithEvents voting_status As DataGridViewTextBoxColumn
    Friend WithEvents vote_date As DataGridViewTextBoxColumn
    Friend WithEvents voterStudent_id As DataGridViewTextBoxColumn
    Friend WithEvents UpdateVoter As DataGridViewButtonColumn
    Friend WithEvents DeleteVoter As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents candidate_id As DataGridViewTextBoxColumn
    Friend WithEvents candidate_fname As DataGridViewTextBoxColumn
    Friend WithEvents candidate_lname As DataGridViewTextBoxColumn
    Friend WithEvents candidate_position As DataGridViewTextBoxColumn
    Friend WithEvents candidateStudent_id As DataGridViewTextBoxColumn
    Friend WithEvents UpdateCandidate As DataGridViewButtonColumn
    Friend WithEvents DeleteCandidate As DataGridViewButtonColumn
    Friend WithEvents displayStudentBtn As Button
    Friend WithEvents searchStudentBtn As Button
    Friend WithEvents tbStudentSearchBox As TextBox
    Friend WithEvents displayCandidateBtn As Button
    Friend WithEvents searchCandidateBtn As Button
    Friend WithEvents tbCandidateSearchBox As TextBox
    Friend WithEvents displayVoterBtn As Button
    Friend WithEvents searchVoterBtn As Button
    Friend WithEvents tbVoterSearchBox As TextBox
End Class
