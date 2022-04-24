Module Module1
    Public Matriz(6, 6)
    Public indice = 0

    Sub Adicional()


        Form1.CBTipoSala.SelectedIndex = "Seleccionar un Tipo de Sala"

        Form1.DataGridView1.Rows.Clear()

        ReDim Matriz(6, 6)
        indice = 0
    End Sub
    Sub Mostrar_Vectores()
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 6
            If (Matriz(0, indice) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(Matriz(0, indice)), Str(Matriz(1, indice)), Str(Matriz(2, indice)), Str(Matriz(3, indice)), Str(Matriz(4, indice)))
            Else
                Exit For

            End If
        Next
    End Sub
End Module
