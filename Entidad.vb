Public Enum EntidadGenero
    Hombre
    Mujer
    Desconocido
End Enum

'Public Enum EntidadClase
'    Bonkeador
'    Mago
'    Picaro
'    Guerrero
'End Enum

Public MustInherit Class Entidad
    Protected Random As New Random
#Region "Variables"
    Protected _nombre As String
    Protected _genero As EntidadGenero
    Protected _fuerza As Integer
    Protected _destreza As Integer
    Protected _vida As Integer
    Protected _inteligencia As Integer
    Protected _modificadorDeFuerza As Integer
    Protected _modificadorDeDestreza As Integer
    Protected _modificadorDeVida As Integer
    Protected _defensa As Integer
    Protected _modificadorDeDefensa As Integer



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

    Public Property Genero As EntidadGenero
        Get
            Return _genero
        End Get
        Set
        End Set
    End Property

    Public Property Fuerza As Integer
        Get
            Return _fuerza + _modificadorDeFuerza
        End Get
        Protected Set(value As Integer)
            _fuerza = value
        End Set
    End Property

    Public Property Destreza As Integer
        Get
            Return _destreza + _modificadorDeDestreza
        End Get
        Protected Set(value As Integer)
            _destreza = value
        End Set
    End Property

    Public Property Salud As Integer
        Get
            Return _vida + _modificadorDeVida
        End Get
        Protected Set(value As Integer)
            _vida = value
        End Set
    End Property

    Public Property Vida As Integer
        Get
            Return _inteligencia
        End Get
        Protected Set(value As Integer)
            _inteligencia = value
        End Set
    End Property

    Public Property Defensa As Integer
        Get
            Return _defensa + _modificadorDeDefensa
        End Get
        Protected Set(value As Integer)
            _defensa = value
        End Set
    End Property

    Public Property Inteligencia As Integer
        Get
            Return _inteligencia
        End Get
        Protected Set(value As Integer)
            _inteligencia = value
        End Set
    End Property


#End Region

#Region "Metodos"

#End Region

#Region "Constructores"
    Public Sub New()
        Nombre = ""
        Fuerza = 0
        Vida = 0
        Destreza = 0
        Defensa = 0
        Inteligencia = 0

    End Sub
#End Region

End Class
