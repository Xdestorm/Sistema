Imports System.Data.SqlClient

Public Class FrmPrincipal
    Dim acceso As Integer
    Dim tipo As Integer

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
        ConectarSQL()

        spLogin(TxbInicioUsuario, TxbContraseñaUsuario, acceso, tipo) ' procedimiento que trae los datos, si es valido activa los controles
        If acceso = 1 Then
            btnUsuarios.Enabled = True
            BtnProductos.Enabled = True
            BtnAsignaciones.Enabled = True
            BtnInventario.Enabled = True
        End If
        'dato que indica si es tecnico o administrador y activa las condiciones de administrador
        If tipo = 1 Then
            BtnAdministracion.Enabled = True
        End If
        DesconectarSQL()
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

End Class
