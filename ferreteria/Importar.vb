Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class Importar
    Dim tablename As String
    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xls"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            tablename = xSheet
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
                Button2.Enabled = True
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar" & ex.ToString(), MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub enviaASQL()
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand
        conexion.Open()
        Try
            comando = conexion.CreateCommand
            Dim sentencesql As String = ""
            For x = 0 To DataGridView1.Rows.Count - 2
                If catTarget.Equals("Producto") Then
                    sentencesql = "INSERT INTO productos VALUES (" &
                    DataGridView1(0, x).Value & ",'" & DataGridView1(1, x).Value & "','" &
                    DataGridView1(2, x).Value & "'," & DataGridView1(3, x).Value & "," &
                    DataGridView1(4, x).Value & "," & DataGridView1(5, x).Value & "," &
                    DataGridView1(6, x).Value & "," & DataGridView1(7, x).Value & ")"
                ElseIf catTarget.Equals("Personal") Then
                    sentencesql = "INSERT INTO personal(idPersonal, nombre, telefono, celular, domicilio, cp, colonia) VALUES 
                    (" & DataGridView1(0, x).Value & ",'" & DataGridView1(1, x).Value & "'," &
                    DataGridView1(2, x).Value & "," & DataGridView1(3, x).Value & ",'" &
                    DataGridView1(4, x).Value & "'," & DataGridView1(5, x).Value & ",'" &
                    DataGridView1(6, x).Value & "')"
                ElseIf catTarget.Equals("Proveedor") Then
                    sentencesql = "INSERT INTO proveedores(idProveedor, nombre, telefono, celular, domicilio, cp, colonia, rfc) VALUES (" &
                    "" & DataGridView1(0, x).Value & ",'" & DataGridView1(1, x).Value & "'," &
                    DataGridView1(2, x).Value & "," & DataGridView1(3, x).Value & ",'" &
                    DataGridView1(4, x).Value & "'," & DataGridView1(5, x).Value & ",'" &
                    DataGridView1(6, x).Value & "','" & DataGridView1(7, x).Value & "'" & ")"
                ElseIf catTarget.Equals("Categoria") Then
                    sentencesql = "INSERT INTO categoria VALUES (" &
                    DataGridView1(0, x).Value & ",'" & DataGridView1(1, x).Value & "','" &
                    DataGridView1(2, x).Value & "')"
                End If
                comando.CommandText = sentencesql
                comando.ExecuteNonQuery()
            Next
            conexion.Close()
            MsgBox("Se ha cargado la importacion A SQL correctamente", MsgBoxStyle.Information, "Importado con exito")
            Close()
        Catch ex As Exception
            conexion.Close()
            MsgBox("Hubo un error al importar a SQL: " & ex.ToString, MsgBoxStyle.Critical, "Importado Fallida")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        importarExcel(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        enviaASQL()
    End Sub

    Private Sub Importar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Button2.Enabled = False
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub
End Class
