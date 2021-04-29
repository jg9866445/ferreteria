Imports System.Data.SqlClient
Public Class FrmBitacora
    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=master; Integrated security=true")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados
    Dim transaction As SqlTransaction

    Private Sub FrmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand

        dgvBitacora.Rows.Clear()
        comando.CommandText = "select * from bitacora"

        lector = comando.ExecuteReader()
        While lector.Read
            dgvBitacora.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub FrmBitacora_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub
End Class