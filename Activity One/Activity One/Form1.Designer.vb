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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.outDOB = New System.Windows.Forms.Label()
        Me.outCourse = New System.Windows.Forms.Label()
        Me.outGender = New System.Windows.Forms.Label()
        Me.outAge = New System.Windows.Forms.Label()
        Me.outName = New System.Windows.Forms.Label()
        Me.inputName = New System.Windows.Forms.TextBox()
        Me.inputAge = New System.Windows.Forms.TextBox()
        Me.cbxCourse = New System.Windows.Forms.ComboBox()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(33, 324)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(90, 33)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Display"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(184, 324)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 33)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(335, 324)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 33)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(29, 43)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 21)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(29, 95)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 21)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Text = "Age"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(29, 159)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(61, 21)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse.Location = New System.Drawing.Point(29, 207)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(59, 21)
        Me.lblCourse.TabIndex = 6
        Me.lblCourse.Text = "Course"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.Location = New System.Drawing.Point(29, 261)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(97, 21)
        Me.lblDob.TabIndex = 7
        Me.lblDob.Text = "Date of Birth"
        '
        'outDOB
        '
        Me.outDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outDOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outDOB.Location = New System.Drawing.Point(474, 257)
        Me.outDOB.Name = "outDOB"
        Me.outDOB.Size = New System.Drawing.Size(238, 25)
        Me.outDOB.TabIndex = 13
        '
        'outCourse
        '
        Me.outCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outCourse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outCourse.Location = New System.Drawing.Point(474, 203)
        Me.outCourse.Name = "outCourse"
        Me.outCourse.Size = New System.Drawing.Size(238, 25)
        Me.outCourse.TabIndex = 12
        '
        'outGender
        '
        Me.outGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outGender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outGender.Location = New System.Drawing.Point(474, 155)
        Me.outGender.Name = "outGender"
        Me.outGender.Size = New System.Drawing.Size(238, 25)
        Me.outGender.TabIndex = 11
        '
        'outAge
        '
        Me.outAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outAge.Location = New System.Drawing.Point(474, 91)
        Me.outAge.Name = "outAge"
        Me.outAge.Size = New System.Drawing.Size(238, 25)
        Me.outAge.TabIndex = 10
        '
        'outName
        '
        Me.outName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outName.Location = New System.Drawing.Point(474, 43)
        Me.outName.Name = "outName"
        Me.outName.Size = New System.Drawing.Size(238, 25)
        Me.outName.TabIndex = 9
        '
        'inputName
        '
        Me.inputName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputName.Location = New System.Drawing.Point(143, 39)
        Me.inputName.Name = "inputName"
        Me.inputName.Size = New System.Drawing.Size(302, 29)
        Me.inputName.TabIndex = 15
        '
        'inputAge
        '
        Me.inputAge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputAge.Location = New System.Drawing.Point(143, 92)
        Me.inputAge.Name = "inputAge"
        Me.inputAge.Size = New System.Drawing.Size(146, 29)
        Me.inputAge.TabIndex = 16
        Me.inputAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxCourse
        '
        Me.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCourse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCourse.FormattingEnabled = True
        Me.cbxCourse.Items.AddRange(New Object() {"B.S. IT", "B.S. ACT", "Something Else"})
        Me.cbxCourse.Location = New System.Drawing.Point(143, 203)
        Me.cbxCourse.Name = "cbxCourse"
        Me.cbxCourse.Size = New System.Drawing.Size(279, 29)
        Me.cbxCourse.TabIndex = 17
        '
        'dtpDob
        '
        Me.dtpDob.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDob.Location = New System.Drawing.Point(143, 257)
        Me.dtpDob.MaxDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpDob.MinDate = New Date(1903, 1, 1, 0, 0, 0, 0)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(279, 29)
        Me.dtpDob.TabIndex = 18
        Me.dtpDob.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(143, 157)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(62, 25)
        Me.rdbMale.TabIndex = 19
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(282, 157)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(78, 25)
        Me.rdbFemale.TabIndex = 20
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(826, 526)
        Me.Controls.Add(Me.rdbFemale)
        Me.Controls.Add(Me.rdbMale)
        Me.Controls.Add(Me.dtpDob)
        Me.Controls.Add(Me.cbxCourse)
        Me.Controls.Add(Me.inputAge)
        Me.Controls.Add(Me.inputName)
        Me.Controls.Add(Me.outDOB)
        Me.Controls.Add(Me.outCourse)
        Me.Controls.Add(Me.outGender)
        Me.Controls.Add(Me.outAge)
        Me.Controls.Add(Me.outName)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblDob As System.Windows.Forms.Label
    Friend WithEvents outDOB As System.Windows.Forms.Label
    Friend WithEvents outCourse As System.Windows.Forms.Label
    Friend WithEvents outGender As System.Windows.Forms.Label
    Friend WithEvents outAge As System.Windows.Forms.Label
    Friend WithEvents outName As System.Windows.Forms.Label
    Friend WithEvents inputName As System.Windows.Forms.TextBox
    Friend WithEvents inputAge As System.Windows.Forms.TextBox
    Friend WithEvents cbxCourse As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton

End Class
