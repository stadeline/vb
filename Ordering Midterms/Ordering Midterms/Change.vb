Public Class Change

    Private Sub approveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles approveButton.Click
        Dim change = Val(inCustomerPayment.Text) - orderingApplicationMainForm.totalBill

        If change < 0 Then
            MsgBox("Your customer is lacking " + change.ToString() + " pesos. Please try again.")
        Else
            MsgBox("CHANGE: " + change.ToString())

        End If

    End Sub
End Class