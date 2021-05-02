Public Class Frmmenu
    Private Sub pbCompras_Click(sender As Object, e As EventArgs) Handles pbCompras.Click
        FrmCompra.ShowDialog()
    End Sub

    Private Sub pbCatalogos_Click(sender As Object, e As EventArgs) Handles pbCatalogos.Click
        FrmMenuCatalogos.ShowDialog()
    End Sub

    Private Sub pbDevoluciones_Click(sender As Object, e As EventArgs) Handles pbDevoluciones.Click
        FrmDevolucion.ShowDialog()
    End Sub

    Private Sub pbVentas_Click(sender As Object, e As EventArgs) Handles pbVentas.Click
        FrmVentas.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmMenuConsultas.ShowDialog()
    End Sub

    Private Sub pbPerdidas_Click(sender As Object, e As EventArgs) Handles pbPerdidas.Click
        FrmPerdidas.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmMenuReportes.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FrmBitacora.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmRespaldo_Restaurar.ShowDialog()
    End Sub

    Private Sub Frmmenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("D:\je_ss\Escritorio\tareas\SIS. INTEGRALES\ferreteria\ferreteria\Ayuda.chm")
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmTraspaso.ShowDialog()
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioNuevoToolStripMenuItem.Click
        SignUp.ShowDialog()
    End Sub
    Private Sub AdministrarUsuarioActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarUsuarioActualToolStripMenuItem.Click
        ProfileManagement.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        user = ""
        pass = ""
        privilege = ""
        Close()
    End Sub

    Private Sub Frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = DateString
        If privilege.Equals("Normal") Then
            AgregarUsuarioNuevoToolStripMenuItem.Enabled = False
            PictureBox4.Visible = False
            PictureBox6.Visible = False
        Else
            AgregarUsuarioNuevoToolStripMenuItem.Enabled = True
            PictureBox4.Visible = True
            PictureBox6.Visible = True
        End If
        UsuarioToolStripMenuItem.Text = user
    End Sub
End Class