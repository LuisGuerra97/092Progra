Public Class Form1

    Const PrecioIngles As Integer = 150
    Const PrecioPortugues As Integer = 80
    Const PrecioFrances As Integer = 125

    Public PagoFinal = 0

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        DataGridView1.Rows.Clear()
        LimpiarEntradas()
        INDICE = 0
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        If (comboFormaPago.Text = "" Or ComboIdioma.Text = "" Or (CheckBoxSabado.Checked = False And CheckBoxViernes.Checked = False) Or txtCantidadHoras.Text = "" Or txtCarnet.Text = "" Or txtNombre.Text = "") Then
            MsgBox("Por favor ingrese todos los datos requeridos", 0, "ERROR")

        ElseIf (INDICE <= 8) Then

            matriz(0, INDICE) = Val(txtCarnet.Text)
            matriz(1, INDICE) = txtNombre.Text
            matriz(2, INDICE) = ComboIdioma.Text
            matriz(3, INDICE) = Format(DTpicker.Value, "dd/MMMM/yyyy")

            If (CheckBoxSabado.Checked = True) Then
                matriz(4, INDICE) = "Sábado"
            ElseIf (CheckBoxViernes.Checked = True) Then
                matriz(4, INDICE) = "Viernes"
            End If

            matriz(5, INDICE) = Val(txtCantidadHoras.Text)
            matriz(6, INDICE) = comboFormaPago.Text

            If ComboIdioma.Text = "Francés" Then
                matriz(7, INDICE) = "Q " & Math.Round(Val(txtCantidadHoras.Text) * PrecioFrances, 2)
            ElseIf (ComboIdioma.Text = "Inglés") Then
                matriz(7, INDICE) = "Q " & Math.Round(Val(txtCantidadHoras.Text) * PrecioIngles, 2)
            ElseIf (ComboIdioma.Text = "Portugués") Then
                matriz(7, INDICE) = "Q " & Math.Round(Val(txtCantidadHoras.Text) * PrecioPortugues, 2)
            End If

            If comboFormaPago.Text = "Efectivo" And ComboIdioma.Text = "Portugués" Then
                matriz(8, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioPortugues) * 0.02, 2)
            ElseIf comboFormaPago.Text = "Efectivo" And ComboIdioma.Text = "Inglés" Then
                matriz(8, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioIngles) * 0.02, 2)
            ElseIf comboFormaPago.Text = "Efectivo" And ComboIdioma.Text = "Francés" Then
                matriz(8, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioFrances) * 0.02, 2)
            ElseIf comboFormaPago.Text = "Cheque" And ComboIdioma.Text = "Portugués" Then
                matriz(8, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioPortugues) * 0.015, 2)
            ElseIf comboFormaPago.Text = "Cheque" And ComboIdioma.Text = "Inglés" Then
                matriz(8, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioIngles) * 0.015, 2)

            ElseIf comboFormaPago.Text = "Cheque" And ComboIdioma.Text = "Francés" Then
                matriz(8, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioFrances) * 0.015, 2)
            End If

            If CheckBoxSabado.Checked = True And CheckBoxViernes.Checked = True And ComboIdioma.Text = "Portugués" Then
                matriz(9, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioPortugues) * 0.05, 2)
            ElseIf CheckBoxSabado.Checked = True And CheckBoxViernes.Checked = True And ComboIdioma.Text = "Francés" Then
                matriz(9, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioFrances) * 0.05, 2)
            ElseIf CheckBoxSabado.Checked = True And CheckBoxViernes.Checked = True And ComboIdioma.Text = "Inglés" Then
                matriz(9, INDICE) = "Q " & Math.Round((Val(txtCantidadHoras.Text) * PrecioIngles) * 0.05, 2)
            Else
                matriz(9, INDICE) = "No Aplica"
            End If

            If matriz(9, INDICE) = "No Aplica" Then
                matriz(10, INDICE) = "Q " & Math.Round(matriz(7, INDICE) - matriz(8, INDICE), 2)
            Else
                matriz(10, INDICE) = "Q " & Math.Round(matriz(7, INDICE) - matriz(8, INDICE) - matriz(9, INDICE), 2)
            End If

            DataGridView1.Rows.Add(matriz(0, INDICE), matriz(1, INDICE), matriz(2, INDICE), matriz(3, INDICE), matriz(4, INDICE), matriz(5, INDICE), matriz(6, INDICE), matriz(7, INDICE), matriz(8, INDICE), matriz(9, INDICE), matriz(10, INDICE))
            INDICE = INDICE + 1
        End If

        If (INDICE = 8) Then
            MsgBox("VECTORES LLENOS", 0, "ERROR")
        End If
        LimpiarEntradas()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            End
        End If
    End Sub

    Private Sub txtCarnet_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtCarnet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCantidadHoras_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtCantidadHoras.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
