Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuarios(,) As String = {{"Abel", "Pedro", "Juan", "Maria"}, {"Abel1", "Pedro1", "Juan1", "Maria1"}}
        Dim user As String = inputUser.Text()
        Dim pass As String = inputPass.Text()


        For i As Integer = 0 To (usuarios.GetLength(1)) - 1
            If usuarios(0, i) = user Then
                If usuarios(1, i) = pass Then
                    Module1.userName = usuarios(0, i)
                    Me.Hide()
                    formAlumno.Show()
                Else
                    errorLogin.Visible = True
                End If
            End If
        Next
    End Sub

End Class