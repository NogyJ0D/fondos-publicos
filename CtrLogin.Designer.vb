﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
    Me.InpCuil = New System.Windows.Forms.TextBox()
    Me.PnlCuil = New System.Windows.Forms.Panel()
    Me.PnlContraseña = New System.Windows.Forms.Panel()
    Me.LblECuil = New System.Windows.Forms.Label()
    Me.LblEContraseña = New System.Windows.Forms.Label()
    Me.LblECaptcha = New System.Windows.Forms.Label()
    Me.LblECredenciales = New System.Windows.Forms.Label()
    Me.PnlCaptcha = New System.Windows.Forms.Panel()
    Me.TmrCaptcha = New System.Windows.Forms.Timer(Me.components)
    Me.BtnCaptcha = New System.Windows.Forms.PictureBox()
    Me.PcbCaptcha = New System.Windows.Forms.PictureBox()
    Me.BtnViewRegistro = New System.Windows.Forms.Button()
    Me.BtnSkipCaptcha = New System.Windows.Forms.Button()
    Me.PnlCuil.SuspendLayout()
    Me.PnlContraseña.SuspendLayout()
    Me.PnlCaptcha.SuspendLayout()
    CType(Me.BtnCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PcbCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'BtnLogin
    '
    Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
    Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
    Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(73, Byte), Integer))
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
    Me.InpCaptcha.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
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
    Me.InpContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
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
    'InpCuil
    '
    Me.InpCuil.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
    Me.InpCuil.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.InpCuil.Dock = System.Windows.Forms.DockStyle.Fill
    Me.InpCuil.Font = New System.Drawing.Font("Verdana", 17.0!)
    Me.InpCuil.ForeColor = System.Drawing.Color.WhiteSmoke
    Me.InpCuil.Location = New System.Drawing.Point(2, 2)
    Me.InpCuil.Margin = New System.Windows.Forms.Padding(0)
    Me.InpCuil.Name = "InpCuil"
    Me.InpCuil.Size = New System.Drawing.Size(365, 28)
    Me.InpCuil.TabIndex = 0
    Me.InpCuil.Text = "CUIL"
    '
    'PnlCuil
    '
    Me.PnlCuil.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.PnlCuil.Controls.Add(Me.InpCuil)
    Me.PnlCuil.Location = New System.Drawing.Point(240, 112)
    Me.PnlCuil.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlCuil.Name = "PnlCuil"
    Me.PnlCuil.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlCuil.Size = New System.Drawing.Size(369, 32)
    Me.PnlCuil.TabIndex = 25
    '
    'PnlContraseña
    '
    Me.PnlContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.PnlContraseña.Controls.Add(Me.InpContraseña)
    Me.PnlContraseña.Location = New System.Drawing.Point(240, 176)
    Me.PnlContraseña.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
    Me.PnlContraseña.Name = "PnlContraseña"
    Me.PnlContraseña.Padding = New System.Windows.Forms.Padding(2)
    Me.PnlContraseña.Size = New System.Drawing.Size(369, 32)
    Me.PnlContraseña.TabIndex = 26
    '
    'LblECuil
    '
    Me.LblECuil.AutoSize = True
    Me.LblECuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblECuil.ForeColor = System.Drawing.Color.Red
    Me.LblECuil.Location = New System.Drawing.Point(240, 88)
    Me.LblECuil.Name = "LblECuil"
    Me.LblECuil.Size = New System.Drawing.Size(140, 20)
    Me.LblECuil.TabIndex = 27
    Me.LblECuil.Text = "Ingrese su CUIL"
    Me.LblECuil.Visible = False
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
    Me.PnlCaptcha.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
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
    Me.BtnCaptcha.Location = New System.Drawing.Point(544, 248)
    Me.BtnCaptcha.Name = "BtnCaptcha"
    Me.BtnCaptcha.Size = New System.Drawing.Size(56, 56)
    Me.BtnCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
    'BtnViewRegistro
    '
    Me.BtnViewRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(88, Byte), Integer))
    Me.BtnViewRegistro.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnViewRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer))
    Me.BtnViewRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
    Me.BtnViewRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(73, Byte), Integer))
    Me.BtnViewRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnViewRegistro.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BtnViewRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
    Me.BtnViewRegistro.Location = New System.Drawing.Point(240, 390)
    Me.BtnViewRegistro.Name = "BtnViewRegistro"
    Me.BtnViewRegistro.Size = New System.Drawing.Size(368, 46)
    Me.BtnViewRegistro.TabIndex = 31
    Me.BtnViewRegistro.Text = "¿No tienes una cuenta? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click aquí para registrarte."
    Me.BtnViewRegistro.UseVisualStyleBackColor = False
    '
    'BtnSkipCaptcha
    '
    Me.BtnSkipCaptcha.FlatAppearance.BorderSize = 0
    Me.BtnSkipCaptcha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
    Me.BtnSkipCaptcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
    Me.BtnSkipCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.BtnSkipCaptcha.Location = New System.Drawing.Point(808, 416)
    Me.BtnSkipCaptcha.Name = "BtnSkipCaptcha"
    Me.BtnSkipCaptcha.Size = New System.Drawing.Size(43, 47)
    Me.BtnSkipCaptcha.TabIndex = 32
    Me.BtnSkipCaptcha.UseVisualStyleBackColor = True
    '
    'CtrLogin
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Controls.Add(Me.BtnSkipCaptcha)
    Me.Controls.Add(Me.BtnViewRegistro)
    Me.Controls.Add(Me.LblECuil)
    Me.Controls.Add(Me.PnlCuil)
    Me.Controls.Add(Me.LblEContraseña)
    Me.Controls.Add(Me.PnlContraseña)
    Me.Controls.Add(Me.PnlCaptcha)
    Me.Controls.Add(Me.LblECaptcha)
    Me.Controls.Add(Me.BtnCaptcha)
    Me.Controls.Add(Me.PcbCaptcha)
    Me.Controls.Add(Me.LblECredenciales)
    Me.Controls.Add(Me.BtnLogin)
    Me.Name = "CtrLogin"
    Me.Size = New System.Drawing.Size(845, 458)
    Me.PnlCuil.ResumeLayout(False)
    Me.PnlCuil.PerformLayout()
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
    Friend WithEvents InpCuil As TextBox
    Friend WithEvents BtnCaptcha As PictureBox
    Friend WithEvents PcbCaptcha As PictureBox
    Friend WithEvents PnlCuil As Panel
    Friend WithEvents PnlContraseña As Panel
    Friend WithEvents LblECuil As Label
    Friend WithEvents LblEContraseña As Label
    Friend WithEvents LblECaptcha As Label
    Friend WithEvents LblECredenciales As Label
    Friend WithEvents PnlCaptcha As Panel
    Friend WithEvents TmrCaptcha As Timer
    Friend WithEvents BtnViewRegistro As Button
    Friend WithEvents BtnSkipCaptcha As Button
End Class
