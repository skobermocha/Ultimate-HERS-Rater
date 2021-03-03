<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceDetails
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
        Me.txtInvoiceMemo = New System.Windows.Forms.TextBox
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox
        Me.lblInvoiceNumber = New System.Windows.Forms.Label
        Me.lblInvoiceAmount = New System.Windows.Forms.Label
        Me.lblInvoiceDate = New System.Windows.Forms.Label
        Me.lblInvoiceMemo = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtInvoiceAmount = New System.Windows.Forms.NumericUpDown
        Me.txtInvoiceDate = New System.Windows.Forms.TextBox
        CType(Me.txtInvoiceAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInvoiceMemo
        '
        Me.txtInvoiceMemo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceMemo.Location = New System.Drawing.Point(13, 78)
        Me.txtInvoiceMemo.Multiline = True
        Me.txtInvoiceMemo.Name = "txtInvoiceMemo"
        Me.txtInvoiceMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInvoiceMemo.Size = New System.Drawing.Size(423, 100)
        Me.txtInvoiceMemo.TabIndex = 3
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(13, 28)
        Me.txtInvoiceNumber.Margin = New System.Windows.Forms.Padding(10, 3, 10, 10)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(197, 22)
        Me.txtInvoiceNumber.TabIndex = 0
        '
        'lblInvoiceNumber
        '
        Me.lblInvoiceNumber.AutoSize = True
        Me.lblInvoiceNumber.Location = New System.Drawing.Point(10, 10)
        Me.lblInvoiceNumber.Name = "lblInvoiceNumber"
        Me.lblInvoiceNumber.Size = New System.Drawing.Size(94, 15)
        Me.lblInvoiceNumber.TabIndex = 4
        Me.lblInvoiceNumber.Text = "Invoice Number"
        '
        'lblInvoiceAmount
        '
        Me.lblInvoiceAmount.AutoSize = True
        Me.lblInvoiceAmount.Location = New System.Drawing.Point(220, 10)
        Me.lblInvoiceAmount.Name = "lblInvoiceAmount"
        Me.lblInvoiceAmount.Size = New System.Drawing.Size(100, 15)
        Me.lblInvoiceAmount.TabIndex = 5
        Me.lblInvoiceAmount.Text = "Invoiced Amount"
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.AutoSize = True
        Me.lblInvoiceDate.Location = New System.Drawing.Point(347, 10)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(74, 15)
        Me.lblInvoiceDate.TabIndex = 6
        Me.lblInvoiceDate.Text = "Invoice Date"
        '
        'lblInvoiceMemo
        '
        Me.lblInvoiceMemo.AutoSize = True
        Me.lblInvoiceMemo.Location = New System.Drawing.Point(10, 60)
        Me.lblInvoiceMemo.Name = "lblInvoiceMemo"
        Me.lblInvoiceMemo.Size = New System.Drawing.Size(43, 15)
        Me.lblInvoiceMemo.TabIndex = 7
        Me.lblInvoiceMemo.Text = "Memo"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(187, 186)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(361, 186)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtInvoiceAmount
        '
        Me.txtInvoiceAmount.DecimalPlaces = 2
        Me.txtInvoiceAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceAmount.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txtInvoiceAmount.Location = New System.Drawing.Point(223, 29)
        Me.txtInvoiceAmount.Margin = New System.Windows.Forms.Padding(10, 3, 10, 10)
        Me.txtInvoiceAmount.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtInvoiceAmount.Name = "txtInvoiceAmount"
        Me.txtInvoiceAmount.Size = New System.Drawing.Size(114, 22)
        Me.txtInvoiceAmount.TabIndex = 1
        Me.txtInvoiceAmount.ThousandsSeparator = True
        '
        'txtInvoiceDate
        '
        Me.txtInvoiceDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceDate.Location = New System.Drawing.Point(350, 27)
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Size = New System.Drawing.Size(86, 22)
        Me.txtInvoiceDate.TabIndex = 2
        '
        'frmInvoiceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 224)
        Me.Controls.Add(Me.txtInvoiceDate)
        Me.Controls.Add(Me.txtInvoiceAmount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblInvoiceMemo)
        Me.Controls.Add(Me.lblInvoiceDate)
        Me.Controls.Add(Me.lblInvoiceAmount)
        Me.Controls.Add(Me.lblInvoiceNumber)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.txtInvoiceMemo)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInvoiceDetails"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Details"
        CType(Me.txtInvoiceAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInvoiceMemo As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceNumber As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceAmount As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceDate As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceMemo As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtInvoiceAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtInvoiceDate As System.Windows.Forms.TextBox
End Class
