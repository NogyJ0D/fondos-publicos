<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrCargarProy
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
    Me.InpDesc = New System.Windows.Forms.RichTextBox()
    Me.BtnEnviar = New System.Windows.Forms.Button()
    Me.InpTitulo = New System.Windows.Forms.TextBox()
    Me.InpFecha = New System.Windows.Forms.DateTimePicker()
    Me.InpMonto = New System.Windows.Forms.NumericUpDown()
    Me.InpVFavor = New System.Windows.Forms.NumericUpDown()
    Me.InpVC = New System.Windows.Forms.NumericUpDown()
    Me.InpEstado = New System.Windows.Forms.ComboBox()
    CType(Me.InpMonto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.InpVFavor, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.InpVC, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'InpDesc
    '
    Me.InpDesc.Location = New System.Drawing.Point(32, 8)
    Me.InpDesc.Name = "InpDesc"
    Me.InpDesc.Size = New System.Drawing.Size(100, 96)
    Me.InpDesc.TabIndex = 0
    Me.InpDesc.Text = ""
    '
    'BtnEnviar
    '
    Me.BtnEnviar.Location = New System.Drawing.Point(48, 208)
    Me.BtnEnviar.Name = "BtnEnviar"
    Me.BtnEnviar.Size = New System.Drawing.Size(75, 23)
    Me.BtnEnviar.TabIndex = 1
    Me.BtnEnviar.Text = "Button1"
    Me.BtnEnviar.UseVisualStyleBackColor = True
    '
    'InpTitulo
    '
    Me.InpTitulo.Location = New System.Drawing.Point(32, 112)
    Me.InpTitulo.Name = "InpTitulo"
    Me.InpTitulo.Size = New System.Drawing.Size(100, 20)
    Me.InpTitulo.TabIndex = 2
    '
    'InpFecha
    '
    Me.InpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.InpFecha.Location = New System.Drawing.Point(8, 152)
    Me.InpFecha.Name = "InpFecha"
    Me.InpFecha.Size = New System.Drawing.Size(200, 20)
    Me.InpFecha.TabIndex = 3
    '
    'InpMonto
    '
    Me.InpMonto.Location = New System.Drawing.Point(32, 184)
    Me.InpMonto.Name = "InpMonto"
    Me.InpMonto.Size = New System.Drawing.Size(120, 20)
    Me.InpMonto.TabIndex = 4
    '
    'InpVFavor
    '
    Me.InpVFavor.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
    Me.InpVFavor.Location = New System.Drawing.Point(152, 48)
    Me.InpVFavor.Name = "InpVFavor"
    Me.InpVFavor.Size = New System.Drawing.Size(120, 20)
    Me.InpVFavor.TabIndex = 5
    '
    'InpVC
    '
    Me.InpVC.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
    Me.InpVC.Location = New System.Drawing.Point(152, 80)
    Me.InpVC.Name = "InpVC"
    Me.InpVC.Size = New System.Drawing.Size(120, 20)
    Me.InpVC.TabIndex = 6
    '
    'InpEstado
    '
    Me.InpEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.InpEstado.FormattingEnabled = True
    Me.InpEstado.Items.AddRange(New Object() {"Aprobado", "En votación"})
    Me.InpEstado.Location = New System.Drawing.Point(152, 24)
    Me.InpEstado.Name = "InpEstado"
    Me.InpEstado.Size = New System.Drawing.Size(121, 21)
    Me.InpEstado.TabIndex = 7
    '
    'CtrCargarProy
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.InpEstado)
    Me.Controls.Add(Me.InpVC)
    Me.Controls.Add(Me.InpVFavor)
    Me.Controls.Add(Me.InpMonto)
    Me.Controls.Add(Me.InpFecha)
    Me.Controls.Add(Me.InpTitulo)
    Me.Controls.Add(Me.BtnEnviar)
    Me.Controls.Add(Me.InpDesc)
    Me.Name = "CtrCargarProy"
    Me.Size = New System.Drawing.Size(388, 243)
    CType(Me.InpMonto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.InpVFavor, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.InpVC, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents InpDesc As RichTextBox
  Friend WithEvents BtnEnviar As Button
  Friend WithEvents InpTitulo As TextBox
  Friend WithEvents InpFecha As DateTimePicker
  Friend WithEvents InpMonto As NumericUpDown
  Friend WithEvents InpVFavor As NumericUpDown
  Friend WithEvents InpVC As NumericUpDown
  Friend WithEvents InpEstado As ComboBox
End Class
