Imports System.Data.SqlClient

Public Class FrmPersonal
    Private Sub FrmPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.personal)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        PersonalBindingSource.AddNew()
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
        Me.Dispose()
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
            System.Diagnostics.Process.Start("D:\je_ss\Escritorio\tareas\SIS. INTEGRALES\ferreteria\ferreteria\Ayuda.chm")
        End If
    End Sub
End Class