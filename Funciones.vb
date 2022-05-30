Imports System.Configuration
Imports SendGrid
Imports SendGrid.Helpers.Mail

Module Funciones
    Public Function GenerarCaptcha(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
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
End Module