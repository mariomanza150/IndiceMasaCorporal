Public Class form_calculo
    Private Sub Calculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.nombre.Text = form_entrada.tb_nombre.Text
        Me.peso.Text = form_entrada.nd_peso.Value.ToString() + " kgs."
        Me.estatura.Text = form_entrada.nd_estatura.Value.ToString() + " mts."
        Me.rango.Text = form_entrada.cb_rango.Text
        Me.nacionalidad.Text = form_entrada.cb_nacionalidad.Text
        Dim rbttn_sexo As RadioButton = form_entrada.box_sexo.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Me.sexo.Text = rbttn_sexo.Text
        Dim sustancias As String = ""
        For Each el As CheckBox In form_entrada.box_sustancias.Controls
            If DirectCast(el, CheckBox).Checked Then
                sustancias += el.Text + ", "
            End If
        Next
        sustancias.Substring(0, sustancias.Length - 2)
        Me.sustancias.Text = sustancias
        Dim imc As Double = Math.Round(form_entrada.nd_peso.Value / Math.Pow(form_entrada.nd_estatura.Value, 2), 2)
        Me.imc.Text = imc
        If imc < 18.5 Then
            Me.condicion.Text = "Bajo Peso"
            Me.recomendacion.Text = "Hey, alimentate bien y ve con tu medico general."
        ElseIf imc < 24.9 Then
            Me.condicion.Text = "Peso Normal"
            Me.recomendacion.Text = "Genial, sigue asi!"
        ElseIf imc < 29.9 Then
            Me.condicion.Text = "Sobrepeso"
            Me.recomendacion.Text = "Hey, bajale a las de harina y ve con tu medico general."
        ElseIf imc > 30 Then
            Me.condicion.Text = "Obesidad"
            Me.recomendacion.Text = "Porfavor ponte a hacer ejercicio y alimentate bien, ve con tu medico."
        End If
    End Sub
End Class