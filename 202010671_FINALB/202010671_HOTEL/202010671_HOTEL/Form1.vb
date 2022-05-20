Imports System.Math

Public Class Form1

   
    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_matriz()
    End Sub

    Private Sub LimpiarMartrizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarMartrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Call salir()
    End Sub


    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If indice < 7 Then
            matriz(0, indice) = TBNITCliente.Text
            matriz(1, indice) = TBNombreCliente.Text
            matriz(2, indice) = TBCantidadPersonas.Text
        End If

        Select Case CBTipoHabitación.SelectedIndex
            Case 0 : matriz(3, indice) = 250
            Case 1 : matriz(3, indice) = 290
            Case 2 : matriz(3, indice) = 370
        End Select

        If Val(TBCantidadPersonas.Text) = 5 Then
            matriz(4, indice) = Str(Val(matriz(3, indice)) + 60)
        Else Val(TBCantidadPersonas.Text) = 6 Then
            matriz(4, indice) = Str(Val(matriz(3, indice)) + 60 * 2)
        Else Val(TBCantidadPersonas.Text) = 7 Then
            matriz(4, indice) = Str(Val(matriz(3, indice)) + 60 * 3)
        Else Val(TBCantidadPersonas.Text) = 8 Then
            matriz(4, indice) = Str(Val(matriz(3, indice)) + 60 * 4)
        End If

        DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice))
        indice = indice + 1



    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Dim existe As Boolean = True
        indice = 0
        While (indice <= 6) And (existe)

            If (matriz(indice, 0) <> Nothing) Then
                existe = False
            Else
                indice = indice + 1
            End If
            Exit While
        End While

        If (existe) Then
            MsgBox("NIT no encontrado")

            TBNITCliente.Text = matriz(0, indice)
            TBNombreCliente.Text = matriz(1, indice)
            TBCantidadPersonas.Text = matriz(2, indice)
            CBTipoHabitación.SelectedIndex = matriz(3, indice)

            DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice))
            fila = indice

        End If

    End Sub


    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Buscar_For()
    End Sub
End Class
