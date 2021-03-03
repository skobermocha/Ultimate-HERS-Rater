<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.txtOld = New System.Windows.Forms.TextBox
        Me.txtNew = New System.Windows.Forms.TextBox
        Me.txtConfirm = New System.Windows.Forms.TextBox
        Me.lblOld = New System.Windows.Forms.Label
        Me.lblNew = New System.Windows.Forms.Label
        Me.lblConfirm = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOld
        '
        Me.txtOld.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOld.Location = New System.Drawing.Point(13, 39)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOld.Size = New System.Drawing.Size(206, 22)
        Me.txtOld.TabIndex = 0
        '
        'txtNew
        '
        Me.txtNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNew.Location = New System.Drawing.Point(13, 83)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew.Size = New System.Drawing.Size(206, 22)
        Me.txtNew.TabIndex = 1
        '
        'txtConfirm
        '
        Me.txtConfirm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(13, 127)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(206, 22)
        Me.txtConfirm.TabIndex = 2
        '
        'lblOld
        '
        Me.lblOld.AutoSize = True
        Me.lblOld.Location = New System.Drawing.Point(10, 21)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.Size = New System.Drawing.Size(81, 15)
        Me.lblOld.TabIndex = 3
        Me.lblOld.Text = "Old Password"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(10, 65)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(88, 15)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "New Password"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(10, 109)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(106, 15)
        Me.lblConfirm.TabIndex = 5
        Me.lblConfirm.Text = "Confirm Password"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(91, 166)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 25)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(169, 166)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 25)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmChangePassword
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 204)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblOld)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtOld)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmChangePassword"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change My Password"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblOld As System.Windows.Forms.Label
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
