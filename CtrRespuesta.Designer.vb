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
    Me.TxbComentario = New System.Windows.Forms.TextBox()
    Me.LblNombre = New System.Windows.Forms.Label()
    Me.SuspendLayout()
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
    Me.Controls.Add(Me.TxbComentario)
    Me.Controls.Add(Me.LblNombre)
    Me.Name = "CtrRespuesta"
    Me.Size = New System.Drawing.Size(758, 78)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TxbComentario As TextBox
  Friend WithEvents LblNombre As Label
End Class
