Public Class Form1

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_Vectores()
    End Sub

    Private Sub CálculoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CálculoToolStripMenuItem.Click
        If (fila <= 6) Then
            Nombre(fila) = TBNombreHuesped.Text
            NIT(fila) = Val(TBNIT.Text)
            TipoPago(fila) = CBTipoPago.Text
            DiasHospedarse(fila) = Val(TBDíasHospedarse.Text)
            TipoHabitación(fila) = CBTipoHabitación.Text
            ValorImpuesto(fila) = Val(TBValorImpuesto.Text)
            fila = fila + 1
            limpiar_entradas()
        End If
        If (fila = 7) Then
            MsgBox("vectores llenos")
        End If
    End Sub


    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False

        I = 0
        While (I <= 6) And Not (existe)

            If (NIT(I) = Val(TBConsultarNIT.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TBNombreHuesped.Text = Nombre(I)
            TBNIT.Text = Str(NIT(I))
            CBTipoPago.Text = Str(TipoPago(I))
            TBDíasHospedarse.Text = Str(DiasHospedarse(I))
            CBTipoHabitación.Text = TipoHabitación(I)
            TBValorImpuesto.Text = Str(ValorImpuesto(I))


            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Nombre(I)), Str(NIT(I)), Str(TipoPago(I)), Str(DíasHospedarse(I)), TipoHabitación(I), Str(ValorImpuesto(I)))
            fila = I
        Else
            MsgBox("NIT no encontrado")
            TBConsultarNIT.Focus()
        End If
    End Sub



    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
     

        Nombre(fila) = Nothing
        NIT(fila) = Nothing
        TipoPago(fila) = Nothing
        DiasHospedarse(fila) = Nothing
        TipoHabitación(fila) = Nothing
        ValorImpuesto(fila) = Nothing


        For I = fila To 6
            
            Nombre(I) = Nombre(I + 1)
            NIT(I) = NIT(I + 1)
            TipoPago(I) = TipoPago(I + 1)
            DiasHospedarse(I) = DiasHospedarse(I + 1)
            TipoHabitación(I) = TipoHabitación(I + 1)
            ValorImpuesto(I) = ValorImpuesto(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
       
        Nombre(I) = Nothing
        NIT(I) = Nothing
        TipoPago(I) = Nothing
        DiasHospedarse(I) = Nothing
        TipoHabitación(I) = Nothing
        ValorImpuesto(I) = Nothing

        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Public Const Sencilla = 250
    Public Const Doble = 400
    Public Const Cabaña = 650

End Class
