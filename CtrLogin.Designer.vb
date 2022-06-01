<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrLogin
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.InpLCaptcha = New System.Windows.Forms.TextBox()
        Me.InpLContraseña = New System.Windows.Forms.TextBox()
        Me.InpLUsuario = New System.Windows.Forms.TextBox()
        Me.LblLCaptcha = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLCaptcha = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.BtnLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnLogin.Location = New System.Drawing.Point(240, 309)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(369, 33)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "ACCEDER"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'InpLCaptcha
        '
        Me.InpLCaptcha.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpLCaptcha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InpLCaptcha.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpLCaptcha.Location = New System.Drawing.Point(352, 264)
        Me.InpLCaptcha.Name = "InpLCaptcha"
        Me.InpLCaptcha.Size = New System.Drawing.Size(134, 27)
        Me.InpLCaptcha.TabIndex = 2
        Me.InpLCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InpLContraseña
        '
        Me.InpLContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpLContraseña.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.InpLContraseña.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpLContraseña.Location = New System.Drawing.Point(240, 160)
        Me.InpLContraseña.Name = "InpLContraseña"
        Me.InpLContraseña.Size = New System.Drawing.Size(369, 33)
        Me.InpLContraseña.TabIndex = 1
        Me.InpLContraseña.Text = "Contraseña"
        Me.InpLContraseña.UseSystemPasswordChar = True
        '
        'InpLUsuario
        '
        Me.InpLUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpLUsuario.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.InpLUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpLUsuario.Location = New System.Drawing.Point(240, 112)
        Me.InpLUsuario.Name = "InpLUsuario"
        Me.InpLUsuario.Size = New System.Drawing.Size(369, 33)
        Me.InpLUsuario.TabIndex = 0
        Me.InpLUsuario.Text = "Usuario"
        '
        'LblLCaptcha
        '
        Me.LblLCaptcha.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.LblLCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblLCaptcha.Cursor = System.Windows.Forms.Cursors.No
        Me.LblLCaptcha.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLCaptcha.ForeColor = System.Drawing.Color.White
        Me.LblLCaptcha.Location = New System.Drawing.Point(338, 213)
        Me.LblLCaptcha.Name = "LblLCaptcha"
        Me.LblLCaptcha.ReadOnly = True
        Me.LblLCaptcha.Size = New System.Drawing.Size(159, 43)
        Me.LblLCaptcha.TabIndex = 21
        Me.LblLCaptcha.TabStop = False
        Me.LblLCaptcha.Text = "captcha"
        Me.LblLCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.fondos_publicos.My.Resources.Resources.ACCEDER
        Me.PictureBox1.Location = New System.Drawing.Point(615, 309)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'BtnLCaptcha
        '
        Me.BtnLCaptcha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLCaptcha.Image = Global.fondos_publicos.My.Resources.Resources.recargar
        Me.BtnLCaptcha.Location = New System.Drawing.Point(521, 216)
        Me.BtnLCaptcha.Name = "BtnLCaptcha"
        Me.BtnLCaptcha.Size = New System.Drawing.Size(70, 70)
        Me.BtnLCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnLCaptcha.TabIndex = 22
        Me.BtnLCaptcha.TabStop = False
        '
        'CtrLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnLCaptcha)
        Me.Controls.Add(Me.LblLCaptcha)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.InpLCaptcha)
        Me.Controls.Add(Me.InpLContraseña)
        Me.Controls.Add(Me.InpLUsuario)
        Me.Name = "CtrLogin"
        Me.Size = New System.Drawing.Size(847, 460)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLogin As Button
    Friend WithEvents InpLCaptcha As TextBox
    Friend WithEvents InpLContraseña As TextBox
    Friend WithEvents InpLUsuario As TextBox
    Friend WithEvents LblLCaptcha As TextBox
    Friend WithEvents BtnLCaptcha As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
