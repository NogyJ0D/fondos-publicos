Public Class CtrRespuesta
  Private Respuesta As String
  Private NombreApellido As String
  Public Sub CargarDatos(ra, na)
    Respuesta = ra
    NombreApellido = na

    TxbComentario.Text = Respuesta
    LblNombre.Text = NombreApellido

    ' 123 caracteres por línea
    Dim AltoCaja = Math.Ceiling(TxbComentario.Text.Length / 113) + 0.8
    TxbComentario.Height = Font.Height * AltoCaja
    Height = 58 + TxbComentario.Height
  End Sub
End Class
