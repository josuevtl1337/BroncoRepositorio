<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MiembrosUC
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiembrosUC))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.ModBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.filtroBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.paymentBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 68)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(975, 435)
        Me.DataGridView1.TabIndex = 0
        '
        'refreshBtn
        '
        Me.refreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.FlatAppearance.BorderSize = 0
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.Image = CType(resources.GetObject("refreshBtn.Image"), System.Drawing.Image)
        Me.refreshBtn.Location = New System.Drawing.Point(104, 523)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(35, 32)
        Me.refreshBtn.TabIndex = 1
        Me.refreshBtn.UseVisualStyleBackColor = False
        '
        'ModBtn
        '
        Me.ModBtn.BackColor = System.Drawing.Color.Transparent
        Me.ModBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModBtn.FlatAppearance.BorderSize = 0
        Me.ModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModBtn.Image = CType(resources.GetObject("ModBtn.Image"), System.Drawing.Image)
        Me.ModBtn.Location = New System.Drawing.Point(150, 523)
        Me.ModBtn.Name = "ModBtn"
        Me.ModBtn.Size = New System.Drawing.Size(31, 32)
        Me.ModBtn.TabIndex = 1
        Me.ModBtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.Transparent
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatAppearance.BorderSize = 0
        Me.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Image = CType(resources.GetObject("addBtn.Image"), System.Drawing.Image)
        Me.addBtn.Location = New System.Drawing.Point(18, 523)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(77, 32)
        Me.addBtn.TabIndex = 1
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'filtroBtn
        '
        Me.filtroBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filtroBtn.FlatAppearance.BorderSize = 0
        Me.filtroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filtroBtn.Image = CType(resources.GetObject("filtroBtn.Image"), System.Drawing.Image)
        Me.filtroBtn.Location = New System.Drawing.Point(863, 522)
        Me.filtroBtn.Name = "filtroBtn"
        Me.filtroBtn.Size = New System.Drawing.Size(94, 32)
        Me.filtroBtn.TabIndex = 2
        Me.filtroBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Image = CType(resources.GetObject("deleteBtn.Image"), System.Drawing.Image)
        Me.deleteBtn.Location = New System.Drawing.Point(191, 522)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(39, 34)
        Me.deleteBtn.TabIndex = 3
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'paymentBtn
        '
        Me.paymentBtn.FlatAppearance.BorderSize = 0
        Me.paymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.paymentBtn.Image = CType(resources.GetObject("paymentBtn.Image"), System.Drawing.Image)
        Me.paymentBtn.Location = New System.Drawing.Point(437, 519)
        Me.paymentBtn.Name = "paymentBtn"
        Me.paymentBtn.Size = New System.Drawing.Size(101, 35)
        Me.paymentBtn.TabIndex = 4
        Me.paymentBtn.UseVisualStyleBackColor = True
        '
        'MiembrosUC
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.paymentBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.filtroBtn)
        Me.Controls.Add(Me.ModBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MiembrosUC"
        Me.Size = New System.Drawing.Size(975, 574)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents refreshBtn As Button
    Friend WithEvents ModBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents filtroBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents paymentBtn As Button
End Class
