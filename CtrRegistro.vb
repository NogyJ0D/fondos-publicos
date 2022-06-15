Imports System.Data.SqlClient

Public Class CtrRegistro
  Private Sub CtrRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    PcbCaptcha.Image = MostrarCaptcha()

    AddHandler Me.MouseMove, AddressOf MoverVentana
    CargarCP()
  End Sub
  Private Sub BtnCaptcha_Click(sender As Object, e As EventArgs) Handles BtnCaptcha.Click
    BtnCaptcha.Size = New Size(46, 46)
    BtnCaptcha.Location = New Point(732, 300)
    Esperar(200)
    BtnCaptcha.Size = New Size(56, 56)
    BtnCaptcha.Location = New Point(728, 296)
    PcbCaptcha.Image = MostrarCaptcha()
  End Sub
  Private Sub BtnCaptcha_MouseEnter(sender As Object, e As EventArgs) Handles BtnCaptcha.MouseEnter
    BtnCaptcha.Image = My.Resources.Resources.recargar_hover
  End Sub
  Private Sub BtnCaptcha_MouseLeave(sender As Object, e As EventArgs) Handles BtnCaptcha.MouseLeave
    BtnCaptcha.Image = My.Resources.Resources.recargar
  End Sub

  Private Async Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
    Dim Err As Boolean = False

    If InpCuil.Text = "" Or InpCuil.Text = "CUIL" Then
      AuthError(PnlCuil, LblECuil, True)
      Err = True
    Else AuthError(PnlCuil, LblECuil, False)
    End If
    If InpContraseña.Text = "" Or InpContraseña.Text = "Contraseña" Then
      AuthError(PnlContraseña, LblEContraseña, True)
      Err = True
    Else AuthError(PnlContraseña, LblEContraseña, False)
    End If
    If InpCContraseña.Text = "" Or InpCContraseña.Text = "Repetir contraseña" Then
      AuthError(PnlCContraseña, LblECContraseña, True)
      Err = True
    Else AuthError(PnlCContraseña, LblECContraseña, False)
    End If
    If InpEmail.Text = "" Or InpEmail.Text = "Email" Then
      AuthError(PnlEmail, LblEEmail, True)
      Err = True
    Else AuthError(PnlEmail, LblEEmail, False)
    End If
    If InpNombre.Text = "" Or InpNombre.Text = "Nombre" Then
      AuthError(PnlNombre, LblENombre, True)
      Err = True
    Else AuthError(PnlNombre, LblENombre, False)
    End If
    If InpApellido.Text = "" Or InpApellido.Text = "Apellido" Then
      AuthError(PnlApellido, LblEApellido, True)
      Err = True
    Else AuthError(PnlApellido, LblEApellido, False)
    End If
    If InpDireccion.Text = "" Or InpDireccion.Text = "Calle y altura" Then
      AuthError(PnlDireccion, LblEDireccion, True)
      Err = True
    Else AuthError(PnlDireccion, LblEDireccion, False)
    End If
    If DateDiff(DateInterval.Day, InpFN.Value, Now.Date) < 5843 Then
      AuthError(PnlFN, LblEFN, True)
      Err = True
    Else AuthError(PnlFN, LblEFN, False)
    End If
    If InpCaptcha.Text <> Captcha Then
      AuthError(PnlCaptcha, LblECaptcha, True)
      Err = True
    Else AuthError(PnlCaptcha, LblECaptcha, False)
    End If
    If InpContraseña.Text <> InpCContraseña.Text Then
      PnlContraseña.BackColor = Color.Red
      PnlCContraseña.BackColor = Color.Red
      LblExito.ForeColor = Color.Red
      LblExito.Text = "Las contraseñas no coinciden"
      LblExito.Show()
      Err = True
    End If

    If Not Err Then
      If Not BuscarUsuario() Then
        If Registrar() Then
          BtnRegistro.Enabled = False
          LblExito.ForeColor = Color.White
          LblExito.Text = "Registro exitoso, valide su email para ingresar."
          Await EnviarEmail(InpEmail.Text)
          LblExito.Show()
        End If
      End If
    End If
  End Sub
  ' Hovers
  Private Sub InpCuil_Enter(sender As Object, e As EventArgs) Handles InpCuil.Enter
    AlternarHover(InpCuil, "CUIL", True)
  End Sub
  Private Sub InpCuil_Leave(sender As Object, e As EventArgs) Handles InpCuil.Leave
    AlternarHover(InpCuil, "CUIL", False)
  End Sub
  Private Sub InpContraseña_Enter(sender As Object, e As EventArgs) Handles InpContraseña.Enter
    If InpContraseña.Text = "Contraseña" Then
      InpContraseña.Text = ""
      InpContraseña.PasswordChar = "*"
    End If
  End Sub
  Private Sub InpContraseña_Leave(sender As Object, e As EventArgs) Handles InpContraseña.Leave
    If InpContraseña.Text = "" Then
      InpContraseña.Text = "Contraseña"
      InpContraseña.PasswordChar = ""
    End If
  End Sub
  Private Sub InpDireccion_Enter(sender As Object, e As EventArgs) Handles InpDireccion.Enter
    AlternarHover(InpDireccion, "Calle y altura", True)
  End Sub
  Private Sub InpDireccion_Leave(sender As Object, e As EventArgs) Handles InpDireccion.Leave
    AlternarHover(InpDireccion, "Calle y altura", False)
  End Sub
  Private Sub InpEmail_Enter(sender As Object, e As EventArgs) Handles InpEmail.Enter
    AlternarHover(InpEmail, "Email", True)
  End Sub
  Private Sub InpEmail_Leave(sender As Object, e As EventArgs) Handles InpEmail.Leave
    AlternarHover(InpEmail, "Email", False)
  End Sub
  Private Sub InpNombre_Enter(sender As Object, e As EventArgs) Handles InpNombre.Enter
    AlternarHover(InpNombre, "Nombre", True)
  End Sub
  Private Sub InpNombre_Leave(sender As Object, e As EventArgs) Handles InpNombre.Leave
    AlternarHover(InpNombre, "Nombre", False)
  End Sub
  Private Sub InpApellido_Enter(sender As Object, e As EventArgs) Handles InpApellido.Enter
    AlternarHover(InpApellido, "Apellido", True)
  End Sub
  Private Sub InpApellido_Leave(sender As Object, e As EventArgs) Handles InpApellido.Leave
    AlternarHover(InpApellido, "Apellido", False)
  End Sub
  Private Sub InpCContraseña_Enter(sender As Object, e As EventArgs) Handles InpCContraseña.Enter
    If InpCContraseña.Text = "Repetir contraseña" Then
      InpCContraseña.Text = ""
      InpCContraseña.PasswordChar = "*"
    End If
  End Sub
  Private Sub InpCContraseña_Leave(sender As Object, e As EventArgs) Handles InpCContraseña.Leave
    If InpCContraseña.Text = "" Then
      InpCContraseña.Text = "Repetir contraseña"
      InpCContraseña.PasswordChar = ""
    End If
  End Sub
  ' ---
  Private Function BuscarUsuario()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = $"SELECT * FROM usuarios WHERE cuit = '{InpCuil.Text}' OR correo_electronico = '{InpEmail.Text}'"

        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
          LblExito.ForeColor = Color.Red
          LblExito.Text = "Ya existe un usuario con ese CUIL o correo."
          LblExito.Show()
          conn.Close()
          Return True
        End If
        Return False
      Catch ex As Exception
        MsgBox(ex.Message)
        conn.Close()
        Return False
      End Try
    End Using
  End Function
  Private Function Registrar()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        Dim hashedPass = BCrypt.Net.BCrypt.HashPassword(InpContraseña.Text)
        conn.Open()
        Dim sql As String = $"INSERT INTO usuarios
            (nombre, apellido, cuit, contrasena, fecha_nacimiento, direccion, id_localidad, correo_electronico)
        VALUES
            ('{InpNombre.Text}', '{InpApellido.Text}', '{InpCuil.Text}', '{hashedPass}', '{CDate(InpFN.Value.ToShortDateString).ToString("yyyy/MM/dd")}', '{InpDireccion.Text}', {InpCP.SelectedValue.ToString}, '{InpEmail.Text}')"

        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        conn.Close()
        Return True
      Catch ex As Exception
        conn.Close()
        MsgBox(ex.ToString)
        Return False
      End Try
    End Using
  End Function
  Private Sub CargarCP()
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim sql As String = "SELECT id_localidad AS ID, codigo_postal AS CP FROM localidades"
        Dim cmd As SqlCommand = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim ds As New DataSet()
        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds)

        InpCP.DataSource = ds.Tables(0)
        InpCP.DisplayMember = "CP"
        InpCP.ValueMember = "ID"

        conn.Close()
      Catch ex As Exception
        conn.Close()
        MsgBox(ex.Message)
      End Try
    End Using
  End Sub
End Class
