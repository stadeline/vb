<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.outTotalBills = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.outTransactionNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.currentOrderList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.inQuantity = New System.Windows.Forms.NumericUpDown()
        Me.outTotalPrice = New System.Windows.Forms.Label()
        Me.outItemPrice = New System.Windows.Forms.Label()
        Me.outItemDescription = New System.Windows.Forms.Label()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.inSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.inQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.Panel3)
        Me.TopPanel.Controls.Add(Me.Panel2)
        Me.TopPanel.Controls.Add(Me.Panel1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1000, 100)
        Me.TopPanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.outTotalBills)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(333, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(334, 100)
        Me.Panel3.TabIndex = 6
        '
        'outTotalBills
        '
        Me.outTotalBills.AutoSize = True
        Me.outTotalBills.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outTotalBills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.outTotalBills.Location = New System.Drawing.Point(180, 40)
        Me.outTotalBills.Name = "outTotalBills"
        Me.outTotalBills.Size = New System.Drawing.Size(77, 21)
        Me.outTotalBills.TabIndex = 2
        Me.outTotalBills.Text = "PHP 0.00"
        Me.outTotalBills.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(78, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TOTAL BILL: "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.outTransactionNumber)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(667, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 100)
        Me.Panel2.TabIndex = 4
        '
        'outTransactionNumber
        '
        Me.outTransactionNumber.AutoSize = True
        Me.outTransactionNumber.Location = New System.Drawing.Point(197, 40)
        Me.outTransactionNumber.Name = "outTransactionNumber"
        Me.outTransactionNumber.Size = New System.Drawing.Size(64, 21)
        Me.outTransactionNumber.TabIndex = 3
        Me.outTransactionNumber.Text = "000001"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TRANSACTION #: "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 100)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CASHIER: PAPA DAN"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 700)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1000, 100)
        Me.Panel4.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(699, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 29)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "&PAYMENT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(508, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 29)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "&VOID TRANSACTION"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(317, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 29)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "&VOID ITEM"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(126, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&ADD TO CART"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.currentOrderList)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(500, 600)
        Me.Panel5.TabIndex = 2
        '
        'currentOrderList
        '
        Me.currentOrderList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.currentOrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.currentOrderList.FullRowSelect = True
        Me.currentOrderList.GridLines = True
        Me.currentOrderList.HideSelection = False
        Me.currentOrderList.Location = New System.Drawing.Point(0, 0)
        Me.currentOrderList.Name = "currentOrderList"
        Me.currentOrderList.Size = New System.Drawing.Size(500, 600)
        Me.currentOrderList.TabIndex = 0
        Me.currentOrderList.UseCompatibleStateImageBehavior = False
        Me.currentOrderList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "QNTY"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ITEM"
        Me.ColumnHeader2.Width = 240
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRICE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TOTAL PRICE"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.inQuantity)
        Me.Panel6.Controls.Add(Me.outTotalPrice)
        Me.Panel6.Controls.Add(Me.outItemPrice)
        Me.Panel6.Controls.Add(Me.outItemDescription)
        Me.Panel6.Controls.Add(Me.searchButton)
        Me.Panel6.Controls.Add(Me.inSearch)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(500, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(500, 600)
        Me.Panel6.TabIndex = 3
        '
        'inQuantity
        '
        Me.inQuantity.Location = New System.Drawing.Point(144, 160)
        Me.inQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inQuantity.Name = "inQuantity"
        Me.inQuantity.Size = New System.Drawing.Size(120, 29)
        Me.inQuantity.TabIndex = 13
        Me.inQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'outTotalPrice
        '
        Me.outTotalPrice.AutoSize = True
        Me.outTotalPrice.Location = New System.Drawing.Point(158, 214)
        Me.outTotalPrice.Name = "outTotalPrice"
        Me.outTotalPrice.Size = New System.Drawing.Size(0, 21)
        Me.outTotalPrice.TabIndex = 12
        '
        'outItemPrice
        '
        Me.outItemPrice.AutoSize = True
        Me.outItemPrice.Location = New System.Drawing.Point(149, 110)
        Me.outItemPrice.Name = "outItemPrice"
        Me.outItemPrice.Size = New System.Drawing.Size(0, 21)
        Me.outItemPrice.TabIndex = 11
        '
        'outItemDescription
        '
        Me.outItemDescription.AutoSize = True
        Me.outItemDescription.Location = New System.Drawing.Point(205, 58)
        Me.outItemDescription.Name = "outItemDescription"
        Me.outItemDescription.Size = New System.Drawing.Size(0, 21)
        Me.outItemDescription.TabIndex = 10
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.SystemColors.Control
        Me.searchButton.FlatAppearance.BorderSize = 0
        Me.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Location = New System.Drawing.Point(350, 2)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(100, 29)
        Me.searchButton.TabIndex = 9
        Me.searchButton.Text = "&SEARCH"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'inSearch
        '
        Me.inSearch.Location = New System.Drawing.Point(238, 2)
        Me.inSearch.Name = "inSearch"
        Me.inSearch.Size = New System.Drawing.Size(100, 29)
        Me.inSearch.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TOTAL PRICE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "QUANTITY:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ITEM PRICE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ITEM DESCRIPTION:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SEARCH BY ITEM CODE:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 800)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordering Version 2 with Code"
        Me.TopPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.inQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents outTotalBills As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents outTransactionNumber As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents currentOrderList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents inQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents outTotalPrice As System.Windows.Forms.Label
    Friend WithEvents outItemPrice As System.Windows.Forms.Label
    Friend WithEvents outItemDescription As System.Windows.Forms.Label
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents inSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
