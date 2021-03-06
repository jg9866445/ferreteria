Imports System.Data.SqlClient

Public Class FrmProducto
    Dim conexion As New SqlConnection(connectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = connectionString
        SqlDataAdapter1.Fill(DataSet11.productos)
        SqlDataAdapter2.Fill(DataSet11.categoria)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ProductosBindingSource.AddNew()
        conexion.Open()

        comando = conexion.CreateCommand
        comando.CommandText = "SELECT TOP 1 idProducto FROM productos ORDER BY idProducto DESC"
        lector = comando.ExecuteReader
        lector.Read()
        Dim n As Integer = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
        ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
        txtIdProductos.Text = n
        lector.Close()
        conexion.Close()
        btnSiguiente.Enabled = False
        btnInicio.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        cboCategoria.Enabled = True

        txtNombre.Enabled = True
        txtDetalleP.Enabled = True
        txtPrecio.Enabled = True
        txtCantidad.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        btnGrabar.Enabled = True

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtIdProductos.Enabled = True
        txtNombre.Enabled = True
        txtDetalleP.Enabled = True
        txtPrecio.Enabled = True
        txtCantidad.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        btnGrabar.Enabled = True
        cboCategoria.Enabled = True


    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        ProductosBindingSource.Current("idCategoria") = cboCategoria.SelectedValue

        txtIdProductos.Enabled = False
        txtNombre.Enabled = False
        txtDetalleP.Enabled = False
        txtPrecio.Enabled = False
        txtCantidad.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        btnGrabar.Enabled = False
        cboCategoria.Enabled = False

        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True

        ProductosBindingSource.EndEdit()

        SqlDataAdapter1.Update(DataSet11.productos)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.productos)
    End Sub


    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ProductosBindingSource.MoveFirst()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ProductosBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ProductosBindingSource.MovePrevious()

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ProductosBindingSource.MoveLast()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ProductosBindingSource.CancelEdit()
        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True
        cboCategoria.Enabled = False

        txtNombre.Enabled = False
        txtDetalleP.Enabled = False
        txtPrecio.Enabled = False
        txtCantidad.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        btnGrabar.Enabled = False
        Close()
    End Sub

    Private Sub FrmProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda + "Ayuda.chm")
        End If
    End Sub

    Private Sub btnImportardesdeExcel_Click(sender As Object, e As EventArgs) Handles btnImportardesdeExcel.Click
        DataSet11.Clear()
        Importar.ShowDialog()
        SqlDataAdapter1.Fill(DataSet11.productos)
    End Sub
End Class