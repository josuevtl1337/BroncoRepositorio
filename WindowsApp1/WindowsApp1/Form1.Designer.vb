<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rutinasBtn = New System.Windows.Forms.Button()
        Me.pagosBtn = New System.Windows.Forms.Button()
        Me.miembrosBtn = New System.Windows.Forms.Button()
        Me.inicioBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.Panel_Botones = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelForms.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.rutinasBtn)
        Me.Panel1.Controls.Add(Me.pagosBtn)
        Me.Panel1.Controls.Add(Me.miembrosBtn)
        Me.Panel1.Controls.Add(Me.inicioBtn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(69, 661)
        Me.Panel1.TabIndex = 0
        '
        'rutinasBtn
        '
        Me.rutinasBtn.BackgroundImage = CType(resources.GetObject("rutinasBtn.BackgroundImage"), System.Drawing.Image)
        Me.rutinasBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.rutinasBtn.FlatAppearance.BorderSize = 0
        Me.rutinasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rutinasBtn.Location = New System.Drawing.Point(0, 252)
        Me.rutinasBtn.Name = "rutinasBtn"
        Me.rutinasBtn.Size = New System.Drawing.Size(69, 63)
        Me.rutinasBtn.TabIndex = 1
        Me.rutinasBtn.UseVisualStyleBackColor = True
        '
        'pagosBtn
        '
        Me.pagosBtn.BackgroundImage = CType(resources.GetObject("pagosBtn.BackgroundImage"), System.Drawing.Image)
        Me.pagosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pagosBtn.FlatAppearance.BorderSize = 0
        Me.pagosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pagosBtn.Location = New System.Drawing.Point(0, 188)
        Me.pagosBtn.Name = "pagosBtn"
        Me.pagosBtn.Size = New System.Drawing.Size(69, 63)
        Me.pagosBtn.TabIndex = 1
        Me.pagosBtn.UseVisualStyleBackColor = True
        '
        'miembrosBtn
        '
        Me.miembrosBtn.BackgroundImage = CType(resources.GetObject("miembrosBtn.BackgroundImage"), System.Drawing.Image)
        Me.miembrosBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.miembrosBtn.FlatAppearance.BorderSize = 0
        Me.miembrosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.miembrosBtn.Location = New System.Drawing.Point(0, 124)
        Me.miembrosBtn.Name = "miembrosBtn"
        Me.miembrosBtn.Size = New System.Drawing.Size(69, 63)
        Me.miembrosBtn.TabIndex = 1
        Me.miembrosBtn.UseVisualStyleBackColor = True
        '
        'inicioBtn
        '
        Me.inicioBtn.BackgroundImage = CType(resources.GetObject("inicioBtn.BackgroundImage"), System.Drawing.Image)
        Me.inicioBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.inicioBtn.FlatAppearance.BorderSize = 0
        Me.inicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inicioBtn.Location = New System.Drawing.Point(0, 60)
        Me.inicioBtn.Name = "inicioBtn"
        Me.inicioBtn.Size = New System.Drawing.Size(69, 63)
        Me.inicioBtn.TabIndex = 1
        Me.inicioBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(66, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1060, 641)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.title)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PanelForms)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(69, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1043, 653)
        Me.Panel3.TabIndex = 1
        '
        'title
        '
        Me.title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(35, 14)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(107, 33)
        Me.title.TabIndex = 2
        Me.title.Text = "Default"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(958, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.PanelForms.Controls.Add(Me.Panel_Botones)
        Me.PanelForms.Location = New System.Drawing.Point(36, 60)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(975, 574)
        Me.PanelForms.TabIndex = 0
        '
        'Panel_Botones
        '
        Me.Panel_Botones.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Botones.Location = New System.Drawing.Point(3, 0)
        Me.Panel_Botones.Name = "Panel_Botones"
        Me.Panel_Botones.Size = New System.Drawing.Size(958, 255)
        Me.Panel_Botones.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1112, 661)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelForms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents inicioBtn As Button
    Friend WithEvents rutinasBtn As Button
    Friend WithEvents pagosBtn As Button
    Friend WithEvents miembrosBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelForms As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Botones As Panel
    Friend WithEvents title As Label
End Class
