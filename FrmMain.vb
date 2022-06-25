Public Class FrmMain
  ' Load
  Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddHandler PnlNav.MouseMove, AddressOf MoverVentana
    'Conectar()
    PnlView.Controls.Add(Viewing)
    CmbTema.SelectedItem = CmbTema.Items(0)
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
  ' Elegir tema
  Private Sub CmbTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTema.SelectedIndexChanged
    CambiarTema(CmbTema.SelectedItem)
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
End Class