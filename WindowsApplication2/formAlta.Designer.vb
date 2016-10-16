<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAlta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inputEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inputCurso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.errorCod = New System.Windows.Forms.Label()
        Me.errorNom = New System.Windows.Forms.Label()
        Me.errorApe = New System.Windows.Forms.Label()
        Me.errorTel = New System.Windows.Forms.Label()
        Me.errorEmail = New System.Windows.Forms.Label()
        Me.errorCurso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'inputCodigo
        '
        Me.inputCodigo.Location = New System.Drawing.Point(110, 29)
        Me.inputCodigo.Name = "inputCodigo"
        Me.inputCodigo.Size = New System.Drawing.Size(100, 20)
        Me.inputCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'inputNombre
        '
        Me.inputNombre.Location = New System.Drawing.Point(110, 79)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(100, 20)
        Me.inputNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido:"
        '
        'inputApellido
        '
        Me.inputApellido.Location = New System.Drawing.Point(110, 129)
        Me.inputApellido.Name = "inputApellido"
        Me.inputApellido.Size = New System.Drawing.Size(100, 20)
        Me.inputApellido.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Teléfono:"
        '
        'inputTelefono
        '
        Me.inputTelefono.Location = New System.Drawing.Point(110, 178)
        Me.inputTelefono.Name = "inputTelefono"
        Me.inputTelefono.Size = New System.Drawing.Size(100, 20)
        Me.inputTelefono.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Email:"
        '
        'inputEmail
        '
        Me.inputEmail.Location = New System.Drawing.Point(110, 224)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(100, 20)
        Me.inputEmail.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Curso:"
        '
        'inputCurso
        '
        Me.inputCurso.Location = New System.Drawing.Point(110, 267)
        Me.inputCurso.Name = "inputCurso"
        Me.inputCurso.Size = New System.Drawing.Size(100, 20)
        Me.inputCurso.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Dar Alta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(218, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'errorCod
        '
        Me.errorCod.AutoSize = True
        Me.errorCod.ForeColor = System.Drawing.Color.Red
        Me.errorCod.Location = New System.Drawing.Point(33, 52)
        Me.errorCod.Name = "errorCod"
        Me.errorCod.Size = New System.Drawing.Size(241, 13)
        Me.errorCod.TabIndex = 4
        Me.errorCod.Text = "El código de alumno no es numérico o está vacío"
        Me.errorCod.Visible = False
        '
        'errorNom
        '
        Me.errorNom.AutoSize = True
        Me.errorNom.ForeColor = System.Drawing.Color.Red
        Me.errorNom.Location = New System.Drawing.Point(43, 102)
        Me.errorNom.Name = "errorNom"
        Me.errorNom.Size = New System.Drawing.Size(212, 13)
        Me.errorNom.TabIndex = 4
        Me.errorNom.Text = "El nombre no admite números o está vacío."
        Me.errorNom.Visible = False
        '
        'errorApe
        '
        Me.errorApe.AutoSize = True
        Me.errorApe.ForeColor = System.Drawing.Color.Red
        Me.errorApe.Location = New System.Drawing.Point(43, 152)
        Me.errorApe.Name = "errorApe"
        Me.errorApe.Size = New System.Drawing.Size(213, 13)
        Me.errorApe.TabIndex = 4
        Me.errorApe.Text = "El apellido no admite números o está vacío."
        Me.errorApe.Visible = False
        '
        'errorTel
        '
        Me.errorTel.AutoSize = True
        Me.errorTel.ForeColor = System.Drawing.Color.Red
        Me.errorTel.Location = New System.Drawing.Point(50, 201)
        Me.errorTel.Name = "errorTel"
        Me.errorTel.Size = New System.Drawing.Size(198, 13)
        Me.errorTel.TabIndex = 4
        Me.errorTel.Text = "El teléfono no es numérico o está vacío."
        Me.errorTel.Visible = False
        '
        'errorEmail
        '
        Me.errorEmail.AutoSize = True
        Me.errorEmail.ForeColor = System.Drawing.Color.Red
        Me.errorEmail.Location = New System.Drawing.Point(97, 247)
        Me.errorEmail.Name = "errorEmail"
        Me.errorEmail.Size = New System.Drawing.Size(129, 13)
        Me.errorEmail.TabIndex = 4
        Me.errorEmail.Text = "Debes introducir un email."
        Me.errorEmail.Visible = False
        '
        'errorCurso
        '
        Me.errorCurso.AutoSize = True
        Me.errorCurso.ForeColor = System.Drawing.Color.Red
        Me.errorCurso.Location = New System.Drawing.Point(95, 290)
        Me.errorCurso.Name = "errorCurso"
        Me.errorCurso.Size = New System.Drawing.Size(131, 13)
        Me.errorCurso.TabIndex = 4
        Me.errorCurso.Text = "Debes introducir un curso."
        Me.errorCurso.Visible = False
        '
        'formAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 359)
        Me.Controls.Add(Me.errorCurso)
        Me.Controls.Add(Me.errorEmail)
        Me.Controls.Add(Me.errorTel)
        Me.Controls.Add(Me.errorApe)
        Me.Controls.Add(Me.errorNom)
        Me.Controls.Add(Me.errorCod)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.inputEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inputTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inputCurso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inputApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.inputCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formAlta"
        Me.Text = "Nuevo Alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents inputNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inputApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents inputTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents inputEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents inputCurso As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents errorCod As Label
    Friend WithEvents errorNom As Label
    Friend WithEvents errorApe As Label
    Friend WithEvents errorTel As Label
    Friend WithEvents errorEmail As Label
    Friend WithEvents errorCurso As Label
End Class
