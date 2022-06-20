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
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.InpMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InpDesc
        '
        Me.InpDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InpDesc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.InpDesc.Location = New System.Drawing.Point(21, 148)
        Me.InpDesc.Name = "InpDesc"
        Me.InpDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.InpDesc.Size = New System.Drawing.Size(364, 301)
        Me.InpDesc.TabIndex = 0
        Me.InpDesc.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEnviar.Location = New System.Drawing.Point(433, 408)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(200, 41)
        Me.BtnEnviar.TabIndex = 1
        Me.BtnEnviar.Text = "Cargar Proyecto"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'InpTitulo
        '
        Me.InpTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpTitulo.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.InpTitulo.Location = New System.Drawing.Point(21, 51)
        Me.InpTitulo.MaxLength = 120
        Me.InpTitulo.Name = "InpTitulo"
        Me.InpTitulo.Size = New System.Drawing.Size(217, 27)
        Me.InpTitulo.TabIndex = 2
        Me.InpTitulo.Text = "Nombre"
        '
        'InpFecha
        '
        Me.InpFecha.CustomFormat = "dd/MM/yyyy"
        Me.InpFecha.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.InpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InpFecha.Location = New System.Drawing.Point(433, 146)
        Me.InpFecha.Name = "InpFecha"
        Me.InpFecha.Size = New System.Drawing.Size(200, 27)
        Me.InpFecha.TabIndex = 3
        '
        'InpMonto
        '
        Me.InpMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InpMonto.DecimalPlaces = 2
        Me.InpMonto.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.InpMonto.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.InpMonto.Location = New System.Drawing.Point(265, 51)
        Me.InpMonto.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.InpMonto.Name = "InpMonto"
        Me.InpMonto.Size = New System.Drawing.Size(120, 27)
        Me.InpMonto.TabIndex = 4
        '
        'InpEstado
        '
        Me.InpEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InpEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.InpEstado.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.InpEstado.FormattingEnabled = True
        Me.InpEstado.Items.AddRange(New Object() {"Aprobado", "En votación"})
        Me.InpEstado.Location = New System.Drawing.Point(433, 51)
        Me.InpEstado.Name = "InpEstado"
        Me.InpEstado.Size = New System.Drawing.Size(200, 28)
        Me.InpEstado.TabIndex = 7
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(17, 115)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(89, 20)
        Me.lblDesc.TabIndex = 8
        Me.lblDesc.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(429, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(17, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre del Proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(429, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(261, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Monto"
        '
        'CtrCargarProy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.InpEstado)
        Me.Controls.Add(Me.InpMonto)
        Me.Controls.Add(Me.InpFecha)
        Me.Controls.Add(Me.InpTitulo)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.InpDesc)
        Me.Name = "CtrCargarProy"
        Me.Size = New System.Drawing.Size(652, 468)
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
  Friend WithEvents lblDesc As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label5 As Label
End Class
