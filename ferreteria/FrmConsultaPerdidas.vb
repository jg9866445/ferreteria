Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmConsultaPerdidas
    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ferreteria.My.MySettings.FERRETERIAConnectionString").ConnectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction
    Private Sub FrmConsultaPerdidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim fechaInicial = dtpFechaInicial.Value.Month & "/" & dtpFechaInicial.Value.Day & "/" & dtpFechaInicial.Value.Year
        Dim fechaFinal = dtpFechaFinal.Value.Month & "/" & dtpFechaFinal.Value.Day & "/" & dtpFechaFinal.Value.Year
        comando.CommandText = "select * from perdidas as p where p.fecha BETWEEN '" + fechaInicial + "' AND '" + fechaFinal + "'"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwConsultaPerdida.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()

    End Sub

    Private Sub dgwConsultaPerdida_Click(sender As Object, e As EventArgs) Handles dgwConsultaPerdida.Click
        dgvConsultaDet.Rows.Clear()
        comando.CommandText = "select pr.nombreProducto,d.CantidadPerdida, d.precio,(d.precio * d.CantidadPerdida) as importe from perdidas as p inner join detallePerdida as d on p.idPerdida=d.idPerdida inner join productos as pr on d.idProducto = pr.idProducto where p.idPerdida=" & dgwConsultaPerdida.CurrentRow.Cells(0).Value

        lector = comando.ExecuteReader()
        While lector.Read
            dgvConsultaDet.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        lector.Close()
    End Sub


End Class