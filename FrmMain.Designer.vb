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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
    Me.PnlNav = New System.Windows.Forms.Panel()
    Me.BtnViewMain = New System.Windows.Forms.PictureBox()
    Me.BtnViewLogin = New System.Windows.Forms.PictureBox()
    Me.PnlView = New System.Windows.Forms.Panel()
    Me.PnlNav.SuspendLayout()
    CType(Me.BtnViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BtnViewLogin, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PnlNav
    '
    Me.PnlNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.PnlNav.Controls.Add(Me.BtnViewMain)
    Me.PnlNav.Controls.Add(Me.BtnViewLogin)
    Me.PnlNav.Dock = System.Windows.Forms.DockStyle.Top
    Me.PnlNav.Location = New System.Drawing.Point(0, 0)
    Me.PnlNav.Name = "PnlNav"
    Me.PnlNav.Size = New System.Drawing.Size(847, 40)
    Me.PnlNav.TabIndex = 1
    '
    'BtnViewMain
    '
    Me.BtnViewMain.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnViewMain.Image = CType(resources.GetObject("BtnViewMain.Image"), System.Drawing.Image)
    Me.BtnViewMain.Location = New System.Drawing.Point(3, 3)
    Me.BtnViewMain.Name = "BtnViewMain"
    Me.BtnViewMain.Size = New System.Drawing.Size(80, 31)
    Me.BtnViewMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.BtnViewMain.TabIndex = 3
    Me.BtnViewMain.TabStop = False
    '
    'BtnViewLogin
    '
    Me.BtnViewLogin.Cursor = System.Windows.Forms.Cursors.Hand
    Me.BtnViewLogin.Image = CType(resources.GetObject("BtnViewLogin.Image"), System.Drawing.Image)
    Me.BtnViewLogin.Location = New System.Drawing.Point(764, 3)
    Me.BtnViewLogin.Name = "BtnViewLogin"
    Me.BtnViewLogin.Size = New System.Drawing.Size(80, 31)
    Me.BtnViewLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.BtnViewLogin.TabIndex = 2
    Me.BtnViewLogin.TabStop = False
    '
    'PnlView
    '
    Me.PnlView.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.PnlView.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PnlView.Location = New System.Drawing.Point(0, 40)
    Me.PnlView.Name = "PnlView"
    Me.PnlView.Size = New System.Drawing.Size(847, 460)
    Me.PnlView.TabIndex = 2
    '
    'FrmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(847, 500)
    Me.Controls.Add(Me.PnlView)
    Me.Controls.Add(Me.PnlNav)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "FrmMain"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Fondos Públicos"
    Me.PnlNav.ResumeLayout(False)
    CType(Me.BtnViewMain, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BtnViewLogin, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PnlNav As Panel
    Friend WithEvents PnlView As Panel
    Friend WithEvents BtnViewLogin As PictureBox
    Friend WithEvents BtnViewMain As PictureBox
End Class
