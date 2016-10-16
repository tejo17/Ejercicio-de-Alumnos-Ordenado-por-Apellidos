Public Class consultaform

    Private Sub consultaform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscod.Text() = ""
        busCod.Text() = ""
        busape.Text() = ""
        busTel.Text() = ""
        busEma.Text() = ""
        busCur.Text() = ""
    End Sub

    Private Sub buttonBusqueda_Click(sender As Object, e As EventArgs) Handles buttonBusqueda.Click
        Dim exist As Boolean
        Dim nombre = inputbusq.Text()
        If inputbusq.Text() = "" Then
            MessageBox.Show("Debes introducir un nombre")
        Else
            For Each elemento As Alumno In arrayAlumno
                If elemento.nomAlum = nombre Then
                    exist = True
                    busCod.Text() = elemento.codAlum
                    busNom.Text() = elemento.nomAlum
                    busApe.Text() = elemento.apellAlum
                    busTel.Text() = elemento.telfAlum
                    busEma.Text() = elemento.emailAlum
                    busCur.Text() = elemento.cursoAlum
                    Exit For
                Else exist = False
                End If
            Next

            If exist = False Then
                MessageBox.Show("El nombre del alumno no existe")
            End If

        End If
    End Sub

    Private Sub buttonVolver_Click(sender As Object, e As EventArgs) Handles buttonVolver.Click
        Me.Hide()
        formAlumno.Show()
    End Sub
End Class