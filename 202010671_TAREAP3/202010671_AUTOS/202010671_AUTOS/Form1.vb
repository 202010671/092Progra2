Public Class Autos



    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        Pago_final()

        If (fila <= 6) Then
            NoPlaca(fila) = Val(TBNoPlaca.Text)
            TipoAuto(fila) = CBTipoAuto.Text
            CobroBase(fila) = Subtotal
            KilometrajeInicial(fila) = Val(TBKilometrajeInicial.Text)
            KilometrajeFinal(fila) = Val(TBKilometrajeFinal.Text)
            Recorrido(fila) = KilometrajeFinal(fila) - KilometrajeInicial(fila)
            PagoFinal(fila) = Total
            fila = fila + 1
            limpiar_entradas()
        End If
        If (fila = 7) Then
            MsgBox("vectores llenos")
        End If
    End Sub


    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()
    End Sub



    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub


    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 4) And Not (existe)
            If (NoPlaca(I) = Val(TBNoPlaca.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            TBNoPlaca.Text = Str(NoPlaca(I))
            CBTipoAuto.Text = TipoAuto(I)
            TBCobroBase.Text = Str(CobroBase(I))
            TBKilometrajeInicial.Text = Str(KilometrajeInicial(I))
            TBKilometrajeFinal.Text = Str(KilometrajeFinal(I))
            TBPagoTotal.Text = PagoFinal(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(NoPlaca(I)), TipoAuto(I), Str(CobroBase(I)), Str(KilometrajeInicial(I)), Str(KilometrajeFinal(I)), Str(Recorrido(I)), Str(PagoFinal(I)))

            fila = I
        Else
            MsgBox("Carnet no encontrado")
            TBConsultarNoPlaca.Focus()
        End If


    End Sub
End Class
