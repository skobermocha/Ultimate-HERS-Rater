<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectLookup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectLookup))
        Me.grbProjectNumber = New System.Windows.Forms.GroupBox
        Me.btnNbrLookup = New System.Windows.Forms.Button
        Me.lblProjectNumber = New System.Windows.Forms.Label
        Me.txtProjectNumber = New System.Windows.Forms.TextBox
        Me.grbProjectName = New System.Windows.Forms.GroupBox
        Me.btnNameLookup = New System.Windows.Forms.Button
        Me.cmbName = New System.Windows.Forms.ComboBox
        Me.cmbDivision = New System.Windows.Forms.ComboBox
        Me.cmbCustomer = New System.Windows.Forms.ComboBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblDivision = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbProjectNumber.SuspendLayout()
        Me.grbProjectName.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbProjectNumber
        '
        Me.grbProjectNumber.Controls.Add(Me.btnNbrLookup)
        Me.grbProjectNumber.Controls.Add(Me.lblProjectNumber)
        Me.grbProjectNumber.Controls.Add(Me.txtProjectNumber)
        Me.grbProjectNumber.Location = New System.Drawing.Point(12, 12)
        Me.grbProjectNumber.Name = "grbProjectNumber"
        Me.grbProjectNumber.Padding = New System.Windows.Forms.Padding(10)
        Me.grbProjectNumber.Size = New System.Drawing.Size(265, 83)
        Me.grbProjectNumber.TabIndex = 0
        Me.grbProjectNumber.TabStop = False
        Me.grbProjectNumber.Text = "Search By Project Number"
        '
        'btnNbrLookup
        '
        Me.btnNbrLookup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNbrLookup.Location = New System.Drawing.Point(177, 42)
        Me.btnNbrLookup.Name = "btnNbrLookup"
        Me.btnNbrLookup.Size = New System.Drawing.Size(75, 25)
        Me.btnNbrLookup.TabIndex = 1
        Me.btnNbrLookup.Text = "Lookup"
        Me.btnNbrLookup.UseVisualStyleBackColor = True
        '
        'lblProjectNumber
        '
        Me.lblProjectNumber.AutoSize = True
        Me.lblProjectNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectNumber.Location = New System.Drawing.Point(10, 26)
        Me.lblProjectNumber.Name = "lblProjectNumber"
        Me.lblProjectNumber.Size = New System.Drawing.Size(55, 15)
        Me.lblProjectNumber.TabIndex = 1
        Me.lblProjectNumber.Text = "Project #"
        '
        'txtProjectNumber
        '
        Me.txtProjectNumber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectNumber.Location = New System.Drawing.Point(13, 44)
        Me.txtProjectNumber.Name = "txtProjectNumber"
        Me.txtProjectNumber.Size = New System.Drawing.Size(94, 22)
        Me.txtProjectNumber.TabIndex = 0
        '
        'grbProjectName
        '
        Me.grbProjectName.Controls.Add(Me.btnNameLookup)
        Me.grbProjectName.Controls.Add(Me.cmbName)
        Me.grbProjectName.Controls.Add(Me.cmbDivision)
        Me.grbProjectName.Controls.Add(Me.cmbCustomer)
        Me.grbProjectName.Controls.Add(Me.lblName)
        Me.grbProjectName.Controls.Add(Me.lblDivision)
        Me.grbProjectName.Controls.Add(Me.lblCustomer)
        Me.grbProjectName.Location = New System.Drawing.Point(12, 101)
        Me.grbProjectName.Name = "grbProjectName"
        Me.grbProjectName.Padding = New System.Windows.Forms.Padding(10)
        Me.grbProjectName.Size = New System.Drawing.Size(265, 204)
        Me.grbProjectName.TabIndex = 1
        Me.grbProjectName.TabStop = False
        Me.grbProjectName.Text = "Search By Project Name"
        '
        'btnNameLookup
        '
        Me.btnNameLookup.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNameLookup.Location = New System.Drawing.Point(95, 166)
        Me.btnNameLookup.Name = "btnNameLookup"
        Me.btnNameLookup.Size = New System.Drawing.Size(75, 25)
        Me.btnNameLookup.TabIndex = 3
        Me.btnNameLookup.Text = "Lookup"
        Me.btnNameLookup.UseVisualStyleBackColor = True
        '
        'cmbName
        '
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(13, 132)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(239, 24)
        Me.cmbName.TabIndex = 2
        '
        'cmbDivision
        '
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(13, 88)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(239, 24)
        Me.cmbDivision.TabIndex = 1
        '
        'cmbCustomer
        '
        Me.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(13, 44)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(239, 24)
        Me.cmbCustomer.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(10, 114)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 15)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Project Name"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(10, 70)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(49, 15)
        Me.lblDivision.TabIndex = 5
        Me.lblDivision.Text = "Division"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(10, 26)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(61, 15)
        Me.lblCustomer.TabIndex = 3
        Me.lblCustomer.Text = "Customer"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(189, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmProjectLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 352)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grbProjectName)
        Me.Controls.Add(Me.grbProjectNumber)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Lookup"
        Me.grbProjectNumber.ResumeLayout(False)
        Me.grbProjectNumber.PerformLayout()
        Me.grbProjectName.ResumeLayout(False)
        Me.grbProjectName.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbProjectNumber As System.Windows.Forms.GroupBox
    Friend WithEvents grbProjectName As System.Windows.Forms.GroupBox
    Friend WithEvents lblProjectNumber As System.Windows.Forms.Label
    Friend WithEvents txtProjectNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDivision As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents btnNbrLookup As System.Windows.Forms.Button
    Friend WithEvents btnNameLookup As System.Windows.Forms.Button
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
