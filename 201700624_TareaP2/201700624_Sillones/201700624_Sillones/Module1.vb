Module Module1

    Public Indice As Byte = 0

    Public NumeroVenta(8) As Integer
    Public PMO(8) As Double
    Public PrecioCosto(8) As Double
    Public PrecioVenta(8) As Double
    Public Tamaño(8) As String
    Public Tipo(8) As String
    Public CantYardas(8) As Double

    Public PMODato As Double = 0
    Public PCODato As Double = 0

    Public Intento As Byte = 1

    Const PMOSofa As Double = 250.99
    Const PMOIndividual As Double = 150.99
    Const PMODoble As Double = 200.99

    Const Cuero As Double = 75
    Const Cuerina As Double = 45.99

    Public Const CantSofa As Double = 8
    Public Const CantIndividual As Double = 3.5
    Public Const CantDoble As Double = 6


    Sub Limpiar()
        Form1.txtNumeroVenta.Clear()
        Form1.comboTamaño.Text = ""
        Form1.comboTela.Text = ""
        PMODato = 0
        PCODato = 0

    End Sub

    Sub PCOCalculos()
        If (Form1.comboTamaño.Text = "Sofá" And Form1.comboTela.Text = "Cuero") Then
            PMODato = PMOSofa
            PCODato = PMODato + (CantSofa * Cuero)
        ElseIf (Form1.comboTamaño.Text = "Doble" And Form1.comboTela.Text = "Cuero") Then
            PMODato = PMODoble
            PCODato = PMODato + (CantDoble * Cuero)
        ElseIf (Form1.comboTamaño.Text = "Individual" And Form1.comboTela.Text = "Cuero") Then
            PMODato = PMOIndividual
            PCODato = PMODato + (CantIndividual * Cuero)
        ElseIf (Form1.comboTamaño.Text = "Sofá" And Form1.comboTela.Text = "Cuerina") Then
            PMODato = PMOSofa
            PCODato = PMODato + (CantSofa * Cuerina)
        ElseIf (Form1.comboTamaño.Text = "Doble" And Form1.comboTela.Text = "Cuerina") Then
            PMODato = PMODoble
            PCODato = PMODato + (CantDoble * Cuerina)
        ElseIf (Form1.comboTamaño.Text = "Individual" And Form1.comboTela.Text = "Cuerina") Then
            PMODato = PMOIndividual
            PCODato = PMODato + (CantIndividual * Cuerina)
        End If

    End Sub


End Module
