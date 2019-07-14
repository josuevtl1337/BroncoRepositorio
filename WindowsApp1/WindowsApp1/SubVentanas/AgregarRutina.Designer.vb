<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarRutina
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombreTxtBx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.descripcionTxtBx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exmRutinaBtn = New System.Windows.Forms.Button()
        Me.rutinaPB = New System.Windows.Forms.PictureBox()
        CType(Me.rutinaPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'nombreTxtBx
        '
        Me.nombreTxtBx.Location = New System.Drawing.Point(12, 31)
        Me.nombreTxtBx.Name = "nombreTxtBx"
        Me.nombreTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.nombreTxtBx.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'descripcionTxtBx
        '
        Me.descripcionTxtBx.Location = New System.Drawing.Point(12, 79)
        Me.descripcionTxtBx.Name = "descripcionTxtBx"
        Me.descripcionTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.descripcionTxtBx.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Imagen"
        '
        'exmRutinaBtn
        '
        Me.exmRutinaBtn.Location = New System.Drawing.Point(12, 125)
        Me.exmRutinaBtn.Name = "exmRutinaBtn"
        Me.exmRutinaBtn.Size = New System.Drawing.Size(75, 23)
        Me.exmRutinaBtn.TabIndex = 0
        Me.exmRutinaBtn.Text = "Examinar"
        Me.exmRutinaBtn.UseVisualStyleBackColor = True
        '
        'rutinaPB
        '
        Me.rutinaPB.Location = New System.Drawing.Point(12, 171)
        Me.rutinaPB.Name = "rutinaPB"
        Me.rutinaPB.Size = New System.Drawing.Size(225, 111)
        Me.rutinaPB.TabIndex = 3
        Me.rutinaPB.TabStop = False
        '
        'AgregarRutina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 361)
        Me.Controls.Add(Me.rutinaPB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.descripcionTxtBx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombreTxtBx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exmRutinaBtn)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AgregarRutina"
        Me.Text = "AgregarRutina"
        CType(Me.rutinaPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nombreTxtBx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents descripcionTxtBx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents exmRutinaBtn As Button
    Friend WithEvents rutinaPB As PictureBox
End Class
