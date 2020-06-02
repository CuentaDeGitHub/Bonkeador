Public Class Form_CreadorDePersonaje
    Public Sub GuardarDatos(ByVal Ruta As String, ByVal Datos As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(Ruta, True)
        file.WriteLine(Datos)
        file.Close()
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
        Dim eGenero As New EntidadGenero
        Dim OutputNombre As String = txtNombreDelPersonaje.Text

        If rbtnGeneroHombre.Checked Then
            eGenero = EntidadGenero.Hombre
        Else eGenero = EntidadGenero.Mujer
        End If
        Dim OutPutClase As String = cmbxClase.Text
        Dim Jugador As New Jugador
        Select Case OutPutClase

            Case "Mago"
                Dim Personaje As New Mago(OutputNombre, eGenero)
                Jugador = Personaje
            Case "Bonkeador"
                Dim Personaje As New BonkeadorExperto(OutputNombre, eGenero)
                Jugador = Personaje
            Case "Picaro"
                Dim Personaje As New Picaro(OutputNombre, eGenero)
                Jugador = Personaje
        End Select

        MessageBox.Show(String.Format("{0} ha sido creado." & "{0} es un Mago {1}.", Jugador.Nombre, Jugador.Genero.ToString()))
        MessageBox.Show("Guarda tu personaje")


        Dim Dialogo As New FolderBrowserDialog

        If (Dialogo.ShowDialog() = DialogResult.OK) Then

            Dim Ruta As String = Dialogo.SelectedPath & "\\" & JUgador.Nombre & ".txt"
            Dim Datos As String = (OutPutClase & "," & Jugador.Nombre & "," & Jugador.Genero.ToString & "," & Jugador.Vida & "," & Jugador.Defensa & "," & Jugador.Fuerza & "," & Jugador.Destreza & "," & Jugador.Inteligencia())
            GuardarDatos(Ruta, Datos)

            '    'OutPutNombre sera igual al nombre del archivo
            '    'Introducir todos los atributos del personaje al archivo
            '    'Usar Destructor
            '    'Cerrar ventanita
        End If

        Close()


    End Sub
End Class