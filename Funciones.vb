Imports System.Drawing.Text

Module Funciones
  Public Sub CambiarVista(origen As String)
    Select Case origen
      Case "Main"
        Viewing = ViewMain
      Case "Login"
        Viewing = ViewLogin
      Case "Registro"
        If Not UserLogged Then
          Viewing = ViewRegistro
        Else
          MsgBox("No puedes registrarte teniendo ya una cuenta abierta.", MsgBoxStyle.Critical, "Error")
        End If
      Case "NuevosProy"
        Viewing = ViewNuevosProy
      Case "ViewCargarProy"
        If UserInfo.UserRol >= 2 Then
          Viewing = ViewCargarProy
        Else
          MsgBox("No posees el rol válido para esto.", MsgBoxStyle.Critical, "Permisos insuficientes")
        End If
      Case "Foro"
        Viewing = ViewForo
    End Select
    OpenedMain.PnlView.Controls.Clear()
    OpenedMain.PnlView.Controls.Add(Viewing)
  End Sub
  Public Function GenerarCaptcha(ByRef len As Integer, ByRef upper As Boolean) As String
    Dim rand As New Random()
    Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
    Dim final As String = String.Empty
    For i As Integer = 0 To len - 1
      final += allowableChars(rand.Next(allowableChars.Length - 1))
    Next

    Return IIf(upper, final.ToUpper(), final)
  End Function
  Public Function MostrarCaptcha()
    Dim pfc As New PrivateFontCollection()
    pfc.AddFontFile("./Recursos/Mom_font.ttf")
    Captcha = GenerarCaptcha(6, False)

    Dim newImage As New Bitmap(288, 40)
    Dim gr As Graphics = Graphics.FromImage(newImage)
    Dim rec As New RectangleF(0, 0, newImage.Width, newImage.Height)
    Dim strF As New StringFormat With {
      .Alignment = StringAlignment.Center,
      .LineAlignment = StringAlignment.Center
    }
    With gr
      .Clear(Color.White)
      .DrawImageUnscaled(newImage, 0, 0)
      .DrawString(Captcha, New Font(pfc.Families(0), 22), Brushes.Black, rec, strF)
    End With

    Return newImage
  End Function
  Public Function EnviarEmail(email As String)
    '    Dim foto = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Gtk-ok.svg/2048px-Gtk-ok.svg.png"
    '    If email.Length > 0 Then
    '      Try
    '        Dim apiKey = ConfigurationManager.AppSettings("SENDGRID_APIKEY")
    '        Dim cliente = New SendGridClient(apiKey)
    '        Dim msg = New SendGridMessage() With {
    '.From = New EmailAddress(email, "Fondos Públicos"),
    '.Subject = "Registro exitoso - Fondos Públicos",
    '.PlainTextContent = "Registro exitoso - Fondos Públicos",
    '.HtmlContent = $"<b>Gracias por registrarte en Fondos Públicos</b><img src='{foto}'/>"
    '}
    '        msg.AddTo(New EmailAddress(email, "Fondos Públicos"))
    '        Dim response = Await cliente.SendEmailAsync(msg)
    '        Return True
    '      Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return False
    '      End Try
    'End If
    'Return False
    'Return True
  End Function
  ' Esperar y congelar
  'Declare Sub Esperar Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
  ' Esperar sin congelar
  Public Sub Esperar(ByVal interval As Integer)
    Dim stopW As New Stopwatch
    stopW.Start()
    Do While stopW.ElapsedMilliseconds < interval
      Application.DoEvents()
    Loop
    stopW.Stop()
  End Sub
  ' Mover Ventana
  Dim Pos As Point
  Public Sub MoverVentana(sender As Object, e As System.Windows.Forms.MouseEventArgs)
    If e.Button = Windows.Forms.MouseButtons.Left Then
      OpenedMain.Location += Control.MousePosition - Pos
    End If
    Pos = Control.MousePosition
  End Sub
  Public Sub AuthError(pnl As Panel, lbl As Label, cond As Boolean)
    If cond Then
      pnl.BackColor = Color.Red
      lbl.Show()
    Else
      pnl.BackColor = Color.White
      lbl.Hide()
    End If
  End Sub
  Public Sub AlternarHover(inp As TextBox, texto As String, cond As Boolean)
    If cond Then
      If inp.Text = texto Then
        inp.Text = ""
      End If
    Else
      If inp.Text = "" Then
        inp.Text = texto
      End If
    End If
  End Sub
End Module