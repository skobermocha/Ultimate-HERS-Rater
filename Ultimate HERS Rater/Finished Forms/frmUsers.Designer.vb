<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.lstUsers = New System.Windows.Forms.ListBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.cmbDepartment = New System.Windows.Forms.ComboBox
        Me.optInactive = New System.Windows.Forms.RadioButton
        Me.optActive = New System.Windows.Forms.RadioButton
        Me.cmbUserType = New System.Windows.Forms.ComboBox
        Me.btnAddUser = New System.Windows.Forms.Button
        Me.btnSaveUser = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.grbUsers = New System.Windows.Forms.GroupBox
        Me.grbUserInfo = New System.Windows.Forms.GroupBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.lblUserType = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblSaved = New System.Windows.Forms.Label
        Me.TimerSave = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSaved = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbUsers.SuspendLayout()
        Me.grbUserInfo.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstUsers
        '
        Me.lstUsers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.ItemHeight = 16
        Me.lstUsers.Location = New System.Drawing.Point(13, 29)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(157, 196)
        Me.lstUsers.TabIndex = 0
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(13, 44)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(237, 22)
        Me.txtUserName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(13, 97)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(237, 22)
        Me.txtPassword.TabIndex = 1
        '
        'cmbDepartment
        '
        Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(13, 205)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(237, 24)
        Me.cmbDepartment.TabIndex = 3
        '
        'optInactive
        '
        Me.optInactive.AutoSize = True
        Me.optInactive.Location = New System.Drawing.Point(183, 24)
        Me.optInactive.Name = "optInactive"
        Me.optInactive.Size = New System.Drawing.Size(67, 19)
        Me.optInactive.TabIndex = 4
        Me.optInactive.TabStop = True
        Me.optInactive.Text = "Inactive"
        Me.optInactive.UseVisualStyleBackColor = True
        '
        'optActive
        '
        Me.optActive.AutoSize = True
        Me.optActive.Location = New System.Drawing.Point(118, 24)
        Me.optActive.Name = "optActive"
        Me.optActive.Size = New System.Drawing.Size(59, 19)
        Me.optActive.TabIndex = 5
        Me.optActive.TabStop = True
        Me.optActive.Text = "Active"
        Me.optActive.UseVisualStyleBackColor = True
        '
        'cmbUserType
        '
        Me.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Location = New System.Drawing.Point(13, 150)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(237, 24)
        Me.cmbUserType.TabIndex = 2
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(54, 238)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(75, 25)
        Me.btnAddUser.TabIndex = 1
        Me.btnAddUser.Text = "&Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Location = New System.Drawing.Point(94, 238)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(75, 25)
        Me.btnSaveUser.TabIndex = 4
        Me.btnSaveUser.Text = "&Save"
        Me.btnSaveUser.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(376, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grbUsers
        '
        Me.grbUsers.Controls.Add(Me.btnAddUser)
        Me.grbUsers.Controls.Add(Me.lstUsers)
        Me.grbUsers.Location = New System.Drawing.Point(12, 12)
        Me.grbUsers.Name = "grbUsers"
        Me.grbUsers.Padding = New System.Windows.Forms.Padding(10)
        Me.grbUsers.Size = New System.Drawing.Size(183, 276)
        Me.grbUsers.TabIndex = 0
        Me.grbUsers.TabStop = False
        Me.grbUsers.Text = "Users"
        '
        'grbUserInfo
        '
        Me.grbUserInfo.Controls.Add(Me.lblDepartment)
        Me.grbUserInfo.Controls.Add(Me.lblUserType)
        Me.grbUserInfo.Controls.Add(Me.lblPassword)
        Me.grbUserInfo.Controls.Add(Me.lblUserName)
        Me.grbUserInfo.Controls.Add(Me.cmbUserType)
        Me.grbUserInfo.Controls.Add(Me.optInactive)
        Me.grbUserInfo.Controls.Add(Me.cmbDepartment)
        Me.grbUserInfo.Controls.Add(Me.btnSaveUser)
        Me.grbUserInfo.Controls.Add(Me.txtPassword)
        Me.grbUserInfo.Controls.Add(Me.optActive)
        Me.grbUserInfo.Controls.Add(Me.txtUserName)
        Me.grbUserInfo.Location = New System.Drawing.Point(201, 12)
        Me.grbUserInfo.Name = "grbUserInfo"
        Me.grbUserInfo.Padding = New System.Windows.Forms.Padding(10)
        Me.grbUserInfo.Size = New System.Drawing.Size(263, 276)
        Me.grbUserInfo.TabIndex = 1
        Me.grbUserInfo.TabStop = False
        Me.grbUserInfo.Text = "User Information"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(10, 187)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(75, 15)
        Me.lblDepartment.TabIndex = 12
        Me.lblDepartment.Text = "Department"
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Location = New System.Drawing.Point(10, 132)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(61, 15)
        Me.lblUserType.TabIndex = 11
        Me.lblUserType.Text = "User Type"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(10, 79)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 15)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(10, 26)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(68, 15)
        Me.lblUserName.TabIndex = 9
        Me.lblUserName.Text = "User Name"
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSaved.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Red
        Me.lblSaved.Location = New System.Drawing.Point(145, 306)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(189, 14)
        Me.lblSaved.TabIndex = 14
        Me.lblSaved.Text = "User Saved"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSaved.Visible = False
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
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 343)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.grbUserInfo)
        Me.Controls.Add(Me.grbUsers)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.grbUsers.ResumeLayout(False)
        Me.grbUserInfo.ResumeLayout(False)
        Me.grbUserInfo.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents optInactive As System.Windows.Forms.RadioButton
    Friend WithEvents optActive As System.Windows.Forms.RadioButton
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnSaveUser As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grbUsers As System.Windows.Forms.GroupBox
    Friend WithEvents grbUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblUserType As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents TimerSave As System.Windows.Forms.Timer
    Friend WithEvents TimerSaved As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
