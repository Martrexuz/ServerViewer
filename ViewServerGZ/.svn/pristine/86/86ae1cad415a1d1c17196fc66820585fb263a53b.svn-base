Imports MySql.Data.MySqlClient

Public Class Cso
    Inherits Cconexion

    Dim _tabla As New DataTable
    Public Function buscar_so_tipo(ByVal dato As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT nombresotipo FROM tblsotipo WHERE idsotipo=(SELECT idsotipo FROM tblso WHERE idso=(SELECT idso FROM tblsoservidor WHERE idservidor='" + dato + "'))", conx)
            adap.Fill(_tabla)
            If tabla.Rows.Count = 0 Then
                estado = False
            End If
        Catch ex As Exception
            estado = False
            MsgBox("error consulta")
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function buscar_so_descripcion(ByVal dato As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT descripcion FROM tblso WHERE idso=(SELECT idso FROM tblsoservidor WHERE idservidor='" + dato + "')", conx)
            adap.Fill(_tabla)
            If tabla.Rows.Count = 0 Then
                estado = False
            End If
        Catch ex As Exception
            estado = False
            MsgBox("error consulta")
        Finally
            cerrar()
        End Try
        Return estado
    End Function


    Public Function tabla() As DataTable
        Return _tabla
    End Function
End Class
