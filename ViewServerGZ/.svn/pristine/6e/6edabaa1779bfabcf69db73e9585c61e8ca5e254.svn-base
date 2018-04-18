Imports MySql.Data.MySqlClient
Public Class Cparametros
    Inherits Cconexion

    Dim _tabla As New DataTable


    Public Function Buscar_valor_parametros(ByVal nombre As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT valor from tblparametros WHERE descripcion='" + nombre + "'", conx)
            adap.Fill(_tabla)
            If _tabla.Rows.Count = 0 Then
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

    Public Function guardar_parametro(ByRef datos As parametros) As Boolean
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.UpdateCommand = New MySqlCommand("UPDATE tblparametros set valor=@valor WHERE descripcion=@descripcion", conx)
            adap.UpdateCommand.Parameters.Add("@valor", MySqlDbType.VarChar, 50).Value = datos.valor
            adap.UpdateCommand.Parameters.Add("@descripcion", MySqlDbType.VarChar, 50).Value = datos.descripcion

            adap.UpdateCommand.Connection = conx()
            adap.UpdateCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
            MsgBox("error consulta parametros")
        Finally
            cerrar()
        End Try
        Return estado
    End Function
    Public Function tabla() As DataTable
        Return _tabla
    End Function
End Class
