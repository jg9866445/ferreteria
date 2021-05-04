Imports System.Configuration
Imports System.Data.SqlClient
Public Class FrmConsultaDevoluciones
    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ferreteria.My.MySettings.FERRETERIAConnectionString").ConnectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction

    Private Sub FrmConsultaDevoluciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fechaInicial = dtpFechaInicial.Value.Month & "/" & dtpFechaInicial.Value.Day & "/" & dtpFechaInicial.Value.Year
        Dim fechaFinal = dtpFechaFinal.Value.Month & "/" & dtpFechaFinal.Value.Day & "/" & dtpFechaFinal.Value.Year

        comando.CommandText = "select d.idDevolucion, d.fecha, p.nombre, v.idventa, d.motivo from devoluciones as d inner join personal as p on d.idPersonal = p.idPersonal inner join ventas as v on d.idventa = v.idventa where d.fecha BETWEEN '" + fechaInicial + "' AND '" + fechaFinal + "'"
        lector = comando.ExecuteReader
        While lector.Read()
            dgvDevF.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub
End Class