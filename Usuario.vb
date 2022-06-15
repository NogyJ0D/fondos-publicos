Public Class Usuario
  ' Atributos
  Private Property Id As Integer
  Private Property CUIT As String
  Private Property Nombre As String
  Private Property Apellido As String
  Private Property FechaN As Date
  Private Property Direccion As String
  Private Property IdLocalidad As Integer
  Private Property Correo As String
  Private Property Rol As Integer
  ' Métodos
  Public Sub Login(Id, CUIT, Nombre, Apellido, FechaN, Direccion, IdLocalidad, Correo, Rol)
    Me.Id = Id
    Me.CUIT = CUIT
    Me.Nombre = Nombre
    Me.Apellido = Apellido
    Me.FechaN = FechaN
    Me.Direccion = Direccion
    Me.IdLocalidad = IdLocalidad
    Me.Correo = Correo
    Me.Rol = Rol

    UserLogged = True

    OpenedMain.BtnViewLogin.Hide()
    OpenedMain.BtnViewLogin.Enabled = False

    OpenedMain.BtnLogout.Show()
    OpenedMain.BtnLogout.Enabled = True

    If Me.Rol >= 2 Then
      ViewNuevosProy.BtnANP.Show()
      ViewNuevosProy.BtnANP.Enabled = True
    End If
  End Sub
  Public Sub Logout()
    Me.Id = Nothing
    Me.CUIT = Nothing
    Me.Nombre = Nothing
    Me.Apellido = Nothing
    Me.FechaN = Nothing
    Me.Direccion = Nothing
    Me.IdLocalidad = Nothing
    Me.Correo = Nothing
    Me.Rol = Nothing

    UserLogged = False

    OpenedMain.BtnViewLogin.Show()
    OpenedMain.BtnViewLogin.Enabled = True

    OpenedMain.BtnLogout.Hide()
    OpenedMain.BtnLogout.Enabled = False

    ViewNuevosProy.BtnANP.Hide()
    ViewNuevosProy.BtnANP.Enabled = False
  End Sub
  Public Function UserRol()
    Return Me.Rol
  End Function
  Public Function UserId()
    Return Me.Id
  End Function
End Class
