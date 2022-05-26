Public Class FrmLogin
  ' Load
  Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    LblLCaptcha.Text = GenerateRandomString(6, False)
  End Sub
  ' Controles
  Private Sub BtnLCaptcha_Click(sender As Object, e As EventArgs) Handles BtnLCaptcha.Click
    LblLCaptcha.Text = GenerateRandomString(6, False)
  End Sub
  Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
    If InpLCaptcha.Text = LblLCaptcha.Text Then
      MessageBox.Show("Válido.")
    Else MessageBox.Show("No válido")
    End If
  End Sub
  ' Funciones
  Public Function GenerateRandomString(ByRef len As Integer, ByRef upper As Boolean) As String
    Dim rand As New Random()
    Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
    Dim final As String = String.Empty
    For i As Integer = 0 To len - 1
      final += allowableChars(rand.Next(allowableChars.Length - 1))
    Next

    Return IIf(upper, final.ToUpper(), final)
  End Function
End Class