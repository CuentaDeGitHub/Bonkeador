<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Menu))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.btnCrearPersonaje = New System.Windows.Forms.Button()
        Me.btnIniciarPartida = New System.Windows.Forms.Button()
        Me.btnInformacion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitulo.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(12, 19)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(66, 30)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Bonk "
        '
        'btnCrearPersonaje
        '
        Me.btnCrearPersonaje.Location = New System.Drawing.Point(201, 201)
        Me.btnCrearPersonaje.Name = "btnCrearPersonaje"
        Me.btnCrearPersonaje.Size = New System.Drawing.Size(98, 37)
        Me.btnCrearPersonaje.TabIndex = 1
        Me.btnCrearPersonaje.Text = "Crear Personaje"
        Me.btnCrearPersonaje.UseVisualStyleBackColor = True
        '
        'btnIniciarPartida
        '
        Me.btnIniciarPartida.Location = New System.Drawing.Point(63, 201)
        Me.btnIniciarPartida.Name = "btnIniciarPartida"
        Me.btnIniciarPartida.Size = New System.Drawing.Size(98, 37)
        Me.btnIniciarPartida.TabIndex = 2
        Me.btnIniciarPartida.Text = "Iniciar Partida"
        Me.btnIniciarPartida.UseVisualStyleBackColor = True
        '
        'btnInformacion
        '
        Me.btnInformacion.Location = New System.Drawing.Point(63, 265)
        Me.btnInformacion.Name = "btnInformacion"
        Me.btnInformacion.Size = New System.Drawing.Size(98, 42)
        Me.btnInformacion.TabIndex = 4
        Me.btnInformacion.Text = "Informacion"
        Me.btnInformacion.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(201, 265)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 42)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "El   juego"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 354)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 354)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnInformacion)
        Me.Controls.Add(Me.btnIniciarPartida)
        Me.Controls.Add(Me.btnCrearPersonaje)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Menu"
        Me.Text = "Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents btnCrearPersonaje As Button
    Friend WithEvents btnIniciarPartida As Button
    Friend WithEvents btnInformacion As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
