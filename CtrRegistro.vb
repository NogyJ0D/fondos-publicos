Public Class CtrRegistro
  Private Sub CtrRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PcbCaptcha.Image = MostrarCaptcha()

    AddHandler Me.MouseMove, AddressOf MoverVentana
  End Sub
  Private Sub BtnCaptcha_Click(sender As Object, e As EventArgs) Handles BtnCaptcha.Click
    BtnCaptcha.Size = New Size(46, 46)
    BtnCaptcha.Location = New Point(732, 300)
    Esperar(200)
    BtnCaptcha.Size = New Size(56, 56)
    BtnCaptcha.Location = New Point(728, 296)
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
    If InpDireccion.Text = "" Or InpDireccion.Text = "Calle y altura" Then
      AuthError(PnlDireccion, LblEDireccion, True)
      Err = True
    Else AuthError(PnlDireccion, LblEDireccion, False)
    End If
    If InpLocalidad.Text = "" Or InpLocalidad.Text = "Localidad" Then
      AuthError(PnlLocalidad, LblELocalidad, True)
      Err = True
    Else AuthError(PnlLocalidad, LblELocalidad, False)
    End If
    If InpCP.Text = "" Or InpCP.Text = "Código Postal" Then
      AuthError(PnlCP, LblECP, True)
      Err = True
    Else AuthError(PnlCP, LblECP, False)
    End If
    If DateDiff(DateInterval.Day, InpFN.Value, Now.Date) < 5843 Then
      AuthError(PnlFN, LblEFN, True)
      Err = True
    Else AuthError(PnlFN, LblEFN, False)
    End If
    If InpCaptcha.Text <> Captcha Then
      AuthError(PnlCaptcha, LblECaptcha, True)
      Err = True
    Else AuthError(PnlCaptcha, LblECaptcha, False)
    End If

    If Not Err Then
      BtnRegistro.Enabled = False
      LblExito.Show()
      UserCuil = InpCuil.Text
    End If
  End Sub
  ' Hovers
  Private Sub InpCuil_Enter(sender As Object, e As EventArgs) Handles InpCuil.Enter
    AlternarHover(InpCuil, "CUIL", True)
  End Sub
  Private Sub InpCuil_Leave(sender As Object, e As EventArgs) Handles InpCuil.Leave
    AlternarHover(InpCuil, "CUIL", False)
  End Sub
  Private Sub InpContraseña_Enter(sender As Object, e As EventArgs) Handles InpContraseña.Enter
    AlternarHover(InpContraseña, "Contraseña", True)
  End Sub
  Private Sub InpContraseña_Leave(sender As Object, e As EventArgs) Handles InpContraseña.Leave
    AlternarHover(InpContraseña, "Contraseña", False)
  End Sub
  Private Sub InpDireccion_Enter(sender As Object, e As EventArgs) Handles InpDireccion.Enter
    AlternarHover(InpDireccion, "Calle y altura", True)
  End Sub
  Private Sub InpDireccion_Leave(sender As Object, e As EventArgs) Handles InpDireccion.Leave
    AlternarHover(InpDireccion, "Calle y altura", False)
  End Sub
  Private Sub InpLocalidad_Enter(sender As Object, e As EventArgs) Handles InpLocalidad.Enter
    AlternarHover(InpLocalidad, "Localidad", True)
  End Sub
  Private Sub InpLocalidad_Leave(sender As Object, e As EventArgs) Handles InpLocalidad.Leave
    AlternarHover(InpLocalidad, "Localidad", False)
  End Sub
  Private Sub InpEmail_Enter(sender As Object, e As EventArgs) Handles InpEmail.Enter
    AlternarHover(InpEmail, "Email", True)
  End Sub
  Private Sub InpEmail_Leave(sender As Object, e As EventArgs) Handles InpEmail.Leave
    AlternarHover(InpEmail, "Email", False)
  End Sub
  Private Sub InpNombre_Enter(sender As Object, e As EventArgs) Handles InpNombre.Enter
    AlternarHover(InpNombre, "Nombre", True)
  End Sub
  Private Sub InpNombre_Leave(sender As Object, e As EventArgs) Handles InpNombre.Leave
    AlternarHover(InpNombre, "Nombre", False)
  End Sub
  Private Sub InpApellido_Enter(sender As Object, e As EventArgs) Handles InpApellido.Enter
    AlternarHover(InpApellido, "Apellido", True)
  End Sub
  Private Sub InpApellido_Leave(sender As Object, e As EventArgs) Handles InpApellido.Leave
    AlternarHover(InpApellido, "Apellido", False)
  End Sub
  Private Sub InpCP_Enter(sender As Object, e As EventArgs) Handles InpCP.Enter
    AlternarHover(InpCP, "Código Postal", True)
  End Sub
  Private Sub InpCP_Leave(sender As Object, e As EventArgs) Handles InpCP.Leave
    AlternarHover(InpCP, "Código Postal", False)
  End Sub
End Class
