Module Module1

    Public NumIDcliente(7) As Integer
    Public TipoViaje(7) As String
    Public NumDias(7) As Integer
    Public NumPersonas(7) As Integer
    Public TotalPago(7) As String

    Public fila As Byte = 0
    Public I As Byte

    Sub Limpiar()
        Form1.txtDiasReserva.Clear()
        Form1.txtIDcliente.Clear()
        Form1.txtPersonas.Clear()
        Form1.comboTipoViaje.Text = ""
        Form1.txtConsulta.Clear()
    End Sub

    Sub Salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            Limpiar()
        End If
    End Sub

    Sub MostrarVectores()
        Form1.DataGridView1.Rows.Clear()

        For I = 0 To 6

            If (NumIDcliente(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(NumIDcliente(I)), TipoViaje(I), Str(NumDias(I)), Str(NumPersonas(I)), (TotalPago(I)))
            Else
                Exit For
            End If
        Next I

    End Sub

    Sub LimpiarVectores()
        Form1.DataGridView1.Rows.Clear()
        fila = 0

        For I = 0 To 6
            NumIDcliente(I) = Nothing
            TipoViaje(I) = Nothing
            NumDias(I) = Nothing
            NumPersonas(I) = Nothing
            TotalPago(I) = Nothing
        Next I

        MsgBox("Vectores limpiados existosamente")
    End Sub


End Module
