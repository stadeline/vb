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
        Me.outImg = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.inNumOfDaysWorked = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.outBasicPay = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inNumOfHoursOt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.outOtPay = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.inPagibig = New System.Windows.Forms.TextBox()
        Me.inPhilHealth = New System.Windows.Forms.TextBox()
        Me.inSSS = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.outTotalDeductions = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.inSearchId = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.outName = New System.Windows.Forms.Label()
        Me.outPosition = New System.Windows.Forms.Label()
        Me.outRatePerDay = New System.Windows.Forms.Label()
        Me.outRatePerHour = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.outGrossPay = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.outNetPay = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        CType(Me.outImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'outImg
        '
        Me.outImg.Location = New System.Drawing.Point(12, 37)
        Me.outImg.Name = "outImg"
        Me.outImg.Size = New System.Drawing.Size(264, 242)
        Me.outImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.outImg.TabIndex = 0
        Me.outImg.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inNumOfDaysWorked)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.outBasicPay)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 170)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Pay"
        '
        'inNumOfDaysWorked
        '
        Me.inNumOfDaysWorked.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inNumOfDaysWorked.Location = New System.Drawing.Point(158, 25)
        Me.inNumOfDaysWorked.Name = "inNumOfDaysWorked"
        Me.inNumOfDaysWorked.Size = New System.Drawing.Size(143, 29)
        Me.inNumOfDaysWorked.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "No. Of Days Worked"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 21)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Basic Pay:"
        '
        'outBasicPay
        '
        Me.outBasicPay.AutoSize = True
        Me.outBasicPay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outBasicPay.Location = New System.Drawing.Point(183, 133)
        Me.outBasicPay.Name = "outBasicPay"
        Me.outBasicPay.Size = New System.Drawing.Size(0, 21)
        Me.outBasicPay.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inNumOfHoursOt)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.outOtPay)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 170)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OT Pay"
        '
        'inNumOfHoursOt
        '
        Me.inNumOfHoursOt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inNumOfHoursOt.Location = New System.Drawing.Point(125, 25)
        Me.inNumOfHoursOt.Name = "inNumOfHoursOt"
        Me.inNumOfHoursOt.Size = New System.Drawing.Size(143, 29)
        Me.inNumOfHoursOt.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 21)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "No. Of hours:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 21)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "OT Pay:"
        '
        'outOtPay
        '
        Me.outOtPay.AutoSize = True
        Me.outOtPay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outOtPay.Location = New System.Drawing.Point(75, 133)
        Me.outOtPay.Name = "outOtPay"
        Me.outOtPay.Size = New System.Drawing.Size(0, 21)
        Me.outOtPay.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.inPagibig)
        Me.GroupBox3.Controls.Add(Me.inPhilHealth)
        Me.GroupBox3.Controls.Add(Me.inSSS)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.outTotalDeductions)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Location = New System.Drawing.Point(708, 314)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deductions"
        '
        'inPagibig
        '
        Me.inPagibig.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inPagibig.Location = New System.Drawing.Point(103, 93)
        Me.inPagibig.Name = "inPagibig"
        Me.inPagibig.Size = New System.Drawing.Size(143, 29)
        Me.inPagibig.TabIndex = 36
        '
        'inPhilHealth
        '
        Me.inPhilHealth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inPhilHealth.Location = New System.Drawing.Point(103, 56)
        Me.inPhilHealth.Name = "inPhilHealth"
        Me.inPhilHealth.Size = New System.Drawing.Size(143, 29)
        Me.inPhilHealth.TabIndex = 35
        '
        'inSSS
        '
        Me.inSSS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inSSS.Location = New System.Drawing.Point(103, 19)
        Me.inSSS.Name = "inSSS"
        Me.inSSS.Size = New System.Drawing.Size(143, 29)
        Me.inSSS.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 21)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "SSS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 21)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "PhilHealth"
        '
        'outTotalDeductions
        '
        Me.outTotalDeductions.AutoSize = True
        Me.outTotalDeductions.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outTotalDeductions.Location = New System.Drawing.Point(140, 133)
        Me.outTotalDeductions.Name = "outTotalDeductions"
        Me.outTotalDeductions.Size = New System.Drawing.Size(0, 21)
        Me.outTotalDeductions.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 21)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Pagibig"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 133)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 21)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Total Deductions"
        '
        'inSearchId
        '
        Me.inSearchId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inSearchId.Location = New System.Drawing.Point(515, 30)
        Me.inSearchId.Name = "inSearchId"
        Me.inSearchId.Size = New System.Drawing.Size(144, 29)
        Me.inSearchId.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(671, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(119, 40)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(399, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(263, 29)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(731, 72)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(263, 29)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search by Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(330, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(330, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Rate Per Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Rate Per Hour"
        '
        'outName
        '
        Me.outName.AutoSize = True
        Me.outName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outName.Location = New System.Drawing.Point(445, 115)
        Me.outName.Name = "outName"
        Me.outName.Size = New System.Drawing.Size(0, 21)
        Me.outName.TabIndex = 12
        '
        'outPosition
        '
        Me.outPosition.AutoSize = True
        Me.outPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outPosition.Location = New System.Drawing.Point(445, 155)
        Me.outPosition.Name = "outPosition"
        Me.outPosition.Size = New System.Drawing.Size(0, 21)
        Me.outPosition.TabIndex = 13
        '
        'outRatePerDay
        '
        Me.outRatePerDay.AutoSize = True
        Me.outRatePerDay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outRatePerDay.Location = New System.Drawing.Point(445, 189)
        Me.outRatePerDay.Name = "outRatePerDay"
        Me.outRatePerDay.Size = New System.Drawing.Size(0, 21)
        Me.outRatePerDay.TabIndex = 14
        '
        'outRatePerHour
        '
        Me.outRatePerHour.AutoSize = True
        Me.outRatePerHour.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outRatePerHour.Location = New System.Drawing.Point(445, 230)
        Me.outRatePerHour.Name = "outRatePerHour"
        Me.outRatePerHour.Size = New System.Drawing.Size(0, 21)
        Me.outRatePerHour.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(684, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "To"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(423, 494)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 21)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Gross Pay:"
        '
        'outGrossPay
        '
        Me.outGrossPay.AutoSize = True
        Me.outGrossPay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outGrossPay.Location = New System.Drawing.Point(510, 494)
        Me.outGrossPay.Name = "outGrossPay"
        Me.outGrossPay.Size = New System.Drawing.Size(0, 21)
        Me.outGrossPay.TabIndex = 29
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(423, 534)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 21)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Net Pay:"
        '
        'outNetPay
        '
        Me.outNetPay.AutoSize = True
        Me.outNetPay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outNetPay.Location = New System.Drawing.Point(508, 534)
        Me.outNetPay.Name = "outNetPay"
        Me.outNetPay.Size = New System.Drawing.Size(0, 21)
        Me.outNetPay.TabIndex = 31
        '
        'btnCompute
        '
        Me.btnCompute.Enabled = False
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(454, 566)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(118, 40)
        Me.btnCompute.TabIndex = 32
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 767)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.outNetPay)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.outGrossPay)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.outRatePerHour)
        Me.Controls.Add(Me.outRatePerDay)
        Me.Controls.Add(Me.outPosition)
        Me.Controls.Add(Me.outName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.inSearchId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.outImg)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Program"
        CType(Me.outImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents outImg As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents inSearchId As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents outName As System.Windows.Forms.Label
    Friend WithEvents outPosition As System.Windows.Forms.Label
    Friend WithEvents outRatePerDay As System.Windows.Forms.Label
    Friend WithEvents outRatePerHour As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents outBasicPay As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents outOtPay As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents outTotalDeductions As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents outGrossPay As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents outNetPay As System.Windows.Forms.Label
    Friend WithEvents inNumOfDaysWorked As System.Windows.Forms.TextBox
    Friend WithEvents inNumOfHoursOt As System.Windows.Forms.TextBox
    Friend WithEvents inPagibig As System.Windows.Forms.TextBox
    Friend WithEvents inPhilHealth As System.Windows.Forms.TextBox
    Friend WithEvents inSSS As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button

End Class
