Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        PCOCalculos()
        If (Indice <= 7) Then

            NumeroVenta(Indice) = Val(txtNumeroVenta.Text)
            PMO(Indice) = "Q " & Module1.PMODato
            PrecioCosto(Indice) = "Q " & Math.Round(Module1.PCODato, 2)
            PrecioVenta(Indice) = "Q " & Math.Round(Module1.PMODato + Module1.PCODato * 1.65, 2)
            Tamaño(Indice) = comboTamaño.Text
            Tipo(Indice) = comboTela.Text

            If (comboTamaño.Text = "Sofá") Then
                CantYardas(Indice) = CantSofa
            ElseIf (comboTamaño.Text = "Individual") Then
                CantYardas(Indice) = CantIndividual
            ElseIf (comboTamaño.Text = "Doble") Then
                CantYardas(Indice) = CantDoble
            End If

            mostrarDatos()

            Indice = Indice + 1

        End If

        If (Indice = 8) Then
            MsgBox("Vectores Llenos")

        End If
        Limpiar()

    End Sub

    Sub mostrarDatos()
        DataGridView1.Rows.Add(Str(NumeroVenta(Indice)), Str(PMO(Indice)), Str(PrecioCosto(Indice)), Str(PrecioVenta(Indice)), (Tamaño(Indice)), (Tipo(Indice)), Str(CantYardas(Indice)))
    End Sub

    Private Sub btnLimpiarGrid_Click(sender As Object, e As EventArgs) Handles btnLimpiarGrid.Click
        DataGridView1.Rows.Clear()
        Indice = 0
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes) Then
            End
        End If
    End Sub

    Private Sub btnLimpiarVect_Click(sender As Object, e As EventArgs) Handles btnLimpiarVect.Click
        MsgBox("Se han limpiado los vectores")
        Indice = 0
    End Sub
End Class
