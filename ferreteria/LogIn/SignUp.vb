Imports System.Data.SqlClient
Public Class SignUp

    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=FERRETERIA; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados 
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPrivilegio.SelectedIndex = 0
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT count(*) FROM Usuarios WHERE [user]='" & txtUser.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        Dim n As Integer = lector(0)
        lector.Close()
        If n = 0 Then 'Si NO hay un usuario registrado con ese username
            If txtPass.Text.Equals(txtPass2.Text) Then
                comando.CommandText = "INSERT INTO Usuarios VALUES('" & txtUser.Text & "','" & txtPass.Text & "','" & cboPrivilegio.SelectedItem & "')"
                comando.ExecuteNonQuery()
                txtPass.Text = ""
                txtPass2.Text = ""
                txtUser.Text = ""
            Else
                MsgBox("Las contraseñas NO coinciden!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Ya existe un usuario con ese nombre!", MsgBoxStyle.Critical)
        End If
        conexion.Close()
    End Sub
End Class