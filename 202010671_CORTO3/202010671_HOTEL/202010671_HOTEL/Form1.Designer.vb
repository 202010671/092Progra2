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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CálculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNNIT = New System.Windows.Forms.Label()
        Me.TBNIT = New System.Windows.Forms.TextBox()
        Me.LNombreHuesped = New System.Windows.Forms.Label()
        Me.TBNombreHuesped = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DíasHospedaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoHabitación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBDíasHospedarse = New System.Windows.Forms.TextBox()
        Me.LValorImpuesto = New System.Windows.Forms.Label()
        Me.TBValorImpuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBTipoHabitación = New System.Windows.Forms.ComboBox()
        Me.GBConsultar = New System.Windows.Forms.GroupBox()
        Me.TBConsultarNIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GBConsultar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(759, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CálculoToolStripMenuItem
        '
        Me.CálculoToolStripMenuItem.Name = "CálculoToolStripMenuItem"
        Me.CálculoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.CálculoToolStripMenuItem.Text = "Cálculo"
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
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBTipoPago)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LNNIT)
        Me.GroupBox1.Controls.Add(Me.TBNIT)
        Me.GroupBox1.Controls.Add(Me.LNombreHuesped)
        Me.GroupBox1.Controls.Add(Me.TBNombreHuesped)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 149)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Huesped"
        '
        'CBTipoPago
        '
        Me.CBTipoPago.FormattingEnabled = True
        Me.CBTipoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta Débito/Crédito ", "Transferencia ", "Depósito"})
        Me.CBTipoPago.Location = New System.Drawing.Point(153, 107)
        Me.CBTipoPago.Name = "CBTipoPago"
        Me.CBTipoPago.Size = New System.Drawing.Size(113, 24)
        Me.CBTipoPago.TabIndex = 11
        Me.CBTipoPago.Text = "Seleccione..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo de Pago"
        '
        'LNNIT
        '
        Me.LNNIT.AutoSize = True
        Me.LNNIT.Location = New System.Drawing.Point(14, 71)
        Me.LNNIT.Name = "LNNIT"
        Me.LNNIT.Size = New System.Drawing.Size(45, 16)
        Me.LNNIT.TabIndex = 3
        Me.LNNIT.Text = "No. NIT"
        '
        'TBNIT
        '
        Me.TBNIT.Location = New System.Drawing.Point(149, 68)
        Me.TBNIT.Name = "TBNIT"
        Me.TBNIT.Size = New System.Drawing.Size(118, 21)
        Me.TBNIT.TabIndex = 2
        '
        'LNombreHuesped
        '
        Me.LNombreHuesped.AutoSize = True
        Me.LNombreHuesped.Location = New System.Drawing.Point(14, 33)
        Me.LNombreHuesped.Name = "LNombreHuesped"
        Me.LNombreHuesped.Size = New System.Drawing.Size(123, 16)
        Me.LNombreHuesped.TabIndex = 1
        Me.LNombreHuesped.Text = "Nombre del Huesped"
        '
        'TBNombreHuesped
        '
        Me.TBNombreHuesped.Location = New System.Drawing.Point(149, 30)
        Me.TBNombreHuesped.Name = "TBNombreHuesped"
        Me.TBNombreHuesped.Size = New System.Drawing.Size(118, 21)
        Me.TBNombreHuesped.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.NIT, Me.Column1, Me.DíasHospedaje, Me.TipoHabitación, Me.Impuesto, Me.PagoTotal, Me.Descuento, Me.Recargo, Me.TotalCompleto, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 273)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 139)
        Me.DataGridView1.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'NIT
        '
        Me.NIT.HeaderText = "NIT"
        Me.NIT.Name = "NIT"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo de Pago"
        Me.Column1.Name = "Column1"
        '
        'DíasHospedaje
        '
        Me.DíasHospedaje.HeaderText = "DíasHospedaje"
        Me.DíasHospedaje.Name = "DíasHospedaje"
        '
        'TipoHabitación
        '
        Me.TipoHabitación.HeaderText = "TipoHabitación"
        Me.TipoHabitación.Name = "TipoHabitación"
        '
        'Impuesto
        '
        Me.Impuesto.HeaderText = "Impuesto"
        Me.Impuesto.Name = "Impuesto"
        '
        'PagoTotal
        '
        Me.PagoTotal.HeaderText = "PagoTotal"
        Me.PagoTotal.Name = "PagoTotal"
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        '
        'Recargo
        '
        Me.Recargo.HeaderText = "Recargo"
        Me.Recargo.Name = "Recargo"
        '
        'TotalCompleto
        '
        Me.TotalCompleto.HeaderText = "TotalCompleto"
        Me.TotalCompleto.Name = "TotalCompleto"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No. Días a Hospedarse"
        '
        'TBDíasHospedarse
        '
        Me.TBDíasHospedarse.Location = New System.Drawing.Point(180, 25)
        Me.TBDíasHospedarse.Name = "TBDíasHospedarse"
        Me.TBDíasHospedarse.Size = New System.Drawing.Size(118, 21)
        Me.TBDíasHospedarse.TabIndex = 4
        '
        'LValorImpuesto
        '
        Me.LValorImpuesto.AutoSize = True
        Me.LValorImpuesto.Location = New System.Drawing.Point(22, 100)
        Me.LValorImpuesto.Name = "LValorImpuesto"
        Me.LValorImpuesto.Size = New System.Drawing.Size(108, 16)
        Me.LValorImpuesto.TabIndex = 7
        Me.LValorImpuesto.Text = "Valor del Impuesto"
        '
        'TBValorImpuesto
        '
        Me.TBValorImpuesto.Location = New System.Drawing.Point(180, 98)
        Me.TBValorImpuesto.Name = "TBValorImpuesto"
        Me.TBValorImpuesto.Size = New System.Drawing.Size(118, 21)
        Me.TBValorImpuesto.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipo de Habitación"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBTipoHabitación)
        Me.GroupBox2.Controls.Add(Me.TBValorImpuesto)
        Me.GroupBox2.Controls.Add(Me.LValorImpuesto)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TBDíasHospedarse)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(376, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 149)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Reserva "
        '
        'CBTipoHabitación
        '
        Me.CBTipoHabitación.FormattingEnabled = True
        Me.CBTipoHabitación.Items.AddRange(New Object() {"Sencilla", "Doble", "Cabaña"})
        Me.CBTipoHabitación.Location = New System.Drawing.Point(180, 58)
        Me.CBTipoHabitación.Name = "CBTipoHabitación"
        Me.CBTipoHabitación.Size = New System.Drawing.Size(118, 24)
        Me.CBTipoHabitación.TabIndex = 12
        Me.CBTipoHabitación.Text = "Seleccione..."
        '
        'GBConsultar
        '
        Me.GBConsultar.Controls.Add(Me.TBConsultarNIT)
        Me.GBConsultar.Controls.Add(Me.Label4)
        Me.GBConsultar.Location = New System.Drawing.Point(17, 207)
        Me.GBConsultar.Name = "GBConsultar"
        Me.GBConsultar.Size = New System.Drawing.Size(319, 49)
        Me.GBConsultar.TabIndex = 4
        Me.GBConsultar.TabStop = False
        Me.GBConsultar.Text = "Consultar"
        '
        'TBConsultarNIT
        '
        Me.TBConsultarNIT.Location = New System.Drawing.Point(144, 20)
        Me.TBConsultarNIT.Name = "TBConsultarNIT"
        Me.TBConsultarNIT.Size = New System.Drawing.Size(118, 21)
        Me.TBConsultarNIT.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "No. NIT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(759, 424)
        Me.Controls.Add(Me.GBConsultar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GBConsultar.ResumeLayout(False)
        Me.GBConsultar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LNombreHuesped As System.Windows.Forms.Label
    Friend WithEvents TBNombreHuesped As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CálculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LNNIT As System.Windows.Forms.Label
    Friend WithEvents TBNIT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBDíasHospedarse As System.Windows.Forms.TextBox
    Friend WithEvents LValorImpuesto As System.Windows.Forms.Label
    Friend WithEvents TBValorImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DíasHospedaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoHabitación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBTipoHabitación As System.Windows.Forms.ComboBox
    Friend WithEvents GBConsultar As System.Windows.Forms.GroupBox
    Friend WithEvents TBConsultarNIT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
