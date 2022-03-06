<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hospital
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Honorarios = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPago = New System.Windows.Forms.ComboBox()
        Me.cbHabitacion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chb1 = New System.Windows.Forms.CheckBox()
        Me.chb2 = New System.Windows.Forms.CheckBox()
        Me.chb3 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.ListBox()
        CType(Me.Dias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(38, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Nombre
        '
        Me.Nombre.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Nombre.Location = New System.Drawing.Point(219, 71)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(309, 30)
        Me.Nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*Nombre Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(445, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 44)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HOSPITAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "*Número de NIT"
        '
        'NIT
        '
        Me.NIT.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NIT.Location = New System.Drawing.Point(219, 107)
        Me.NIT.Name = "NIT"
        Me.NIT.Size = New System.Drawing.Size(309, 30)
        Me.NIT.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "*Días hospitalizado"
        '
        'Honorarios
        '
        Me.Honorarios.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Honorarios.Location = New System.Drawing.Point(219, 181)
        Me.Honorarios.Name = "Honorarios"
        Me.Honorarios.Size = New System.Drawing.Size(309, 30)
        Me.Honorarios.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "*Honorarios               Q"
        '
        'Dias
        '
        Me.Dias.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Dias.Location = New System.Drawing.Point(219, 144)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(180, 30)
        Me.Dias.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*Tipo de habitación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "*Forma de pago"
        '
        'cbPago
        '
        Me.cbPago.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbPago.FormattingEnabled = True
        Me.cbPago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Trajeta de crédito", "Tarjeta de débito"})
        Me.cbPago.Location = New System.Drawing.Point(219, 335)
        Me.cbPago.Name = "cbPago"
        Me.cbPago.Size = New System.Drawing.Size(182, 31)
        Me.cbPago.TabIndex = 13
        '
        'cbHabitacion
        '
        Me.cbHabitacion.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbHabitacion.FormattingEnabled = True
        Me.cbHabitacion.Items.AddRange(New Object() {"Privada", "Semiprivada", "No privada"})
        Me.cbHabitacion.Location = New System.Drawing.Point(219, 218)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(182, 31)
        Me.cbHabitacion.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(12, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Servicios"
        '
        'chb1
        '
        Me.chb1.AutoSize = True
        Me.chb1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb1.Location = New System.Drawing.Point(17, 296)
        Me.chb1.Name = "chb1"
        Me.chb1.Size = New System.Drawing.Size(173, 27)
        Me.chb1.TabIndex = 16
        Me.chb1.Text = "Encamamiento"
        Me.chb1.UseVisualStyleBackColor = True
        '
        'chb2
        '
        Me.chb2.AutoSize = True
        Me.chb2.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb2.Location = New System.Drawing.Point(196, 296)
        Me.chb2.Name = "chb2"
        Me.chb2.Size = New System.Drawing.Size(136, 27)
        Me.chb2.TabIndex = 17
        Me.chb2.Text = "Operación"
        Me.chb2.UseVisualStyleBackColor = True
        '
        'chb3
        '
        Me.chb3.AutoSize = True
        Me.chb3.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chb3.Location = New System.Drawing.Point(338, 296)
        Me.chb3.Name = "chb3"
        Me.chb3.Size = New System.Drawing.Size(150, 27)
        Me.chb3.TabIndex = 18
        Me.chb3.Text = "Maternidad"
        Me.chb3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(12, 527)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aqua
        Me.Button3.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(328, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 62)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Limpiar listbox/vectores"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Aqua
        Me.Button4.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(154, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 62)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Limpiar datos de entrada"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Salida
        '
        Me.Salida.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Salida.FormattingEnabled = True
        Me.Salida.ItemHeight = 23
        Me.Salida.Location = New System.Drawing.Point(547, 71)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(477, 487)
        Me.Salida.TabIndex = 22
        '
        'Hospital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1036, 569)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.chb3)
        Me.Controls.Add(Me.chb2)
        Me.Controls.Add(Me.chb1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbPago)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbHabitacion)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Honorarios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NIT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Hospital"
        Me.Text = "Hospital"
        CType(Me.Dias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NIT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Honorarios As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Dias As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbPago As ComboBox
    Friend WithEvents cbHabitacion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chb1 As CheckBox
    Friend WithEvents chb2 As CheckBox
    Friend WithEvents chb3 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Salida As ListBox
End Class
