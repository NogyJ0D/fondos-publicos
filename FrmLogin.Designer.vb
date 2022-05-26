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
    Me.InpLCaptcha = New System.Windows.Forms.TextBox()
    Me.LblLCaptcha = New System.Windows.Forms.Label()
    Me.BtnLCaptcha = New System.Windows.Forms.Button()
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
    Me.BtnLogin.Location = New System.Drawing.Point(96, 200)
    Me.BtnLogin.Name = "BtnLogin"
    Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
    Me.BtnLogin.TabIndex = 3
    Me.BtnLogin.Text = "Button1"
    Me.BtnLogin.UseVisualStyleBackColor = True
    '
    'InpLCaptcha
    '
    Me.InpLCaptcha.Location = New System.Drawing.Point(80, 160)
    Me.InpLCaptcha.Name = "InpLCaptcha"
    Me.InpLCaptcha.Size = New System.Drawing.Size(100, 20)
    Me.InpLCaptcha.TabIndex = 6
    '
    'LblLCaptcha
    '
    Me.LblLCaptcha.AutoSize = True
    Me.LblLCaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
    Me.LblLCaptcha.Location = New System.Drawing.Point(80, 128)
    Me.LblLCaptcha.Name = "LblLCaptcha"
    Me.LblLCaptcha.Size = New System.Drawing.Size(66, 24)
    Me.LblLCaptcha.TabIndex = 7
    Me.LblLCaptcha.Text = "Label1"
    '
    'BtnLCaptcha
    '
    Me.BtnLCaptcha.Location = New System.Drawing.Point(184, 128)
    Me.BtnLCaptcha.Name = "BtnLCaptcha"
    Me.BtnLCaptcha.Size = New System.Drawing.Size(75, 23)
    Me.BtnLCaptcha.TabIndex = 8
    Me.BtnLCaptcha.Text = "Button1"
    Me.BtnLCaptcha.UseVisualStyleBackColor = True
    '
    'FrmLogin
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(269, 281)
    Me.Controls.Add(Me.BtnLCaptcha)
    Me.Controls.Add(Me.LblLCaptcha)
    Me.Controls.Add(Me.InpLCaptcha)
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
  Friend WithEvents InpLCaptcha As TextBox
  Friend WithEvents LblLCaptcha As Label
  Friend WithEvents BtnLCaptcha As Button
End Class
