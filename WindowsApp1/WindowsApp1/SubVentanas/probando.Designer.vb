<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class probando
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
        Me.SuspendLayout()
        '
        'sendBtn
        '
        Me.sendBtn.Location = New System.Drawing.Point(15, 264)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(75, 23)
        Me.sendBtn.TabIndex = 13
        Me.sendBtn.Text = "Button1"
        Me.sendBtn.UseVisualStyleBackColor = True
        '
        'deportistaChkBx
        '
        Me.deportistaChkBx.AutoSize = True
        Me.deportistaChkBx.Location = New System.Drawing.Point(15, 221)
        Me.deportistaChkBx.Name = "deportistaChkBx"
        Me.deportistaChkBx.Size = New System.Drawing.Size(81, 17)
        Me.deportistaChkBx.TabIndex = 12
        Me.deportistaChkBx.Text = "CheckBox1"
        Me.deportistaChkBx.UseVisualStyleBackColor = True
        '
        'emailTxtBx
        '
        Me.emailTxtBx.Location = New System.Drawing.Point(12, 182)
        Me.emailTxtBx.Name = "emailTxtBx"
        Me.emailTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.emailTxtBx.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label1"
        '
        'telefonoTxtBx
        '
        Me.telefonoTxtBx.Location = New System.Drawing.Point(12, 134)
        Me.telefonoTxtBx.Name = "telefonoTxtBx"
        Me.telefonoTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.telefonoTxtBx.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label1"
        '
        'apellidoTxtBx
        '
        Me.apellidoTxtBx.Location = New System.Drawing.Point(12, 88)
        Me.apellidoTxtBx.Name = "apellidoTxtBx"
        Me.apellidoTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.apellidoTxtBx.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label1"
        '
        'nombreTxtBx
        '
        Me.nombreTxtBx.Location = New System.Drawing.Point(12, 42)
        Me.nombreTxtBx.Name = "nombreTxtBx"
        Me.nombreTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.nombreTxtBx.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'probando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 361)
        Me.Controls.Add(Me.sendBtn)
        Me.Controls.Add(Me.deportistaChkBx)
        Me.Controls.Add(Me.emailTxtBx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.telefonoTxtBx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.apellidoTxtBx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombreTxtBx)
        Me.Controls.Add(Me.Label1)
        Me.Name = "probando"
        Me.Text = "probando"
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
End Class
