Public Class Confirmation_Dialog

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
        Next
    End Sub

    Private Sub confirmButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmButton.Click
        'Debugging
        If inVerificationPassword.Text = "ADMIN" Then
            'If inVerificationPassword.Text = "" Then
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