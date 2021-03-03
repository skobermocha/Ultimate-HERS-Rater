<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncentivePrograms
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
        Me.lblSaved = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.grbInformation = New System.Windows.Forms.GroupBox
        Me.lblType = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtType = New System.Windows.Forms.TextBox
        Me.grbTypes = New System.Windows.Forms.GroupBox
        Me.lstTypes = New System.Windows.Forms.ListBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.TimerSave = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSaved = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbInformation.SuspendLayout()
        Me.grbTypes.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSaved
        '
        Me.lblSaved.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSaved.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Red
        Me.lblSaved.Location = New System.Drawing.Point(130, 197)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(189, 14)
        Me.lblSaved.TabIndex = 23
        Me.lblSaved.Text = "Incentive Program Saved"
        Me.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSaved.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grbInformation
        '
        Me.grbInformation.Controls.Add(Me.lblType)
        Me.grbInformation.Controls.Add(Me.btnSave)
        Me.grbInformation.Controls.Add(Me.txtType)
        Me.grbInformation.Location = New System.Drawing.Point(200, 12)
        Me.grbInformation.Name = "grbInformation"
        Me.grbInformation.Padding = New System.Windows.Forms.Padding(10)
        Me.grbInformation.Size = New System.Drawing.Size(237, 170)
        Me.grbInformation.TabIndex = 21
        Me.grbInformation.TabStop = False
        Me.grbInformation.Text = "Type Information"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(10, 26)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(90, 15)
        Me.lblType.TabIndex = 3
        Me.lblType.Text = "Program Name"
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
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(13, 44)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(211, 23)
        Me.txtType.TabIndex = 0
        '
        'grbTypes
        '
        Me.grbTypes.Controls.Add(Me.lstTypes)
        Me.grbTypes.Controls.Add(Me.btnAdd)
        Me.grbTypes.Location = New System.Drawing.Point(11, 12)
        Me.grbTypes.Name = "grbTypes"
        Me.grbTypes.Padding = New System.Windows.Forms.Padding(10)
        Me.grbTypes.Size = New System.Drawing.Size(183, 170)
        Me.grbTypes.TabIndex = 20
        Me.grbTypes.TabStop = False
        Me.grbTypes.Text = "Incentive Programs"
        '
        'lstTypes
        '
        Me.lstTypes.FormattingEnabled = True
        Me.lstTypes.ItemHeight = 15
        Me.lstTypes.Location = New System.Drawing.Point(13, 29)
        Me.lstTypes.Name = "lstTypes"
        Me.lstTypes.Size = New System.Drawing.Size(157, 94)
        Me.lstTypes.TabIndex = 0
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
        'frmIncentivePrograms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 224)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grbInformation)
        Me.Controls.Add(Me.grbTypes)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmIncentivePrograms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incentive Programs"
        Me.grbInformation.ResumeLayout(False)
        Me.grbInformation.PerformLayout()
        Me.grbTypes.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grbInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents grbTypes As System.Windows.Forms.GroupBox
    Friend WithEvents lstTypes As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents TimerSave As System.Windows.Forms.Timer
    Friend WithEvents TimerSaved As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
