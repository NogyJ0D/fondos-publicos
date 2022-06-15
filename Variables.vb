Module Variables
  ' FrmMain abierto
  Public OpenedMain As FrmMain = My.Application.OpenForms().Item("FrmMain")
  ' Vistas del panel
  Public ViewMain As New CtrMain
  Public ViewLogin As New CtrLogin
  Public ViewRegistro As New CtrRegistro
  Public ViewNuevosProy As New CtrNuevosProy
  Public Viewing As UserControl = ViewMain
  ' Captcha
  Public Captcha As String

  ' Modelo de usuario
  Public UserInfo As New DataTable
  Public UserLogged As Boolean = False

  ' Proyectos




  ' Cadenas sql locales
  Private sqlValentin = "Data Source=DESKTOP-7N22TGM\SQLEXPRESS;Initial Catalog=PPI;Integrated Security=false; user id=sa;password=manual322"

  ' Cambiar la cadena según quien está usando localmente
  Public sqlConn = sqlValentin
End Module
