Public Class RataNormal
    Implements IRata
    Dim Random As New Random
    Private _vida As Integer = 22
    Public Property Salud As Integer
        Get
            Return _vida
        End Get
        Set(value As Integer)
            _vida = value
        End Set
    End Property
    Public Function Atacar() As Integer Implements IRata.Atacar
        '
        Return Random.Next(4, 6)
    End Function

    Public Function RegresarVida() As Integer Implements IRata.RegresesarVida
        MessageBox.Show("Has obtenido algo del queso de la rata y has recuperado algunos puntos de vida")
        Return 4
    End Function
End Class
