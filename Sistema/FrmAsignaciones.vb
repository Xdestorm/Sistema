Public Class FrmAsignaciones

    Dim msg As String
    Dim id, id_Marca As Integer


    Private Sub FrmAsignaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarSQL()
        CbMarcas(CbMarcasDisp)
        CbTiposProd(CbTipoProductoAsig)
        DesconectarSQL()

        TxHost.Enabled = False

    End Sub

    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click
        CerrarFrm(Me)
    End Sub

    Private Sub BtnConsultarAsignaciones_Click(sender As Object, e As EventArgs) Handles BtnConsultarAsignaciones.Click
        msg = ""
        ConectarSQL()
        consultaUsuario(TxCorreoUsuario, msg, DgvUserAsig)

        DgvUserAsig.Columns(0).HeaderCell.Value = "Nombre"
        DgvUserAsig.Columns(0).Width = 100
        DgvUserAsig.Columns(1).HeaderCell.Value = "Apellido"
        DgvUserAsig.Columns(1).Width = 100
        DgvUserAsig.Columns(2).HeaderCell.Value = "Anexo"
        DgvUserAsig.Columns(2).Width = 50
        DgvUserAsig.Columns(3).HeaderCell.Value = "Ubicación"
        DgvUserAsig.Columns(3).Width = 200
        DgvUserAsig.Columns(4).HeaderCell.Value = "Sitio"
        DgvUserAsig.Columns(4).Width = 100
        DgvUserAsig.Columns(5).HeaderCell.Value = "Empresa"
        DgvUserAsig.Columns(5).Width = 100
        DgvUserAsig.Columns(6).HeaderCell.Value = "Tipo"
        DgvUserAsig.Columns(6).Width = 100
        DgvUserAsig.Columns(7).HeaderCell.Value = "Estado"
        DgvUserAsig.Columns(7).Width = 100

        DesconectarSQL()

        ConectarSQL()
        consultaAsignaciones(TxCorreoUsuario, msg, DgvActv)

        DgvActv.Columns(0).HeaderCell.Value = "Fecha asignación"
        DgvActv.Columns(0).Width = 100
        DgvActv.Columns(1).HeaderCell.Value = "Tipo de producto"
        DgvActv.Columns(1).Width = 100
        DgvActv.Columns(2).HeaderCell.Value = "Asignación"
        DgvActv.Columns(2).Width = 100
        DgvActv.Columns(3).HeaderCell.Value = "Marca"
        DgvActv.Columns(3).Width = 100
        DgvActv.Columns(4).HeaderCell.Value = "Modelo"
        DgvActv.Columns(4).Width = 100
        DgvActv.Columns(5).HeaderCell.Value = "Service tag"
        DgvActv.Columns(5).Width = 100
        DgvActv.Columns(6).HeaderCell.Value = "Contrato"
        DgvActv.Columns(6).Width = 100
        DgvActv.Columns(7).HeaderCell.Value = "Sitio"
        DgvActv.Columns(7).Width = 100
        DgvActv.Columns(8).HeaderCell.Value = "Descripción"
        DgvActv.Columns(8).Width = 200

        DesconectarSQL()
                          
    End Sub




    Private Sub CbTipoProductoAsig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipoProductoAsig.SelectedIndexChanged
        'ConectarSQL()
        'NomMarca(CbTipoProductoAsig, CbMarcasDisp)
        'DesconectarSQL()

        ConectarSQL()
        'limpiamos el cb antes de volver a llenarlo
        CbModelosAsig.Items.Clear()
        CbModelosAsig.Text = ""
        Productos.IdMarca(id_Marca, CbMarcasDisp.Text.Trim)
        Dim idtipo As Integer
        Dim nomtipo As String

        nomtipo = CbTipoProductoAsig.Text.Trim

        Productos.IdTipo(idtipo, nomtipo)
        Productos.IdMarca(id_Marca, CbMarcasDisp.Text)
        'traemos el modelo segun la marca del producto y el tipo
        Productos.CbModelos(CbModelosAsig, id_Marca, idtipo)

        DesconectarSQL()




        If CbTipoProductoAsig.Text = "Laptop" Or CbTipoProductoAsig.Text = "Computador" Or CbTipoProductoAsig.Text = "Ipad" Then

            TxHost.Enabled = True
        Else

            TxHost.Enabled = False

        End If



    End Sub

    'Private Sub CbMarcasDisp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMarcasDisp.SelectedIndexChanged
    '    CbModelosAsig.Items.Clear()
    '    CbModelosAsig.Text = ""
    '    CbProDisp.Items.Clear()
    '    CbProDisp.Text = ""
    '    ConectarSQL()
    '    NomModelo(CbModelosAsig, CbMarcasDisp, CbTipoProductoAsig)
    '    DesconectarSQL()
    'End Sub

    Private Sub CbModelosAsig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbModelosAsig.SelectedIndexChanged
        CbProDisp.Items.Clear()
        CbProDisp.Text = ""
        ConectarSQL()
        Disponibles(CbProDisp, CbModelosAsig.Text)
        DesconectarSQL()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        Dim checked As Integer
        Dim accion As Integer
        If (TxHost.Text = "" And CbTipoProductoAsig.Text = "Laptop") Or (TxHost.Text = "" And CbTipoProductoAsig.Text = "Computador") Then
            MessageBox.Show("Debe asignar un HOST al producto seleccionado")
            TxHost.Focus()
        ElseIf Chkb_Multiusuario.Checked Then
            checked = 1
            MessageBox.Show(checked)
            accion = 1
            ConectarSQL()
            AsignarProductos(accion, TxCorreoUsuario, CbProDisp, TxHost, checked)
            DesconectarSQL()
            Limpiar(Me)
        Else
            MessageBox.Show(checked)
            accion = 1
            ConectarSQL()
            AsignarProductos(accion, TxCorreoUsuario, CbProDisp, TxHost, checked)
            DesconectarSQL()
            Limpiar(Me)

        End If
    End Sub

    Private Sub CbProDisp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProDisp.SelectedIndexChanged

        ConectarSQL()
        Descripcion(CbProDisp, TbDescripcion.Text)
        DesconectarSQL()

    End Sub
End Class