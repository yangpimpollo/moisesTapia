Imports System.Data.SqlClient
Public Class DCEstudiante
    Inherits Conexion
    Private ALU_ID As String
    Private ALU_NOMBRE As String
    Private ALU_DIRECCION As String
    Private ALU_TELEFONO As String
    Private ALU_EMAIL As String
    Private cmd As SqlCommand
    Public Property ID_ALU As String
        Get
            Return ALU_ID
        End Get
        Set(value As String)
            ALU_ID = value
        End Set
    End Property
    Public Property NOMBRE_ALU As String
        Get
            Return ALU_NOMBRE
        End Get
        Set(value As String)
            ALU_NOMBRE = value
        End Set
    End Property
    Public Property DIRECC_ALU As String
        Get
            Return ALU_DIRECCION
        End Get
        Set(value As String)
            ALU_DIRECCION = value
        End Set
    End Property
    Public Property TEL_ALU As String
        Get
            Return ALU_TELEFONO
        End Get
        Set(value As String)
            ALU_TELEFONO = value
        End Set
    End Property
    Public Property EMAIL_ALU As String
        Get
            Return ALU_EMAIL
        End Get
        Set(value As String)
            ALU_EMAIL = value
        End Set
    End Property
End Class
