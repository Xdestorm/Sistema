Imports System.Data.SqlClient

Public Class FrmPrincipal
    Dim acceso As Integer
    Dim tipo As Integer
    Dim accion As Integer
    Dim msg As String

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


#Disable Warning IDE1006 ' Estilos de nombres
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
#Enable Warning IDE1006 ' Estilos de nombres
        formularios.CerrarFormEnPanel(Of FrmProductos)()

        formularios.AbrirFormEnPanel(Of FrmUsuarios)()
        'btnUsuarios.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        formularios.CerrarFormEnPanel(Of FrmUsuarios)()

        formularios.AbrirFormEnPanel(Of FrmProductos)()
        'btnUsuarios.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
    Private Sub BtnAsignaciones_Click(sender As Object, e As EventArgs) Handles BtnAsignaciones.Click
        formularios.CerrarFormEnPanel(Of FrmAsignaciones)()

        formularios.AbrirFormEnPanel(Of FrmAsignaciones)()
        'btnUsuarios.BackColor = Color.FromArgb(12, 61, 92)
    End Sub
    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        formularios.CerrarFormEnPanel(Of FrmInventario)()

        formularios.AbrirFormEnPanel(Of FrmInventario)()
    End Sub
    Private Sub BtnAcceso_Click(sender As Object, e As EventArgs) Handles BtnAcceso.Click

        accion = 4
        tipo = 0
        Dim psw As String = TxbContraseñaUsuario.Text

        Dim validar_email As New validaciones 'instanciamos el objeto

        If validar_email.valemail(LCase(TxbInicioUsuario.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.com, " & " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxbInicioUsuario.Focus()
            TxbInicioUsuario.SelectAll()


        Else

            ConectarSQL()
            spLogin(TxbInicioUsuario, psw, acceso, tipo, accion, msg) ' procedimiento que trae los datos, si es valido activa los controles

            If acceso = 1 Then
                btnUsuarios.Enabled = True
                BtnProductos.Enabled = True
                BtnAsignaciones.Enabled = True
                BtnInventario.Enabled = True
                TmMenuMostrar.Enabled = True
            Else

                MessageBox.Show("no tiene privilegios para acceder al sistema", "Sistema", MessageBoxButtons.OK)
                TxbInicioUsuario.Text = ""
                TxbContraseñaUsuario.Text = ""
                TxbInicioUsuario.Select()
            End If
            'dato que indica si es tecnico o administrador y activa las condiciones de administrador
            If tipo = 1 Then
                BtnAdministracion.Enabled = True
                btn_adm.Enabled = True
            ElseIf tipo = 2 Then
                BtnAdministracion.Enabled = False
            Else

            End If
            DesconectarSQL()

        End If



    End Sub
    'Acciones del Muenu Vertical
    Private Sub PBMenu_Click(sender As Object, e As EventArgs) Handles PBMenu.Click
        'condicion para abrir o cerrar el menu vertical
        If PMVertical.Width = 60 Then
            TmMenuMostrar.Enabled = True
        ElseIf PMVertical.Width = 250 Then
            TmMenuOcultar.Enabled = True
        End If

    End Sub
    Private Sub TmMenuOcultar_Tick(sender As Object, e As EventArgs) Handles TmMenuOcultar.Tick
        If PMVertical.Width <= 60 Then
            Me.TmMenuOcultar.Enabled = False
        Else
            Me.PMVertical.Width = PMVertical.Width - 10
        End If
    End Sub

    Private Sub TmMenuMostrar_Tick(sender As Object, e As EventArgs) Handles TmMenuMostrar.Tick
        If PMVertical.Width >= 250 Then
            Me.TmMenuMostrar.Enabled = False
        Else
            Me.PMVertical.Width = PMVertical.Width + 10
        End If
    End Sub

    Private Sub btn_adm_Click(sender As Object, e As EventArgs) Handles btn_adm.Click
        formularios.CerrarFormEnPanel(Of FrmLogin)()

        formularios.AbrirFormEnPanel(Of FrmLogin)()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click

        If MessageBox.Show(
            "¿Desea cerrar sesion?", "Cerrar sesion",
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DesconectarSQL()

            formularios.CerrarFormEnPanel(Of FrmUsuarios)()
            formularios.CerrarFormEnPanel(Of FrmProductos)()
            formularios.CerrarFormEnPanel(Of FrmAsignaciones)()
            formularios.CerrarFormEnPanel(Of FrmInventario)()
            formularios.CerrarFormEnPanel(Of FrmLogin)()

            Limpiar(Me)
            TxbInicioUsuario.Text = ""
            TxbContraseñaUsuario.Text = ""
            btn_adm.Enabled = False
            btnUsuarios.Enabled = False
            BtnInventario.Enabled = False
            BtnAsignaciones.Enabled = False
            BtnProductos.Enabled = False
            BtnAdministracion.Enabled = False

            Me.Refresh()
        Else



        End If



    End Sub
End Class
