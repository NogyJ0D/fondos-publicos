<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.PnlNav = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbTema = New System.Windows.Forms.ComboBox()
        Me.BtnNMinim = New System.Windows.Forms.Button()
        Me.BtnNCerrar = New System.Windows.Forms.Button()
        Me.PnlView = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.PictureBox()
        Me.BtnViewLogin = New System.Windows.Forms.PictureBox()
        Me.BtnViewMain = New System.Windows.Forms.PictureBox()
        Me.PnlNav.SuspendLayout()
        CType(Me.BtnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnViewLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlNav
        '
        Me.PnlNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.PnlNav.Controls.Add(Me.BtnLogout)
        Me.PnlNav.Controls.Add(Me.Label1)
        Me.PnlNav.Controls.Add(Me.CmbTema)
        Me.PnlNav.Controls.Add(Me.BtnNMinim)
        Me.PnlNav.Controls.Add(Me.BtnNCerrar)
        Me.PnlNav.Controls.Add(Me.BtnViewLogin)
        Me.PnlNav.Controls.Add(Me.BtnViewMain)
        Me.PnlNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlNav.Location = New System.Drawing.Point(0, 0)
        Me.PnlNav.Name = "PnlNav"
        Me.PnlNav.Size = New System.Drawing.Size(847, 42)
        Me.PnlNav.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(584, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tema:"
        '
        'CmbTema
        '
        Me.CmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTema.FormattingEnabled = True
        Me.CmbTema.Items.AddRange(New Object() {"Oscuro", "Claro"})
        Me.CmbTema.Location = New System.Drawing.Point(629, 11)
        Me.CmbTema.Name = "CmbTema"
        Me.CmbTema.Size = New System.Drawing.Size(104, 21)
        Me.CmbTema.TabIndex = 6
        '
        'BtnNMinim
        '
        Me.BtnNMinim.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BtnNMinim.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNMinim.FlatAppearance.BorderSize = 0
        Me.BtnNMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNMinim.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNMinim.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNMinim.Location = New System.Drawing.Point(763, 0)
        Me.BtnNMinim.Name = "BtnNMinim"
        Me.BtnNMinim.Size = New System.Drawing.Size(42, 42)
        Me.BtnNMinim.TabIndex = 5
        Me.BtnNMinim.TabStop = False
        Me.BtnNMinim.Text = "—"
        Me.BtnNMinim.UseVisualStyleBackColor = False
        '
        'BtnNCerrar
        '
        Me.BtnNCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BtnNCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNCerrar.FlatAppearance.BorderSize = 0
        Me.BtnNCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNCerrar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNCerrar.Location = New System.Drawing.Point(805, 0)
        Me.BtnNCerrar.Name = "BtnNCerrar"
        Me.BtnNCerrar.Size = New System.Drawing.Size(42, 42)
        Me.BtnNCerrar.TabIndex = 4
        Me.BtnNCerrar.TabStop = False
        Me.BtnNCerrar.Text = "X"
        Me.BtnNCerrar.UseVisualStyleBackColor = False
        '
        'PnlView
        '
        Me.PnlView.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PnlView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlView.Location = New System.Drawing.Point(0, 42)
        Me.PnlView.Name = "PnlView"
        Me.PnlView.Size = New System.Drawing.Size(847, 466)
        Me.PnlView.TabIndex = 2
        '
        'BtnLogout
        '
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnLogout.Enabled = False
        Me.BtnLogout.Image = Global.fondos_publicos.My.Resources.Resources.ViewLogout
        Me.BtnLogout.Location = New System.Drawing.Point(84, 0)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(7)
        Me.BtnLogout.Size = New System.Drawing.Size(42, 42)
        Me.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnLogout.TabIndex = 8
        Me.BtnLogout.TabStop = False
        Me.BtnLogout.Visible = False
        '
        'BtnViewLogin
        '
        Me.BtnViewLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnViewLogin.Image = Global.fondos_publicos.My.Resources.Resources.ViewLogin
        Me.BtnViewLogin.Location = New System.Drawing.Point(42, 0)
        Me.BtnViewLogin.Name = "BtnViewLogin"
        Me.BtnViewLogin.Padding = New System.Windows.Forms.Padding(7)
        Me.BtnViewLogin.Size = New System.Drawing.Size(42, 42)
        Me.BtnViewLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnViewLogin.TabIndex = 2
        Me.BtnViewLogin.TabStop = False
        '
        'BtnViewMain
        '
        Me.BtnViewMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnViewMain.Image = Global.fondos_publicos.My.Resources.Resources.ViewBack
        Me.BtnViewMain.Location = New System.Drawing.Point(0, 0)
        Me.BtnViewMain.Name = "BtnViewMain"
        Me.BtnViewMain.Padding = New System.Windows.Forms.Padding(7)
        Me.BtnViewMain.Size = New System.Drawing.Size(42, 42)
        Me.BtnViewMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnViewMain.TabIndex = 3
        Me.BtnViewMain.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 508)
        Me.Controls.Add(Me.PnlView)
        Me.Controls.Add(Me.PnlNav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fondos Públicos"
        Me.PnlNav.ResumeLayout(False)
        Me.PnlNav.PerformLayout()
        CType(Me.BtnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnViewLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlNav As Panel
    Friend WithEvents PnlView As Panel
    Friend WithEvents BtnViewLogin As PictureBox
    Friend WithEvents BtnViewMain As PictureBox
    Friend WithEvents BtnNMinim As Button
    Friend WithEvents BtnNCerrar As Button
    Friend WithEvents CmbTema As ComboBox
    Friend WithEvents Label1 As Label
  Friend WithEvents BtnLogout As PictureBox
End Class
