<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inSearchTerm = New System.Windows.Forms.TextBox()
        Me.inCashGiven = New System.Windows.Forms.TextBox()
        Me.inQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.outChange = New System.Windows.Forms.Label()
        Me.outDescription = New System.Windows.Forms.Label()
        Me.outPrice = New System.Windows.Forms.Label()
        Me.outTotal = New System.Windows.Forms.Label()
        CType(Me.inQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search by Item Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cash"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Change"
        '
        'inSearchTerm
        '
        Me.inSearchTerm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inSearchTerm.Location = New System.Drawing.Point(215, 25)
        Me.inSearchTerm.Name = "inSearchTerm"
        Me.inSearchTerm.Size = New System.Drawing.Size(100, 29)
        Me.inSearchTerm.TabIndex = 9
        '
        'inCashGiven
        '
        Me.inCashGiven.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inCashGiven.Location = New System.Drawing.Point(215, 276)
        Me.inCashGiven.Name = "inCashGiven"
        Me.inCashGiven.Size = New System.Drawing.Size(100, 29)
        Me.inCashGiven.TabIndex = 13
        Me.inCashGiven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inQuantity
        '
        Me.inQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inQuantity.Location = New System.Drawing.Point(215, 176)
        Me.inQuantity.Name = "inQuantity"
        Me.inQuantity.Size = New System.Drawing.Size(100, 29)
        Me.inQuantity.TabIndex = 14
        Me.inQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(356, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'outChange
        '
        Me.outChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outChange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outChange.Location = New System.Drawing.Point(215, 336)
        Me.outChange.Name = "outChange"
        Me.outChange.Size = New System.Drawing.Size(100, 29)
        Me.outChange.TabIndex = 16
        Me.outChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'outDescription
        '
        Me.outDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outDescription.Location = New System.Drawing.Point(215, 80)
        Me.outDescription.Name = "outDescription"
        Me.outDescription.Size = New System.Drawing.Size(216, 29)
        Me.outDescription.TabIndex = 17
        Me.outDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'outPrice
        '
        Me.outPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outPrice.Location = New System.Drawing.Point(215, 131)
        Me.outPrice.Name = "outPrice"
        Me.outPrice.Size = New System.Drawing.Size(100, 29)
        Me.outPrice.TabIndex = 18
        Me.outPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'outTotal
        '
        Me.outTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outTotal.Location = New System.Drawing.Point(215, 227)
        Me.outTotal.Name = "outTotal"
        Me.outTotal.Size = New System.Drawing.Size(100, 29)
        Me.outTotal.TabIndex = 19
        Me.outTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 624)
        Me.Controls.Add(Me.outTotal)
        Me.Controls.Add(Me.outPrice)
        Me.Controls.Add(Me.outDescription)
        Me.Controls.Add(Me.outChange)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.inQuantity)
        Me.Controls.Add(Me.inCashGiven)
        Me.Controls.Add(Me.inSearchTerm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Simple Ordering Application"
        CType(Me.inQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents inSearchTerm As System.Windows.Forms.TextBox
    Friend WithEvents inCashGiven As System.Windows.Forms.TextBox
    Friend WithEvents inQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents outChange As System.Windows.Forms.Label
    Friend WithEvents outDescription As System.Windows.Forms.Label
    Friend WithEvents outPrice As System.Windows.Forms.Label
    Friend WithEvents outTotal As System.Windows.Forms.Label

End Class
