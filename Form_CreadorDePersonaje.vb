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
        Dim eGenero As String
        Dim OutputNombre As String = txtNombreDelPersonaje.Text

        If rbtnGeneroHombre.Checked Then
            eGenero = "Hombre"
        Else eGenero = "Mujer"
        End If
        Dim OutPutClase As String = cmbxClase.Text
        Dim Jugador As Entidad
        Select Case OutPutClase

            Case "Enclenque"
                Dim Personaje As New BonkeadorExperto(OutputNombre, eGenero, 5, 15, 5, 20)
                Jugador = Personaje
            Case "Peleador"
                Dim Personaje As New BonkeadorExperto(OutputNombre, eGenero, 13, 30, 5, 5)
                Jugador = Personaje
            Case "Escurridizo"
                Dim Personaje As New BonkeadorExperto(OutputNombre, eGenero, 10, 25, 15, 10)
                Jugador = Personaje
        End Select

        MessageBox.Show(String.Format("{0} sido creado." & " {0} es un " & cmbxClase.Text & " {1}.", Jugador.Nombre, Jugador.Genero.ToString()))
        MessageBox.Show("Guarda tu personaje")


        Dim Dialogo As New FolderBrowserDialog

        If (Dialogo.ShowDialog() = DialogResult.OK) Then

            Dim Ruta As String = Dialogo.SelectedPath & "\\" & Jugador.Nombre & ".txt"
            Dim Datos As String = (OutPutClase & "," & Jugador.Nombre & "," & Jugador.Genero & "," & Jugador.Fuerza & "," & Jugador.Salud & "," & Jugador.Destreza & "," & Jugador.Inteligencia())
            GuardarDatos(Ruta, Datos)
            '    
        End If

        Close()


    End Sub
End Class