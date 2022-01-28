Public Class Form1

    Const PrecioArroz As Double = 2.0
    Const PrecioFrijol As Double = 1.75
    Const PrecioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoIVA As Double = 0
    Dim Descuento As Double = 0
    Dim PagoFinal As Double = 0


    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        'codigo para el boton de acepatar para calcular los pagos'
        pagoSinIVA = (Val(TxtArroz.Text) * PrecioArroz) + (Val(TxtFrijol.Text) * PrecioFrijol) + (Val(TxtAzucar.Text) * PrecioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoIVA = pagoSinIVA + valorIVA
        Descuento = Math.Round(Val(pagoIVA * 0.025), 3)
        PagoFinal = pagoIVA - Descuento

        LabelDescuento.Text = Descuento
        LabelPagoConIVA.Text = pagoIVA
        LabelPagoSinIva.Text = pagoSinIVA
        LabelValorIVA.Text = valorIVA


    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        'limpiar los textbox los labels y las variables'
        TxtArroz.Text = "0"
        TxtAzucar.Text = "0"
        TxtFrijol.Text = "0"

        LabelDescuento.Text = "0"
        LabelPagoConIVA.Text = "0"
        LabelPagoSinIva.Text = "0"
        LabelValorIVA.Text = "0"

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If MsgBox("Desea salir de la aplicación", vbQuestion + vbYesNo, "Pregunta") = vbNo Then
        Else
            End
        End If
    End Sub

    Private Sub TxtArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArroz.KeyPress
        'codigo para restringir el ingreso de numeros'
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub TxtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If



    End Sub

    Private Sub TxtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAzucar.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub
End Class
