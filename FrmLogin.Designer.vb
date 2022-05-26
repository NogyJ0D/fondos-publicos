<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.InpLContraseña = New System.Windows.Forms.TextBox()
    Me.InpLUsuario = New System.Windows.Forms.TextBox()
    Me.BtnLogin = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'InpLContraseña
    '
    Me.InpLContraseña.Location = New System.Drawing.Point(80, 80)
    Me.InpLContraseña.Name = "InpLContraseña"
    Me.InpLContraseña.Size = New System.Drawing.Size(100, 20)
    Me.InpLContraseña.TabIndex = 5
    '
    'InpLUsuario
    '
    Me.InpLUsuario.Location = New System.Drawing.Point(80, 40)
    Me.InpLUsuario.Name = "InpLUsuario"
    Me.InpLUsuario.Size = New System.Drawing.Size(100, 20)
    Me.InpLUsuario.TabIndex = 4
    '
    'BtnLogin
    '
    Me.BtnLogin.Location = New System.Drawing.Point(96, 112)
    Me.BtnLogin.Name = "BtnLogin"
    Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
    Me.BtnLogin.TabIndex = 3
    Me.BtnLogin.Text = "Button1"
    Me.BtnLogin.UseVisualStyleBackColor = True
    '
    'FrmLogin
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(269, 198)
    Me.Controls.Add(Me.InpLContraseña)
    Me.Controls.Add(Me.InpLUsuario)
    Me.Controls.Add(Me.BtnLogin)
    Me.Name = "FrmLogin"
    Me.Text = "FrmLogin"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents InpLContraseña As TextBox
  Friend WithEvents InpLUsuario As TextBox
  Friend WithEvents BtnLogin As Button
End Class
