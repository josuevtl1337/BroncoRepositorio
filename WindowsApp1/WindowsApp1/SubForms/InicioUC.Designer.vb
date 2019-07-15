<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioUC
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioUC))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mastiempo = New System.Windows.Forms.Button()
        Me.masactivos = New System.Windows.Forms.Button()
        Me.maspagos = New System.Windows.Forms.Button()
        Me.masmiembros = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.mastiempo)
        Me.Panel1.Controls.Add(Me.masactivos)
        Me.Panel1.Controls.Add(Me.maspagos)
        Me.Panel1.Controls.Add(Me.masmiembros)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 236)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'mastiempo
        '
        Me.mastiempo.BackColor = System.Drawing.Color.Transparent
        Me.mastiempo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mastiempo.FlatAppearance.BorderSize = 0
        Me.mastiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mastiempo.Image = CType(resources.GetObject("mastiempo.Image"), System.Drawing.Image)
        Me.mastiempo.Location = New System.Drawing.Point(732, 163)
        Me.mastiempo.Name = "mastiempo"
        Me.mastiempo.Size = New System.Drawing.Size(214, 39)
        Me.mastiempo.TabIndex = 4
        Me.mastiempo.UseVisualStyleBackColor = False
        '
        'masactivos
        '
        Me.masactivos.BackColor = System.Drawing.Color.Transparent
        Me.masactivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.masactivos.FlatAppearance.BorderSize = 0
        Me.masactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masactivos.Image = CType(resources.GetObject("masactivos.Image"), System.Drawing.Image)
        Me.masactivos.Location = New System.Drawing.Point(497, 163)
        Me.masactivos.Name = "masactivos"
        Me.masactivos.Size = New System.Drawing.Size(214, 39)
        Me.masactivos.TabIndex = 4
        Me.masactivos.UseVisualStyleBackColor = False
        '
        'maspagos
        '
        Me.maspagos.BackColor = System.Drawing.Color.Transparent
        Me.maspagos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maspagos.FlatAppearance.BorderSize = 0
        Me.maspagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maspagos.Image = CType(resources.GetObject("maspagos.Image"), System.Drawing.Image)
        Me.maspagos.Location = New System.Drawing.Point(262, 163)
        Me.maspagos.Name = "maspagos"
        Me.maspagos.Size = New System.Drawing.Size(214, 39)
        Me.maspagos.TabIndex = 4
        Me.maspagos.UseVisualStyleBackColor = False
        '
        'masmiembros
        '
        Me.masmiembros.BackColor = System.Drawing.Color.Transparent
        Me.masmiembros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.masmiembros.FlatAppearance.BorderSize = 0
        Me.masmiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.masmiembros.Image = CType(resources.GetObject("masmiembros.Image"), System.Drawing.Image)
        Me.masmiembros.Location = New System.Drawing.Point(27, 163)
        Me.masmiembros.Name = "masmiembros"
        Me.masmiembros.Size = New System.Drawing.Size(214, 39)
        Me.masmiembros.TabIndex = 4
        Me.masmiembros.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(733, 34)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(214, 169)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(498, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(214, 169)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(263, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(214, 169)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(649, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'InicioUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InicioUC"
        Me.Size = New System.Drawing.Size(975, 574)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mastiempo As Button
    Friend WithEvents masactivos As Button
    Friend WithEvents maspagos As Button
    Friend WithEvents masmiembros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
