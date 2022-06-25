<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrForo
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
    Me.PnlComentarios = New System.Windows.Forms.FlowLayoutPanel()
    Me.PnlNComentario = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.InpComentario = New System.Windows.Forms.RichTextBox()
    Me.BtnNComentario = New System.Windows.Forms.Button()
    Me.LblPNombre = New System.Windows.Forms.Label()
    Me.LblIS = New System.Windows.Forms.Label()
    Me.LblNumCom = New System.Windows.Forms.Label()
    Me.PnlCargando = New System.Windows.Forms.Panel()
    Me.LblCargando = New System.Windows.Forms.Label()
    Me.PnlNComentario.SuspendLayout()
    Me.PnlCargando.SuspendLayout()
    Me.SuspendLayout()
    '
    'PnlComentarios
    '
    Me.PnlComentarios.AutoScroll = True
    Me.PnlComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PnlComentarios.Location = New System.Drawing.Point(32, 40)
    Me.PnlComentarios.Name = "PnlComentarios"
    Me.PnlComentarios.Size = New System.Drawing.Size(784, 296)
    Me.PnlComentarios.TabIndex = 0
    '
    'PnlNComentario
    '
    Me.PnlNComentario.Controls.Add(Me.Label1)
    Me.PnlNComentario.Controls.Add(Me.InpComentario)
    Me.PnlNComentario.Controls.Add(Me.BtnNComentario)
    Me.PnlNComentario.Enabled = False
    Me.PnlNComentario.Location = New System.Drawing.Point(32, 352)
    Me.PnlNComentario.Name = "PnlNComentario"
    Me.PnlNComentario.Size = New System.Drawing.Size(784, 96)
    Me.PnlNComentario.TabIndex = 1
    Me.PnlNComentario.Visible = False
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(16, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(94, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Nuevo comentario"
    '
    'InpComentario
    '
    Me.InpComentario.Location = New System.Drawing.Point(16, 32)
    Me.InpComentario.Name = "InpComentario"
    Me.InpComentario.Size = New System.Drawing.Size(656, 56)
    Me.InpComentario.TabIndex = 1
    Me.InpComentario.Text = ""
    '
    'BtnNComentario
    '
    Me.BtnNComentario.Location = New System.Drawing.Point(680, 64)
    Me.BtnNComentario.Name = "BtnNComentario"
    Me.BtnNComentario.Size = New System.Drawing.Size(96, 24)
    Me.BtnNComentario.TabIndex = 0
    Me.BtnNComentario.Text = "Button1"
    Me.BtnNComentario.UseVisualStyleBackColor = True
    '
    'LblPNombre
    '
    Me.LblPNombre.AutoSize = True
    Me.LblPNombre.ForeColor = System.Drawing.Color.White
    Me.LblPNombre.Location = New System.Drawing.Point(32, 24)
    Me.LblPNombre.Name = "LblPNombre"
    Me.LblPNombre.Size = New System.Drawing.Size(89, 13)
    Me.LblPNombre.TabIndex = 3
    Me.LblPNombre.Text = "Nombre Proyecto"
    '
    'LblIS
    '
    Me.LblIS.AutoSize = True
    Me.LblIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblIS.ForeColor = System.Drawing.Color.White
    Me.LblIS.Location = New System.Drawing.Point(136, 392)
    Me.LblIS.Name = "LblIS"
    Me.LblIS.Size = New System.Drawing.Size(592, 29)
    Me.LblIS.TabIndex = 4
    Me.LblIS.Text = "INICIA SESIÓN PARA AGREGAR COMENTARIOS"
    '
    'LblNumCom
    '
    Me.LblNumCom.AutoSize = True
    Me.LblNumCom.ForeColor = System.Drawing.Color.White
    Me.LblNumCom.Location = New System.Drawing.Point(225, 25)
    Me.LblNumCom.Name = "LblNumCom"
    Me.LblNumCom.Size = New System.Drawing.Size(77, 13)
    Me.LblNumCom.TabIndex = 5
    Me.LblNumCom.Text = "Comentarios: 0"
    '
    'PnlCargando
    '
    Me.PnlCargando.Controls.Add(Me.LblCargando)
    Me.PnlCargando.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PnlCargando.Location = New System.Drawing.Point(0, 0)
    Me.PnlCargando.Name = "PnlCargando"
    Me.PnlCargando.Size = New System.Drawing.Size(847, 466)
    Me.PnlCargando.TabIndex = 6
    '
    'LblCargando
    '
    Me.LblCargando.AutoSize = True
    Me.LblCargando.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblCargando.ForeColor = System.Drawing.Color.White
    Me.LblCargando.Location = New System.Drawing.Point(296, 208)
    Me.LblCargando.Name = "LblCargando"
    Me.LblCargando.Size = New System.Drawing.Size(224, 42)
    Me.LblCargando.TabIndex = 0
    Me.LblCargando.Text = "Cargando..."
    '
    'CtrForo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.PnlCargando)
    Me.Controls.Add(Me.LblNumCom)
    Me.Controls.Add(Me.LblIS)
    Me.Controls.Add(Me.LblPNombre)
    Me.Controls.Add(Me.PnlNComentario)
    Me.Controls.Add(Me.PnlComentarios)
    Me.Name = "CtrForo"
    Me.Size = New System.Drawing.Size(847, 466)
    Me.PnlNComentario.ResumeLayout(False)
    Me.PnlNComentario.PerformLayout()
    Me.PnlCargando.ResumeLayout(False)
    Me.PnlCargando.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents PnlComentarios As FlowLayoutPanel
  Friend WithEvents PnlNComentario As Panel
  Friend WithEvents Label1 As Label
  Friend WithEvents InpComentario As RichTextBox
  Friend WithEvents BtnNComentario As Button
  Friend WithEvents LblPNombre As Label
  Friend WithEvents LblIS As Label
  Friend WithEvents LblNumCom As Label
  Friend WithEvents PnlCargando As Panel
  Friend WithEvents LblCargando As Label
End Class
