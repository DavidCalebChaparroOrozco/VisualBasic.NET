Public Class Calculator
    Dim Num1 As Double
    Dim Num2 As Double
    Dim Result As Double



    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Num1 = txtNumber1.Text
        Num2 = txtNumber2.Text


        Result = Num1 + Num2
        txtResult.Text = Result
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Num1 = txtNumber1.Text
        Num2 = txtNumber2.Text


        Result = Num1 - Num2
        txtResult.Text = Result
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Num1 = txtNumber1.Text
        Num2 = txtNumber2.Text


        Result = Num1 / Num2
        txtResult.Text = Result
    End Sub

    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Num1 = txtNumber1.Text
        Num2 = txtNumber2.Text


        Result = Num1 * Num2
        txtResult.Text = Result
    End Sub
End Class
