Public Class FrmMenuCatalogos
    Private Sub pbProductos_Click(sender As Object, e As EventArgs) Handles pbProductos.Click
        catTarget = "Producto"
        FrmProducto.ShowDialog()
    End Sub

    Private Sub pbPersonal_Click(sender As Object, e As EventArgs) Handles pbPersonal.Click
        catTarget = "Personal"
        FrmPersonal.ShowDialog()
    End Sub

    Private Sub pbProveedor_Click(sender As Object, e As EventArgs) Handles pbProveedor.Click
        catTarget = "Proveedor"
        FrmProveedor.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        catTarget = "Categoria"
        FrmCategoria.ShowDialog()
    End Sub
End Class