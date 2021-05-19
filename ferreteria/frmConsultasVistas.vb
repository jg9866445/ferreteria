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


        DGVADHOC.Rows.Add(0, "compras", "idCompras", "..")
        DGVADHOC.Rows.Add(0, "compras", "idProveedor", "..")
        DGVADHOC.Rows.Add(0, "compras", "subTotal", "..")
        DGVADHOC.Rows.Add(0, "compras", "iva", "..")
        DGVADHOC.Rows.Add(0, "compras", "total", "..")
        DGVADHOC.Rows.Add(0, "compras", "fecha", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "nombre", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "telefono", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "celular", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "domicilio", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "cp", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "colonia", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "rfc", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "ciudad", "..")
        DGVADHOC.Rows.Add(0, "proveedores", "estado", "..")
        DGVADHOC.Rows.Add(0, "detalleCompra", "idCompra", "..")
        DGVADHOC.Rows.Add(0, "detalleCompra", "idProducto", "..")
        DGVADHOC.Rows.Add(0, "detalleCompra", "cantidad", "..")
        DGVADHOC.Rows.Add(0, "detalleCompra", "precio", "..")
        DGVADHOC.Rows.Add(0, "productos", "nombreProducto", "..")
        DGVADHOC.Rows.Add(0, "productos", "detalle", "..")
        DGVADHOC.Rows.Add(0, "productos", "idCategoria", "..")
        DGVADHOC.Rows.Add(0, "productos", "precio", "..")
        DGVADHOC.Rows.Add(0, "productos", "cantidad", "..")
        DGVADHOC.Rows.Add(0, "productos", "maximo", "..")
        DGVADHOC.Rows.Add(0, "productos", "minimo", "..")
        DGVADHOC.Rows.Add(0, "categoria", "nombre", "..")
        DGVADHOC.Rows.Add(0, "categoria", "descripcion", "..")


    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim primerCampo = False
        Dim numcap = 0
        Dim sql As String = "select "
        Dim x = 0, a = 0
        Dim columna As String
        Try
            For i As Integer = 0 To DGVADHOC.Rows.Count - 2
                Dim y As Integer = DGVADHOC.Item(0, i).Value
                If y = -1 Then
                    numcap = numcap + 1

                    Dim nomTabla As String = DGVADHOC.Item(1, i).Value
                    Dim nomCampo As String = DGVADHOC.Item(2, i).Value

                    If nomTabla = "compras" Then
                        If primerCampo = False Then
                            sql = sql + "com." + nomCampo
                            primerCampo = True
                        Else
                            sql = sql + ",com." + nomCampo
                        End If

                    ElseIf nomTabla = "proveedores" Then
                        If primerCampo = False Then
                            sql = sql + "pro." + nomCampo
                            primerCampo = True
                        Else
                            sql = sql + ",pro." + nomCampo
                        End If

                    ElseIf nomTabla = "detalleCompra" Then
                        If primerCampo = False Then
                            sql = sql + "detCompra." + nomCampo
                            primerCampo = True
                        Else
                            sql = sql + ",detCompra." + nomCampo
                        End If

                    ElseIf nomTabla = "productos" Then
                        If primerCampo = False Then
                            sql = sql + "prod." + nomCampo
                            primerCampo = True
                        Else
                            sql = sql + ",prod." + nomCampo
                        End If

                    ElseIf nomTabla = "categoria" Then
                        If primerCampo = False Then
                            sql = sql + "cat." + nomCampo
                            primerCampo = True
                        Else
                            sql = sql + ",cat." + nomCampo
                        End If
                    End If
                    columna = "Column" & x
                    DGVExcel.Columns.Add(columna, nomCampo)
                    x = x + 1
                End If

            Next




            sql = sql + " from compras as com inner join proveedores as pro on pro.idProveedor = com.idProveedor inner join detalleCompra as detCompra on detCompra.idCompra = com.idCompras inner join productos as prod on detCompra.idProducto = prod.idProducto inner join categoria as cat on cat.idCategoria = prod.idCategoria"
            Comando.CommandText = sql
            lector = Comando.ExecuteReader
            While lector.Read
                DGVExcel.Rows.Add()
                For i = 0 To numcap - 1
                    DGVExcel.Rows(a).Cells(i).Value = lector(i)
                Next
                a = a + 1
            End While
            lector.Close()

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