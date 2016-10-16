<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.inputUser = New System.Windows.Forms.TextBox()
        Me.inputPass = New System.Windows.Forms.TextBox()
        Me.errorLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inputUser
        '
        Me.inputUser.Location = New System.Drawing.Point(67, 55)
        Me.inputUser.Name = "inputUser"
        Me.inputUser.Size = New System.Drawing.Size(100, 20)
        Me.inputUser.TabIndex = 1
        '
        'inputPass
        '
        Me.inputPass.Location = New System.Drawing.Point(67, 111)
        Me.inputPass.Name = "inputPass"
        Me.inputPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inputPass.Size = New System.Drawing.Size(100, 20)
        Me.inputPass.TabIndex = 2
        '
        'errorLogin
        '
        Me.errorLogin.AutoSize = True
        Me.errorLogin.ForeColor = System.Drawing.Color.Red
        Me.errorLogin.Location = New System.Drawing.Point(32, 145)
        Me.errorLogin.Name = "errorLogin"
        Me.errorLogin.Size = New System.Drawing.Size(176, 13)
        Me.errorLogin.TabIndex = 3
        Me.errorLogin.Text = "Usuario y/o contraseña incorrectos."
        Me.errorLogin.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 224)
        Me.Controls.Add(Me.errorLogin)
        Me.Controls.Add(Me.inputPass)
        Me.Controls.Add(Me.inputUser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents inputUser As TextBox
    Friend WithEvents inputPass As TextBox
    Friend WithEvents errorLogin As Label
End Class
