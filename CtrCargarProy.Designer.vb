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
    Me.InpEstado = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    CType(Me.InpMonto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'InpDesc
    '
    Me.InpDesc.Location = New System.Drawing.Point(40, 80)
    Me.InpDesc.Name = "InpDesc"
    Me.InpDesc.Size = New System.Drawing.Size(100, 96)
    Me.InpDesc.TabIndex = 0
    Me.InpDesc.Text = ""
    '
    'BtnEnviar
    '
    Me.BtnEnviar.Location = New System.Drawing.Point(232, 296)
    Me.BtnEnviar.Name = "BtnEnviar"
    Me.BtnEnviar.Size = New System.Drawing.Size(75, 23)
    Me.BtnEnviar.TabIndex = 1
    Me.BtnEnviar.Text = "Button1"
    Me.BtnEnviar.UseVisualStyleBackColor = True
    '
    'InpTitulo
    '
    Me.InpTitulo.Location = New System.Drawing.Point(240, 160)
    Me.InpTitulo.MaxLength = 120
    Me.InpTitulo.Name = "InpTitulo"
    Me.InpTitulo.Size = New System.Drawing.Size(100, 20)
    Me.InpTitulo.TabIndex = 2
    '
    'InpFecha
    '
    Me.InpFecha.CustomFormat = "dd/MM/yyyy"
    Me.InpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.InpFecha.Location = New System.Drawing.Point(392, 160)
    Me.InpFecha.Name = "InpFecha"
    Me.InpFecha.Size = New System.Drawing.Size(200, 20)
    Me.InpFecha.TabIndex = 3
    '
    'InpMonto
    '
    Me.InpMonto.DecimalPlaces = 2
    Me.InpMonto.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
    Me.InpMonto.Location = New System.Drawing.Point(232, 232)
    Me.InpMonto.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
    Me.InpMonto.Name = "InpMonto"
    Me.InpMonto.Size = New System.Drawing.Size(120, 20)
    Me.InpMonto.TabIndex = 4
    '
    'InpEstado
    '
    Me.InpEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.InpEstado.FormattingEnabled = True
    Me.InpEstado.Items.AddRange(New Object() {"Aprobado", "En votación"})
    Me.InpEstado.Location = New System.Drawing.Point(232, 104)
    Me.InpEstado.Name = "InpEstado"
    Me.InpEstado.Size = New System.Drawing.Size(121, 21)
    Me.InpEstado.TabIndex = 7
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(48, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(30, 13)
    Me.Label1.TabIndex = 8
    Me.Label1.Text = "desc"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(232, 80)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(39, 13)
    Me.Label2.TabIndex = 9
    Me.Label2.Text = "estado"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(248, 144)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(29, 13)
    Me.Label3.TabIndex = 10
    Me.Label3.Text = "titulo"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(392, 136)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(34, 13)
    Me.Label4.TabIndex = 11
    Me.Label4.Text = "fecha"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(248, 216)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(36, 13)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "monto"
    '
    'CtrCargarProy
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.InpEstado)
    Me.Controls.Add(Me.InpMonto)
    Me.Controls.Add(Me.InpFecha)
    Me.Controls.Add(Me.InpTitulo)
    Me.Controls.Add(Me.BtnEnviar)
    Me.Controls.Add(Me.InpDesc)
    Me.Name = "CtrCargarProy"
    Me.Size = New System.Drawing.Size(847, 466)
    CType(Me.InpMonto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents InpDesc As RichTextBox
  Friend WithEvents BtnEnviar As Button
  Friend WithEvents InpTitulo As TextBox
  Friend WithEvents InpFecha As DateTimePicker
  Friend WithEvents InpMonto As NumericUpDown
  Friend WithEvents InpEstado As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label5 As Label
End Class
