Public Class Form1

    Function Evaluate(ByVal firstNumber As String, ByVal secondNumber As String, ByVal operation As String)

        'Define variables
        Dim returnedResult, firstNumberLocal, secondNumberLocal As Double

        'Check if inputs are numbers
        If IsNumeric(firstNumber) And IsNumeric(secondNumber) Then

            'Define Local Variables
            firstNumberLocal = Val(firstNumber)
            secondNumberLocal = Val(secondNumber)

            'Check which operation is being performed.
            Select Case operation
                Case "add"
                    returnedResult = firstNumberLocal + secondNumberLocal
                Case "subtract"
                    returnedResult = firstNumberLocal - secondNumberLocal
                Case "multiply"
                    returnedResult = firstNumberLocal * secondNumberLocal
                Case "divide"
                    returnedResult = firstNumberLocal / secondNumberLocal
                Case "modulus"
                    returnedResult = firstNumberLocal Mod secondNumberLocal
            End Select

        Else

            MsgBox("Please input a valid number")

        End If

        'Return the result.
        'Modulus doesn't have decimal places.
        If operation Is "modulus" Then
            Return returnedResult
        Else
            'Any other operation may have 2.
            Return Format(returnedResult, "#,##0.00")
        End If



    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        outResult.Text = Evaluate(inFirstNumber.Text, inSecondNumber.Text, "add")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        outResult.Text = Evaluate(inFirstNumber.Text, inSecondNumber.Text, "subtract")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        outResult.Text = Evaluate(inFirstNumber.Text, inSecondNumber.Text, "multiply")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        outResult.Text = Evaluate(inFirstNumber.Text, inSecondNumber.Text, "divide")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        outResult.Text = Evaluate(inFirstNumber.Text, inSecondNumber.Text, "modulus")
    End Sub
End Class
