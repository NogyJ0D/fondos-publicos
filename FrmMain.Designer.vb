<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
    Me.BtnLogin = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'BtnLogin
    '
    Me.BtnLogin.Location = New System.Drawing.Point(720, 8)
    Me.BtnLogin.Name = "BtnLogin"
    Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
    Me.BtnLogin.TabIndex = 0
    Me.BtnLogin.Text = "(login icon)"
    Me.BtnLogin.UseVisualStyleBackColor = True
    '
    'FrmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.BtnLogin)
    Me.Name = "FrmMain"
    Me.Text = "FrmMain"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents BtnLogin As Button
End Class
