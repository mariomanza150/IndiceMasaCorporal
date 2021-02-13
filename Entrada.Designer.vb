<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_entrada
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
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_estatura = New System.Windows.Forms.Label()
        Me.lbl_peso = New System.Windows.Forms.Label()
        Me.lbl_rango = New System.Windows.Forms.Label()
        Me.box_datos = New System.Windows.Forms.GroupBox()
        Me.nd_peso = New System.Windows.Forms.NumericUpDown()
        Me.nd_estatura = New System.Windows.Forms.NumericUpDown()
        Me.cb_rango = New System.Windows.Forms.ComboBox()
        Me.tb_nombre = New System.Windows.Forms.TextBox()
        Me.box_sexo = New System.Windows.Forms.GroupBox()
        Me.rb_femenino = New System.Windows.Forms.RadioButton()
        Me.rb_masculino = New System.Windows.Forms.RadioButton()
        Me.box_nacionalidad = New System.Windows.Forms.GroupBox()
        Me.cb_nacionalidad = New System.Windows.Forms.ComboBox()
        Me.box_sustancias = New System.Windows.Forms.GroupBox()
        Me.chk_medicamentos = New System.Windows.Forms.CheckBox()
        Me.chk_drogas = New System.Windows.Forms.CheckBox()
        Me.chk_tabaco = New System.Windows.Forms.CheckBox()
        Me.chk_alchohol = New System.Windows.Forms.CheckBox()
        Me.bttn_calculate = New System.Windows.Forms.Button()
        Me.bttn_exit = New System.Windows.Forms.Button()
        Me.box_datos.SuspendLayout()
        CType(Me.nd_peso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_estatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_sexo.SuspendLayout()
        Me.box_nacionalidad.SuspendLayout()
        Me.box_sustancias.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lbl_titulo.Location = New System.Drawing.Point(0, 0)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Padding = New System.Windows.Forms.Padding(20)
        Me.lbl_titulo.Size = New System.Drawing.Size(784, 411)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Calculadora de Indice de Masa Corporal (IMC)"
        Me.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_nombre.Location = New System.Drawing.Point(9, 40)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(58, 17)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_estatura
        '
        Me.lbl_estatura.AutoSize = True
        Me.lbl_estatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_estatura.Location = New System.Drawing.Point(9, 84)
        Me.lbl_estatura.Name = "lbl_estatura"
        Me.lbl_estatura.Size = New System.Drawing.Size(97, 17)
        Me.lbl_estatura.TabIndex = 3
        Me.lbl_estatura.Text = "Estatura (mts)"
        '
        'lbl_peso
        '
        Me.lbl_peso.AutoSize = True
        Me.lbl_peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_peso.Location = New System.Drawing.Point(10, 131)
        Me.lbl_peso.Name = "lbl_peso"
        Me.lbl_peso.Size = New System.Drawing.Size(76, 17)
        Me.lbl_peso.TabIndex = 4
        Me.lbl_peso.Text = "Peso (kgs)"
        '
        'lbl_rango
        '
        Me.lbl_rango.AutoSize = True
        Me.lbl_rango.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_rango.Location = New System.Drawing.Point(10, 173)
        Me.lbl_rango.Name = "lbl_rango"
        Me.lbl_rango.Size = New System.Drawing.Size(107, 17)
        Me.lbl_rango.TabIndex = 5
        Me.lbl_rango.Text = "Rango de Edad"
        '
        'box_datos
        '
        Me.box_datos.Controls.Add(Me.nd_peso)
        Me.box_datos.Controls.Add(Me.nd_estatura)
        Me.box_datos.Controls.Add(Me.cb_rango)
        Me.box_datos.Controls.Add(Me.tb_nombre)
        Me.box_datos.Controls.Add(Me.lbl_nombre)
        Me.box_datos.Controls.Add(Me.lbl_rango)
        Me.box_datos.Controls.Add(Me.lbl_estatura)
        Me.box_datos.Controls.Add(Me.lbl_peso)
        Me.box_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.box_datos.Location = New System.Drawing.Point(29, 61)
        Me.box_datos.Name = "box_datos"
        Me.box_datos.Size = New System.Drawing.Size(353, 209)
        Me.box_datos.TabIndex = 6
        Me.box_datos.TabStop = False
        Me.box_datos.Text = "Datos del Paciente"
        '
        'nd_peso
        '
        Me.nd_peso.DecimalPlaces = 1
        Me.nd_peso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nd_peso.Location = New System.Drawing.Point(120, 129)
        Me.nd_peso.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.nd_peso.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nd_peso.Name = "nd_peso"
        Me.nd_peso.Size = New System.Drawing.Size(69, 23)
        Me.nd_peso.TabIndex = 11
        Me.nd_peso.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'nd_estatura
        '
        Me.nd_estatura.DecimalPlaces = 2
        Me.nd_estatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nd_estatura.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nd_estatura.Location = New System.Drawing.Point(120, 82)
        Me.nd_estatura.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nd_estatura.Minimum = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.nd_estatura.Name = "nd_estatura"
        Me.nd_estatura.Size = New System.Drawing.Size(69, 23)
        Me.nd_estatura.TabIndex = 10
        Me.nd_estatura.Value = New Decimal(New Integer() {4, 0, 0, 65536})
        '
        'cb_rango
        '
        Me.cb_rango.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cb_rango.FormattingEnabled = True
        Me.cb_rango.Items.AddRange(New Object() {"10-19", "20-29", "30-39", "40-49", "50-59", "60-69"})
        Me.cb_rango.Location = New System.Drawing.Point(123, 170)
        Me.cb_rango.Name = "cb_rango"
        Me.cb_rango.Size = New System.Drawing.Size(66, 24)
        Me.cb_rango.TabIndex = 9
        '
        'tb_nombre
        '
        Me.tb_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tb_nombre.Location = New System.Drawing.Point(73, 37)
        Me.tb_nombre.Name = "tb_nombre"
        Me.tb_nombre.Size = New System.Drawing.Size(274, 23)
        Me.tb_nombre.TabIndex = 6
        '
        'box_sexo
        '
        Me.box_sexo.Controls.Add(Me.rb_femenino)
        Me.box_sexo.Controls.Add(Me.rb_masculino)
        Me.box_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.box_sexo.Location = New System.Drawing.Point(392, 61)
        Me.box_sexo.Name = "box_sexo"
        Me.box_sexo.Size = New System.Drawing.Size(353, 75)
        Me.box_sexo.TabIndex = 7
        Me.box_sexo.TabStop = False
        Me.box_sexo.Text = "Sexo"
        '
        'rb_femenino
        '
        Me.rb_femenino.AutoSize = True
        Me.rb_femenino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rb_femenino.Location = New System.Drawing.Point(129, 36)
        Me.rb_femenino.Name = "rb_femenino"
        Me.rb_femenino.Size = New System.Drawing.Size(88, 21)
        Me.rb_femenino.TabIndex = 1
        Me.rb_femenino.TabStop = True
        Me.rb_femenino.Text = "Femenino"
        Me.rb_femenino.UseVisualStyleBackColor = True
        '
        'rb_masculino
        '
        Me.rb_masculino.AutoSize = True
        Me.rb_masculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rb_masculino.Location = New System.Drawing.Point(22, 36)
        Me.rb_masculino.Name = "rb_masculino"
        Me.rb_masculino.Size = New System.Drawing.Size(89, 21)
        Me.rb_masculino.TabIndex = 0
        Me.rb_masculino.TabStop = True
        Me.rb_masculino.Text = "Masculino"
        Me.rb_masculino.UseVisualStyleBackColor = True
        '
        'box_nacionalidad
        '
        Me.box_nacionalidad.Controls.Add(Me.cb_nacionalidad)
        Me.box_nacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_nacionalidad.Location = New System.Drawing.Point(29, 276)
        Me.box_nacionalidad.Name = "box_nacionalidad"
        Me.box_nacionalidad.Size = New System.Drawing.Size(353, 114)
        Me.box_nacionalidad.TabIndex = 8
        Me.box_nacionalidad.TabStop = False
        Me.box_nacionalidad.Text = "Nacionalidad"
        '
        'cb_nacionalidad
        '
        Me.cb_nacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_nacionalidad.FormattingEnabled = True
        Me.cb_nacionalidad.Items.AddRange(New Object() {"Mexicana", "Estadounidense", "Española", "Italiana", "Inglesa", "Francesa", "Africana"})
        Me.cb_nacionalidad.Location = New System.Drawing.Point(13, 36)
        Me.cb_nacionalidad.Name = "cb_nacionalidad"
        Me.cb_nacionalidad.Size = New System.Drawing.Size(184, 24)
        Me.cb_nacionalidad.TabIndex = 0
        '
        'box_sustancias
        '
        Me.box_sustancias.Controls.Add(Me.chk_medicamentos)
        Me.box_sustancias.Controls.Add(Me.chk_drogas)
        Me.box_sustancias.Controls.Add(Me.chk_tabaco)
        Me.box_sustancias.Controls.Add(Me.chk_alchohol)
        Me.box_sustancias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_sustancias.Location = New System.Drawing.Point(392, 145)
        Me.box_sustancias.Name = "box_sustancias"
        Me.box_sustancias.Size = New System.Drawing.Size(353, 125)
        Me.box_sustancias.TabIndex = 9
        Me.box_sustancias.TabStop = False
        Me.box_sustancias.Text = "¿Usted consume alguna de estas sustancias?"
        '
        'chk_medicamentos
        '
        Me.chk_medicamentos.AutoSize = True
        Me.chk_medicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chk_medicamentos.Location = New System.Drawing.Point(129, 85)
        Me.chk_medicamentos.Name = "chk_medicamentos"
        Me.chk_medicamentos.Size = New System.Drawing.Size(190, 21)
        Me.chk_medicamentos.TabIndex = 3
        Me.chk_medicamentos.Text = "Medicamentos Recetados"
        Me.chk_medicamentos.UseVisualStyleBackColor = True
        '
        'chk_drogas
        '
        Me.chk_drogas.AutoSize = True
        Me.chk_drogas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chk_drogas.Location = New System.Drawing.Point(129, 45)
        Me.chk_drogas.Name = "chk_drogas"
        Me.chk_drogas.Size = New System.Drawing.Size(73, 21)
        Me.chk_drogas.TabIndex = 2
        Me.chk_drogas.Text = "Drogas"
        Me.chk_drogas.UseVisualStyleBackColor = True
        '
        'chk_tabaco
        '
        Me.chk_tabaco.AutoSize = True
        Me.chk_tabaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chk_tabaco.Location = New System.Drawing.Point(22, 85)
        Me.chk_tabaco.Name = "chk_tabaco"
        Me.chk_tabaco.Size = New System.Drawing.Size(75, 21)
        Me.chk_tabaco.TabIndex = 1
        Me.chk_tabaco.Text = "Tabaco"
        Me.chk_tabaco.UseVisualStyleBackColor = True
        '
        'chk_alchohol
        '
        Me.chk_alchohol.AutoSize = True
        Me.chk_alchohol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chk_alchohol.Location = New System.Drawing.Point(22, 45)
        Me.chk_alchohol.Name = "chk_alchohol"
        Me.chk_alchohol.Size = New System.Drawing.Size(81, 21)
        Me.chk_alchohol.TabIndex = 0
        Me.chk_alchohol.Text = "Alchohol"
        Me.chk_alchohol.UseVisualStyleBackColor = True
        '
        'bttn_calculate
        '
        Me.bttn_calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_calculate.Location = New System.Drawing.Point(631, 312)
        Me.bttn_calculate.Name = "bttn_calculate"
        Me.bttn_calculate.Size = New System.Drawing.Size(80, 30)
        Me.bttn_calculate.TabIndex = 10
        Me.bttn_calculate.Text = "Calcular"
        Me.bttn_calculate.UseVisualStyleBackColor = True
        '
        'bttn_exit
        '
        Me.bttn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn_exit.Location = New System.Drawing.Point(521, 312)
        Me.bttn_exit.Name = "bttn_exit"
        Me.bttn_exit.Size = New System.Drawing.Size(80, 30)
        Me.bttn_exit.TabIndex = 11
        Me.bttn_exit.Text = "Salir"
        Me.bttn_exit.UseVisualStyleBackColor = True
        '
        'form_entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.bttn_exit)
        Me.Controls.Add(Me.bttn_calculate)
        Me.Controls.Add(Me.box_sustancias)
        Me.Controls.Add(Me.box_nacionalidad)
        Me.Controls.Add(Me.box_sexo)
        Me.Controls.Add(Me.box_datos)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "form_entrada"
        Me.Text = "Calculadora IMC"
        Me.box_datos.ResumeLayout(False)
        Me.box_datos.PerformLayout()
        CType(Me.nd_peso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_estatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_sexo.ResumeLayout(False)
        Me.box_sexo.PerformLayout()
        Me.box_nacionalidad.ResumeLayout(False)
        Me.box_sustancias.ResumeLayout(False)
        Me.box_sustancias.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_estatura As Label
    Friend WithEvents lbl_peso As Label
    Friend WithEvents lbl_rango As Label
    Friend WithEvents box_datos As GroupBox
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents cb_rango As ComboBox
    Friend WithEvents nd_estatura As NumericUpDown
    Friend WithEvents box_sexo As GroupBox
    Friend WithEvents box_nacionalidad As GroupBox
    Friend WithEvents box_sustancias As GroupBox
    Friend WithEvents nd_peso As NumericUpDown
    Friend WithEvents rb_femenino As RadioButton
    Friend WithEvents rb_masculino As RadioButton
    Friend WithEvents cb_nacionalidad As ComboBox
    Friend WithEvents chk_medicamentos As CheckBox
    Friend WithEvents chk_drogas As CheckBox
    Friend WithEvents chk_tabaco As CheckBox
    Friend WithEvents chk_alchohol As CheckBox
    Friend WithEvents bttn_calculate As Button
    Friend WithEvents bttn_exit As Button
End Class
