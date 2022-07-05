<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrNuevosProy
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
        Me.PnlProyecto = New System.Windows.Forms.Panel()
        Me.BtnVotarF = New System.Windows.Forms.Button()
        Me.BtnViewForo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxbPDesc = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblProyId = New System.Windows.Forms.Label()
        Me.LblVotosC = New System.Windows.Forms.Label()
        Me.LblVotosF = New System.Windows.Forms.Label()
        Me.BtnVotarC = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvP = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblPTop = New System.Windows.Forms.Label()
        Me.BtnANP = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PnlProyecto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlProyecto
        '
        Me.PnlProyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PnlProyecto.Controls.Add(Me.BtnVotarF)
        Me.PnlProyecto.Controls.Add(Me.BtnViewForo)
        Me.PnlProyecto.Controls.Add(Me.Panel1)
        Me.PnlProyecto.Controls.Add(Me.Label5)
        Me.PnlProyecto.Controls.Add(Me.LblProyId)
        Me.PnlProyecto.Controls.Add(Me.LblVotosC)
        Me.PnlProyecto.Controls.Add(Me.LblVotosF)
        Me.PnlProyecto.Controls.Add(Me.BtnVotarC)
        Me.PnlProyecto.Location = New System.Drawing.Point(215, 34)
        Me.PnlProyecto.Name = "PnlProyecto"
        Me.PnlProyecto.Size = New System.Drawing.Size(529, 354)
        Me.PnlProyecto.TabIndex = 0
        Me.PnlProyecto.Visible = False
        '
        'BtnVotarF
        '
        Me.BtnVotarF.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnVotarF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnVotarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVotarF.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnVotarF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnVotarF.Location = New System.Drawing.Point(40, 272)
        Me.BtnVotarF.Name = "BtnVotarF"
        Me.BtnVotarF.Size = New System.Drawing.Size(93, 28)
        Me.BtnVotarF.TabIndex = 0
        Me.BtnVotarF.Text = "A favor"
        Me.BtnVotarF.UseVisualStyleBackColor = False
        Me.BtnVotarF.Visible = False
        '
        'BtnViewForo
        '
        Me.BtnViewForo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnViewForo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewForo.Font = New System.Drawing.Font("Yu Gothic UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.BtnViewForo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnViewForo.Location = New System.Drawing.Point(440, 272)
        Me.BtnViewForo.Name = "BtnViewForo"
        Me.BtnViewForo.Size = New System.Drawing.Size(80, 28)
        Me.BtnViewForo.TabIndex = 10
        Me.BtnViewForo.Text = "Ir al foro"
        Me.BtnViewForo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxbPDesc)
        Me.Panel1.Location = New System.Drawing.Point(28, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 212)
        Me.Panel1.TabIndex = 9
        '
        'TxbPDesc
        '
        Me.TxbPDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TxbPDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbPDesc.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.TxbPDesc.ForeColor = System.Drawing.Color.White
        Me.TxbPDesc.Location = New System.Drawing.Point(1, 1)
        Me.TxbPDesc.Name = "TxbPDesc"
        Me.TxbPDesc.Size = New System.Drawing.Size(485, 210)
        Me.TxbPDesc.TabIndex = 3
        Me.TxbPDesc.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(24, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descripción"
        '
        'LblProyId
        '
        Me.LblProyId.AutoSize = True
        Me.LblProyId.Location = New System.Drawing.Point(488, 8)
        Me.LblProyId.Name = "LblProyId"
        Me.LblProyId.Size = New System.Drawing.Size(39, 13)
        Me.LblProyId.TabIndex = 7
        Me.LblProyId.Text = "Label2"
        Me.LblProyId.Visible = False
        '
        'LblVotosC
        '
        Me.LblVotosC.AutoSize = True
        Me.LblVotosC.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LblVotosC.ForeColor = System.Drawing.Color.White
        Me.LblVotosC.Location = New System.Drawing.Point(256, 317)
        Me.LblVotosC.Name = "LblVotosC"
        Me.LblVotosC.Size = New System.Drawing.Size(135, 23)
        Me.LblVotosC.TabIndex = 6
        Me.LblVotosC.Text = "Votos en contra:"
        '
        'LblVotosF
        '
        Me.LblVotosF.AutoSize = True
        Me.LblVotosF.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LblVotosF.ForeColor = System.Drawing.Color.White
        Me.LblVotosF.Location = New System.Drawing.Point(27, 317)
        Me.LblVotosF.Name = "LblVotosF"
        Me.LblVotosF.Size = New System.Drawing.Size(116, 23)
        Me.LblVotosF.TabIndex = 5
        Me.LblVotosF.Text = "Votos a favor:"
        '
        'BtnVotarC
        '
        Me.BtnVotarC.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnVotarC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnVotarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVotarC.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnVotarC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnVotarC.Location = New System.Drawing.Point(296, 272)
        Me.BtnVotarC.Name = "BtnVotarC"
        Me.BtnVotarC.Size = New System.Drawing.Size(93, 28)
        Me.BtnVotarC.TabIndex = 1
        Me.BtnVotarC.Text = "En contra"
        Me.BtnVotarC.UseVisualStyleBackColor = False
        Me.BtnVotarC.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DgvP)
        Me.Panel2.Controls.Add(Me.LblPTop)
        Me.Panel2.Location = New System.Drawing.Point(17, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 354)
        Me.Panel2.TabIndex = 1
        '
        'DgvP
        '
        Me.DgvP.AllowUserToAddRows = False
        Me.DgvP.AllowUserToDeleteRows = False
        Me.DgvP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DgvP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Precio, Me.Id, Me.Fecha, Me.Descripción})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvP.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvP.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvP.Location = New System.Drawing.Point(0, 40)
        Me.DgvP.Name = "DgvP"
        Me.DgvP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvP.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvP.RowHeadersVisible = False
        Me.DgvP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvP.ShowEditingIcon = False
        Me.DgvP.Size = New System.Drawing.Size(180, 314)
        Me.DgvP.TabIndex = 9
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
        Me.Precio.HeaderText = "Monto"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 74
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
        'LblPTop
        '
        Me.LblPTop.AutoSize = True
        Me.LblPTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.LblPTop.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPTop.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPTop.Location = New System.Drawing.Point(8, 8)
        Me.LblPTop.Name = "LblPTop"
        Me.LblPTop.Size = New System.Drawing.Size(101, 23)
        Me.LblPTop.TabIndex = 8
        Me.LblPTop.Text = "Proyectos: _"
        '
        'BtnANP
        '
        Me.BtnANP.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnANP.Enabled = False
        Me.BtnANP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnANP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnANP.Font = New System.Drawing.Font("Yu Gothic UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.BtnANP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnANP.Location = New System.Drawing.Point(672, 3)
        Me.BtnANP.Name = "BtnANP"
        Me.BtnANP.Size = New System.Drawing.Size(75, 23)
        Me.BtnANP.TabIndex = 2
        Me.BtnANP.TabStop = False
        Me.BtnANP.Text = "Agregar"
        Me.BtnANP.UseVisualStyleBackColor = False
        Me.BtnANP.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(16, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(182, 356)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(214, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(531, 356)
        Me.Panel4.TabIndex = 15
        '
        'CtrNuevosProy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BtnANP)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlProyecto)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "CtrNuevosProy"
        Me.Size = New System.Drawing.Size(759, 411)
        Me.PnlProyecto.ResumeLayout(False)
        Me.PnlProyecto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlProyecto As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxbPDesc As RichTextBox
    Friend WithEvents BtnVotarC As Button
    Friend WithEvents BtnVotarF As Button
    Friend WithEvents DgvP As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents LblPTop As Label
    Friend WithEvents LblVotosC As Label
    Friend WithEvents LblVotosF As Label
    Friend WithEvents LblProyId As Label
    Friend WithEvents BtnANP As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnViewForo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
