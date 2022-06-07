Public Class CtrLogin
  ' Load
  Private Sub CtrLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PcbCaptcha.Image = MostrarCaptcha()

    AddHandler Me.MouseMove, AddressOf MoverVentana ' Mover formulario
  End Sub
  ' Boton captcha
  Private Sub BtnCaptcha_Click(sender As Object, e As EventArgs) Handles BtnCaptcha.Click
    BtnCaptcha.Size = New Size(46, 46)
    BtnCaptcha.Location = New Point(550, 252)
    Esperar(200)
    BtnCaptcha.Size = New Size(56, 56)
    BtnCaptcha.Location = New Point(544, 248)
    PcbCaptcha.Image = MostrarCaptcha()
  End Sub
  Private Sub BtnCaptcha_MouseEnter(sender As Object, e As EventArgs) Handles BtnCaptcha.MouseEnter
    BtnCaptcha.Image = My.Resources.Resources.recargar_hover
  End Sub
  Private Sub BtnCaptcha_MouseLeave(sender As Object, e As EventArgs) Handles BtnCaptcha.MouseLeave
    BtnCaptcha.Image = My.Resources.Resources.recargar
  End Sub
  ' Iniciar
  Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
    Dim Err As Boolean = False

    ' User mockup
    Dim Pass As String = "123"

    ' Falta
    If InpCuil.Text = "" Or InpCuil.Text = "CUIL" Then
      AuthError(PnlCuil, LblECuil, True)
      Err = True
    Else AuthError(PnlCuil, LblECuil, False)
    End If
    If InpContraseña.Text = "" Or InpContraseña.Text = "Contraseña" Then
      AuthError(PnlContraseña, LblEContraseña, True)
      Err = True
    Else AuthError(PnlContraseña, LblEContraseña, False)
    End If
    If InpCaptcha.Text <> Captcha Then
      AuthError(PnlCaptcha, LblECaptcha, True)
      Err = True
    Else AuthError(PnlCaptcha, LblECaptcha, False)
    End If

    ' No iguala
    If InpCuil.Text <> UserCuil Or InpContraseña.Text <> Pass Then
      PnlCuil.BackColor = Color.Red
      PnlContraseña.BackColor = Color.Red
      Err = True
      LblECredenciales.Show()
    Else LblECredenciales.Hide()
    End If

    ' Fin
    If Err Then Exit Sub
    UserLogged = 1
    UserCuil = InpCuil.Text

    CambiarVista("Main")
  End Sub
  ' Texto placeholder en los input
  Private Sub InpCuil_Enter(sender As Object, e As EventArgs) Handles InpCuil.Enter
    AlternarHover(InpCuil, "CUIL", True)
  End Sub
  Private Sub InpCuil_Leave(sender As Object, e As EventArgs) Handles InpCuil.Leave
    AlternarHover(InpCuil, "CUIL", False)
  End Sub
  Private Sub InpContraseña_Enter(sender As Object, e As EventArgs) Handles InpContraseña.Enter
    If InpContraseña.Text = "Contraseña" Then
      InpContraseña.Text = ""
      InpContraseña.PasswordChar = "*"
    End If
  End Sub
  Private Sub InpContraseña_Leave(sender As Object, e As EventArgs) Handles InpContraseña.Leave
    If InpContraseña.Text = "" Then
      InpContraseña.Text = "Contraseña"
      InpContraseña.PasswordChar = ""
    End If
  End Sub

  Private Sub BtnCaptcha_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCaptcha.MouseDown
    BtnCaptcha.Size = New Size(46, 46)
    BtnCaptcha.Location = New Point(550, 252)
  End Sub

  Private Sub BtnCaptcha_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCaptcha.MouseUp
    BtnCaptcha.Size = New Size(56, 56)
    BtnCaptcha.Location = New Point(544, 248)
  End Sub

  Private Sub BtnViewRegistro_Click(sender As Object, e As EventArgs) Handles BtnViewRegistro.Click
    CambiarVista("Registro")
  End Sub
End Class
