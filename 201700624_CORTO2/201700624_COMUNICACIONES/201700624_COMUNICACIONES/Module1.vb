Module Module1

    Public Indice As Byte = 0

    Public Nombre(7) As String
    Public SueldoBruto(7) As String
    Public Comision(7) As Double
    Public Comisión(7) As Double
    Public Bono(7) As Double
    Public SueldoFinal(7) As Double
    Public Productos(7) As String

    Public CantBono As Integer = 0
    Public CantSueldoFinal As Integer = 0
    Public CantComisión As Integer = 0
    Public CantSueldoBruto As Integer = 0

    Public Const precioTablet = 375
    Public Const precioDrone = 560
    Public Const precioCelular = 1450
    Public Const precioTele = 3250


    '>
    Sub Calculos()

        If Form1.txtSueldoBruto.Text >= "1" And Form1.txtSueldoBruto.Text <= "2000" Then
            CantBono = (Form1.txtSueldoBruto.Text * 0.03) + Form1.txtSueldoBruto.Text


        End If




    End Sub

    Sub Limpiar()
        Form1.txtNombre.Clear()
        Form1.comboProducto.Text = ""

    End Sub


End Module
