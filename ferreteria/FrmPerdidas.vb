Imports System.Data.SqlClient
Public Class FrmPerdidas
    Dim conexion As New SqlConnection(connectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction
    Private Sub FrmPerdidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaP.Text = Now.Month & "/" & Now.Day & "/" & Now.Year
        cboNombreProducto.Enabled = False
        btnAgregar.Enabled = False
        txtCantidadP.Enabled = False
        txtConceptoP.Enabled = False
        btnGuardar.Enabled = False

        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select * From productos"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreProducto.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboNombreProducto.Enabled = True
        btnAgregar.Enabled = True
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False

        comando.CommandText = "Select count(*) From perdidas" 'SELECT TOP, SELECT BOTTOM 
        lector = comando.ExecuteReader
        lector.Read()
        Dim aux As Integer
        aux = lector(0)
        lector.Close()

        If aux > 0 Then
            comando.CommandText = "SELECT TOP 1 idPerdida FROM perdidas ORDER BY idPerdida DESC"
            lector = comando.ExecuteReader
            lector.Read()
            Dim n = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
            ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
            txtIdperdida.Text = n
            lector.Close()
        Else
            txtIdperdida.Text = ""
        End If
    End Sub

    Private Sub cboNombreProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreProducto.SelectedIndexChanged
        comando.CommandText = "Select * from productos where nombreProducto='" & cboNombreProducto.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtProducto.Text = lector(0)
        txtDetalleProducto.Text = lector(2)
        txtPrecio.Text = lector(3)
        lector.Close()
        txtCantidadP.Enabled = True
        txtConceptoP.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dgvPerdida.Rows.Add(txtProducto.Text, cboNombreProducto.Text, txtDetalleProducto.Text, txtPrecio.Text, txtConceptoP.Text, txtCantidadP.Text)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        transaction = conexion.BeginTransaction("SimpleTransaction")
        comando.Connection = conexion
        comando.Transaction = transaction

        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        txtCantidadP.Enabled = False
        txtConceptoP.Enabled = False

        'SE INSERTA LA COMPRA CON EL IDCOMPRA SIN NINGUN VALOR ASIGNADO, DEBIDO A QUE ESTE SE ASIGNA AUTOMATICAMENTE CON LA PROPIEDAD IDENTITY
        Dim r As String
        Dim idc As Integer

        r = "insert into perdidas(concepto,fecha) values('" & txtConceptoP.Text & "', '" & (txtFechaP.Text) & "')"
        comando.CommandText = r
        comando.ExecuteNonQuery()

        For i = 0 To dgvPerdida.Rows.Count - 2

            Dim idProducto = CInt(dgvPerdida.Item(0, i).Value)
            Dim cantidadPerdida = CInt(dgvPerdida.Item(5, i).Value)
            Dim precio = CDbl(dgvPerdida.Item(3, i).Value)

            'OBTENER EL ULTIMO REGISTRO DE LA COMPRA QUE SE ACABA DE INSERTAR

            If txtIdperdida.Text = "" Then 'PRIMERA COMPRA DESPUES DEL TRASPASO, SIN PRESENCIA DE REGISTROS EN LA TABLA
                comando.CommandText = "SELECT TOP 1 idPerdida FROM perdidas ORDER BY idPerdida DESC"
                lector = comando.ExecuteReader
                lector.Read()
                idc = lector(0)
                lector.Close()
            Else
                idc = txtIdperdida.Text
            End If

            r = "insert into detallePerdida values(" & idc & "," & idProducto & ", " & cantidadPerdida & ", " & precio & ")"
            comando.CommandText = r
            comando.ExecuteNonQuery()

            comando.CommandText = "Update Productos SET cantidad=cantidad-" & cantidadPerdida & " WHERE idProducto=" & idProducto
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

    Private Sub FrmPerdidas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        dgvPerdida.Rows.Clear()
        conexion.Close()
    End Sub

    Private Sub FrmPerdidas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda + "Ayuda.chm")
        End If
    End Sub
End Class