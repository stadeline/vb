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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.totalBillText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.checkoutButton = New System.Windows.Forms.Button()
        Me.voidTransactionButton = New System.Windows.Forms.Button()
        Me.voidItemButton = New System.Windows.Forms.Button()
        Me.addToCartButton = New System.Windows.Forms.Button()
        Me.addToCartButton3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.orderList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.outProductTotal = New System.Windows.Forms.Label()
        Me.outProductPrice = New System.Windows.Forms.Label()
        Me.outDescription = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.inSearchText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.outTransactionNumber = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.inQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.outTransactionNumber)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(532, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(266, 100)
        Me.Panel7.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transaction #:"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.totalBillText)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(266, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(266, 100)
        Me.Panel6.TabIndex = 1
        '
        'totalBillText
        '
        Me.totalBillText.AutoSize = True
        Me.totalBillText.Location = New System.Drawing.Point(136, 40)
        Me.totalBillText.Name = "totalBillText"
        Me.totalBillText.Size = New System.Drawing.Size(52, 21)
        Me.totalBillText.TabIndex = 2
        Me.totalBillText.Text = "PHP 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Bill: "
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(266, 100)
        Me.Panel5.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cashier: Rokn"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.addToCartButton3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 500)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 100)
        Me.Panel2.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.checkoutButton)
        Me.Panel8.Controls.Add(Me.voidTransactionButton)
        Me.Panel8.Controls.Add(Me.voidItemButton)
        Me.Panel8.Controls.Add(Me.addToCartButton)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(800, 100)
        Me.Panel8.TabIndex = 6
        '
        'checkoutButton
        '
        Me.checkoutButton.Enabled = False
        Me.checkoutButton.Location = New System.Drawing.Point(567, 35)
        Me.checkoutButton.Name = "checkoutButton"
        Me.checkoutButton.Size = New System.Drawing.Size(132, 31)
        Me.checkoutButton.TabIndex = 8
        Me.checkoutButton.Text = "&Checkout"
        Me.checkoutButton.UseVisualStyleBackColor = True
        '
        'voidTransactionButton
        '
        Me.voidTransactionButton.Enabled = False
        Me.voidTransactionButton.Location = New System.Drawing.Point(412, 35)
        Me.voidTransactionButton.Name = "voidTransactionButton"
        Me.voidTransactionButton.Size = New System.Drawing.Size(132, 31)
        Me.voidTransactionButton.TabIndex = 7
        Me.voidTransactionButton.Text = "V&oid Transaction"
        Me.voidTransactionButton.UseVisualStyleBackColor = True
        '
        'voidItemButton
        '
        Me.voidItemButton.Enabled = False
        Me.voidItemButton.Location = New System.Drawing.Point(257, 35)
        Me.voidItemButton.Name = "voidItemButton"
        Me.voidItemButton.Size = New System.Drawing.Size(132, 31)
        Me.voidItemButton.TabIndex = 6
        Me.voidItemButton.Text = "&Void Item"
        Me.voidItemButton.UseVisualStyleBackColor = True
        '
        'addToCartButton
        '
        Me.addToCartButton.Enabled = False
        Me.addToCartButton.Location = New System.Drawing.Point(102, 35)
        Me.addToCartButton.Name = "addToCartButton"
        Me.addToCartButton.Size = New System.Drawing.Size(132, 31)
        Me.addToCartButton.TabIndex = 5
        Me.addToCartButton.Text = "&Add to Cart"
        Me.addToCartButton.UseVisualStyleBackColor = True
        '
        'addToCartButton3
        '
        Me.addToCartButton3.Enabled = False
        Me.addToCartButton3.Location = New System.Drawing.Point(298, -188)
        Me.addToCartButton3.Name = "addToCartButton3"
        Me.addToCartButton3.Size = New System.Drawing.Size(232, 254)
        Me.addToCartButton3.TabIndex = 5
        Me.addToCartButton3.Text = "&Add to Cart"
        Me.addToCartButton3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.orderList)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 400)
        Me.Panel3.TabIndex = 2
        '
        'orderList
        '
        Me.orderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.orderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.orderList.FullRowSelect = True
        Me.orderList.GridLines = True
        Me.orderList.HideSelection = False
        Me.orderList.Location = New System.Drawing.Point(0, 0)
        Me.orderList.Name = "orderList"
        Me.orderList.Size = New System.Drawing.Size(400, 400)
        Me.orderList.TabIndex = 0
        Me.orderList.UseCompatibleStateImageBehavior = False
        Me.orderList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Qty."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item"
        Me.ColumnHeader2.Width = 219
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.Width = 64
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total"
        Me.ColumnHeader4.Width = 47
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.outProductTotal)
        Me.Panel4.Controls.Add(Me.outProductPrice)
        Me.Panel4.Controls.Add(Me.outDescription)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.inQuantity)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.inSearchText)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(400, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(400, 400)
        Me.Panel4.TabIndex = 3
        '
        'outProductTotal
        '
        Me.outProductTotal.AutoSize = True
        Me.outProductTotal.Location = New System.Drawing.Point(59, 272)
        Me.outProductTotal.Name = "outProductTotal"
        Me.outProductTotal.Size = New System.Drawing.Size(0, 21)
        Me.outProductTotal.TabIndex = 12
        '
        'outProductPrice
        '
        Me.outProductPrice.AutoSize = True
        Me.outProductPrice.Location = New System.Drawing.Point(61, 192)
        Me.outProductPrice.Name = "outProductPrice"
        Me.outProductPrice.Size = New System.Drawing.Size(0, 21)
        Me.outProductPrice.TabIndex = 11
        '
        'outDescription
        '
        Me.outDescription.AutoSize = True
        Me.outDescription.Location = New System.Drawing.Point(106, 152)
        Me.outDescription.Name = "outDescription"
        Me.outDescription.Size = New System.Drawing.Size(0, 21)
        Me.outDescription.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total:"
        '
        'inQuantity
        '
        Me.inQuantity.Location = New System.Drawing.Point(84, 230)
        Me.inQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inQuantity.Name = "inQuantity"
        Me.inQuantity.Size = New System.Drawing.Size(120, 29)
        Me.inQuantity.TabIndex = 8
        Me.inQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Description:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inSearchText
        '
        Me.inSearchText.Location = New System.Drawing.Point(132, 109)
        Me.inSearchText.Name = "inSearchText"
        Me.inSearchText.Size = New System.Drawing.Size(99, 29)
        Me.inSearchText.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Enter Item Code:"
        '
        'outTransactionNumber
        '
        Me.outTransactionNumber.AutoSize = True
        Me.outTransactionNumber.Location = New System.Drawing.Point(136, 40)
        Me.outTransactionNumber.Name = "outTransactionNumber"
        Me.outTransactionNumber.Size = New System.Drawing.Size(64, 21)
        Me.outTransactionNumber.TabIndex = 3
        Me.outTransactionNumber.Text = "000001"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.inQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents orderList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents outProductTotal As System.Windows.Forms.Label
    Friend WithEvents outProductPrice As System.Windows.Forms.Label
    Friend WithEvents outDescription As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents inQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents inSearchText As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents addToCartButton3 As System.Windows.Forms.Button
    Friend WithEvents totalBillText As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents voidItemButton As System.Windows.Forms.Button
    Friend WithEvents addToCartButton As System.Windows.Forms.Button
    Friend WithEvents voidTransactionButton As System.Windows.Forms.Button
    Friend WithEvents checkoutButton As System.Windows.Forms.Button
    Friend WithEvents outTransactionNumber As System.Windows.Forms.Label

End Class
