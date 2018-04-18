<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetalleServidor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_so = New System.Windows.Forms.Label()
        Me.txt_nip = New System.Windows.Forms.Label()
        Me.txt_nservidor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_comprobar_puertos = New System.Windows.Forms.Button()
        Me.btn_comprobar_servicios = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGdetallesrv = New System.Windows.Forms.DataGridView()
        Me.DGaplicaciones = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DGdetallesrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGaplicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_so)
        Me.Panel1.Controls.Add(Me.txt_nip)
        Me.Panel1.Controls.Add(Me.txt_nservidor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.btn_comprobar_puertos)
        Me.Panel1.Controls.Add(Me.btn_comprobar_servicios)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 144)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(643, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tabla Aplicaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tabla Servicios"
        '
        'txt_so
        '
        Me.txt_so.AutoSize = True
        Me.txt_so.Location = New System.Drawing.Point(643, 13)
        Me.txt_so.Name = "txt_so"
        Me.txt_so.Size = New System.Drawing.Size(0, 13)
        Me.txt_so.TabIndex = 7
        '
        'txt_nip
        '
        Me.txt_nip.AutoSize = True
        Me.txt_nip.Location = New System.Drawing.Point(328, 13)
        Me.txt_nip.Name = "txt_nip"
        Me.txt_nip.Size = New System.Drawing.Size(0, 13)
        Me.txt_nip.TabIndex = 6
        '
        'txt_nservidor
        '
        Me.txt_nservidor.AutoSize = True
        Me.txt_nservidor.Location = New System.Drawing.Point(98, 13)
        Me.txt_nservidor.Name = "txt_nservidor"
        Me.txt_nservidor.Size = New System.Drawing.Size(0, 13)
        Me.txt_nservidor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(541, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sistema Operativo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IP:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(30, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Servidor:"
        '
        'btn_comprobar_puertos
        '
        Me.btn_comprobar_puertos.Location = New System.Drawing.Point(480, 84)
        Me.btn_comprobar_puertos.Name = "btn_comprobar_puertos"
        Me.btn_comprobar_puertos.Size = New System.Drawing.Size(81, 54)
        Me.btn_comprobar_puertos.TabIndex = 1
        Me.btn_comprobar_puertos.Text = "Comprobar puertos"
        Me.btn_comprobar_puertos.UseVisualStyleBackColor = True
        '
        'btn_comprobar_servicios
        '
        Me.btn_comprobar_servicios.Location = New System.Drawing.Point(15, 84)
        Me.btn_comprobar_servicios.Name = "btn_comprobar_servicios"
        Me.btn_comprobar_servicios.Size = New System.Drawing.Size(81, 54)
        Me.btn_comprobar_servicios.TabIndex = 0
        Me.btn_comprobar_servicios.Text = "Comprobar estado Servicios"
        Me.btn_comprobar_servicios.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 434)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 100)
        Me.Panel2.TabIndex = 1
        '
        'DGdetallesrv
        '
        Me.DGdetallesrv.AllowUserToAddRows = False
        Me.DGdetallesrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdetallesrv.Location = New System.Drawing.Point(0, 144)
        Me.DGdetallesrv.Name = "DGdetallesrv"
        Me.DGdetallesrv.Size = New System.Drawing.Size(454, 290)
        Me.DGdetallesrv.TabIndex = 2
        '
        'DGaplicaciones
        '
        Me.DGaplicaciones.AllowUserToAddRows = False
        Me.DGaplicaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGaplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGaplicaciones.Location = New System.Drawing.Point(480, 144)
        Me.DGaplicaciones.Name = "DGaplicaciones"
        Me.DGaplicaciones.Size = New System.Drawing.Size(440, 290)
        Me.DGaplicaciones.TabIndex = 3
        '
        'FrmDetalleServidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 534)
        Me.Controls.Add(Me.DGaplicaciones)
        Me.Controls.Add(Me.DGdetallesrv)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDetalleServidor"
        Me.Text = "FrmDetalleServidor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGdetallesrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGaplicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGdetallesrv As DataGridView
    Friend WithEvents btn_comprobar_servicios As Button
    Friend WithEvents btn_comprobar_puertos As Button
    Friend WithEvents DGaplicaciones As DataGridView
    Friend WithEvents txt_so As Label
    Friend WithEvents txt_nip As Label
    Friend WithEvents txt_nservidor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
