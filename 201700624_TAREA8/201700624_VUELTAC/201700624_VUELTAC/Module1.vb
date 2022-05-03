Module Module1

    Public numEtapa(12) As Integer
    Public Equipo(12) As String
    Public kmRecorrido(12) As Integer
    Public Tiempo(12) As Integer
    Public Nacionalidad(12) As String
    Public Penalizacion(12) As Integer

    Public fila As Byte = 0

    Public Const N = 3

    Public I As Byte


    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
        End If
    End Sub


    Sub limpiar_entradas()
        Form1.txtConsultar.Clear()
        Form1.txtKm45.Clear()
        Form1.txtKmEquipo.Clear()
        Form1.txtNumEtapa.Clear()
        Form1.txtTiempo.Clear()
        Form1.comboEquipo.Text = ""
        Form1.comboNac.Text = ""
    End Sub

    Sub Mostrar_vectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 11

            If (numEtapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(numEtapa(I)), Equipo(I), Str(kmRecorrido(I)), Str(Tiempo(I)), Nacionalidad(I), Str(Penalizacion(I)))
            Else

                Exit For
            End If
        Next I
    End Sub

    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        fila = 0

        For I = 0 To 4

            numEtapa(I) = Nothing
            kmRecorrido(I) = Nothing
            Equipo(I) = Nothing
            Tiempo(I) = Nothing
            Nacionalidad(I) = Nothing
            Penalizacion(I) = Nothing
        Next I

    End Sub



End Module
