Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Public Class FrmAvanzados

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' crear   
        MsgBox(start_Up(True))
    End Sub

    Private Sub FrmAvanzados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Iniciar al inicio de windows"
        Button2.Text = "No iniciar al inicio de windows"
        Dim parametro As New Cparametros
        If parametro.Buscar_valor_parametros("revision automatica") Then
            If parametro.tabla.Rows.Item(0).Item(0) = True Then
                r1.Checked = True
                r2.Checked = False
            Else
                r2.Checked = True
                r1.Checked = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Eliminar  
        MsgBox(start_Up(False))
    End Sub

    Private Function start_Up(ByVal bCrear As Boolean) As String

        ' clave del registro para   
        ' colocar el path del ejecutable para iniciar con windows  
        Const CLAVE As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"

        'ProductName : el nombre del programa.  
        Dim subClave As String = Application.ProductName.ToString
        ' Mensaje para retornar el resultado  
        Dim msg As String = ""

        Try
            ' Abre la clave del usuario actual (CurrentUser) para poder extablecer el dato  
            ' si la clave CurrentVersion\Run no existe la crea  
            Dim Registro As RegistryKey = CurrentUser.CreateSubKey(CLAVE, RegistryKeyPermissionCheck.ReadWriteSubTree)

            With Registro

                .OpenSubKey(CLAVE, True)

                Select Case bCrear
                    ' Crear  
                    ''''''''''''''''''''''  
                    Case True
                        ' Escribe el path con SetValue   
                        'Valores : ProductName el nombre del programa y ExecutablePath : la ruta del exe  
                        .SetValue(subClave,
                                  Application.ExecutablePath.ToString)
                        Return "Ok .. clave añadida"
                        ' Eliminar  
                        ''''''''''''''''''''''  
                        'Elimina la entrada con DeleteValue  
                    Case False
                        If .GetValue(subClave, "").ToString <> "" Then
                            .DeleteValue(subClave) ' eliminar  
                            msg = "Ok .. clave eliminada"
                        Else

                            msg = "No se eliminó , por que el programa" &
                                   " no iniciaba con windows"
                        End If
                End Select
            End With
            ' Error  
            ''''''''''''''''''''''  
        Catch ex As Exception
            msg = ex.Message.ToString
        End Try
        'retorno  
        Return msg
    End Function

    Private Sub r1_CheckedChanged(sender As Object, e As EventArgs) Handles r1.CheckedChanged
        Dim cp As New Cparametros
        Dim pp As New parametros
        If r1.Checked = True Then
            pp.valor = "True"
            pp.descripcion = "revision automatica"
            cp.guardar_parametro(pp)
            revision_automatica = True
        End If
    End Sub

    Private Sub r2_CheckedChanged(sender As Object, e As EventArgs) Handles r2.CheckedChanged
        Dim cp As New Cparametros
        Dim pp As New parametros
        If r2.Checked = True Then
            pp.valor = "False"
            pp.descripcion = "revision automatica"
            cp.guardar_parametro(pp)
            revision_automatica = False
        End If
    End Sub
End Class