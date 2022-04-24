<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Autos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NúmerodePlaca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeleccionarTipodeAuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipodeCobroBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilometrosIniciales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilometrosFinales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorridodeKilometros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoFinalEstablecido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDatos = New System.Windows.Forms.GroupBox()
        Me.CBTipoAuto = New System.Windows.Forms.ComboBox()
        Me.TBKilometrajeFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBKilometrajeInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBCobroBase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNoPlaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBConsultarNoPlaca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBPagoTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.IngresoDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NúmerodePlaca, Me.SeleccionarTipodeAuto, Me.TipodeCobroBase, Me.KilometrosIniciales, Me.KilometrosFinales, Me.RecorridodeKilometros, Me.PagoFinalEstablecido})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 281)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(750, 123)
        Me.DataGridView1.TabIndex = 0
        '
        'NúmerodePlaca
        '
        Me.NúmerodePlaca.HeaderText = "No. Placa"
        Me.NúmerodePlaca.Name = "NúmerodePlaca"
        '
        'SeleccionarTipodeAuto
        '
        Me.SeleccionarTipodeAuto.HeaderText = "Tipo Auto"
        Me.SeleccionarTipodeAuto.Name = "SeleccionarTipodeAuto"
        '
        'TipodeCobroBase
        '
        Me.TipodeCobroBase.HeaderText = "Cobro Base"
        Me.TipodeCobroBase.Name = "TipodeCobroBase"
        '
        'KilometrosIniciales
        '
        Me.KilometrosIniciales.HeaderText = "Km Inicial"
        Me.KilometrosIniciales.Name = "KilometrosIniciales"
        '
        'KilometrosFinales
        '
        Me.KilometrosFinales.HeaderText = "Km Final"
        Me.KilometrosFinales.Name = "KilometrosFinales"
        '
        'RecorridodeKilometros
        '
        Me.RecorridodeKilometros.HeaderText = "Recorrido"
        Me.RecorridodeKilometros.Name = "RecorridodeKilometros"
        '
        'PagoFinalEstablecido
        '
        Me.PagoFinalEstablecido.HeaderText = "Pago Final"
        Me.PagoFinalEstablecido.Name = "PagoFinalEstablecido"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(777, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'IngresoDatos
        '
        Me.IngresoDatos.Controls.Add(Me.CBTipoAuto)
        Me.IngresoDatos.Controls.Add(Me.TBKilometrajeFinal)
        Me.IngresoDatos.Controls.Add(Me.Label5)
        Me.IngresoDatos.Controls.Add(Me.TBKilometrajeInicial)
        Me.IngresoDatos.Controls.Add(Me.Label4)
        Me.IngresoDatos.Controls.Add(Me.TBCobroBase)
        Me.IngresoDatos.Controls.Add(Me.Label3)
        Me.IngresoDatos.Controls.Add(Me.Label2)
        Me.IngresoDatos.Controls.Add(Me.TBNoPlaca)
        Me.IngresoDatos.Controls.Add(Me.Label1)
        Me.IngresoDatos.Location = New System.Drawing.Point(24, 53)
        Me.IngresoDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IngresoDatos.Name = "IngresoDatos"
        Me.IngresoDatos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IngresoDatos.Size = New System.Drawing.Size(266, 204)
        Me.IngresoDatos.TabIndex = 2
        Me.IngresoDatos.TabStop = False
        Me.IngresoDatos.Text = "Ingreso de Datos"
        '
        'CBTipoAuto
        '
        Me.CBTipoAuto.FormattingEnabled = True
        Me.CBTipoAuto.Items.AddRange(New Object() {"Tipo 1", "Tipo 2", "Tipo 3", "Tipo 4"})
        Me.CBTipoAuto.Location = New System.Drawing.Point(126, 53)
        Me.CBTipoAuto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CBTipoAuto.Name = "CBTipoAuto"
        Me.CBTipoAuto.Size = New System.Drawing.Size(104, 24)
        Me.CBTipoAuto.TabIndex = 0
        Me.CBTipoAuto.Text = "Seleccione..."
        '
        'TBKilometrajeFinal
        '
        Me.TBKilometrajeFinal.Location = New System.Drawing.Point(125, 166)
        Me.TBKilometrajeFinal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBKilometrajeFinal.Name = "TBKilometrajeFinal"
        Me.TBKilometrajeFinal.Size = New System.Drawing.Size(105, 21)
        Me.TBKilometrajeFinal.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kilometraje Final"
        '
        'TBKilometrajeInicial
        '
        Me.TBKilometrajeInicial.Location = New System.Drawing.Point(126, 128)
        Me.TBKilometrajeInicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBKilometrajeInicial.Name = "TBKilometrajeInicial"
        Me.TBKilometrajeInicial.Size = New System.Drawing.Size(104, 21)
        Me.TBKilometrajeInicial.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kilometraje Inicial "
        '
        'TBCobroBase
        '
        Me.TBCobroBase.Location = New System.Drawing.Point(125, 90)
        Me.TBCobroBase.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBCobroBase.Name = "TBCobroBase"
        Me.TBCobroBase.Size = New System.Drawing.Size(105, 21)
        Me.TBCobroBase.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cobro Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Auto"
        '
        'TBNoPlaca
        '
        Me.TBNoPlaca.AllowDrop = True
        Me.TBNoPlaca.Location = New System.Drawing.Point(126, 22)
        Me.TBNoPlaca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBNoPlaca.Name = "TBNoPlaca"
        Me.TBNoPlaca.Size = New System.Drawing.Size(104, 21)
        Me.TBNoPlaca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. de Placa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TBConsultarNoPlaca)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(315, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(244, 79)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 132)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(218, 73)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consultar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(10, 74)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 21)
        Me.TextBox2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "No. de Placa"
        '
        'TBConsultarNoPlaca
        '
        Me.TBConsultarNoPlaca.Location = New System.Drawing.Point(108, 43)
        Me.TBConsultarNoPlaca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBConsultarNoPlaca.Name = "TBConsultarNoPlaca"
        Me.TBConsultarNoPlaca.Size = New System.Drawing.Size(104, 21)
        Me.TBConsultarNoPlaca.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "No. de Placa"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.TBPagoTotal)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 146)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(237, 105)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calcular"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 132)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(218, 73)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consultar"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(10, 74)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 21)
        Me.TextBox3.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "No. de Placa"
        '
        'TBPagoTotal
        '
        Me.TBPagoTotal.Location = New System.Drawing.Point(101, 39)
        Me.TBPagoTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBPagoTotal.Name = "TBPagoTotal"
        Me.TBPagoTotal.Size = New System.Drawing.Size(104, 21)
        Me.TBPagoTotal.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Pago Total"
        '
        'Autos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(777, 466)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IngresoDatos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Autos"
        Me.Text = "Autos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.IngresoDatos.ResumeLayout(False)
        Me.IngresoDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents CBTipoAuto As System.Windows.Forms.ComboBox
    Friend WithEvents TBKilometrajeFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBKilometrajeInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBCobroBase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBNoPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBConsultarNoPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBPagoTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NúmerodePlaca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeleccionarTipodeAuto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipodeCobroBase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilometrosIniciales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilometrosFinales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecorridodeKilometros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagoFinalEstablecido As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
