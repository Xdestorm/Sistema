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


End Class
