Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class Cconexion

    Private cadena As String = "Server=localhost;User Id=root;Password=;Persist Security Info=True;Database=viewservergz"
    Dim conexion As MySqlConnection

    Public Sub Conectar()

        Try
            conexion = New MySqlConnection(cadena)
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se puede Conectar a la BD.")
            conexion.Close()
        End Try
    End Sub


    Public Function conx() As MySqlConnection
        Return conexion
    End Function
    Public Sub cerrar()
        conexion.Close()
    End Sub
End Class
