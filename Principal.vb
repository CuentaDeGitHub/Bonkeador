Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Seleccione el perfil del jugador")
        Dim Dialogo As New FolderBrowserDialog
        If (Dialogo.ShowDialog() = DialogResult.OK) Then
            'Leer archivo y mandar a llamar al constructor de la clase con los datos que viene

        End If
    End Sub
End Class