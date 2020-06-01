Public Class Form_CreadorDePersonaje
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gboxGenero.Enter

    End Sub

    Private Sub Form_CreadorDePersonaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click

        Dim OutputNombre As String = ""
        OutputNombre = txtNombreDelPersonaje.Text
        Dim OutputGenero As String = ""
        If rbtnGeneroHombre.Checked Then
            OutputGenero = "Hombre"
        Else OutputGenero = "Mujer"
        End If
        Dim OutPutClase As String = ""
        OutPutClase = cmbxClase.Text
        MessageBox.Show("Nombre : " & OutputNombre)
        MessageBox.Show("Genero : " & OutputGenero)
        MessageBox.Show("Clase : " & OutPutClase)


    End Sub
End Class