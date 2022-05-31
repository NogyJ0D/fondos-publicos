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
        Me.BtnLCaptcha = New System.Windows.Forms.Button()
        Me.BtnEmail = New System.Windows.Forms.Button()
        Me.InpEmail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAcceder = New System.Windows.Forms.Button()
        Me.LblLCaptcha = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InpLContraseña
        '
        Me.InpLContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpLContraseña.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InpLContraseña.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpLContraseña.Location = New System.Drawing.Point(252, 87)
        Me.InpLContraseña.Name = "InpLContraseña"
        Me.InpLContraseña.Size = New System.Drawing.Size(369, 27)
        Me.InpLContraseña.TabIndex = 5
        Me.InpLContraseña.Text = "Contraseña"
        '
        'InpLUsuario
        '
        Me.InpLUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpLUsuario.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InpLUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpLUsuario.Location = New System.Drawing.Point(252, 42)
        Me.InpLUsuario.Name = "InpLUsuario"
        Me.InpLUsuario.Size = New System.Drawing.Size(369, 27)
        Me.InpLUsuario.TabIndex = 4
        Me.InpLUsuario.Text = "Usuario"
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(39, 273)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Button1"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'InpLCaptcha
        '
        Me.InpLCaptcha.Location = New System.Drawing.Point(12, 245)
        Me.InpLCaptcha.Name = "InpLCaptcha"
        Me.InpLCaptcha.Size = New System.Drawing.Size(120, 20)
        Me.InpLCaptcha.TabIndex = 6
        '
        'BtnLCaptcha
        '
        Me.BtnLCaptcha.Location = New System.Drawing.Point(140, 244)
        Me.BtnLCaptcha.Name = "BtnLCaptcha"
        Me.BtnLCaptcha.Size = New System.Drawing.Size(75, 23)
        Me.BtnLCaptcha.TabIndex = 8
        Me.BtnLCaptcha.Text = "Button1"
        Me.BtnLCaptcha.UseVisualStyleBackColor = True
        '
        'BtnEmail
        '
        Me.BtnEmail.Location = New System.Drawing.Point(467, 279)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(64, 24)
        Me.BtnEmail.TabIndex = 9
        Me.BtnEmail.Text = "Button1"
        Me.BtnEmail.UseVisualStyleBackColor = True
        '
        'InpEmail
        '
        Me.InpEmail.Location = New System.Drawing.Point(283, 279)
        Me.InpEmail.Name = "InpEmail"
        Me.InpEmail.Size = New System.Drawing.Size(180, 20)
        Me.InpEmail.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.fondos_publicos.My.Resources.Resources.RecaptchaLogo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblLCaptcha)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnLogin)
        Me.Panel1.Controls.Add(Me.InpLCaptcha)
        Me.Panel1.Controls.Add(Me.BtnLCaptcha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 311)
        Me.Panel1.TabIndex = 13
        '
        'BtnAcceder
        '
        Me.BtnAcceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcceder.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcceder.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAcceder.Location = New System.Drawing.Point(252, 143)
        Me.BtnAcceder.Name = "BtnAcceder"
        Me.BtnAcceder.Size = New System.Drawing.Size(369, 33)
        Me.BtnAcceder.TabIndex = 14
        Me.BtnAcceder.Text = "ACCEDER"
        Me.BtnAcceder.UseVisualStyleBackColor = False
        '
        'LblLCaptcha
        '
        Me.LblLCaptcha.AutoSize = True
        Me.LblLCaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLCaptcha.Location = New System.Drawing.Point(23, 106)
        Me.LblLCaptcha.Name = "LblLCaptcha"
        Me.LblLCaptcha.Size = New System.Drawing.Size(91, 20)
        Me.LblLCaptcha.TabIndex = 13
        Me.LblLCaptcha.Text = "CAPTCHA"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 311)
        Me.Controls.Add(Me.BtnAcceder)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.InpEmail)
        Me.Controls.Add(Me.BtnEmail)
        Me.Controls.Add(Me.InpLContraseña)
        Me.Controls.Add(Me.InpLUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InpLContraseña As TextBox
  Friend WithEvents InpLUsuario As TextBox
  Friend WithEvents BtnLogin As Button
  Friend WithEvents InpLCaptcha As TextBox
    Friend WithEvents BtnLCaptcha As Button
    Friend WithEvents BtnEmail As Button
    Friend WithEvents InpEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAcceder As Button
    Friend WithEvents LblLCaptcha As Label
End Class
