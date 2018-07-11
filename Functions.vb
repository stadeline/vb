Public Class Form1
   
    Function Answer(ByVal firstnumber As String, ByVal secondnumber As String, ByVal ope As String)
        Dim ans As Double = 0
        If IsNumeric(firstnumber) And IsNumeric(secondnumber) Then
            Select Case ope
                Case "+"
                    ans = firstnumber + secondnumber
                Case "-"
                    ans = firstnumber - secondnumber
                Case "*"
                    ans = firstnumber * secondnumber
                Case "/"
                    ans = firstnumber / secondnumber
                Case "m"
                    ans = firstnumber Mod secondnumber
            End Select
        Else
            MsgBox("Invalid input")
        End If
        Return Format(ans, "#,##0.00")
    End Function
 
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        lblanswer.Text = Answer(txtn1.Text, txtn2.Text, "+")
    End Sub
 
    Private Sub btnsubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubtract.Click
        lblanswer.Text = Answer(txtn1.Text, txtn2.Text, "-")
    End Sub
 
    Private Sub btnMultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplication.Click
        lblanswer.Text = Answer(txtn1.Text, txtn2.Text, "*")
    End Sub
 
    Private Sub btnDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivision.Click
        lblanswer.Text = Answer(txtn1.Text, txtn2.Text, "/")
    End Sub
 
    Private Sub btnModulus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModulus.Click
        lblanswer.Text = Answer(txtn1.Text, txtn2.Text, "m")
    End Sub
 
End Class