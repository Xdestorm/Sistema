Imports System.Data.SqlClient
Module Acceso
    'valida usuario y clave de acceso al programa
#Disable Warning IDE1006 ' Estilos de nombres

    Public Sub NomIdTipo(ByRef id As Integer, ByRef nom As String)
        Try
            cmd = New SqlCommand("SELECT [IdTipoPer], [NomTipoPer] FROM [dbo].[Tb_TipoPersona] WHERE [IdTipoPer] ='" & id & "' or [NomTipoPer] = '" & nom & "' ", cnn)
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            If data_reader.Read Then
                id = data_reader(0)
                nom = data_reader(1)
                data_reader.Close()
            End If
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub spLogin(ByVal user As TextBox, ByVal pws As String, ByRef acceso As Integer, ByRef tipo As Integer, ByVal accion As Integer, ByRef msg As String)
#Enable Warning IDE1006 ' Estilos de nombres
        Dim has As New OC.Core.Crypto.Hash
        Dim cif As String

        If pws = "" Then
            'pasamos vacio
        Else
            pws = has.Sha256(pws).ToLower 'lo ciframos

        End If

        Try
            cmd = New SqlCommand("spAcceso", cnn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user.Text.Trim()
            cmd.Parameters.Add("@psw", SqlDbType.VarChar).Value = pws
            cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo
            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = accion

            cmd.ExecuteNonQuery()

            If accion = 4 Then
                Dim data_reader As SqlDataReader
                data_reader = cmd.ExecuteReader
                If data_reader.Read Then
                    user.Text = data_reader(0)
                    cif = data_reader(1)
                    tipo = data_reader(2)
                    msg = "Exito"

                    'validamos para coincidencia para dar acceso
                    If user.Text = data_reader(0) And pws.Equals(cif) Then

                        acceso = 1

                    Else

                        acceso = 0

                    End If
                    data_reader.Close()
                Else
                    MsgBox("no se encontro el usuario")
                End If

            ElseIf accion = 1 Then

                MessageBox.Show("Usuario Creado, Quiere Cerrar la ventana?", "Agregar", MessageBoxButtons.YesNo)

                If MessageBoxButtons.YesNo = vbYes Then
                    FrmLogin.Close()
                Else
                    Limpiar(FrmLogin)
                End If

                FrmLogin.Close()

            ElseIf accion = 2 Then

                MessageBox.Show("Usuario Actualizado", "Actualizar")
                FrmLogin.Close()
            ElseIf accion = 3 Then

                MessageBox.Show("Usuario Eliminado", "Eliminar")
                FrmLogin.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
