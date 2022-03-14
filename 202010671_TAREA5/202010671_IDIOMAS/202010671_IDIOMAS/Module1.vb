Module Module1
    Public matriz(10, 7)

    Public indice = 0

    Sub Limpiar()
        Form1.TBCarnet.Clear()
        Form1.TBHora.Clear()
        Form1.TBNombre.Clear()

        Form1.RBCheque.Checked = False
        Form1.RBEfectivo.Checked = False

        Form1.CBDía.Text = "Seleccionar un día..."
        Form1.CBIdioma.SelectedIndex = "Seleccionar un idioma..."

        Form1.DataGridView1.Rows.Clear()

        ReDim matriz(10, 7)
        indice = 0

    End Sub
End Module
