﻿

Public Class Principal
    Dim ProgresoFaltante As Integer = 100
    Dim TiempoRestante As Integer = 150
    Dim Jugador As BonkeadorExperto
    Dim R As New Random
    Dim RataGenerica As New RataNormal
    Dim EncuentrosYCombates As New Combate

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Seleccione el perfil del jugador")
        Dim Seleccionar As New OpenFileDialog
        If (Seleccionar.ShowDialog() = DialogResult.OK) Then
            Try
                Dim Ruta As String = Seleccionar.FileName
                Dim Linea As String = System.IO.File.ReadAllText(Ruta)
                Dim Datos() As String = Linea.Split(",")
                '0 Clase
                '1 Nombre
                '2 Genero
                '3 Fuerza
                '4 Salud
                '5 Destreza
                '6 Inteligencia

                Dim Bonk As New BonkeadorExperto(Datos(1), Datos(2), Datos(3), Datos(4), Datos(5), Datos(6))
                Jugador = Bonk
                lblNombre.Text = Jugador.Nombre
                lblVida.Text = Jugador.Salud
            Catch ex As Exception
                MessageBox.Show("Seleccione un archivo valido")
            End Try


        End If
    End Sub

    Private Sub btnMoverseNormalmente_Click(sender As Object, e As EventArgs) Handles btnMoverseNormalmente.Click
        MessageBox.Show("Avanzas rapidamente y sin ningun cuidado por la ciudad para escapar")
        Dim IntEncuentro As Integer = R.Next(0, 7)
        ProgresoFaltante -= 10
        If (ProgresoFaltante <= 0) Then
            MessageBox.Show("Has escapado de la ciudad")
            Me.Close()
        End If
        TiempoRestante -= 10
        If (TiempoRestante < 0) Then
            PictureBox1.Image = My.Resources.RataSeñalando
            MessageBox.Show("No has logrado escapar a tiempo de la ciudad, las ratas te bonkean")
            Me.Close()
        End If
        prgbarEscape.Value = prgbarEscape.Value + 10
        If (prgbarEscape.Value = 100) Then
            MessageBox.Show("Has escapado!")
            Me.Close()
        End If
        Encuentros(Jugador, IntEncuentro)



    End Sub

    Private Sub btnMoverseSigilosamente_Click(sender As Object, e As EventArgs) Handles btnMoverseSigilosamente.Click
        MessageBox.Show("Te mueves lenta y sigiolosamente por la ciudad para intentar escapar")
        Dim IntEncuentro As Integer = R.Next(0, 11)
        ProgresoFaltante -= 10
        If (ProgresoFaltante <= 0) Then
            MessageBox.Show("Has escapado de la ciudad")
            Me.Close()
        End If
        TiempoRestante -= 20
        If (TiempoRestante < 0) Then
            PictureBox1.Image = My.Resources.RataSeñalando
            MessageBox.Show("No has logrado escapar a tiempo de la ciudad, las ratas te bonkean")
            Me.Close()
        End If
        prgbarEscape.Value = prgbarEscape.Value + 10
        Encuentros(Jugador, IntEncuentro)


    End Sub

    Private Sub btnDescansar_Click(sender As Object, e As EventArgs) Handles btnDescansar.Click
        MessageBox.Show("Te has detenido unos minutos para poder descanar, has recuperado 10 puntos de vida")
        Jugador.Salud += 10
        TiempoRestante -= 10
        If (TiempoRestante <= 0) Then
            MessageBox.Show("No has logrado escapar a tiempo de la ciudad, las ratas te bonkean")
            PictureBox1.Image = My.Resources.RatBonk
            Me.Close()
        End If
        lblVida.Text = Jugador.Salud

    End Sub

    Private Sub btnProgreso_Click(sender As Object, e As EventArgs) Handles btnProgresoTiempo.Click
        MessageBox.Show("Metros por recorrer :" & ProgresoFaltante & " metros")
        MessageBox.Show("Minutos restantes :" & TiempoRestante & " minutos antes de que las ratas te alcanzen")
    End Sub

    Private Sub btnBonkear_Click(sender As Object, e As EventArgs) Handles btnBonkear.Click
        Dim DañoRecibido As Integer = EncuentrosYCombates.CombateGenerico(Jugador, RataGenerica)
        MessageBox.Show("Gracias a tu fuerza, lograste derrotar a la rata, pero recibiste " & DañoRecibido & " puntos de daño")
        Jugador.Salud -= DañoRecibido
        lblVida.Text = Jugador.Salud
        If (Jugador.Salud > 0) Then
            Jugador.Salud += RataGenerica.RegresarVida
            lblVida.Text = Jugador.Salud
            gboxCombate.Visible = False
            gboxPrincipal.Visible = True
        ElseIf (Jugador.Salud <= 0) Then
            MessageBox.Show("Fuiste derrotado por la rata. Bonk")
            PictureBox1.Image = My.Resources.RatBonk
            Me.Close()
        End If
        PictureBox1.Image = My.Resources.Ciudad
    End Sub
    Public Sub Encuentros(Jugador As BonkeadorExperto, intEncuentro As Integer)
        Select Case ProgresoFaltante
            Case 50
                If (MessageBox.Show("Hay una gran cantidad de escombros enfrente de ti, deseas utilizar tu fuerza para moverlos y evitar rodearlos?", "Evento", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    If (Jugador.Fuerza >= 10) Then
                        MessageBox.Show("Logras mover los escombros con facilidad")
                    ElseIf (Jugador.Fuerza < 10) Then
                        MessageBox.Show("Debido a tu falta de fuerza te ves forzado a rodear y perder mas tiempo")
                        TiempoRestante -= 10
                        gboxPrincipal.Visible = False
                        gboxCombate.Visible = True
                    End If
                ElseIf (DialogResult.No) Then
                    MessageBox.Show("Decides rodear, perdiendo asi mas tiempo")
                    TiempoRestante -= 10
                    gboxPrincipal.Visible = False
                    gboxCombate.Visible = True
                End If
            Case 20
                If (MessageBox.Show("Hay una rata durmiendo en el camino, desea rodearla e impedir la pelea?", "Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                    If (Jugador.Destreza > 10) Then
                        MessageBox.Show("Logras rodear a la rata de manera sigilosa sin despertarla")
                    ElseIf (Jugador.Destreza < 10) Then
                        MessageBox.Show("Debido a tu falta de sigilo terminas despertando a la rata")
                        PictureBox1.Image = My.Resources.RataSeñalando
                        gboxPrincipal.Visible = False
                        gboxCombate.Visible = True
                    End If
                ElseIf (DialogResult.No) Then
                    PictureBox1.Image = My.Resources.RataSeñalando
                    gboxPrincipal.Visible = False
                    gboxCombate.Visible = True

                End If
            Case 10
                MessageBox.Show("La rata mas inteligente que has visto esta en tu camino, no puedes evitar esta pelea")
                PictureBox1.Image = My.Resources.BonkProof
                gboxPrincipal.Visible = False
                gboxCombate.Visible = True
            Case Else
                If (intEncuentro <= 3) Then

                    MessageBox.Show("Una rata te impide tu progreso")
                    PictureBox1.Image = My.Resources.Rata
                    gboxCombate.Visible = True
                    gboxPrincipal.Visible = False
                Else

                End If
        End Select
    End Sub
End Class