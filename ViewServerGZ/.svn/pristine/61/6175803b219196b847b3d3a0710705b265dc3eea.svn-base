Imports MySql.Data.MySqlClient

Public Class Chistorial
    Inherits Cconexion

    Dim _tabla As New DataTable

    Public Function guardar_historial(ByRef datos As historial) As Boolean
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.InsertCommand = New MySqlCommand("INSERT INTO tblhistorial (idhistorial,estado,horasactivo,fecharevision,fechacaida,causal,idservidor) VALUES (@idhistorial,@estado,@horasactivo,@fecharevision,@fechacaida,@causal,@idservidor)", conx)
            adap.InsertCommand.Parameters.Add("@idhistorial", MySqlDbType.Int32).Value = Nothing
            adap.InsertCommand.Parameters.Add("@estado", MySqlDbType.Int32).Value = datos.estado
            adap.InsertCommand.Parameters.Add("@horasactivo", MySqlDbType.Double).Value = datos.horasactivo
            adap.InsertCommand.Parameters.Add("@fecharevision", MySqlDbType.DateTime).Value = datos.fecharevision
            adap.InsertCommand.Parameters.Add("@fechacaida", MySqlDbType.DateTime).Value = datos.fechacaida
            adap.InsertCommand.Parameters.Add("@causal", MySqlDbType.VarChar, 50).Value = datos.causal
            adap.InsertCommand.Parameters.Add("@idservidor", MySqlDbType.Int32).Value = datos.idservidor
            adap.InsertCommand.Connection = conx()
            adap.InsertCommand.ExecuteNonQuery()
        Catch ex As Exception
            estado = False
            MsgBox("error consulta")
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function Buscar_horasactivo_max(ByVal servidor As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT MAX(fecharevision),horasactivo FROM tblhistorial WHERE idservidor=" + servidor + "", conx)
            adap.Fill(_tabla)
            If _tabla.Rows.Count <= 0 Then
                estado = False
            End If
        Catch ex As Exception
            estado = False
            MsgBox("error al buscar la hora activa")
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function tabla() As DataTable
        Return _tabla
    End Function



End Class
