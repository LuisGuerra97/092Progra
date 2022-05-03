Public Class Form1
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        If (fila <= 11) Then
            numEtapa(fila) = Val(txtNumEtapa.Text)
            Tiempo(fila) = txtTiempo.Text
            Equipo(fila) = comboEquipo.Text
            Nacionalidad(fila) = comboNac.Text
            kmRecorrido(fila) = Val(txtKmRecorridos.Text)

            If "120" < txtTiempo.Text And txtTiempo.Text < "140" Then

                Penalizacion(fila) = 30
            ElseIf "140" < txtTiempo.Text And txtTiempo.Text < "160" Then
                Penalizacion(fila) = 40

            ElseIf txtTiempo.Text > "160" Then
                Penalizacion(fila) = 50
            ElseIf txtTiempo.Text < "85" And comboEquipo.Text = "Movistar" Then
                Penalizacion(fila) = -15
            ElseIf txtTiempo.Text < "85" And comboEquipo.Text = "Pro Team" Then
                Penalizacion(fila) = -10
            Else
                Penalizacion(fila) = 0

            End If

            fila = fila + 1


            limpiar_entradas()
        End If
        If (fila = 12) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_vectores()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 11) And Not (existe)

            If (numEtapa(I) = Val(txtConsultar.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            txtNumEtapa.Text = Str(numEtapa(I))
            comboEquipo.Text = Equipo(I)
            txtKmRecorridos.Text = Str(kmRecorrido(I))
            txtTiempo.Text = Str(Tiempo(I))
            comboNac.Text = Nacionalidad(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(numEtapa(I)), Equipo(I), Str(kmRecorrido(I)), Str(Tiempo(I)), Nacionalidad(I), Str(Penalizacion(I)))
            fila = I
        Else
            MsgBox("Carnet no encontrado")
            txtNumEtapa.Focus()
        End If


    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        numEtapa(fila) = Val(txtNumEtapa.Text)
        Equipo(fila) = comboEquipo.Text
        Nacionalidad(fila) = comboNac.Text
        kmRecorrido(fila) = Val(txtKmRecorridos.Text)
        Tiempo(fila) = Val(txtTiempo.Text)
        MsgBox("Registro actualizado correctamente en los vectores")
        fila = 12
    End Sub

End Class
