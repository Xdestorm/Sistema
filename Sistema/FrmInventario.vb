Public Class FrmInventario
    Dim msg As String = "mensaje"


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
        Dim estado As String = "Disponible"
        ConectarSQL()
        inventarioDisponibles(CbSitios, estado, 1, msg, DgvInv)
        DesconectarSQL()
    End Sub

    Private Sub PbbuttonExcel_Click(sender As Object, e As EventArgs) Handles PbbuttonExcel.Click
        expExcel(DgvInv)
    End Sub

    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click
        CerrarFrm(Me)
    End Sub
End Class