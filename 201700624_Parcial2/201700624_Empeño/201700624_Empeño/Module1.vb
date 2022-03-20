Module Module1

    Public matriz(9, 5)
    Public Indice As Byte = 0
    Public Intento As Byte = 0

    Public Const CortoPlazoTv As Integer = 250
    Public Const LargoPlazoTv As Integer = 300

    Public Const CortoPlazoTelefono As Integer = 550
    Public Const LargoPlazoTelefono As Integer = 600

    Public Const CortoPlazoLaptop As Integer = 770
    Public Const LargoPlazoLaptop As Integer = 800

    Public Const CortoPlazoRefri As Integer = 1000
    Public Const LargoPlazoRefri As Integer = 1200


    Sub CalculosDescuentos()
        If (Form1.checkBoxTV.Checked And Form1.comboTipoPlazo.Text = "Corto" And Form1.checkBoxRefri.Checked) Then
            Form1.ListPagoParcial.Items.Add(CortoPlazoTv + CortoPlazoRefri)

            Form1.ListDescuentos.Items.Add((CortoPlazoTv + CortoPlazoRefri) * 1.15)

        ElseIf (Form1.checkBoxTV.Checked And Form1.comboTipoPlazo.Text = "Largo" And Form1.checkBoxRefri.Checked) Then
            Form1.ListPagoParcial.Items.Add(LargoPlazoTv + LargoPlazoRefri)

            Form1.ListDescuentos.Items.Add((CortoPlazoTv + CortoPlazoRefri) * 1.05)
        ElseIf (Form1.CheckBoxTelefono.Checked And Form1.comboTipoPlazo.Text = "Corto" And Form1.CheckBoxLaptop.Checked) Then
            Form1.ListPagoParcial.Items.Add(CortoPlazoTelefono + CortoPlazoLaptop)

            Form1.ListDescuentos.Items.Add((CortoPlazoTelefono + CortoPlazoLaptop) * 1.05)
        ElseIf (Form1.CheckBoxTelefono.Checked And Form1.comboTipoPlazo.Text = "Largo" And Form1.CheckBoxLaptop.Checked) Then
            Form1.ListPagoParcial.Items.Add(LargoPlazoTelefono + LargoPlazoLaptop)

            Form1.ListDescuentos.Items.Add((LargoPlazoTelefono + LargoPlazoLaptop) * 1.1)

        End If

    End Sub



End Module
