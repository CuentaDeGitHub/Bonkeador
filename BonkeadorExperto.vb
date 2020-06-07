Public Class BonkeadorExperto
    Inherits Entidad

    Public Sub New()
        MyBase.New()

    End Sub

    Public Sub New(ByVal nombre As String, ByVal genero As String, ByVal fuerza As Integer,
                 ByVal vida As Integer, ByVal destreza As Integer, ByVal inteligencia As Integer)
        MyBase.New()

        _nombre = nombre
        _genero = genero
        _fuerza = fuerza
        _vida = vida
        _destreza = destreza
        _inteligencia = inteligencia
    End Sub

    Protected Overrides Sub Finalize()

        MessageBox.Show("La instancia ha sido tirada a la basura")

    End Sub

    Public Overrides Function Atacar() As Integer
        Return Fuerza - 5
    End Function


End Class
