Imports System.Configuration
Imports System.Data.SqlClient
Public Class FrmConsultaDevolucionesPersonal
    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ferreteria.My.MySettings.FERRETERIAConnectionString").ConnectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction
    Private Sub FrmConsultaDevolucionesPersonal_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select * From personal"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombrePersonal.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvConsultaD.Rows.Clear()
        comando.CommandText = "select d.* from devoluciones as d inner join personal as p on d.idPersonal = p.idPersonal where p.nombre='" & cboNombrePersonal.Text & "'"
        lector = comando.ExecuteReader()

        While lector.Read
            dgvConsultaD.Rows.Add(lector(0), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub cboNombrePersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombrePersonal.SelectedIndexChanged
        comando.CommandText = "Select * from personal where nombre='" & cboNombrePersonal.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdPersonal.Text = lector(0)
        txtDireccion.Text = lector(2)
        txtCp.Text = lector(3)
        txtColonia.Text = lector(4)
        txtTelefono.Text = lector(5)
        txtCelular.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub FrmConsultaDevolucionesPersonal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub
End Class