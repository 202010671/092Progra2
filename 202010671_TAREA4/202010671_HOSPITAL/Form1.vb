Public Class Hospital

    Public datos(5, 9) As String


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Nombre.Text = "" Or NIT.Text = "" Or Dias.Text = "0" Or Honorarios.Text = "" Or cbHabitacion.Text = "" Or cbPago.Text = "" Then
            MsgBox("Debe completar los campos obligatorios")

        ElseIf Not IsNumeric(Honorarios.Text()) Then
            MsgBox("Los honorarios deben ser de valor numérico")
        Else
            Calcular(Nombre.Text, NIT.Text, Integer.Parse(Dias.Text), Convert.ToDecimal(Honorarios.Text), chb1.Checked, chb2.Checked, chb3.Checked, cbPago.Text, cbHabitacion.Text)

            For index0 = 0 To datos.GetUpperBound(0)
                For index1 = 0 To datos.GetUpperBound(1)
                    Console.Write($"{datos(index0, index1)} ")
                Next
                Console.WriteLine()
            Next
            Mostrar()
        End If

    End Sub

    Function Calcular(nombre As String, nit As String, dias As Integer, honorarios As Integer, c1 As Boolean, c2 As Boolean, c3 As Boolean, cbPago As String, cbHabitacion As String) As Double
        Dim Servicios As String
        Servicios = ""
        Dim descuentos As Double
        Dim subtotal As Double
        Dim total As Double

        If c1 = True Then
            Servicios += "Encamamiento "
        End If
        If c2 = True Then
            Servicios += "Operación "
        End If
        If c3 = True Then
            Servicios += "Maternidad "
        End If

        subtotal = honorarios

        Select Case cbHabitacion
            Case "Privada"
                If c1 = True Then
                    subtotal += 350 * dias
                End If
                If c2 = True Then
                    subtotal += 550 * dias
                End If
                If c3 = True Then
                    subtotal += 450 * dias
                End If
            Case "Semiprivada"
                If c1 = True Then
                    subtotal += 250 * dias
                End If
                If c2 = True Then
                    subtotal += 400 * dias
                End If
                If c3 = True Then
                    subtotal += 350 * dias
                End If
            Case "No privada"
                If c1 = True Then
                    subtotal += 150 * dias
                End If
                If c2 = True Then
                    subtotal += 300 * dias
                End If
                If c3 = True Then
                    subtotal += 250 * dias
                End If
            Case Else

        End Select

        Select Case cbPago
            Case "Efectivo"
                descuentos = subtotal * 0.15
                total = subtotal * 0.85
            Case "Cheque"
                descuentos = subtotal * 0.15
                total = subtotal * 0.85
            Case "Tarjeta de débito"
                descuentos = subtotal * 0.8
                total = subtotal * 0.92
            Case "Trajeta de crédito"
                descuentos = subtotal * 0.05
                total = subtotal * 1.05
            Case Else

        End Select

        Dim espacio As Boolean
        espacio = False

        For index0 = 0 To datos.GetUpperBound(0)
            If datos(index0, 0) = "" Then
                datos(index0, 0) = nombre
                datos(index0, 1) = nit
                datos(index0, 2) = dias
                datos(index0, 3) = honorarios
                datos(index0, 4) = cbHabitacion
                datos(index0, 5) = Servicios
                datos(index0, 6) = cbPago
                datos(index0, 7) = Format(subtotal, "0.00")
                datos(index0, 8) = Format(descuentos, "0.00")
                datos(index0, 9) = Format(total, "0.00")
                'MsgBox(index0)
                espacio = True
                Exit For
            End If
        Next

        If espacio = False Then
            MsgBox("No hay espacio en el vector, por favor libere espacio")
        End If

        Return honorarios
    End Function

    Function Mostrar()
        Salida.Items.Clear()

        For index0 = 0 To datos.GetUpperBound(0)
            Dim npaciente As String
            npaciente = "********** PACIENTE " & CInt(index0 + 1) & " **********"
            Salida.Items.Add(npaciente)
            Salida.Items.Add("Nombre: " & datos(index0, 0))
            Salida.Items.Add("NIT: " & datos(index0, 1))
            Salida.Items.Add("Días hospitalizado: " & datos(index0, 2))
            Salida.Items.Add("Honorarios: " & datos(index0, 3))
            Salida.Items.Add("Habitación: " & datos(index0, 4))
            Salida.Items.Add("Servicios prestados: " & datos(index0, 5))
            Salida.Items.Add("Forma de Pago: " & datos(index0, 6))
            Salida.Items.Add("Subtotal: " & datos(index0, 7))
            Salida.Items.Add("Descuento/Recargo: " & datos(index0, 8))
            Salida.Items.Add("Total: " & datos(index0, 9))
        Next
    End Function
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPago.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Desea salir de la aplicación?", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            End
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Nombre.Text() = ""
        NIT.Text() = ""
        Dias.Text() = 0
        Honorarios.Text() = ""
        cbHabitacion.Text() = ""
        chb1.Checked = False
        chb2.Checked = False
        chb3.Checked = False
        cbPago.Text() = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Salida.Items.Clear()
        For index0 = 0 To datos.GetUpperBound(0)
            For index1 = 0 To datos.GetUpperBound(1)
                datos(index0, index1) = ""
            Next
        Next
    End Sub
End Class
