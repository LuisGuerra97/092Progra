Public Class Form1

    Public Const precioLagunaBrava As Integer = 440
    Public Const precioMirador As Integer = 1190
    Public Const precioBiotopo As Integer = 255

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (fila <= 6) Then

            NumIDcliente(fila) = Val(txtIDcliente.Text)
            TipoViaje(fila) = comboTipoViaje.Text
            NumDias(fila) = Val(txtDiasReserva.Text)
            NumPersonas(fila) = Val(txtPersonas.Text)

            If (comboTipoViaje.Text = "Biotopo del Quetzal") Then
                TotalPago(fila) = "Q " & Math.Round(Val(precioBiotopo * txtPersonas.Text * txtDiasReserva.Text), 2)
            ElseIf (comboTipoViaje.Text = "Mirador") Then
                TotalPago(fila) = "Q " & Math.Round(Val(precioMirador * txtPersonas.Text * txtDiasReserva.Text), 2)
            ElseIf (comboTipoViaje.Text = "Laguna Brava") Then
                TotalPago(fila) = "Q " & Math.Round(Val(precioLagunaBrava * txtPersonas.Text * txtDiasReserva.Text), 2)
            End If

            fila = fila + 1
            Limpiar()
        End If
        If (fila = 7) Then
            MsgBox("Vectores llenos")
        End If


    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MostrarVectores()
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0

        While (I <= 6) And Not (existe)

            If (NumIDcliente(I) = Val(txtConsulta.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Cliente Encontrado exitosamente")

            txtIDcliente.Text = Str(NumIDcliente(I))
            comboTipoViaje.Text = TipoViaje(I)
            txtPersonas.Text = Str(NumPersonas(I))
            txtDiasReserva.Text = Str(NumDias(I))

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(NumIDcliente(I)), TipoViaje(I), Str(NumDias(I)), Str(NumPersonas(I)), Str(TotalPago(I)))

            fila = I
        Else
            MsgBox("Número de cliente no encontrado")
            txtIDcliente.Focus()
        End If

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LimpiarVectores()
        Limpiar()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click

        NumIDcliente(fila) = Nothing
        TipoViaje(fila) = Nothing
        NumPersonas(fila) = Nothing
        NumDias(fila) = Nothing
        TotalPago(fila) = Nothing



        For I = fila To 5

            NumIDcliente(I) = NumIDcliente(I + 1)
            TipoViaje(I) = TipoViaje(I + 1)
            NumPersonas(I) = NumPersonas(I + 1)
            NumDias(I) = NumDias(I + 1)
            TotalPago(I) = TotalPago(I + 1)



        Next I
        MsgBox("Cliente Eliminado exitosamente")

        NumIDcliente(I) = Nothing
        TipoViaje(I) = Nothing
        NumPersonas(I) = Nothing
        NumDias(I) = Nothing
        TotalPago(I) = Nothing

        fila = I
        Limpiar()
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub txtIDcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDcliente.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDiasReserva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiasReserva.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPersonas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPersonas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtConsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConsulta.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
