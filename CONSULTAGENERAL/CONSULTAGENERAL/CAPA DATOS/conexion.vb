Imports System.Data.SqlClient
Public Class Conexion
    Protected cnn As New SqlConnection("Data Source=DESKTOP-3U63GCL;Initial Catalog=EDUCA;Integrated Security=True")

    Public Function conectado() As Boolean
        Try
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub desconectado()
        Try
            If cnn.State = ConnectionState.Open Then

                cnn.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

