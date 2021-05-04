Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class FrmReporteComperi
    Private Sub FrmReporteComperi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim f1 As Date
        Dim f2 As Date
        f1 = dtpFi.Text
        f2 = dtpFf.Text
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("ferreteria.My.MySettings.FERRETERIAConnectionString").ConnectionString)

        conexion.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = conexion
        Adaptador.SelectCommand.CommandText = "comprasperiodo"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
        Dim param2 = New SqlParameter("@FF", SqlDbType.Date)

        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input

        param1.Value = f1
        param2.Value = f2

        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)

        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)

        Dim p1 As New ReportParameter("FI", f1)
        Dim p2 As New ReportParameter("FF", f2)

        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        frmReportes.ReportViewer1.LocalReport.ReportPath = "D:\je_ss\Escritorio\tareas\SIS. INTEGRALES\ferreteria\ferreteria\ferreteria\Reporte-compras-periodo.rdlc"
        frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub
End Class