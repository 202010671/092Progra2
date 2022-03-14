<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBEstudiante = New System.Windows.Forms.GroupBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBCarnet = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LCarné = New System.Windows.Forms.Label()
        Me.GBCurso = New System.Windows.Forms.GroupBox()
        Me.TBHora = New System.Windows.Forms.TextBox()
        Me.LHora = New System.Windows.Forms.Label()
        Me.CBDía = New System.Windows.Forms.ComboBox()
        Me.LDía = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LIdioma = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.CBIdioma = New System.Windows.Forms.ComboBox()
        Me.GBMétodo = New System.Windows.Forms.GroupBox()
        Me.RBCheque = New System.Windows.Forms.RadioButton()
        Me.RBEfectivo = New System.Windows.Forms.RadioButton()
        Me.BCalcular = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.GBEstudiante.SuspendLayout()
        Me.GBCurso.SuspendLayout()
        Me.GBMétodo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBEstudiante
        '
        Me.GBEstudiante.Controls.Add(Me.TBNombre)
        Me.GBEstudiante.Controls.Add(Me.TBCarnet)
        Me.GBEstudiante.Controls.Add(Me.LNombre)
        Me.GBEstudiante.Controls.Add(Me.LCarné)
        Me.GBEstudiante.Location = New System.Drawing.Point(14, 15)
        Me.GBEstudiante.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBEstudiante.Name = "GBEstudiante"
        Me.GBEstudiante.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBEstudiante.Size = New System.Drawing.Size(254, 110)
        Me.GBEstudiante.TabIndex = 0
        Me.GBEstudiante.TabStop = False
        Me.GBEstudiante.Text = "Datos del Estudiante"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(119, 64)
        Me.TBNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(114, 21)
        Me.TBNombre.TabIndex = 3
        '
        'TBCarnet
        '
        Me.TBCarnet.Location = New System.Drawing.Point(118, 32)
        Me.TBCarnet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBCarnet.Name = "TBCarnet"
        Me.TBCarnet.Size = New System.Drawing.Size(114, 21)
        Me.TBCarnet.TabIndex = 2
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(14, 64)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(51, 16)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'LCarné
        '
        Me.LCarné.AutoSize = True
        Me.LCarné.Location = New System.Drawing.Point(14, 32)
        Me.LCarné.Name = "LCarné"
        Me.LCarné.Size = New System.Drawing.Size(46, 16)
        Me.LCarné.TabIndex = 0
        Me.LCarné.Text = "Carnet"
        '
        'GBCurso
        '
        Me.GBCurso.Controls.Add(Me.TBHora)
        Me.GBCurso.Controls.Add(Me.LHora)
        Me.GBCurso.Controls.Add(Me.CBDía)
        Me.GBCurso.Controls.Add(Me.LDía)
        Me.GBCurso.Controls.Add(Me.LFecha)
        Me.GBCurso.Controls.Add(Me.LIdioma)
        Me.GBCurso.Controls.Add(Me.DTPFecha)
        Me.GBCurso.Controls.Add(Me.CBIdioma)
        Me.GBCurso.Location = New System.Drawing.Point(14, 133)
        Me.GBCurso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBCurso.Name = "GBCurso"
        Me.GBCurso.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBCurso.Size = New System.Drawing.Size(533, 162)
        Me.GBCurso.TabIndex = 1
        Me.GBCurso.TabStop = False
        Me.GBCurso.Text = "Curso"
        '
        'TBHora
        '
        Me.TBHora.Location = New System.Drawing.Point(266, 117)
        Me.TBHora.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBHora.Name = "TBHora"
        Me.TBHora.Size = New System.Drawing.Size(114, 21)
        Me.TBHora.TabIndex = 4
        Me.TBHora.Text = "Ingrese hora"
        '
        'LHora
        '
        Me.LHora.AutoSize = True
        Me.LHora.Location = New System.Drawing.Point(262, 94)
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(99, 16)
        Me.LHora.TabIndex = 8
        Me.LHora.Text = "Seleccione Hora:"
        '
        'CBDía
        '
        Me.CBDía.FormattingEnabled = True
        Me.CBDía.Items.AddRange(New Object() {"Viernes", "Sábado ", "Viernes y Sábado"})
        Me.CBDía.Location = New System.Drawing.Point(266, 46)
        Me.CBDía.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBDía.Name = "CBDía"
        Me.CBDía.Size = New System.Drawing.Size(159, 24)
        Me.CBDía.TabIndex = 7
        Me.CBDía.Text = "Seleccionar día:"
        '
        'LDía
        '
        Me.LDía.AutoSize = True
        Me.LDía.Location = New System.Drawing.Point(262, 20)
        Me.LDía.Name = "LDía"
        Me.LDía.Size = New System.Drawing.Size(88, 16)
        Me.LDía.TabIndex = 6
        Me.LDía.Text = "Seleccione Día"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(14, 94)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(120, 16)
        Me.LFecha.TabIndex = 4
        Me.LFecha.Text = "Fecha de Inscripción"
        '
        'LIdioma
        '
        Me.LIdioma.AutoSize = True
        Me.LIdioma.Location = New System.Drawing.Point(14, 26)
        Me.LIdioma.Name = "LIdioma"
        Me.LIdioma.Size = New System.Drawing.Size(108, 16)
        Me.LIdioma.TabIndex = 5
        Me.LIdioma.Text = "Seleccione Idioma"
        '
        'DTPFecha
        '
        Me.DTPFecha.Location = New System.Drawing.Point(17, 113)
        Me.DTPFecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(157, 21)
        Me.DTPFecha.TabIndex = 4
        '
        'CBIdioma
        '
        Me.CBIdioma.FormattingEnabled = True
        Me.CBIdioma.Items.AddRange(New Object() {"Inglés", "Portugués", "Francés"})
        Me.CBIdioma.Location = New System.Drawing.Point(17, 46)
        Me.CBIdioma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBIdioma.Name = "CBIdioma"
        Me.CBIdioma.Size = New System.Drawing.Size(159, 24)
        Me.CBIdioma.TabIndex = 3
        Me.CBIdioma.Text = "Seleccionar un idioma:"
        '
        'GBMétodo
        '
        Me.GBMétodo.Controls.Add(Me.RBCheque)
        Me.GBMétodo.Controls.Add(Me.RBEfectivo)
        Me.GBMétodo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GBMétodo.Location = New System.Drawing.Point(293, 15)
        Me.GBMétodo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBMétodo.Name = "GBMétodo"
        Me.GBMétodo.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBMétodo.Size = New System.Drawing.Size(254, 110)
        Me.GBMétodo.TabIndex = 2
        Me.GBMétodo.TabStop = False
        Me.GBMétodo.Text = "Método de Pago"
        '
        'RBCheque
        '
        Me.RBCheque.AutoSize = True
        Me.RBCheque.Location = New System.Drawing.Point(23, 65)
        Me.RBCheque.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RBCheque.Name = "RBCheque"
        Me.RBCheque.Size = New System.Drawing.Size(71, 20)
        Me.RBCheque.TabIndex = 1
        Me.RBCheque.TabStop = True
        Me.RBCheque.Text = "Cheque"
        Me.RBCheque.UseVisualStyleBackColor = True
        '
        'RBEfectivo
        '
        Me.RBEfectivo.AutoSize = True
        Me.RBEfectivo.Location = New System.Drawing.Point(23, 32)
        Me.RBEfectivo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RBEfectivo.Name = "RBEfectivo"
        Me.RBEfectivo.Size = New System.Drawing.Size(70, 20)
        Me.RBEfectivo.TabIndex = 0
        Me.RBEfectivo.TabStop = True
        Me.RBEfectivo.Text = "Efectivo"
        Me.RBEfectivo.UseVisualStyleBackColor = True
        '
        'BCalcular
        '
        Me.BCalcular.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BCalcular.Location = New System.Drawing.Point(51, 474)
        Me.BCalcular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BCalcular.Name = "BCalcular"
        Me.BCalcular.Size = New System.Drawing.Size(85, 34)
        Me.BCalcular.TabIndex = 3
        Me.BCalcular.Text = "Calcular"
        Me.BCalcular.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 303)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(533, 163)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Registro"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carnet"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Idioma"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fecha"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Día"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Hora"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Método"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Pago Parcial"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Descuento No.1"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Descuento No.2"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Total"
        Me.Column12.Name = "Column12"
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BSalir.Location = New System.Drawing.Point(413, 474)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(85, 34)
        Me.BSalir.TabIndex = 5
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BLimpiar.Location = New System.Drawing.Point(223, 474)
        Me.BLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(85, 34)
        Me.BLimpiar.TabIndex = 6
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(569, 506)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BCalcular)
        Me.Controls.Add(Me.GBMétodo)
        Me.Controls.Add(Me.GBCurso)
        Me.Controls.Add(Me.GBEstudiante)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBEstudiante.ResumeLayout(False)
        Me.GBEstudiante.PerformLayout()
        Me.GBCurso.ResumeLayout(False)
        Me.GBCurso.PerformLayout()
        Me.GBMétodo.ResumeLayout(False)
        Me.GBMétodo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBEstudiante As System.Windows.Forms.GroupBox
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBCarnet As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LCarné As System.Windows.Forms.Label
    Friend WithEvents GBCurso As System.Windows.Forms.GroupBox
    Friend WithEvents CBIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents GBMétodo As System.Windows.Forms.GroupBox
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BCalcular As System.Windows.Forms.Button
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents LIdioma As System.Windows.Forms.Label
    Friend WithEvents LHora As System.Windows.Forms.Label
    Friend WithEvents CBDía As System.Windows.Forms.ComboBox
    Friend WithEvents LDía As System.Windows.Forms.Label
    Friend WithEvents RBCheque As System.Windows.Forms.RadioButton
    Friend WithEvents RBEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents TBHora As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BLimpiar As System.Windows.Forms.Button

End Class
