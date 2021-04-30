Imports System.Data.SqlClient

Public Class FrmRespaldo_Restaurar
    Dim conexion As New SqlConnection("Data Source=.;Initial catalog=master; Integrated security=Yes")
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Private Sub FrmRespaldo_Restaurar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        If privilege.Equals("Normal") Then
            btnAbrir.Enabled = False
        End If
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            OpenFileDialog1.InitialDirectory = "C:\\"
            OpenFileDialog1.Filter = "Archivos de texto (*.bak)|*.bak"

            Dim str_RutaArchivo As String
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                str_RutaArchivo = OpenFileDialog1.FileName
                txtRuta1.Text = str_RutaArchivo
                comando.CommandText = "DELETE DATABASE FERRETERIA"
                comando.ExecuteNonQuery()
                comando.CommandText = "RESTORE DATABASE FERRETERIA FROM DISK = '" & str_RutaArchivo & "' WITH Replace"
                comando.ExecuteNonQuery()
            End If
            conexion.Close()
            MsgBox("La restauración fue un exito")
        Catch
            MsgBox("A ocurrido un error con la restauracion")
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            SaveFileDialog1.InitialDirectory = "C:\\"
            SaveFileDialog1.Filter = "Archivos de texto (*.bak)|*.bak"

            Dim str_RutaArchivo As String
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                str_RutaArchivo = SaveFileDialog1.FileName
                txtRuta2.Text = str_RutaArchivo
                comando.CommandText = "BACKUP DATABASE [FERRETERIA] TO DISK = N'" & str_RutaArchivo & "'"
                comando.ExecuteNonQuery()
            End If
            conexion.Close()
            MsgBox("El respaldo fue un exito")
        Catch
            MsgBox("A ocurrido un error con la restauracion")
        End Try
    End Sub
End Class