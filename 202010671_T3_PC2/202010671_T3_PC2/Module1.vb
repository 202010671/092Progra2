Module Module1
    Public Const TCDOLAR = 7.69
    Public Const TCPESO = 0.38
    Public Const TCEURO = 7.89
    Public Const TCCOLONOS = 0.012

    Const COMISIONCOMPRA = 0.025
    Const COMISIONVENTA = 0.03

    Dim total_parcial = 0
    Dim total

    Sub limpiar()
        Form1.TBCOMPRA.Clear()
        Form1.TBVENTA.Clear()
        Form1.CBCOMPRA.Checked = False
        Form1.CBVENTA.Checked = False

        Form2.Label1.Text = "Limpio"
    End Sub

    Function calcularCompra(ByVal cantidadCompra As Double, ByVal TipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            total_parcial = cantidadCompra * TipoCompra
            total = total_parcial * COMISIONCOMPRA + total_parcial

        End If

        Return Math.Round(total, 2)
    End Function



    Function calcularVenta(ByVal cantidadVenta As Double, ByVal TipoVenta As Double) As Double
        If cantidadVenta > 0 Then
            total_parcial = cantidadVenta * TipoVenta
            total = total_parcial * COMISIONVENTA + total_parcial

        End If

        Return Math.Round(total, 2)
    End Function

End Module
