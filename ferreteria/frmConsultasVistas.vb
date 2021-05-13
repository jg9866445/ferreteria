Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmConsultasVistas
    Dim R As String
    Dim Comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim rutaArchivo As String
    Dim Conexion As New SqlConnection(connectionString)
    Dim chk As New DataGridViewCheckBoxColumn()

    Dim objApp As Excel.Application
    Dim objBook As Excel._Workbook


    Private Sub frmConsultasVistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        Comando = Conexion.CreateCommand

        chk.Name = "chk"

        DGVADHOC.Rows.Add(0, "Productos", "idProducto", "Clave del producto (ID)")
        DGVADHOC.Rows.Add(0, "Productos", "nombreProducto", "Clave del producto (ID)")
        DGVADHOC.Rows.Add(0, "Productos", "detalle", "Descripción del producto")
        DGVADHOC.Rows.Add(0, "Productos", "idCategoria", "Clave de la categoría del producto (ID)")
        DGVADHOC.Rows.Add(0, "Productos", "precio", "Precio de venta del producto")
        DGVADHOC.Rows.Add(0, "Productos", "cantidad", "Número de existencias del producto")
        DGVADHOC.Rows.Add(0, "Productos", "maximo", "Máximo en stock del producto")
        DGVADHOC.Rows.Add(0, "Productos", "minimo", "Minímo en stock del producto")
        DGVADHOC.Rows.Add(0, "categoria", "IdCategoria", "ID_Categoria")
        DGVADHOC.Rows.Add(0, "categoria", "nombre", "Nombre de la categoría")
        DGVADHOC.Rows.Add(0, "categoria", "descripcion", "Nombre de la categoría")
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim x, a As Integer
        x = 0
        a = 0
        Try
            For i As Integer = 0 To DGVADHOC.Rows.Count - 2
                Dim y As Integer = DGVADHOC.Item(0, i).Value
                ' MsgBox(y)
                If y = -1 Then
                    Dim nomTabla As String = DGVADHOC.Item(1, i).Value
                    Dim nomCampo As String = DGVADHOC.Item(2, i).Value
                    Dim columna As String
                    columna = "Column" & x


                    R = "Select " & nomCampo & " from " & nomTabla & ""
                    Comando.CommandText = R
                    lector = Comando.ExecuteReader
                    DGVExcel.Columns.Add(columna, nomCampo)
                    a = 0
                    While lector.Read
                        DGVExcel.Rows.Add()
                        DGVExcel.Rows(a).Cells(x).Value = lector(0)
                        a = a + 1
                    End While
                    lector.Close()
                    x = x + 1
                End If
            Next
        Catch m As Exception
            MsgBox(m)
        End Try
    End Sub

    Private Sub PObject(ByRef obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btn_ExportarExcel_Click(sender As Object, e As EventArgs) Handles btn_ExportarExcel.Click
        Try
            Dim fichero As New SaveFileDialog()
            fichero.Filter = "Excel (*.xlsx)|*.xlsx"
            fichero.FileName = ""
            If fichero.ShowDialog() = DialogResult.OK Then


                'Creando Dataset para Exportar
                Dim dset As New DataSet
                'Agregar tabla al Dataset
                dset.Tables.Add()
                'AGregar Columna a la tabla
                For i As Integer = 0 To DGVExcel.ColumnCount - 1
                    dset.Tables(0).Columns.Add(DGVExcel.Columns(i).HeaderText)
                Next
                'Agregar filas a la tabla
                Dim dr1 As DataRow
                For i As Integer = 0 To DGVExcel.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To DGVExcel.Columns.Count - 1
                        dr1(j) = DGVExcel.Rows(i).Cells(j).Value
                    Next
                    dset.Tables(0).Rows.Add(dr1)
                Next

                Dim aplicacion As Excel.Application
                Dim wBook As Excel.Workbook
                Dim wSheet As Excel.Worksheet
                aplicacion = New Excel.Application()
                wBook = aplicacion.Workbooks.Add()
                wSheet = wBook.ActiveSheet()

                Dim dt As System.Data.DataTable = dset.Tables(0)
                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0

                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    aplicacion.Cells(1, colIndex) = dc.ColumnName
                Next

                For Each dr In dt.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In dt.Columns
                        colIndex = colIndex + 1
                        aplicacion.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

                    Next
                Next

                Dim strFileName As String = fichero.FileName
                Dim blnFileOpen As Boolean = False
                Try
                    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                    fileTemp.Close()
                Catch ex As Exception
                    blnFileOpen = False
                End Try

                If System.IO.File.Exists(strFileName) Then
                    System.IO.File.Delete(strFileName)
                End If
                MessageBox.Show("El documento fue exportado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                wBook.SaveAs(strFileName)
                aplicacion.Workbooks.Open(strFileName)
                aplicacion.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error al exportar la informacion debido a: " & ex.ToString())
        End Try
    End Sub

End Class