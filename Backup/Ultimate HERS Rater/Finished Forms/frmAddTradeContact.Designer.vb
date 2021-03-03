<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTradeContact
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
        Me.grbTradesList = New System.Windows.Forms.GroupBox
        Me.lstTradetypes = New System.Windows.Forms.ListBox
        Me.grbContacts = New System.Windows.Forms.GroupBox
        Me.lblContacts = New System.Windows.Forms.Label
        Me.lstDivisions = New System.Windows.Forms.Label
        Me.lblCustomers = New System.Windows.Forms.Label
        Me.cmbContacts = New System.Windows.Forms.ComboBox
        Me.cmbDivisions = New System.Windows.Forms.ComboBox
        Me.cmbCustomers = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grbTradesList.SuspendLayout()
        Me.grbContacts.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbTradesList
        '
        Me.grbTradesList.Controls.Add(Me.lstTradetypes)
        Me.grbTradesList.Location = New System.Drawing.Point(12, 12)
        Me.grbTradesList.Name = "grbTradesList"
        Me.grbTradesList.Size = New System.Drawing.Size(170, 200)
        Me.grbTradesList.TabIndex = 0
        Me.grbTradesList.TabStop = False
        Me.grbTradesList.Text = "Trades List"
        '
        'lstTradetypes
        '
        Me.lstTradetypes.FormattingEnabled = True
        Me.lstTradetypes.ItemHeight = 15
        Me.lstTradetypes.Location = New System.Drawing.Point(6, 22)
        Me.lstTradetypes.Name = "lstTradetypes"
        Me.lstTradetypes.Size = New System.Drawing.Size(158, 169)
        Me.lstTradetypes.TabIndex = 0
        '
        'grbContacts
        '
        Me.grbContacts.Controls.Add(Me.lblContacts)
        Me.grbContacts.Controls.Add(Me.lstDivisions)
        Me.grbContacts.Controls.Add(Me.lblCustomers)
        Me.grbContacts.Controls.Add(Me.cmbContacts)
        Me.grbContacts.Controls.Add(Me.cmbDivisions)
        Me.grbContacts.Controls.Add(Me.cmbCustomers)
        Me.grbContacts.Location = New System.Drawing.Point(188, 12)
        Me.grbContacts.Name = "grbContacts"
        Me.grbContacts.Size = New System.Drawing.Size(249, 161)
        Me.grbContacts.TabIndex = 1
        Me.grbContacts.TabStop = False
        Me.grbContacts.Text = "Trade Contacts"
        '
        'lblContacts
        '
        Me.lblContacts.AutoSize = True
        Me.lblContacts.Location = New System.Drawing.Point(3, 107)
        Me.lblContacts.Name = "lblContacts"
        Me.lblContacts.Size = New System.Drawing.Size(54, 15)
        Me.lblContacts.TabIndex = 5
        Me.lblContacts.Text = "Contacts"
        '
        'lstDivisions
        '
        Me.lstDivisions.AutoSize = True
        Me.lstDivisions.Location = New System.Drawing.Point(3, 63)
        Me.lstDivisions.Name = "lstDivisions"
        Me.lstDivisions.Size = New System.Drawing.Size(54, 15)
        Me.lstDivisions.TabIndex = 4
        Me.lstDivisions.Text = "Divisions"
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Location = New System.Drawing.Point(3, 19)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(66, 15)
        Me.lblCustomers.TabIndex = 3
        Me.lblCustomers.Text = "Customers"
        '
        'cmbContacts
        '
        Me.cmbContacts.FormattingEnabled = True
        Me.cmbContacts.Location = New System.Drawing.Point(6, 125)
        Me.cmbContacts.Name = "cmbContacts"
        Me.cmbContacts.Size = New System.Drawing.Size(237, 23)
        Me.cmbContacts.TabIndex = 2
        '
        'cmbDivisions
        '
        Me.cmbDivisions.FormattingEnabled = True
        Me.cmbDivisions.Location = New System.Drawing.Point(6, 81)
        Me.cmbDivisions.Name = "cmbDivisions"
        Me.cmbDivisions.Size = New System.Drawing.Size(237, 23)
        Me.cmbDivisions.TabIndex = 1
        '
        'cmbCustomers
        '
        Me.cmbCustomers.FormattingEnabled = True
        Me.cmbCustomers.Location = New System.Drawing.Point(6, 37)
        Me.cmbCustomers.Name = "cmbCustomers"
        Me.cmbCustomers.Size = New System.Drawing.Size(237, 23)
        Me.cmbCustomers.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(246, 187)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(362, 187)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AddTradeContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 224)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grbContacts)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grbTradesList)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddTradeContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Trade Contact"
        Me.grbTradesList.ResumeLayout(False)
        Me.grbContacts.ResumeLayout(False)
        Me.grbContacts.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbTradesList As System.Windows.Forms.GroupBox
    Friend WithEvents lstTradetypes As System.Windows.Forms.ListBox
    Friend WithEvents grbContacts As System.Windows.Forms.GroupBox
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents lstDivisions As System.Windows.Forms.Label
    Friend WithEvents lblCustomers As System.Windows.Forms.Label
    Friend WithEvents cmbContacts As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDivisions As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustomers As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
