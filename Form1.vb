Imports System.Drawing.Bitmap
Public Class Form1
    Dim sqlnya As String
    Sub auto()

        Call konek()
        cmd = New OleDb.OleDbCommand("select * from Db_Daftar order by NO_PENDAFTARAN desc", con)
        rd = cmd.ExecuteReader
        rd.Read()

        If Not rd.HasRows Then
            TextBox1.Text = "Ps01"
        Else
            TextBox1.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("NO_PENDAFTARAN").ToString, 3, 2)) + 1
            If Len(TextBox1.Text) = 1 Then
                TextBox1.Text = "Ps0" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 2 Then
                TextBox1.Text = "Ps" & TextBox1.Text & ""
            ElseIf Len(TextBox1.Text) = 3 Then
                TextBox1.Text = "P" & TextBox1.Text & ""
            End If
        End If

    End Sub
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
        OpenFileDialog1.Title = "masukan foto anda"
        OpenFileDialog1.Filter = "JPEG FILE | *.jpg;*.jpeg "
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub
    Dim lahir As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call panggildata()
        Call konek()
        ComboBox1.Items.Add("Laki-Laki")
        ComboBox1.Items.Add("Perempuan")
        ComboBox2.Items.Add("islam")
        ComboBox2.Items.Add("kristen")
        ComboBox2.Items.Add("hindu")
        ComboBox2.Items.Add("budha")
        ComboBox2.Items.Add("khong hu cu")
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        TextBox6.Enabled = False
        TextBox8.Enabled = False
        lahir = TextBox5.Text + TextBox6.Text

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox3.Text <> dalamlogin.TextBox1.Text Then
            MsgBox("daftar sudah ada yang punya")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox3.Text = dalamlogin.TextBox1.Text
        Else
            If TextBox1.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Then
                MsgBox("Silahkan isi terlebih dahulu yang kosong")
            Else
                sqlnya = "insert into Db_Daftar values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox12.Text & "','" & TextBox11.Text & "')"
                Call jalan()
                MsgBox("Data Berhasil Tersimpan")
                Call panggildata()
                dalamlogin.Panel1.Controls.Clear()
                hasildaftar.TopLevel = False
                dalamlogin.Panel1.Controls.Add(hasildaftar)
                hasildaftar.Show()
                Button1.Enabled = False
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text <> dalamlogin.TextBox1.Text Then
            MsgBox("data bukan milik anda")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox3.Text = dalamlogin.TextBox1.Text
        Else
            sqlnya = "UPDATE Db_Daftar set NAMA_LENGKAP='" & TextBox3.Text & "',TGL_PENDAFTARAN='" & TextBox2.Text & "',JENIS_KELAMIN='" & TextBox4.Text & "',TEMPAT_LAHIR='" & TextBox5.Text & "',TGL_LAHIR='" & TextBox6.Text & "',ALAMAT='" & TextBox7.Text & "',AGAMA='" & TextBox8.Text & "',NILAI_UAN='" & TextBox10.Text & "',ASAL_SEKOLAH='" & TextBox9.Text & "' where NO_PENDAFTARAN='" & TextBox1.Text & "'"
            Call jalan()
            MsgBox("Data Berhasil Terubah")
            Call panggildata()
        End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text <> dalamlogin.TextBox1.Text Then
            MsgBox("data tidak dapat di hapus karna data milik orang")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox3.Text = dalamlogin.TextBox1.Text
        Else
            sqlnya = "delete from Db_Daftar where NO_PENDAFTARAN='" & TextBox1.Text & "'"
            Call jalan()
            MsgBox("Data Berhasil Terhapus")
            Call panggildata()
        End If 
    End Sub

    Private Sub TextBox19_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM Db_Daftar where NAMA_LENGKAP like '%" & TextBox19.Text & "%'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Db_Daftar")
        DataGridView1.DataSource = ds.Tables("Db_Daftar")
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i = DataGridView1.NewRowIndex Then
            MsgBox("Data Tidak ada")
        Else
            TextBox1.Text = DataGridView1.Item(0, i).Value
            TextBox2.Text = DataGridView1.Item(1, i).Value
            TextBox3.Text = DataGridView1.Item(2, i).Value
            TextBox4.Text = DataGridView1.Item(3, i).Value
            TextBox5.Text = DataGridView1.Item(4, i).Value
            TextBox6.Text = DataGridView1.Item(5, i).Value
            TextBox7.Text = DataGridView1.Item(6, i).Value
            TextBox8.Text = DataGridView1.Item(7, i).Value
            TextBox9.Text = DataGridView1.Item(8, i).Value
            TextBox10.Text = DataGridView1.Item(9, i).Value
            TextBox12.Text = DataGridView1.Item(10, i).Value
            TextBox11.Text = DataGridView1.Item(11, i).Value
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox2.Text = DateTimePicker1.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox4.Text = ComboBox1.Text
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        TextBox6.Text = DateTimePicker2.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox8.Text = ComboBox2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog Then
            PictureBox1.Image = FromFile(OpenFileDialog1.FileName)
            Call CheckBox1_CheckedChanged(sender, e)
            Label13.Text = "Nama file:" & OpenFileDialog1.FileName
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        kelulusan.PictureBox1.Image = PictureBox1.Image
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call auto()
    End Sub

End Class