<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrNuevosProy
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.PnlProyecto = New System.Windows.Forms.Panel()
        Me.LblVotosC = New System.Windows.Forms.Label()
        Me.LblVotosF = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbPDesc = New System.Windows.Forms.RichTextBox()
        Me.BtnVotarC = New System.Windows.Forms.Button()
        Me.BtnVotarF = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvP = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblPTop = New System.Windows.Forms.Label()
        Me.LblProyId = New System.Windows.Forms.Label()
        Me.PnlProyecto.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlProyecto
        '
        Me.PnlProyecto.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PnlProyecto.Controls.Add(Me.LblProyId)
        Me.PnlProyecto.Controls.Add(Me.LblVotosC)
        Me.PnlProyecto.Controls.Add(Me.LblVotosF)
        Me.PnlProyecto.Controls.Add(Me.Label1)
        Me.PnlProyecto.Controls.Add(Me.TxbPDesc)
        Me.PnlProyecto.Controls.Add(Me.BtnVotarC)
        Me.PnlProyecto.Controls.Add(Me.BtnVotarF)
        Me.PnlProyecto.Location = New System.Drawing.Point(215, 34)
        Me.PnlProyecto.Name = "PnlProyecto"
        Me.PnlProyecto.Size = New System.Drawing.Size(529, 354)
        Me.PnlProyecto.TabIndex = 0
        Me.PnlProyecto.Visible = False
        '
        'LblVotosC
        '
        Me.LblVotosC.AutoSize = True
        Me.LblVotosC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVotosC.ForeColor = System.Drawing.Color.White
        Me.LblVotosC.Location = New System.Drawing.Point(248, 317)
        Me.LblVotosC.Name = "LblVotosC"
        Me.LblVotosC.Size = New System.Drawing.Size(163, 24)
        Me.LblVotosC.TabIndex = 6
        Me.LblVotosC.Text = "Votos en contra:"
        '
        'LblVotosF
        '
        Me.LblVotosF.AutoSize = True
        Me.LblVotosF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVotosF.ForeColor = System.Drawing.Color.White
        Me.LblVotosF.Location = New System.Drawing.Point(24, 317)
        Me.LblVotosF.Name = "LblVotosF"
        Me.LblVotosF.Size = New System.Drawing.Size(137, 24)
        Me.LblVotosF.TabIndex = 5
        Me.LblVotosF.Text = "Votos a favor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.MaximumSize = New System.Drawing.Size(100, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Descripción"
        '
        'TxbPDesc
        '
        Me.TxbPDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.TxbPDesc.ForeColor = System.Drawing.Color.White
        Me.TxbPDesc.Location = New System.Drawing.Point(17, 49)
        Me.TxbPDesc.Name = "TxbPDesc"
        Me.TxbPDesc.Size = New System.Drawing.Size(485, 210)
        Me.TxbPDesc.TabIndex = 3
        Me.TxbPDesc.Text = ""
        '
        'BtnVotarC
        '
        Me.BtnVotarC.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnVotarC.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnVotarC.Location = New System.Drawing.Point(270, 272)
        Me.BtnVotarC.Name = "BtnVotarC"
        Me.BtnVotarC.Size = New System.Drawing.Size(93, 28)
        Me.BtnVotarC.TabIndex = 1
        Me.BtnVotarC.Text = "En contra"
        Me.BtnVotarC.UseVisualStyleBackColor = False
        Me.BtnVotarC.Visible = False
        '
        'BtnVotarF
        '
        Me.BtnVotarF.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnVotarF.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnVotarF.Location = New System.Drawing.Point(46, 272)
        Me.BtnVotarF.Name = "BtnVotarF"
        Me.BtnVotarF.Size = New System.Drawing.Size(93, 28)
        Me.BtnVotarF.TabIndex = 0
        Me.BtnVotarF.Text = "A favor"
        Me.BtnVotarF.UseVisualStyleBackColor = False
        Me.BtnVotarF.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
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
        Me.DgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Precio, Me.Id, Me.Fecha, Me.Descripción})
        Me.DgvP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvP.Location = New System.Drawing.Point(0, 40)
        Me.DgvP.Name = "DgvP"
        Me.DgvP.RowHeadersVisible = False
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
        Me.Precio.Width = 62
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
        Me.LblPTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblPTop.Font = New System.Drawing.Font("Yu Gothic UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPTop.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPTop.Location = New System.Drawing.Point(8, 8)
        Me.LblPTop.Name = "LblPTop"
        Me.LblPTop.Size = New System.Drawing.Size(101, 23)
        Me.LblPTop.TabIndex = 8
        Me.LblPTop.Text = "Proyectos: _"
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
        'CtrNuevosProy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlProyecto)
        Me.Name = "CtrNuevosProy"
        Me.Size = New System.Drawing.Size(759, 411)
        Me.PnlProyecto.ResumeLayout(False)
        Me.PnlProyecto.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlProyecto As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
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
End Class
