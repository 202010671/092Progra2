<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRECIOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRECIOS))
        Me.GBTAMAÑO = New System.Windows.Forms.GroupBox()
        Me.RBLARGE = New System.Windows.Forms.RadioButton()
        Me.RBMEDIUM = New System.Windows.Forms.RadioButton()
        Me.RBSMALL = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBLONA = New System.Windows.Forms.RadioButton()
        Me.RBSEDA = New System.Windows.Forms.RadioButton()
        Me.RBALGODON = New System.Windows.Forms.RadioButton()
        Me.BCALCULAR = New System.Windows.Forms.Button()
        Me.BLIMPIAR = New System.Windows.Forms.Button()
        Me.BSALIR = New System.Windows.Forms.Button()
        Me.GBCANTIDAD = New System.Windows.Forms.GroupBox()
        Me.TBCANTIDAD = New System.Windows.Forms.TextBox()
        Me.LBCANTIDAD = New System.Windows.Forms.Label()
        Me.Resultados = New System.Windows.Forms.GroupBox()
        Me.TBVENTAR = New System.Windows.Forms.TextBox()
        Me.TBCOSTOR = New System.Windows.Forms.TextBox()
        Me.LR2 = New System.Windows.Forms.Label()
        Me.LR1 = New System.Windows.Forms.Label()
        Me.GBTAMAÑO.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBCANTIDAD.SuspendLayout()
        Me.Resultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBTAMAÑO
        '
        Me.GBTAMAÑO.Controls.Add(Me.RBLARGE)
        Me.GBTAMAÑO.Controls.Add(Me.RBMEDIUM)
        Me.GBTAMAÑO.Controls.Add(Me.RBSMALL)
        Me.GBTAMAÑO.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTAMAÑO.Location = New System.Drawing.Point(269, 29)
        Me.GBTAMAÑO.Name = "GBTAMAÑO"
        Me.GBTAMAÑO.Size = New System.Drawing.Size(255, 75)
        Me.GBTAMAÑO.TabIndex = 0
        Me.GBTAMAÑO.TabStop = False
        Me.GBTAMAÑO.Text = "Tamaño"
        '
        'RBLARGE
        '
        Me.RBLARGE.AutoSize = True
        Me.RBLARGE.Location = New System.Drawing.Point(188, 29)
        Me.RBLARGE.Name = "RBLARGE"
        Me.RBLARGE.Size = New System.Drawing.Size(59, 21)
        Me.RBLARGE.TabIndex = 2
        Me.RBLARGE.Text = "Large"
        Me.RBLARGE.UseVisualStyleBackColor = True
        '
        'RBMEDIUM
        '
        Me.RBMEDIUM.AutoSize = True
        Me.RBMEDIUM.Location = New System.Drawing.Point(92, 31)
        Me.RBMEDIUM.Name = "RBMEDIUM"
        Me.RBMEDIUM.Size = New System.Drawing.Size(74, 21)
        Me.RBMEDIUM.TabIndex = 1
        Me.RBMEDIUM.Text = "Medium"
        Me.RBMEDIUM.UseVisualStyleBackColor = True
        '
        'RBSMALL
        '
        Me.RBSMALL.AutoSize = True
        Me.RBSMALL.Location = New System.Drawing.Point(7, 31)
        Me.RBSMALL.Name = "RBSMALL"
        Me.RBSMALL.Size = New System.Drawing.Size(57, 21)
        Me.RBSMALL.TabIndex = 0
        Me.RBSMALL.Text = "Small"
        Me.RBSMALL.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBLONA)
        Me.GroupBox1.Controls.Add(Me.RBSEDA)
        Me.GroupBox1.Controls.Add(Me.RBALGODON)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 65)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material"
        '
        'RBLONA
        '
        Me.RBLONA.AutoSize = True
        Me.RBLONA.Location = New System.Drawing.Point(183, 34)
        Me.RBLONA.Name = "RBLONA"
        Me.RBLONA.Size = New System.Drawing.Size(54, 20)
        Me.RBLONA.TabIndex = 2
        Me.RBLONA.TabStop = True
        Me.RBLONA.Text = "Lona"
        Me.RBLONA.UseVisualStyleBackColor = True
        '
        'RBSEDA
        '
        Me.RBSEDA.AutoSize = True
        Me.RBSEDA.Location = New System.Drawing.Point(101, 34)
        Me.RBSEDA.Name = "RBSEDA"
        Me.RBSEDA.Size = New System.Drawing.Size(56, 20)
        Me.RBSEDA.TabIndex = 1
        Me.RBSEDA.TabStop = True
        Me.RBSEDA.Text = "Seda"
        Me.RBSEDA.UseVisualStyleBackColor = True
        '
        'RBALGODON
        '
        Me.RBALGODON.AutoSize = True
        Me.RBALGODON.Location = New System.Drawing.Point(7, 34)
        Me.RBALGODON.Name = "RBALGODON"
        Me.RBALGODON.Size = New System.Drawing.Size(77, 20)
        Me.RBALGODON.TabIndex = 0
        Me.RBALGODON.TabStop = True
        Me.RBALGODON.Text = "Algodón"
        Me.RBALGODON.UseVisualStyleBackColor = True
        '
        'BCALCULAR
        '
        Me.BCALCULAR.Location = New System.Drawing.Point(297, 123)
        Me.BCALCULAR.Name = "BCALCULAR"
        Me.BCALCULAR.Size = New System.Drawing.Size(91, 26)
        Me.BCALCULAR.TabIndex = 2
        Me.BCALCULAR.Text = "Calcular"
        Me.BCALCULAR.UseVisualStyleBackColor = True
        '
        'BLIMPIAR
        '
        Me.BLIMPIAR.Location = New System.Drawing.Point(434, 123)
        Me.BLIMPIAR.Name = "BLIMPIAR"
        Me.BLIMPIAR.Size = New System.Drawing.Size(91, 26)
        Me.BLIMPIAR.TabIndex = 3
        Me.BLIMPIAR.Text = "Limpiar"
        Me.BLIMPIAR.UseVisualStyleBackColor = True
        '
        'BSALIR
        '
        Me.BSALIR.Location = New System.Drawing.Point(361, 162)
        Me.BSALIR.Name = "BSALIR"
        Me.BSALIR.Size = New System.Drawing.Size(91, 26)
        Me.BSALIR.TabIndex = 4
        Me.BSALIR.Text = "Salir"
        Me.BSALIR.UseVisualStyleBackColor = True
        '
        'GBCANTIDAD
        '
        Me.GBCANTIDAD.Controls.Add(Me.TBCANTIDAD)
        Me.GBCANTIDAD.Controls.Add(Me.LBCANTIDAD)
        Me.GBCANTIDAD.Location = New System.Drawing.Point(20, 29)
        Me.GBCANTIDAD.Name = "GBCANTIDAD"
        Me.GBCANTIDAD.Size = New System.Drawing.Size(218, 75)
        Me.GBCANTIDAD.TabIndex = 5
        Me.GBCANTIDAD.TabStop = False
        Me.GBCANTIDAD.Text = "Ingrese Dato"
        '
        'TBCANTIDAD
        '
        Me.TBCANTIDAD.Location = New System.Drawing.Point(156, 31)
        Me.TBCANTIDAD.Name = "TBCANTIDAD"
        Me.TBCANTIDAD.Size = New System.Drawing.Size(56, 22)
        Me.TBCANTIDAD.TabIndex = 1
        Me.TBCANTIDAD.Text = "0"
        '
        'LBCANTIDAD
        '
        Me.LBCANTIDAD.AutoSize = True
        Me.LBCANTIDAD.Location = New System.Drawing.Point(13, 35)
        Me.LBCANTIDAD.Name = "LBCANTIDAD"
        Me.LBCANTIDAD.Size = New System.Drawing.Size(118, 16)
        Me.LBCANTIDAD.TabIndex = 0
        Me.LBCANTIDAD.Text = "Cantidad Deseada"
        '
        'Resultados
        '
        Me.Resultados.Controls.Add(Me.TBVENTAR)
        Me.Resultados.Controls.Add(Me.TBCOSTOR)
        Me.Resultados.Controls.Add(Me.LR2)
        Me.Resultados.Controls.Add(Me.LR1)
        Me.Resultados.Location = New System.Drawing.Point(20, 219)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(490, 55)
        Me.Resultados.TabIndex = 6
        Me.Resultados.TabStop = False
        Me.Resultados.Text = "Resultados"
        '
        'TBVENTAR
        '
        Me.TBVENTAR.Location = New System.Drawing.Point(368, 23)
        Me.TBVENTAR.Name = "TBVENTAR"
        Me.TBVENTAR.Size = New System.Drawing.Size(82, 22)
        Me.TBVENTAR.TabIndex = 3
        '
        'TBCOSTOR
        '
        Me.TBCOSTOR.Location = New System.Drawing.Point(144, 23)
        Me.TBCOSTOR.Name = "TBCOSTOR"
        Me.TBCOSTOR.Size = New System.Drawing.Size(82, 22)
        Me.TBCOSTOR.TabIndex = 2
        '
        'LR2
        '
        Me.LR2.AutoSize = True
        Me.LR2.Location = New System.Drawing.Point(235, 29)
        Me.LR2.Name = "LR2"
        Me.LR2.Size = New System.Drawing.Size(105, 16)
        Me.LR2.TabIndex = 1
        Me.LR2.Text = "Precio de Venta "
        '
        'LR1
        '
        Me.LR1.AutoSize = True
        Me.LR1.Location = New System.Drawing.Point(13, 29)
        Me.LR1.Name = "LR1"
        Me.LR1.Size = New System.Drawing.Size(104, 16)
        Me.LR1.TabIndex = 0
        Me.LR1.Text = "Precio de Costo "
        '
        'PRECIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(546, 289)
        Me.Controls.Add(Me.Resultados)
        Me.Controls.Add(Me.GBCANTIDAD)
        Me.Controls.Add(Me.BSALIR)
        Me.Controls.Add(Me.BLIMPIAR)
        Me.Controls.Add(Me.BCALCULAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBTAMAÑO)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PRECIOS"
        Me.Text = "Form1"
        Me.GBTAMAÑO.ResumeLayout(False)
        Me.GBTAMAÑO.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBCANTIDAD.ResumeLayout(False)
        Me.GBCANTIDAD.PerformLayout()
        Me.Resultados.ResumeLayout(False)
        Me.Resultados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBTAMAÑO As System.Windows.Forms.GroupBox
    Friend WithEvents RBLARGE As System.Windows.Forms.RadioButton
    Friend WithEvents RBMEDIUM As System.Windows.Forms.RadioButton
    Friend WithEvents RBSMALL As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBLONA As System.Windows.Forms.RadioButton
    Friend WithEvents RBSEDA As System.Windows.Forms.RadioButton
    Friend WithEvents RBALGODON As System.Windows.Forms.RadioButton
    Friend WithEvents BCALCULAR As System.Windows.Forms.Button
    Friend WithEvents BLIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BSALIR As System.Windows.Forms.Button
    Friend WithEvents GBCANTIDAD As System.Windows.Forms.GroupBox
    Friend WithEvents TBCANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents LBCANTIDAD As System.Windows.Forms.Label
    Friend WithEvents Resultados As System.Windows.Forms.GroupBox
    Friend WithEvents LR1 As System.Windows.Forms.Label
    Friend WithEvents TBVENTAR As System.Windows.Forms.TextBox
    Friend WithEvents TBCOSTOR As System.Windows.Forms.TextBox
    Friend WithEvents LR2 As System.Windows.Forms.Label

End Class
