Public Class CtrLogin
  ' Load
  Private Sub CtrLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    LblLCaptcha.Text = GenerarCaptcha(6, False)
  End Sub
    ' Generar captcha
    Private Sub BtnLCaptcha_Click(sender As Object, e As EventArgs) Handles BtnLCaptcha.Click
        LblLCaptcha.Text = GenerarCaptcha(6, False)
    End Sub
    ' Iniciar
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If InpLCaptcha.Text = LblLCaptcha.Text Then
            MessageBox.Show("Válido.")
        Else MessageBox.Show("No válido")
        End If
    End Sub
    ' Texto placeholder en los input
    Private Sub InpLUsuario_Enter(sender As Object, e As EventArgs) Handles InpLUsuario.Enter
        If InpLUsuario.Text = "Usuario" Then
            InpLUsuario.Text = ""
        End If
    End Sub
    Private Sub InpLUsuario_Leave(sender As Object, e As EventArgs) Handles InpLUsuario.Leave
        If InpLUsuario.Text = "" Then
            InpLUsuario.Text = "Usuario"
        End If
    End Sub
    Private Sub InpLContraseña_Enter(sender As Object, e As EventArgs) Handles InpLContraseña.Enter
        If InpLContraseña.Text = "Contraseña" Then
            InpLContraseña.Text = ""
        End If
    End Sub
    Private Sub InpLContraseña_Leave(sender As Object, e As EventArgs) Handles InpLContraseña.Leave
        If InpLContraseña.Text = "" Then
            InpLContraseña.Text = "Contraseña"
        End If
    End Sub

    Private Sub BtnLCaptcha_Click_1(sender As Object, e As EventArgs)

    End Sub




End Class
