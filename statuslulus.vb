Public Class statuslulus
    Dim sqlnya As String

    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Tb_kelulusan", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tb_kelulusan")
        DataGridView1.DataSource = ds.Tables("Tb_kelulusan")
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

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Tb_kelulusan where Nama like '%" & TextBox1.Text & "%'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tb_kelulusan")
        DataGridView1.DataSource = ds.Tables("Tb_kelulusan")
    End Sub
End Class