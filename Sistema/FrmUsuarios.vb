Public Class FrmUsuarios
    Dim anexo As Integer = 0
    Dim accion As Integer
    Dim i As Integer = 0
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
        Dim correoID As String = TbCorreo.Text
        ConectarSQL()
        AgregarUsuario(TbCorreo.Text, TbNombre, TbApellido, TxUbicacion, CbPlanta, CbEmpresa, anexo, CbTipo, CbEstados, accion, TbClave, i)
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

    End Sub
    'Boton Agrega o Actualiza segun se requiere
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click

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

                ElseIf TbClave.Enabled = True And TbClave.Text <> "" And BtnUsuarios.Text = "Actualizar" Then

                    accion = 5 'actualizar clave de usuario, solo aplica para admin o tech

                ElseIf BtnUsuarios.Text = "Actualizar" Then

                    accion = 2 'actualizar usuario

                End If

                ConectarSQL()
                AgregarUsuario(TbCorreo.Text, TbNombre, TbApellido, TxUbicacion, CbPlanta, CbEmpresa, anexo, CbTipo, CbEstados, accion, TbClave, i)
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
            MessageBox.Show("llene todos los campos requeridos", "Información")
        End If
    End Sub

    Private Sub BtnAdminUsers_Click(sender As Object, e As EventArgs) Handles BtnAdminUsers.Click

    End Sub

    Private Sub CbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged
        If CbTipo.Text = "Técnico" Or CbTipo.Text = "Administrador" Then

            TbClave.Enabled = True
        Else
            TbClave.Enabled = False

        End If
    End Sub
End Class