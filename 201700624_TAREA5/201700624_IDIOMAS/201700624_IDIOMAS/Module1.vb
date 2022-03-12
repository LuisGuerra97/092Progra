Module Module1
    'Columnas,Filas
    Public matriz(10, 7)
    Public INDICE As Byte = 0

    Public Intento As Byte = 1

    Sub LimpiarEntradas()
        Form1.txtCantidadHoras.Clear()
        Form1.txtCarnet.Clear()
        Form1.txtNombre.Clear()
        Form1.comboFormaPago.Text = ""
        Form1.ComboIdioma.Text = ""
        Form1.CheckBoxSabado.Checked = False
        Form1.CheckBoxViernes.Checked = False
    End Sub

End Module
