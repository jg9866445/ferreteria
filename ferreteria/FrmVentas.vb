Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmVentas
    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=FERRETERIA; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Now.Month & "/" & Now.Day & "/" & Now.Year
        cboNombreEmpleado.Enabled = False
        cboNombreProducto.Enabled = False
        btnAgregar.Enabled = False
        txtCantidad.Enabled = False
        txtEdoVenta.Enabled = False
        btnGuardar.Enabled = False
        cboDescuento.Enabled = False

        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select * From personal"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreEmpleado.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * From productos"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreProducto.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboNombreEmpleado.Enabled = True
        cboNombreProducto.Enabled = True
        btnAgregar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False

        comando.CommandText = "Select count(*) From Ventas" 'SELECT TOP, SELECT BOTTOM 
        lector = comando.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector(0)
        lector.Close()

        If aux > 0 Then
            comando.CommandText = "SELECT TOP 1 idventa FROM Ventas ORDER BY idventa DESC"
            lector = comando.ExecuteReader
            lector.Read()
            Dim n = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
            ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
            txtIdVenta.Text = n
            lector.Close()
        Else
            txtIdVenta.Text = ""
        End If
    End Sub

    Private Sub cboNombreEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreEmpleado.SelectedIndexChanged
        comando.CommandText = "Select * from personal where nombre='" & cboNombreEmpleado.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtPersonal.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub cboNombreProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreProducto.SelectedIndexChanged
        comando.CommandText = "Select * from productos where nombreProducto='" & cboNombreProducto.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtProducto.Text = lector(0)
        txtDetalleProducto.Text = lector(2)
        txtPrecio.Text = lector(4)
        txtCantidad.Value = 0
        txtCantidad.Maximum = lector(5)
        lector.Close()
        cboDescuento.Enabled = True
        txtCantidad.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim subtotal = CDbl(txtPrecio.Text) * CDbl(txtCantidad.Text)
        Dim iva = subtotal * 0.16
        Dim descuento = subtotal * (CDbl(cboDescuento.Text) / 100)
        Dim tot = subtotal - descuento
        Dim tota = tot + iva
        Dim Total = tota

        comando.CommandText = "Select count(*) From Ventas"
        txtNumFactura.Text = CStr(comando.ExecuteScalar() + 1)

        txtSubtotal.Text = txtSubtotal.Text + subtotal
        txtIva.Text = txtIva.Text + iva
        txtdes.Text = txtdes.Text + descuento
        txtTotal.Text = txtTotal.Text + Total

        dgvVenta.Rows.Add(txtProducto.Text, cboNombreProducto.Text, txtPrecio.Text, txtCantidad.Text, CDbl(txtPrecio.Text) * CDbl(txtCantidad.Text), descuento)
        btnAtrasRejilla.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            transaction = conexion.BeginTransaction("SimpleTransaction")
            comando.Connection = conexion
            comando.Transaction = transaction

            btnGuardar.Enabled = False
            btnNuevo.Enabled = True

            Dim idProducto As String
            Dim cantidad, precio As Double

            'SE INSERTA LA COMPRA CON EL IDCOMPRA SIN NINGUN VALOR ASIGNADO, DEBIDO A QUE ESTE SE ASIGNA AUTOMATICAMENTE CON LA PROPIEDAD IDENTITY
            Dim r As String
            Dim idc As Integer

            r = "insert into Ventas(idPersonal, subTotal, iva, descuento, total, fecha, numFactura, edoVenta) values(" & CInt(txtPersonal.Text) & "," & CDbl(txtSubtotal.Text) & ", " & CDbl(txtIva.Text) & ", " & CDbl(txtdes.Text) & "," & CDbl(txtTotal.Text) & ",'" & (txtFecha.Text) & "'," & CDbl(txtNumFactura.Text) & ",'" & CChar(txtEdoVenta.Text) & "')"
            comando.CommandText = r
            comando.ExecuteNonQuery()

            For i = 0 To dgvVenta.Rows.Count - 2

                idProducto = CInt(dgvVenta.Item(0, i).Value)
                cantidad = CDbl(dgvVenta.Item(3, i).Value)
                precio = CDbl(dgvVenta.Item(2, i).Value)

                'OBTENER EL ULTIMO REGISTRO DE LA COMPRA QUE SE ACABA DE INSERTAR

                If txtIdVenta.Text = "" Then 'PRIMERA COMPRA DESPUES DEL TRASPASO, SIN PRESENCIA DE REGISTROS EN LA TABLA
                    comando.CommandText = "SELECT TOP 1 idventa FROM Ventas ORDER BY idventa DESC"
                    lector = comando.ExecuteReader
                    lector.Read()
                    idc = lector(0)
                    lector.Close()
                Else
                    idc = txtIdVenta.Text
                End If

                r = "insert into detalleVenta values(" & idc & "," & idProducto & "," & cantidad & "," & precio & ")"
                comando.CommandText = r
                comando.ExecuteNonQuery()

                comando.CommandText = "Update Productos SET cantidad=cantidad-" & cantidad & " WHERE idProducto=" & idProducto
                comando.ExecuteNonQuery()
            Next

            If MsgBox("desea ejecutar transaccion", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
            Else
                transaction.Rollback()
                MsgBox("Transaccion Cancelada")
            End If

        Catch ex As Exception
            Dim conexion2 As New SqlConnection("Data Source=.;Initial Catalog= master;Integrated Security = Yes")
            Dim comando2 As New SqlCommand
            conexion2.Open()
            comando2 = conexion2.CreateCommand
            comando2.Connection = conexion2
            Dim R = "insert into bitacora (fechaHora,formulario,numError, Descripcion) VALUES ( '" & Now.Date.ToString & "','Ventas' ,'" & ex.Source.ToString & "','" & ex.Message.Replace("'", " ").ToString & "')"
            comando2.CommandText = R
            comando2.ExecuteNonQuery()
            conexion2.Close()
            MsgBox("Error de " & ex.Message.Replace("'", " ").ToString)
            MsgBox("Error enviado a la bitacora")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        conexion.Close()
    End Sub

    Private Sub FrmVentas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub

    Private Sub FrmVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("D:\je_ss\Escritorio\tareas\SIS. INTEGRALES\ferreteria\ferreteria\Ayuda.chm")
        End If
    End Sub

    Private Sub btnAtrasRejilla_Click(sender As Object, e As EventArgs) Handles btnAtrasRejilla.Click
        Dim subtotal = txtSubtotal.Text - (CDbl(dgvVenta(2, dgvVenta.CurrentRow.Index - 1).Value) * CDbl(dgvVenta(3, dgvVenta.CurrentRow.Index - 1).Value))
        Dim iva = subtotal * 0.16
        Dim descuento As Single = Math.Round(CSng(txtdes.Text), 2) - Math.Round(CSng(dgvVenta(5, dgvVenta.CurrentRow.Index - 1).Value), 2)
        Dim Total = (subtotal + iva) - descuento
        dgvVenta.Rows.RemoveAt(dgvVenta.CurrentRow.Index - 1)
        dgvVenta.Refresh()
        txtSubtotal.Text = subtotal
        txtIva.Text = iva
        txtdes.Text = descuento
        txtTotal.Text = Total
        If dgvVenta.RowCount - 1 = 0 Then
            btnAtrasRejilla.Enabled = False
        End If
    End Sub
End Class