<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultaform
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
        Me.buttonBusqueda = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputbusq = New System.Windows.Forms.TextBox()
        Me.busCod = New System.Windows.Forms.TextBox()
        Me.busNom = New System.Windows.Forms.TextBox()
        Me.busApe = New System.Windows.Forms.TextBox()
        Me.busTel = New System.Windows.Forms.TextBox()
        Me.busEma = New System.Windows.Forms.TextBox()
        Me.busCur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buttonVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonBusqueda
        '
        Me.buttonBusqueda.Location = New System.Drawing.Point(197, 34)
        Me.buttonBusqueda.Name = "buttonBusqueda"
        Me.buttonBusqueda.Size = New System.Drawing.Size(75, 23)
        Me.buttonBusqueda.TabIndex = 2
        Me.buttonBusqueda.Text = "Buscar"
        Me.buttonBusqueda.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'inputbusq
        '
        Me.inputbusq.Location = New System.Drawing.Point(89, 36)
        Me.inputbusq.Name = "inputbusq"
        Me.inputbusq.Size = New System.Drawing.Size(100, 20)
        Me.inputbusq.TabIndex = 1
        '
        'busCod
        '
        Me.busCod.Location = New System.Drawing.Point(89, 87)
        Me.busCod.Name = "busCod"
        Me.busCod.ReadOnly = True
        Me.busCod.Size = New System.Drawing.Size(100, 20)
        Me.busCod.TabIndex = 0
        '
        'busNom
        '
        Me.busNom.Location = New System.Drawing.Point(89, 113)
        Me.busNom.Name = "busNom"
        Me.busNom.ReadOnly = True
        Me.busNom.Size = New System.Drawing.Size(100, 20)
        Me.busNom.TabIndex = 0
        '
        'busApe
        '
        Me.busApe.Location = New System.Drawing.Point(89, 139)
        Me.busApe.Name = "busApe"
        Me.busApe.ReadOnly = True
        Me.busApe.Size = New System.Drawing.Size(100, 20)
        Me.busApe.TabIndex = 0
        '
        'busTel
        '
        Me.busTel.Location = New System.Drawing.Point(89, 165)
        Me.busTel.Name = "busTel"
        Me.busTel.ReadOnly = True
        Me.busTel.Size = New System.Drawing.Size(100, 20)
        Me.busTel.TabIndex = 0
        '
        'busEma
        '
        Me.busEma.Location = New System.Drawing.Point(89, 191)
        Me.busEma.Name = "busEma"
        Me.busEma.ReadOnly = True
        Me.busEma.Size = New System.Drawing.Size(100, 20)
        Me.busEma.TabIndex = 0
        '
        'busCur
        '
        Me.busCur.Location = New System.Drawing.Point(89, 217)
        Me.busCur.Name = "busCur"
        Me.busCur.ReadOnly = True
        Me.busCur.Size = New System.Drawing.Size(100, 20)
        Me.busCur.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Curso:"
        '
        'buttonVolver
        '
        Me.buttonVolver.Location = New System.Drawing.Point(105, 253)
        Me.buttonVolver.Name = "buttonVolver"
        Me.buttonVolver.Size = New System.Drawing.Size(75, 23)
        Me.buttonVolver.TabIndex = 3
        Me.buttonVolver.Text = "Volver"
        Me.buttonVolver.UseVisualStyleBackColor = True
        '
        'consultaform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 288)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.busCur)
        Me.Controls.Add(Me.busEma)
        Me.Controls.Add(Me.busTel)
        Me.Controls.Add(Me.busApe)
        Me.Controls.Add(Me.busNom)
        Me.Controls.Add(Me.busCod)
        Me.Controls.Add(Me.inputbusq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonVolver)
        Me.Controls.Add(Me.buttonBusqueda)
        Me.Name = "consultaform"
        Me.Text = "Busqueda de Alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonBusqueda As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents inputbusq As TextBox
    Friend WithEvents busCod As TextBox
    Friend WithEvents busNom As TextBox
    Friend WithEvents busApe As TextBox
    Friend WithEvents busTel As TextBox
    Friend WithEvents busEma As TextBox
    Friend WithEvents busCur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents buttonVolver As Button
End Class
