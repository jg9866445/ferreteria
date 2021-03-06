Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class FrmReporteVenPer
    Dim conexion = New SqlConnection(connectionString)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados

    Private Sub FrmReporteVenPer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()

        comando = conexion.CreateCommand

        comando.CommandText = "Select * From personal"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombrePer.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        comando.CommandText = "select * from personal as per  where per.nombre='" & cboNombrePer.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        Dim id = lector(0).ToString
        lector.Close()


        Dim conexion2 = New SqlConnection(connectionString)

        conexion2.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion2
        Adaptador.SelectCommand.CommandText = "ventasPersonal"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@ID", SqlDbType.Int)
        param1.Direction = ParameterDirection.Input
        param1.Value = CInt(id)
        Adaptador.SelectCommand.Parameters.Add(param1)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("ID", id)
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        frmReportes.ReportViewer1.LocalReport.ReportPath = rutasReportes + "Reporte-ventas-personal.rdlc"
        frmReportes.ReportViewer1.LocalReport.SetParameters(
        New ReportParameter() {p1})
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.Show()
        conexion.Close()
        conexion2.Close()
    End Sub
End Class