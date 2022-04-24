Module Module1
    Public NoPlaca(7) As Integer
    Public TipoAuto(7) As String
    Public CobroBase(7) As Integer
    Public KilometrajeInicial(7) As Integer
    Public KilometrajeFinal(7) As Integer
    Public Recorrido(7) As Integer
    Public PagoFinal(7) As Double

    Public Subtotal As Integer
    Public Total As Integer
    Public Diferencia As Double

    Public fila As Byte = 0

    Public I As Byte

    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Autos.Close()
        Else
            Limpiar_entradas()
        End If
    End Sub
    Sub limpiar_entradas()
        Autos.TBNoPlaca.Clear()
        Autos.CBTipoAuto.Text = ""
        Autos.TBCobroBase.Clear()
        Autos.TBKilometrajeFinal.Clear()
        Autos.TBKilometrajeInicial.Clear()
        Autos.TBPagoTotal.Clear()
        Autos.TBConsultarNoPlaca.Clear()
    End Sub
    Sub Mostrar_vectores()

        Autos.DataGridView1.Rows.Clear()
        For I = 0 To 7

            If (NoPlaca(I) <> Nothing) Then
                Autos.DataGridView1.Rows.Add(Str(NoPlaca(I)), TipoAuto(I), Str(CobroBase(I)), Str(KilometrajeInicial(I)), Str(KilometrajeFinal(I)), Recorrido(I), Str(PagoFinal(I)))
            Else
                Exit For
            End If
        Next I

    End Sub
    Sub limpiar_vectores()
        Autos.DataGridView1.Rows.Clear()
        fila = 0
        For I = 0 To 6
            NoPlaca(I) = Nothing
            TipoAuto(I) = Nothing
            CobroBase(I) = Nothing
            KilometrajeInicial(I) = Nothing
            KilometrajeFinal(I) = Nothing
            Recorrido(I) = Nothing
            PagoFinal(I) = Nothing
        Next I

    End Sub

    Sub Pago_final()

        Select Case (Autos.CBTipoAuto.SelectedIndex)
            Case 0
                Subtotal = 500
            Case 1
                Subtotal = 400
            Case 2
                Subtotal = 300
            Case 3
                Subtotal = 200
        End Select




        Diferencia = Val(Autos.TBKilometrajeFinal.Text) - Val(Autos.TBKilometrajeInicial.Text)

        If Diferencia <= 50 Then
            Total = (Diferencia * 3) + Subtotal
        ElseIf Diferencia <= 70 Then
            Total = (Diferencia * 4) + Subtotal
        ElseIf Diferencia > 70 Then
            Total = (Diferencia * 5) + Subtotal
        End If



    End Sub




End Module
