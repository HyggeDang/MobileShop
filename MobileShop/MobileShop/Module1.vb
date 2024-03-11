Imports System.Data.OleDb

Module Module1
    Public cn As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & Application.StartupPath & "\DataBase\Mobile.mdb;Persist Security Info=false;")
    Public rptStr As String

    Public Function Text_Validation(ByVal ch As Char) As Boolean
        If Not (Asc(ch)) = 8 Then
            If InStr("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRST.UVWXYZ ", ch) = 0 Then
                Return True
            End If
        End If
    End Function

    Public Function Number_Validation(ByVal ch As Char) As Boolean
        If Not (Asc(ch)) = 8 Then
            If InStr("0123456789", ch) = 0 Then
                Return True
            End If
        End If
    End Function


End Module
