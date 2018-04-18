Public Class Frmloginservicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usuario_ssh = TextBox1.Text
        clave_ssh = TextBox2.Text
        MsgBox(FrmDetalleServidor.txt_nip.ToString)
        FrmDetalleServidor.consola_ssl(FrmDetalleServidor.txt_nip.Text, TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Frmloginservicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class