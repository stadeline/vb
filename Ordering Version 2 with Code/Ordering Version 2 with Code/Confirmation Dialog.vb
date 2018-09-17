Public Class Confirmation_Dialog

    Private Sub confirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmButton.Click
        If inVerificationPassword.Text = "ADMIN" Then
            'Check the void type
            If MainForm.currentVoidType = "item" Then
                MainForm.currentOrderList.Items.RemoveAt(MainForm.currentlySelectedRow)
                inVerificationPassword.Text = ""
                MainForm.computeTotalBills()
                'List view is empty
                If MainForm.currentOrderList.Items.Count = 0 Then
                    'Disable void buttons
                    MainForm.Button2.Enabled = False
                    MainForm.Button3.Enabled = False
                End If
                Close()
            ElseIf MainForm.currentVoidType = "transaction" Then
                MainForm.clearAll()
                MainForm.computeTotalBills()
                inVerificationPassword.Text = ""
                Close()
            End If
        Else
            MsgBox("You have entered an invalid password. Please try again.")
            inVerificationPassword.Text = ""
        End If
    End Sub
End Class