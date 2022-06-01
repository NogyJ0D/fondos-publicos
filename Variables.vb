Module Variables
  ' FrmMain abierto
  Public OpenedMain As FrmMain = My.Application.OpenForms().Item("FrmMain")
  ' Vistas del panel
  Public ViewMain As New CtrMain
  Public ViewLogin As New CtrLogin
  Public Viewing = ViewMain
  ' Captcha
  Public Captcha As String

  ' Modelo temporal de usuario
  Public UserNUsuario As String
  Public UserContraseña As String
  Public UserLogged As Boolean = False
End Module
