<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrMain
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnViewNuevosProy = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PnlPBorde = New System.Windows.Forms.Panel()
        Me.PnlProyectos = New System.Windows.Forms.Panel()
        Me.DgvPAprob = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlPTop = New System.Windows.Forms.Panel()
        Me.LblPTop = New System.Windows.Forms.Label()
        Me.PnlPABorde = New System.Windows.Forms.Panel()
        Me.PnlPA = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TxbPDesc = New System.Windows.Forms.RichTextBox()
        Me.PnlView = New System.Windows.Forms.Panel()
        Me.PnlPBorde.SuspendLayout()
        Me.PnlProyectos.SuspendLayout()
        CType(Me.DgvPAprob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPTop.SuspendLayout()
        Me.PnlPABorde.SuspendLayout()
        Me.PnlPA.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.PnlView.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnViewNuevosProy
        '
        Me.BtnViewNuevosProy.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnViewNuevosProy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnViewNuevosProy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewNuevosProy.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BtnViewNuevosProy.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnViewNuevosProy.Location = New System.Drawing.Point(14, 415)
        Me.BtnViewNuevosProy.Name = "BtnViewNuevosProy"
        Me.BtnViewNuevosProy.Size = New System.Drawing.Size(236, 40)
        Me.BtnViewNuevosProy.TabIndex = 5
        Me.BtnViewNuevosProy.Text = "Proyectos No Aprobados"
        Me.BtnViewNuevosProy.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(10, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Proyectos Aprobados"
        '
        'PnlPBorde
        '
        Me.PnlPBorde.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.PnlPBorde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlPBorde.Controls.Add(Me.PnlProyectos)
        Me.PnlPBorde.Location = New System.Drawing.Point(14, 44)
        Me.PnlPBorde.Name = "PnlPBorde"
        Me.PnlPBorde.Size = New System.Drawing.Size(236, 365)
        Me.PnlPBorde.TabIndex = 6
        '
        'PnlProyectos
        '
        Me.PnlProyectos.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.PnlProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlProyectos.Controls.Add(Me.DgvPAprob)
        Me.PnlProyectos.Controls.Add(Me.PnlPTop)
        Me.PnlProyectos.Location = New System.Drawing.Point(1, 1)
        Me.PnlProyectos.Name = "PnlProyectos"
        Me.PnlProyectos.Size = New System.Drawing.Size(234, 363)
        Me.PnlProyectos.TabIndex = 2
        '
        'DgvPAprob
        '
        Me.DgvPAprob.AllowUserToAddRows = False
        Me.DgvPAprob.AllowUserToDeleteRows = False
        Me.DgvPAprob.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.DgvPAprob.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPAprob.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvPAprob.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPAprob.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvPAprob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPAprob.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Precio, Me.Id, Me.Fecha, Me.Descripción})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPAprob.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvPAprob.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvPAprob.Location = New System.Drawing.Point(0, 40)
        Me.DgvPAprob.Name = "DgvPAprob"
        Me.DgvPAprob.ReadOnly = True
        Me.DgvPAprob.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPAprob.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvPAprob.RowHeadersVisible = False
        Me.DgvPAprob.ShowEditingIcon = False
        Me.DgvPAprob.Size = New System.Drawing.Size(234, 323)
        Me.DgvPAprob.TabIndex = 7
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "titulo"
        Me.Nombre.HeaderText = "Título"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precio.DataPropertyName = "monto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle6
        Me.Precio.HeaderText = "Monto"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 80
        '
        'Id
        '
        Me.Id.DataPropertyName = "id_proyecto"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Visible = False
        '
        'Descripción
        '
        Me.Descripción.DataPropertyName = "descripcion"
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        Me.Descripción.Visible = False
        '
        'PnlPTop
        '
        Me.PnlPTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPTop.Controls.Add(Me.LblPTop)
        Me.PnlPTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlPTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlPTop.Name = "PnlPTop"
        Me.PnlPTop.Size = New System.Drawing.Size(234, 40)
        Me.PnlPTop.TabIndex = 6
        '
        'LblPTop
        '
        Me.LblPTop.AutoSize = True
        Me.LblPTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblPTop.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPTop.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPTop.Location = New System.Drawing.Point(8, 8)
        Me.LblPTop.Name = "LblPTop"
        Me.LblPTop.Size = New System.Drawing.Size(101, 23)
        Me.LblPTop.TabIndex = 6
        Me.LblPTop.Text = "Proyectos: _"
        '
        'PnlPABorde
        '
        Me.PnlPABorde.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.PnlPABorde.Controls.Add(Me.PnlPA)
        Me.PnlPABorde.Location = New System.Drawing.Point(267, 44)
        Me.PnlPABorde.Name = "PnlPABorde"
        Me.PnlPABorde.Size = New System.Drawing.Size(557, 412)
        Me.PnlPABorde.TabIndex = 11
        Me.PnlPABorde.Visible = False
        '
        'PnlPA
        '
        Me.PnlPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.PnlPA.Controls.Add(Me.Button2)
        Me.PnlPA.Controls.Add(Me.Label4)
        Me.PnlPA.Controls.Add(Me.Panel3)
        Me.PnlPA.Controls.Add(Me.Panel2)
        Me.PnlPA.Location = New System.Drawing.Point(1, 1)
        Me.PnlPA.Name = "PnlPA"
        Me.PnlPA.Size = New System.Drawing.Size(555, 410)
        Me.PnlPA.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(444, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 41)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(7, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Foro"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel3.Controls.Add(Me.RichTextBox1)
        Me.Panel3.Location = New System.Drawing.Point(11, 329)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(525, 26)
        Me.Panel3.TabIndex = 9
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(1, 1)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(523, 24)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Location = New System.Drawing.Point(11, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(529, 279)
        Me.Panel2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(-4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Descripción"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel9.Controls.Add(Me.TxbPDesc)
        Me.Panel9.Location = New System.Drawing.Point(-1, 36)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(529, 243)
        Me.Panel9.TabIndex = 8
        '
        'TxbPDesc
        '
        Me.TxbPDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TxbPDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbPDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxbPDesc.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbPDesc.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TxbPDesc.HideSelection = False
        Me.TxbPDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxbPDesc.Location = New System.Drawing.Point(2, 1)
        Me.TxbPDesc.Name = "TxbPDesc"
        Me.TxbPDesc.ReadOnly = True
        Me.TxbPDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TxbPDesc.Size = New System.Drawing.Size(526, 241)
        Me.TxbPDesc.TabIndex = 3
        Me.TxbPDesc.Text = ""
        '
        'PnlView
        '
        Me.PnlView.BackColor = System.Drawing.Color.Transparent
        Me.PnlView.Controls.Add(Me.PnlPABorde)
        Me.PnlView.Controls.Add(Me.BtnViewNuevosProy)
        Me.PnlView.Controls.Add(Me.PnlPBorde)
        Me.PnlView.Location = New System.Drawing.Point(0, 0)
        Me.PnlView.Name = "PnlView"
        Me.PnlView.Size = New System.Drawing.Size(840, 473)
        Me.PnlView.TabIndex = 6
        '
        'CtrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PnlView)
        Me.Name = "CtrMain"
        Me.Size = New System.Drawing.Size(847, 460)
        Me.PnlPBorde.ResumeLayout(False)
        Me.PnlProyectos.ResumeLayout(False)
        CType(Me.DgvPAprob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPTop.ResumeLayout(False)
        Me.PnlPTop.PerformLayout()
        Me.PnlPABorde.ResumeLayout(False)
        Me.PnlPA.ResumeLayout(False)
        Me.PnlPA.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.PnlView.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnViewNuevosProy As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PnlPBorde As Panel
    Friend WithEvents PnlProyectos As Panel
    Friend WithEvents PnlPABorde As Panel
    Friend WithEvents PnlPA As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TxbPDesc As RichTextBox
    Friend WithEvents PnlView As Panel
  Friend WithEvents PnlPTop As Panel
  Friend WithEvents LblPTop As Label
  Friend WithEvents DgvPAprob As DataGridView
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
End Class
