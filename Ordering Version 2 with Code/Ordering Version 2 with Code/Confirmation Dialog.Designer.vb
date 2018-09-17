<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmation_Dialog
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
        Me.inVerificationPassword = New System.Windows.Forms.TextBox()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inVerificationPassword
        '
        Me.inVerificationPassword.Location = New System.Drawing.Point(50, 54)
        Me.inVerificationPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.inVerificationPassword.Name = "inVerificationPassword"
        Me.inVerificationPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inVerificationPassword.Size = New System.Drawing.Size(300, 29)
        Me.inVerificationPassword.TabIndex = 0
        '
        'confirmButton
        '
        Me.confirmButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.confirmButton.FlatAppearance.BorderSize = 0
        Me.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmButton.ForeColor = System.Drawing.Color.White
        Me.confirmButton.Location = New System.Drawing.Point(150, 117)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(100, 29)
        Me.confirmButton.TabIndex = 10
        Me.confirmButton.Text = "&CONFIRM"
        Me.confirmButton.UseVisualStyleBackColor = False
        '
        'Confirmation_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.inVerificationPassword)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Confirmation_Dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ENTER MANAGER'S CODE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inVerificationPassword As System.Windows.Forms.TextBox
    Friend WithEvents confirmButton As System.Windows.Forms.Button
End Class
