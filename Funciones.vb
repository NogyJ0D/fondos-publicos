﻿Imports System.Configuration
Imports System.Drawing.Text
Imports SendGrid
Imports SendGrid.Helpers.Mail

Module Funciones
  Public Sub CambiarVista(origen As String)
    Dim Vista As UserControl
    Select Case origen
      Case "Main"
        OpenedMain.BtnViewMain.Hide()
        If UserLogged Then : OpenedMain.BtnViewLogin.Hide()
        Else : OpenedMain.BtnViewLogin.Show()
        End If
        Vista = ViewMain
      Case "Login"
        OpenedMain.BtnViewLogin.Hide()
        OpenedMain.BtnViewMain.Show()
        Vista = ViewLogin
      Case "Registro"
        Vista = ViewRegistro
      Case "NuevosProy"
        OpenedMain.BtnViewMain.Show()
        If UserLogged Then : OpenedMain.BtnViewLogin.Hide()
        Else : OpenedMain.BtnViewLogin.Show()
        End If
        Vista = ViewNuevosProy
    End Select
    Viewing = Vista
    OpenedMain.PnlView.Controls.Clear()
    OpenedMain.PnlView.Controls.Add(Vista)
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

    Dim newImage As Bitmap = New Bitmap(288, 40)
    Dim gr As Graphics = Graphics.FromImage(newImage)
    Dim rec As RectangleF = New RectangleF(0, 0, newImage.Width, newImage.Height)
    Dim strF As StringFormat = New StringFormat()
    strF.Alignment = StringAlignment.Center
    strF.LineAlignment = StringAlignment.Center
    gr.Clear(Color.White)
    gr.DrawImageUnscaled(newImage, 0, 0)
    gr.DrawString(Captcha, New Font(pfc.Families(0), 22), Brushes.Black, rec, strF)

    Return newImage
  End Function
  Public Async Function EnviarEmail(email As String) As Task(Of Boolean)
    Dim foto = "https://www.lavoz.com.ar/resizer/YT06bU_V2GqH2_drCrDrELNH9QU=/1023x682/smart/cloudfront-us-east-1.images.arcpublishing.com/grupoclarin/AIROXALBW5ECLJRSCCJRJKA3OU.jpg"
    If email.Length > 0 Then
      Try
        Dim apiKey = ConfigurationManager.AppSettings("SENDGRID_APIKEY")
        Dim cliente = New SendGridClient(apiKey)
        Dim msg = New SendGridMessage() With {
.From = New EmailAddress(email, "Mauricio Macri"),
.Subject = "Email de prueba - Fondos públicos",
.PlainTextContent = "Hola, soy un email",
.HtmlContent = $"<b>UwU</b><img src='{foto}'/>"
}
        msg.AddTo(New EmailAddress(email, "Fondear"))
        Dim response = Await cliente.SendEmailAsync(msg)
        Return True
      Catch ex As Exception
        MessageBox.Show(ex.Message)
        Return False
      End Try
    End If
    Return False
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
  Public Sub CambiarTema(tema As String)
    Dim ColorNav, ColorView As Color
    Select Case tema
      Case "Oscuro"
        ColorNav = Color.FromArgb(15, 41, 27)
        ColorView = Color.FromArgb(19, 56, 36)
      Case "Claro"
        ColorNav = Color.FromArgb(193, 255, 223)
        ColorView = Color.FromArgb(224, 255, 239)

        'Case "Rosario"
        '  ColorNav = Color.FromArgb(27, 75, 136)
        '  ColorView = Color.FromArgb(0, 102, 204)
        'Case "Francia"
        '  ColorNav = Color.FromArgb(230, 57, 70)
        '  ColorView = Color.FromArgb(241, 250, 238)
    End Select
    OpenedMain.PnlNav.BackColor = ColorNav
    OpenedMain.PnlView.BackColor = ColorView
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