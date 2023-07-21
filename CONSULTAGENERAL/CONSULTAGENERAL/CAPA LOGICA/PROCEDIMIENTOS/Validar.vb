Imports System.Data.SqlClient
Public Class Validar
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Public Function Validar(ByVal dts As DCEstudiante)
        Try
            conectado()
            cmd = New SqlCommand("Validar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class
