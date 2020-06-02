Public Class Form_CreadorDePersonaje
    Public Sub Jalar()

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gboxGenero.Enter

    End Sub

    Private Sub Form_CreadorDePersonaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If (String.IsNullOrWhiteSpace(txtNombreDelPersonaje.Text)) Then
            MessageBox.Show("Mano el nombre")
            Return
        End If
        If (rbtnGeneroHombre.Checked = False And rbtnGeneroMujer.Checked = False) Then
            MessageBox.Show("Elige un genero")
            Return
        End If
        If (String.IsNullOrEmpty(cmbxClase.Text)) Then
            MessageBox.Show("Selecciona tu clase")
            Return
        End If
        Dim OutputNombre As String = txtNombreDelPersonaje.Text
            Dim OutputGenero As String = ""
            If rbtnGeneroHombre.Checked Then
                OutputGenero = "Hombre"
            Else OutputGenero = "Mujer"
            End If
        Dim OutPutClase As String = cmbxClase.Text
        MessageBox.Show("Guarda tu personaje")
        Dim Maguito As New Mago()
        Dim Dialogo As New FolderBrowserDialog

        If (Dialogo.ShowDialog() = DialogResult.OK) Then
            'OutPutNombre sera igual al nombre del archivo
            'Introducir todos los atributos del personaje al archivo
            'Usar Destructor
            'Cerrar ventanita
        End If



    End Sub
End Class