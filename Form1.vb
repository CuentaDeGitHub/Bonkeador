Public Class Form_Menu
    Private Sub LblTitulo_Click(sender As Object, e As EventArgs) Handles LblTitulo.Click

    End Sub

    Private Sub btnCrearPersonaje_Click(sender As Object, e As EventArgs) Handles btnEmpezarPartida.Click
        Dim FormCreador As New Form_CreadorDePersonaje
        FormCreador.Show()
    End Sub
End Class
