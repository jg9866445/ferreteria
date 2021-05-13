Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class Importar
    Dim tablename As String
    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
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
            'Dim screatetable As String = "CREATE TABLE " & tablename & "("
            'Dim natributos As Integer = DataGridView1.Columns.Count
            'Dim datatypeA As New ArrayList
            'For x = 0 To natributos - 1
            '    If IsNumeric(DataGridView1.Rows(0).Cells(x).Value) Then
            '        datatypeA.Add("int")
            '    Else
            '        datatypeA.Add("varchar(MAX)")
            '    End If
            '    If x = natributos - 1 Then
            '        screatetable += DataGridView1.Columns.Item(x).HeaderText & " " & datatypeA(x) & " NOT NULL);"

            '    Else
            '        screatetable += DataGridView1.Columns.Item(x).HeaderText & " " & datatypeA(x) & " NOT NULL, "
            '    End If
            'Next
            'comando.CommandText = screatetable
            For x = 0 To DataGridView1.Rows.Count - 2
                Dim sentencesql As String = "INSERT INTO productos VALUES (" &
                DataGridView1(0, x).Value & ",'" & DataGridView1(1, x).Value & "','" &
                DataGridView1(2, x).Value & "'," & DataGridView1(3, x).Value & "," &
                DataGridView1(4, x).Value & "," & DataGridView1(5, x).Value & "," &
                DataGridView1(6, x).Value & "," & DataGridView1(7, x).Value & ")"
                'For y = 0 To DataGridView1.Columns.Count - 1
                '    If datatypeA(y).Equals("int") Then
                '        sentencesql += CInt(DataGridView1(y, x).Value) & ","
                '    Else
                '        sentencesql += "'" & DataGridView1(y, x).Value & "',"
                '    End If
                'Next
                'sentencesql = sentencesql.Substring(0, sentencesql.Length - 1)
                'sentencesql += ")"
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
End Class
