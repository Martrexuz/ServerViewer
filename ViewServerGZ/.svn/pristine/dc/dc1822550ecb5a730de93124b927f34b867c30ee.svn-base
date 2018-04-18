Imports MySql.Data.MySqlClient

Public Class Caplicacion
    Inherits Cconexion

    Dim _tabla As New DataTable

    Public Function Buscar_aplicacion_servidor(ByVal servidor As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT idaplicacion FROM tblaplicacionservidor WHERE idservidor=" + servidor + "", conx)
            adap.Fill(_tabla)
        Catch ex As Exception
            estado = False
            MsgBox("error al buscar la aplicacion")
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function Buscar_aplicacion(ByVal id As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT * from tblaplicacion WHERE idaplicacion='" + id + "'", conx)
            adap.Fill(_tabla)
        Catch ex As Exception
            estado = False
            MsgBox("error al buscar el puerto")
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    Public Function tabla() As DataTable
        Return _tabla
    End Function
End Class
