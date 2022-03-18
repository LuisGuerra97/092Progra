Public Class Form1



    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Calculos()

        If (Indice <= 7) Then
            Nombre(Indice) = txtNombre.Text
            SueldoBruto(Indice) = Val(txtSueldoBruto.Text)
            Productos(Indice) = comboProducto.Text
            Bono(Indice) = CantBono


            mostrarDatos()
            Indice = Indice + 1

        End If



    End Sub

    Sub mostrarDatos()
        DataGridView1.Rows.Add(Nombre(Indice), Str(SueldoBruto(Indice)), Str(Comision(Indice)), Str(Bono(Indice)), Str(SueldoFinal(Indice)), (Productos(Indice)))


    End Sub

End Class
