Imports System.Data.SqlClient

Public Class CtrForo

  Dim DtComentarios As New DataTable

  Private Sub CtrForo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    AddHandler Me.MouseMove, AddressOf MoverVentana

    If UserLogged Then

      LblIS.Hide()
      PnlNComentario.Show()
      PnlNComentario.Enabled = True

    End If

    CargarProy()
    CargarComentarios()

  End Sub
  Private Sub CargarProy()

    Using conn = New SqlClient.SqlConnection(sqlConn)

      Try

        conn.Open()
        Dim sql As String = $"SELECT titulo FROM proyectos WHERE id_proyecto = {Me.Tag}"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        While dr.Read()

          LblPNombre.Text = dr.Item(0)

        End While

      Catch ex As Exception

        MsgBox(ex.ToString)

      Finally

        conn.Close()

      End Try

    End Using

  End Sub
  Public Sub CargarComentarios()

    Using conn = New SqlConnection(sqlConn)

      Try

        PnlCargando.Show()
        conn.Open()

        Dim sql As String =
          $"SELECT c.id_comentario, c.comentario, CONCAT(u.nombre, ' ', u.apellido) AS usuario_nombre
          FROM comentarios AS c
          INNER JOIN usuarios AS u ON c.id_usuario = u.id_usuario
          WHERE id_proyecto = {Me.Tag}"

        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        DtComentarios.Clear()
        da.Fill(DtComentarios)
        MostrarComentarios()

      Catch ex As Exception

        MsgBox(ex.Message)

      End Try

    End Using

  End Sub
  Private Sub MostrarComentarios()

    If DtComentarios.Rows.Count > 0 Then

      PnlComentarios.Controls.Clear()
      Dim cont As Integer = 1

      For Each comentario As DataRow In DtComentarios.Rows

        Dim newComment As New CtrComentario
        newComment.CargarDatos(comentario.Item(0), comentario.Item(1), comentario.Item(2), cont)
        PnlComentarios.Controls.Add(newComment)

        If Not UserLogged Then

          newComment.BtnResponder.Hide()
          newComment.BtnResponder.Enabled = False

        End If

        cont += 1

      Next

      'Esperar(500) ' Simular espera de gran carga
      LblNumCom.Text = $"Comentarios: {PnlComentarios.Controls.Count}"

    Else

      'MsgBox("No hay comentarios")

    End If

    PnlCargando.Hide()

  End Sub

  Private Sub BtnNComentario_Click(sender As Object, e As EventArgs) Handles BtnNComentario.Click

    If InpComentario.Text <> "" And InpComentario.Text <> " " Then

      Using conn = New SqlClient.SqlConnection(sqlConn)

        Try

          conn.Open()

          Dim sql As String = $"INSERT INTO comentarios (id_proyecto, id_usuario, comentario) VALUES ({Me.Tag}, {UserInfo.UserId()}, '{InpComentario.Text}')"

          Dim cmd As SqlCommand = New SqlCommand(sql, conn)
          cmd.ExecuteNonQuery()
          CargarComentarios()

        Catch ex As Exception

          MsgBox(ex.ToString)

        End Try

      End Using

    End If

  End Sub

  Public Sub PnlComentarios_ControlAdded(sender As Object, e As ControlEventArgs) Handles PnlComentarios.ControlAdded

    PnlComentarios.ScrollControlIntoView(e.Control)

  End Sub

End Class
