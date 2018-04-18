Public Class Servidor
    Private _idservidor As Integer
    Private _descripcion As String
    Private _direccionip As String
    Private _direccionmac As String
    Private _ubicacion As String


    Public Property idservidor() As Integer
        Get
            Return _idservidor
        End Get
        Set(ByVal value As Integer)
            _idservidor = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property


    Public Property direccionip() As String
        Get
            Return _direccionip
        End Get
        Set(ByVal value As String)
            _direccionip = value
        End Set
    End Property

    Public Property direccionmac() As String
        Get
            Return _direccionmac
        End Get
        Set(ByVal value As String)
            _direccionmac = value
        End Set
    End Property

    Public Property ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property
End Class
