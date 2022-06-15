Imports System.Data.SqlClient
Public Class CtrMain
  Private Sub CtrMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddHandler Me.MouseMove, AddressOf MoverVentana ' Mover formulario

    ContarProyectos()
    LlenarProyectos()
  End Sub
  Private Sub BtnViewNuevosProy_Click(sender As Object, e As EventArgs) Handles BtnViewNuevosProy.Click
    CambiarVista("NuevosProy")
  End Sub
  Public Sub ContarProyectos()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = "SELECT COUNT(*) FROM proyectos WHERE id_estado = 1"
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
  Public Sub LlenarProyectos()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String =
          "SELECT id_proyecto, titulo, descripcion, fecha, monto
          FROM proyectos
          WHERE id_estado = 1
          ORDER BY fecha DESC"

        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim ProyAprob As New DataTable
        da.Fill(ProyAprob)
        DgvPAprob.DataSource = ProyAprob
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub
  Private Sub DgvPAprob_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPAprob.CellClick
    Try
      TxbPDesc.Text = DgvPAprob.Rows(e.RowIndex).Cells.Item(2).Value & " - " & DgvPAprob.Rows(e.RowIndex).Cells.Item(1).Value
      PnlPABorde.Show()
    Catch ex As System.ArgumentOutOfRangeException
    End Try
  End Sub
End Class
