Public Class FrmMain
  Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
    Dim newForm As New FrmLogin
    newForm.ShowDialog()
  End Sub
End Class