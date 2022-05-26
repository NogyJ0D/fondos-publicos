Public Class FrmLogin
  ' Load
  Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    LblLCaptcha.Text = GenerarCaptcha(6, False)
  End Sub
  ' Controles
  Private Sub BtnLCaptcha_Click(sender As Object, e As EventArgs) Handles BtnLCaptcha.Click
    LblLCaptcha.Text = GenerarCaptcha(6, False)
  End Sub
  Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
    If InpLCaptcha.Text = LblLCaptcha.Text Then
      MessageBox.Show("Válido.")
    Else MessageBox.Show("No válido")
    End If
  End Sub
  ' Funciones
End Class