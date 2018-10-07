Public Class Confirmation

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If inPassCode.Text = "" Then
            If Form1.currentVoid = "item" Then
                For Each row As ListViewItem In Form1.orderList.Items
                    If row.Selected Then
                        row.Remove()
                        Form1.checkButtons()
                    End If
                Next
                Form1.computeTotalBill()
            ElseIf Form1.currentVoid = "transaction" Then
                Form1.orderList.Items.Clear()
                Form1.computeTotalBill()
                Form1.checkButtons()
            End If
            'Success
            inPassCode.Text = ""
            Me.Close()
        Else
            MsgBox("You have entered an invalid password. The police has been notified. Joke. Try mo ulit.")
            inPassCode.Text = ""
        End If

    End Sub
End Class