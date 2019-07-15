<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RutinasUC
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RutinasUC))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.addRutinaBtn = New System.Windows.Forms.Button()
        Me.printRutinaBtn = New System.Windows.Forms.Button()
        Me.rutinaPB = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.nombresLB = New System.Windows.Forms.ListBox()
        Me.descripcionLB = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rutinaPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(62, 68)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(816, 116)
        Me.DataGridView1.TabIndex = 2
        '
        'addRutinaBtn
        '
        Me.addRutinaBtn.BackColor = System.Drawing.Color.Transparent
        Me.addRutinaBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addRutinaBtn.FlatAppearance.BorderSize = 0
        Me.addRutinaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addRutinaBtn.Image = CType(resources.GetObject("addRutinaBtn.Image"), System.Drawing.Image)
        Me.addRutinaBtn.Location = New System.Drawing.Point(18, 523)
        Me.addRutinaBtn.Name = "addRutinaBtn"
        Me.addRutinaBtn.Size = New System.Drawing.Size(77, 32)
        Me.addRutinaBtn.TabIndex = 3
        Me.addRutinaBtn.UseVisualStyleBackColor = False
        '
        'printRutinaBtn
        '
        Me.printRutinaBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printRutinaBtn.FlatAppearance.BorderSize = 0
        Me.printRutinaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printRutinaBtn.Image = CType(resources.GetObject("printRutinaBtn.Image"), System.Drawing.Image)
        Me.printRutinaBtn.Location = New System.Drawing.Point(112, 522)
        Me.printRutinaBtn.Name = "printRutinaBtn"
        Me.printRutinaBtn.Size = New System.Drawing.Size(89, 33)
        Me.printRutinaBtn.TabIndex = 4
        Me.printRutinaBtn.UseVisualStyleBackColor = True
        '
        'rutinaPB
        '
        Me.rutinaPB.BackColor = System.Drawing.Color.LightCoral
        Me.rutinaPB.Location = New System.Drawing.Point(341, 228)
        Me.rutinaPB.Name = "rutinaPB"
        Me.rutinaPB.Size = New System.Drawing.Size(398, 275)
        Me.rutinaPB.TabIndex = 5
        Me.rutinaPB.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(459, 23)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'nombresLB
        '
        Me.nombresLB.FormattingEnabled = True
        Me.nombresLB.Location = New System.Drawing.Point(156, 228)
        Me.nombresLB.Name = "nombresLB"
        Me.nombresLB.Size = New System.Drawing.Size(167, 121)
        Me.nombresLB.TabIndex = 7
        '
        'descripcionLB
        '
        Me.descripcionLB.AutoSize = True
        Me.descripcionLB.Location = New System.Drawing.Point(746, 228)
        Me.descripcionLB.Name = "descripcionLB"
        Me.descripcionLB.Size = New System.Drawing.Size(39, 13)
        Me.descripcionLB.TabIndex = 8
        Me.descripcionLB.Text = "Label1"
        '
        'RutinasUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.descripcionLB)
        Me.Controls.Add(Me.nombresLB)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.rutinaPB)
        Me.Controls.Add(Me.printRutinaBtn)
        Me.Controls.Add(Me.addRutinaBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RutinasUC"
        Me.Size = New System.Drawing.Size(975, 574)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rutinaPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents addRutinaBtn As Button
    Friend WithEvents printRutinaBtn As Button
    Friend WithEvents rutinaPB As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents nombresLB As ListBox
    Friend WithEvents descripcionLB As Label
End Class
