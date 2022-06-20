Imports System.Data.SqlClient

Public Class CtrRespuesta
  Private IdComentario As Integer
  Private IdProyecto As Integer
  Private IdUsuario As Integer
  Private Comentario As String
  Private Creado As DateTime
  Private NombreApellido As String
  Private MeGustas As Integer
  Private NoMeGustas As Integer
  Public Sub CargarDatos(idC, idP, idU, com, cre, na)
    IdComentario = idC
    IdProyecto = idP
    IdUsuario = idU
    Comentario = com
    Creado = cre
    NombreApellido = na
    CargarVotos()

    TxbComentario.Text = Comentario
    LblFecha.Text = Creado
    LblNombre.Text = NombreApellido

    BuscarVoto()

    ' 123 caracteres por línea
    Dim AltoCaja = Math.Ceiling(TxbComentario.Text.Length / 113) + 0.8
    TxbComentario.Height = Font.Height * AltoCaja
    Height = 58 + TxbComentario.Height
  End Sub
  Private Sub BtnFav_Click(sender As Object, e As EventArgs) Handles BtnFav.Click
    If UserLogged Then
      Votar(0)
      CargarVotos()
      BuscarVoto()
    Else
      MsgBox("Inicia sesión para votar")
    End If
  End Sub
  Private Sub BtnCon_Click(sender As Object, e As EventArgs) Handles BtnCon.Click
    If UserLogged Then
      Votar(1)
      CargarVotos()
      BuscarVoto()
    Else
      MsgBox("Inicia sesión para votar")
    End If
  End Sub
  Private Sub Votar(TipoVoto As Integer)
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"INSERT INTO votos_comentarios (id_comentario, id_usuario, tipo_voto, tipo_comentario) VALUES ({IdComentario}, {UserInfo.UserId()}, {TipoVoto}, 1)"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
      Catch ex As Exception
        MsgBox(ex.ToString)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub CargarVotos()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"SELECT
	          SUM(CASE WHEN tipo_voto = 0 THEN 1 ELSE 0 END) AS MeGusta,
	          SUM(CASE WHEN tipo_voto = 1 THEN 1 ELSE 0 END) AS NoMeGusta
          FROM votos_comentarios
          WHERE id_comentario = {IdComentario} AND tipo_comentario = 1"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.HasRows() Then
          While dr.Read()
            If Not dr.IsDBNull(0) AndAlso Not dr.IsDBNull(1) Then
              MeGustas = dr.Item(0)
              BtnFav.Text = $"A favor: {MeGustas}"
              NoMeGustas = dr.Item(1) Or 0
              BtnCon.Text = $"En contra: {NoMeGustas}"
            Else
              MeGustas = 0
              BtnFav.Text = "A favor: 0"
              NoMeGustas = 0
              BtnCon.Text = "En contra: 0"
            End If
          End While
        Else
          MeGustas = 0
          BtnFav.Text = "A favor: 0"
          NoMeGustas = 0
          BtnCon.Text = "En contra: 0"
        End If
      Catch ex As Exception
        MsgBox(ex.ToString)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub BuscarVoto()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"SELECT COUNT(*) FROM votos_comentarios WHERE id_comentario = {IdComentario} AND id_usuario = {UserInfo.UserId()} AND tipo_comentario = 1"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
          If dr.Item(0) > 0 Then
            BtnFav.Enabled = False
            BtnCon.Enabled = False
          Else
            BtnFav.Enabled = True
            BtnCon.Enabled = True
          End If
        End While
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
End Class
