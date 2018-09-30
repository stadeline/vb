Public Class orderingApplicationMainForm

    Public totalBill
    Public currentVoid

    ' http://www.vbforums.com/showthread.php?387308-Visit-Every-Control-on-a-Form-(includes-nested-controls-no-recursion)
    Sub iterateOverAll()
        Dim ctl As Control = Me.GetNextControl(Me, True) 'Get the first control in the tab order.

        Do Until ctl Is Nothing
            'Use ctl here.

            ctl = Me.GetNextControl(ctl, True) 'Get the next control in the tab order.
        Loop
    End Sub


    'Clear Current Order
    Sub clearCurrentOrder()
        inSearchString.Text = ""
        outDescription.Text = ""
        outItemPrice.Text = ""
        inOrderQuantity.Value = 1
        outOrderPrice.Text = ""
    End Sub

    'Compute Current Order
    Sub computeCurrentOrder()
        outOrderPrice.Text = Val(inOrderQuantity.Value) * Val(outItemPrice.Text)
        If Val(outOrderPrice.Text) > 0 Then
            addToCartButton.Enabled = True
        Else
            addToCartButton.Enabled = False
        End If
        'Update total
        computeTotalBill()
    End Sub

    'Compute Total Price
    Sub computeTotalBill()
        'Reset
        totalBill = 0
        For Each row As ListViewItem In currentOrdersList.Items
            totalBill += Val(row.SubItems(3).Text)
        Next
        outTotalBill.Text = "PHP " & totalBill
        'Total Bill Enabler
        If totalBill > 0 Then
            paymentButton.Enabled = True
        Else
            paymentButton.Enabled = False
        End If
    End Sub

    'Search Button
    Private Sub inSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inSearchButton.Click
        Select Case (inSearchString.Text)
            Case 1
                outDescription.Text = "1 Pc. Chicken"
                outItemPrice.Text = "75.00"
            Case 2
                outDescription.Text = "2 Pcs. Chicken"
                outItemPrice.Text = "130.00"
            Case 3
                outDescription.Text = "Coffee"
                outItemPrice.Text = "25.00"
            Case Else
                MsgBox("You have entered an invalid item code. Please try again.")
                clearCurrentOrder()
        End Select
        'Reset the quantity per search query.
        inOrderQuantity.Value = 1
        'Calculate on quantity of 1.
        computeCurrentOrder()
    End Sub

    'Changing the quantity automatically calculates the price of the current order.
    Private Sub inOrderQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inOrderQuantity.ValueChanged
        computeCurrentOrder()
    End Sub

    'Add an item to the cart.
    Private Sub addToCartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToCartButton.Click
        'Create the element.
        Dim currentOrderListViewItem As New ListViewItem
        currentOrderListViewItem.Text = inOrderQuantity.Value
        currentOrderListViewItem.SubItems.Add(outDescription.Text)
        currentOrderListViewItem.SubItems.Add(outItemPrice.Text)
        currentOrderListViewItem.SubItems.Add(outOrderPrice.Text)
        'Attach it
        currentOrdersList.Items.Add(currentOrderListViewItem)
        computeTotalBill()
        'Reset the add to cart menu.
        clearCurrentOrder()
        voidAllButton.Enabled = True
    End Sub

    '
    'Void
    'Clicking on an item in the current orders list will allow you to void it.
    Private Sub currentOrdersList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles currentOrdersList.SelectedIndexChanged
        For Each row As ListViewItem In currentOrdersList.Items
            If row.Selected = True Then
                voidItemButton.Enabled = True
            Else
                voidItemButton.Enabled = False
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voidItemButton.Click
        currentVoid = "singleItem"
        transactionCompleteModal.ShowDialog()
    End Sub
    Private Sub voidAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voidAllButton.Click
        currentVoid = "all"
        transactionCompleteModal.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paymentButton.Click
        Change.outTotalBill.Text = outTotalBill.Text
        Change.ShowDialog()
    End Sub
End Class
