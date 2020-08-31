Imports System.Text.RegularExpressions

Public Class validaciones

    'funcion para validar formato de email
    Public Function valemail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    'funcion para extraer el nombre del achivo o su extension 
    Public Function Extraer(Path As String) As String
        Dim ret As String
        Dim Caracter As String = "."
        If InStr(Path, Caracter) = 0 Then Exit Function

        ret = Right(Path, Len(Path) - InStrRev(Path, Caracter))

        ' -- Retorna el valor  
        Extraer = ret
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Public Sub SoloLetras(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Public Sub SoloNumeros(ByRef e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    'contador de caracter
    Public Sub contCaracter(ByVal texto As String, ByVal maxtext As Integer, ByRef valor As Integer)

        'pasamos el valor del campo de texto a integer y lo almacenamos en la variables 
        Dim count As Integer = Len(texto)
        'restamos el valor y lo mostramos en el programa
        valor = maxtext - count

    End Sub
End Class
