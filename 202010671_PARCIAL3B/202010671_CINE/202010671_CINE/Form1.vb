Public Class Form1

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If indice < 7 Then
            Matriz(0, indice) = TBNITCliente.Text
            Matriz(1, indice) = TBNombrePelicula.Text
            Matriz(2, indice) = TBCantidadBoletosaComprar.Text

        Select Case CBTipoSala.SelectedIndex
            Case 0 : Matriz(3, indice) = 44
            Case 1 : Matriz(3, indice) = 62
            Case 2 : Matriz(3, indice) = 104
        End Select


        Matriz(4, indice) = Matriz(3, indice) * Val(TBCantidadBoletosaComprar.Text)


        DataGridView1.Rows.Add(indice + 1, Matriz(0, indice), Matriz(1, indice), Matriz(2, indice), Matriz(3, indice), Matriz(4, indice))
        indice = indice + 1

        Else
        MessageBox.Show("Ya se llegó al límite")
        End If

    End Sub


    Private Sub LimpiarMatrizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        TBNITCliente.Clear()
        TBNombrePelicula.Clear()
        TBCantidadBoletosaComprar.Clear()
        TBPagoTotal.Clear()
        CBTipoSala.Items.Clear()
        TBBuscarNITCliente.Clear()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Matriz(0, indice) = Val(TBNITCliente.Text)
        Matriz(1, indice) = TBNombrePelicula
        Matriz(2, indice) = Val(TBCantidadBoletosaComprar.Text)
        Matriz(3, indice) = CBTipoSala.Text
        Matriz(4, indice) = Matriz(3, indice) * Val(TBCantidadBoletosaComprar.Text)
        MsgBox("Registro actualizado correctamente en la matriz")
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim existe As Boolean = False
        indice = 0
        While (indice <= 7) And Not (existe)
            If (Matriz(0, indice) = Val(TBNITCliente.Text)) Then
                existe = True
            Else
                indice = indice + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TBNITCliente.Text = Str(Matriz(0, indice))
            TBNombrePelicula.Text = Str(Matriz(1, indice))
            TBCantidadBoletosaComprar.Text = Str(Matriz(2, indice))
            CBTipoSala.Text = Str(Matriz(3, indice))
            TBPagoTotal.Text = Str(Matriz(4, indice))

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Matriz(0, indice)), Str(Matriz(1, indice)), Str(Matriz(2, indice)), Str(Matriz(3, indice)), Str(Matriz(4, indice)))

            Matriz = indice
        Else
            MsgBox("NIT no encontrado")
            TBBuscarNITCliente.Focus()
        End If

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_Vectores()
    End Sub
End Class
