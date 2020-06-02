<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CreadorDePersonaje
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxGenero = New System.Windows.Forms.GroupBox()
        Me.rbtnGeneroHombre = New System.Windows.Forms.RadioButton()
        Me.rbtnGeneroMujer = New System.Windows.Forms.RadioButton()
        Me.cmbxClase = New System.Windows.Forms.ComboBox()
        Me.lblClase = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtNombreDelPersonaje = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gboxGenero.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del personaje"
        '
        'gboxGenero
        '
        Me.gboxGenero.Controls.Add(Me.rbtnGeneroHombre)
        Me.gboxGenero.Controls.Add(Me.rbtnGeneroMujer)
        Me.gboxGenero.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxGenero.Location = New System.Drawing.Point(48, 64)
        Me.gboxGenero.Name = "gboxGenero"
        Me.gboxGenero.Size = New System.Drawing.Size(175, 68)
        Me.gboxGenero.TabIndex = 2
        Me.gboxGenero.TabStop = False
        Me.gboxGenero.Text = "Genero"
        '
        'rbtnGeneroHombre
        '
        Me.rbtnGeneroHombre.AutoSize = True
        Me.rbtnGeneroHombre.Location = New System.Drawing.Point(6, 32)
        Me.rbtnGeneroHombre.Name = "rbtnGeneroHombre"
        Me.rbtnGeneroHombre.Size = New System.Drawing.Size(89, 29)
        Me.rbtnGeneroHombre.TabIndex = 3
        Me.rbtnGeneroHombre.TabStop = True
        Me.rbtnGeneroHombre.Text = "Hombre"
        Me.rbtnGeneroHombre.UseVisualStyleBackColor = True
        '
        'rbtnGeneroMujer
        '
        Me.rbtnGeneroMujer.AutoSize = True
        Me.rbtnGeneroMujer.Location = New System.Drawing.Point(101, 32)
        Me.rbtnGeneroMujer.Name = "rbtnGeneroMujer"
        Me.rbtnGeneroMujer.Size = New System.Drawing.Size(70, 29)
        Me.rbtnGeneroMujer.TabIndex = 4
        Me.rbtnGeneroMujer.TabStop = True
        Me.rbtnGeneroMujer.Text = "Mujer"
        Me.rbtnGeneroMujer.UseVisualStyleBackColor = True
        '
        'cmbxClase
        '
        Me.cmbxClase.FormattingEnabled = True
        Me.cmbxClase.Items.AddRange(New Object() {"Mago", "Picaro", "Bonkeador"})
        Me.cmbxClase.Location = New System.Drawing.Point(103, 153)
        Me.cmbxClase.Name = "cmbxClase"
        Me.cmbxClase.Size = New System.Drawing.Size(121, 21)
        Me.cmbxClase.TabIndex = 3
        '
        'lblClase
        '
        Me.lblClase.AutoSize = True
        Me.lblClase.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClase.Location = New System.Drawing.Point(43, 150)
        Me.lblClase.Name = "lblClase"
        Me.lblClase.Size = New System.Drawing.Size(54, 25)
        Me.lblClase.TabIndex = 4
        Me.lblClase.Text = "Clase"
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(100, 289)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(116, 32)
        Me.btnCrear.TabIndex = 5
        Me.btnCrear.Text = "Crear personaje"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'txtNombreDelPersonaje
        '
        Me.txtNombreDelPersonaje.Location = New System.Drawing.Point(171, 21)
        Me.txtNombreDelPersonaje.Name = "txtNombreDelPersonaje"
        Me.txtNombreDelPersonaje.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreDelPersonaje.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Informacion de la clase"
        '
        'Form_CreadorDePersonaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 350)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.lblClase)
        Me.Controls.Add(Me.cmbxClase)
        Me.Controls.Add(Me.gboxGenero)
        Me.Controls.Add(Me.txtNombreDelPersonaje)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_CreadorDePersonaje"
        Me.Text = "Crea tu personaje"
        Me.gboxGenero.ResumeLayout(False)
        Me.gboxGenero.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gboxGenero As GroupBox
    Friend WithEvents rbtnGeneroHombre As RadioButton
    Friend WithEvents rbtnGeneroMujer As RadioButton
    Friend WithEvents cmbxClase As ComboBox
    Friend WithEvents lblClase As Label
    Friend WithEvents btnCrear As Button
    Friend WithEvents txtNombreDelPersonaje As TextBox
    Friend WithEvents Label2 As Label
End Class
