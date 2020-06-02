Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Seleccione el perfil del jugador")
        Dim Seleccionar As New OpenFileDialog
        If (Seleccionar.ShowDialog() = DialogResult.OK) Then
            Dim Ruta As String = Seleccionar.FileName
            Dim Datos As String = System.IO.File.ReadAllText(Ruta)
            MessageBox.Show(Datos)

        End If
    End Sub
End Class