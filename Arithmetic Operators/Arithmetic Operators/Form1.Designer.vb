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
        Me.outResult = New System.Windows.Forms.Label()
        Me.inFirstNumber = New System.Windows.Forms.TextBox()
        Me.inSecondNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Second Number"
        '
        'outResult
        '
        Me.outResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outResult.Location = New System.Drawing.Point(191, 149)
        Me.outResult.Name = "outResult"
        Me.outResult.Size = New System.Drawing.Size(100, 29)
        Me.outResult.TabIndex = 2
        Me.outResult.Text = "0.00"
        Me.outResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'inFirstNumber
        '
        Me.inFirstNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inFirstNumber.Location = New System.Drawing.Point(191, 73)
        Me.inFirstNumber.Name = "inFirstNumber"
        Me.inFirstNumber.Size = New System.Drawing.Size(100, 29)
        Me.inFirstNumber.TabIndex = 3
        Me.inFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'inSecondNumber
        '
        Me.inSecondNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inSecondNumber.Location = New System.Drawing.Point(191, 111)
        Me.inSecondNumber.Name = "inSecondNumber"
        Me.inSecondNumber.Size = New System.Drawing.Size(100, 29)
        Me.inSecondNumber.TabIndex = 4
        Me.inSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Result"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(174, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Subtract"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(64, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(284, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 43)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "&Multiply"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(394, 197)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 43)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "&Divide"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(504, 197)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 43)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "M&odulus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 628)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inSecondNumber)
        Me.Controls.Add(Me.inFirstNumber)
        Me.Controls.Add(Me.outResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arithmetic Operators"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents outResult As System.Windows.Forms.Label
    Friend WithEvents inFirstNumber As System.Windows.Forms.TextBox
    Friend WithEvents inSecondNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
