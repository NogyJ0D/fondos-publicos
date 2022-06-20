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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.PnlPBorde = New System.Windows.Forms.Panel()
    Me.PnlProyectos = New System.Windows.Forms.Panel()
    Me.DgvPAprob = New System.Windows.Forms.DataGridView()
    Me.PnlPTop = New System.Windows.Forms.Panel()
    Me.LblPTop = New System.Windows.Forms.Label()
    Me.PnlPABorde = New System.Windows.Forms.Panel()
    Me.PnlPA = New System.Windows.Forms.Panel()
    Me.LblPId = New System.Windows.Forms.Label()
    Me.BtnViewForo = New System.Windows.Forms.Button()
    Me.LblMonto = New System.Windows.Forms.Label()
    Me.LblPNombre = New System.Windows.Forms.Label()
    Me.PnlDesc = New System.Windows.Forms.Panel()
    Me.TxbPDesc = New System.Windows.Forms.RichTextBox()
    Me.PnlView = New System.Windows.Forms.Panel()
    Me.BtnViewNuevosProy = New System.Windows.Forms.Button()
    Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PnlPBorde.SuspendLayout()
    Me.PnlProyectos.SuspendLayout()
    CType(Me.DgvPAprob, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PnlPTop.SuspendLayout()
    Me.PnlPABorde.SuspendLayout()
    Me.PnlPA.SuspendLayout()
    Me.PnlDesc.SuspendLayout()
    Me.PnlView.SuspendLayout()
    Me.SuspendLayout()
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
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight
    DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DgvPAprob.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DgvPAprob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DgvPAprob.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Precio, Me.Id, Me.Fecha, Me.Descripción})
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DgvPAprob.DefaultCellStyle = DataGridViewCellStyle3
    Me.DgvPAprob.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DgvPAprob.GridColor = System.Drawing.SystemColors.ButtonHighlight
    Me.DgvPAprob.Location = New System.Drawing.Point(0, 40)
    Me.DgvPAprob.Name = "DgvPAprob"
    Me.DgvPAprob.ReadOnly = True
    Me.DgvPAprob.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DgvPAprob.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.DgvPAprob.RowHeadersVisible = False
    Me.DgvPAprob.ShowEditingIcon = False
    Me.DgvPAprob.Size = New System.Drawing.Size(234, 323)
    Me.DgvPAprob.TabIndex = 8
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
    Me.PnlPABorde.Size = New System.Drawing.Size(564, 404)
    Me.PnlPABorde.TabIndex = 11
    Me.PnlPABorde.Visible = False
    '
    'PnlPA
    '
    Me.PnlPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    Me.PnlPA.Controls.Add(Me.LblPId)
    Me.PnlPA.Controls.Add(Me.BtnViewForo)
    Me.PnlPA.Controls.Add(Me.LblMonto)
    Me.PnlPA.Controls.Add(Me.LblPNombre)
    Me.PnlPA.Controls.Add(Me.PnlDesc)
    Me.PnlPA.Location = New System.Drawing.Point(1, 1)
    Me.PnlPA.Name = "PnlPA"
    Me.PnlPA.Size = New System.Drawing.Size(562, 402)
    Me.PnlPA.TabIndex = 5
    '
    'LblPId
    '
    Me.LblPId.AutoSize = True
    Me.LblPId.Location = New System.Drawing.Point(488, 8)
    Me.LblPId.Name = "LblPId"
    Me.LblPId.Size = New System.Drawing.Size(39, 13)
    Me.LblPId.TabIndex = 13
    Me.LblPId.Text = "Label1"
    Me.LblPId.Visible = False
    '
    'BtnViewForo
    '
    Me.BtnViewForo.Location = New System.Drawing.Point(464, 368)
    Me.BtnViewForo.Name = "BtnViewForo"
    Me.BtnViewForo.Size = New System.Drawing.Size(75, 23)
    Me.BtnViewForo.TabIndex = 12
    Me.BtnViewForo.Text = "Button1"
    Me.BtnViewForo.UseVisualStyleBackColor = True
    '
    'LblMonto
    '
    Me.LblMonto.AutoSize = True
    Me.LblMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    Me.LblMonto.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblMonto.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.LblMonto.Location = New System.Drawing.Point(16, 368)
    Me.LblMonto.Name = "LblMonto"
    Me.LblMonto.Size = New System.Drawing.Size(134, 23)
    Me.LblMonto.TabIndex = 11
    Me.LblMonto.Text = "Monto: _________"
    '
    'LblPNombre
    '
    Me.LblPNombre.AutoSize = True
    Me.LblPNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    Me.LblPNombre.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblPNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.LblPNombre.Location = New System.Drawing.Point(16, 8)
    Me.LblPNombre.Name = "LblPNombre"
    Me.LblPNombre.Size = New System.Drawing.Size(73, 23)
    Me.LblPNombre.TabIndex = 9
    Me.LblPNombre.Text = "Nombre"
    '
    'PnlDesc
    '
    Me.PnlDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
    Me.PnlDesc.Controls.Add(Me.TxbPDesc)
    Me.PnlDesc.Location = New System.Drawing.Point(11, 38)
    Me.PnlDesc.Name = "PnlDesc"
    Me.PnlDesc.Size = New System.Drawing.Size(529, 314)
    Me.PnlDesc.TabIndex = 10
    '
    'TxbPDesc
    '
    Me.TxbPDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(23, Byte), Integer))
    Me.TxbPDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TxbPDesc.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.TxbPDesc.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TxbPDesc.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TxbPDesc.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.TxbPDesc.HideSelection = False
    Me.TxbPDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.TxbPDesc.Location = New System.Drawing.Point(0, 0)
    Me.TxbPDesc.Name = "TxbPDesc"
    Me.TxbPDesc.ReadOnly = True
    Me.TxbPDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
    Me.TxbPDesc.Size = New System.Drawing.Size(529, 314)
    Me.TxbPDesc.TabIndex = 3
    Me.TxbPDesc.Text = ""
    '
    'PnlView
    '
    Me.PnlView.BackColor = System.Drawing.Color.Transparent
    Me.PnlView.Controls.Add(Me.BtnViewNuevosProy)
    Me.PnlView.Controls.Add(Me.PnlPABorde)
    Me.PnlView.Controls.Add(Me.PnlPBorde)
    Me.PnlView.Location = New System.Drawing.Point(0, 0)
    Me.PnlView.Name = "PnlView"
    Me.PnlView.Size = New System.Drawing.Size(847, 460)
    Me.PnlView.TabIndex = 6
    '
    'BtnViewNuevosProy
    '
    Me.BtnViewNuevosProy.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    Me.BtnViewNuevosProy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
    Me.BtnViewNuevosProy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnViewNuevosProy.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold)
    Me.BtnViewNuevosProy.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.BtnViewNuevosProy.Location = New System.Drawing.Point(15, 416)
    Me.BtnViewNuevosProy.Name = "BtnViewNuevosProy"
    Me.BtnViewNuevosProy.Size = New System.Drawing.Size(236, 35)
    Me.BtnViewNuevosProy.TabIndex = 12
    Me.BtnViewNuevosProy.Text = "Proyectos No Aprobados"
    Me.BtnViewNuevosProy.UseVisualStyleBackColor = False
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
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.Precio.DefaultCellStyle = DataGridViewCellStyle2
    Me.Precio.HeaderText = "Monto"
    Me.Precio.Name = "Precio"
    Me.Precio.ReadOnly = True
    Me.Precio.Visible = False
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
    '
    'Descripción
    '
    Me.Descripción.DataPropertyName = "descripcion"
    Me.Descripción.HeaderText = "Descripción"
    Me.Descripción.Name = "Descripción"
    Me.Descripción.ReadOnly = True
    Me.Descripción.Visible = False
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
    Me.PnlDesc.ResumeLayout(False)
    Me.PnlView.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label3 As Label
  Friend WithEvents PnlPBorde As Panel
  Friend WithEvents PnlProyectos As Panel
  Friend WithEvents PnlPABorde As Panel
  Friend WithEvents PnlPA As Panel
  Friend WithEvents PnlView As Panel
  Friend WithEvents PnlPTop As Panel
  Friend WithEvents LblPTop As Label
  Friend WithEvents LblMonto As Label
  Friend WithEvents LblPNombre As Label
  Friend WithEvents PnlDesc As Panel
  Friend WithEvents TxbPDesc As RichTextBox
  Friend WithEvents BtnViewForo As Button
  Friend WithEvents LblPId As Label
  Friend WithEvents DgvPAprob As DataGridView
  Friend WithEvents BtnViewNuevosProy As Button
  Friend WithEvents Nombre As DataGridViewTextBoxColumn
  Friend WithEvents Precio As DataGridViewTextBoxColumn
  Friend WithEvents Id As DataGridViewTextBoxColumn
  Friend WithEvents Fecha As DataGridViewTextBoxColumn
  Friend WithEvents Descripción As DataGridViewTextBoxColumn
End Class
