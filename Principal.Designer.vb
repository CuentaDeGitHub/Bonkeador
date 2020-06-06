<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.btnDescansar = New System.Windows.Forms.Button()
        Me.btnMoverseSigilosamente = New System.Windows.Forms.Button()
        Me.btnProgresoTiempo = New System.Windows.Forms.Button()
        Me.btnMoverseNormalmente = New System.Windows.Forms.Button()
        Me.gboxPrincipal = New System.Windows.Forms.GroupBox()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.btnBonkear = New System.Windows.Forms.Button()
        Me.gboxCombate = New System.Windows.Forms.GroupBox()
        Me.lblVida = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.prgbarEscape = New System.Windows.Forms.ProgressBar()
        Me.Progreso = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gboxPrincipal.SuspendLayout()
        Me.gboxCombate.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDescansar
        '
        Me.btnDescansar.Location = New System.Drawing.Point(16, 85)
        Me.btnDescansar.Name = "btnDescansar"
        Me.btnDescansar.Size = New System.Drawing.Size(99, 50)
        Me.btnDescansar.TabIndex = 0
        Me.btnDescansar.Text = "Descansar"
        Me.btnDescansar.UseVisualStyleBackColor = True
        '
        'btnMoverseSigilosamente
        '
        Me.btnMoverseSigilosamente.Location = New System.Drawing.Point(131, 29)
        Me.btnMoverseSigilosamente.Name = "btnMoverseSigilosamente"
        Me.btnMoverseSigilosamente.Size = New System.Drawing.Size(99, 50)
        Me.btnMoverseSigilosamente.TabIndex = 1
        Me.btnMoverseSigilosamente.Text = "Moverse sigilosamente"
        Me.btnMoverseSigilosamente.UseVisualStyleBackColor = True
        '
        'btnProgresoTiempo
        '
        Me.btnProgresoTiempo.Location = New System.Drawing.Point(131, 85)
        Me.btnProgresoTiempo.Name = "btnProgresoTiempo"
        Me.btnProgresoTiempo.Size = New System.Drawing.Size(99, 50)
        Me.btnProgresoTiempo.TabIndex = 2
        Me.btnProgresoTiempo.Text = "Mirar hacia atras"
        Me.btnProgresoTiempo.UseVisualStyleBackColor = True
        '
        'btnMoverseNormalmente
        '
        Me.btnMoverseNormalmente.Location = New System.Drawing.Point(16, 29)
        Me.btnMoverseNormalmente.Name = "btnMoverseNormalmente"
        Me.btnMoverseNormalmente.Size = New System.Drawing.Size(99, 50)
        Me.btnMoverseNormalmente.TabIndex = 3
        Me.btnMoverseNormalmente.Text = "Moverte"
        Me.btnMoverseNormalmente.UseVisualStyleBackColor = True
        '
        'gboxPrincipal
        '
        Me.gboxPrincipal.Controls.Add(Me.btnMoverseNormalmente)
        Me.gboxPrincipal.Controls.Add(Me.btnProgresoTiempo)
        Me.gboxPrincipal.Controls.Add(Me.btnMoverseSigilosamente)
        Me.gboxPrincipal.Controls.Add(Me.btnDescansar)
        Me.gboxPrincipal.Location = New System.Drawing.Point(22, 284)
        Me.gboxPrincipal.Name = "gboxPrincipal"
        Me.gboxPrincipal.Size = New System.Drawing.Size(248, 154)
        Me.gboxPrincipal.TabIndex = 4
        Me.gboxPrincipal.TabStop = False
        Me.gboxPrincipal.Text = "Grupo Principal"
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(9, 211)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(50, 13)
        Me.lblPrincipal.TabIndex = 4
        Me.lblPrincipal.Text = "Nombre :"
        '
        'btnBonkear
        '
        Me.btnBonkear.Location = New System.Drawing.Point(6, 19)
        Me.btnBonkear.Name = "btnBonkear"
        Me.btnBonkear.Size = New System.Drawing.Size(79, 26)
        Me.btnBonkear.TabIndex = 4
        Me.btnBonkear.Text = "Bonkear"
        Me.btnBonkear.UseVisualStyleBackColor = True
        '
        'gboxCombate
        '
        Me.gboxCombate.Controls.Add(Me.btnBonkear)
        Me.gboxCombate.Location = New System.Drawing.Point(99, 225)
        Me.gboxCombate.Name = "gboxCombate"
        Me.gboxCombate.Size = New System.Drawing.Size(93, 53)
        Me.gboxCombate.TabIndex = 6
        Me.gboxCombate.TabStop = False
        Me.gboxCombate.Text = "GrupoCombate"
        Me.gboxCombate.Visible = False
        '
        'lblVida
        '
        Me.lblVida.AutoSize = True
        Me.lblVida.Location = New System.Drawing.Point(231, 211)
        Me.lblVida.Name = "lblVida"
        Me.lblVida.Size = New System.Drawing.Size(39, 13)
        Me.lblVida.TabIndex = 7
        Me.lblVida.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Vida :"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(65, 211)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Label3"
        '
        'prgbarEscape
        '
        Me.prgbarEscape.ForeColor = System.Drawing.SystemColors.Desktop
        Me.prgbarEscape.Location = New System.Drawing.Point(37, 444)
        Me.prgbarEscape.Maximum = 110
        Me.prgbarEscape.Name = "prgbarEscape"
        Me.prgbarEscape.Size = New System.Drawing.Size(215, 23)
        Me.prgbarEscape.TabIndex = 10
        '
        'Progreso
        '
        Me.Progreso.AutoSize = True
        Me.Progreso.Location = New System.Drawing.Point(124, 470)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(49, 13)
        Me.Progreso.TabIndex = 11
        Me.Progreso.Text = "Progreso"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NoSoyOriginal.My.Resources.Resources.Ciudad
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 485)
        Me.Controls.Add(Me.Progreso)
        Me.Controls.Add(Me.prgbarEscape)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVida)
        Me.Controls.Add(Me.gboxCombate)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gboxPrincipal)
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.gboxPrincipal.ResumeLayout(False)
        Me.gboxCombate.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDescansar As Button
    Friend WithEvents btnMoverseSigilosamente As Button
    Friend WithEvents btnProgresoTiempo As Button
    Friend WithEvents btnMoverseNormalmente As Button
    Friend WithEvents gboxPrincipal As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPrincipal As Label
    Friend WithEvents btnBonkear As Button
    Friend WithEvents gboxCombate As GroupBox
    Friend WithEvents lblVida As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents prgbarEscape As ProgressBar
    Friend WithEvents Progreso As Label
End Class
