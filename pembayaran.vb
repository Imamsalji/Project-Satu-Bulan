Public Class pembayaran
    Dim sqlnya As String

    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Tb_bayar", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tb_bayar")
        DataGridView1.DataSource = ds.Tables("Tb_bayar")
        DataGridView1.Enabled = True
    End Sub
    Sub jalan()
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sqlnya
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
        DateTimePicker1.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub pembayaran_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.Items.Add("ATM")
        ComboBox1.Items.Add("BCA")
        ComboBox1.Items.Add("MANDIRI")
        ComboBox1.Items.Add("CASH")
        TextBox1.Text = Form1.TextBox3.Text
        TextBox2.Text = Form1.TextBox1.Text
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Call panggildata()
    End Sub
    Dim b As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox3.Text) <= 2000000 Then
            MsgBox("maaf uang anda kurang")
            TextBox3.Text = ""
        Else
            TextBox4.Text = Val(TextBox3.Text) - 2000000
            sqlnya = "insert into Tb_bayar values('" & TextBox2.Text & "','" & TextBox1.Text & "','" & DateTimePicker1.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "')"
            Call jalan()
            MsgBox("data telah di simpan")
            Call panggildata()
            Button1.Enabled = False
            dalamlogin.Panel1.Controls.Clear()
            kelulusan.TopLevel = False
            dalamlogin.Panel1.Controls.Add(kelulusan)
            kelulusan.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlnya = "UPDATE Tb_bayar set Nama='" & TextBox1.Text & "',No_daftar='" & TextBox2.Text & "',T_Bayar='" & DateTimePicker1.Text & "',J_Bayar='" & ComboBox1.Text & "' where No_Transaksi='" & TextBox5.Text & "'"
        Call jalan()
        MsgBox("update")
        Call panggildata()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sqlnya = "delete from Tb_bayar where No_Transaksi='" & TextBox5.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Terhapus")
        Call panggildata()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i = DataGridView1.NewRowIndex Then
            MsgBox("Data Tidak ada")
        Else
            TextBox1.Text = DataGridView1.Item(0, i).Value
            TextBox2.Text = DataGridView1.Item(1, i).Value
            DateTimePicker1.Text = DataGridView1.Item(2, i).Value
            ComboBox1.Text = DataGridView1.Item(3, i).Value
            TextBox5.Text = DataGridView1.Item(4, i).Value
        End If

    End Sub
    Dim bab As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "CASH" Then
            TextBox5.Text = "TUNAI"
            bab = "TUNAI"
            TextBox5.Enabled = False
            Label11.Text = "harga = RP.2.000.000"
        Else
            TextBox5.Enabled = True
            TextBox5.Text = ""
            bab = "NO TUNAI"
            Label11.Text = "harga = RP.2.000.000"
        End If
        kelulusan.TextBox9.Text = bab
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class