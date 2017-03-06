Public Class Form1

    Public valor As Double
    Public funcao As String

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtVisor.Text = ""
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtVisor.Text = txtVisor.Text & 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtVisor.Text = txtVisor.Text & 2
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtVisor.Text = txtVisor.Text & 3
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtVisor.Text = txtVisor.Text & 4
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtVisor.Text = txtVisor.Text & 5
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtVisor.Text = txtVisor.Text & 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtVisor.Text = txtVisor.Text & 7
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtVisor.Text = txtVisor.Text & 8
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtVisor.Text = txtVisor.Text & 9
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtVisor.Text = Str(txtVisor.Text & "0")
        'Str Converte um valor numerico em uma expressao
    End Sub

    Private Sub btnponto_Click(sender As Object, e As EventArgs) Handles btnponto.Click
        txtVisor.Text = CStr(txtVisor.Text & ",")
        'Csrt Converte uma expressão em string
    End Sub

    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        valor = txtVisor.Text
        txtVisor.Text = ""
        funcao = "divisao"
    End Sub

    Private Sub btnMultiplicacao_Click(sender As Object, e As EventArgs) Handles btnMultiplicacao.Click
        valor = txtVisor.Text
        txtVisor.Text = ""
        funcao = "multiplicacao"
    End Sub

    Private Sub btnSubtracao_Click(sender As Object, e As EventArgs) Handles btnSubtracao.Click
        valor = txtVisor.Text
        txtVisor.Text = ""
        funcao = "subtracao"
    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        valor = txtVisor.Text
        txtVisor.Text = ""
        funcao = "soma"
    End Sub

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        Select Case funcao
            Case "soma"
                valor = valor + txtVisor.Text
            Case "subtracao"
                valor = valor - txtVisor.Text
            Case "multiplicacao"
                valor = valor * txtVisor.Text
            Case "divisao"
                valor = valor / txtVisor.Text
        End Select
        txtVisor.Text = valor
    End Sub
End Class