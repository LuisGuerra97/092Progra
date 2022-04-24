Public Class Form1

    Public KmIniDato As Integer = 0
    Public KmFinaDato As Integer = 0

    Const PrecioTipo1 As Integer = 500
    Const PrecioTipo2 As Integer = 400
    Const PrecioTipo3 As Integer = 300
    Const PrecioTipo4 As Integer = 200

    Const PrecioKm0a50 As Integer = 3
    Const PrecioKm51a70 As Integer = 4
    Const PrecioKm70 As Integer = 5

    Public DatoPago As Integer = 0
    Public DatoCobro As Integer = 0
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (fila <= 6) Then
            NumeroPlaca(fila) = Val(txtNumPlaca.Text)
            TipoCarro(fila) = ComboTipoCarro.Text
            KmInicial(fila) = Val(txtKmInicial.Text)
            KmFinal(fila) = Val(txtKmFinal.Text)

            If (ComboTipoCarro.Text = "Tipo 1") Then
                CobroBase(fila) = PrecioTipo1
            ElseIf (ComboTipoCarro.Text = "Tipo 2") Then
                CobroBase(fila) = PrecioTipo2
            ElseIf (ComboTipoCarro.Text = "Tipo 3") Then
                CobroBase(fila) = PrecioTipo3
            ElseIf (ComboTipoCarro.Text = "Tipo 4") Then
                CobroBase(fila) = PrecioTipo4
            End If

            DatoCobro = CobroBase(fila)

            If ("0" <= txtKmFinal.Text - txtKmInicial.Text <= "50" And ComboTipoCarro.Text = "Tipo 1") Then
                PagoFinal(fila) = PrecioTipo1 + (PrecioKm0a50 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("51" <= txtKmFinal.Text - txtKmInicial.Text <= "70" And ComboTipoCarro.Text = "Tipo 1") Then
                PagoFinal(fila) = PrecioTipo1 + (PrecioKm51a70 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("70" <= txtKmFinal.Text - txtKmInicial.Text And ComboTipoCarro.Text = "Tipo 1") Then
                PagoFinal(fila) = PrecioTipo1 + (PrecioKm70 * (txtKmFinal.Text - txtKmInicial.Text))


            ElseIf ("0" <= txtKmFinal.Text - txtKmInicial.Text <= "50" And ComboTipoCarro.Text = "Tipo 2") Then
                PagoFinal(fila) = PrecioTipo2 + (PrecioKm0a50 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("51" <= txtKmFinal.Text - txtKmInicial.Text <= "70" And ComboTipoCarro.Text = "Tipo 2") Then
                PagoFinal(fila) = PrecioTipo2 + (PrecioKm51a70 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("70" <= txtKmFinal.Text - txtKmInicial.Text And ComboTipoCarro.Text = "Tipo 2") Then
                PagoFinal(fila) = PrecioTipo2 + (PrecioKm70 * (txtKmFinal.Text - txtKmInicial.Text))


            ElseIf ("0" <= txtKmFinal.Text - txtKmInicial.Text <= "50" And ComboTipoCarro.Text = "Tipo 3") Then
                PagoFinal(fila) = PrecioTipo3 + (PrecioKm0a50 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("51" <= txtKmFinal.Text - txtKmInicial.Text <= "70" And ComboTipoCarro.Text = "Tipo 3") Then
                PagoFinal(fila) = PrecioTipo3 + (PrecioKm51a70 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("70" <= txtKmFinal.Text - txtKmInicial.Text And ComboTipoCarro.Text = "Tipo 3") Then
                PagoFinal(fila) = PrecioTipo3 + (PrecioKm70 * (txtKmFinal.Text - txtKmInicial.Text))


            ElseIf ("0" <= txtKmFinal.Text - txtKmInicial.Text <= "50" And ComboTipoCarro.Text = "Tipo 4") Then
                PagoFinal(fila) = PrecioTipo4 + (PrecioKm0a50 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("51" <= txtKmFinal.Text - txtKmInicial.Text <= "70" And ComboTipoCarro.Text = "Tipo 4") Then
                PagoFinal(fila) = PrecioTipo4 + (PrecioKm51a70 * (txtKmFinal.Text - txtKmInicial.Text))
            ElseIf ("70" <= txtKmFinal.Text - txtKmInicial.Text And ComboTipoCarro.Text = "Tipo 4") Then
                PagoFinal(fila) = PrecioTipo4 + (PrecioKm70 * (txtKmFinal.Text - txtKmInicial.Text))
            End If

            DatoPago = PagoFinal(fila)

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

            If (NumeroPlaca(I) = Val(txtConsulta.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While


        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            txtNumPlaca.Text = Str(NumeroPlaca(I))
            ComboTipoCarro.Text = TipoCarro(I)
            ComboTipoCarro.Text = TipoCarro(I)
            txtKmInicial.Text = Str(KmInicial(I))
            txtKmFinal.Text = Str(KmFinal(I))

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(NumeroPlaca(I)), TipoCarro(I), Str(KmInicial(I)), Str(KmFinal(I)), Str(PagoFinal(I)), Str(CobroBase(I)))

            fila = I
        Else
            MsgBox("Numero de placa no encontrado")
            txtNumPlaca.Focus()
        End If




    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click

        NumeroPlaca(fila) = Nothing
        TipoCarro(fila) = Nothing
        KmInicial(fila) = Nothing
        KmFinal(fila) = Nothing
        PagoFinal(fila) = Nothing
        CobroBase(fila) = Nothing


        For I = fila To 5

            NumeroPlaca(I) = NumeroPlaca(I + 1)
            TipoCarro(I) = TipoCarro(I + 1)
            KmInicial(I) = KmInicial(I + 1)
            KmFinal(I) = KmFinal(I + 1)
            PagoFinal(I) = PagoFinal(I + 1)
            CobroBase(I) = CobroBase(I + 1)


        Next I
        MsgBox("Registro Eliminado exitosamente")

        NumeroPlaca(I) = Nothing
        TipoCarro(I) = Nothing
        KmInicial(I) = Nothing
        KmFinal(I) = Nothing
        PagoFinal(I) = Nothing
        CobroBase(I) = Nothing

        fila = I
        Limpiar()
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click

        NumeroPlaca(fila) = Val(txtNumPlaca.Text)
        TipoCarro(fila) = ComboTipoCarro.Text
        KmInicial(fila) = Val(txtKmInicial.Text)
        KmFinal(fila) = Val(txtKmFinal.Text)
        PagoFinal(fila) = DatoPago
        CobroBase(fila) = DatoCobro
        MsgBox("Registro actualizado correctamente en los vectores")
        fila = 7



    End Sub
End Class
