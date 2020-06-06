Public Class Combate
    Public Function CombateGenerico(ByVal p As BonkeadorExperto, ByVal rata As RataNormal) As Integer
        Dim Contador As Integer = 0
        rata.Salud = 20
        While (rata.Salud > 0)
            rata.Salud -= p.Atacar
            Contador = Contador + 1
        End While
        Return Contador * rata.Atacar
    End Function
End Class
