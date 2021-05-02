Imports System.Data.SqlClient
Public Class FrmCategoria
    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=FERRETERIA; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.categoria)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        CategoriaBindingSource.AddNew()
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT TOP 1 idCategoria FROM categoria ORDER BY idCategoria DESC"
        lector = comando.ExecuteReader
        lector.Read()
        Dim n As Integer = lector(0) + 1 'OBTENGO ULTIMA ID Y LA INCREMENTO
        ' SI LA ULTIMA FUE ID = 5, SERA 5+1 = 6
        txtidCategoria.Text = n
        lector.Close()
        conexion.Close()
        btnSiguiente.Enabled = False
        btnInicio.Enabled = False
        btnAnterior.Enabled = False
        btnUltimo.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnSalir.Enabled = True

        txtNombreCategoria.Enabled = True
        txtDetalleCategoria.Enabled = True

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtidCategoria.Enabled = True
        txtNombreCategoria.Enabled = True
        txtDetalleCategoria.Enabled = True
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        txtidCategoria.Enabled = False
        txtNombreCategoria.Enabled = False
        txtDetalleCategoria.Enabled = False

        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True

        CategoriaBindingSource.EndEdit()

        SqlDataAdapter1.Update(DataSet11.categoria)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.categoria)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        CategoriaBindingSource.MoveFirst()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        CategoriaBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        CategoriaBindingSource.MovePrevious()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        CategoriaBindingSource.MoveLast()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        CategoriaBindingSource.CancelEdit()
        btnSiguiente.Enabled = True
        btnInicio.Enabled = True
        btnAnterior.Enabled = True
        btnUltimo.Enabled = True
        btnModificar.Enabled = True
        btnNuevo.Enabled = True
        btnGrabar.Enabled = False
        btnSalir.Enabled = False

        txtNombreCategoria.Enabled = False
        txtDetalleCategoria.Enabled = False
        Close()
    End Sub

    Private Sub FrmCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("D:\je_ss\Escritorio\tareas\SIS. INTEGRALES\ferreteria\ferreteria\Ayuda.chm")
        End If
    End Sub
End Class