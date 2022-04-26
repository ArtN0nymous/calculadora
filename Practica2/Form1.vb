Public Class ventana

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles C.Click
        TextBox1.Clear()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""

    End Sub

    Private Sub ventana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Sqrt_Click(sender As Object, e As EventArgs) Handles Sqrt.Click
        Dim Sqrt As Double
        Sqrt = Convert.ToDouble(TextBox1.Text)
        TextBox1.Text = Convert.ToString(Math.Sqrt(Sqrt))
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Dim numb As Double
        numb = Convert.ToDouble(TextBox1.Text)
        Dim nu As Double
        nu = numb - numb - numb
        TextBox1.Text = Convert.ToString(nu)

    End Sub

    Private Sub siete_Click(sender As Object, e As EventArgs) Handles siete.Click
        TextBox1.AppendText(7)
    End Sub

    Private Sub ocho_Click(sender As Object, e As EventArgs) Handles ocho.Click
        TextBox1.AppendText(8)
    End Sub

    Private Sub nueve_Click(sender As Object, e As EventArgs) Handles nueve.Click
        TextBox1.AppendText(9)
    End Sub

    Private Sub cuatro_Click(sender As Object, e As EventArgs) Handles cuatro.Click
        TextBox1.AppendText(4)
    End Sub

    Private Sub cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        TextBox1.AppendText(5)
    End Sub

    Private Sub seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        TextBox1.AppendText(6)
    End Sub

    Private Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        TextBox1.AppendText(1)
    End Sub

    Private Sub dos_Click(sender As Object, e As EventArgs) Handles dos.Click
        TextBox1.AppendText(2)
    End Sub

    Private Sub tres_Click(sender As Object, e As EventArgs) Handles tres.Click
        TextBox1.AppendText(3)
    End Sub

    Private Sub cero_Click(sender As Object, e As EventArgs) Handles cero.Click
        TextBox1.AppendText(0)
    End Sub

    Private Sub punto_Click(sender As Object, e As EventArgs) Handles punto.Click
        TextBox1.AppendText(".")
    End Sub

    Private Sub dividir_Click(sender As Object, e As EventArgs) Handles dividir.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "/"
        TextBox1.Clear()
    End Sub

    Private Sub multiplicacion_Click(sender As Object, e As EventArgs) Handles multiplicacion.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "*"
        TextBox1.Clear()
    End Sub

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "+"
        TextBox1.Clear()
    End Sub

    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "-"
        TextBox1.Clear()
    End Sub

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click
        Label3.Text = TextBox1.Text
        Dim sign As Char
        sign = Label2.Text
        Dim n1 As Double
        n1 = Convert.ToDouble(Label1.Text)
        Dim n2 As Double
        n2 = Convert.ToDouble(Label3.Text)
        Dim n3 As Double

        Select Case (sign)
            Case "+"
                n3 = n1 + n2
            Case "-"
                n3 = n1 - n2
            Case "*"
                n3 = n1 * n2
            Case "/"
                n3 = n1 / n2
        End Select
        TextBox1.Text = Convert.ToString(n3)
    End Sub
End Class
