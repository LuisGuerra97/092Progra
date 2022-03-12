<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCarnet = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidadHoras = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataCarnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataIdioma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDía = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataCantidadHoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comboFormaPago = New System.Windows.Forms.ComboBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ComboIdioma = New System.Windows.Forms.ComboBox()
        Me.DTpicker = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxViernes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSabado = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carnet del estudiante"
        '
        'txtCarnet
        '
        Me.txtCarnet.Location = New System.Drawing.Point(268, 25)
        Me.txtCarnet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCarnet.Name = "txtCarnet"
        Me.txtCarnet.Size = New System.Drawing.Size(172, 26)
        Me.txtCarnet.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(268, 65)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(172, 26)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del Estudiante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seleccionar Idioma"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de Inscripción"
        '
        'txtCantidadHoras
        '
        Me.txtCantidadHoras.Location = New System.Drawing.Point(268, 200)
        Me.txtCantidadHoras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCantidadHoras.Name = "txtCantidadHoras"
        Me.txtCantidadHoras.Size = New System.Drawing.Size(172, 26)
        Me.txtCantidadHoras.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad de horas "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Forma de Pago"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(584, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Días a recibir el curso"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataCarnet, Me.DataNombre, Me.DataIdioma, Me.DataFecha, Me.DataDía, Me.DataCantidadHoras, Me.DataFormaPago, Me.Column3, Me.Column1, Me.Column2, Me.DataPago})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1012, 255)
        Me.DataGridView1.TabIndex = 15
        '
        'DataCarnet
        '
        Me.DataCarnet.HeaderText = "Carnet"
        Me.DataCarnet.Name = "DataCarnet"
        Me.DataCarnet.Width = 75
        '
        'DataNombre
        '
        Me.DataNombre.HeaderText = "Nombre"
        Me.DataNombre.Name = "DataNombre"
        Me.DataNombre.Width = 120
        '
        'DataIdioma
        '
        Me.DataIdioma.HeaderText = "Idioma"
        Me.DataIdioma.Name = "DataIdioma"
        Me.DataIdioma.Width = 75
        '
        'DataFecha
        '
        Me.DataFecha.HeaderText = "Fecha de Inscripción"
        Me.DataFecha.Name = "DataFecha"
        '
        'DataDía
        '
        Me.DataDía.HeaderText = "Dia"
        Me.DataDía.Name = "DataDía"
        Me.DataDía.Width = 85
        '
        'DataCantidadHoras
        '
        Me.DataCantidadHoras.HeaderText = "Cantidad de Horas"
        Me.DataCantidadHoras.Name = "DataCantidadHoras"
        Me.DataCantidadHoras.Width = 85
        '
        'DataFormaPago
        '
        Me.DataFormaPago.HeaderText = "Forma de Pago"
        Me.DataFormaPago.Name = "DataFormaPago"
        Me.DataFormaPago.Width = 85
        '
        'Column3
        '
        Me.Column3.HeaderText = "Pago Parcial"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descuento 1"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descuento 2"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 90
        '
        'DataPago
        '
        Me.DataPago.HeaderText = "Pago Final"
        Me.DataPago.Name = "DataPago"
        Me.DataPago.Width = 85
        '
        'comboFormaPago
        '
        Me.comboFormaPago.FormattingEnabled = True
        Me.comboFormaPago.Items.AddRange(New Object() {"Efectivo", "Cheque"})
        Me.comboFormaPago.Location = New System.Drawing.Point(268, 246)
        Me.comboFormaPago.Name = "comboFormaPago"
        Me.comboFormaPago.Size = New System.Drawing.Size(172, 28)
        Me.comboFormaPago.TabIndex = 20
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(607, 114)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(116, 47)
        Me.btnCalcular.TabIndex = 21
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(607, 176)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(116, 47)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(607, 236)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 47)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ComboIdioma
        '
        Me.ComboIdioma.FormattingEnabled = True
        Me.ComboIdioma.Items.AddRange(New Object() {"Inglés", "Portugués", "Francés"})
        Me.ComboIdioma.Location = New System.Drawing.Point(268, 154)
        Me.ComboIdioma.Name = "ComboIdioma"
        Me.ComboIdioma.Size = New System.Drawing.Size(172, 28)
        Me.ComboIdioma.TabIndex = 26
        '
        'DTpicker
        '
        Me.DTpicker.Location = New System.Drawing.Point(268, 109)
        Me.DTpicker.Name = "DTpicker"
        Me.DTpicker.Size = New System.Drawing.Size(172, 26)
        Me.DTpicker.TabIndex = 27
        '
        'CheckBoxViernes
        '
        Me.CheckBoxViernes.AutoSize = True
        Me.CheckBoxViernes.Location = New System.Drawing.Point(570, 71)
        Me.CheckBoxViernes.Name = "CheckBoxViernes"
        Me.CheckBoxViernes.Size = New System.Drawing.Size(82, 24)
        Me.CheckBoxViernes.TabIndex = 28
        Me.CheckBoxViernes.Text = "Viernes"
        Me.CheckBoxViernes.UseVisualStyleBackColor = True
        '
        'CheckBoxSabado
        '
        Me.CheckBoxSabado.AutoSize = True
        Me.CheckBoxSabado.Location = New System.Drawing.Point(687, 71)
        Me.CheckBoxSabado.Name = "CheckBoxSabado"
        Me.CheckBoxSabado.Size = New System.Drawing.Size(85, 24)
        Me.CheckBoxSabado.TabIndex = 29
        Me.CheckBoxSabado.Text = "Sabado"
        Me.CheckBoxSabado.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1036, 596)
        Me.Controls.Add(Me.CheckBoxSabado)
        Me.Controls.Add(Me.CheckBoxViernes)
        Me.Controls.Add(Me.DTpicker)
        Me.Controls.Add(Me.ComboIdioma)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.comboFormaPago)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCantidadHoras)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCarnet)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "IDIOMAS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCarnet As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidadHoras As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents comboFormaPago As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ComboIdioma As ComboBox
    Friend WithEvents DTpicker As DateTimePicker
    Friend WithEvents CheckBoxViernes As CheckBox
    Friend WithEvents CheckBoxSabado As CheckBox
    Friend WithEvents DataCarnet As DataGridViewTextBoxColumn
    Friend WithEvents DataNombre As DataGridViewTextBoxColumn
    Friend WithEvents DataIdioma As DataGridViewTextBoxColumn
    Friend WithEvents DataFecha As DataGridViewTextBoxColumn
    Friend WithEvents DataDía As DataGridViewTextBoxColumn
    Friend WithEvents DataCantidadHoras As DataGridViewTextBoxColumn
    Friend WithEvents DataFormaPago As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataPago As DataGridViewTextBoxColumn
End Class
