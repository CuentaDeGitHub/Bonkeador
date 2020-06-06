<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informacion
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bruh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Moverte = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NoSoyOriginal.My.Resources.Resources.RataSeñalando
        Me.PictureBox1.Location = New System.Drawing.Point(36, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(274, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(55, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Las ratas se han apoderado de la ciudad, tienes que escapar rapidamente antes que" &
    " la horda de ratas te alcanze, pero ten cuidado, moverte muy rapido tal vez llam" &
    "e la atencion de otras ratas"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(79, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Miras hacia la horda de ratas y calculas cuanto tiempo queda antes de que te atra" &
    "pen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Te detienes a descansar y recuperar vida"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(79, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 36)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Te mueves lentamente, es poco probable que te noten de esta manera"
        '
        'Bruh
        '
        Me.Bruh.Location = New System.Drawing.Point(79, 289)
        Me.Bruh.Name = "Bruh"
        Me.Bruh.Size = New System.Drawing.Size(247, 29)
        Me.Bruh.TabIndex = 6
        Me.Bruh.Text = "Te mueves rapidamente por la ciudad, pero puede que llames la atencion de alguna " &
    "rata"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Mirar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descansar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Sigilo"
        '
        'Moverte
        '
        Me.Moverte.AutoSize = True
        Me.Moverte.Location = New System.Drawing.Point(16, 289)
        Me.Moverte.Name = "Moverte"
        Me.Moverte.Size = New System.Drawing.Size(46, 13)
        Me.Moverte.TabIndex = 10
        Me.Moverte.Text = "Moverte"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(101, 455)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Mucho Texto"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Informacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 479)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Moverte)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Bruh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Informacion"
        Me.Text = "Informacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Bruh As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Moverte As Label
    Friend WithEvents btnSalir As Button
End Class
