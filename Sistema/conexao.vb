Imports System.Data.SqlClient
Module conexao
    Public conectar As SqlConnection
    Public comando As SqlCommand
    Public local As DataSet
    Public adaptar As SqlDataAdapter
    Public sql As String
    Public resultado As Integer
    Public registro As DataRow
    Public dt As DataSet
    Public cnn As String = "Data Source=ALESSANDRA-E-JA\MSSQLSEVER2; Initial Catalog=sistema; User id=sa; Password=123456;"
    Public vnivel As String 
    Public contador As Integer

End Module
