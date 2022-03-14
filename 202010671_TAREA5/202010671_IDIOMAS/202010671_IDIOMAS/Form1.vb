Public Class Form1

    Private Sub BCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCalcular.Click

        If TBCarnet.Text = "" Then
            MsgBox("Error Campo Incompleto Carné")
            Exit Sub
        End If

        If TBHora.Text = "" Then
            MsgBox("Error Campo Incompleto Hora")
            Exit Sub
        End If

        If TBNombre.Text = "" Then
            MsgBox("Error Campo Incompleto Nombre")
            Exit Sub
        End If

        If (RBCheque.Checked = True) Then
            RBEfectivo.Checked = True
        Else : MsgBox("Error no se seleccióno método de pago")
        End If

        If (CBDía.SelectedIndex.Equals(-1)) Then
            MsgBox("Error no se seleccióno día")
        End If

        If (CBIdioma.SelectedIndex.Equals(-1)) Then
            MsgBox("Error no se seleccióno idioma")
        End If

        If indice < 8 Then
            matriz(0, indice) = TBCarnet.Text
            matriz(1, indice) = TBNombre.Text
            matriz(2, indice) = CBIdioma.SelectedItem
            matriz(3, indice) = DTPFecha.Value
            matriz(4, indice) = CBDía.SelectedItem
            matriz(5, indice) = TBHora.Text

            If RBCheque.Checked Then
                matriz(6, indice) = RBCheque.Text
            ElseIf RBEfectivo.Checked Then
                matriz(6, indice) = RBEfectivo.Text
            End If

            Select Case CBIdioma.SelectedIndex
                Case 0 : matriz(7, indice) = 150 * Val(TBHora.Text)
                Case 1 : matriz(7, indice) = 80 * Val(TBHora.Text)
                Case 2 : matriz(7, indice) = 125 * Val(TBHora.Text)
            End Select

            If RBEfectivo.Checked Then
                matriz(8, indice) = Str(Val(matriz(7, indice) * 0.02))
            ElseIf (RBCheque.Checked) Then
                matriz(8, indice) = Str(Val(matriz(7, indice) * 0.015))
            End If

            Select Case CBDía.SelectedIndex
                Case 0 : matriz(9, indice) = 0
                Case 1 : matriz(9, indice) = 0
                Case 2 : matriz(9, indice) = Str(Val(matriz(7, indice) * 0.05))
            End Select

            matriz(10, indice) = Val(matriz(7, indice)) - Val(matriz(8, indice)) - Val(matriz(9, indice))

            DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), matriz(8, indice), matriz(9, indice), matriz(10, indice))
            indice = indice + 1

        Else
            MessageBox.Show("Ya se llegó al límite")
        End If


    End Sub



    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub BLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLimpiar.Click
        DataGridView1.Rows.Clear()
        TBCarnet.Clear()
        TBHora.Clear()
        TBNombre.Clear()
        CBDía.Items.Clear()
        CBIdioma.Items.Clear()
        RBCheque.Checked = False
        RBEfectivo.Checked = False

    End Sub

   
End Class
