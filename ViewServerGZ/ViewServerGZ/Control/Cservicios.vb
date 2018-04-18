﻿Imports MySql.Data.MySqlClient

Public Class Cservicios
    Inherits Cconexion

    Dim _tabla As New DataTable
    Public Function buscar_servicio_servidor(ByVal servidor As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT idservicio from tblservidorservicios WHERE idservidor='" + servidor + "'", conx)
            adap.Fill(_tabla)
            If _tabla.Rows.Count < 1 Then
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

    Public Function buscar_servicio(ByVal idservicio As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT nombreservicio from tblservicios WHERE idservicio='" + idservicio + "'", conx)
            adap.Fill(_tabla)
        Catch ex As Exception
            estado = False
            MsgBox("error consulta")
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function buscar_servicio_con_detalle(ByVal idservicio As String)
        Dim estado As Boolean = True
        Try
            Dim adap As New MySqlDataAdapter()
            Conectar()
            adap.SelectCommand = New MySqlCommand("SELECT * from tblservicios WHERE idservicio='" + idservicio + "'", conx)
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
