Public Class MainForm

    'Track the currently selected row in the main list view locally.
    Public currentlySelectedRow As String
    'Track the type of void being currently used.
    Public currentVoidType As String
    'Total bill
    Dim totalBill = 0

    'Clear current transaction
    Sub clearCurrentTransaction()
        inSearch.Text = ""
        outItemDescription.Text = ""
        outItemPrice.Text = ""
        inQuantity.Value = 1
        outTotalPrice.Text = 0
    End Sub

    Sub clearAll()
        clearCurrentTransaction()
        currentOrderList.Items.Clear()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub


    Sub computeTotalPrice()
        outTotalPrice.Text = Val(inQuantity.Value) * Val(outItemPrice.Text)
    End Sub


    Sub successSearch()
        'Add to Cart
        inQuantity.Value = 1
        Button1.Enabled = True
    End Sub



    Sub computeTotalBills()
        'Track the total bill
        totalBill = 0
        For Each rowItem In currentOrderList.Items
            totalBill += Val(rowItem.SubItems(3).text)
        Next
        outTotalBills.Text = "PHP " & totalBill
    End Sub


    Private Sub searchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchButton.Click
        Select Case inSearch.Text
            'Stacking - https://stackoverflow.com/questions/23795886/vb-net-stacking-select-case-statements-together-like-in-switch-c-java
            Case "c1", "C1"
                outItemDescription.Text = "1 PC. Uncle John's Fried Chicken"
                outItemPrice.Text = "75.00"
                computeTotalPrice()
                successSearch()
            Case "c2", "C2"
                outItemDescription.Text = "Turon"
                outItemPrice.Text = "12.00"
                computeTotalPrice()
                successSearch()
            Case "c3", "C3"
                outItemDescription.Text = "Kopiko 78"
                outItemPrice.Text = "21.00"
                computeTotalPrice()
                successSearch()
            Case Else
                MsgBox("You have entered an invalid Item Code. Please try again.")
                clearCurrentTransaction()
                'Add to Cart Disable
                Button1.Enabled = False
        End Select
    End Sub

    Private Sub inQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inQuantity.ValueChanged
        computeTotalPrice()
    End Sub

    'Add to Cart Button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rowItem As New ListViewItem
        rowItem = currentOrderList.Items.Add(inQuantity.Value)
        rowItem.SubItems.Add(outItemDescription.Text)
        rowItem.SubItems.Add(outItemPrice.Text)
        rowItem.SubItems.Add(outTotalPrice.Text)
        computeTotalBills()
        'Enable Void Buttons
        Button2.Enabled = True
        Button3.Enabled = True
        'Reset Current Item
        clearCurrentTransaction()
        'Disable Add to cart button
        Button1.Enabled = False
    End Sub

    'Void Item
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        currentVoidType = "item"
        Confirmation_Dialog.ShowDialog()
    End Sub

    'Void Transaction
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        currentVoidType = "transaction"
        Confirmation_Dialog.ShowDialog()
    End Sub

    'Track currently selected item.
    Private Sub currentOrderList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles currentOrderList.Click
        For Each listItem In currentOrderList.SelectedItems
            currentlySelectedRow = listItem.Index
        Next
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Insert the current total bill into the form.
        Payment.paymentTotalBill.Text = totalBill
        Payment.ShowDialog()
    End Sub
End Class
