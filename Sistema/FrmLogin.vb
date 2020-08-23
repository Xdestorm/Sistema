Public Class FrmLogin
    Dim acceso As Integer
    Dim tipo As Integer
    Dim accion As Integer
    Dim msg As String
    Dim has As New OC.Core.Crypto.Hash
    Dim pws As String = ""

    '--1 = insertar
    '--2 = actualizar
    '--3 = eliminar
    '--4 = consultar
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarSQL()
        CbTipos(cbx_Tipo)
        DesconectarSQL()
    End Sub


    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click

        pws = PasswordTextBox.Text

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
                Eliminar.Enabled = True
            Else
                OK.Text = "Agregar"
            End If
        ElseIf OK.Text = "Agregar" Then

            accion = 1
            ConectarSQL()
            NomIdTipo(tipo, cbx_Tipo.Text)
            DesconectarSQL()
            ConectarSQL()
            spLogin(UsernameTextBox, pws, acceso, tipo, accion, msg)
            DesconectarSQL()
            ConectarSQL()


        ElseIf OK.Text = "Actualizar" Then
            tipo = 0 'evitamos conflictos de validacion en la cosulta
            accion = 2
            ConectarSQL()
            NomIdTipo(tipo, cbx_Tipo.Text)
            DesconectarSQL()
            ConectarSQL()
            spLogin(UsernameTextBox, pws, acceso, tipo, accion, msg)
            DesconectarSQL()
        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If OK.Text = "Actualizar" Then
            accion = 3
            ConectarSQL()
            NomIdTipo(tipo, cbx_Tipo.Text)
            DesconectarSQL()
            ConectarSQL()
            spLogin(UsernameTextBox, pws, acceso, tipo, accion, msg)
            DesconectarSQL()
        Else

            MessageBox.Show("no se puede usar esta acción")

        End If
    End Sub
End Class
