Public Class Form1


    Const CortoPlazoTv As Integer = 250
    Const LargoPlazoTv As Integer = 300

    Const CortoPlazoTelefono As Integer = 550
    Const LargoPlazoTelefono As Integer = 600

    Const CortoPlazoLaptop As Integer = 770
    Const LargoPlazoLaptop As Integer = 800

    Const CortoPlazoRefri As Integer = 1000
    Const LargoPlazoRefri As Integer = 1200



    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click


        If (Indice <= 6) Then
            matriz(0, Indice) = ListNombre.Items.Add(txtNombre.Text)
            matriz(1, Indice) = ListCUI.Items.Add(txtCUI.Text)
            matriz(2, Indice) = ListDirección.Items.Add(txtDireccion.Text)
            matriz(3, Indice) = ListPlazo.Items.Add(comboTipoPlazo.Text)
            matriz(4, Indice) = ListCosto.Items.Add("Q " & txtCostoTV.Text)


            If (checkBoxTV.Checked) Then
                ListAparato.Items.Add("TV")
            ElseIf (CheckBoxLaptop.Checked) Then
                ListAparato.Items.Add("Laptop")
            ElseIf (CheckBoxTelefono.Checked) Then
                ListAparato.Items.Add("Telefono")
            ElseIf (checkBoxRefri.Checked) Then
                ListAparato.Items.Add("Refrigeradora")
            End If


            If (checkBoxTV.Checked And comboTipoPlazo.Text = "Corto") Then
                ListPagoParcial.Items.Add("Q " & CortoPlazoTv)
                ListPagoFinal.Items.Add("Q " & CortoPlazoTv)
            ElseIf (checkBoxTV.Checked And comboTipoPlazo.Text = "Largo") Then
                ListPagoParcial.Items.Add("Q " & LargoPlazoTv)
                ListPagoFinal.Items.Add("Q " & LargoPlazoTv)
            ElseIf (CheckBoxLaptop.Checked And comboTipoPlazo.Text = "Corto") Then
                ListPagoParcial.Items.Add("Q " & CortoPlazoLaptop)
                ListPagoFinal.Items.Add("Q " & CortoPlazoLaptop)
            ElseIf (CheckBoxLaptop.Checked And comboTipoPlazo.Text = "Largo") Then
                ListPagoParcial.Items.Add("Q " & LargoPlazoLaptop)
                ListPagoFinal.Items.Add("Q " & LargoPlazoLaptop)
            ElseIf (CheckBoxTelefono.Checked And comboTipoPlazo.Text = "Corto") Then
                ListPagoParcial.Items.Add("Q " & CortoPlazoTelefono)
                ListPagoFinal.Items.Add("Q " & CortoPlazoTelefono)
            ElseIf (CheckBoxTelefono.Checked And comboTipoPlazo.Text = "Largo") Then
                ListPagoParcial.Items.Add("Q " & LargoPlazoTelefono)
                ListPagoFinal.Items.Add("Q " & LargoPlazoTelefono)
            ElseIf (checkBoxRefri.Checked And comboTipoPlazo.Text = "Corto") Then
                ListPagoParcial.Items.Add("Q " & CortoPlazoRefri)
                ListPagoFinal.Items.Add("Q " & CortoPlazoRefri)
            ElseIf (checkBoxRefri.Checked And comboTipoPlazo.Text = "Largo") Then
                ListPagoParcial.Items.Add("Q " & LargoPlazoRefri)
                ListPagoFinal.Items.Add("Q " & LargoPlazoRefri)
            End If


            If (checkBoxTV.Checked And checkBoxRefri.Checked And comboTipoPlazo.Text = "Corto") Then
                ListPagoParcial.Items.Add(("Q " & CortoPlazoTv + CortoPlazoRefri) * 1.15)

                ListDescuentos.Items.Add(("Q " & CortoPlazoTv + CortoPlazoRefri) * 0.15)

            ElseIf (checkBoxTV.Checked And comboTipoPlazo.Text = "Largo" And checkBoxRefri.Checked) Then
                ListPagoParcial.Items.Add(("Q " & LargoPlazoTv + LargoPlazoRefri) * 1.05)

                ListDescuentos.Items.Add(("Q " & CortoPlazoTv + CortoPlazoRefri) * 0.05)
            ElseIf (CheckBoxTelefono.Checked And comboTipoPlazo.Text = "Corto" And CheckBoxLaptop.Checked) Then
                ListPagoParcial.Items.Add(("Q " & CortoPlazoTelefono + CortoPlazoLaptop) * 1.05)

                ListDescuentos.Items.Add(("Q " & CortoPlazoTelefono + CortoPlazoLaptop) * 0.05)
            ElseIf (CheckBoxTelefono.Checked And comboTipoPlazo.Text = "Largo" And CheckBoxLaptop.Checked) Then
                ListPagoParcial.Items.Add(("Q " & LargoPlazoTelefono + LargoPlazoLaptop) * 1.1)

                ListDescuentos.Items.Add(("Q " & LargoPlazoTelefono + LargoPlazoLaptop) * 0.1)
            Else
                ListDescuentos.Items.Add("No aplica")
            End If

        End If
        If (Indice = 6) Then
            MsgBox("VECTORES LLENOS", 0, "ERROR")
        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            End
        End If
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click

    End Sub

    Private Sub LimpiarListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListBoxToolStripMenuItem.Click
        ListAparato.Items.Clear()
        ListCosto.Items.Clear()
        ListNombre.Items.Clear()
        ListDescuentos.Items.Clear()
        ListDirección.Items.Clear()
        ListPagoParcial.Items.Clear()
        ListPagoFinal.Items.Clear()
        ListPlazo.Items.Clear()
        ListCUI.Items.Clear()
        txtCostoLaptop.Clear()
        txtCUI.Clear()
        txtDireccion.Clear()
        txtNombre.Clear()
        txtCostoRefri.Clear()
        txtCostoTelefono.Clear()
        txtCostoTV.Clear()
        checkBoxRefri.Checked = False
        CheckBoxLaptop.Checked = False
        checkBoxTV.Checked = False
        CheckBoxTelefono.Checked = False



    End Sub
End Class
