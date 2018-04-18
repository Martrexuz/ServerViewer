Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateContextMenu() ' menu para el icono cuando pasa a segundo plano
        Dim pp As New PanelPrincipal
        pp.MdiParent = Me
        pp.Show()

    End Sub

    Private Sub ServidoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServidoresToolStripMenuItem.Click
        FrmServidor.MdiParent = Me
        FrmServidor.Show()
    End Sub

    Private Sub AplicacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicacionesToolStripMenuItem.Click
        FrmAplicacion.MdiParent = Me
        FrmAplicacion.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        FrmServicios.MdiParent = Me
        FrmServicios.Show()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        FrmHistorial.MdiParent = Me
        FrmHistorial.Show()
    End Sub

    Private Sub SOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SOToolStripMenuItem.Click
        FrmSO.MdiParent = Me
        FrmSO.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrosToolStripMenuItem.Click
        FrmParametros.MdiParent = Me
        FrmParametros.Show()
    End Sub




    Public Sub CreateContextMenu()

        'Define New Context Menu and Menu Item 
        Dim contextMenu As New ContextMenu
        Dim menuItem As New MenuItem("Salir")
        contextMenu.MenuItems.Add(menuItem)

        ' Associate context menu with Notify Icon 
        IconoNotificacion.ContextMenu = contextMenu

        'Add functionality for menu Item click 
        AddHandler menuItem.Click, AddressOf Close

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            IconoNotificacion.Visible = True
            IconoNotificacion.Icon = SystemIcons.WinLogo
            IconoNotificacion.BalloonTipIcon = ToolTipIcon.Info
            IconoNotificacion.BalloonTipTitle = "ViewerServerGZ"
            IconoNotificacion.BalloonTipText = "ViewerServer GZ esta corriendo"
            IconoNotificacion.Text = "ViewerServerGZ"
            IconoNotificacion.ShowBalloonTip(50000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub IconoNotificacion_DoubleClick(sender As Object, e As EventArgs) Handles IconoNotificacion.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        IconoNotificacion.Visible = False
    End Sub

    Private Sub AvanzadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvanzadosToolStripMenuItem.Click
        FrmAvanzados.MdiParent = Me
        FrmAvanzados.Show()
    End Sub


End Class
