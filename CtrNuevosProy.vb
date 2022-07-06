Imports System.Data.SqlClient

Public Class CtrNuevosProy
  Private Sub CtrNuevosProy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddHandler Me.MouseMove, AddressOf MoverVentana

    ContarProyectos()
    LlenarProyectos()
  End Sub
  Public Sub ContarProyectos()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = "SELECT COUNT(*) FROM proyectos WHERE id_estado = 2"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
          LblPTop.Text = "Proyectos: " & dr.Item(0)
        End While
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub BtnViewForo_Click(sender As Object, e As EventArgs) Handles BtnViewForo.Click
    ViewForo = New CtrForo
    ViewForo.Tag = LblProyId.Text
    CambiarVista("Foro")
  End Sub
  Public Sub LlenarProyectos()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String =
          "SELECT id_proyecto, titulo, descripcion, fecha, monto
          FROM proyectos
          WHERE id_estado = 2
          ORDER BY fecha DESC"

        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim ProyVotacion As New DataTable
        da.Fill(ProyVotacion)
        DgvP.DataSource = ProyVotacion
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub DgvP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvP.CellClick
    Try
      Panel4.Show()
      PnlProyecto.Show()
      LblProyId.Text = DgvP.Rows(e.RowIndex).Cells.Item(0).Value
      TxbPDesc.Text = DgvP.Rows(e.RowIndex).Cells.Item(2).Value
      ContarVotos(0)
      ContarVotos(1)
      BuscarVoto()
      If UserLogged Then
        BtnVotarC.Show()
        BtnVotarF.Show()
      Else
        BtnVotarC.Hide()
        BtnVotarF.Hide()
      End If
    Catch ex As Exception
    End Try
  End Sub
  Private Sub ContarVotos(tipoVoto As Integer)
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"SELECT COUNT(*) FROM votos_proyectos WHERE id_proyecto = {LblProyId.Text} AND tipo_voto = {tipoVoto}"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read()
          If tipoVoto = 0 Then
            LblVotosF.Text = $"Votos a favor: {dr.Item(0)}"
          Else
            LblVotosC.Text = $"Votos en contra: {dr.Item(0)}"
          End If
        End While
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub BuscarVoto()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        ' TODO: Cambiar * por COUNT
        Dim sql As String = $"SELECT * FROM votos_proyectos WHERE id_proyecto = {LblProyId.Text} AND id_usuario = {UserInfo.UserId()}"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
          BtnVotarC.Enabled = False
          BtnVotarF.Enabled = False
        Else
          BtnVotarC.Enabled = True
          BtnVotarF.Enabled = True
        End If
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub BtnVotarF_Click(sender As Object, e As EventArgs) Handles BtnVotarF.Click
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"INSERT INTO votos_proyectos (id_proyecto, id_usuario, tipo_voto) VALUES ({LblProyId.Text}, {UserInfo.UserId()}, 0)"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        ContarVotos(0)
        BuscarVoto()
      Catch ex As Exception
        MsgBox(ex.ToString)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub BtnVotarC_Click(sender As Object, e As EventArgs) Handles BtnVotarC.Click
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"INSERT INTO votos_proyectos (id_proyecto, id_usuario, tipo_voto) VALUES ({LblProyId.Text}, {UserInfo.UserId()}, 1)"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        ContarVotos(1)
        BuscarVoto()
      Catch ex As Exception
        MsgBox(ex.ToString)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub

  Private Sub BtnANP_Click(sender As Object, e As EventArgs) Handles BtnANP.Click
    If UserInfo.UserRol >= 2 Then
      CambiarVista("ViewCargarProy")
    End If
  End Sub
End Class
