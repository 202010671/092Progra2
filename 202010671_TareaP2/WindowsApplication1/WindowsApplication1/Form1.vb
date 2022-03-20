Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCalcular.Click
        If CBTamaño.SelectedIndex = -1 Or CBTela.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
            Exit Sub
        End If

        If Contador < 8 Then
            NúmeroVenta(Contador) = Contador + 1
            Tamaño(Contador) = CBTamaño.SelectedItem
            Material(Contador) = CBTela.SelectedItem


            Select Case Tamaño(Contador)
                Case "Sofá"
                    Select Case Material(Contador)
                        Case "Cuero"
                            PrecioManoObra(Contador) = 8 * PSofá
                            PrecioCosto(Contador) = 8 * PCuero + PrecioManoObra(Contador)
                        Case "Cuerina"
                            PrecioManoObra(Contador) = 8 * PSofá
                            PrecioCosto(Contador) = 8 * PCuerina + PrecioManoObra(Contador)
                    End Select

                Case "Individual"
                    Select Case Material(Contador)
                        Case "Cuero"
                            PrecioManoObra(Contador) = 8 * PIndividual
                            PrecioCosto(Contador) = 8 * PCuero + PrecioManoObra(Contador)
                        Case "Cuerina"
                            PrecioManoObra(Contador) = 8 * PIndividual
                            PrecioCosto(Contador) = 8 * PCuerina + PrecioManoObra(Contador)
                    End Select

                Case "Doble"
                    Select Case Material(Contador)
                        Case "Cuero"
                            PrecioManoObra(Contador) = 8 * PDoble
                            PrecioCosto(Contador) = 8 * PCuero + PrecioManoObra(Contador)
                        Case "Cuerina"
                            PrecioManoObra(Contador) = 8 * PDoble
                            PrecioCosto(Contador) = 8 * PCuerina + PrecioManoObra(Contador)
                    End Select
            End Select

            PrecioVenta(Contador) = PrecioCosto(Contador) * 1.65




            
            ListBox1.Items.Add(NúmeroVenta(Contador))
            ListBox2.Items.Add(Tamaño(Contador))
            ListBox3.Items.Add(Material(Contador))
            ListBox4.Items.Add(System.Math.Round(PrecioManoObra(Contador), 2))
            ListBox5.Items.Add(System.Math.Round(PrecioCosto(Contador), 2))
            ListBox6.Items.Add(System.Math.Round(PrecioVenta(Contador), 2))


            Contador = Contador + 1
        Else
            MsgBox("Se ha llegado al límite de registros")
        End If
    End Sub

   
    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub BLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLimpiar.Click
        CBTamaño.Items.Clear()
        CBTela.Items.Clear()
        
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub
End Class
