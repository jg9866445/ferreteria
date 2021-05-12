Imports System.Data.SqlClient
Public Class FrmTraspaso
    Dim conexion = New SqlConnection(connectionString)
    Dim conexion2 As New SqlConnection(connectionString)
    Dim comando1, comando2, comando3 As New SqlCommand 'Ejecuta comandos SQL
    Dim lector, lector2 As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados

    Private Sub FrmTraspaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista = New ArrayList()

        conexion.Open()
        comando1 = conexion.CreateCommand
        comando1.CommandText = "select fecha from ventas"
        lector = comando1.ExecuteReader


        While lector.Read()
            Dim fecha As Date
            fecha = lector(0)
            If Not lista.Contains(fecha.Year) Then
                lista.Add(fecha.Year)
            End If
        End While
        lector.Close()

        comando1.CommandText = "select fecha from devoluciones"
        lector = comando1.ExecuteReader

        While lector.Read()
            Dim fecha As Date
            fecha = lector(0)
            If Not lista.Contains(fecha.Year) Then
                lista.Add(fecha.Year)
            End If
        End While
        lector.Close()
        comando1.CommandText = "select fecha from compras"
        lector = comando1.ExecuteReader

        While lector.Read()
            Dim fecha As Date
            fecha = lector(0)
            If Not lista.Contains(fecha.Year) Then
                lista.Add(fecha.Year)
            End If
        End While
        lector.Close()
        comando1.CommandText = "select fecha from perdidas"
        lector = comando1.ExecuteReader


        While lector.Read()
            Dim fecha As Date
            fecha = lector(0)
            If Not lista.Contains(fecha.Year) Then
                lista.Add(fecha.Year)
            End If
        End While
        lector.Close()
        cboPeriodoTraspaso.DataSource = lista
        conexion.Close()
    End Sub

    Private Sub btnTraspaso_Click(sender As Object, e As EventArgs) Handles btnTraspaso.Click
        Try
            conexion.Open()
            conexion2.Open()
            comando1 = conexion.CreateCommand
            comando2 = conexion2.CreateCommand
            comando3 = conexion.CreateCommand
            Dim t As String
            Dim R, X As String

            'trucate en catalogos

            t = "TRUNCATE TABLE Personal"
            comando2.CommandText = t
            comando2.ExecuteNonQuery()

            t = "TRUNCATE TABLE Proveedores"
            comando2.CommandText = t
            comando2.ExecuteNonQuery()

            t = "TRUNCATE TABLE Productos"
            comando2.CommandText = t
            comando2.ExecuteNonQuery()

            t = "TRUNCATE TABLE Categoria"
            comando2.CommandText = t
            comando2.ExecuteNonQuery()

            'traspaso de catalogos

            R = "Select * From Personal”
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                X = "Insert into Personal (idPersonal, nombre, telefono, celular, domicilio, cp, colonia) Values (" & (CInt(lector(0))) & ", '" & (CStr(lector(1))) & "'," & (CInt(lector(2))) & "," & (CInt(lector(3))) & ", '" & (CStr(lector(4))) & "', " & (CInt(lector(5))) & ", '" & (CStr(lector(6))) & "')"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()
            End While
            lector.Close()

            R = "Select * From Proveedores"
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                X = "Insert into Proveedores (idProveedor, nombre, telefono, celular, domicilio, cp, colonia, rfc) Values (" & (CInt(lector(0))) & ", '" & (CStr(lector(1))) & "'," & (CInt(lector(2))) & "," & (CInt(lector(3))) & ", '" & (CStr(lector(4))) & "', " & (CInt(lector(5))) & ", '" & (CStr(lector(6))) & "', " & (CInt(lector(7))) & ")"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()
            End While
            lector.Close()

            R = "Select * From Categoria”
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                X = "Insert into Categoria (idCategoria, nombre, descripcion) Values (" & (CInt(lector(0))) & ",'" & (CStr(lector(1))) & "','" & (CStr(lector(2))) & "')"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()
            End While
            lector.Close()

            R = "Select * From Productos”
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                X = "Insert into Productos (idProducto, nombreProducto, detalle, idCategoria, precio, cantidad, maximo, minimo) Values (" & (CInt(lector(0))) & ",'" & (CStr(lector(1))) & "','" & (CStr(lector(2))) & "'," & (CInt(lector(3))) & ", '" & (CDbl(lector(4))) & "', " & (CInt(lector(5))) & ", '" & (CInt(lector(6))) & "', " & (CInt(lector(7))) & ")"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()
            End While
            lector.Close()

            'traspaso movimientos

            'VENTAS
            R = "select * from ventas where YEAR(ventas.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                Dim fecha As Date
                fecha = lector(6)
                Dim fechaF = fecha.Month & "/" & fecha.Day & "/" & fecha.Year

                X = "insert into Ventas(idventa, idPersonal, subTotal, iva, descuento, total, fecha, numFactura, edoVenta) values(" & (CInt(lector(0))) & "," & CInt(lector(1)) & "," & CDbl(lector(2)) & ", " & CDbl(lector(3)) & ", " & CDbl(lector(4)) & "," & CDbl(lector(5)) & ",'" & fechaF & "'," & CDbl(lector(7)) & ",'" & CChar(lector(8)) & "')"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()

                X = "Select * From DetalleVenta Where idVenta=" & lector(0)
                comando3.CommandText = X
                lector2 = comando3.ExecuteReader
                While lector2.Read()
                    X = "insert into detalleVenta values(" & (CInt(lector2(0))) & "," & (CInt(lector2(1))) & "," & (CInt(lector2(2))) & "," & (CDbl(lector2(3))) & ")"
                    comando2.CommandText = X
                    comando2.ExecuteNonQuery()
                End While
                lector2.Close()
            End While
            lector.Close()

            'COMPRAS
            R = "select * from compras where YEAR(compras.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                Dim fecha As Date
                fecha = lector(5)
                Dim fechaF = fecha.Month & "/" & fecha.Day & "/" & fecha.Year

                X = "insert into Compras(idCompras, idProveedor, subtotal, iva, total, fecha) values(" & (CInt(lector(0))) & "," & CInt(lector(1)) & "," & CDbl(lector(2)) & ", " & CDbl(lector(3)) & ", " & CDbl(lector(4)) & ",'" & fechaF & "')"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()

                X = "Select * From DetalleCompra Where idCompra=" & lector(0)
                comando3.CommandText = X
                lector2 = comando3.ExecuteReader
                While lector2.Read()
                    X = "insert into detalleCompra values(" & (CInt(lector2(0))) & "," & (CInt(lector2(1))) & "," & (CInt(lector2(2))) & "," & (CDbl(lector2(3))) & ")"
                    comando2.CommandText = X
                    comando2.ExecuteNonQuery()
                End While
                lector2.Close()
            End While
            lector.Close()

            'PERDIDAS
            R = "select * from perdidas where YEAR(perdidas.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                Dim fecha As Date
                fecha = lector(2)
                Dim fechaF = fecha.Month & "/" & fecha.Day & "/" & fecha.Year

                X = "insert into Perdidas(idPerdida, Concepto, fecha) values(" & (CInt(lector(0))) & ",'" & (CStr(lector(1))) & "','" & fechaF & "')"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()

                X = "Select * From DetallePerdida Where idPerdida=" & lector(0)
                comando3.CommandText = X
                lector2 = comando3.ExecuteReader
                While lector2.Read()
                    X = "insert into detallePerdida values(" & (CInt(lector2(0))) & "," & (CInt(lector2(1))) & "," & (CInt(lector2(2))) & "," & (CDbl(lector2(3))) & ")"
                    comando2.CommandText = X
                    comando2.ExecuteNonQuery()
                End While
                lector2.Close()
            End While
            lector.Close()

            'DEVOLUCIONES
            R = "select * from devoluciones where YEAR(devoluciones.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                Dim fecha As Date
                fecha = lector(3)
                Dim fechaF = fecha.Month & "/" & fecha.Day & "/" & fecha.Year

                X = "insert into Devoluciones(idDevolucion, idPersonal, idVenta, fecha, motivo) values(" & (CInt(lector(0))) & "," & (CInt(lector(1))) & "," & (CInt(lector(2))) & ",'" & fechaF & "', '" & (CStr(lector(4))) & "')"
                comando2.CommandText = X
                comando2.ExecuteNonQuery()
            End While
            lector.Close()

            'Eliminar los registros traspasados

            'ELIMINAR VENTAS
            R = "select * from ventas where YEAR(ventas.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                X = "delete from detalleVenta Where idVenta=" & lector(0)
                comando3.CommandText = X
                comando3.ExecuteNonQuery()
            End While
            lector.Close()

            X = "Delete From ventas Where YEAR(ventas.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = X
            comando1.ExecuteNonQuery()

            'ELIMINAR COMPRAS
            R = "select * from compras where YEAR(compras.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                X = "delete from detalleCompra Where idCompra=" & lector(0)
                comando3.CommandText = X
                comando3.ExecuteNonQuery()
            End While
            lector.Close()

            X = "Delete From compras Where YEAR(compras.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = X
            comando1.ExecuteNonQuery()

            'ELIMINAR PERDIDAS
            R = "select * from perdidas where YEAR(perdidas.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            lector = comando1.ExecuteReader
            While lector.Read()
                X = "delete from detalleperdida Where idPerdida=" & lector(0)
                comando3.CommandText = X
                comando3.ExecuteNonQuery()
            End While
            lector.Close()

            X = "Delete From perdidas Where YEAR(perdidas.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = X
            comando1.ExecuteNonQuery()

            'ELIMINAR DEVOLUCIONES   
            R = "Delete From devoluciones Where YEAR(devoluciones.fecha)=" & Val(cboPeriodoTraspaso.Text)
            comando1.CommandText = R
            comando1.ExecuteNonQuery()

            MsgBox("El traspaso fue un exito")
        Catch ex As Exception
            MsgBox("A ocurrido un error con el traspaso")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmTraspaso_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
        conexion2.Close()
    End Sub
End Class