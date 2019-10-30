Public Class Datadaftar
    Dim sqlnya As String

    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Db_Daftar", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Db_Daftar")
        DataGridView1.DataSource = ds.Tables("Db_Daftar")
        DataGridView1.Enabled = True
    End Sub
    Dim jk As String
    Sub jalan()
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sqlnya
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Private Sub Datadaftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Form1.DataGridView1.DataSource
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
       
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Db_Daftar where NAMA_LENGKAP like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Db_Daftar")
        DataGridView1.DataSource = ds.Tables("Db_Daftar")
    End Sub
End Class