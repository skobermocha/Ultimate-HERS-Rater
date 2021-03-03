<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.cmbCustomer = New System.Windows.Forms.ComboBox
        Me.cmbDivision = New System.Windows.Forms.ComboBox
        Me.cmbContact = New System.Windows.Forms.ComboBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblDivision = New System.Windows.Forms.Label
        Me.lblContact = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblLocation = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblSaved = New System.Windows.Forms.Label
        Me.grbCustomer = New System.Windows.Forms.GroupBox
        Me.grbProject = New System.Windows.Forms.GroupBox
        Me.cmbProjectType = New System.Windows.Forms.ComboBox
        Me.lblProjectType = New System.Windows.Forms.Label
        Me.optActive = New System.Windows.Forms.RadioButton
        Me.optInactive = New System.Windows.Forms.RadioButton
        Me.lblProjectList = New System.Windows.Forms.Label
        Me.lstProjects = New System.Windows.Forms.ListBox
        Me.TimerSave = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSaved = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbCustomer.SuspendLayout()
        Me.grbProject.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCustomer
        '
        Me.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(15, 46)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(459, 24)
        Me.cmbCustomer.TabIndex = 0
        '
        'cmbDivision
        '
        Me.cmbDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(15, 90)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(459, 24)
        Me.cmbDivision.TabIndex = 1
        '
        'cmbContact
        '
        Me.cmbContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbContact.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbContact.FormattingEnabled = True
        Me.cmbContact.Location = New System.Drawing.Point(15, 152)
        Me.cmbContact.Name = "cmbContact"
        Me.cmbContact.Size = New System.Drawing.Size(239, 24)
        Me.cmbContact.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(15, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(239, 22)
        Me.txtName.TabIndex = 1
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(15, 99)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(239, 22)
        Me.txtLocation.TabIndex = 2
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(12, 28)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(61, 15)
        Me.lblCustomer.TabIndex = 5
        Me.lblCustomer.Text = "Customer"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(12, 72)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(49, 15)
        Me.lblDivision.TabIndex = 6
        Me.lblDivision.Text = "Division"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(12, 134)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(49, 15)
        Me.lblContact.TabIndex = 7
        Me.lblContact.Text = "Contact"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 15)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(12, 81)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(53, 15)
        Me.lblLocation.TabIndex = 9
        Me.lblLocation.Text = "Location"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(432, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(40, 25)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(386, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 25)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(413, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSaved.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Red
        Me.lblSaved.Location = New System.Drawing.Point(138, 405)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(241, 16)
        Me.lblSaved.TabIndex = 13
        Me.lblSaved.Text = "Project Saved"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSaved.Visible = False
        '
        'grbCustomer
        '
        Me.grbCustomer.Controls.Add(Me.cmbCustomer)
        Me.grbCustomer.Controls.Add(Me.cmbDivision)
        Me.grbCustomer.Controls.Add(Me.lblCustomer)
        Me.grbCustomer.Controls.Add(Me.lblDivision)
        Me.grbCustomer.Location = New System.Drawing.Point(14, 14)
        Me.grbCustomer.Name = "grbCustomer"
        Me.grbCustomer.Padding = New System.Windows.Forms.Padding(12)
        Me.grbCustomer.Size = New System.Drawing.Size(488, 126)
        Me.grbCustomer.TabIndex = 0
        Me.grbCustomer.TabStop = False
        Me.grbCustomer.Text = "Customer Information"
        '
        'grbProject
        '
        Me.grbProject.Controls.Add(Me.cmbProjectType)
        Me.grbProject.Controls.Add(Me.lblProjectType)
        Me.grbProject.Controls.Add(Me.optActive)
        Me.grbProject.Controls.Add(Me.optInactive)
        Me.grbProject.Controls.Add(Me.lblProjectList)
        Me.grbProject.Controls.Add(Me.lstProjects)
        Me.grbProject.Controls.Add(Me.btnAdd)
        Me.grbProject.Controls.Add(Me.txtLocation)
        Me.grbProject.Controls.Add(Me.btnSave)
        Me.grbProject.Controls.Add(Me.cmbContact)
        Me.grbProject.Controls.Add(Me.txtName)
        Me.grbProject.Controls.Add(Me.lblContact)
        Me.grbProject.Controls.Add(Me.lblName)
        Me.grbProject.Controls.Add(Me.lblLocation)
        Me.grbProject.Location = New System.Drawing.Point(14, 146)
        Me.grbProject.Name = "grbProject"
        Me.grbProject.Padding = New System.Windows.Forms.Padding(12)
        Me.grbProject.Size = New System.Drawing.Size(488, 245)
        Me.grbProject.TabIndex = 1
        Me.grbProject.TabStop = False
        Me.grbProject.Text = "Project Information"
        '
        'cmbProjectType
        '
        Me.cmbProjectType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProjectType.FormattingEnabled = True
        Me.cmbProjectType.Location = New System.Drawing.Point(15, 205)
        Me.cmbProjectType.Name = "cmbProjectType"
        Me.cmbProjectType.Size = New System.Drawing.Size(239, 24)
        Me.cmbProjectType.TabIndex = 4
        '
        'lblProjectType
        '
        Me.lblProjectType.AutoSize = True
        Me.lblProjectType.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectType.Location = New System.Drawing.Point(12, 187)
        Me.lblProjectType.Name = "lblProjectType"
        Me.lblProjectType.Size = New System.Drawing.Size(75, 15)
        Me.lblProjectType.TabIndex = 15
        Me.lblProjectType.Text = "Project Type"
        '
        'optActive
        '
        Me.optActive.AutoSize = True
        Me.optActive.Location = New System.Drawing.Point(119, 24)
        Me.optActive.Name = "optActive"
        Me.optActive.Size = New System.Drawing.Size(59, 19)
        Me.optActive.TabIndex = 13
        Me.optActive.TabStop = True
        Me.optActive.Text = "Active"
        Me.optActive.UseVisualStyleBackColor = True
        '
        'optInactive
        '
        Me.optInactive.AutoSize = True
        Me.optInactive.Location = New System.Drawing.Point(184, 24)
        Me.optInactive.Name = "optInactive"
        Me.optInactive.Size = New System.Drawing.Size(67, 19)
        Me.optInactive.TabIndex = 12
        Me.optInactive.TabStop = True
        Me.optInactive.Text = "Inactive"
        Me.optInactive.UseVisualStyleBackColor = True
        '
        'lblProjectList
        '
        Me.lblProjectList.AutoSize = True
        Me.lblProjectList.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectList.Location = New System.Drawing.Point(257, 26)
        Me.lblProjectList.Name = "lblProjectList"
        Me.lblProjectList.Size = New System.Drawing.Size(73, 15)
        Me.lblProjectList.TabIndex = 11
        Me.lblProjectList.Text = "Projects List"
        '
        'lstProjects
        '
        Me.lstProjects.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProjects.FormattingEnabled = True
        Me.lstProjects.ItemHeight = 16
        Me.lstProjects.Location = New System.Drawing.Point(260, 45)
        Me.lstProjects.Name = "lstProjects"
        Me.lstProjects.Size = New System.Drawing.Size(212, 180)
        Me.lstProjects.TabIndex = 0
        '
        'TimerSave
        '
        Me.TimerSave.Interval = 500
        '
        'TimerSaved
        '
        Me.TimerSaved.Interval = 1000
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmProjectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 441)
        Me.Controls.Add(Me.grbProject)
        Me.Controls.Add(Me.grbCustomer)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProjectDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Details"
        Me.grbCustomer.ResumeLayout(False)
        Me.grbCustomer.PerformLayout()
        Me.grbProject.ResumeLayout(False)
        Me.grbProject.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cmbContact As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents grbCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents grbProject As System.Windows.Forms.GroupBox
    Friend WithEvents lblProjectList As System.Windows.Forms.Label
    Friend WithEvents lstProjects As System.Windows.Forms.ListBox
    Friend WithEvents optActive As System.Windows.Forms.RadioButton
    Friend WithEvents optInactive As System.Windows.Forms.RadioButton
    Friend WithEvents cmbProjectType As System.Windows.Forms.ComboBox
    Friend WithEvents lblProjectType As System.Windows.Forms.Label
    Friend WithEvents TimerSave As System.Windows.Forms.Timer
    Friend WithEvents TimerSaved As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
