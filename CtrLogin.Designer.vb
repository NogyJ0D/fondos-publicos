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
        Me.components = New System.ComponentModel.Container()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.InpCaptcha = New System.Windows.Forms.TextBox()
        Me.InpContraseña = New System.Windows.Forms.TextBox()
        Me.InpUsuario = New System.Windows.Forms.TextBox()
        Me.PnlUsuario = New System.Windows.Forms.Panel()
        Me.PnlContraseña = New System.Windows.Forms.Panel()
        Me.LblEUsuario = New System.Windows.Forms.Label()
        Me.LblEContraseña = New System.Windows.Forms.Label()
        Me.LblECaptcha = New System.Windows.Forms.Label()
        Me.LblECredenciales = New System.Windows.Forms.Label()
        Me.PnlCaptcha = New System.Windows.Forms.Panel()
        Me.TmrCaptcha = New System.Windows.Forms.Timer(Me.components)
        Me.BtnCaptcha = New System.Windows.Forms.PictureBox()
        Me.PcbCaptcha = New System.Windows.Forms.PictureBox()
        Me.PnlUsuario.SuspendLayout()
        Me.PnlContraseña.SuspendLayout()
        Me.PnlCaptcha.SuspendLayout()
        CType(Me.BtnCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcbCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnLogin.Location = New System.Drawing.Point(240, 344)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(369, 33)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "ACCEDER"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'InpCaptcha
        '
        Me.InpCaptcha.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpCaptcha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InpCaptcha.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InpCaptcha.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpCaptcha.Location = New System.Drawing.Point(2, 2)
        Me.InpCaptcha.Name = "InpCaptcha"
        Me.InpCaptcha.Size = New System.Drawing.Size(285, 20)
        Me.InpCaptcha.TabIndex = 2
        Me.InpCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InpContraseña
        '
        Me.InpContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpContraseña.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InpContraseña.Font = New System.Drawing.Font("Verdana", 17.0!)
        Me.InpContraseña.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpContraseña.Location = New System.Drawing.Point(2, 2)
        Me.InpContraseña.Name = "InpContraseña"
        Me.InpContraseña.Size = New System.Drawing.Size(365, 28)
        Me.InpContraseña.TabIndex = 1
        Me.InpContraseña.Text = "Contraseña"
        '
        'InpUsuario
        '
        Me.InpUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.InpUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InpUsuario.Font = New System.Drawing.Font("Verdana", 17.0!)
        Me.InpUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InpUsuario.Location = New System.Drawing.Point(2, 2)
        Me.InpUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.InpUsuario.Name = "InpUsuario"
        Me.InpUsuario.Size = New System.Drawing.Size(365, 28)
        Me.InpUsuario.TabIndex = 0
        Me.InpUsuario.Text = "Usuario"
        '
        'PnlUsuario
        '
        Me.PnlUsuario.BackColor = System.Drawing.Color.White
        Me.PnlUsuario.Controls.Add(Me.InpUsuario)
        Me.PnlUsuario.Location = New System.Drawing.Point(240, 112)
        Me.PnlUsuario.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.PnlUsuario.Name = "PnlUsuario"
        Me.PnlUsuario.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlUsuario.Size = New System.Drawing.Size(369, 32)
        Me.PnlUsuario.TabIndex = 25
        '
        'PnlContraseña
        '
        Me.PnlContraseña.BackColor = System.Drawing.Color.White
        Me.PnlContraseña.Controls.Add(Me.InpContraseña)
        Me.PnlContraseña.Location = New System.Drawing.Point(240, 176)
        Me.PnlContraseña.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.PnlContraseña.Name = "PnlContraseña"
        Me.PnlContraseña.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlContraseña.Size = New System.Drawing.Size(369, 32)
        Me.PnlContraseña.TabIndex = 26
        '
        'LblEUsuario
        '
        Me.LblEUsuario.AutoSize = True
        Me.LblEUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEUsuario.ForeColor = System.Drawing.Color.Red
        Me.LblEUsuario.Location = New System.Drawing.Point(240, 88)
        Me.LblEUsuario.Name = "LblEUsuario"
        Me.LblEUsuario.Size = New System.Drawing.Size(159, 20)
        Me.LblEUsuario.TabIndex = 27
        Me.LblEUsuario.Text = "Ingrese un usuario"
        Me.LblEUsuario.Visible = False
        '
        'LblEContraseña
        '
        Me.LblEContraseña.AutoSize = True
        Me.LblEContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEContraseña.ForeColor = System.Drawing.Color.Red
        Me.LblEContraseña.Location = New System.Drawing.Point(240, 152)
        Me.LblEContraseña.Name = "LblEContraseña"
        Me.LblEContraseña.Size = New System.Drawing.Size(200, 20)
        Me.LblEContraseña.TabIndex = 28
        Me.LblEContraseña.Text = "Ingrese una contraseña"
        Me.LblEContraseña.Visible = False
        '
        'LblECaptcha
        '
        Me.LblECaptcha.AutoSize = True
        Me.LblECaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblECaptcha.ForeColor = System.Drawing.Color.Red
        Me.LblECaptcha.Location = New System.Drawing.Point(240, 216)
        Me.LblECaptcha.Name = "LblECaptcha"
        Me.LblECaptcha.Size = New System.Drawing.Size(190, 20)
        Me.LblECaptcha.TabIndex = 29
        Me.LblECaptcha.Text = "El captcha no coincide"
        Me.LblECaptcha.Visible = False
        '
        'LblECredenciales
        '
        Me.LblECredenciales.AutoSize = True
        Me.LblECredenciales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblECredenciales.ForeColor = System.Drawing.Color.Red
        Me.LblECredenciales.Location = New System.Drawing.Point(240, 320)
        Me.LblECredenciales.Name = "LblECredenciales"
        Me.LblECredenciales.Size = New System.Drawing.Size(254, 20)
        Me.LblECredenciales.TabIndex = 30
        Me.LblECredenciales.Text = "Las credencialels no coinciden"
        Me.LblECredenciales.Visible = False
        '
        'PnlCaptcha
        '
        Me.PnlCaptcha.BackColor = System.Drawing.Color.White
        Me.PnlCaptcha.Controls.Add(Me.InpCaptcha)
        Me.PnlCaptcha.Location = New System.Drawing.Point(240, 288)
        Me.PnlCaptcha.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.PnlCaptcha.Name = "PnlCaptcha"
        Me.PnlCaptcha.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlCaptcha.Size = New System.Drawing.Size(289, 24)
        Me.PnlCaptcha.TabIndex = 27
        '
        'TmrCaptcha
        '
        Me.TmrCaptcha.Enabled = True
        Me.TmrCaptcha.Interval = 500
        '
        'BtnCaptcha
        '
        Me.BtnCaptcha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCaptcha.Image = Global.fondos_publicos.My.Resources.Resources.recargar
        Me.BtnCaptcha.Location = New System.Drawing.Point(536, 240)
        Me.BtnCaptcha.Name = "BtnCaptcha"
        Me.BtnCaptcha.Size = New System.Drawing.Size(72, 72)
        Me.BtnCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BtnCaptcha.TabIndex = 22
        Me.BtnCaptcha.TabStop = False
        '
        'PcbCaptcha
        '
        Me.PcbCaptcha.Location = New System.Drawing.Point(240, 240)
        Me.PcbCaptcha.Name = "PcbCaptcha"
        Me.PcbCaptcha.Size = New System.Drawing.Size(288, 40)
        Me.PcbCaptcha.TabIndex = 24
        Me.PcbCaptcha.TabStop = False
        '
        'CtrLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.LblEUsuario)
        Me.Controls.Add(Me.PnlUsuario)
        Me.Controls.Add(Me.LblEContraseña)
        Me.Controls.Add(Me.PnlContraseña)
        Me.Controls.Add(Me.PnlCaptcha)
        Me.Controls.Add(Me.LblECaptcha)
        Me.Controls.Add(Me.BtnCaptcha)
        Me.Controls.Add(Me.PcbCaptcha)
        Me.Controls.Add(Me.LblECredenciales)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "CtrLogin"
        Me.Size = New System.Drawing.Size(847, 460)
        Me.PnlUsuario.ResumeLayout(False)
        Me.PnlUsuario.PerformLayout()
        Me.PnlContraseña.ResumeLayout(False)
        Me.PnlContraseña.PerformLayout()
        Me.PnlCaptcha.ResumeLayout(False)
        Me.PnlCaptcha.PerformLayout()
        CType(Me.BtnCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcbCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLogin As Button
    Friend WithEvents InpCaptcha As TextBox
    Friend WithEvents InpContraseña As TextBox
    Friend WithEvents InpUsuario As TextBox
    Friend WithEvents BtnCaptcha As PictureBox
    Friend WithEvents PcbCaptcha As PictureBox
    Friend WithEvents PnlUsuario As Panel
    Friend WithEvents PnlContraseña As Panel
    Friend WithEvents LblEUsuario As Label
    Friend WithEvents LblEContraseña As Label
    Friend WithEvents LblECaptcha As Label
    Friend WithEvents LblECredenciales As Label
    Friend WithEvents PnlCaptcha As Panel
    Friend WithEvents TmrCaptcha As Timer
End Class
