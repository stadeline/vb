Public Class Payment

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

End Class