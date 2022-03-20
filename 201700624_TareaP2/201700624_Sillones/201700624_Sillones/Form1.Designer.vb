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
        Me.txtNumeroVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboTamaño = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboTela = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiarGrid = New System.Windows.Forms.Button()
        Me.btnLimpiarVect = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumeroVenta
        '
        Me.txtNumeroVenta.Location = New System.Drawing.Point(261, 39)
        Me.txtNumeroVenta.Name = "txtNumeroVenta"
        Me.txtNumeroVenta.Size = New System.Drawing.Size(121, 23)
        Me.txtNumeroVenta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de venta"
        '
        'comboTamaño
        '
        Me.comboTamaño.FormattingEnabled = True
        Me.comboTamaño.Items.AddRange(New Object() {"Sofá", "Individual", "Doble"})
        Me.comboTamaño.Location = New System.Drawing.Point(261, 77)
        Me.comboTamaño.Name = "comboTamaño"
        Me.comboTamaño.Size = New System.Drawing.Size(121, 25)
        Me.comboTamaño.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tamaño "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo de tela"
        '
        'comboTela
        '
        Me.comboTela.FormattingEnabled = True
        Me.comboTela.Items.AddRange(New Object() {"Cuero", "Cuerina"})
        Me.comboTela.Location = New System.Drawing.Point(261, 123)
        Me.comboTela.Name = "comboTela"
        Me.comboTela.Size = New System.Drawing.Size(121, 25)
        Me.comboTela.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(745, 121)
        Me.DataGridView1.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Número de venta"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Precio Mano de Obra"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio Costo"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio Venta"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tamaño"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Tipo de Tela"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Yardas"
        Me.Column7.Name = "Column7"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(457, 42)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(96, 43)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiarGrid
        '
        Me.btnLimpiarGrid.Location = New System.Drawing.Point(559, 42)
        Me.btnLimpiarGrid.Name = "btnLimpiarGrid"
        Me.btnLimpiarGrid.Size = New System.Drawing.Size(96, 43)
        Me.btnLimpiarGrid.TabIndex = 8
        Me.btnLimpiarGrid.Text = "Limpiar Grid"
        Me.btnLimpiarGrid.UseVisualStyleBackColor = True
        '
        'btnLimpiarVect
        '
        Me.btnLimpiarVect.Location = New System.Drawing.Point(457, 91)
        Me.btnLimpiarVect.Name = "btnLimpiarVect"
        Me.btnLimpiarVect.Size = New System.Drawing.Size(96, 43)
        Me.btnLimpiarVect.TabIndex = 9
        Me.btnLimpiarVect.Text = "Limpiar Vectores"
        Me.btnLimpiarVect.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(559, 91)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(96, 43)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(769, 322)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.btnLimpiarVect)
        Me.Controls.Add(Me.btnLimpiarGrid)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboTela)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboTamaño)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumeroVenta)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "SILLONES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumeroVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboTamaño As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comboTela As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiarGrid As Button
    Friend WithEvents btnLimpiarVect As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
