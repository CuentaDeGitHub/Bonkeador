Public Class Form_Menu
    Private Sub LblTitulo_Click(sender As Object, e As EventArgs) Handles LblTitulo.Click

    End Sub

    Private Sub btnCrearPersonaje_Click(sender As Object, e As EventArgs) Handles btnCrearPersonaje.Click
        Dim FormCreador As New Form_CreadorDePersonaje
        FormCreador.Show()
    End Sub

    Private Sub btnIniciarPartida_Click(sender As Object, e As EventArgs) Handles btnIniciarPartida.Click
        If (MessageBox.Show("Ya posees un personaje creado? De lo contrario presiona -No- para crear uno", "Inicio de Juego", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand)) = DialogResult.Yes Then
            Dim Juego As New Principal
            Principal.Show()
        ElseIf DialogResult.No Then
            Dim FormCreador As New Form_CreadorDePersonaje
            FormCreador.Show()
        ElseIf DialogResult.Cancel Then
        End If

    End Sub
End Class
