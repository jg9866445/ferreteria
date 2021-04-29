Imports System.Data.SqlClient
Public Class FrmDevolucion
    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=FERRETERIA; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction
    Private Sub FrmDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaD.Text = Now.Month & "/" & Now.Day & "/" & Now.Year
        cboNombreEmpleado.Enabled = False
        btnGuardar.Enabled = False
        btnBuscar.Enabled = False

        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select * From personal"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreEmpleado.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboNombreEmpleado.Enabled = True
        btnGuardar.Enabled = True
        btnBuscar.Enabled = True
        txtIdVenta.Enabled = True
        txtMotivo.Enabled = True
        btnNuevo.Enabled = False

        comando.CommandText = "Select count(*) From devoluciones" 'SELECT TOP, SELECT BOTTOM 
        lector = comando.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector(0)
        lector.Close()

        If aux > 0 Then
            comando.CommandText = "SELECT TOP 1 idDevolucion FROM devoluciones ORDER BY idDevolucion DESC"
            lector = comando.ExecuteReader
            lector.Read()
            Dim n = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
            ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
            txtIdDevolucion.Text = n
            lector.Close()
        Else
            txtIdDevolucion.Text = ""
        End If
    End Sub

    Private Sub cboNombreEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreEmpleado.SelectedIndexChanged
        comando.CommandText = "Select * from personal where nombre='" & cboNombreEmpleado.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdPersonal.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvDevolucion.Rows.Clear()
        comando.CommandText = "select * from ventas where idventa = " & txtIdVenta.Text & ""
        lector = comando.ExecuteReader()

        If lector.Read() Then
            lector.Close()
            comando.CommandText = "select * from ventas as v where v.idventa = " & txtIdVenta.Text & " and v.edoVenta = 'r'"
            lector = comando.ExecuteReader()

            If lector.Read() Then
                lector.Close()
                comando.CommandText = "select per.nombre, v.fecha, v.subTotal, v.iva, v.total from ventas as v inner join personal as per on v.idventa = v.idventa where idventa = " & txtIdVenta.Text & ""
                lector = comando.ExecuteReader()
                lector.Read()
                txtNombreEmpleado.Text = lector(0)
                txtFechaV.Text = lector(1)
                txtSubtotal.Text = lector(2)
                txtIva.Text = lector(3)
                txtTotal.Text = lector(4)
                lector.Close()

                comando.CommandText = "select pro.idproducto, pro.nombreProducto, det.precio, det.cantidad, det.cantidad*det.precio from detalleVenta as det inner join productos as pro on pro.idProducto = det.idProducto where det.idventa = " & txtIdVenta.Text & ""
                lector = comando.ExecuteReader()
                While lector.Read
                    dgvDevolucion.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                End While
                lector.Close()
            Else
                lector.Close()
                MsgBox("Esta devolucion ya ha sido cancelada")
            End If

        Else
            lector.Close()
            MsgBox("La venta no existe")
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        transaction = conexion.BeginTransaction("SimpleTransaction")
        comando.Connection = conexion
        comando.Transaction = transaction

        btnGuardar.Enabled = False
        btnNuevo.Enabled = True

        txtMotivo.Text = txtMotivo.Text

        'SE INSERTA LA COMPRA CON EL IDCOMPRA SIN NINGUN VALOR ASIGNADO, DEBIDO A QUE ESTE SE ASIGNA AUTOMATICAMENTE CON LA PROPIEDAD IDENTITY
        Dim r As String

        r = "insert into devoluciones values(" & Val(txtIdPersonal.Text) & "," & Val(txtIdVenta.Text) & ",'" & txtFechaD.Text & "','" & txtMotivo.Text & "')"
        comando.CommandText = r
        comando.ExecuteNonQuery()

        For i = 0 To dgvDevolucion.Rows.Count - 2
            Dim idProducto = CInt(dgvDevolucion.Item(0, i).Value)
            Dim Cantidad = CDbl(dgvDevolucion.Item(3, i).Value)
            comando.CommandText = "Update Productos SET cantidad=cantidad+" & Cantidad & " WHERE idProducto=" & idProducto
            comando.ExecuteNonQuery()
        Next

        comando.CommandText = "Update ventas SET edoVenta = 'c' where idventa =" & txtIdVenta.Text
        comando.ExecuteNonQuery()
        If MsgBox("desea ejecutar transaccion", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
            transaction.Commit()
        Else
            transaction.Rollback()
            MsgBox("Transaccion Cancelada")
        End If

        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        conexion.Close()
    End Sub

    Private Sub FrmDevolucion_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub

    Private Sub FrmDevolucion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("D:\je_ss\Escritorio\tareas\SIS. INTEGRALES\ferreteria\ferreteria\Ayuda.chm")
        End If
    End Sub
End Class