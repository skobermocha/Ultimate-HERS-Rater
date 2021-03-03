<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnLogOut = New System.Windows.Forms.Button
        Me.grbProjects = New System.Windows.Forms.GroupBox
        Me.btnEditProject = New System.Windows.Forms.Button
        Me.btnTitle24 = New System.Windows.Forms.Button
        Me.btnCreateProject = New System.Windows.Forms.Button
        Me.btnTesting = New System.Windows.Forms.Button
        Me.btnBid = New System.Windows.Forms.Button
        Me.grbCustomers = New System.Windows.Forms.GroupBox
        Me.btnCreateCustomer = New System.Windows.Forms.Button
        Me.btnEditCustomer = New System.Windows.Forms.Button
        Me.grbReports = New System.Windows.Forms.GroupBox
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeMyPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditDepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Title24OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditAssembliesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditEquipmentTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditReportTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TestingOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditCustomerTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grbProjects.SuspendLayout()
        Me.grbCustomers.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(159, 258)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 25)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Log &Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'grbProjects
        '
        Me.grbProjects.Controls.Add(Me.btnEditProject)
        Me.grbProjects.Controls.Add(Me.btnTitle24)
        Me.grbProjects.Controls.Add(Me.btnCreateProject)
        Me.grbProjects.Controls.Add(Me.btnTesting)
        Me.grbProjects.Controls.Add(Me.btnBid)
        Me.grbProjects.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbProjects.Location = New System.Drawing.Point(19, 44)
        Me.grbProjects.Margin = New System.Windows.Forms.Padding(10)
        Me.grbProjects.Name = "grbProjects"
        Me.grbProjects.Padding = New System.Windows.Forms.Padding(11)
        Me.grbProjects.Size = New System.Drawing.Size(105, 200)
        Me.grbProjects.TabIndex = 0
        Me.grbProjects.TabStop = False
        Me.grbProjects.Text = "Projects"
        '
        'btnEditProject
        '
        Me.btnEditProject.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProject.Location = New System.Drawing.Point(15, 163)
        Me.btnEditProject.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditProject.Name = "btnEditProject"
        Me.btnEditProject.Size = New System.Drawing.Size(75, 25)
        Me.btnEditProject.TabIndex = 4
        Me.btnEditProject.Text = "Edit"
        Me.btnEditProject.UseVisualStyleBackColor = True
        '
        'btnTitle24
        '
        Me.btnTitle24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTitle24.Location = New System.Drawing.Point(15, 31)
        Me.btnTitle24.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTitle24.Name = "btnTitle24"
        Me.btnTitle24.Size = New System.Drawing.Size(75, 25)
        Me.btnTitle24.TabIndex = 0
        Me.btnTitle24.Text = "Title-24"
        Me.btnTitle24.UseVisualStyleBackColor = True
        '
        'btnCreateProject
        '
        Me.btnCreateProject.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateProject.Location = New System.Drawing.Point(15, 130)
        Me.btnCreateProject.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateProject.Name = "btnCreateProject"
        Me.btnCreateProject.Size = New System.Drawing.Size(75, 25)
        Me.btnCreateProject.TabIndex = 3
        Me.btnCreateProject.Text = "Create"
        Me.btnCreateProject.UseVisualStyleBackColor = True
        '
        'btnTesting
        '
        Me.btnTesting.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTesting.Location = New System.Drawing.Point(15, 64)
        Me.btnTesting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTesting.Name = "btnTesting"
        Me.btnTesting.Size = New System.Drawing.Size(75, 25)
        Me.btnTesting.TabIndex = 1
        Me.btnTesting.Text = "Testing"
        Me.btnTesting.UseVisualStyleBackColor = True
        '
        'btnBid
        '
        Me.btnBid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBid.Location = New System.Drawing.Point(15, 97)
        Me.btnBid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBid.Name = "btnBid"
        Me.btnBid.Size = New System.Drawing.Size(75, 25)
        Me.btnBid.TabIndex = 2
        Me.btnBid.Text = "Bid"
        Me.btnBid.UseVisualStyleBackColor = True
        '
        'grbCustomers
        '
        Me.grbCustomers.Controls.Add(Me.btnCreateCustomer)
        Me.grbCustomers.Controls.Add(Me.btnEditCustomer)
        Me.grbCustomers.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCustomers.Location = New System.Drawing.Point(144, 44)
        Me.grbCustomers.Margin = New System.Windows.Forms.Padding(10)
        Me.grbCustomers.Name = "grbCustomers"
        Me.grbCustomers.Padding = New System.Windows.Forms.Padding(11, 11, 4, 4)
        Me.grbCustomers.Size = New System.Drawing.Size(105, 200)
        Me.grbCustomers.TabIndex = 1
        Me.grbCustomers.TabStop = False
        Me.grbCustomers.Text = "Customers"
        '
        'btnCreateCustomer
        '
        Me.btnCreateCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateCustomer.Location = New System.Drawing.Point(15, 30)
        Me.btnCreateCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateCustomer.Name = "btnCreateCustomer"
        Me.btnCreateCustomer.Size = New System.Drawing.Size(75, 25)
        Me.btnCreateCustomer.TabIndex = 0
        Me.btnCreateCustomer.Text = "Create"
        Me.btnCreateCustomer.UseVisualStyleBackColor = True
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCustomer.Location = New System.Drawing.Point(15, 64)
        Me.btnEditCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(75, 25)
        Me.btnEditCustomer.TabIndex = 1
        Me.btnEditCustomer.Text = "Edit"
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'grbReports
        '
        Me.grbReports.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbReports.Location = New System.Drawing.Point(269, 44)
        Me.grbReports.Margin = New System.Windows.Forms.Padding(10)
        Me.grbReports.Name = "grbReports"
        Me.grbReports.Padding = New System.Windows.Forms.Padding(11, 11, 4, 4)
        Me.grbReports.Size = New System.Drawing.Size(105, 200)
        Me.grbReports.TabIndex = 2
        Me.grbReports.TabStop = False
        Me.grbReports.Text = "Reports"
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(393, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogOutToolStripMenuItem.Text = "Log &Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserOptionsToolStripMenuItem, Me.Title24OptionsToolStripMenuItem, Me.TestingOptionsToolStripMenuItem, Me.CustomerOptionsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.AdminToolStripMenuItem.Text = "&Admin"
        '
        'UserOptionsToolStripMenuItem
        '
        Me.UserOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeMyPasswordToolStripMenuItem, Me.EditUsersToolStripMenuItem, Me.EditDepartmentsToolStripMenuItem})
        Me.UserOptionsToolStripMenuItem.Name = "UserOptionsToolStripMenuItem"
        Me.UserOptionsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UserOptionsToolStripMenuItem.Text = "User Options"
        '
        'ChangeMyPasswordToolStripMenuItem
        '
        Me.ChangeMyPasswordToolStripMenuItem.Name = "ChangeMyPasswordToolStripMenuItem"
        Me.ChangeMyPasswordToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ChangeMyPasswordToolStripMenuItem.Text = "Change My Password"
        '
        'EditUsersToolStripMenuItem
        '
        Me.EditUsersToolStripMenuItem.Name = "EditUsersToolStripMenuItem"
        Me.EditUsersToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditUsersToolStripMenuItem.Text = "Edit Users"
        '
        'EditDepartmentsToolStripMenuItem
        '
        Me.EditDepartmentsToolStripMenuItem.Name = "EditDepartmentsToolStripMenuItem"
        Me.EditDepartmentsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditDepartmentsToolStripMenuItem.Text = "Edit Departments"
        '
        'Title24OptionsToolStripMenuItem
        '
        Me.Title24OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditAssembliesToolStripMenuItem, Me.EditEquipmentTypesToolStripMenuItem, Me.EditReportTypesToolStripMenuItem})
        Me.Title24OptionsToolStripMenuItem.Name = "Title24OptionsToolStripMenuItem"
        Me.Title24OptionsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.Title24OptionsToolStripMenuItem.Text = "Title24 Options"
        '
        'EditAssembliesToolStripMenuItem
        '
        Me.EditAssembliesToolStripMenuItem.Name = "EditAssembliesToolStripMenuItem"
        Me.EditAssembliesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditAssembliesToolStripMenuItem.Text = "Edit Assemblies"
        '
        'EditEquipmentTypesToolStripMenuItem
        '
        Me.EditEquipmentTypesToolStripMenuItem.Name = "EditEquipmentTypesToolStripMenuItem"
        Me.EditEquipmentTypesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditEquipmentTypesToolStripMenuItem.Text = "Edit Equipment Types"
        '
        'EditReportTypesToolStripMenuItem
        '
        Me.EditReportTypesToolStripMenuItem.Name = "EditReportTypesToolStripMenuItem"
        Me.EditReportTypesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EditReportTypesToolStripMenuItem.Text = "Edit Incentive Programs"
        '
        'TestingOptionsToolStripMenuItem
        '
        Me.TestingOptionsToolStripMenuItem.Name = "TestingOptionsToolStripMenuItem"
        Me.TestingOptionsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TestingOptionsToolStripMenuItem.Text = "Testing Options"
        '
        'CustomerOptionsToolStripMenuItem
        '
        Me.CustomerOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditCustomerTypesToolStripMenuItem})
        Me.CustomerOptionsToolStripMenuItem.Name = "CustomerOptionsToolStripMenuItem"
        Me.CustomerOptionsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CustomerOptionsToolStripMenuItem.Text = "Customer Options"
        '
        'EditCustomerTypesToolStripMenuItem
        '
        Me.EditCustomerTypesToolStripMenuItem.Name = "EditCustomerTypesToolStripMenuItem"
        Me.EditCustomerTypesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EditCustomerTypesToolStripMenuItem.Text = "Edit Customer Types"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 296)
        Me.Controls.Add(Me.grbReports)
        Me.Controls.Add(Me.grbCustomers)
        Me.Controls.Add(Me.grbProjects)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.grbProjects.ResumeLayout(False)
        Me.grbCustomers.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents grbProjects As System.Windows.Forms.GroupBox
    Friend WithEvents btnTitle24 As System.Windows.Forms.Button
    Friend WithEvents btnCreateProject As System.Windows.Forms.Button
    Friend WithEvents btnTesting As System.Windows.Forms.Button
    Friend WithEvents btnBid As System.Windows.Forms.Button
    Friend WithEvents grbCustomers As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateCustomer As System.Windows.Forms.Button
    Friend WithEvents btnEditCustomer As System.Windows.Forms.Button
    Friend WithEvents grbReports As System.Windows.Forms.GroupBox
    Friend WithEvents btnEditProject As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeMyPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Title24OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditAssembliesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditEquipmentTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditReportTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestingOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCustomerTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
