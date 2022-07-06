Public Class FrmMain
  Private Contador As Integer = 0
  ' Load
  Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddHandler PnlNav.MouseMove, AddressOf MoverVentana
    'Conectar()
    PnlView.Controls.Add(Viewing)
  End Sub
  ' Cambiar panel
  Private Sub BtnViewLogin_Click(sender As Object, e As EventArgs) Handles BtnViewLogin.Click
    CambiarVista("Login")
  End Sub
  Private Sub BtnViewMain_Click(sender As Object, e As EventArgs) Handles BtnViewMain.Click
    CambiarVista("Main")
  End Sub
  ' Estado de ventana
  '   Cerrar
  Private Sub BtnNCerrar_Click(sender As Object, e As EventArgs) Handles BtnNCerrar.Click
    Me.Close()
  End Sub
  '   Minimizar
  Private Sub BtnNMinim_Click(sender As Object, e As EventArgs) Handles BtnNMinim.Click
    Me.WindowState = FormWindowState.Minimized
  End Sub
  Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
    Dim conf As DialogResult = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo)
    If conf = vbYes Then
      UserInfo.Logout()
    End If
  End Sub
  Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
    FrmManual.Show()
  End Sub
  Private Sub pbxLogo_Click(sender As Object, e As EventArgs) Handles pbxLogo.Click
    'TomarFoto(Me)
    Contador += 1
    If Contador = 13 Then
      MsgBox("Leonel Acosta - Micaela Agüero - Facundo Espósito - Agustin Galán - Valentin Giarra - Tiago Gómez - Matías Lozano - Gabriel Moyano - Matias Obuljen - Joaquin Palacios - Nicolás Pascucci - Facundo Suarez - Leandro Villarroya", Title:="ConCor")
      Contador = 0
    End If
  End Sub

  Private Sub PnlNav_DoubleClick(sender As Object, e As EventArgs) Handles PnlNav.DoubleClick
    If Me.WindowState = FormWindowState.Maximized Then
      Me.WindowState = FormWindowState.Normal
    Else
      Me.WindowState = FormWindowState.Maximized
    End If
  End Sub
End Class