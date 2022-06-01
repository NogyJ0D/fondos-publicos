Public Class FrmMain
  ' Load
  Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PnlView.Controls.Add(Viewing)
  End Sub
  ' Cambiar panel
  Private Sub BtnViewLogin_Click(sender As Object, e As EventArgs) Handles BtnViewLogin.Click
    CambiarVista("Login")
  End Sub
  Private Sub BtnViewMain_Click(sender As Object, e As EventArgs) Handles BtnViewMain.Click
    CambiarVista("Main")
  End Sub
End Class