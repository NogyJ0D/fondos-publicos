Imports System.Data.SqlClient

Public Class CtrComentario
  Private IdComentario As Integer
  Private IdProyecto As Integer
  Private IdUsuario As Integer
  Private Comentario As String
  Private Creado As DateTime
  Private NombreApellido As String
  Private MeGustas As Integer
  Private NoMeGustas As Integer
  Private Numero As Integer
  Private DtRespuestas As New DataTable
  Private PnlRespuestas As FlowLayoutPanel = New FlowLayoutPanel With {
    .Size = New Size(758, 0),
    .Dock = DockStyle.Bottom
  }

  Public Sub CargarDatos(idC, idP, idU, com, cre, na, num)
    IdComentario = idC
    IdProyecto = idP
    IdUsuario = idU
    Comentario = com
    Creado = cre
    NombreApellido = na
    Numero = num
    CargarVotos()

    Me.Name = $"CtrComentario{IdComentario}"
    LblN.Text = $"N.° {Numero}"
    TxbComentario.Text = Comentario
    LblFecha.Text = Creado
    LblNombre.Text = NombreApellido
    PnlRespuestas.Name = $"PnlRta{IdComentario}"
    Controls.Add(PnlRespuestas)
    AddHandler PnlRespuestas.ControlAdded, AddressOf ViewForo.PnlComentarios_ControlAdded

    BuscarVoto()

    ' 123 caracteres por línea
    Dim AltoCaja = Math.Ceiling(TxbComentario.Text.Length / 123) + 0.8
    TxbComentario.Height = Font.Height * AltoCaja
    PnlComentario.Height = 58 + TxbComentario.Height
    Height = PnlComentario.Height
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
        Dim sql As String = $"INSERT INTO votos_comentarios (id_comentario, id_usuario, tipo_voto, tipo_comentario) VALUES ({IdComentario}, {UserInfo.UserId()}, {TipoVoto}, 0)"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
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
        Dim sql As String = $"SELECT COUNT(*) FROM votos_comentarios WHERE id_comentario = {IdComentario} AND id_usuario = {UserInfo.UserId()} AND tipo_comentario = 0"
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
  Private Sub CargarVotos()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"SELECT
	          SUM(CASE WHEN tipo_voto = 0 THEN 1 ELSE 0 END) AS MeGusta,
	          SUM(CASE WHEN tipo_voto = 1 THEN 1 ELSE 0 END) AS NoMeGusta
          FROM votos_comentarios
          WHERE id_comentario = {IdComentario} AND tipo_comentario = 0"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.HasRows() Then
          While dr.Read()
            If Not dr.IsDBNull(0) AndAlso Not dr.IsDBNull(1) Then
              MeGustas = dr.Item(0)
              BtnFav.Text = $"Me gusta: {MeGustas}"
              NoMeGustas = dr.Item(1) Or 0
              BtnCon.Text = $"No me gusta: {NoMeGustas}"
            Else
              MeGustas = 0
              BtnFav.Text = "Me gusta: 0"
              NoMeGustas = 0
              BtnCon.Text = "No me gusta: 0"
            End If
          End While
        Else
          MeGustas = 0
          BtnFav.Text = "Me gusta: 0"
          NoMeGustas = 0
          BtnCon.Text = "No me gusta: 0"
        End If
      Catch ex As Exception
        MsgBox(ex.ToString)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  ' -- Respuestas --
  Private Sub CtrComentario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    BuscarRespuestas()
    MostrarRespuestas()
  End Sub
  Private Sub BuscarRespuestas()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String =
          $"SELECT c.*, CONCAT(u.nombre, ' ', u.apellido) AS usuario_nombre
          FROM comentarios_respuestas AS c
          INNER JOIN usuarios AS u ON c.id_usuario = u.id_usuario
          WHERE id_comentario = {IdComentario}"

        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(DtRespuestas)
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub MostrarRespuestas()
    If DtRespuestas.Rows.Count > 0 Then
      Me.Height = PnlComentario.Height
      Dim Alto As Integer = 0
      For Each respuesta As DataRow In DtRespuestas.Rows
        Dim newResponse As New CtrRespuesta
        newResponse.CargarDatos(respuesta.Item(0), respuesta.Item(1), respuesta.Item(2), respuesta.Item(3), respuesta.Item(4), respuesta.Item(5))
        PnlRespuestas.Controls.Add(newResponse)
        Alto += newResponse.Height
      Next
      PnlRespuestas.Height = Alto
      Me.Height += PnlRespuestas.Height
    Else
      Try
      Catch ex As Exception
      End Try
      'MsgBox("No hay comentarios")
    End If
  End Sub

  Private Sub BtnResponder_Click(sender As Object, e As EventArgs) Handles BtnResponder.Click
    BtnResponder.Enabled = False
    Dim PnlRta As New CtrResponder
    PnlRta.CargarId(IdComentario)
    PnlRespuestas.Controls.Add(PnlRta)
    PnlRespuestas.Height += PnlRta.Height
    Me.Height = PnlComentario.Height + PnlRespuestas.Height
  End Sub
End Class
