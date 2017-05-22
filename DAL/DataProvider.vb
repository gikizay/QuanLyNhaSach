Imports System.Data.SqlClient


Public Class DataProvider
    Protected Const connStr As String = "Data Source=HMCHOAN-6V3O0HL\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True"
    Shared conn As SqlConnection

    Public Shared Sub OpenConnection()
        Try
            conn = New SqlConnection(connStr)
            conn.Open()
        Catch

        End Try
    End Sub

    Public Shared Sub CloseConnection()
        If Not (conn Is Nothing) Then
            conn.Close()
        End If
    End Sub

    Public Shared Function ExcuteQuery(Sql As String) As DataTable
        OpenConnection()
        Dim dt As New DataTable
        Dim comm As SqlCommand = conn.CreateCommand()
        comm.CommandText = Sql
        Dim da As New SqlDataAdapter()
        da.SelectCommand = comm

        da.Fill(dt)
        CloseConnection()
        Return dt
    End Function

    Public Shared Sub ExcuteNonQuery(sql As String)
        OpenConnection()
        Dim command As SqlCommand = conn.CreateCommand()
        command.CommandText = sql
        command.ExecuteNonQuery()
        CloseConnection()
    End Sub

End Class
