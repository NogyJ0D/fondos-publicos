Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Net.Mail

Module Funciones

  Public Sub CambiarVista(origen As String)

    Select Case origen

      Case "Main"
        Viewing = ViewMain

      Case "Login"
        Viewing = ViewLogin

      Case "Registro"
        If Not UserLogged Then
          Viewing = ViewRegistro
        Else
          MsgBox("No puedes registrarte teniendo ya una cuenta abierta.", MsgBoxStyle.Critical, "Error")
        End If

      Case "NuevosProy"
        Viewing = ViewNuevosProy

      Case "ViewCargarProy"
        If UserInfo.UserRol >= 2 Then
          Viewing = ViewCargarProy
        Else
          MsgBox("No posees el rol válido para esto.", MsgBoxStyle.Critical, "Permisos insuficientes")
        End If

      Case "Foro"
        Viewing = ViewForo

    End Select

    OpenedMain.PnlView.Controls.Clear()
    OpenedMain.PnlView.Controls.Add(Viewing)

  End Sub

  Public Function GenerarCaptcha(len As Integer, mayus As Boolean) As String
    ' len = cantidad de caracteres - mayus = si quiere caracteres en mayuscula

    Dim rand As New Random()
    Dim permitidos() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
    Dim final As String = String.Empty

    For i As Integer = 0 To len - 1
      final += permitidos(rand.Next(permitidos.Length - 1))
    Next

    Return IIf(mayus, final.ToUpper(), final)

  End Function

  Public Function MostrarCaptcha()

    Dim pfc As New PrivateFontCollection()
    pfc.AddFontFile("./Recursos/Mom_font.ttf")
    Captcha = GenerarCaptcha(6, False)

    Dim newImage As New Bitmap(288, 40)
    Dim gr As Graphics = Graphics.FromImage(newImage)
    Dim rec As New RectangleF(0, 0, newImage.Width, newImage.Height)

    Dim strF As New StringFormat With {
      .Alignment = StringAlignment.Center,
      .LineAlignment = StringAlignment.Center
    }

    With gr
      .Clear(Color.White)
      .DrawImageUnscaled(newImage, 0, 0)
      .DrawString(Captcha, New Font(pfc.Families(0), 22), Brushes.Black, rec, strF)
    End With

    Return newImage

  End Function

  ' Esperar y congelar
  'Declare Sub Esperar Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)
  ' Esperar sin congelar

  Public Sub Esperar(ByVal interval As Integer)

    Dim stopW As New Stopwatch
    stopW.Start()

    Do While stopW.ElapsedMilliseconds < interval
      Application.DoEvents()
    Loop

    stopW.Stop()

  End Sub

  ' Mover Ventana
  Dim Pos As Point
  Public Sub MoverVentana(sender As Object, e As System.Windows.Forms.MouseEventArgs)

    If e.Button = Windows.Forms.MouseButtons.Left Then
      OpenedMain.Location += Control.MousePosition - Pos
    End If

    Pos = Control.MousePosition

  End Sub

  Public Sub AuthError(pnl As Panel, lbl As Label, cond As Boolean)

    If cond Then
      pnl.BackColor = Color.Red
      lbl.Show()
    Else
      pnl.BackColor = Color.White
      lbl.Hide()
    End If

  End Sub

  Public Sub AlternarHover(inp As TextBox, texto As String, cond As Boolean)

    If cond Then
      If inp.Text = texto Then
        inp.Text = ""
      End If
    Else
      If inp.Text = "" Then
        inp.Text = texto
      End If
    End If

  End Sub

  Public Function EnviarEmail(ClienteCorreo As String) As Boolean
    ' Server
    Dim Server As New SmtpClient("smtp-mail.outlook.com", 587)
    With Server
      .Credentials = New Net.NetworkCredential(SCred.Item1, SCred.Item2)
      .EnableSsl = True
    End With

    ' Email
    Dim Email As New MailMessage()
    With Email
      .From = New MailAddress(SCred.Item1)
      .To.Add(ClienteCorreo)
      .Subject = $"ConCor - Registro exitoso"
      .IsBodyHtml = True
      .Body =
            "<h1>Gracias por registrarte en ConCor.</h1>"
      .Priority = MailPriority.Normal
    End With

    ' Envío
    Try
      Server.Send(Email)
      Server.Dispose()
      MsgBox("Mensaje enviado", MsgBoxStyle.OkOnly, "Éxito")
      Return True
    Catch ex As Exception
      MsgBox("Error, enseñe a un técnico el siguiente mensaje.", MsgBoxStyle.Critical, "Error")
      MsgBox(ex.ToString)
      Server.Dispose()
      Return False
    End Try
  End Function

  Public Sub LlenarCmb(ByVal sql As String, ByVal Cmb As ComboBox) ' Orden: ID - Texto
    Using conn = New SqlClient.SqlConnection(sqlConn)
      Try
        conn.Open()
        Dim cmd As New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()

        Dim ds As New DataSet()
        Dim da As New SqlDataAdapter With {.SelectCommand = cmd}
        da.Fill(ds)

        Cmb.DataSource = ds.Tables(0)
        Cmb.ValueMember = ds.Tables(0).Columns(0).ColumnName
        Cmb.DisplayMember = ds.Tables(0).Columns(1).ColumnName

      Catch ex As Exception
        MsgBox(ex.Message)
      End Try
    End Using
  End Sub

End Module