<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_calculo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_calculo))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_peso = New System.Windows.Forms.Label()
        Me.lbl_estatura = New System.Windows.Forms.Label()
        Me.lbl_rango = New System.Windows.Forms.Label()
        Me.lbl_nacionalidad = New System.Windows.Forms.Label()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.lbl_sustancias = New System.Windows.Forms.Label()
        Me.lbl_imc = New System.Windows.Forms.Label()
        Me.lbl_condicion = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.peso = New System.Windows.Forms.Label()
        Me.estatura = New System.Windows.Forms.Label()
        Me.rango = New System.Windows.Forms.Label()
        Me.nacionalidad = New System.Windows.Forms.Label()
        Me.sexo = New System.Windows.Forms.Label()
        Me.sustancias = New System.Windows.Forms.Label()
        Me.imc = New System.Windows.Forms.Label()
        Me.condicion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.recomendacion = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lbl_titulo.Location = New System.Drawing.Point(212, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(141, 186)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Resultados"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_nombre.Location = New System.Drawing.Point(45, 56)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 17)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_peso
        '
        Me.lbl_peso.AutoSize = True
        Me.lbl_peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_peso.Location = New System.Drawing.Point(45, 95)
        Me.lbl_peso.Name = "lbl_peso"
        Me.lbl_peso.Size = New System.Drawing.Size(44, 17)
        Me.lbl_peso.TabIndex = 2
        Me.lbl_peso.Text = "Peso:"
        '
        'lbl_estatura
        '
        Me.lbl_estatura.AutoSize = True
        Me.lbl_estatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_estatura.Location = New System.Drawing.Point(45, 140)
        Me.lbl_estatura.Name = "lbl_estatura"
        Me.lbl_estatura.Size = New System.Drawing.Size(65, 17)
        Me.lbl_estatura.TabIndex = 3
        Me.lbl_estatura.Text = "Estatura:"
        '
        'lbl_rango
        '
        Me.lbl_rango.AutoSize = True
        Me.lbl_rango.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_rango.Location = New System.Drawing.Point(45, 180)
        Me.lbl_rango.Name = "lbl_rango"
        Me.lbl_rango.Size = New System.Drawing.Size(110, 17)
        Me.lbl_rango.TabIndex = 4
        Me.lbl_rango.Text = "Rango de edad:"
        '
        'lbl_nacionalidad
        '
        Me.lbl_nacionalidad.AutoSize = True
        Me.lbl_nacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_nacionalidad.Location = New System.Drawing.Point(45, 218)
        Me.lbl_nacionalidad.Name = "lbl_nacionalidad"
        Me.lbl_nacionalidad.Size = New System.Drawing.Size(94, 17)
        Me.lbl_nacionalidad.TabIndex = 5
        Me.lbl_nacionalidad.Text = "Nacionalidad:"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_sexo.Location = New System.Drawing.Point(45, 254)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(43, 17)
        Me.lbl_sexo.TabIndex = 6
        Me.lbl_sexo.Text = "Sexo:"
        '
        'lbl_sustancias
        '
        Me.lbl_sustancias.AutoSize = True
        Me.lbl_sustancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_sustancias.Location = New System.Drawing.Point(45, 296)
        Me.lbl_sustancias.Name = "lbl_sustancias"
        Me.lbl_sustancias.Size = New System.Drawing.Size(81, 17)
        Me.lbl_sustancias.TabIndex = 7
        Me.lbl_sustancias.Text = "Sustancias:"
        '
        'lbl_imc
        '
        Me.lbl_imc.AutoSize = True
        Me.lbl_imc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_imc.Location = New System.Drawing.Point(45, 370)
        Me.lbl_imc.Name = "lbl_imc"
        Me.lbl_imc.Size = New System.Drawing.Size(202, 17)
        Me.lbl_imc.TabIndex = 8
        Me.lbl_imc.Text = "Indice de Masa Corporal (IMC):"
        '
        'lbl_condicion
        '
        Me.lbl_condicion.AutoSize = True
        Me.lbl_condicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_condicion.Location = New System.Drawing.Point(45, 406)
        Me.lbl_condicion.Name = "lbl_condicion"
        Me.lbl_condicion.Size = New System.Drawing.Size(112, 17)
        Me.lbl_condicion.TabIndex = 9
        Me.lbl_condicion.Text = "Tu condicion es:"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nombre.Location = New System.Drawing.Point(214, 56)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(58, 17)
        Me.nombre.TabIndex = 10
        Me.nombre.Text = "Nombre"
        '
        'peso
        '
        Me.peso.AutoSize = True
        Me.peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.peso.Location = New System.Drawing.Point(214, 95)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(40, 17)
        Me.peso.TabIndex = 11
        Me.peso.Text = "Peso"
        '
        'estatura
        '
        Me.estatura.AutoSize = True
        Me.estatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.estatura.Location = New System.Drawing.Point(214, 140)
        Me.estatura.Name = "estatura"
        Me.estatura.Size = New System.Drawing.Size(61, 17)
        Me.estatura.TabIndex = 12
        Me.estatura.Text = "Estatura"
        '
        'rango
        '
        Me.rango.AutoSize = True
        Me.rango.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rango.Location = New System.Drawing.Point(214, 180)
        Me.rango.Name = "rango"
        Me.rango.Size = New System.Drawing.Size(50, 17)
        Me.rango.TabIndex = 13
        Me.rango.Text = "Rango"
        '
        'nacionalidad
        '
        Me.nacionalidad.AutoSize = True
        Me.nacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nacionalidad.Location = New System.Drawing.Point(214, 218)
        Me.nacionalidad.Name = "nacionalidad"
        Me.nacionalidad.Size = New System.Drawing.Size(90, 17)
        Me.nacionalidad.TabIndex = 14
        Me.nacionalidad.Text = "Nacionalidad"
        '
        'sexo
        '
        Me.sexo.AutoSize = True
        Me.sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.sexo.Location = New System.Drawing.Point(214, 254)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(39, 17)
        Me.sexo.TabIndex = 15
        Me.sexo.Text = "Sexo"
        '
        'sustancias
        '
        Me.sustancias.AutoSize = True
        Me.sustancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.sustancias.Location = New System.Drawing.Point(214, 296)
        Me.sustancias.Name = "sustancias"
        Me.sustancias.Size = New System.Drawing.Size(77, 17)
        Me.sustancias.TabIndex = 16
        Me.sustancias.Text = "Sustancias"
        '
        'imc
        '
        Me.imc.AutoSize = True
        Me.imc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.imc.Location = New System.Drawing.Point(285, 370)
        Me.imc.Name = "imc"
        Me.imc.Size = New System.Drawing.Size(31, 17)
        Me.imc.TabIndex = 17
        Me.imc.Text = "IMC"
        '
        'condicion
        '
        Me.condicion.AutoSize = True
        Me.condicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.condicion.Location = New System.Drawing.Point(285, 406)
        Me.condicion.Name = "condicion"
        Me.condicion.Size = New System.Drawing.Size(70, 17)
        Me.condicion.TabIndex = 18
        Me.condicion.Text = "Condicion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(27, 482)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(477, 227)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'recomendacion
        '
        Me.recomendacion.AutoSize = True
        Me.recomendacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.recomendacion.Location = New System.Drawing.Point(45, 445)
        Me.recomendacion.Name = "recomendacion"
        Me.recomendacion.Size = New System.Drawing.Size(125, 17)
        Me.recomendacion.TabIndex = 20
        Me.recomendacion.Text = "Recomendaciones"
        '
        'form_calculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 715)
        Me.Controls.Add(Me.recomendacion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.condicion)
        Me.Controls.Add(Me.imc)
        Me.Controls.Add(Me.sustancias)
        Me.Controls.Add(Me.sexo)
        Me.Controls.Add(Me.nacionalidad)
        Me.Controls.Add(Me.rango)
        Me.Controls.Add(Me.estatura)
        Me.Controls.Add(Me.peso)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.lbl_condicion)
        Me.Controls.Add(Me.lbl_imc)
        Me.Controls.Add(Me.lbl_sustancias)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.lbl_nacionalidad)
        Me.Controls.Add(Me.lbl_rango)
        Me.Controls.Add(Me.lbl_estatura)
        Me.Controls.Add(Me.lbl_peso)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "form_calculo"
        Me.Text = "Calculadora IMC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_peso As Label
    Friend WithEvents lbl_estatura As Label
    Friend WithEvents lbl_rango As Label
    Friend WithEvents lbl_nacionalidad As Label
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents lbl_sustancias As Label
    Friend WithEvents lbl_imc As Label
    Friend WithEvents lbl_condicion As Label
    Friend WithEvents nombre As Label
    Friend WithEvents peso As Label
    Friend WithEvents estatura As Label
    Friend WithEvents rango As Label
    Friend WithEvents nacionalidad As Label
    Friend WithEvents sexo As Label
    Friend WithEvents sustancias As Label
    Friend WithEvents imc As Label
    Friend WithEvents condicion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents recomendacion As Label
End Class
