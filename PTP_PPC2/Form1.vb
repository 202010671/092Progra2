Public Class PRECIOS

    'Evento para solo ingresar textos
    Private Sub TBCANTIDAD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBCANTIDAD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BCALCULAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BCALCULAR.Click
        If RBSMALL.Checked = False And RBMEDIUM.Checked = False And RBLARGE.Checked = False Then
            MsgBox("No se ha elegido tamaño")
            End
        End If

        If RBALGODON.Checked = False And RBSEDA.Checked = False And RBLONA.Checked = False Then
            MsgBox("No se ha elegido material")
            End
        End If

        If TBCANTIDAD.Text = "" Then
            MsgBox("Ingrese una cantidad")
            End
        End If

        Dim tamaño As String
        Dim material As String

        If RBSMALL.Checked Then
            tamaño = "SMALL"
        ElseIf RBMEDIUM.Checked Then
            tamaño = "MEDIUM"
        Else
            tamaño = "LARGE"
        End If

        If RBSEDA.Checked Then
            material = "Seda"
        ElseIf RBALGODON.Checked Then
            material = "Algodón"
        Else
            material = "Lona"
        End If



        Calcular(material, tamaño, Val(TBCANTIDAD.Text))

        TBCOSTOR.Text = "Q" & PrecioDeCosto
        TBVENTAR.Text = "Q" & PrecioDeVenta


    End Sub

    Private Sub BSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSALIR.Click
        Me.Close()
    End Sub


    Private Sub BLIMPIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLIMPIAR.Click
        TBCANTIDAD.Clear()
        TBCOSTOR.Clear()
        TBVENTAR.Clear()

    End Sub

    Private Sub GBTAMAÑO_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBTAMAÑO.Enter

    End Sub
End Class
