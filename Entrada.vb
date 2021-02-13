Public Class form_entrada
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_titulo.Click

    End Sub

    Private Sub datos_gral_Enter(sender As Object, e As EventArgs) Handles box_datos.Enter

    End Sub

    Private Sub lbl_estatura_Click(sender As Object, e As EventArgs) Handles lbl_estatura.Click

    End Sub

    Private Sub lbl_peso_Click(sender As Object, e As EventArgs) Handles lbl_peso.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nd_estatura.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttn_exit.Click
        Me.Close()
    End Sub
    Private Sub bttn_calculate_Click(sender As Object, e As EventArgs) Handles bttn_calculate.Click
        form_calculo.ShowDialog()
    End Sub
End Class
