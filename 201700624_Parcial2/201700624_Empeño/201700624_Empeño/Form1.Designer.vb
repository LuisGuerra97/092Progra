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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.comboTipoPlazo = New System.Windows.Forms.ComboBox()
        Me.tipopago = New System.Windows.Forms.Label()
        Me.ListNombre = New System.Windows.Forms.ListBox()
        Me.txtCUI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListCUI = New System.Windows.Forms.ListBox()
        Me.ListDirección = New System.Windows.Forms.ListBox()
        Me.ListPlazo = New System.Windows.Forms.ListBox()
        Me.ListAparato = New System.Windows.Forms.ListBox()
        Me.checkBoxTV = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTelefono = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLaptop = New System.Windows.Forms.CheckBox()
        Me.txtCostoTV = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.checkBoxRefri = New System.Windows.Forms.CheckBox()
        Me.txtCostoTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCostoLaptop = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCostoRefri = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListDescuentos = New System.Windows.Forms.ListBox()
        Me.ListCosto = New System.Windows.Forms.ListBox()
        Me.ListPagoParcial = New System.Windows.Forms.ListBox()
        Me.ListPagoFinal = New System.Windows.Forms.ListBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(319, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 26)
        Me.txtNombre.TabIndex = 1
        '
        'comboTipoPlazo
        '
        Me.comboTipoPlazo.FormattingEnabled = True
        Me.comboTipoPlazo.Items.AddRange(New Object() {"Largo", "Corto"})
        Me.comboTipoPlazo.Location = New System.Drawing.Point(635, 84)
        Me.comboTipoPlazo.Name = "comboTipoPlazo"
        Me.comboTipoPlazo.Size = New System.Drawing.Size(158, 28)
        Me.comboTipoPlazo.TabIndex = 2
        '
        'tipopago
        '
        Me.tipopago.AutoSize = True
        Me.tipopago.Location = New System.Drawing.Point(514, 92)
        Me.tipopago.Name = "tipopago"
        Me.tipopago.Size = New System.Drawing.Size(103, 20)
        Me.tipopago.TabIndex = 3
        Me.tipopago.Text = "Tipo de Plazo"
        '
        'ListNombre
        '
        Me.ListNombre.FormattingEnabled = True
        Me.ListNombre.ItemHeight = 20
        Me.ListNombre.Location = New System.Drawing.Point(21, 387)
        Me.ListNombre.Name = "ListNombre"
        Me.ListNombre.Size = New System.Drawing.Size(106, 224)
        Me.ListNombre.TabIndex = 5
        '
        'txtCUI
        '
        Me.txtCUI.Location = New System.Drawing.Point(319, 90)
        Me.txtCUI.Name = "txtCUI"
        Me.txtCUI.Size = New System.Drawing.Size(121, 26)
        Me.txtCUI.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CUI"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(635, 43)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(158, 26)
        Me.txtDireccion.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(514, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(514, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tipo de Aparato"
        '
        'ListCUI
        '
        Me.ListCUI.FormattingEnabled = True
        Me.ListCUI.ItemHeight = 20
        Me.ListCUI.Location = New System.Drawing.Point(133, 387)
        Me.ListCUI.Name = "ListCUI"
        Me.ListCUI.Size = New System.Drawing.Size(100, 224)
        Me.ListCUI.TabIndex = 16
        '
        'ListDirección
        '
        Me.ListDirección.FormattingEnabled = True
        Me.ListDirección.ItemHeight = 20
        Me.ListDirección.Location = New System.Drawing.Point(239, 387)
        Me.ListDirección.Name = "ListDirección"
        Me.ListDirección.Size = New System.Drawing.Size(104, 224)
        Me.ListDirección.TabIndex = 17
        '
        'ListPlazo
        '
        Me.ListPlazo.FormattingEnabled = True
        Me.ListPlazo.ItemHeight = 20
        Me.ListPlazo.Location = New System.Drawing.Point(349, 387)
        Me.ListPlazo.Name = "ListPlazo"
        Me.ListPlazo.Size = New System.Drawing.Size(108, 224)
        Me.ListPlazo.TabIndex = 18
        '
        'ListAparato
        '
        Me.ListAparato.FormattingEnabled = True
        Me.ListAparato.ItemHeight = 20
        Me.ListAparato.Location = New System.Drawing.Point(463, 387)
        Me.ListAparato.Name = "ListAparato"
        Me.ListAparato.Size = New System.Drawing.Size(103, 224)
        Me.ListAparato.TabIndex = 19
        '
        'checkBoxTV
        '
        Me.checkBoxTV.AutoSize = True
        Me.checkBoxTV.Location = New System.Drawing.Point(540, 163)
        Me.checkBoxTV.Name = "checkBoxTV"
        Me.checkBoxTV.Size = New System.Drawing.Size(44, 24)
        Me.checkBoxTV.TabIndex = 20
        Me.checkBoxTV.Text = "TV"
        Me.checkBoxTV.UseVisualStyleBackColor = True
        '
        'CheckBoxTelefono
        '
        Me.CheckBoxTelefono.AutoSize = True
        Me.CheckBoxTelefono.Location = New System.Drawing.Point(540, 193)
        Me.CheckBoxTelefono.Name = "CheckBoxTelefono"
        Me.CheckBoxTelefono.Size = New System.Drawing.Size(90, 24)
        Me.CheckBoxTelefono.TabIndex = 21
        Me.CheckBoxTelefono.Text = "Telefono"
        Me.CheckBoxTelefono.UseVisualStyleBackColor = True
        '
        'CheckBoxLaptop
        '
        Me.CheckBoxLaptop.AutoSize = True
        Me.CheckBoxLaptop.Location = New System.Drawing.Point(540, 236)
        Me.CheckBoxLaptop.Name = "CheckBoxLaptop"
        Me.CheckBoxLaptop.Size = New System.Drawing.Size(80, 24)
        Me.CheckBoxLaptop.TabIndex = 22
        Me.CheckBoxLaptop.Text = "Laptop"
        Me.CheckBoxLaptop.UseVisualStyleBackColor = True
        '
        'txtCostoTV
        '
        Me.txtCostoTV.Location = New System.Drawing.Point(319, 152)
        Me.txtCostoTV.Name = "txtCostoTV"
        Me.txtCostoTV.Size = New System.Drawing.Size(121, 26)
        Me.txtCostoTV.TabIndex = 24
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(160, 201)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(118, 20)
        Me.label.TabIndex = 23
        Me.label.Text = "Costo Telefono"
        '
        'checkBoxRefri
        '
        Me.checkBoxRefri.AutoSize = True
        Me.checkBoxRefri.Location = New System.Drawing.Point(540, 275)
        Me.checkBoxRefri.Name = "checkBoxRefri"
        Me.checkBoxRefri.Size = New System.Drawing.Size(130, 24)
        Me.checkBoxRefri.TabIndex = 25
        Me.checkBoxRefri.Text = "Refrigeradora"
        Me.checkBoxRefri.UseVisualStyleBackColor = True
        '
        'txtCostoTelefono
        '
        Me.txtCostoTelefono.Location = New System.Drawing.Point(319, 195)
        Me.txtCostoTelefono.Name = "txtCostoTelefono"
        Me.txtCostoTelefono.Size = New System.Drawing.Size(121, 26)
        Me.txtCostoTelefono.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Costo TV"
        '
        'txtCostoLaptop
        '
        Me.txtCostoLaptop.Location = New System.Drawing.Point(319, 242)
        Me.txtCostoLaptop.Name = "txtCostoLaptop"
        Me.txtCostoLaptop.Size = New System.Drawing.Size(121, 26)
        Me.txtCostoLaptop.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Costo Laptop"
        '
        'txtCostoRefri
        '
        Me.txtCostoRefri.Location = New System.Drawing.Point(319, 287)
        Me.txtCostoRefri.Name = "txtCostoRefri"
        Me.txtCostoRefri.Size = New System.Drawing.Size(121, 26)
        Me.txtCostoRefri.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Costo Refrigeradora"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1010, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.LimpiarListBoxToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'LimpiarListBoxToolStripMenuItem
        '
        Me.LimpiarListBoxToolStripMenuItem.Name = "LimpiarListBoxToolStripMenuItem"
        Me.LimpiarListBoxToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LimpiarListBoxToolStripMenuItem.Text = "Limpiar ListBox"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListDescuentos
        '
        Me.ListDescuentos.FormattingEnabled = True
        Me.ListDescuentos.ItemHeight = 20
        Me.ListDescuentos.Location = New System.Drawing.Point(681, 387)
        Me.ListDescuentos.Name = "ListDescuentos"
        Me.ListDescuentos.Size = New System.Drawing.Size(103, 224)
        Me.ListDescuentos.TabIndex = 33
        '
        'ListCosto
        '
        Me.ListCosto.FormattingEnabled = True
        Me.ListCosto.ItemHeight = 20
        Me.ListCosto.Location = New System.Drawing.Point(572, 387)
        Me.ListCosto.Name = "ListCosto"
        Me.ListCosto.Size = New System.Drawing.Size(103, 224)
        Me.ListCosto.TabIndex = 34
        '
        'ListPagoParcial
        '
        Me.ListPagoParcial.FormattingEnabled = True
        Me.ListPagoParcial.ItemHeight = 20
        Me.ListPagoParcial.Location = New System.Drawing.Point(790, 387)
        Me.ListPagoParcial.Name = "ListPagoParcial"
        Me.ListPagoParcial.Size = New System.Drawing.Size(103, 224)
        Me.ListPagoParcial.TabIndex = 35
        '
        'ListPagoFinal
        '
        Me.ListPagoFinal.FormattingEnabled = True
        Me.ListPagoFinal.ItemHeight = 20
        Me.ListPagoFinal.Location = New System.Drawing.Point(899, 387)
        Me.ListPagoFinal.Name = "ListPagoFinal"
        Me.ListPagoFinal.Size = New System.Drawing.Size(103, 224)
        Me.ListPagoFinal.TabIndex = 36
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(39, 352)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(68, 20)
        Me.Nombre.TabIndex = 37
        Me.Nombre.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(140, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "CUI"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(262, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Dirección"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(375, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 20)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Plazo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(477, 352)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 20)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Aparato"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(594, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 20)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Costo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(681, 352)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 20)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Descuento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(790, 352)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 20)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Pago Parcial"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(910, 352)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 20)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Pago Final"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1010, 643)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.ListPagoFinal)
        Me.Controls.Add(Me.ListPagoParcial)
        Me.Controls.Add(Me.ListCosto)
        Me.Controls.Add(Me.ListDescuentos)
        Me.Controls.Add(Me.txtCostoRefri)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCostoLaptop)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCostoTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.checkBoxRefri)
        Me.Controls.Add(Me.txtCostoTV)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.CheckBoxLaptop)
        Me.Controls.Add(Me.CheckBoxTelefono)
        Me.Controls.Add(Me.checkBoxTV)
        Me.Controls.Add(Me.ListAparato)
        Me.Controls.Add(Me.ListPlazo)
        Me.Controls.Add(Me.ListDirección)
        Me.Controls.Add(Me.ListCUI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCUI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListNombre)
        Me.Controls.Add(Me.tipopago)
        Me.Controls.Add(Me.comboTipoPlazo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "EMPEÑO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents comboTipoPlazo As ComboBox
    Friend WithEvents tipopago As Label
    Friend WithEvents ListNombre As ListBox
    Friend WithEvents txtCUI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListCUI As ListBox
    Friend WithEvents ListDirección As ListBox
    Friend WithEvents ListPlazo As ListBox
    Friend WithEvents ListAparato As ListBox
    Friend WithEvents checkBoxTV As CheckBox
    Friend WithEvents CheckBoxTelefono As CheckBox
    Friend WithEvents CheckBoxLaptop As CheckBox
    Friend WithEvents txtCostoTV As TextBox
    Friend WithEvents label As Label
    Friend WithEvents checkBoxRefri As CheckBox
    Friend WithEvents txtCostoTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCostoLaptop As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCostoRefri As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListDescuentos As ListBox
    Friend WithEvents ListCosto As ListBox
    Friend WithEvents ListPagoParcial As ListBox
    Friend WithEvents ListPagoFinal As ListBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
