Public Class transactionCompleteModal


    Private Sub approveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles approveButton.Click
        'If password is correct here.
        If inPassword.Text = "" Then
            If orderingApplicationMainForm.currentVoid = "singleItem" Then
                For Each selectedRow As ListViewItem In orderingApplicationMainForm.currentOrdersList.Items
                    If selectedRow.Selected = True Then
                        selectedRow.Remove()
                    End If
                Next
            Else
                orderingApplicationMainForm.currentOrdersList.Items.Clear()
            End If
            If orderingApplicationMainForm.currentOrdersList.Items.Count < 1 Then
                orderingApplicationMainForm.voidAllButton.Enabled = False
                orderingApplicationMainForm.voidItemButton.Enabled = False
            End If
            orderingApplicationMainForm.computeCurrentOrder()
            inPassword.Text = ""
            Me.Close()
        Else
            MsgBox("You have entered an invalid access code. Please try again.")
            inPassword.Text = ""
        End If
       
    End Sub
End Class