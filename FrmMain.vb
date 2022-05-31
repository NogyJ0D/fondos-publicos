Public Class FrmMain
  Private Sub BtnLogin_Click(sender As Object, e As EventArgs) 
    Dim newForm As New FrmLogin
    newForm.ShowDialog()
  End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmLogin.Show()

    End Sub
End Class