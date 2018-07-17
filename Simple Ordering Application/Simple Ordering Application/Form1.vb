Public Class Form1
    'Search for Items
    Sub searchItems(ByVal searchString As String)
        Select Case searchString
            Case "a1"
                outDescription.Text = "1 Piece Fried Chicken"
                outPrice.Text = "70"
            Case "a2"
                outDescription.Text = "Jolly Hotdog"
                outPrice.Text = "50"
            Case Else
                outDescription.Text = ""
                outPrice.Text = ""
                MsgBox("Item not found.")
        End Select
    End Sub
    'Get total amount due.
    Sub totalPrice(ByVal price As Double, ByVal quantity As Integer)
        If IsNumeric(price) And IsNumeric(quantity) Then
            outTotal.Text = Val(price) * Val(quantity)
        End If
    End Sub


    Sub getChange(ByVal cashGiven As Double, ByVal amountDue As Double)
        If IsNumeric(cashGiven) And IsNumeric(amountDue) Then
            outChange.Text = cashGiven - amountDue
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        searchItems(inSearchTerm.Text)
        'Search is sometimes empty/wrong so check for that.
        If IsNumeric(outPrice.Text) And IsNumeric(inQuantity.Value) Then
            totalPrice(Val(outPrice.Text), Val(inQuantity.Value))
        End If
        If IsNumeric(inCashGiven.Text) And IsNumeric(outTotal.Text) Then
            getChange(Val(inCashGiven.Text), Val(outTotal.Text))
        End If
    End Sub

    Private Sub inQuantity_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles inQuantity.KeyUp
        If IsNumeric(outPrice.Text) And IsNumeric(inQuantity.Value) Then
            totalPrice(outPrice.Text, inQuantity.Value)
        End If
        If IsNumeric(inCashGiven.Text) And IsNumeric(outTotal.Text) Then
            getChange(Val(inCashGiven.Text), Val(outTotal.Text))
        End If
    End Sub

    Private Sub inQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inQuantity.ValueChanged
        If IsNumeric(outPrice.Text) And IsNumeric(inQuantity.Value) Then
            totalPrice(outPrice.Text, inQuantity.Value)
        End If
        If IsNumeric(inCashGiven.Text) And IsNumeric(outTotal.Text) Then
            getChange(Val(inCashGiven.Text), Val(outTotal.Text))
        End If
    End Sub


    Private Sub inCashGiven_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inCashGiven.TextChanged
        If IsNumeric(inCashGiven.Text) And IsNumeric(outTotal.Text) Then
            getChange(Val(inCashGiven.Text), Val(outTotal.Text))
        End If
    End Sub
End Class
