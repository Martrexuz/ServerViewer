Imports System.Net
Imports System.Net.Sockets

Public Class FrmDetalleServidor
    Public id_servidor As Integer
    Public ip_servidor As String
    Public n_servidor As String
    Dim tabla As New DataTable
    Dim tabla2 As New DataTable
    Private Sub FrmDetalleServidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cs As New Cservicios
        Dim ca As New Caplicacion
        Dim so As New Cso
        txt_nservidor.Text = n_servidor
        txt_nip.Text = ip_servidor
        'busco nombre s.o
        If so.buscar_so_descripcion(id_servidor) Then
            txt_so.Text = so.tabla.Rows.Item(0).Item(0)
        End If
        'llena  el DGdetalleserv
        If cs.buscar_servicio_servidor(id_servidor) Then
            For i As Integer = 0 To cs.tabla.Rows.Count - 1
                Dim csc As New Cservicios
                If csc.buscar_servicio_con_detalle(cs.tabla.Rows.Item(i).Item(0)) Then
                    If tabla.Rows.Count < 1 Then
                        tabla = csc.tabla.Clone
                        tabla.Merge(csc.tabla)
                    Else
                        tabla.Merge(csc.tabla)
                    End If

                End If
            Next
            DGdetallesrv.DataSource = tabla
        End If

        'llena DGaplicaciones

        If ca.Buscar_aplicacion_servidor(id_servidor) Then
            For i As Integer = 0 To cs.tabla.Rows.Count - 1
                Dim csa As New Caplicacion
                If csa.Buscar_aplicacion(cs.tabla.Rows.Item(i).Item(0)) Then
                    If tabla2.Rows.Count < 1 Then
                        tabla2 = csa.tabla.Clone
                        tabla2.Merge(csa.tabla)
                    Else
                        tabla2.Merge(csa.tabla)
                    End If
                    'tabla.Rows.Add(csc.tabla.Rows.Item(0).Item(0).ToString)
                End If
            Next
            DGaplicaciones.DataSource = tabla2
        End If


    End Sub

    Private Sub btn_comprobar_servicios_Click(sender As Object, e As EventArgs) Handles btn_comprobar_servicios.Click
        ' PRIMERO REVISO SI TIENE SSH, DESPUES SOLICITO QUE SE LOGUEE PARA EJECUTAR LA PRUEBA DE SERVICIOS.
        Frmloginservicio.MdiParent = Me.MdiParent
        Frmloginservicio.Show()

    End Sub

    Private Sub btn_comprobar_puertos_Click(sender As Object, e As EventArgs) Handles btn_comprobar_puertos.Click
        Dim par As New Cparametros

        For Each fila As DataRow In tabla.Rows
            If IsDBNull(fila.Item(2)) Then
                MsgBox("No usa puerto definido")
            Else
                If Conectarse_a_puerto(ip_servidor, fila.Item(2), Val(par.Buscar_valor_parametros("Tiempo de respuesta"))) Then
                    MsgBox("abierto")
                Else
                    MsgBox("cerrado")
                End If
            End If

        Next
    End Sub





    Public Function Conectarse_a_puerto(address As String, port As Integer, tiempo_respuesta As Integer) As Boolean
        Dim timeout As Integer = tiempo_respuesta
        Dim result = False
        Try
            Using socket = New Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                Dim asyncResult As IAsyncResult = socket.BeginConnect(address, port, Nothing, Nothing)
                result = asyncResult.AsyncWaitHandle.WaitOne(timeout, True)
                socket.Close()
            End Using
            Return result
        Catch
            Return False
        End Try
    End Function

    Public Function consola_ssl(ip_servidor As String, user As String, pass As String)

        'Crear los objetos necesarios para hacer la conexion'
        Dim connInfo As New Renci.SshNet.PasswordConnectionInfo(ip_servidor, user, pass)
        Dim sshClient As New Renci.SshNet.SshClient(connInfo)
        Dim status As Boolean
        'Need to hold the command'
        Dim cmd As Renci.SshNet.SshCommand

        Using sshClient
            'connect to the server'
            sshClient.Connect()
                Frmloginservicio.Label4.Text = "Conectado"
                sshClient.Disconnect()


        End Using

        Return status
    End Function


End Class