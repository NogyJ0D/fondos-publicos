Public Class FrmManual
  Private Sub FrmManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim Archivo As String = My.Application.Info.DirectoryPath + "\Recursos\pdf-prueba.pdf"
    'MsgBox(Archivo)
    ViewManual.LoadFile(Archivo)
  End Sub
End Class