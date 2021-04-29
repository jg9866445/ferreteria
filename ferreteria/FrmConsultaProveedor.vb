Imports System.Data.SqlClient
Public Class FrmConsultaProveedor
    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=FERRETERIA; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction
    Private Sub FrmConsultaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select * From proveedores"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreProve.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        dgwConsultaCom.Rows.Clear()
        comando.CommandText = "select c.* from compras as c inner join proveedores as prov on c.idProveedor = prov.idProveedor where prov.nombre='" & cboNombreProve.Text & "'"

        lector = comando.ExecuteReader()
        While lector.Read
            dgwConsultaCom.Rows.Add(lector(0), lector(2), lector(3), lector(4), lector(5))
        End While
        lector.Close()
    End Sub

    Private Sub cboNombreProve_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreProve.SelectedIndexChanged
        comando.CommandText = "Select * from proveedores where nombre='" & cboNombreProve.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtproveedor.Text = lector(0)
        txtRfc.Text = lector(2)
        txtDomicilio.Text = lector(3)
        txtTelefono.Text = lector(5)
        txtCelular.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub FrmConsultaProveedor_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()

    End Sub

    Private Sub dgwConsultaCom_Click(sender As Object, e As EventArgs) Handles dgwConsultaCom.Click
        dgvConsultaDet.Rows.Clear()
        comando.CommandText = "select p.nombreProducto, d.cantidad, d.precio from detalleCompra as d inner join productos as p on d.idProducto = p.idProducto where d.idCompra =" & dgwConsultaCom.CurrentRow.Cells(0).Value

        lector = comando.ExecuteReader()
        While lector.Read
            dgvConsultaDet.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub
End Class
