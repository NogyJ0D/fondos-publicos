Imports System.Configuration
Imports System.Drawing.Text
Imports SendGrid
Imports SendGrid.Helpers.Mail

Module Funciones
  Public Sub CambiarVista(origen As String)
    Select Case origen
      Case "Main"
        OpenedMain.PnlView.Controls.Clear()
        OpenedMain.PnlView.Controls.Add(ViewMain)
      Case "Login"
        OpenedMain.PnlView.Controls.Clear()
        OpenedMain.PnlView.Controls.Add(ViewLogin)
    End Select
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
End Module