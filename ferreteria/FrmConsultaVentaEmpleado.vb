Imports System.Data.SqlClient
Public Class FrmConsultaVentaEmpleado
    Dim conexion As New SqlConnection(connectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Private Sub FrmConsultaVentaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dgvConsultaVenta.Rows.Clear()
        comando.CommandText = "select v.* from ventas as v inner join personal as per on v.idPersonal = per.idPersonal where per.nombre='" & cboNombrePersonal.Text & "'"

        lector = comando.ExecuteReader()
        While lector.Read
            dgvConsultaVenta.Rows.Add(lector(0), lector(6), lector(2), lector(3), lector(4), lector(5), lector(7), lector(8))
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

    Private Sub FrmConsultaVentaEmpleado_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub

    Private Sub dgvConsultaVenta_Click(sender As Object, e As EventArgs) Handles dgvConsultaVenta.Click
        dgvConsultaDetVenta.Rows.Clear()
        comando.CommandText = "select p.nombreProducto, d.cantidad, d.precio from detalleVenta as d inner join productos as p on d.idProducto = p.idProducto where d.idVenta =" & dgvConsultaVenta.CurrentRow.Cells(0).Value

        lector = comando.ExecuteReader()
        While lector.Read
            dgvConsultaDetVenta.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub
End Class