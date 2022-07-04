<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrResponder
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
        Me.LblNR = New System.Windows.Forms.Label()
        Me.InpRespuesta = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNR
        '
        Me.LblNR.AutoSize = True
        Me.LblNR.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblNR.ForeColor = System.Drawing.Color.White
        Me.LblNR.Location = New System.Drawing.Point(17, 4)
        Me.LblNR.Name = "LblNR"
        Me.LblNR.Size = New System.Drawing.Size(113, 17)
        Me.LblNR.TabIndex = 5
        Me.LblNR.Text = "Nueva Respuesta"
        '
        'InpRespuesta
        '
        Me.InpRespuesta.Location = New System.Drawing.Point(16, 24)
        Me.InpRespuesta.Name = "InpRespuesta"
        Me.InpRespuesta.Size = New System.Drawing.Size(633, 48)
        Me.InpRespuesta.TabIndex = 4
        Me.InpRespuesta.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Yu Gothic UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.BtnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnEnviar.Location = New System.Drawing.Point(656, 48)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(96, 24)
        Me.BtnEnviar.TabIndex = 3
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Yu Gothic UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnCerrar.Location = New System.Drawing.Point(680, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 6
        Me.BtnCerrar.Text = "Cancelar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'CtrResponder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblNR)
        Me.Controls.Add(Me.InpRespuesta)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Name = "CtrResponder"
        Me.Size = New System.Drawing.Size(758, 88)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNR As Label
  Friend WithEvents InpRespuesta As RichTextBox
  Friend WithEvents BtnEnviar As Button
  Friend WithEvents BtnCerrar As Button
End Class
