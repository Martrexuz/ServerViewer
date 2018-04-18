Public Class FrmServidor
    Dim tabla As New DataTable
    Private Sub FrmServidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sv As New Cservidor
        If sv.Listar_servidores Then
            tabla = sv.tabla
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) 
        If comprobar_cajas() Then

        End If
    End Sub

    Private Function comprobar_cajas()
        Dim valor As Boolean = True
        If txtdescripcion.Text = "" Then
            valor = False
        End If
        Return valor
    End Function
End Class