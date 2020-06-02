Public Class BonkeadorExperto
    Inherits Jugador

    Public Sub New()
        MyBase.New()

    End Sub

    Public Sub New(ByVal nombre As String, ByVal genero As EntidadGenero)
        MyBase.New()
        _nombre = nombre
        _genero = genero
        Fuerza = Random.Next(15, 21)
        Vida = 40
        Destreza = 8
        Defensa = 14
        Inteligencia = 8
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
