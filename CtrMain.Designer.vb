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
    Me.BtnViewNuevosProy = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.PnlPBorde = New System.Windows.Forms.Panel()
    Me.PnlProyectos = New System.Windows.Forms.Panel()
    Me.PnlProyectoActivo = New System.Windows.Forms.Panel()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Panel9 = New System.Windows.Forms.Panel()
    Me.TextProyectos = New System.Windows.Forms.RichTextBox()
    Me.PnlView = New System.Windows.Forms.Panel()
    Me.PnlPTop = New System.Windows.Forms.Panel()
    Me.LblPTop = New System.Windows.Forms.Label()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PnlPBorde.SuspendLayout()
    Me.PnlProyectos.SuspendLayout()
    Me.PnlProyectoActivo.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel9.SuspendLayout()
    Me.PnlView.SuspendLayout()
    Me.PnlPTop.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'BtnViewNuevosProy
    '
    Me.BtnViewNuevosProy.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    Me.BtnViewNuevosProy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
    Me.BtnViewNuevosProy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnViewNuevosProy.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BtnViewNuevosProy.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.BtnViewNuevosProy.Location = New System.Drawing.Point(14, 415)
    Me.BtnViewNuevosProy.Name = "BtnViewNuevosProy"
    Me.BtnViewNuevosProy.Size = New System.Drawing.Size(236, 33)
    Me.BtnViewNuevosProy.TabIndex = 5
    Me.BtnViewNuevosProy.Text = "(abir proyectos no aprobados)"
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
    Me.PnlProyectos.Controls.Add(Me.DataGridView1)
    Me.PnlProyectos.Controls.Add(Me.PnlPTop)
    Me.PnlProyectos.Location = New System.Drawing.Point(1, 1)
    Me.PnlProyectos.Name = "PnlProyectos"
    Me.PnlProyectos.Size = New System.Drawing.Size(234, 363)
    Me.PnlProyectos.TabIndex = 2
    '
    'PnlProyectoActivo
    '
    Me.PnlProyectoActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
    Me.PnlProyectoActivo.Controls.Add(Me.Panel4)
    Me.PnlProyectoActivo.Location = New System.Drawing.Point(267, 44)
    Me.PnlProyectoActivo.Name = "PnlProyectoActivo"
    Me.PnlProyectoActivo.Size = New System.Drawing.Size(564, 404)
    Me.PnlProyectoActivo.TabIndex = 11
    '
    'Panel4
    '
    Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    Me.Panel4.Controls.Add(Me.Button2)
    Me.Panel4.Controls.Add(Me.Label4)
    Me.Panel4.Controls.Add(Me.Panel3)
    Me.Panel4.Controls.Add(Me.Panel2)
    Me.Panel4.Location = New System.Drawing.Point(1, 1)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(562, 402)
    Me.Panel4.TabIndex = 5
    '
    'Button2
    '
    Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
    Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(83, Byte), Integer))
    Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.Button2.Location = New System.Drawing.Point(462, 361)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(92, 33)
    Me.Button2.TabIndex = 10
    Me.Button2.Text = "(Enviar)"
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
    Me.Panel3.Controls.Add(Me.TextBox1)
    Me.Panel3.Location = New System.Drawing.Point(11, 329)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
    Me.Panel3.Size = New System.Drawing.Size(543, 26)
    Me.Panel3.TabIndex = 9
    '
    'TextBox1
    '
    Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(23, Byte), Integer))
    Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.TextBox1.Location = New System.Drawing.Point(1, 1)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.TextBox1.Size = New System.Drawing.Size(541, 24)
    Me.TextBox1.TabIndex = 11
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
    Me.Panel2.Controls.Add(Me.Label5)
    Me.Panel2.Controls.Add(Me.Panel9)
    Me.Panel2.Location = New System.Drawing.Point(11, 7)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(543, 279)
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
    Me.Panel9.Controls.Add(Me.TextProyectos)
    Me.Panel9.Location = New System.Drawing.Point(-1, 36)
    Me.Panel9.Name = "Panel9"
    Me.Panel9.Size = New System.Drawing.Size(543, 243)
    Me.Panel9.TabIndex = 8
    '
    'TextProyectos
    '
    Me.TextProyectos.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(23, Byte), Integer))
    Me.TextProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextProyectos.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.TextProyectos.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextProyectos.ForeColor = System.Drawing.SystemColors.ButtonFace
    Me.TextProyectos.HideSelection = False
    Me.TextProyectos.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.TextProyectos.Location = New System.Drawing.Point(2, 1)
    Me.TextProyectos.Name = "TextProyectos"
    Me.TextProyectos.ReadOnly = True
    Me.TextProyectos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
    Me.TextProyectos.Size = New System.Drawing.Size(540, 241)
    Me.TextProyectos.TabIndex = 3
    Me.TextProyectos.Text = ""
    Me.TextProyectos.Visible = False
    '
    'PnlView
    '
    Me.PnlView.BackColor = System.Drawing.Color.Transparent
    Me.PnlView.Controls.Add(Me.PnlProyectoActivo)
    Me.PnlView.Controls.Add(Me.PnlPBorde)
    Me.PnlView.Location = New System.Drawing.Point(0, 0)
    Me.PnlView.Name = "PnlView"
    Me.PnlView.Size = New System.Drawing.Size(847, 460)
    Me.PnlView.TabIndex = 6
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
    'DataGridView1
    '
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Precio})
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(0, 40)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.RowHeadersVisible = False
    Me.DataGridView1.Size = New System.Drawing.Size(234, 323)
    Me.DataGridView1.TabIndex = 7
    '
    'Nombre
    '
    Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.Nombre.HeaderText = "Nombre"
    Me.Nombre.Name = "Nombre"
    Me.Nombre.ReadOnly = True
    '
    'Precio
    '
    Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.Precio.HeaderText = "Precio"
    Me.Precio.Name = "Precio"
    Me.Precio.ReadOnly = True
    Me.Precio.Width = 62
    '
    'CtrMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.BtnViewNuevosProy)
    Me.Controls.Add(Me.PnlView)
    Me.Name = "CtrMain"
    Me.Size = New System.Drawing.Size(847, 460)
    Me.PnlPBorde.ResumeLayout(False)
    Me.PnlProyectos.ResumeLayout(False)
    Me.PnlProyectoActivo.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.Panel4.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel9.ResumeLayout(False)
    Me.PnlView.ResumeLayout(False)
    Me.PnlPTop.ResumeLayout(False)
    Me.PnlPTop.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents BtnViewNuevosProy As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PnlPBorde As Panel
    Friend WithEvents PnlProyectos As Panel
  Friend WithEvents PnlProyectoActivo As Panel
  Friend WithEvents Panel4 As Panel
  Friend WithEvents Button2 As Button
  Friend WithEvents Label4 As Label
  Friend WithEvents Panel3 As Panel
  Friend WithEvents Panel2 As Panel
  Friend WithEvents Label5 As Label
  Friend WithEvents Panel9 As Panel
  Friend WithEvents TextProyectos As RichTextBox
  Friend WithEvents PnlView As Panel
  Friend WithEvents TextBox1 As TextBox
  Friend WithEvents PnlPTop As Panel
  Friend WithEvents LblPTop As Label
  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents Nombre As DataGridViewTextBoxColumn
  Friend WithEvents Precio As DataGridViewTextBoxColumn
End Class
