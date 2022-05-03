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
        Me.eq = New System.Windows.Forms.Label()
        Me.comboEquipo = New System.Windows.Forms.ComboBox()
        Me.txtNumEtapa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKmRecorridos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        Me.comboNac = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarAscedenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConsultar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKm45 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKmEquipo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTiempoNac = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Etapa"
        '
        'eq
        '
        Me.eq.AutoSize = True
        Me.eq.Location = New System.Drawing.Point(44, 104)
        Me.eq.Name = "eq"
        Me.eq.Size = New System.Drawing.Size(59, 20)
        Me.eq.TabIndex = 2
        Me.eq.Text = "Equipo"
        '
        'comboEquipo
        '
        Me.comboEquipo.FormattingEnabled = True
        Me.comboEquipo.Items.AddRange(New Object() {"Sky", "Movistar", "Pro Cycling", "Pro Team"})
        Me.comboEquipo.Location = New System.Drawing.Point(210, 101)
        Me.comboEquipo.Name = "comboEquipo"
        Me.comboEquipo.Size = New System.Drawing.Size(174, 28)
        Me.comboEquipo.TabIndex = 3
        '
        'txtNumEtapa
        '
        Me.txtNumEtapa.Location = New System.Drawing.Point(210, 47)
        Me.txtNumEtapa.Name = "txtNumEtapa"
        Me.txtNumEtapa.Size = New System.Drawing.Size(174, 26)
        Me.txtNumEtapa.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Km Recorridos"
        '
        'txtKmRecorridos
        '
        Me.txtKmRecorridos.Location = New System.Drawing.Point(210, 159)
        Me.txtKmRecorridos.Name = "txtKmRecorridos"
        Me.txtKmRecorridos.Size = New System.Drawing.Size(174, 26)
        Me.txtKmRecorridos.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tiempo"
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(210, 222)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(174, 26)
        Me.txtTiempo.TabIndex = 6
        '
        'comboNac
        '
        Me.comboNac.FormattingEnabled = True
        Me.comboNac.Items.AddRange(New Object() {"guatemalteco", "extranjero"})
        Me.comboNac.Location = New System.Drawing.Point(210, 280)
        Me.comboNac.Name = "comboNac"
        Me.comboNac.Size = New System.Drawing.Size(174, 28)
        Me.comboNac.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nacionalidad"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.OrdenarAscedenteToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
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
        'OrdenarAscedenteToolStripMenuItem
        '
        Me.OrdenarAscedenteToolStripMenuItem.Name = "OrdenarAscedenteToolStripMenuItem"
        Me.OrdenarAscedenteToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.OrdenarAscedenteToolStripMenuItem.Text = "Ordenar Ascendente"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar entradas "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 353)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(684, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. etapa"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Equipo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Km Recorridos"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tiempo"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nacionalidad"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Penalización"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Consultar"
        '
        'txtConsultar
        '
        Me.txtConsultar.Location = New System.Drawing.Point(510, 47)
        Me.txtConsultar.Name = "txtConsultar"
        Me.txtConsultar.Size = New System.Drawing.Size(174, 26)
        Me.txtConsultar.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Más de 45 KM"
        '
        'txtKm45
        '
        Me.txtKm45.Location = New System.Drawing.Point(589, 128)
        Me.txtKm45.Name = "txtKm45"
        Me.txtKm45.Size = New System.Drawing.Size(131, 26)
        Me.txtKm45.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Km por equipo"
        '
        'txtKmEquipo
        '
        Me.txtKmEquipo.Location = New System.Drawing.Point(589, 177)
        Me.txtKmEquipo.Name = "txtKmEquipo"
        Me.txtKmEquipo.Size = New System.Drawing.Size(131, 26)
        Me.txtKmEquipo.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tiempo nacionalidad"
        '
        'txtTiempoNac
        '
        Me.txtTiempoNac.Location = New System.Drawing.Point(589, 222)
        Me.txtTiempoNac.Name = "txtTiempoNac"
        Me.txtTiempoNac.Size = New System.Drawing.Size(131, 26)
        Me.txtTiempoNac.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(510, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Estadistica"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(756, 540)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTiempoNac)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtKmEquipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKm45)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConsultar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.comboNac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKmRecorridos)
        Me.Controls.Add(Me.comboEquipo)
        Me.Controls.Add(Me.eq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumEtapa)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "VUELTA CICLISTICA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents eq As Label
    Friend WithEvents comboEquipo As ComboBox
    Friend WithEvents txtNumEtapa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKmRecorridos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTiempo As TextBox
    Friend WithEvents comboNac As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarAscedenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConsultar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKm45 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKmEquipo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTiempoNac As TextBox
    Friend WithEvents Label9 As Label
End Class
