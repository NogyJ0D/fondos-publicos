Module Variables
  ' FrmMain abierto
  Public OpenedMain As FrmMain = My.Application.OpenForms().Item("FrmMain")
  ' Vistas del panel
  Public ViewMain As New CtrMain
  Public ViewLogin As New CtrLogin
  Public ViewRegistro As New CtrRegistro
  Public ViewNuevosProy As New CtrNuevosProy
  Public ViewCargarProy As New CtrCargarProy
  Public ViewForo As CtrForo
  Public Viewing As UserControl = ViewMain
  ' Captcha
  Public Captcha As String

  ' Modelo de usuario
  Public UserInfo As New Usuario
  Public UserLogged As Boolean = False

  ' Cadenas sql locales
  Private sqlValentin = "Data Source=DESKTOP-7N22TGM\SQLEXPRESS;Initial Catalog=PPI;Integrated Security=false; user id=sa;password=<>"
  Private sqlValentinIzo = "Data Source=LAB-L04\SQLEXPRESS;Initial Catalog=PPI;Integrated Security=false; user id=sa;password=<>"
  ' Cambiar la cadena según quien está usando localmente
  Public sqlConn = sqlValentin
End Module
