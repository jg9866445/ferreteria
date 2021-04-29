Public Class FrmMenuConsultas
    Private Sub pbConsultaProv_Click(sender As Object, e As EventArgs) Handles pbConsultaProv.Click
        FrmConsultaProveedor.ShowDialog()
    End Sub

    Private Sub pbConsultaD_Click(sender As Object, e As EventArgs) Handles pbConsultaD.Click
        FrmConsultaDevolucionesPersonal.ShowDialog()
    End Sub

    Private Sub pbConsultaVfec_Click(sender As Object, e As EventArgs) Handles pbConsultaVfec.Click
        FrmConsultaVentaFecha.ShowDialog()
    End Sub

    Private Sub pbConsultaVemp_Click(sender As Object, e As EventArgs) Handles pbConsultaVemp.Click
        FrmConsultaVentaEmpleado.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmConsultaDevoluciones.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmConsultaPerdidas.ShowDialog()
    End Sub
End Class