<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class probando
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(probando))
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.deportistaChkBx = New System.Windows.Forms.CheckBox()
        Me.emailTxtBx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.telefonoTxtBx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apellidoTxtBx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreTxtBx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sendBtn
        '
        Me.sendBtn.BackColor = System.Drawing.Color.Transparent
        Me.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sendBtn.FlatAppearance.BorderSize = 0
        Me.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendBtn.Image = CType(resources.GetObject("sendBtn.Image"), System.Drawing.Image)
        Me.sendBtn.Location = New System.Drawing.Point(42, 365)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(95, 24)
        Me.sendBtn.TabIndex = 13
        Me.sendBtn.UseVisualStyleBackColor = False
        '
        'deportistaChkBx
        '
        Me.deportistaChkBx.AutoSize = True
        Me.deportistaChkBx.BackColor = System.Drawing.Color.Transparent
        Me.deportistaChkBx.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deportistaChkBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.deportistaChkBx.Location = New System.Drawing.Point(25, 317)
        Me.deportistaChkBx.Name = "deportistaChkBx"
        Me.deportistaChkBx.Size = New System.Drawing.Size(90, 23)
        Me.deportistaChkBx.TabIndex = 12
        Me.deportistaChkBx.Text = "Deportista"
        Me.deportistaChkBx.UseVisualStyleBackColor = False
        '
        'emailTxtBx
        '
        Me.emailTxtBx.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.emailTxtBx.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTxtBx.Location = New System.Drawing.Point(25, 265)
        Me.emailTxtBx.Name = "emailTxtBx"
        Me.emailTxtBx.Size = New System.Drawing.Size(245, 27)
        Me.emailTxtBx.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Teléfono:"
        '
        'telefonoTxtBx
        '
        Me.telefonoTxtBx.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.telefonoTxtBx.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonoTxtBx.Location = New System.Drawing.Point(25, 206)
        Me.telefonoTxtBx.Name = "telefonoTxtBx"
        Me.telefonoTxtBx.Size = New System.Drawing.Size(245, 27)
        Me.telefonoTxtBx.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "E-Mail:"
        '
        'apellidoTxtBx
        '
        Me.apellidoTxtBx.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.apellidoTxtBx.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoTxtBx.Location = New System.Drawing.Point(25, 147)
        Me.apellidoTxtBx.Name = "apellidoTxtBx"
        Me.apellidoTxtBx.Size = New System.Drawing.Size(245, 27)
        Me.apellidoTxtBx.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellido:"
        '
        'nombreTxtBx
        '
        Me.nombreTxtBx.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.nombreTxtBx.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreTxtBx.Location = New System.Drawing.Point(25, 88)
        Me.nombreTxtBx.Name = "nombreTxtBx"
        Me.nombreTxtBx.Size = New System.Drawing.Size(245, 27)
        Me.nombreTxtBx.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(69, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Registrar Cliente"
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), System.Drawing.Image)
        Me.closeBtn.Location = New System.Drawing.Point(153, 365)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(95, 25)
        Me.closeBtn.TabIndex = 15
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'probando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(290, 415)
        Me.Controls.Add(Me.telefonoTxtBx)
        Me.Controls.Add(Me.emailTxtBx)
        Me.Controls.Add(Me.nombreTxtBx)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sendBtn)
        Me.Controls.Add(Me.deportistaChkBx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.apellidoTxtBx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "probando"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Nuevo Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sendBtn As Button
    Friend WithEvents deportistaChkBx As CheckBox
    Friend WithEvents emailTxtBx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents telefonoTxtBx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents apellidoTxtBx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nombreTxtBx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents closeBtn As Button
End Class
