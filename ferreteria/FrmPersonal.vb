Imports System.Data.SqlClient

Public Class FrmPersonal
    Dim conexion As New SqlConnection(connectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Private Sub FrmPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = connectionString
        SqlDataAdapter1.Fill(DataSet11.personal)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        PersonalBindingSource.AddNew()
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT TOP 1 idPersonal FROM personal ORDER BY idPersonal DESC"
        lector = comando.ExecuteReader
        lector.Read()
        Dim n As Integer = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
        ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
        txtIdPersonal.Text = n
        lector.Close()
        conexion.Close()
        btnSiguiente.Enabled = False
        btnInicio.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        txtNombre.Enabled = True
        txtDireccion.Enabled = True
        txtCp.Enabled = True
        txtColonia.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        btnGrabar.Enabled = True


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnSiguiente.Enabled = False
        btnInicio.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = False

        txtIdPersonal.Enabled = True
        txtNombre.Enabled = True
        txtDireccion.Enabled = True
        txtCp.Enabled = True
        txtColonia.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        btnGrabar.Enabled = True

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtIdPersonal.Enabled = False
        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        txtCp.Enabled = False
        txtColonia.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        btnGrabar.Enabled = False

        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True

        PersonalBindingSource.EndEdit()

        SqlDataAdapter1.Update(DataSet11.personal)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.personal)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        PersonalBindingSource.CancelEdit()
        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True
        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        txtCp.Enabled = False
        txtColonia.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        btnGrabar.Enabled = False
        Close()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        PersonalBindingSource.MoveFirst()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        PersonalBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        PersonalBindingSource.MovePrevious()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        PersonalBindingSource.MoveLast()
    End Sub


    Private Sub SqlDataAdapter1_RowUpdated(sender As Object, e As SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf &
                                e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub FrmPersonal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda + "Ayuda.chm")
        End If
    End Sub


End Class