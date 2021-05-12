Imports System.Data.SqlClient

Public Class FrmProveedor
    Dim conexion As New SqlConnection(connectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = connectionString
        SqlDataAdapter1.Fill(DataSet11.proveedores)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ProveedoresBindingSource.AddNew()
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT TOP 1 idProveedor FROM proveedores ORDER BY idProveedor DESC"
        lector = comando.ExecuteReader
        lector.Read()
        Dim n As Integer = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
        ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
        txtIdProveedor.Text = n
        lector.Close()
        conexion.Close()
        btnSiguiente.Enabled = False
        btnInicio.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = False

        txtNombre.Enabled = True
        txtDireecion.Enabled = True
        txtCP.Enabled = True
        txtColonia.Enabled = True
        txtRFC.Enabled = True
        txtTelefono.Enabled = True
        txtCeluar.Enabled = True
        btnGrabar.Enabled = True



    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtIdProveedor.Enabled = False
        txtNombre.Enabled = False
        txtDireecion.Enabled = False
        txtCP.Enabled = False
        txtColonia.Enabled = False
        txtRFC.Enabled = False
        txtTelefono.Enabled = False
        txtCeluar.Enabled = False
        btnGrabar.Enabled = False

        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True

        ProveedoresBindingSource.EndEdit()

        SqlDataAdapter1.Update(DataSet11.proveedores)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.proveedores)

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnSiguiente.Enabled = False
        btnInicio.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = False

        txtIdProveedor.Enabled = True
        txtNombre.Enabled = True
        txtDireecion.Enabled = True
        txtCP.Enabled = True
        txtColonia.Enabled = True
        txtRFC.Enabled = True
        txtTelefono.Enabled = True
        txtCeluar.Enabled = True
        btnGrabar.Enabled = True

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ProveedoresBindingSource.MoveFirst()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        ProveedoresBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        ProveedoresBindingSource.MovePrevious()

    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ProveedoresBindingSource.MoveLast()
    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated

        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ProveedoresBindingSource.CancelEdit()
        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True

        txtNombre.Enabled = False
        txtDireecion.Enabled = False
        txtCP.Enabled = False
        txtColonia.Enabled = False
        txtRFC.Enabled = False
        txtTelefono.Enabled = False
        txtCeluar.Enabled = False
        btnGrabar.Enabled = False
        Close()
    End Sub

    Private Sub FrmProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda + "\Ayuda.chm")
        End If
    End Sub
End Class
