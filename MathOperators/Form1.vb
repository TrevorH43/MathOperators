Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtLeftOperand.Clear()
        txtRightOperand.Clear()
        lblOperator.Text = ""
        lblDisplay.Text = ""
        result.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim rightOperand As Double
        Dim leftOperand As Double

        rightOperand = Double.Parse(txtRightOperand.Text)
        leftOperand = Double.Parse(txtLeftOperand.Text)
        result.Text = leftOperand + rightOperand

        lblOperator.Text = $"{leftOperand} + {rightOperand}"
        lblDisplay.Text = result.ToString("N")
        expression.Text = leftOperand + rightOperand
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim rightOperand As Double
        Dim leftOperand As Double

        rightOperand = Double.Parse(txtRightOperand.Text)
        leftOperand = Double.Parse(txtLeftOperand.Text)
        result.Text = leftOperand - rightOperand

        lblOperator.Text = $"{leftOperand} - {rightOperand}"
        lblDisplay.Text = result.ToString("N")

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim rightOperand As Double
        Dim leftOperand As Double

        rightOperand = Double.Parse(txtRightOperand.Text)
        leftOperand = Double.Parse(txtLeftOperand.Text)
        result.Text = leftOperand * rightOperand

        lblOperator.Text = $"{leftOperand} * {rightOperand}"
        lblDisplay.Text = result.ToString("N")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim rightOperand As Double
        Dim leftOperand As Double

        rightOperand = Double.Parse(txtRightOperand.Text)
        leftOperand = Double.Parse(txtLeftOperand.Text)
        result.Text = leftOperand / rightOperand

        lblOperator.Text = $"{leftOperand} / {rightOperand}"
        lblDisplay.Text = result.ToString("N")

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Dim rightOperand As Double
        Dim leftOperand As Double

        rightOperand = Double.Parse(txtRightOperand.Text)
        leftOperand = Double.Parse(txtLeftOperand.Text)
        result.Text = leftOperand / rightOperand

        lblOperator.Text = $"{leftOperand} % {rightOperand}"
        lblDisplay.Text = result.ToString("N")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
