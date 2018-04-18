Imports MySql.Data.MySqlClient

Public Class Cservidor
    Inherits Cconexion

    Dim _tabla As New DataTable
    Public Function Listar_servidores()
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT * from tblservidor ", conx)
            adap.Fill(_tabla)
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
