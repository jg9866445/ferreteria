Imports System.Configuration
Imports System.Data.SqlClient
Public Class FrmCompra

    Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ferreteria.My.MySettings.FERRETERIAConnectionString").ConnectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction


    Private Sub FrmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = Now.Month & "/" & Now.Day & "/" & Now.Year
        cboNombreEmpleado.Enabled = False
        cboNombreProducto.Enabled = False
        cboNombreProve.Enabled = False
        btnAgregar.Enabled = False
        txtCantidad.Enabled = False
        btnGuardar.Enabled = False

        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select * From proveedores"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreProve.Items.Add(lector(1))
        End While
        lector.Close()

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
        cboNombreProve.Enabled = True
        btnAgregar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False

        comando.CommandText = "Select count(*) From Compras" 'SELECT TOP, SELECT BOTTOM 
        lector = comando.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector(0)
        lector.Close()

        If aux > 0 Then
            comando.CommandText = "SELECT TOP 1 idCompras FROM Compras ORDER BY idCompras DESC"
            lector = comando.ExecuteReader
            lector.Read()
            Dim n = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
            ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
            txtIdCompra.Text = n
            lector.Close()
        Else
            txtIdCompra.Text = ""
        End If
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
        txtPrecio.Enabled = True
        lector.Close()
        txtCantidad.Enabled = True

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim subtotal = CDbl(txtPrecio.Text) * CDbl(txtCantidad.Text)
        Dim IVA = subtotal * 0.16
        Dim Total = subtotal + IVA
        txtSubtotal.Text = txtSubtotal.Text + subtotal
        txtIva.Text = txtIva.Text + IVA
        txtTotal.Text = txtTotal.Text + Total

        dgwCompra.Rows.Add(txtProducto.Text, cboNombreProducto.Text, txtPrecio.Text, txtCantidad.Text, CDbl(txtPrecio.Text) * CDbl(txtCantidad.Text))
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

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

        r = "insert into Compras(idProveedor,subTotal,iva,total,fecha) values(" & CInt(txtproveedor.Text) & "," & CDbl(txtSubtotal.Text) & ", " & CDbl(txtIva.Text) & "," & CDbl(txtTotal.Text) & ",'" & (txtFecha.Text) & "')"
        comando.CommandText = r
        comando.ExecuteNonQuery()

        For i = 0 To dgwCompra.Rows.Count - 2

            idProducto = CInt(dgwCompra.Item(0, i).Value)
            cantidad = CDbl(dgwCompra.Item(3, i).Value)
            precio = CDbl(dgwCompra.Item(2, i).Value)

            'OBTENER EL ULTIMO REGISTRO DE LA COMPRA QUE SE ACABA DE INSERTAR

            If txtIdCompra.Text = "" Then 'PRIMERA COMPRA DESPUES DEL TRASPASO, SIN PRESENCIA DE REGISTROS EN LA TABLA
                comando.CommandText = "SELECT TOP 1 idCompras FROM compras ORDER BY idCompras DESC"
                lector = comando.ExecuteReader
                lector.Read()
                idc = lector(0)
                lector.Close()
            Else
                idc = txtIdCompra.Text
            End If

            r = "insert into detalleCompra values(" & idc & "," & idProducto & "," & cantidad & "," & precio & ")"
            comando.CommandText = r
            comando.ExecuteNonQuery()

            comando.CommandText = "Update Productos SET cantidad=cantidad+" & cantidad & " WHERE idProducto=" & idProducto
            comando.ExecuteNonQuery()
        Next

        If MsgBox("desea ejecutar transaccion", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
            transaction.Commit()
        Else
            transaction.Rollback()
            MsgBox("Transaccion Cancelada")
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        conexion.Close()

    End Sub

    Private Sub FrmCompra_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub

    Private Sub FrmCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("D:\je_ss\Escritorio\tareas\SIS. INTEGRALES\ferreteria\ferreteria\Ayuda.chm")
        End If
    End Sub
End Class