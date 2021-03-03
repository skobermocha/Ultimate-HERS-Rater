<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartments
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
        Me.grbDepartments = New System.Windows.Forms.GroupBox
        Me.lstDepartments = New System.Windows.Forms.ListBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.grbInformation = New System.Windows.Forms.GroupBox
        Me.lblDepartName = New System.Windows.Forms.Label
        Me.txtDepartName = New System.Windows.Forms.TextBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.TimerSave = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSaved = New System.Windows.Forms.Timer(Me.components)
        Me.lblSaved = New System.Windows.Forms.Label
        Me.grbDepartments.SuspendLayout()
        Me.grbInformation.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbDepartments
        '
        Me.grbDepartments.Controls.Add(Me.lstDepartments)
        Me.grbDepartments.Controls.Add(Me.btnAdd)
        Me.grbDepartments.Location = New System.Drawing.Point(11, 12)
        Me.grbDepartments.Name = "grbDepartments"
        Me.grbDepartments.Padding = New System.Windows.Forms.Padding(10)
        Me.grbDepartments.Size = New System.Drawing.Size(183, 170)
        Me.grbDepartments.TabIndex = 0
        Me.grbDepartments.TabStop = False
        Me.grbDepartments.Text = "Departments"
        '
        'lstDepartments
        '
        Me.lstDepartments.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDepartments.FormattingEnabled = True
        Me.lstDepartments.ItemHeight = 16
        Me.lstDepartments.Location = New System.Drawing.Point(13, 29)
        Me.lstDepartments.Name = "lstDepartments"
        Me.lstDepartments.Size = New System.Drawing.Size(157, 84)
        Me.lstDepartments.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(54, 132)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 25)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(81, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grbInformation
        '
        Me.grbInformation.Controls.Add(Me.lblDepartName)
        Me.grbInformation.Controls.Add(Me.btnSave)
        Me.grbInformation.Controls.Add(Me.txtDepartName)
        Me.grbInformation.Location = New System.Drawing.Point(200, 12)
        Me.grbInformation.Name = "grbInformation"
        Me.grbInformation.Padding = New System.Windows.Forms.Padding(10)
        Me.grbInformation.Size = New System.Drawing.Size(237, 170)
        Me.grbInformation.TabIndex = 1
        Me.grbInformation.TabStop = False
        Me.grbInformation.Text = "Department Information"
        '
        'lblDepartName
        '
        Me.lblDepartName.AutoSize = True
        Me.lblDepartName.Location = New System.Drawing.Point(10, 26)
        Me.lblDepartName.Name = "lblDepartName"
        Me.lblDepartName.Size = New System.Drawing.Size(111, 15)
        Me.lblDepartName.TabIndex = 3
        Me.lblDepartName.Text = "Department Name"
        '
        'txtDepartName
        '
        Me.txtDepartName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartName.Location = New System.Drawing.Point(13, 44)
        Me.txtDepartName.Name = "txtDepartName"
        Me.txtDepartName.Size = New System.Drawing.Size(211, 22)
        Me.txtDepartName.TabIndex = 0
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TimerSave
        '
        Me.TimerSave.Interval = 500
        '
        'TimerSaved
        '
        Me.TimerSaved.Interval = 1000
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSaved.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Red
        Me.lblSaved.Location = New System.Drawing.Point(131, 197)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(189, 14)
        Me.lblSaved.TabIndex = 15
        Me.lblSaved.Text = "Department Saved"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSaved.Visible = False
        '
        'frmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 224)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grbInformation)
        Me.Controls.Add(Me.grbDepartments)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDepartments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departments"
        Me.grbDepartments.ResumeLayout(False)
        Me.grbInformation.ResumeLayout(False)
        Me.grbInformation.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDepartments As System.Windows.Forms.GroupBox
    Friend WithEvents lstDepartments As System.Windows.Forms.ListBox
    Friend WithEvents grbInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblDepartName As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtDepartName As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TimerSave As System.Windows.Forms.Timer
    Friend WithEvents TimerSaved As System.Windows.Forms.Timer
    Friend WithEvents lblSaved As System.Windows.Forms.Label
End Class
