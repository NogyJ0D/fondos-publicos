Public Class FrmMain
  ' Load
  Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PnlView.Controls.Add(Viewing)

    AddHandler PnlNav.MouseMove, AddressOf MoverVentana
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
  '   Mover ventana
End Class