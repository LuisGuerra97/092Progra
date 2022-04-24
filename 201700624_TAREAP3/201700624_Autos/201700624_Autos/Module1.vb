Module Module1


    Public NumeroPlaca(7) As Integer
    Public TipoCarro(7) As String
    Public KmInicial(7) As Integer
    Public KmFinal(7) As Integer
    Public PagoFinal(7) As Integer
    Public CobroBase(7) As Integer



    Public fila As Byte = 0
    Public I As Byte

    Sub Limpiar()
        Form1.txtConsulta.Clear()
        Form1.txtKmFinal.Clear()
        Form1.txtKmInicial.Clear()
        Form1.txtNumPlaca.Clear()
        Form1.ComboTipoCarro.Text = ""
        Form1.KmIniDato = 0
        Form1.KmFinaDato = 0
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

            If (NumeroPlaca(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(NumeroPlaca(I)), TipoCarro(I), Str(KmInicial(I)), Str(KmFinal(I)), Str(PagoFinal(I)), CobroBase(I))
            Else

                Exit For
            End If
        Next I

    End Sub

    Sub LimpiarVectores()
        Form1.DataGridView1.Rows.Clear()
        fila = 0

        For I = 0 To 6
            NumeroPlaca(I) = Nothing
            TipoCarro(I) = Nothing
            KmFinal(I) = Nothing
            KmInicial(I) = Nothing
            PagoFinal(I) = Nothing
            CobroBase(I) = Nothing
        Next I

        MsgBox("Vectores limpiados existosamente")

    End Sub



End Module
