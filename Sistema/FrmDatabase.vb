Public Class FrmDatabase



    Dim direccion As String
    Dim nombrebackup As String
    Dim cadena As String
    Dim accion As Integer
    Dim mensaje As String = "vacio"

    Private Sub FrmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_Restaurar.Enabled = False
        btn_Respaldar.Enabled = False

    End Sub

    '************************************************************************************************************

    Private Sub btn_Examinar_Click(sender As Object, e As EventArgs) Handles btn_Examinar.Click
        lbl_backup.Text = ""
        btn_Respaldar.Enabled = False

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

            TxbDireccion.Text = FolderBrowserDialog1.SelectedPath

            TxbDireccion.Enabled = False

        End If

    End Sub


    Private Sub txb_nombrebackup_TextChanged(sender As Object, e As EventArgs) Handles txb_nombrebackup.TextChanged

        If txb_nombrebackup.Text <> "" And TxbDireccion.Text <> "" Then

            btn_Respaldar.Enabled = True

        End If

    End Sub

    Private Sub btn_Respaldar_Click(sender As Object, e As EventArgs) Handles btn_Respaldar.Click

        accion = 1
        direccion = TxbDireccion.Text
        nombrebackup = txb_nombrebackup.Text

        If TxbDireccion.Text = "" Or txb_nombrebackup.Text = "" Then

            MessageBox.Show("debe ingresar los datos requeridos")

        Else
            'verificamos si existe el directorio escrito 
            If Not IO.Directory.Exists(direccion) Then
                IO.Directory.CreateDirectory(direccion)
            Else


                cadena = direccion + "\" + nombrebackup + ".bak"

                Dim dbbackup As New dbBackup
                ConectarSQLM()
                dbbackup.backupandrestore(cadena, accion, mensaje)
                DesconectarSQLM()
                lbl_backup.Text = mensaje
            End If
        End If

    End Sub

    '**************************************************************************************************************************

    Private Sub btn_examinarRest_Click(sender As Object, e As EventArgs) Handles btn_examinarRest.Click
        lbl_restore.Text = ""
        btn_Restaurar.Enabled = False

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            txb_direccionRestaurar.Text = OpenFileDialog1.FileName.Trim()

            Dim ext As New validaciones

            Dim valor As String = ext.Extraer(txb_direccionRestaurar.Text)


            If valor <> "bak" Then

                MessageBox.Show("debe ingresar un archivo valido para restaurar")


            Else

                btn_Restaurar.Enabled = True
                txb_direccionRestaurar.Enabled = False

            End If

        End If

    End Sub

    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click

        accion = 2
        direccion = txb_direccionRestaurar.Text
        Dim dbrestore As New dbBackup
        ConectarSQLM()
        dbrestore.backupandrestore(direccion, accion, mensaje)
        DesconectarSQLM()
        lbl_restore.Text = mensaje


    End Sub


End Class