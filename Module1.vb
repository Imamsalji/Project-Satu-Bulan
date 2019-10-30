Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection
    Public cmd As OleDbCommand
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public rd As OleDbDataReader
    Public lokasidata As String

    Public Sub konek()
        lokasidata = "provider=microsoft.ace.oledb.12.0;data source=Penerimaaan Siswa Baru.mdb"
        con = New OleDbConnection(lokasidata)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
End Module
