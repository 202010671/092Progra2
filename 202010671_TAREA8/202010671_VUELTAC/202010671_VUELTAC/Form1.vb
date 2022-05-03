Imports System.Math
Public Class Form1


    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Etapa(fila) = Nothing
        Equipo(fila) = Nothing
        KilómetrosR(fila) = Nothing
        Tiempo(fila) = Nothing
        Nacionalidad(fila) = Nothing
        Penalización(fila) = Nothing

        For I = fila To 11
            Etapa(I) = Etapa(I + 1)
            Equipo(I) = Equipo(I + 1)
            KilómetrosR(I) = KilómetrosR(I + 1)
            Tiempo(I) = Tiempo(I + 1)
            Nacionalidad(I) = Nacionalidad(I + 1)
            Penalización(I) = Penalización(I + 1)
        Next
        MsgBox("Registro Eliminado Exitosamente")
        Etapa(I) = Nothing
        Equipo(I) = Nothing
        KilómetrosR(I) = Nothing
        Tiempo(I) = Nothing
        Nacionalidad(I) = Nothing
        Penalización(I) = Nothing

        fila = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub MostrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem1.Click
        Mostrar_vectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 4) And Not (existe)
            If (Etapa(I) = Val(TBNoEtapaaParticipar.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            TBNoEtapaaParticipar.Text = Etapa(I)
            CBEquipo.Text = Equipo(I)
            TBKilómetrosRecorridos.Text = Str(KilómetrosR(I))
            TBTiempoenMinutos.Text = Str(Tiempo(I))
            CBNacionalidad.Text = Nacionalidad(I)
            Str(Penalización(I))

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Equipo(I), Str(KilómetrosR(I)), Str(Tiempo(I)), Nacionalidad(I), Str(Penalización(I)))
            fila = I
        Else
            MsgBox("Carnet no encontrado")

        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem1.Click
        Etapa(fila) = TBNoEtapaaParticipar.Text
        Equipo(fila) = CBEquipo.Text
        KilómetrosR(fila) = Val(TBKilómetrosRecorridos.Text)
        Tiempo(fila) = Val(TBTiempoenMinutos.Text)
        Nacionalidad(fila) = CBNacionalidad.Text
        Penalización(fila)

        MsgBox("Registro actualizado correctamente en los vectores")
        fila = 11
    End Sub



    Private Sub EstadísticasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadísticasToolStripMenuItem.Click

    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem1.Click
        MontoFinal()
        If (fila <= 11) Then
            Etapa(fila) = TBNoEtapaaParticipar.Text
            Equipo(fila) = CBEquipo.Text
            KilómetrosR(fila) = Val(TBKilómetrosRecorridos.Text)
            Tiempo(fila) = Val(TBTiempoenMinutos.Text)
            Nacionalidad(fila) = CBNacionalidad.Text
            Penalización(fila)
            fila = fila + 1

        End If
        If (fila = 7) Then MsgBox("vectores llenos")

        End If
    End Sub
End Class