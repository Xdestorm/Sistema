Public Class FrmUsuarios
    Dim anexo As Integer = 0
    Dim accion As Integer
    Dim i As Integer = 0

    Dim validar_email As New validaciones 'instanciamos el objeto

    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click

        CerrarFrm(Me)

    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarSQL()
        Usuarios.CbPlanta(CbPlanta)
        Usuarios.CbEmpresas(CbEmpresa)
        Usuarios.CbTipos(CbTipo)
        Usuarios.Cbestados(CbEstados)
        DesconectarSQL()

        CbEstados.SelectedIndex = 0
        CbEstados.Enabled = False

        If FrmPrincipal.BtnAdministracion.Enabled = True Then
            BtnAdminUsers.Enabled = True
        Else
            BtnAdminUsers.Enabled = False
        End If

    End Sub
    'Activa la consulta de usuario
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        accion = 4




        If validar_email.valemail(LCase(TbCorreo.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TbCorreo.Focus()
            TbCorreo.SelectAll()

        Else
            Dim correoID As String = TbCorreo.Text
            ConectarSQL()
            Usuario(TbCorreo.Text, TbNombre, TbApellido, TxUbicacion, CbPlanta, CbEmpresa, anexo, CbTipo, CbEstados, accion, i)
            TbAnexo.Text = anexo
            DesconectarSQL()

            If i = 1 Then
                TbNombre.Enabled = False
                TbApellido.Enabled = False
                CbEmpresa.Enabled = False
                CbPlanta.Enabled = False
                CbTipo.Enabled = False
                BtnUsuarios.Text = "Actualizar"
            Else
                Limpiar(Me) 'limpiamos los campos
                TbCorreo.Text = correoID 'mantenemos el correo consultado
                BtnUsuarios.Text = "Agregar" 'cambiamos el nombre del boton
                CbEstados.Text = "Activo" 'cambiamos el estado a usuario activo
                'activamos los campos
                TbNombre.Enabled = True
                TbApellido.Enabled = True
                CbEmpresa.Enabled = True
                CbPlanta.Enabled = True
                CbTipo.Enabled = True
            End If
        End If
    End Sub
    'Boton Agrega o Actualiza segun se requiere
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click

        If validar_email.valemail(LCase(TbCorreo.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TbCorreo.Focus()
            TbCorreo.SelectAll()

        Else


            If TbCorreo.Text <> "" And TbNombre.Text <> "" And TbApellido.Text <> "" And TxUbicacion.Text <> "" And CbEmpresa.Text <> "" And CbPlanta.Text <> "" And CbTipo.Text <> "" Then

                Try
                    'validamos que anexo
                    If TbAnexo.Text = "" Then
                        anexo = 0
                    Else
                        anexo = Convert.ToInt32(TbAnexo.Text)
                    End If

                    'validamos las acciones 
                    If BtnUsuarios.Text = "Agregar" Then

                        accion = 1 'agregar usuario

                    ElseIf BtnUsuarios.Text = "Actualizar" Then

                        accion = 2 'actualizar usuario

                    End If

                    ConectarSQL()
                    Usuario(TbCorreo.Text, TbNombre, TbApellido, TxUbicacion, CbPlanta, CbEmpresa, anexo, CbTipo, CbEstados, accion, i)
                    DesconectarSQL()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Limpiar(Me)
                BtnUsuarios.Text = "Agregar"
                CbEstados.Text = "Activo"
                TbNombre.Enabled = True
                TbApellido.Enabled = True
                CbEmpresa.Enabled = True
                CbPlanta.Enabled = True
                CbTipo.Enabled = True


            Else
                MessageBox.Show("Complete todos los campos requeridos", "Información")
            End If
        End If
    End Sub


    Private Sub TbNombre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TbNombre.KeyPress
        'validamos que solo se ingrese texto
        Dim soloL As New validaciones
        soloL.SoloLetras(e)
    End Sub

    Private Sub TbAnexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbAnexo.KeyPress
        'validamos que solo se ingresen numeros en el campo
        Dim soloN As New validaciones
        soloN.SoloNumeros(e)
    End Sub

    Private Sub TbApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbApellido.KeyPress
        'validamos que solo se ingrese texto
        Dim soloL As New validaciones
        soloL.SoloLetras(e)
    End Sub

    Private Sub TxUbicacion_TextChanged(sender As Object, e As EventArgs) Handles TxUbicacion.TextChanged
        'validamos que solo se ingresen 50 caracteres en el campo
        Dim maxtext As Integer = 50
        Dim valor As Integer
        TxUbicacion.MaxLength = maxtext

        Dim cCaracter As New validaciones
        cCaracter.contCaracter(TxUbicacion.Text, maxtext, valor)

        lbl_maxtext.Text = valor

        If valor <= 0 Then

            MessageBox.Show("No puede ingresar mas de 100 caracteres")

        End If

    End Sub
End Class