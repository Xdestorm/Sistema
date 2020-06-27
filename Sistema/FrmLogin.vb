Public Class FrmLogin
    Dim acceso As Integer
    Dim tipo As Integer
    Dim accion As Integer
    Dim msg As String
    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    '--1 = insertar
    '--2 = actualizar
    '--3 = eliminar
    '--4 = consultar
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarSQL()
        CbTipos(cbx_Tipo)
        DesconectarSQL()
    End Sub

    Private Sub cbx_Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Tipo.SelectedIndexChanged

    End Sub

    Private Sub UsernameTextBox_LostFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus

    End Sub

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Dim has As New OC.Core.Crypto.Hash
        Dim pws As String = PasswordTextBox.Text

        If OK.Text = "Consultar" Then

            accion = 4
            ConectarSQL()
            spLogin(UsernameTextBox, pws, acceso, tipo, accion, msg)
            DesconectarSQL()
            ConectarSQL()
            NomIdTipo(tipo, cbx_Tipo.Text)
            DesconectarSQL()
            If msg = "Exito" Then
                OK.Text = "Actualizar"
            Else
                OK.Text = "Agregar"
            End If
        ElseIf ok.Text = "Agregar" Then

            accion = 1
            ConectarSQL()
            NomIdTipo(tipo, cbx_Tipo.Text)
            DesconectarSQL()
            ConectarSQL()
            spLogin(UsernameTextBox, pws, acceso, tipo, accion, msg)
            DesconectarSQL()
            ConectarSQL()


        ElseIf ok.Text = "Actualizar" Then
            tipo = 0 'evitamos conflictos de validacion en la cosulta
            accion = 2
            ConectarSQL()
            NomIdTipo(tipo, cbx_Tipo.Text)
            DesconectarSQL()
            ConectarSQL()
            spLogin(UsernameTextBox, pws, acceso, tipo, accion, msg)
            DesconectarSQL()
            ConectarSQL()
        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
