Public Class Mago
    Inherits Jugador

    Protected _Mana As Integer
    'Public Property PuntosDeMana As Integer
    '    Get
    '        Return _Mana
    '    End Get
    '    Set(value As Integer)
    '        _Mana = value
    '    End Set
    'End Property
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal nombre As String, ByVal genero As EntidadGenero)
        MyBase.New()
        _nombre = nombre
        _genero = genero
        Fuerza = 8
        Salud = 25
        Destreza = 12
        Defensa = 10
        Inteligencia = Random.Next(15, 19)
    End Sub

    Public Sub New(ByVal nombre As String, ByVal genero As EntidadGenero, ByVal fuerza As Integer,
                   ByVal vida As Integer, ByVal destreza As Integer, ByVal defensa As Integer, ByVal inteligencia As Integer)
        MyBase.New()
        _nombre = nombre
        _genero = genero
        _fuerza = fuerza
        _vida = vida
        _destreza = destreza
        _defensa = defensa
        _inteligencia = inteligencia
    End Sub
End Class
