﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrRegistro
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
    Me.LblECuil = New System.Windows.Forms.Label()
    Me.PnlCuil = New System.Windows.Forms.Panel()
    Me.InpCuil = New System.Windows.Forms.TextBox()
    Me.LblEContraseña = New System.Windows.Forms.Label()
    Me.PnlContraseña = New System.Windows.Forms.Panel()
    Me.InpContraseña = New System.Windows.Forms.TextBox()
    Me.PnlCaptcha = New System.Windows.Forms.Panel()
    Me.InpCaptcha = New System.Windows.Forms.TextBox()
    Me.LblECaptcha = New System.Windows.Forms.Label()
    Me.BtnCaptcha = New System.Windows.Forms.PictureBox()
    Me.PcbCaptcha = New System.Windows.Forms.PictureBox()
    Me.BtnRegistro = New System.Windows.Forms.Button()
    Me.LblEEmail = New System.Windows.Forms.Label()
    Me.PnlEmail = New System.Windows.Forms.Panel()
    Me.InpEmail = New System.Windows.Forms.TextBox()
    Me.LblENombre = New System.Windows.Forms.Label()
    Me.PnlNombre = New System.Windows.Forms.Panel()
    Me.InpNombre = New System.Windows.Forms.TextBox()
    Me.LblEApellido = New System.Windows.Forms.Label()
    Me.PnlApellido = New System.Windows.Forms.Panel()
    Me.InpApellido = New System.Windows.Forms.TextBox()
    Me.LblEDireccion = New System.Windows.Forms.Label()
    Me.PnlDireccion = New System.Windows.Forms.Panel()
    Me.InpDireccion = New System.Windows.Forms.TextBox()
    Me.PnlAltura = New System.Windows.Forms.Panel()
    Me.InpAltura = New System.Windows.Forms.TextBox()
    Me.LblECP = New System.Windows.Forms.Label()
    Me.PnlCP = New System.Windows.Forms.Panel()
    Me.InpCP = New System.Windows.Forms.TextBox()
    Me.LblExito = New System.Windows.Forms.Label()
    Me.InpFN = New System.Windows.Forms.DateTimePicker()
    Me.LblFN = New System.Windows.Forms.Label()
    Me.PnlFN = New System.Windows.Forms.Panel()
    Me.PnlCuil.SuspendLayout()
    Me.PnlContraseña.SuspendLayout()
    Me.PnlCaptcha.SuspendLayout()
    CType(Me.BtnCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PcbCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.PnlEmail.SuspendLayout()
    Me.PnlNombre.SuspendLayout()
    Me.PnlApellido.SuspendLayout()
    Me.PnlDireccion.SuspendLayout()
    Me.PnlAltura.SuspendLayout()
    Me.PnlCP.SuspendLayout()
    Me.PnlFN.SuspendLayout()
    Me.SuspendLayout()
    '
    'LblECuil
    '
    Me.LblECuil.AutoSize = True
    Me.LblECuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblECuil.ForeColor = System.Drawing.Color.Red
    Me.LblECuil.Location = New System.Drawing.Point(8, 8)
    Me.LblECuil.Name = "LblECuil"
    Me.LblECuil.Size = New System.Drawing.Size(140, 20)
    Me.LblECuil.TabIndex = 37
    Me.LblECuil.Text = "Ingrese su CUIL"
    Me.LblECuil.Visible = False
    '
    'PnlCuil
    '
    Me.PnlCuil.BackColor = System.Drawing.Color.White
    Me.PnlCuil.Controls.Add(Me.InpCuil)
    Me.PnlCuil.Location = New System.Drawing.Point(8, 32)
    Me.PnlCuil.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlCuil.Name = "PnlCuil"
    Me.PnlCuil.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlCuil.Size = New System.Drawing.Size(369, 32)
    Me.PnlCuil.TabIndex = 35
    '
    'InpCuil
    '
    Me.InpCuil.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
    Me.InpCuil.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpCuil.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpCuil.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpCuil.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpCuil.Location = New System.Drawing.Point(2, 2)
    Me.InpCuil.Margin = New System.Windows.Forms.Padding(0)
    Me.InpCuil.Name = "InpCuil"
    Me.InpCuil.Size = New System.Drawing.Size(365, 28)
    Me.InpCuil.TabIndex = 0
    Me.InpCuil.Text = "Usuario"
    '
    'LblEContraseña
    '
    Me.LblEContraseña.AutoSize = True
    Me.LblEContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblEContraseña.ForeColor = System.Drawing.Color.Red
    Me.LblEContraseña.Location = New System.Drawing.Point(8, 72)
    Me.LblEContraseña.Name = "LblEContraseña"
    Me.LblEContraseña.Size = New System.Drawing.Size(189, 20)
    Me.LblEContraseña.TabIndex = 39
    Me.LblEContraseña.Text = "Ingrese su contraseña"
    Me.LblEContraseña.Visible = False
    '
    'PnlContraseña
    '
    Me.PnlContraseña.BackColor = System.Drawing.Color.White
    Me.PnlContraseña.Controls.Add(Me.InpContraseña)
    Me.PnlContraseña.Location = New System.Drawing.Point(8, 96)
    Me.PnlContraseña.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlContraseña.Name = "PnlContraseña"
    Me.PnlContraseña.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlContraseña.Size = New System.Drawing.Size(369, 32)
    Me.PnlContraseña.TabIndex = 36
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
    'PnlCaptcha
    '
    Me.PnlCaptcha.BackColor = System.Drawing.Color.White
    Me.PnlCaptcha.Controls.Add(Me.InpCaptcha)
    Me.PnlCaptcha.Location = New System.Drawing.Point(8, 208)
    Me.PnlCaptcha.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlCaptcha.Name = "PnlCaptcha"
    Me.PnlCaptcha.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlCaptcha.Size = New System.Drawing.Size(289, 24)
    Me.PnlCaptcha.TabIndex = 38
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
    'LblECaptcha
    '
    Me.LblECaptcha.AutoSize = True
    Me.LblECaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblECaptcha.ForeColor = System.Drawing.Color.Red
    Me.LblECaptcha.Location = New System.Drawing.Point(8, 136)
    Me.LblECaptcha.Name = "LblECaptcha"
    Me.LblECaptcha.Size = New System.Drawing.Size(190, 20)
    Me.LblECaptcha.TabIndex = 40
    Me.LblECaptcha.Text = "El captcha no coincide"
    Me.LblECaptcha.Visible = False
    '
    'BtnCaptcha
    '
    Me.BtnCaptcha.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnCaptcha.Image = Global.fondos_publicos.My.Resources.Resources.recargar
    Me.BtnCaptcha.Location = New System.Drawing.Point(312, 168)
    Me.BtnCaptcha.Name = "BtnCaptcha"
    Me.BtnCaptcha.Size = New System.Drawing.Size(56, 56)
    Me.BtnCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.BtnCaptcha.TabIndex = 33
    Me.BtnCaptcha.TabStop = False
    '
    'PcbCaptcha
    '
    Me.PcbCaptcha.Location = New System.Drawing.Point(8, 160)
    Me.PcbCaptcha.Name = "PcbCaptcha"
    Me.PcbCaptcha.Size = New System.Drawing.Size(288, 40)
    Me.PcbCaptcha.TabIndex = 34
    Me.PcbCaptcha.TabStop = False
    '
    'BtnRegistro
    '
    Me.BtnRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
    Me.BtnRegistro.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White
    Me.BtnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(59, Byte), Integer))
    Me.BtnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.BtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnRegistro.Font = New System.Drawing.Font("Verdana", 14.0!)
    Me.BtnRegistro.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.BtnRegistro.Location = New System.Drawing.Point(8, 264)
    Me.BtnRegistro.Name = "BtnRegistro"
    Me.BtnRegistro.Size = New System.Drawing.Size(369, 33)
    Me.BtnRegistro.TabIndex = 32
    Me.BtnRegistro.Text = "ACCEDER"
    Me.BtnRegistro.UseVisualStyleBackColor = False
    '
    'LblEEmail
    '
    Me.LblEEmail.AutoSize = True
    Me.LblEEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblEEmail.ForeColor = System.Drawing.Color.Red
    Me.LblEEmail.Location = New System.Drawing.Point(384, 8)
    Me.LblEEmail.Name = "LblEEmail"
    Me.LblEEmail.Size = New System.Drawing.Size(141, 20)
    Me.LblEEmail.TabIndex = 44
    Me.LblEEmail.Text = "Ingrese su email"
    Me.LblEEmail.Visible = False
    '
    'PnlEmail
    '
    Me.PnlEmail.BackColor = System.Drawing.Color.White
    Me.PnlEmail.Controls.Add(Me.InpEmail)
    Me.PnlEmail.Location = New System.Drawing.Point(384, 32)
    Me.PnlEmail.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlEmail.Name = "PnlEmail"
    Me.PnlEmail.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlEmail.Size = New System.Drawing.Size(369, 32)
    Me.PnlEmail.TabIndex = 43
    '
    'InpEmail
    '
    Me.InpEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
    Me.InpEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpEmail.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpEmail.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpEmail.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpEmail.Location = New System.Drawing.Point(2, 2)
    Me.InpEmail.Margin = New System.Windows.Forms.Padding(0)
    Me.InpEmail.Name = "InpEmail"
    Me.InpEmail.Size = New System.Drawing.Size(365, 28)
    Me.InpEmail.TabIndex = 0
    Me.InpEmail.Text = "Usuario"
    '
    'LblENombre
    '
    Me.LblENombre.AutoSize = True
    Me.LblENombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblENombre.ForeColor = System.Drawing.Color.Red
    Me.LblENombre.Location = New System.Drawing.Point(384, 72)
    Me.LblENombre.Name = "LblENombre"
    Me.LblENombre.Size = New System.Drawing.Size(159, 20)
    Me.LblENombre.TabIndex = 46
    Me.LblENombre.Text = "Ingrese su nombre"
    Me.LblENombre.Visible = False
    '
    'PnlNombre
    '
    Me.PnlNombre.BackColor = System.Drawing.Color.White
    Me.PnlNombre.Controls.Add(Me.InpNombre)
    Me.PnlNombre.Location = New System.Drawing.Point(384, 96)
    Me.PnlNombre.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlNombre.Name = "PnlNombre"
    Me.PnlNombre.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlNombre.Size = New System.Drawing.Size(369, 32)
    Me.PnlNombre.TabIndex = 45
    '
    'InpNombre
    '
    Me.InpNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
    Me.InpNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpNombre.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpNombre.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpNombre.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpNombre.Location = New System.Drawing.Point(2, 2)
    Me.InpNombre.Margin = New System.Windows.Forms.Padding(0)
    Me.InpNombre.Name = "InpNombre"
    Me.InpNombre.Size = New System.Drawing.Size(365, 28)
    Me.InpNombre.TabIndex = 0
    Me.InpNombre.Text = "Nombre"
    '
    'LblEApellido
    '
    Me.LblEApellido.AutoSize = True
    Me.LblEApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblEApellido.ForeColor = System.Drawing.Color.Red
    Me.LblEApellido.Location = New System.Drawing.Point(384, 136)
    Me.LblEApellido.Name = "LblEApellido"
    Me.LblEApellido.Size = New System.Drawing.Size(161, 20)
    Me.LblEApellido.TabIndex = 48
    Me.LblEApellido.Text = "Ingrese su apellido"
    Me.LblEApellido.Visible = False
    '
    'PnlApellido
    '
    Me.PnlApellido.BackColor = System.Drawing.Color.White
    Me.PnlApellido.Controls.Add(Me.InpApellido)
    Me.PnlApellido.Location = New System.Drawing.Point(384, 160)
    Me.PnlApellido.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlApellido.Name = "PnlApellido"
    Me.PnlApellido.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlApellido.Size = New System.Drawing.Size(369, 32)
    Me.PnlApellido.TabIndex = 47
    '
    'InpApellido
    '
    Me.InpApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
    Me.InpApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpApellido.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpApellido.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpApellido.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpApellido.Location = New System.Drawing.Point(2, 2)
    Me.InpApellido.Margin = New System.Windows.Forms.Padding(0)
    Me.InpApellido.Name = "InpApellido"
    Me.InpApellido.Size = New System.Drawing.Size(365, 28)
    Me.InpApellido.TabIndex = 0
    Me.InpApellido.Text = "Apellido"
    '
    'LblEDireccion
    '
    Me.LblEDireccion.AutoSize = True
    Me.LblEDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblEDireccion.ForeColor = System.Drawing.Color.Red
    Me.LblEDireccion.Location = New System.Drawing.Point(384, 200)
    Me.LblEDireccion.Name = "LblEDireccion"
    Me.LblEDireccion.Size = New System.Drawing.Size(171, 20)
    Me.LblEDireccion.TabIndex = 50
    Me.LblEDireccion.Text = "Ingrese su dirección"
    Me.LblEDireccion.Visible = False
    '
    'PnlDireccion
    '
    Me.PnlDireccion.BackColor = System.Drawing.Color.White
    Me.PnlDireccion.Controls.Add(Me.InpDireccion)
    Me.PnlDireccion.Location = New System.Drawing.Point(384, 224)
    Me.PnlDireccion.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlDireccion.Name = "PnlDireccion"
    Me.PnlDireccion.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlDireccion.Size = New System.Drawing.Size(280, 32)
    Me.PnlDireccion.TabIndex = 49
    '
    'InpDireccion
    '
    Me.InpDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
    Me.InpDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpDireccion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpDireccion.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpDireccion.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpDireccion.Location = New System.Drawing.Point(2, 2)
    Me.InpDireccion.Margin = New System.Windows.Forms.Padding(0)
    Me.InpDireccion.Name = "InpDireccion"
    Me.InpDireccion.Size = New System.Drawing.Size(276, 28)
    Me.InpDireccion.TabIndex = 0
    Me.InpDireccion.Text = "Calle"
    '
    'PnlAltura
    '
    Me.PnlAltura.BackColor = System.Drawing.Color.White
    Me.PnlAltura.Controls.Add(Me.InpAltura)
    Me.PnlAltura.Location = New System.Drawing.Point(672, 224)
    Me.PnlAltura.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlAltura.Name = "PnlAltura"
    Me.PnlAltura.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlAltura.Size = New System.Drawing.Size(80, 32)
    Me.PnlAltura.TabIndex = 51
    '
    'InpAltura
    '
    Me.InpAltura.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
    Me.InpAltura.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpAltura.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpAltura.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpAltura.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpAltura.Location = New System.Drawing.Point(2, 2)
    Me.InpAltura.Margin = New System.Windows.Forms.Padding(0)
    Me.InpAltura.Name = "InpAltura"
    Me.InpAltura.Size = New System.Drawing.Size(76, 28)
    Me.InpAltura.TabIndex = 0
    Me.InpAltura.Text = "Altura"
    '
    'LblECP
    '
    Me.LblECP.AutoSize = True
    Me.LblECP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblECP.ForeColor = System.Drawing.Color.Red
    Me.LblECP.Location = New System.Drawing.Point(384, 264)
    Me.LblECP.Name = "LblECP"
    Me.LblECP.Size = New System.Drawing.Size(206, 20)
    Me.LblECP.TabIndex = 54
    Me.LblECP.Text = "Ingrese su código postal"
    Me.LblECP.Visible = False
    '
    'PnlCP
    '
    Me.PnlCP.BackColor = System.Drawing.Color.White
    Me.PnlCP.Controls.Add(Me.InpCP)
    Me.PnlCP.Location = New System.Drawing.Point(384, 288)
    Me.PnlCP.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlCP.Name = "PnlCP"
    Me.PnlCP.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlCP.Size = New System.Drawing.Size(369, 32)
    Me.PnlCP.TabIndex = 53
    '
    'InpCP
    '
    Me.InpCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
    Me.InpCP.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpCP.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpCP.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpCP.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpCP.Location = New System.Drawing.Point(2, 2)
    Me.InpCP.Margin = New System.Windows.Forms.Padding(0)
    Me.InpCP.Name = "InpCP"
    Me.InpCP.Size = New System.Drawing.Size(365, 28)
    Me.InpCP.TabIndex = 0
    Me.InpCP.Text = "Código Postal"
    '
    'LblExito
    '
    Me.LblExito.AutoSize = True
    Me.LblExito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblExito.ForeColor = System.Drawing.Color.White
    Me.LblExito.Location = New System.Drawing.Point(8, 336)
    Me.LblExito.Name = "LblExito"
    Me.LblExito.Size = New System.Drawing.Size(382, 20)
    Me.LblExito.TabIndex = 55
    Me.LblExito.Text = "Registro exitoso, valide su email para ingresar."
    Me.LblExito.Visible = False
    '
    'InpFN
    '
    Me.InpFN.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpFN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.InpFN.Location = New System.Drawing.Point(2, 2)
    Me.InpFN.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
    Me.InpFN.Name = "InpFN"
    Me.InpFN.Size = New System.Drawing.Size(108, 20)
    Me.InpFN.TabIndex = 56
    '
    'LblFN
    '
    Me.LblFN.AutoSize = True
    Me.LblFN.ForeColor = System.Drawing.Color.White
    Me.LblFN.Location = New System.Drawing.Point(424, 352)
    Me.LblFN.Name = "LblFN"
    Me.LblFN.Size = New System.Drawing.Size(106, 13)
    Me.LblFN.TabIndex = 57
    Me.LblFN.Text = "Fecha de nacimiento"
    '
    'PnlFN
    '
    Me.PnlFN.BackColor = System.Drawing.Color.White
    Me.PnlFN.Controls.Add(Me.InpFN)
    Me.PnlFN.Location = New System.Drawing.Point(568, 344)
    Me.PnlFN.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlFN.Name = "PnlFN"
    Me.PnlFN.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlFN.Size = New System.Drawing.Size(112, 24)
    Me.PnlFN.TabIndex = 58
    '
    'CtrRegistro
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.PnlFN)
    Me.Controls.Add(Me.LblFN)
    Me.Controls.Add(Me.LblExito)
    Me.Controls.Add(Me.LblECP)
    Me.Controls.Add(Me.PnlCP)
    Me.Controls.Add(Me.PnlAltura)
    Me.Controls.Add(Me.LblEDireccion)
    Me.Controls.Add(Me.PnlDireccion)
    Me.Controls.Add(Me.LblEApellido)
    Me.Controls.Add(Me.PnlApellido)
    Me.Controls.Add(Me.LblENombre)
    Me.Controls.Add(Me.PnlNombre)
    Me.Controls.Add(Me.LblEEmail)
    Me.Controls.Add(Me.PnlEmail)
    Me.Controls.Add(Me.LblECuil)
    Me.Controls.Add(Me.PnlCuil)
    Me.Controls.Add(Me.LblEContraseña)
    Me.Controls.Add(Me.PnlContraseña)
    Me.Controls.Add(Me.PnlCaptcha)
    Me.Controls.Add(Me.LblECaptcha)
    Me.Controls.Add(Me.BtnCaptcha)
    Me.Controls.Add(Me.PcbCaptcha)
    Me.Controls.Add(Me.BtnRegistro)
    Me.Name = "CtrRegistro"
    Me.Size = New System.Drawing.Size(847, 460)
    Me.PnlCuil.ResumeLayout(False)
    Me.PnlCuil.PerformLayout()
    Me.PnlContraseña.ResumeLayout(False)
    Me.PnlContraseña.PerformLayout()
    Me.PnlCaptcha.ResumeLayout(False)
    Me.PnlCaptcha.PerformLayout()
    CType(Me.BtnCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PcbCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
    Me.PnlEmail.ResumeLayout(False)
    Me.PnlEmail.PerformLayout()
    Me.PnlNombre.ResumeLayout(False)
    Me.PnlNombre.PerformLayout()
    Me.PnlApellido.ResumeLayout(False)
    Me.PnlApellido.PerformLayout()
    Me.PnlDireccion.ResumeLayout(False)
    Me.PnlDireccion.PerformLayout()
    Me.PnlAltura.ResumeLayout(False)
    Me.PnlAltura.PerformLayout()
    Me.PnlCP.ResumeLayout(False)
    Me.PnlCP.PerformLayout()
    Me.PnlFN.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents LblECuil As Label
  Friend WithEvents PnlCuil As Panel
  Friend WithEvents InpCuil As TextBox
  Friend WithEvents LblEContraseña As Label
  Friend WithEvents PnlContraseña As Panel
  Friend WithEvents InpContraseña As TextBox
  Friend WithEvents PnlCaptcha As Panel
  Friend WithEvents InpCaptcha As TextBox
  Friend WithEvents LblECaptcha As Label
  Friend WithEvents BtnCaptcha As PictureBox
  Friend WithEvents PcbCaptcha As PictureBox
  Friend WithEvents BtnRegistro As Button
  Friend WithEvents LblEEmail As Label
  Friend WithEvents PnlEmail As Panel
  Friend WithEvents InpEmail As TextBox
  Friend WithEvents LblENombre As Label
  Friend WithEvents PnlNombre As Panel
  Friend WithEvents InpNombre As TextBox
  Friend WithEvents LblEApellido As Label
  Friend WithEvents PnlApellido As Panel
  Friend WithEvents InpApellido As TextBox
  Friend WithEvents LblEDireccion As Label
  Friend WithEvents PnlDireccion As Panel
  Friend WithEvents InpDireccion As TextBox
  Friend WithEvents PnlAltura As Panel
  Friend WithEvents InpAltura As TextBox
  Friend WithEvents LblECP As Label
  Friend WithEvents PnlCP As Panel
  Friend WithEvents InpCP As TextBox
  Friend WithEvents LblExito As Label
  Friend WithEvents InpFN As DateTimePicker
  Friend WithEvents LblFN As Label
  Friend WithEvents PnlFN As Panel
End Class