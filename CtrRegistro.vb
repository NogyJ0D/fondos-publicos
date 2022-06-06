Public Class CtrRegistro
  Private Sub CtrRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PcbCaptcha.Image = MostrarCaptcha()

    AddHandler Me.MouseMove, AddressOf MoverVentana
  End Sub
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

  Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
    Dim Err As Boolean = False

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
    If InpEmail.Text = "" Or InpEmail.Text = "Email" Then
      AuthError(PnlEmail, LblEEmail, True)
      Err = True
    Else AuthError(PnlEmail, LblEEmail, False)
    End If
    If InpNombre.Text = "" Or InpNombre.Text = "Nombre" Then
      AuthError(PnlNombre, LblENombre, True)
      Err = True
    Else AuthError(PnlNombre, LblENombre, False)
    End If
    If InpApellido.Text = "" Or InpApellido.Text = "Apellido" Then
      AuthError(PnlApellido, LblEApellido, True)
      Err = True
    Else AuthError(PnlApellido, LblEApellido, False)
    End If
    ' TODO: seguir

  End Sub
End Class
