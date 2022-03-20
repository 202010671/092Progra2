Public Class Form1
    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If CBProducto.SelectedIndex = -1 Then
            MsgBox("Seleccione los campos faltantes")
        End If

        If Contador < 6 Then
            Número(Contador) = Contador + 1
            Producto(Contador) = CBProducto.SelectedItem
        End If


        If TBCantidadInventario.Text < TBCantidadDeseada.Text Then
            MsgBox("La cantidad del inventario debe ser mayor a la cantidad deseada")
        End If


        Dim numero1 As Integer = TBCantidadInventario.Text
        Dim numero2 As Integer = TBCantidadDeseada.Text

        Dim división As Integer = (numero1 / numero2)

        NúmeroPacks(Contador) = división
        Sobrante(Contador) = numero1 Mod numero2




        Select Case IngresosPacks(Contador)
            Case "Jugos"
                IngresosPacks(Contador) = NúmeroPacks(Contador) * PJugo
            Case "Frituras"
                IngresosPacks(Contador) = NúmeroPacks(Contador) * PFrituras
            Case "Galletas"
                IngresosPacks(Contador) = NúmeroPacks(Contador) * PGalletas
            Case "Baterías"
                IngresosPacks(Contador) = NúmeroPacks(Contador) * PBaterías
        End Select


        If TBCantidadInventario.Text >= 10 Then
            Descuento(Contador) = IngresosPacks(Contador) * 0.1
        ElseIf TBCantidadInventario.Text >= 5 Then
            Descuento(Contador) = IngresosPacks(Contador) * 0.05
        Else
            Descuento(Contador) = IngresosPacks(Contador) * 0.03
        End If


        IngresosEsperadosporelPack(Contador) = IngresosPacks(Contador) - Descuento(Contador)



        Select Case IngresosEsperadosporelProductoSobrante(Contador)
            Case "Jugos"
                IngresosEsperadosporelProductoSobrante(Contador) = Sobrante(Contador) * PJugo
            Case "Frituras"
                IngresosEsperadosporelProductoSobrante(Contador) = Sobrante(Contador) * PFrituras
            Case "Galletas"
                IngresosEsperadosporelProductoSobrante(Contador) = Sobrante(Contador) * PGalletas
            Case "Baterías"
                IngresosEsperadosporelProductoSobrante(Contador) = Sobrante(Contador) * PBaterías
        End Select


        Total(Contador) = IngresosEsperadosporelPack(Contador) + IngresosEsperadosporelProductoSobrante(Contador)


        If DGV1.Rows.Add(Contador + 1, (Número(Contador)), (NúmeroPacks(Contador)), (System.Math.Round(Sobrante(Contador), 2)), (System.Math.Round(IngresosEsperadosporelPack(Contador), 2)), (System.Math.Round(IngresosEsperadosporelProductoSobrante(Contador), 2)), (System.Math.Round(Total(Contador), 2))) Then
            Contador = Contador + 1
        Else
            MsgBox("Se ha llegado al límite de registros")
        End If


    End Sub

    
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If

    End Sub

    Private Sub DataGridViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridViewToolStripMenuItem.Click
        DGV1.Rows.Clear()
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VectoresToolStripMenuItem.Click
        CBProducto.Items.Clear()
        TBCantidadDeseada.Clear()
        TBCantidadInventario.Clear()
        TBNombrePack.Clear()
    End Sub
End Class
