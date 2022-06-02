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
        'BtnCaptcha.Image = My.Resources.Resources.recargar_chico
        Esperar(200)
        BtnCaptcha.Size = New Size(56, 56)
        BtnCaptcha.Location = New Point(544, 248)
        'BtnCaptcha.Image = My.Resources.Resources.recargar
        PcbCaptcha.Image = MostrarCaptcha()
    End Sub
    Private Sub BtnCaptcha_MouseEnter(sender As Object, e As EventArgs) Handles BtnCaptcha.MouseEnter
        BtnCaptcha.Image = My.Resources.Resources.recargar_hover
    End Sub
    Private Sub BtnCaptcha_MouseLeave(sender As Object, e As EventArgs) Handles BtnCaptcha.MouseLeave
        BtnCaptcha.Image = My.Resources.Resources.recargar
    End Sub
    ' Iniciar
    Private Function BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim Err As Boolean = False

        ' User mockup
        Dim User As String = "123"
        Dim Pass As String = "123"

        ' Falta
        If InpUsuario.Text = "" Or InpUsuario.Text = "Usuario" Then
            PnlUsuario.BackColor = Color.Red
            Err = True
            LblEUsuario.Text = "Ingrese un usuario"
            LblEUsuario.Show()
        Else
            PnlUsuario.BackColor = Color.White
            LblEUsuario.Hide()
        End If
        If InpContraseña.Text = "" Or InpContraseña.Text = "Contraseña" Then
            PnlContraseña.BackColor = Color.Red
            Err = True
            LblEContraseña.Text = "Ingrese una contraseña"
            LblEContraseña.Show()
        Else
            PnlContraseña.BackColor = Color.White
            LblEContraseña.Hide()
        End If
        If InpCaptcha.Text <> Captcha Then
            PnlCaptcha.BackColor = Color.Red
            Err = True
            LblECaptcha.Text = "El captcha no coincide"
            LblECaptcha.Show()
        Else
            PnlCaptcha.BackColor = Color.White
            LblECaptcha.Hide()
        End If

        ' No iguala
        If InpUsuario.Text <> User Or InpContraseña.Text <> Pass Then
            PnlUsuario.BackColor = Color.Red
            PnlContraseña.BackColor = Color.Red
            Err = True
            LblECredenciales.Show()
        Else LblECredenciales.Hide()
        End If

        ' Fin
        If Err Then Return MessageBox.Show("Mal")
        UserLogged = 1
        UserNUsuario = "123"

        CambiarVista("Main")
        Return MessageBox.Show("Bien")
    End Function
    ' Texto placeholder en los input
    Private Sub InpLUsuario_Enter(sender As Object, e As EventArgs) Handles InpUsuario.Enter
        If InpUsuario.Text = "Usuario" Then
            InpUsuario.Text = ""
        End If
    End Sub
    Private Sub InpLUsuario_Leave(sender As Object, e As EventArgs) Handles InpUsuario.Leave
        If InpUsuario.Text = "" Then
            InpUsuario.Text = "Usuario"
        End If
    End Sub
    Private Sub InpLContraseña_Enter(sender As Object, e As EventArgs) Handles InpContraseña.Enter
        If InpContraseña.Text = "Contraseña" Then
            InpContraseña.Text = ""
            InpContraseña.PasswordChar = "*"
        End If
    End Sub
    Private Sub InpLContraseña_Leave(sender As Object, e As EventArgs) Handles InpContraseña.Leave
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
End Class
