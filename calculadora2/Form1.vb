Public Class Form1
    Dim operacion As String
    Dim valorresultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim sepresionaoperador As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResultado.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtResultado.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtResultado.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtResultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtResultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtResultado.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtResultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtResultado.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtResultado.Text &= "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        txtResultado.Text &= "0"
    End Sub

    Private Sub Buttonpunto_Click(sender As Object, e As EventArgs) Handles Buttonpunto.Click
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click

    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click

    End Sub

    Private Sub Buttondivision_Click(sender As Object, e As EventArgs) Handles Buttondivision.Click

    End Sub

    Private Sub Buttonmenos_Click(sender As Object, e As EventArgs) Handles Buttonmenos.Click

    End Sub

    Private Sub Buttonpor_Click(sender As Object, e As EventArgs) Handles Buttonpor.Click

    End Sub

    Private Sub Buttonmas_Click(sender As Object, e As EventArgs) Handles Buttonmas.Click
        evaluayhazoperacion()
    End Sub

    Private Sub Buttonigual_Click(sender As Object, e As EventArgs) Handles Buttonigual.Click

    End Sub

    Private Sub Buttonporciento_Click(sender As Object, e As EventArgs) Handles Buttonporciento.Click

    End Sub
End Class
