Public Class Form2

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub


    Private Sub Form2_Load2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.COMPRADOLAR.Checked Then
            Label1.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.TBCOMPRA.Text, TCDOLAR))
        End If

        If Form1.COMPRAPESO.Checked Then
            Label1.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.TBCOMPRA.Text, TCPESO))
        End If

        If Form1.COMPRAEURO.Checked Then
            Label1.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.TBCOMPRA.Text, TCEURO))
        End If

        If Form1.COMPRACOLONOS.Checked Then
            Label1.Text = "La cantidad de tu compra es: " + Str(calcularCompra(Form1.TBCOMPRA.Text, TCCOLONOS))
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.VENTADOLAR.Checked Then
            Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.TBVENTA.Text, TCDOLAR))
        End If

        If Form1.VENTAPESOS.Checked Then
            Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.TBVENTA.Text, TCPESO))
        End If

        If Form1.VENTAEURO.Checked Then
            Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.TBVENTA.Text, TCEURO))
        End If

        If Form1.VENTACOLONOS.Checked Then
            Label2.Text = "La cantidad de tu venta es: " + Str(calcularVenta(Form1.TBVENTA.Text, TCCOLONOS))
        End If


    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class