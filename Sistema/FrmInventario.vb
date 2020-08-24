Public Class FrmInventario
    Dim msg As String = "mensaje"
    Dim estado As String = ""
    Dim accion As Integer = 0

    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarSQL()
        CbPlanta(CbSitios)
        DesconectarSQL()
    End Sub

    Private Sub BtnConsultarAsignaciones_Click(sender As Object, e As EventArgs) Handles BtnConsultarAsignaciones.Click
        ConectarSQL()
        inventario(CbSitios, msg, DgvInv)
        DesconectarSQL()
    End Sub

#Disable Warning IDE1006 ' Estilos de nombres
    Private Sub btnConsultaDisponibles_Click(sender As Object, e As EventArgs) Handles btnConsultaDisponibles.Click
#Enable Warning IDE1006 ' Estilos de nombres
        estado = "Disponible"
        accion = 1
        ConectarSQL()
        inventariomulti(CbSitios, estado, accion, txt_host.Text, msg, DgvInv)
        DesconectarSQL()
    End Sub

    Private Sub PbbuttonExcel_Click(sender As Object, e As EventArgs) Handles PbbuttonExcel.Click
        expExcel(DgvInv)
    End Sub

    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click
        CerrarFrm(Me)
    End Sub

    Private Sub btn_host_Click(sender As Object, e As EventArgs) Handles btn_host.Click
        accion = 2
        ConectarSQL()
        inventariomulti(CbSitios, estado, accion, txt_host.Text, msg, DgvInv)
        DesconectarSQL()
    End Sub
End Class