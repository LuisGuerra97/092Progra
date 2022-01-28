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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtFrijol = New System.Windows.Forms.TextBox()
        Me.TxtAzucar = New System.Windows.Forms.TextBox()
        Me.TxtArroz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelDescuento = New System.Windows.Forms.Label()
        Me.LabelPagoConIVA = New System.Windows.Forms.Label()
        Me.LabelValorIVA = New System.Windows.Forms.Label()
        Me.LabelPagoSinIva = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtFrijol)
        Me.GroupBox1.Controls.Add(Me.TxtAzucar)
        Me.GroupBox1.Controls.Add(Me.TxtArroz)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Ingreso"
        '
        'TxtFrijol
        '
        Me.TxtFrijol.Location = New System.Drawing.Point(135, 69)
        Me.TxtFrijol.Name = "TxtFrijol"
        Me.TxtFrijol.Size = New System.Drawing.Size(114, 23)
        Me.TxtFrijol.TabIndex = 5
        Me.TxtFrijol.Text = "0"
        '
        'TxtAzucar
        '
        Me.TxtAzucar.Location = New System.Drawing.Point(135, 105)
        Me.TxtAzucar.Name = "TxtAzucar"
        Me.TxtAzucar.Size = New System.Drawing.Size(114, 23)
        Me.TxtAzucar.TabIndex = 4
        Me.TxtAzucar.Text = "0"
        '
        'TxtArroz
        '
        Me.TxtArroz.Location = New System.Drawing.Point(135, 32)
        Me.TxtArroz.Name = "TxtArroz"
        Me.TxtArroz.Size = New System.Drawing.Size(114, 23)
        Me.TxtArroz.TabIndex = 3
        Me.TxtArroz.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libras de Azucar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libras de Frijol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libras de Arroz"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelDescuento)
        Me.GroupBox2.Controls.Add(Me.LabelPagoConIVA)
        Me.GroupBox2.Controls.Add(Me.LabelValorIVA)
        Me.GroupBox2.Controls.Add(Me.LabelPagoSinIva)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'LabelDescuento
        '
        Me.LabelDescuento.AutoSize = True
        Me.LabelDescuento.Location = New System.Drawing.Point(157, 150)
        Me.LabelDescuento.Name = "LabelDescuento"
        Me.LabelDescuento.Size = New System.Drawing.Size(33, 17)
        Me.LabelDescuento.TabIndex = 22
        Me.LabelDescuento.Text = "0.00"
        '
        'LabelPagoConIVA
        '
        Me.LabelPagoConIVA.AutoSize = True
        Me.LabelPagoConIVA.Location = New System.Drawing.Point(157, 109)
        Me.LabelPagoConIVA.Name = "LabelPagoConIVA"
        Me.LabelPagoConIVA.Size = New System.Drawing.Size(33, 17)
        Me.LabelPagoConIVA.TabIndex = 21
        Me.LabelPagoConIVA.Text = "0.00"
        '
        'LabelValorIVA
        '
        Me.LabelValorIVA.AutoSize = True
        Me.LabelValorIVA.Location = New System.Drawing.Point(157, 68)
        Me.LabelValorIVA.Name = "LabelValorIVA"
        Me.LabelValorIVA.Size = New System.Drawing.Size(33, 17)
        Me.LabelValorIVA.TabIndex = 20
        Me.LabelValorIVA.Text = "0.00"
        '
        'LabelPagoSinIva
        '
        Me.LabelPagoSinIva.AutoSize = True
        Me.LabelPagoSinIva.Location = New System.Drawing.Point(157, 31)
        Me.LabelPagoSinIva.Name = "LabelPagoSinIva"
        Me.LabelPagoSinIva.Size = New System.Drawing.Size(33, 17)
        Me.LabelPagoSinIva.TabIndex = 19
        Me.LabelPagoSinIva.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Pago Con IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Valor del IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Pago Sin IVA"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(335, 114)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(106, 52)
        Me.ButtonAceptar.TabIndex = 2
        Me.ButtonAceptar.Text = "ACEPTAR"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(335, 246)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(106, 50)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(335, 178)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(106, 52)
        Me.ButtonLimpiar.TabIndex = 4
        Me.ButtonLimpiar.Text = "LIMPIAR"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(506, 453)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFrijol As TextBox
    Friend WithEvents TxtAzucar As TextBox
    Friend WithEvents TxtArroz As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelPagoSinIva As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents LabelDescuento As Label
    Friend WithEvents LabelPagoConIVA As Label
    Friend WithEvents LabelValorIVA As Label
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonLimpiar As Button
End Class
