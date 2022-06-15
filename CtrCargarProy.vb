Imports System.Data.SqlClient

Public Class CtrCargarProy
  Private Sub CtrCargarProy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddHandler Me.MouseMove, AddressOf MoverVentana

    CargarEstados()
  End Sub
  Private Sub CargarEstados()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = "SELECT id_estado AS ID, nombre AS Nombre FROM estados"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim ds As New DataSet()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)

        InpEstado.DataSource = ds.Tables(0)
        InpEstado.DisplayMember = "Nombre"
        InpEstado.ValueMember = "ID"
      Catch ex As Exception
        MsgBox(ex.Message)
      Finally
        conn.Close()
      End Try
    End Using
  End Sub

  Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"INSERT INTO proyectos (titulo, descripcion, fecha, monto, id_estado) VALUES ('{InpTitulo.Text}', '{InpDesc.Text}', '{CDate(InpFecha.Value.ToShortDateString).ToString("yyyy/MM/dd")}', {Replace(InpMonto.Value, ",", ".")}, {InpEstado.SelectedValue.ToString})"

        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        MsgBox("Carga exitosa.")

        InpTitulo.Text = ""
        InpDesc.Text = ""
        InpFecha.Value = Today
        InpMonto.Value = 0.00
        InpEstado.SelectedIndex = 0

        ViewMain.ContarProyectos()
        ViewMain.LlenarProyectos()

        ViewNuevosProy.ContarProyectos()
        ViewNuevosProy.LlenarProyectos()

        conn.Close()
      Catch ex As Exception
        conn.Close()
        MsgBox(ex.ToString)
      End Try
    End Using
  End Sub
End Class
