Public Class kelulusan
    Dim sqlnya As String
    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Tb_kelulusan", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Tb_kelulusan")
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
    Public Sub kelulusan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call panggildata()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        TextBox1.Text = Form1.TextBox3.Text
        TextBox2.Text = Form1.TextBox6.Text
        TextBox3.Text = Form1.TextBox8.Text
        TextBox4.Text = Form1.TextBox4.Text
        TextBox5.Text = Form1.TextBox7.Text
        TextBox6.Text = Form1.TextBox12.Text
        TextBox7.Text = Form1.TextBox11.Text
        TextBox8.Text = Form1.TextBox10.Text
        TextBox10.Text = Label20.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("maaf silahkan cek kembali data yang belum di isi")
        Else
            sqlnya = "insert into Tb_kelulusan values('" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox3.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"
            Call jalan()
            MsgBox("Data Berhasil Tersimpan")
            Call panggildata()
        End If
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox9.Text = "TUNAI" Or TextBox9.Text = "NO TUNAI" Then
            Label20.Text = "LULUS"
        Else
            Label20.Text = "tidak LULUS"
        End If
    End Sub
End Class