Imports System.Data.OleDb
Public Class daftar
    Dim sqlnya As String

    Sub panggildata()
        konek()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM akun", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "akun")
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
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub daftar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call panggildata()
        ComboBox1.Items.Add("Laki-laki")
        ComboBox1.Items.Add("Perempuan")
        ComboBox2.Items.Add("islam")
        ComboBox2.Items.Add("kristen")
        ComboBox2.Items.Add("hindu")
        ComboBox2.Items.Add("budha")
        ComboBox2.Items.Add("khong hu cu")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox7.Text <> TextBox8.Text Then
            MsgBox("Password tidak sesuai")
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ";"
        Else
            sqlnya = "INSERT into akun values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox2.Text & "')"
            Call jalan()
            MsgBox("Akun Telah Terbuat")
            Call panggildata()
            Hide()

        End If
    End Sub

 
End Class