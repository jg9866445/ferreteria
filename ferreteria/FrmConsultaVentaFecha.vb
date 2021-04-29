Imports System.Data.SqlClient
Public Class FrmConsultaVentaFecha
    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=FERRETERIA; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction
    Private Sub FrmConsultaVentaFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        Dim fechaInicial = dtpFechaInicial.Value.Month & "/" & dtpFechaInicial.Value.Day & "/" & dtpFechaInicial.Value.Year
        Dim fechaFinal = dtpFechaFinal.Value.Month & "/" & dtpFechaFinal.Value.Day & "/" & dtpFechaFinal.Value.Year

        comando.CommandText = "select v.idventa , p.nombre  , v.subTotal, v.iva , v.total, v.fecha,v.edoVenta from ventas as v inner join personal as p on v.idPersonal = p.idPersonal where v.fecha BETWEEN '" + fechaInicial + "' AND '" + fechaFinal + "'"
        lector = comando.ExecuteReader
        While lector.Read()

            dgwConsultaVenta.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()
    End Sub

    Private Sub dgwConsultaVenta_Click(sender As Object, e As EventArgs) Handles dgwConsultaVenta.Click
        dgvConsultaDet.Rows.Clear()
        comando.CommandText = "select p.nombreProducto, d.cantidad, d.precio from detalleVenta as d inner join productos as p on d.idProducto = p.idProducto where d.idVenta =" & dgwConsultaVenta.CurrentRow.Cells(0).Value

        lector = comando.ExecuteReader()
        While lector.Read
            dgvConsultaDet.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub
End Class