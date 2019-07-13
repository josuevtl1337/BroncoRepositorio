<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPago
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.montoTxtBx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreTxtBx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fechaDP = New System.Windows.Forms.DateTimePicker()
        Me.rutinaCB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'sendBtn
        '
        Me.sendBtn.Location = New System.Drawing.Point(15, 264)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(75, 23)
        Me.sendBtn.TabIndex = 23
        Me.sendBtn.Text = "Button1"
        Me.sendBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Rutina"
        '
        'montoTxtBx
        '
        Me.montoTxtBx.Location = New System.Drawing.Point(12, 134)
        Me.montoTxtBx.Name = "montoTxtBx"
        Me.montoTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.montoTxtBx.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha de Pago"
        '
        'nombreTxtBx
        '
        Me.nombreTxtBx.Location = New System.Drawing.Point(12, 42)
        Me.nombreTxtBx.Name = "nombreTxtBx"
        Me.nombreTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.nombreTxtBx.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        '
        'fechaDP
        '
        Me.fechaDP.Location = New System.Drawing.Point(12, 94)
        Me.fechaDP.Name = "fechaDP"
        Me.fechaDP.Size = New System.Drawing.Size(100, 20)
        Me.fechaDP.TabIndex = 24
        '
        'rutinaCB
        '
        Me.rutinaCB.FormattingEnabled = True
        Me.rutinaCB.Items.AddRange(New Object() {"Basket", "futbol", "Natacion", "tenis", "Voley"})
        Me.rutinaCB.Location = New System.Drawing.Point(12, 182)
        Me.rutinaCB.Name = "rutinaCB"
        Me.rutinaCB.Size = New System.Drawing.Size(121, 21)
        Me.rutinaCB.TabIndex = 25
        '
        'AgregarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 361)
        Me.Controls.Add(Me.rutinaCB)
        Me.Controls.Add(Me.fechaDP)
        Me.Controls.Add(Me.sendBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.montoTxtBx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombreTxtBx)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarPago"
        Me.Text = "Modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sendBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents montoTxtBx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nombreTxtBx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fechaDP As DateTimePicker
    Friend WithEvents rutinaCB As ComboBox
End Class
