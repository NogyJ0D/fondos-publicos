﻿Module Variables
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

  ' Modelo temporal de usuario
  Public UserCuil As String = "123"
  Public UserLogged As Boolean = False
End Module
