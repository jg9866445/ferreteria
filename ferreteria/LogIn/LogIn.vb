Imports System.Configuration
Imports System.Data.SqlClient
Public Class LogIn
    Dim conexion As New SqlConnection(connectionString)

    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        logInUser()
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown, txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            logInUser()
        End If
    End Sub
    Private Sub logInUser()
        Dim n As Integer
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT count(*) FROM Usuarios WHERE [user]='" & txtUser.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        n = lector(0)
        lector.Close()
        comando.CommandText = "SELECT password, privilege FROM Usuarios WHERE [user]='" & txtUser.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        If n <> 0 Then 'Si existe un usuario con ese username
            If txtPass.Text.Equals(lector(0)) Then 'Si la password ingresada es correcta
                user = txtUser.Text
                pass = txtPass.Text
                txtUser.Text = ""
                txtPass.Text = ""
                privilege = lector(1)
                Frmmenu.ShowDialog()
            Else 'Si la password ingresada no es correcta
                MsgBox("La contraseña ingresada es incorrecta!", MsgBoxStyle.Critical)
            End If
        Else 'Si no existe un usuario con ese username
            MsgBox("El usuario ingresado no es valido!", MsgBoxStyle.Critical)
        End If
        lector.Close()
        conexion.Close()
    End Sub
End Class