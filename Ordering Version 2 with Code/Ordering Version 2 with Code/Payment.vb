Public Class Payment

    Private Sub Confirmation_Dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(136, 152, 170)
        'me.controls doesn't work since it'll only return the parents (panels)
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Panel Then
                'Go deeper
                For Each ctrlInner As Control In ctrl.Controls
                    If TypeOf ctrlInner Is Button Then
                        'Stripe Color
                        ctrlInner.BackColor = Color.FromArgb(103, 114, 229)
                        ctrlInner.ForeColor = Color.White
                    ElseIf TypeOf ctrlInner Is Label Then
                        ctrlInner.ForeColor = Color.FromArgb(50, 50, 93)
                    ElseIf TypeOf ctrlInner Is Panel Then
                        For Each ctrlInnerInner In ctrlInner.Controls
                            ctrlInnerInner.ForeColor = Color.FromArgb(50, 50, 93)
                        Next
                    End If
                Next
            End If
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Color.FromArgb(50, 50, 93)
            End If
        Next
    End Sub

    Private Sub confirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmButton.Click
        Dim change As Double
        change = Val(inCash.Text) - Val(paymentTotalBill.Text)
        If change >= 0 Then
            outChange.Text = change
        Else
            MsgBox("Your cash is not enough. Please provide enough cash.")
            inCash.Text = ""
        End If
    End Sub

    'When closed, reset the order and increment the counter.
    Private Sub Payment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        paymentTotalBill.Text = ""
        inCash.Text = ""
        outChange.Text = ""
        MainForm.clearAll()
        MainForm.transactionNumber += 1
        'Source - https://social.msdn.microsoft.com/Forums/en-US/7bb492d1-7079-46da-aaf5-14b39627b5eb/adding-leading-zeros-to-string?forum=vblanguage
        MainForm.outTransactionNumber.Text = String.Format("{0:000000}", MainForm.transactionNumber)
    End Sub

End Class