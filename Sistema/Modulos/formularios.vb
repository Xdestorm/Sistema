Module formularios
    Public Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = FrmPrincipal.PContainer.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform With {
                .TopLevel = False,
                .FormBorderStyle = FormBorderStyle.None,
                .Dock = DockStyle.Fill
            }

            FrmPrincipal.PContainer.Controls.Add(Formulario)
            FrmPrincipal.PContainer.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub
    'Cierra el formulario 
    Public Sub CerrarFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = FrmPrincipal.PContainer.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        If Formulario Is Nothing Then
            'condicion en caso que se requiera 
        Else
            Formulario.Close()
        End If
    End Sub


    Public Sub Limpiar(ByVal formulario As Form)
        'Recorremos todos los controles del formulario que enviamos.
        For Each control As Control In formulario.Controls
            'Filtramos solo aquellos de tipo TextBox.
            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto.
            End If
            If TypeOf control Is ComboBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Public Sub CerrarFrm(ByVal Formulario As Form)

        If MessageBox.Show(
            "¿Desea cerrar el formulario?", "Cerrar el formulario",
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Formulario.Close()
        End If


    End Sub


End Module

