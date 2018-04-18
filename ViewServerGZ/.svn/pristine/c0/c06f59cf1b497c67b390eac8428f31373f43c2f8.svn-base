Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class PanelPrincipal
    Dim tabla As New DataTable
    Dim aux As Boolean = False
    Dim servidores_con_problemas As New ArrayList
    Private Sub PanelPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sv As New Cservidor
        sv.Listar_servidores()
        tabla = sv.tabla
        tabla.Columns.Add("Estado")
        'debo armar el formato de la grilla
        Dim ch As New DataGridViewCheckBoxColumn
        Dim bt As New DataGridViewButtonColumn
        Dim bt2 As New DataGridViewButtonColumn

        DGprincipal.Columns.Add(ch) 'agrego la columna de checkbox
        '
        DGprincipal.DataSource = tabla
        DGprincipal.Columns("Estado").DefaultCellStyle.BackColor = Color.LightGray
        'Button7.PerformClick()
        'btn_comprobar_ping.PerformClick()
    End Sub



    Private Sub DGprincipal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGprincipal.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        If DGprincipal.Columns(e.ColumnIndex).Name.Equals("") Then
            Dim rw As DataGridViewRow = DGprincipal.Rows(e.RowIndex)
            Dim cselect As DataGridViewCheckBoxCell = rw.Cells("")

            If Convert.ToBoolean(cselect.Value) Then

                'PINTA LA CELDA DEL CHECK
                rw.DefaultCellStyle.BackColor = Color.Azure

                'AQUI SE DEBERIA REALIZAR LAS COMPROBACIONES PARA DARLE ESTADO AL SERVIDOR
                If comprobar_conexion(rw.Cells.Item(3).Value, 30000) Then
                    rw.Cells.Item(6).Style.BackColor = Color.Green
                Else
                    rw.Cells.Item(6).Style.BackColor = Color.Red
                End If

            Else
                rw.Cells.Item(6).Style.BackColor = Color.LightGray
            End If

        End If
    End Sub

    Private Sub DGprincipal_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DGprincipal.CurrentCellDirtyStateChanged
        If DGprincipal.IsCurrentCellDirty Then
            DGprincipal.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub




    Private Sub btn_detalle_Click(sender As Object, e As EventArgs) Handles btn_detalle.Click

        If DGprincipal.CurrentRow.Selected Then

            FrmDetalleServidor.MdiParent = Me.MdiParent
            FrmDetalleServidor.id_servidor = DGprincipal.CurrentRow.Cells.Item(1).Value
            FrmDetalleServidor.ip_servidor = DGprincipal.CurrentRow.Cells.Item(3).Value
            FrmDetalleServidor.n_servidor = DGprincipal.CurrentRow.Cells.Item(2).Value
            FrmDetalleServidor.Show()
        Else
            MsgBox("Debe seleccionar una fila", MsgBoxStyle.Information)
        End If



    End Sub

    'COMPROBACION CON SERVICIOS 
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '    'Comprobar ping, aplicaciones y servicios a todos los servidores de la grilla
        '    'Cargo datos de la tabla parametros
        Dim tparametro As New Cparametros
        For Each fila As DataRow In tabla.Rows
            tparametro.Buscar_valor_parametros("Tiempo de respuesta")
            If comprobar_conexion(fila.Item(2), tparametro.tabla.Rows.Item(0).Item(0)) Then
                'BUSCO EL SISTEMA OPERATIVO QUE TIENE

                'BUSCO EL SERVICIO DEL SERVIDOR, DEBERIA VALIDAR QUE FUESE LINUX PARA USAR SSH Y EN WINDOWS SOLO TIRAR UN PING DE MOMENTO.
                Dim cs As New Cservicios
                'busco el codigo del servicio enlazado al servidor
                If cs.buscar_servicio_servidor(fila.Item(0)) Then

                    'recorro la lista de la tabla join
                    For Each r As DataRow In cs.tabla.Rows
                        Dim csn As New Cservicios
                        'busco la lista con los servicios
                        If csn.buscar_servicio(r.Item(0)) Then
                            'recorro la lista de servicios
                            For Each rr As DataRow In csn.tabla.Rows
                                'si en la lista existe el ssh 
                                If rr.Item(0) = "sshd" Then
                                    aux = True
                                End If
                                Application.DoEvents()
                            Next
                            For Each rrr As DataRow In csn.tabla.Rows
                                If aux = True Then
                                    If consola_ssl(fila.Item(2), rrr.Item(0)) Then
                                        DGprincipal.Rows.Item(tabla.Rows.IndexOf(fila)).Cells.Item(6).Style.BackColor = Color.LightGreen
                                        tabla.Rows.Item(tabla.Rows.IndexOf(fila)).Item(5) = "Correcto"
                                    Else
                                        MsgBox("No encuentra el servicio " + rrr.Item(0))
                                        DGprincipal.Rows.Item(tabla.Rows.IndexOf(fila)).Cells.Item(6).Style.BackColor = Color.Red
                                    End If
                                Else
                                    MsgBox("no hay ssh")
                                End If
                                Application.DoEvents()
                            Next
                        End If
                        Application.DoEvents()
                    Next
                Else
                    DGprincipal.Rows.Item(tabla.Rows.IndexOf(fila)).Cells.Item(6).Style.BackColor = Color.LightGreen
                    txtinfo.Text = "Servidor:" + tabla.Rows.Item(tabla.Rows.IndexOf(fila)).Item(1) + " no tiene servicios asignados"
                    tabla.Rows.Item(tabla.Rows.IndexOf(fila)).Item(5) = "Correcto"
                End If
            Else
                DGprincipal.Rows.Item(tabla.Rows.IndexOf(fila)).Cells.Item(6).Style.BackColor = Color.Red
                fila.Item(5) = "Fallò ping"
            End If
            Application.DoEvents()
        Next
    End Sub


    Private Sub btn_comprobar_ping_Click(sender As Object, e As EventArgs) Handles btn_comprobar_ping.Click
        Dim tparametro As New Cparametros

        For Each fila As DataRow In tabla.Rows
            Dim h As New historial
            Dim ch As New Chistorial
            tparametro.Buscar_valor_parametros("Tiempo de respuesta")
            If comprobar_conexion(fila.Item(2), tparametro.tabla.Rows.Item(0).Item(0)) Then
                DGprincipal.Rows.Item(tabla.Rows.IndexOf(fila)).Cells.Item(6).Style.BackColor = Color.LightGreen
                fila.Item(5) = "Correcto"
                h.estado = 1
                h.fechacaida = Nothing
                calcular_horas_activas(h, fila, True)
            Else
                DGprincipal.Rows.Item(tabla.Rows.IndexOf(fila)).Cells.Item(6).Style.BackColor = Color.Red
                fila.Item(5) = "Fallò ping"
                comprobacion_repechaje(fila, tparametro)
                h.estado = 0
                h.fechacaida = System.DateTime.Now
                calcular_horas_activas(h, fila, False)
            End If
            h.fecharevision = System.DateTime.Now
            h.causal = fila.Item(5)
            h.idservidor = fila.Item(0)
            If ch.guardar_historial(h) Then
                txtinfo.Text = "SE GUARDO INFO"
            End If
            Application.DoEvents()
        Next
        'MsgBox(servidores_con_problemas.Count.ToString)
        If servidores_con_problemas.Count > 0 Then
            enviar_correo()
        End If
    End Sub

    Private Function calcular_horas_activas(h As historial, fila As DataRow, estado As Boolean)
        Dim ch2 As New Chistorial
        If estado = True Then
            If ch2.Buscar_horasactivo_max(fila.Item(0)) Then
                If IsDBNull(ch2.tabla.Rows.Item(0).Item(0)) Then
                    h.horasactivo = 0
                Else
                    Dim f1 As DateTime = ch2.tabla.Rows.Item(0).Item(0)         'hora del ultimo registro
                    Dim f2 As DateTime = System.DateTime.Now                    'hora actual
                    Dim HA As Double = ch2.tabla.Rows.Item(0).Item(1)
                    'MsgBox((HA + DateDiff(DateInterval.Minute, f1, f2)).ToString)
                    h.horasactivo = HA + (DateDiff(DateInterval.Minute, f1, f2) / 60)

                End If
            End If
        Else
            If ch2.Buscar_horasactivo_max(fila.Item(0)) Then
                If IsDBNull(ch2.tabla.Rows.Item(0).Item(0)) Then
                    h.horasactivo = 0
                Else
                    Dim HA As Double = ch2.tabla.Rows.Item(0).Item(1)
                    h.horasactivo = HA
                End If
            End If

        End If
        Return estado
    End Function


    Private Function comprobar_conexion(direccion_ip As String, parametro As Integer)
        Dim estado As Boolean
        Try
            If My.Computer.Network.Ping(direccion_ip, parametro) Then
                estado = True
            Else
                estado = False
            End If
        Catch ex As Net.NetworkInformation.PingException
            'txtinfo.Text += " error de conexion: \n"
            estado = False
        End Try
        Return estado
    End Function

    Private Function comprobacion_repechaje(fila As DataRow, tparametro As Cparametros)
        Dim pintento As New Cparametros
        pintento.Buscar_valor_parametros("Numero de Intentos")
        Dim cintentos As Integer = pintento.tabla.Rows.Item(0).Item(0)

        Dim ci As Integer = 0
        For i As Integer = 0 To cintentos - 1
            If comprobar_conexion(fila.Item(2), tparametro.tabla.Rows.Item(0).Item(0)) Then
                DGprincipal.Rows.Item(tabla.Rows.IndexOf(fila)).Cells.Item(6).Style.BackColor = Color.LightGreen
                fila.Item(5) = "Correcto"
            Else
                ci += 1
            End If
        Next
        If ci = 3 Then
            'MsgBox(fila.Item(2).ToString)
            servidores_con_problemas.Add(fila.Item(1).ToString + " - " + fila.Item(2).ToString)
        End If
        Return True
    End Function



    Public Function Conectarse_a_puerto(address As String, port As Integer) As Boolean
        Dim timeout As Integer = 15000
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



    Private Function consola_ssl(ip_servidor As String, nombre_servicio As String)

        'Crear los objetos necesarios para hacer la conexion'
        Dim connInfo As New Renci.SshNet.PasswordConnectionInfo(ip_servidor, "mrojas", "m12r07,")
        Dim sshClient As New Renci.SshNet.SshClient(connInfo)
        Dim status As Boolean
        'Need to hold the command'
        Dim cmd As Renci.SshNet.SshCommand

        Using sshClient
            'connect to the server'
            sshClient.Connect()

            'se ejecuta el comando y se almacena en un objeto cmd en este caso'
            'reviso el servicio del servidor'
            If ip_servidor.Equals("192.168.140.1") Or ip_servidor.Equals("192.168.140.3") Or ip_servidor.Equals("190.151.32.203") Then
                cmd = sshClient.RunCommand("sudo systemctl status " + nombre_servicio + ".service")
                'necesito leer la 3ra linea del result
                If cmd.Result.Contains("active (running)") Or cmd.Result.Contains("active (exited)") Then
                    status = True
                Else
                    status = False
                End If
                'SI ES ELASTIC
            ElseIf ip_servidor.Equals("190.151.32.204") Or ip_servidor.Equals("190.151.60.115") Then
                cmd = sshClient.RunCommand("sudo /sbin/service " + nombre_servicio + " status")
                'necesito leer la primera linea
                If cmd.Result.Contains("Se está ejecutando") Then
                    status = True
                Else
                    status = False
                End If
            Else
                cmd = sshClient.RunCommand("ls")
            End If '
            sshClient.Disconnect()
            Application.DoEvents()
        End Using

        Return status
    End Function



    Private Function enviar_correo()
        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage
        Dim adjunto As System.Net.Mail.Attachment

        With smtp
            .Port = 25
            .Host = "hades.gonzagri.cl"
            .Credentials = New System.Net.NetworkCredential("mrojas", "m12r07,")
            .EnableSsl = False
        End With
        'adjunto = New System.Net.Mail.Attachment("")
        With correo
            .From = New System.Net.Mail.MailAddress("Alertas@gonzagri.cl")
            .To.Add("mrojas@gonzagri.cl")
            .Subject = "Problema de revision Ping servidores"
            .Body = "<strong>Problema de conexion con los siguientes servidores:</strong><BR>"
            For i As Integer = 0 To servidores_con_problemas.Count - 1
                .Body += servidores_con_problemas.Item(i) + "<BR>"
            Next
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
            '.Attachments.Add(adjunto)
        End With

        Try
            smtp.Send(correo)
            'MessageBox.Show("Su mensaje de correo ha sido enviado.",
            '               "Correo enviado",
            'MessageBoxButtons.OK)
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message,
            '           "Error al enviar correo",
            'MessageBoxButtons.OK)
        End Try
        Return True
    End Function

    Private Sub PanelPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim p As New Cparametros

        If p.Buscar_valor_parametros("revision automatica") Then
            If p.tabla.Rows.Item(0).Item(0) = True Then
                btn_comprobar_ping.PerformClick()
            End If

        End If
    End Sub
End Class

