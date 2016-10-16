Public Class formAlta
    Private codAlum As Integer
    Private nomAlum As String
    Private apeAlum As String
    Private telAlum As String
    Private emailAlum As String
    Private cursoAlum As String

    Dim checkCodigo, checkNombre, checkApellido, checkTelefono, checkEmail, checkCurso

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        formAlumno.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If inputCodigo.Text Is "" Or IsNumeric(inputCodigo.Text) = False Then
            errorCod.Visible = True
            checkCodigo = False
            inputCodigo.Text() = ""
            inputCodigo.Focus()
        Else
            errorCod.Visible = False
            checkCodigo = True
        End If

        If inputNombre.Text Is "" Or IsNumeric(inputNombre.Text) = True Then
            errorNom.Visible = True
            checkNombre = False
            inputNombre.Text() = ""
            inputNombre.Focus()
        Else
            errorNom.Visible = False
            checkNombre = True
        End If

        If inputApellido.Text Is "" Or IsNumeric(inputApellido.Text) = True Then
            errorApe.Visible = True
            checkApellido = False
            inputApellido.Text() = ""
            inputApellido.Focus()
        Else
            errorApe.Visible = False
            checkApellido = True
        End If

        If inputTelefono.Text Is "" Or IsNumeric(inputTelefono.Text) = False Then
            errorTel.Visible = True
            checkTelefono = False
            inputTelefono.Text() = ""
            inputTelefono.Focus()
        Else
            errorTel.Visible = False
            checkTelefono = True
        End If

        If inputEmail.Text Is "" Then
            errorEmail.Visible = True
            checkEmail = False
            inputEmail.Text() = ""
            inputEmail.Focus()
        Else
            errorEmail.Visible = False
            checkEmail = True
        End If

        If inputCurso.Text Is "" Then
            errorCurso.Visible = True
            checkCurso = False
            inputCurso.Text() = ""
            inputCurso.Focus()
        Else
            errorCurso.Visible = False
            checkCurso = True
        End If

        If checkCodigo = True And checkNombre = True And checkApellido = True And checkTelefono = True And checkEmail = True And checkCurso = True Then


            alumnoNuevo.codAlum = inputCodigo.Text
            alumnoNuevo.nomAlum = inputNombre.Text
            alumnoNuevo.apellAlum = inputApellido.Text
            alumnoNuevo.telfAlum = inputTelefono.Text
            alumnoNuevo.emailAlum = inputEmail.Text
            alumnoNuevo.cursoAlum = inputCurso.Text

            For Each elemento As Alumno In arrayAlumno
                If elemento.nomAlum = inputNombre.Text() Then

                    MessageBox.Show("Este nombre de alumno ya existe y no puede ser registrado")
                    Exit For
                Else
                    arrayAlumno(arrayAlumno.Length - 1) = alumnoNuevo
                    MessageBox.Show("Código Alumno:" + vbTab & alumnoNuevo.codAlum & vbCrLf & "Nombre Alumno:" + vbTab & alumnoNuevo.nomAlum & vbCrLf & "Apellido Alumno:" + vbTab & alumnoNuevo.apellAlum & vbCrLf & "Telefono Alumno:" + vbTab & alumnoNuevo.telfAlum & vbCrLf & "Email Alumno:" + vbTab & alumnoNuevo.emailAlum & vbCrLf & "Curso Alumno:" + vbTab & alumnoNuevo.cursoAlum, "Usuario Registrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Exit For
                End If
            Next



            inputCodigo.Text() = ""
            inputNombre.Text() = ""
            inputApellido.Text() = ""
            inputTelefono.Text() = ""
            inputEmail.Text() = ""
            inputCurso.Text() = ""
            ReDim Preserve arrayAlumno(arrayAlumno.Length)
            inputCodigo.Focus()
        End If
    End Sub


End Class