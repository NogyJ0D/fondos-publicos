<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrComentario
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
    Me.LblNombre = New System.Windows.Forms.Label()
    Me.PnlLinea = New System.Windows.Forms.Panel()
    Me.TxbComentario = New System.Windows.Forms.TextBox()
    Me.BtnFav = New System.Windows.Forms.Button()
    Me.BtnCon = New System.Windows.Forms.Button()
    Me.BtnResponder = New System.Windows.Forms.Button()
    Me.LblN = New System.Windows.Forms.Label()
    Me.PnlComentario = New System.Windows.Forms.Panel()
    Me.PnlComentario.SuspendLayout()
    Me.SuspendLayout()
    '
    'LblNombre
    '
    Me.LblNombre.AutoSize = True
    Me.LblNombre.Font = New System.Drawing.Font("Yu Gothic UI", 8.75!, System.Drawing.FontStyle.Bold)
    Me.LblNombre.ForeColor = System.Drawing.Color.White
    Me.LblNombre.Location = New System.Drawing.Point(48, 16)
    Me.LblNombre.Name = "LblNombre"
    Me.LblNombre.Size = New System.Drawing.Size(98, 15)
    Me.LblNombre.TabIndex = 0
    Me.LblNombre.Text = "Nombre Apellido"
    '
    'PnlLinea
    '
    Me.PnlLinea.BackColor = System.Drawing.Color.Red
    Me.PnlLinea.Dock = System.Windows.Forms.DockStyle.Top
    Me.PnlLinea.Location = New System.Drawing.Point(0, 0)
    Me.PnlLinea.Name = "PnlLinea"
    Me.PnlLinea.Size = New System.Drawing.Size(758, 4)
    Me.PnlLinea.TabIndex = 5
    '
    'TxbComentario
    '
    Me.TxbComentario.Location = New System.Drawing.Point(8, 40)
    Me.TxbComentario.Multiline = True
    Me.TxbComentario.Name = "TxbComentario"
    Me.TxbComentario.ReadOnly = True
    Me.TxbComentario.Size = New System.Drawing.Size(744, 24)
    Me.TxbComentario.TabIndex = 1
    '
    'BtnFav
    '
    Me.BtnFav.BackColor = System.Drawing.Color.White
    Me.BtnFav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.BtnFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnFav.Font = New System.Drawing.Font("Yu Gothic UI", 7.75!, System.Drawing.FontStyle.Bold)
    Me.BtnFav.ForeColor = System.Drawing.Color.Black
    Me.BtnFav.Location = New System.Drawing.Point(213, 11)
    Me.BtnFav.Name = "BtnFav"
    Me.BtnFav.Size = New System.Drawing.Size(78, 23)
    Me.BtnFav.TabIndex = 6
    Me.BtnFav.Text = "Me Gusta: 0"
    Me.BtnFav.UseVisualStyleBackColor = False
    '
    'BtnCon
    '
    Me.BtnCon.BackColor = System.Drawing.Color.White
    Me.BtnCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.BtnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnCon.Font = New System.Drawing.Font("Yu Gothic UI", 7.75!, System.Drawing.FontStyle.Bold)
    Me.BtnCon.ForeColor = System.Drawing.Color.Black
    Me.BtnCon.Location = New System.Drawing.Point(304, 11)
    Me.BtnCon.Name = "BtnCon"
    Me.BtnCon.Size = New System.Drawing.Size(96, 23)
    Me.BtnCon.TabIndex = 7
    Me.BtnCon.Text = "No Me Gusta: 0"
    Me.BtnCon.UseVisualStyleBackColor = False
    '
    'BtnResponder
    '
    Me.BtnResponder.BackColor = System.Drawing.Color.White
    Me.BtnResponder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.BtnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnResponder.Font = New System.Drawing.Font("Yu Gothic UI", 7.75!, System.Drawing.FontStyle.Bold)
    Me.BtnResponder.ForeColor = System.Drawing.Color.Black
    Me.BtnResponder.Location = New System.Drawing.Point(456, 11)
    Me.BtnResponder.Name = "BtnResponder"
    Me.BtnResponder.Size = New System.Drawing.Size(75, 23)
    Me.BtnResponder.TabIndex = 8
    Me.BtnResponder.Text = "Responder"
    Me.BtnResponder.UseVisualStyleBackColor = False
    '
    'LblN
    '
    Me.LblN.AutoSize = True
    Me.LblN.Font = New System.Drawing.Font("Yu Gothic UI", 8.75!, System.Drawing.FontStyle.Bold)
    Me.LblN.ForeColor = System.Drawing.Color.White
    Me.LblN.Location = New System.Drawing.Point(8, 16)
    Me.LblN.Name = "LblN"
    Me.LblN.Size = New System.Drawing.Size(33, 15)
    Me.LblN.TabIndex = 9
    Me.LblN.Text = "N.° x"
    '
    'PnlComentario
    '
    Me.PnlComentario.Controls.Add(Me.LblNombre)
    Me.PnlComentario.Controls.Add(Me.TxbComentario)
    Me.PnlComentario.Controls.Add(Me.LblN)
    Me.PnlComentario.Controls.Add(Me.BtnResponder)
    Me.PnlComentario.Controls.Add(Me.BtnCon)
    Me.PnlComentario.Controls.Add(Me.BtnFav)
    Me.PnlComentario.Controls.Add(Me.PnlLinea)
    Me.PnlComentario.Location = New System.Drawing.Point(0, 0)
    Me.PnlComentario.Name = "PnlComentario"
    Me.PnlComentario.Size = New System.Drawing.Size(758, 78)
    Me.PnlComentario.TabIndex = 10
    '
    'CtrComentario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.PnlComentario)
    Me.Name = "CtrComentario"
    Me.Size = New System.Drawing.Size(758, 78)
    Me.PnlComentario.ResumeLayout(False)
    Me.PnlComentario.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents LblNombre As Label
  Friend WithEvents PnlLinea As Panel
  Friend WithEvents TxbComentario As TextBox
  Friend WithEvents BtnFav As Button
  Friend WithEvents BtnCon As Button
  Friend WithEvents BtnResponder As Button
  Friend WithEvents LblN As Label
  Friend WithEvents PnlComentario As Panel
End Class
