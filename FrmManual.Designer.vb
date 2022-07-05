<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManual
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManual))
    'Me.ViewManual = New AxAcroPDFLib.AxAcroPDF()
    'CType(Me.ViewManual, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ViewManual
    '
    'Me.ViewManual.Dock = System.Windows.Forms.DockStyle.Fill
    'Me.ViewManual.Enabled = True
    'Me.ViewManual.Location = New System.Drawing.Point(0, 0)
    'Me.ViewManual.Name = "ViewManual"
    'Me.ViewManual.OcxState = CType(resources.GetObject("ViewManual.OcxState"), System.Windows.Forms.AxHost.State)
    'Me.ViewManual.Size = New System.Drawing.Size(800, 450)
    'Me.ViewManual.TabIndex = 0
    '
    'FrmManual
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    'Me.Controls.Add(Me.ViewManual)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.Name = "FrmManual"
    Me.Text = "CONCOR - Manual de Usuario"
    'CType(Me.ViewManual, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
End Class
