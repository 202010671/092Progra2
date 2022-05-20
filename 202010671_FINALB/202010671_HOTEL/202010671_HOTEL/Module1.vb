Module Module1
    Public fila As Byte = 0
    Public I As Byte



    Public matriz(4, 6)
    Public indice = 0

    Sub salir()
        'PROCEDIMIENTO QUE REALIZA LA ACCIÓN DE SALIR DE LA APLICACIÓN
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()

        End If
    End Sub

    Sub limpiar_entradas()

        Form1.TBNITCliente.Clear()
        Form1.TBNombreCliente.Clear()
        Form1.TBCantidadPersonas.Clear()
        Form1.TBConsultarNIT.Clear()
        Form1.CBTipoHabitación.Text = ""

    End Sub

    Sub limpiar_matriz()

        Form1.DataGridView1.Rows.Clear()
        fila = 0
        indice = 0
        While (indice <= 6)
            matriz(indice, 0) = Nothing
            matriz(indice, 1) = Nothing
            matriz(indice, 2) = Nothing
            matriz(indice, 3) = Nothing
            matriz(indice, 4) = Nothing

            indice = indice + 1
        End While

    End Sub

    Sub Mostrar_matriz()
        Form1.DataGridView1.Rows.Clear()
        indice = 0
        While (indice <= 6)
            If (matriz(indice, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice))
            Else
                Exit While
            End If
            indice = indice + 1
        End While
    End Sub

    Sub Buscar_For()
        Dim g As Byte
        For g = 0 To 6
            If (matriz(indice, 0) <> Nothing) Then
                If (Val(matriz(indice, 0)) = Val(Form1.TBNITCliente.Text)) Then
                    MsgBox("registro encontrado")
                    Exit For
                End If
            Else
                Exit For
            End If
        Next g
        If (g = 5) Then
            MsgBox("NIT no encontrado")
        Else
            MsgBox("Registro encontrado exitosamente")
            Form1.TBNITCliente.Text = matriz(0, indice)
            Form1.TBNombreCliente.Text = matriz(1, indice)
            Form1.TBCantidadPersonas.Text = matriz(2, indice)
            Form1.CBTipoHabitación.SelectedIndex = matriz(3, indice)

            Form1.DataGridView1.Rows.Clear()
            Form1.DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice))
            fila = indice
        End If

    End Sub
End Module
