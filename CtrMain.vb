Public Class CtrMain
    ' Load
    Private Sub CtrMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.MouseMove, AddressOf MoverVentana ' Mover formulario
        Panel9.Hide()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel9.Show()
        TextProyectos.Visible = True
        TextProyectos.Text = "Vamos a pavimentar las arterias más concurridas de la ciudad para beneficiar al... Etc. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        With TextProyectos
            Dim OldSelStart As Integer = TextProyectos.SelectionStart
            Dim OldSelLen As Integer = TextProyectos.SelectionLength
            TextProyectos.SelectionStart = 0
            TextProyectos.SelectionLength = Len(TextProyectos.Text)
            TextProyectos.SelectionIndent = 20
            TextProyectos.SelectionStart = OldSelStart
            TextProyectos.SelectionLength = OldSelLen
        End With
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    TextProyectos.Clear()
  End Sub

  Private Sub BtnViewNuevosProy_Click(sender As Object, e As EventArgs) Handles BtnViewNuevosProy.Click
    CambiarVista("NuevosProy")
  End Sub
End Class
