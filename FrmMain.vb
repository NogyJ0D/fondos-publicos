Public Class FrmMain
  ' Load
  Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PnlView.Controls.Add(ViewMain)
  End Sub
    ' Cambiar panel
    Private Sub AlternarVista(sender As Object, e As EventArgs) Handles BtnViewLogin.Click, BtnViewMain.Click
        Dim Boton As PictureBox = sender
        Select Case Boton.Name
            Case "BtnViewLogin"
                PnlView.Controls.Clear()
                PnlView.Controls.Add(ViewLogin)
                ViewLogin.InpLUsuario.Focus()
            Case "BtnViewMain"
                PnlView.Controls.Clear()
                PnlView.Controls.Add(ViewMain)
        End Select
    End Sub
End Class