Public Class Form1

    'Images Path String
    Dim imgPathLocal As String = "C:\Users\TagStart\Desktop\School\vb\Payroll\Payroll\img\"

    'Clear Utility Subroutine.
    Sub clearInputs()
        inSearchId.Text = ""
        inNumOfDaysWorked.Text = ""
        inNumOfHoursOt.Text = ""
        inSSS.Text = ""
        inPhilHealth.Text = ""
        inPagibig.Text = ""
        outName.Text = ""
        outPosition.Text = ""
        outRatePerDay.Text = ""
        outRatePerHour.Text = ""
        outImg.ImageLocation = ""
        outBasicPay.Text = ""
        outOtPay.Text = ""
        outTotalDeductions.Text = ""
        outGrossPay.Text = ""
        outNetPay.Text = ""
        btnCompute.Enabled = False
    End Sub

    'Search subroutine.
    Sub search(ByVal name As String, ByVal position As String, ByVal ratePerDay As Double, ByVal ratePerHour As Double, ByVal fileName As String)
        outName.Text = name
        outPosition.Text = position
        outRatePerDay.Text = ratePerDay
        outRatePerHour.Text = ratePerHour
        outImg.ImageLocation = imgPathLocal + fileName
        btnCompute.Enabled = True
    End Sub

    'Calculate All Sub
    Sub calculateAllPay()
        'Input Validation is done in the same sub. This allows for exiting on invalid or missing input.
        'Number of days Worked.
        If inNumOfDaysWorked.Text = "" Then
            MsgBox("Enter number of days worked.")
            Exit Sub
        ElseIf Not IsNumeric(inNumOfDaysWorked.Text) Then
            MsgBox("Invalid Number of Days.")
            Exit Sub
        End If

        'OT
        If inNumOfHoursOt.Text = "" Then
            MsgBox("Enter number of OT hours.")
            Exit Sub
        ElseIf Not IsNumeric(inNumOfHoursOt.Text) Then
            MsgBox("Invalid OT hours.")
            Exit Sub
        End If

        'SSS
        If inSSS.Text = "" Then
            MsgBox("Enter SSS Amount.")
            Exit Sub
        ElseIf Not IsNumeric(inSSS.Text) Then
            MsgBox("Invalid SSS Amount.")
            Exit Sub
        End If

        'Philhealth
        If inPhilHealth.Text = "" Then
            MsgBox("Enter Philhealth Amount.")
            Exit Sub
        ElseIf Not IsNumeric(inPhilHealth.Text) Then
            MsgBox("Invalid Philhealth Amount.")
            Exit Sub
        End If

        'Pagibig
        If inPagibig.Text = "" Then
            MsgBox("Enter Pagibig Amount.")
            Exit Sub
        ElseIf Not IsNumeric(inPagibig.Text) Then
            MsgBox("Invalid Pagibig Amount.")
            Exit Sub
        End If


        outBasicPay.Text = basicPay(inNumOfDaysWorked.Text, outRatePerDay.Text)
        outOtPay.Text = inNumOfHoursOt.Text * outRatePerHour.Text
        'Use VAL to avoid string concat.
        outTotalDeductions.Text = Val(inSSS.Text) + Val(inPagibig.Text) + Val(inPhilHealth.Text)
        outGrossPay.Text = Val(outBasicPay.Text) + Val(outOtPay.Text)
        outNetPay.Text = Val(outGrossPay.Text) - Val(outTotalDeductions.Text)
    End Sub


    'Calulation Functions.
    'This use case can actually be done by a sub since we're not re-using the function elsewhere. See above.
    Function basicPay(ByVal numberOfDaysWorked As Double, ByVal ratePerDay As Double)
        Return numberOfDaysWorked * ratePerDay
    End Function

    'Search Button
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Select Case inSearchId.Text
            Case "101"
                search("Sherlock Holmes", "Consulting Detective", 700, 100, "Sherlock_Holmes_250px.png")
            Case "102"
                search("Joan Watson", "Sober Companion", 800, 150, "Joan_Watson_250px.png")
            Case "103"
                search("Jamie Moriarity", "Criminal Mastermind", 1000, 200, "S01E23-Moriarty_head_shot.jpg")
            Case Else
                clearInputs()
                MsgBox("Employee ID is Invalid. Please try again.")
        End Select
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        'Calculate Pay
        calculateAllPay()
    End Sub
End Class
