Public Class FrmProductos
    Dim result As DialogResult
    Dim id_Marca As Integer
    Dim p As Integer = 0
    Dim accion As Integer
    Private Sub PBCerrar_Click(sender As Object, e As EventArgs) Handles PBCerrar.Click
        CerrarFrm(Me)
    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarSQL()
        Usuarios.CbPlanta(CbSitiosProd)
        Productos.CbMarcas(CbMarcas)
        Productos.CbEstadosProd(CbEstadosProd)
        Productos.CbTiposProd(CbTiposProd)
        Productos.CbContratos(CbContratos)
        DesconectarSQL()
    End Sub

    'Private Sub CbMarcas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMarcas.SelectedIndexChanged
    '    ConectarSQL()
    '    Productos.IdMarca(id_Marca, CbMarcas.Text)
    '    DesconectarSQL()

    'End Sub

    Private Sub BtnConsultarProducto_Click(sender As Object, e As EventArgs) Handles BtnConsultarProducto.Click
        accion = 4

        ConectarSQL()
        AgregarProducto(TxServiceTag, CbMarcas, CbModelos, CbTiposProd, TbDescripcion, CbEstadosProd, CbContratos, CbSitiosProd, accion, p)
        DesconectarSQL()

        If p = 1 Then

            CbMarcas.Enabled = False
            CbModelos.Enabled = False
            CbTiposProd.Enabled = False
            CbContratos.Enabled = False
            CbSitiosProd.Enabled = False

            BtnProductos.Text = "Actualizar"
            accion = 2 'es actualizar usuario en SP SQL
        Else
            Limpiar(Me)
            BtnProductos.Text = "Agregar"
            CbMarcas.Enabled = True
            CbModelos.Enabled = True
            CbTiposProd.Enabled = True
            CbContratos.Enabled = True
            CbSitiosProd.Enabled = True

        End If
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click


        If TxServiceTag.Text <> "" And CbMarcas.Text <> "" And CbModelos.Text <> "" And CbTiposProd.Text <> "" And CbSitiosProd.Text <> "" And CbEstadosProd.Text <> "" And CbContratos.Text <> "" Then
            ' Dim opt As Integer
            Try
                If BtnProductos.Text = "Agregar" Then
                    accion = 1
                Else
                    accion = 2 'es actualizar usuario en SP SQL
                End If

                'If CbEstadosProd.Text = "Disponible" And accion = 2 Then

                '    result = MessageBox.Show("Esta seguro de eliminar la asignación?", "Eliminar asignación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                '    If result = DialogResult.Yes Then

                '        opt = 1

                '    ElseIf result = DialogResult.No Then

                '        CbEstadosProd.Text = "Asignado"

                '        Exit Sub

                '    ElseIf accion = 2 And CbEstadosProd.Text <> "Disponible" Then

                '        opt = 1

                '    End If

                '    If opt = 1 Then

                ConectarSQL()
                AgregarProducto(TxServiceTag, CbMarcas, CbModelos, CbTiposProd, TbDescripcion, CbEstadosProd, CbContratos, CbSitiosProd, accion, p)
                DesconectarSQL()

                'End If


                'End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Limpiar(Me)
            BtnProductos.Text = "Agregar"
            CbMarcas.Enabled = True
            CbModelos.Enabled = True
            CbTiposProd.Enabled = True
            CbContratos.Enabled = True
            CbSitiosProd.Enabled = True
        Else
            MessageBox.Show("llene todos los campos requeridos", "Información")
        End If

    End Sub

    Private Sub CbTiposProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTiposProd.SelectedIndexChanged

        ConectarSQL()
        'limpiamos el cb antes de volver a llenarlo
        CbModelos.Items.Clear()
        CbModelos.Text = ""

        Dim idtipo As Integer
        Dim nomtipo As String

        nomtipo = CbTiposProd.Text.Trim

        Productos.IdTipo(idtipo, nomtipo)
        Productos.IdMarca(id_Marca, CbMarcas.Text)
        'traemos el modelo segun la marca del producto y el tipo
        Productos.CbModelos(CbModelos, id_Marca, idtipo)

        DesconectarSQL()




    End Sub


End Class