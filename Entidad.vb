

Public MustInherit Class Entidad
    Protected Random As New Random
#Region "Variables"
    Protected _nombre As String
    Protected _genero As String
    Protected _fuerza As Integer
    Protected _destreza As Integer
    Protected _vida As Integer
    Protected _inteligencia As Integer
    Protected _defensa As Integer

#End Region

#Region "Propiedades"
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return _genero
        End Get
        Set
        End Set
    End Property

    Public Property Fuerza As Integer
        Get
            Return _fuerza
        End Get
        Set(value As Integer)
            _fuerza = value
        End Set
    End Property

    Public Property Destreza As Integer
        Get
            Return _destreza
        End Get
        Set(value As Integer)
            _destreza = value
        End Set
    End Property

    Public Property Salud As Integer
        Get
            Return _vida
        End Get
        Set(value As Integer)
            _vida = value
        End Set
    End Property

    Public Property Inteligenciaa As Integer
        Get
            Return _inteligencia
        End Get
        Set(value As Integer)
            _inteligencia = value
        End Set
    End Property

    Public Property Defensa As Integer
        Get
            Return _defensa
        End Get
        Set(value As Integer)
            _defensa = value
        End Set
    End Property

    Public Property Inteligencia As Integer
        Get
            Return _inteligencia
        End Get
        Set(value As Integer)
            _inteligencia = value
        End Set
    End Property


#End Region

#Region "Metodos"
    Public MustOverride Function Atacar() As Integer
    Public MustOverride Function MoverseSigilosamente() As Integer
#End Region

#Region "Constructores"
    Public Sub New()
        Nombre = ""
        Genero = ""
        Fuerza = 0
        Salud = 0
        Destreza = 0
        Defensa = 0
        Inteligencia = 0

    End Sub
#End Region

End Class
