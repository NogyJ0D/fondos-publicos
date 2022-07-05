<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrRespuesta
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
        Me.BtnCon = New System.Windows.Forms.Button()
        Me.BtnFav = New System.Windows.Forms.Button()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.TxbComentario = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCon
        '
        Me.BtnCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCon.Font = New System.Drawing.Font("Yu Gothic UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnCon.Location = New System.Drawing.Point(328, 11)
        Me.BtnCon.Name = "BtnCon"
        Me.BtnCon.Size = New System.Drawing.Size(96, 23)
        Me.BtnCon.TabIndex = 15
        Me.BtnCon.Text = "No Me Gusta: 0"
        Me.BtnCon.UseVisualStyleBackColor = True
        '
        'BtnFav
        '
        Me.BtnFav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFav.Font = New System.Drawing.Font("Yu Gothic UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.BtnFav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnFav.Location = New System.Drawing.Point(235, 11)
        Me.BtnFav.Name = "BtnFav"
        Me.BtnFav.Size = New System.Drawing.Size(82, 23)
        Me.BtnFav.TabIndex = 14
        Me.BtnFav.Text = "Me Gusta: 0"
        Me.BtnFav.UseVisualStyleBackColor = True
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Yu Gothic UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(648, 16)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(95, 15)
        Me.LblFecha.TabIndex = 12
        Me.LblFecha.Text = "xx/xx/xxxx xx:xx"
        '
        'TxbComentario
        '
        Me.TxbComentario.Location = New System.Drawing.Point(64, 40)
        Me.TxbComentario.Multiline = True
        Me.TxbComentario.Name = "TxbComentario"
        Me.TxbComentario.ReadOnly = True
        Me.TxbComentario.Size = New System.Drawing.Size(688, 24)
        Me.TxbComentario.TabIndex = 11
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(63, 16)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(111, 17)
        Me.LblNombre.TabIndex = 10
        Me.LblNombre.Text = "Nombre Apellido"
        '
        'CtrRespuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BtnCon)
        Me.Controls.Add(Me.BtnFav)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.TxbComentario)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "CtrRespuesta"
        Me.Size = New System.Drawing.Size(758, 78)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCon As Button
  Friend WithEvents BtnFav As Button
  Friend WithEvents LblFecha As Label
  Friend WithEvents TxbComentario As TextBox
  Friend WithEvents LblNombre As Label
End Class
