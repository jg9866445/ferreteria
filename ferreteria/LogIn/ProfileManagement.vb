Imports System.Data.SqlClient
Public Class ProfileManagement

    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=FERRETERIA; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados

    Private Sub btnChangeUser_Click(sender As Object, e As EventArgs) Handles btnChangeUser.Click
        If txtUser.Text <> user Then
            conexion.Open()
            comando = conexion.CreateCommand
            comando.CommandText = "SELECT count(*) FROM Usuarios WHERE [user]='" & txtUser.Text & "'"
            lector = comando.ExecuteReader
            lector.Read()
            Dim n As Integer = lector(0)
            lector.Close()

            If n = 0 Then 'Si no existe un usuario con ese nombre de usuario
                comando.CommandText = "UPDATE Usuarios SET [user]='" & txtUser.Text & "' WHERE [user]='" & user & "'"
                comando.ExecuteNonQuery()
                user = txtUser.Text
                Frmmenu.UsuarioToolStripMenuItem.Text = user
                MsgBox("Nombre de Usuario Cambiado Correctamente!", MsgBoxStyle.Information)
            Else
                MsgBox("Ya existe un Usuario con ese nombre. Escriba uno diferente!", MsgBoxStyle.Critical)
            End If
            conexion.Close()
        End If
    End Sub
    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        If pass = txtCurrentPass.Text Then 'Si la contraseña escrita es la contraseña actual
            If txtNewPass.Text.Equals(txtNewPass2.Text) Then 'Si la nueva contraseña es igual a la contraseña de confirmacion
                conexion.Open()
                comando = conexion.CreateCommand
                comando.CommandText = "UPDATE Usuarios SET password='" & txtNewPass.Text & "' WHERE [user]='" & user & "'"
                comando.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Contraseña Cambiada Correctamente!", MsgBoxStyle.Information)
                pass = txtNewPass.Text
                txtNewPass.Text = ""
                txtCurrentPass.Text = ""
                txtNewPass2.Text = ""
            Else
                MsgBox("La nueva contraseña no coincide en ambos campos!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("La contraseña actual escrita es incorrecta!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub ProfileManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = user
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class