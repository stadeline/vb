<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.inCash = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paymentTotalBill = New System.Windows.Forms.Label()
        Me.outChange = New System.Windows.Forms.Label()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inCash
        '
        Me.inCash.Location = New System.Drawing.Point(204, 87)
        Me.inCash.Name = "inCash"
        Me.inCash.Size = New System.Drawing.Size(100, 29)
        Me.inCash.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TOTAL BILL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CASH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "CHANGE"
        '
        'paymentTotalBill
        '
        Me.paymentTotalBill.AutoSize = True
        Me.paymentTotalBill.Location = New System.Drawing.Point(200, 53)
        Me.paymentTotalBill.Name = "paymentTotalBill"
        Me.paymentTotalBill.Size = New System.Drawing.Size(0, 21)
        Me.paymentTotalBill.TabIndex = 14
        '
        'outChange
        '
        Me.outChange.AutoSize = True
        Me.outChange.Location = New System.Drawing.Point(200, 127)
        Me.outChange.Name = "outChange"
        Me.outChange.Size = New System.Drawing.Size(0, 21)
        Me.outChange.TabIndex = 15
        '
        'confirmButton
        '
        Me.confirmButton.Location = New System.Drawing.Point(150, 159)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(100, 29)
        Me.confirmButton.TabIndex = 16
        Me.confirmButton.Text = "&COMPUTE"
        Me.confirmButton.UseVisualStyleBackColor = True
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.outChange)
        Me.Controls.Add(Me.paymentTotalBill)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inCash)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inCash As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents paymentTotalBill As System.Windows.Forms.Label
    Friend WithEvents outChange As System.Windows.Forms.Label
    Friend WithEvents confirmButton As System.Windows.Forms.Button
End Class
