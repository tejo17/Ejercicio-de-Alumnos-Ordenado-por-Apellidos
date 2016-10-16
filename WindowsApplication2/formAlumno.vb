Public Class formAlumno
    Private Sub formAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputUserName.Text() = Module1.userName

    End Sub

    Dim opcion As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        If IsNumeric(TextBox1.Text()) Then

            opcion = TextBox1.Text()
            Select Case opcion
                Case 1
                    Me.Hide()
                    formAlta.ShowDialog()
                Case 2
                    Me.Hide()
                    consultaform.ShowDialog()
                Case 3

                    Dim apellidoAlum(0) As String
                    'Recorremos todos los alumnos y cogemos los apellidos y los guardamos en un array de apellidos
                    For index As Integer = 0 To arrayAlumno.Length - 1
                        apellidoAlum(index) = arrayAlumno(index).apellAlum
                        ReDim Preserve apellidoAlum(apellidoAlum.Length)
                    Next
                    'Ordenamos el array apellidos alfabeticamente
                    Array.Sort(apellidoAlum)

                    'Creamos un array temporal para traspasar los alumnos y que no se pierdan los datos 
                    Dim arrayTemporal() As Alumno

                    'Clonamos el arry de Alumnos en el array temporal
                    arrayTemporal = arrayAlumno.Clone
                    Dim contador = 0

                    'Recorremos todo el array apellidos y los buscamos
                    For Each apellidos As String In apellidoAlum

                        'Recorremos el array temporal y movemos ordenado al array de alumnos
                        For i As Integer = 0 To arrayTemporal.Length - 2
                            If arrayTemporal(i).apellAlum = apellidos Then

                                arrayAlumno(contador).codAlum = arrayTemporal(i).codAlum
                                arrayAlumno(contador).nomAlum = arrayTemporal(i).nomAlum
                                arrayAlumno(contador).apellAlum = arrayTemporal(i).apellAlum
                                arrayAlumno(contador).telfAlum = arrayTemporal(i).telfAlum
                                arrayAlumno(contador).emailAlum = arrayTemporal(i).emailAlum
                                arrayAlumno(contador).cursoAlum = arrayTemporal(i).cursoAlum
                                contador = contador + 1

                                Exit For

                            End If
                        Next

                    Next
                    MessageBox.Show("El listado de alumnos ha sido ordenado por apellidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case 4

                    Dim mensaje As String

                    For index As Integer = 0 To arrayAlumno.Length - 2

                        mensaje = mensaje & arrayAlumno(index).codAlum.ToString & vbTab
                        mensaje = mensaje & arrayAlumno(index).nomAlum & vbTab
                        mensaje = mensaje & arrayAlumno(index).apellAlum & vbTab
                        mensaje = mensaje & arrayAlumno(index).telfAlum & vbTab
                        mensaje = mensaje & arrayAlumno(index).emailAlum & vbTab
                        mensaje = mensaje & arrayAlumno(index).cursoAlum & vbTab
                        mensaje = mensaje & vbCrLf

                    Next

                    MessageBox.Show("|Codigo|" + vbTab + "|Nombre|" + vbTab + "|Apellido|" + vbTab + "|Telefono|" + vbTab + "|Email|" + vbTab + vbTab + "|Curso|" & vbCrLf + mensaje)

                Case 5
                    Application.Exit()
            End Select
            TextBox1.Text() = ""

        End If
    End Sub


End Class
