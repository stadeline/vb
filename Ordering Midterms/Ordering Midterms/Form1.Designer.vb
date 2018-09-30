<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderingApplicationMainForm
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
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.outTotalBill = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.voidItemButton = New System.Windows.Forms.Button()
        Me.addToCartButton = New System.Windows.Forms.Button()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.currentOrdersList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.inOrderQuantity = New System.Windows.Forms.NumericUpDown()
        Me.outOrderPrice = New System.Windows.Forms.Label()
        Me.outItemPrice = New System.Windows.Forms.Label()
        Me.outDescription = New System.Windows.Forms.Label()
        Me.inSearchString = New System.Windows.Forms.TextBox()
        Me.inSearchButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.voidAllButton = New System.Windows.Forms.Button()
        Me.paymentButton = New System.Windows.Forms.Button()
        Me.topPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.bottomPanel.SuspendLayout()
        Me.leftPanel.SuspendLayout()
        Me.rightPanel.SuspendLayout()
        CType(Me.inOrderQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.Controls.Add(Me.Panel3)
        Me.topPanel.Controls.Add(Me.Panel2)
        Me.topPanel.Controls.Add(Me.Panel1)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(800, 100)
        Me.topPanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.outTotalBill)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(266, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(268, 100)
        Me.Panel3.TabIndex = 3
        '
        'outTotalBill
        '
        Me.outTotalBill.AutoSize = True
        Me.outTotalBill.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outTotalBill.Location = New System.Drawing.Point(111, 40)
        Me.outTotalBill.Name = "outTotalBill"
        Me.outTotalBill.Size = New System.Drawing.Size(0, 21)
        Me.outTotalBill.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TOTAL BILL: "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(534, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(266, 100)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TRANSACTION NUMBER: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CASHIER: FOO BAR"
        '
        'bottomPanel
        '
        Me.bottomPanel.Controls.Add(Me.paymentButton)
        Me.bottomPanel.Controls.Add(Me.voidAllButton)
        Me.bottomPanel.Controls.Add(Me.voidItemButton)
        Me.bottomPanel.Controls.Add(Me.addToCartButton)
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 500)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(800, 100)
        Me.bottomPanel.TabIndex = 1
        '
        'voidItemButton
        '
        Me.voidItemButton.Enabled = False
        Me.voidItemButton.Location = New System.Drawing.Point(278, 35)
        Me.voidItemButton.Name = "voidItemButton"
        Me.voidItemButton.Size = New System.Drawing.Size(119, 31)
        Me.voidItemButton.TabIndex = 11
        Me.voidItemButton.Text = "&VOID ITEM"
        Me.voidItemButton.UseVisualStyleBackColor = True
        '
        'addToCartButton
        '
        Me.addToCartButton.Enabled = False
        Me.addToCartButton.Location = New System.Drawing.Point(153, 35)
        Me.addToCartButton.Name = "addToCartButton"
        Me.addToCartButton.Size = New System.Drawing.Size(119, 31)
        Me.addToCartButton.TabIndex = 10
        Me.addToCartButton.Text = "&ADD TO CART"
        Me.addToCartButton.UseVisualStyleBackColor = True
        '
        'leftPanel
        '
        Me.leftPanel.Controls.Add(Me.currentOrdersList)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 100)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(400, 400)
        Me.leftPanel.TabIndex = 2
        '
        'currentOrdersList
        '
        Me.currentOrdersList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.currentOrdersList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.currentOrdersList.FullRowSelect = True
        Me.currentOrdersList.GridLines = True
        Me.currentOrdersList.Location = New System.Drawing.Point(0, 0)
        Me.currentOrdersList.MultiSelect = False
        Me.currentOrdersList.Name = "currentOrdersList"
        Me.currentOrdersList.Size = New System.Drawing.Size(400, 400)
        Me.currentOrdersList.TabIndex = 0
        Me.currentOrdersList.UseCompatibleStateImageBehavior = False
        Me.currentOrdersList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "QTY"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ITEM"
        Me.ColumnHeader2.Width = 216
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRICE"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TOTAL"
        '
        'rightPanel
        '
        Me.rightPanel.Controls.Add(Me.inOrderQuantity)
        Me.rightPanel.Controls.Add(Me.outOrderPrice)
        Me.rightPanel.Controls.Add(Me.outItemPrice)
        Me.rightPanel.Controls.Add(Me.outDescription)
        Me.rightPanel.Controls.Add(Me.inSearchString)
        Me.rightPanel.Controls.Add(Me.inSearchButton)
        Me.rightPanel.Controls.Add(Me.Label8)
        Me.rightPanel.Controls.Add(Me.Label7)
        Me.rightPanel.Controls.Add(Me.Label6)
        Me.rightPanel.Controls.Add(Me.Label5)
        Me.rightPanel.Controls.Add(Me.Label4)
        Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.rightPanel.Location = New System.Drawing.Point(400, 100)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(400, 400)
        Me.rightPanel.TabIndex = 3
        '
        'inOrderQuantity
        '
        Me.inOrderQuantity.Location = New System.Drawing.Point(102, 247)
        Me.inOrderQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inOrderQuantity.Name = "inOrderQuantity"
        Me.inOrderQuantity.Size = New System.Drawing.Size(50, 29)
        Me.inOrderQuantity.TabIndex = 14
        Me.inOrderQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'outOrderPrice
        '
        Me.outOrderPrice.AutoSize = True
        Me.outOrderPrice.Location = New System.Drawing.Point(116, 320)
        Me.outOrderPrice.Name = "outOrderPrice"
        Me.outOrderPrice.Size = New System.Drawing.Size(0, 21)
        Me.outOrderPrice.TabIndex = 13
        '
        'outItemPrice
        '
        Me.outItemPrice.AutoSize = True
        Me.outItemPrice.Location = New System.Drawing.Point(69, 190)
        Me.outItemPrice.Name = "outItemPrice"
        Me.outItemPrice.Size = New System.Drawing.Size(0, 21)
        Me.outItemPrice.TabIndex = 12
        '
        'outDescription
        '
        Me.outDescription.AutoSize = True
        Me.outDescription.Location = New System.Drawing.Point(125, 125)
        Me.outDescription.Name = "outDescription"
        Me.outDescription.Size = New System.Drawing.Size(0, 21)
        Me.outDescription.TabIndex = 11
        '
        'inSearchString
        '
        Me.inSearchString.Location = New System.Drawing.Point(187, 52)
        Me.inSearchString.Name = "inSearchString"
        Me.inSearchString.Size = New System.Drawing.Size(75, 29)
        Me.inSearchString.TabIndex = 10
        '
        'inSearchButton
        '
        Me.inSearchButton.Location = New System.Drawing.Point(268, 51)
        Me.inSearchButton.Name = "inSearchButton"
        Me.inSearchButton.Size = New System.Drawing.Size(100, 31)
        Me.inSearchButton.TabIndex = 9
        Me.inSearchButton.Text = "&SEARCH"
        Me.inSearchButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "QUANTITY:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TOTAL PRICE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PRICE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DESCRIPTION:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "SEARCH BY ITEM CODE:"
        '
        'voidAllButton
        '
        Me.voidAllButton.Enabled = False
        Me.voidAllButton.Location = New System.Drawing.Point(403, 35)
        Me.voidAllButton.Name = "voidAllButton"
        Me.voidAllButton.Size = New System.Drawing.Size(119, 31)
        Me.voidAllButton.TabIndex = 12
        Me.voidAllButton.Text = "V&OID ORDER"
        Me.voidAllButton.UseVisualStyleBackColor = True
        '
        'paymentButton
        '
        Me.paymentButton.Enabled = False
        Me.paymentButton.Location = New System.Drawing.Point(528, 35)
        Me.paymentButton.Name = "paymentButton"
        Me.paymentButton.Size = New System.Drawing.Size(119, 31)
        Me.paymentButton.TabIndex = 13
        Me.paymentButton.Text = "&PAYMENT"
        Me.paymentButton.UseVisualStyleBackColor = True
        '
        'orderingApplicationMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.bottomPanel)
        Me.Controls.Add(Me.topPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "orderingApplicationMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDERING APPLICATION VERSION 2"
        Me.topPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.bottomPanel.ResumeLayout(False)
        Me.leftPanel.ResumeLayout(False)
        Me.rightPanel.ResumeLayout(False)
        Me.rightPanel.PerformLayout()
        CType(Me.inOrderQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents topPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bottomPanel As System.Windows.Forms.Panel
    Friend WithEvents leftPanel As System.Windows.Forms.Panel
    Friend WithEvents currentOrdersList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents rightPanel As System.Windows.Forms.Panel
    Friend WithEvents inOrderQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents outOrderPrice As System.Windows.Forms.Label
    Friend WithEvents outItemPrice As System.Windows.Forms.Label
    Friend WithEvents outDescription As System.Windows.Forms.Label
    Friend WithEvents inSearchString As System.Windows.Forms.TextBox
    Friend WithEvents inSearchButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents addToCartButton As System.Windows.Forms.Button
    Friend WithEvents outTotalBill As System.Windows.Forms.Label
    Friend WithEvents voidItemButton As System.Windows.Forms.Button
    Friend WithEvents voidAllButton As System.Windows.Forms.Button
    Friend WithEvents paymentButton As System.Windows.Forms.Button

End Class
