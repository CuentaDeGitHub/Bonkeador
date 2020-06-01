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
        Me.btnEmpezarPartida = New System.Windows.Forms.Button()
        Me.btnCargarPartida = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCreditos = New System.Windows.Forms.Button()
        Me.btnOpciones = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitulo.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(27, 19)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(66, 30)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Bonk "
        '
        'btnEmpezarPartida
        '
        Me.btnEmpezarPartida.Location = New System.Drawing.Point(134, 210)
        Me.btnEmpezarPartida.Name = "btnEmpezarPartida"
        Me.btnEmpezarPartida.Size = New System.Drawing.Size(98, 37)
        Me.btnEmpezarPartida.TabIndex = 1
        Me.btnEmpezarPartida.Text = "Nueva Partida"
        Me.btnEmpezarPartida.UseVisualStyleBackColor = True
        '
        'btnCargarPartida
        '
        Me.btnCargarPartida.Location = New System.Drawing.Point(257, 210)
        Me.btnCargarPartida.Name = "btnCargarPartida"
        Me.btnCargarPartida.Size = New System.Drawing.Size(98, 37)
        Me.btnCargarPartida.TabIndex = 2
        Me.btnCargarPartida.Text = "Cargar Partida"
        Me.btnCargarPartida.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCreditos
        '
        Me.btnCreditos.Location = New System.Drawing.Point(257, 262)
        Me.btnCreditos.Name = "btnCreditos"
        Me.btnCreditos.Size = New System.Drawing.Size(98, 37)
        Me.btnCreditos.TabIndex = 4
        Me.btnCreditos.Text = "Creditos"
        Me.btnCreditos.UseVisualStyleBackColor = True
        '
        'btnOpciones
        '
        Me.btnOpciones.Location = New System.Drawing.Point(134, 262)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Size = New System.Drawing.Size(98, 37)
        Me.btnOpciones.TabIndex = 5
        Me.btnOpciones.Text = "Opciones"
        Me.btnOpciones.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 353)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "El   RPG"
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 354)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpciones)
        Me.Controls.Add(Me.btnCreditos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCargarPartida)
        Me.Controls.Add(Me.btnEmpezarPartida)
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
    Friend WithEvents btnEmpezarPartida As Button
    Friend WithEvents btnCargarPartida As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCreditos As Button
    Friend WithEvents btnOpciones As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
