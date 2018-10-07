Public Class Form1

    Public totalBill = 0
    Public currentVoid = ""
    Public transactionNumber = 1

    Sub clearProduct()
        inSearchText.Text = ""
        outDescription.Text = ""
        outProductPrice.Text = ""
        inQuantity.Value = 1
        outProductTotal.Text = ""
        addToCartButton.Enabled = False
    End Sub


    Sub checkButtons()
        If orderList.SelectedItems.Count > 0 Then
            voidItemButton.Enabled = True
        Else
            voidItemButton.Enabled = False
        End If
        If orderList.Items.Count > 0 Then
            voidTransactionButton.Enabled = True
        Else
            voidTransactionButton.Enabled = False
        End If
    End Sub


    Sub computeProduct()
        Dim productTotal = Val(outProductPrice.Text) * Val(inQuantity.Value)
        outProductTotal.Text = productTotal
        'Enable add to cart.
        If productTotal > 0 Then
            addToCartButton.Enabled = True
            'Disable
        Else
            addToCartButton.Enabled = False
        End If
    End Sub


    Sub computeTotalBill()
        totalBill = 0
        For Each row As ListViewItem In orderList.Items
            totalBill += Val(row.SubItems(3).Text)
        Next
        totalBillText.Text = "PHP " + totalBill.ToString()
        If totalBill > 0 Then
            checkoutButton.Enabled = True
        Else
            checkoutButton.Enabled = False
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case inSearchText.Text
            Case "1"
                outDescription.Text = "Chinese Style Fried Chicken"
                outProductPrice.Text = "75"
                computeProduct()
            Case "2"
                outDescription.Text = "Siomai"
                outProductPrice.Text = "40"
                computeProduct()
            Case "3"
                outDescription.Text = "Siopao"
                outProductPrice.Text = "50"
                computeProduct()
            Case Else
                MsgBox("You have entered an invalid product code. Please try again.")
                clearProduct()
        End Select

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inQuantity.ValueChanged
        computeProduct()
    End Sub

    Private Sub addToCartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToCartButton.Click
        Dim currentEntry As New ListViewItem
        currentEntry.Text = inQuantity.Value
        currentEntry.SubItems.Add(outDescription.Text)
        currentEntry.SubItems.Add(outProductPrice.Text)
        currentEntry.SubItems.Add(outProductTotal.Text)
        orderList.Items.Add(currentEntry)
        clearProduct()
        computeTotalBill()
        checkButtons()
    End Sub

    'Void Order


    Private Sub orderList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderList.SelectedIndexChanged
        checkButtons()
    End Sub

    Private Sub voidItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voidItemButton.Click
        currentVoid = "item"
        Confirmation.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voidTransactionButton.Click
        currentVoid = "transaction"
        Confirmation.ShowDialog()
    End Sub

    Private Sub checkoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkoutButton.Click
        Form2.ShowDialog()
    End Sub
End Class
