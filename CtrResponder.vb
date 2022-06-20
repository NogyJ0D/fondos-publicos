Imports System.Data.SqlClient

Public Class CtrResponder
  Private IdUsuario As Integer = UserInfo.UserId()
  Private IdComentario As Integer
  Public Sub CargarId(idc)
    IdComentario = idc
  End Sub
  Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"INSERT INTO comentarios_respuestas (id_usuario, id_comentario, respuesta) VALUES ({IdUsuario}, {IdComentario}, '{InpRespuesta.Text}')"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
      Catch ex As Exception
        MsgBox(ex.ToString)
      Finally
        conn.Close()
      End Try
    End Using

    ViewForo.CargarComentarios()
    BtnCerrar_Click(sender, e)
  End Sub
  Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
    Parent.Height -= Me.Height
    Parent.Parent.Height = Parent.Parent.Controls("PnlComentario").Height + Parent.Height
    Parent.Parent.Controls("PnlComentario").Controls.Item("BtnResponder").Enabled = True
    Parent.Controls.Remove(Me)
  End Sub
End Class
