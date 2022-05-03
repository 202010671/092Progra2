Module Module1
    Public Etapa(12) As String
    Public Equipo(12) As String
    Public KilómetrosR(12) As Integer
    Public Tiempo(12) As Integer
    Public Nacionalidad(12) As String
    Public Penalización(12) As String

    Public Total As Integer

    Public fila As Byte = 0
    Public I As Byte

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            Limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub

    Sub limpiar_entradas()
        Form1.TBTiempoenMinutos.Clear()
        Form1.TBKilómetrosRecorridos.Clear()
        Form1.TBNoEtapaaParticipar.Clear()
        Form1.TBConsultarNoEtapaaParticipar.Clear()
        Form1.CBEquipo.Text = ""
        Form1.CBNacionalidad.Text = ""
        Form1.TBNoEtapaaParticipar.Focus()
    End Sub

    Sub limpiar_estadisticas()
        Form1.TBCorredoresmás45km.Clear()
        Form1.TBKilómetrosRecorridosporcadaEquipo.Clear()
        Form1.TBTiempoTotalporNacionalidad.Clear()
        Form1.TBCorredoresmás45km.Focus()
    End Sub

    Sub Mostrar_vectores()

        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 11

            If (Etapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Equipo(I), Str(KilómetrosR(I)), Str(Tiempo(I)), Nacionalidad(I), Str(Penalización(I)))
            Else

                Exit For
            End If
        Next I

    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()
   
        fila = 0

        For I = 0 To 11
            Etapa(I) = Nothing
            Equipo(I) = Nothing
            KilómetrosR(I) = Nothing
            Tiempo(I) = Nothing
            Nacionalidad(I) = Nothing
            Penalización(I) = Nothing
        Next I

    End Sub

    Sub MontoFinal()

        If Val(Form1.TBTiempoenMinutos) <= 120 Then
            Total = Val(Form1.TBTiempoenMinutos) + 30
        ElseIf Val(Form1.TBTiempoenMinutos) <= 140 Then
            Total = Val(Form1.TBTiempoenMinutos) + 40
        ElseIf Val(Form1.TBTiempoenMinutos) <= 160 Then
            Total = Val(Form1.TBTiempoenMinutos) + 50
        ElseIf Val(Form1.TBTiempoenMinutos) >= 85 Then
            Total = Val(Form1.TBTiempoenMinutos) - 15
        End If

    End Sub



End Module
