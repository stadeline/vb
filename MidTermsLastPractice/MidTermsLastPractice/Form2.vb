Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkoutTotal.Text = "PHP" + Form1.totalBill.ToString()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim change = Val(inTenderedAmount.Text) - Val(Form1.totalBill)
        If change < 0 Then
            change = change * -1
        End If

        If Val(inTenderedAmount.Text) < Val(Form1.totalBill) Then
            MsgBox("Kulang bayad nung customer mo. Singinlin mo ng " + change.ToString())
        Else
            MsgBox("Transaction Complete. Your customer's change is " + change.ToString())
            inTenderedAmount.Text = ""
            checkoutTotal.Text = "PHP 0"
            Me.Close()
            Form1.clearProduct()
            Form1.orderList.Items.Clear()
            Form1.computeTotalBill()
            Form1.checkButtons()
            Form1.transactionNumber = Form1.transactionNumber + 1
            Form1.outTransactionNumber.Text = Format(Form1.transactionNumber, "00000")
        End If

    End Sub
End Class