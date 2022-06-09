Imports System.Data.SqlClient

Public Class CtrNuevosProy
  Public ProyVotacion As New DataTable
  Public ProyViendo
  Private Sub CtrNuevosProy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ContarProyectos()
    LlenarProyectos()
  End Sub
  Private Sub ContarProyectos()
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
  Private Sub LlenarProyectos()
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
    'ProyViendo = DgvP.Rows(e.RowIndex)
    'TxbPDesc.Text = ProyViendo.Cells.Item(2).Value
    TxbPDesc.Text = DgvP.Rows(e.RowIndex).Cells.Item(2).Value
  End Sub
End Class
