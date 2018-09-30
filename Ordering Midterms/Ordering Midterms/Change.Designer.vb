<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.outTotalBill = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inCustomerPayment = New System.Windows.Forms.TextBox()
        Me.approveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "TOTAL BILL:"
        '
        'outTotalBill
        '
        Me.outTotalBill.AutoSize = True
        Me.outTotalBill.Location = New System.Drawing.Point(197, 76)
        Me.outTotalBill.Name = "outTotalBill"
        Me.outTotalBill.Size = New System.Drawing.Size(0, 21)
        Me.outTotalBill.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CUSTOMER PAYMENT:"
        '
        'inCustomerPayment
        '
        Me.inCustomerPayment.Location = New System.Drawing.Point(197, 111)
        Me.inCustomerPayment.Name = "inCustomerPayment"
        Me.inCustomerPayment.Size = New System.Drawing.Size(179, 29)
        Me.inCustomerPayment.TabIndex = 18
        '
        'approveButton
        '
        Me.approveButton.Location = New System.Drawing.Point(131, 194)
        Me.approveButton.Name = "approveButton"
        Me.approveButton.Size = New System.Drawing.Size(119, 31)
        Me.approveButton.TabIndex = 19
        Me.approveButton.Text = "&COMPLETE"
        Me.approveButton.UseVisualStyleBackColor = True
        '
        'Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.approveButton)
        Me.Controls.Add(Me.inCustomerPayment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.outTotalBill)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Complete Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents outTotalBill As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inCustomerPayment As System.Windows.Forms.TextBox
    Friend WithEvents approveButton As System.Windows.Forms.Button
End Class
