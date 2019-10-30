Public Class hasildaftar

    Private Sub hasildaftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.TextBox3.Text
        TextBox2.Text = Form1.TextBox6.Text
        TextBox3.Text = Form1.TextBox8.Text
        TextBox4.Text = Form1.TextBox4.Text
        TextBox5.Text = Form1.TextBox7.Text
        TextBox6.Text = Form1.TextBox12.Text
        TextBox7.Text = Form1.TextBox11.Text
        If TextBox1.Text = Form1.TextBox3.Text Or TextBox2.Text = Form1.TextBox6.Text Or TextBox3.Text = Form1.TextBox8.Text Or TextBox4.Text = Form1.TextBox4.Text Or TextBox5.Text = Form1.TextBox7.Text Or TextBox6.Text = Form1.TextBox12.Text Or TextBox7.Text = Form1.TextBox11.Text Then
            Label8.Text = "Selamat anda sudah terdaftar silahkan lanjutkan"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dalamlogin.Panel1.Controls.Clear()
        pembayaran.TopLevel = False
        dalamlogin.Panel1.Controls.Add(pembayaran)
        pembayaran.Show()
    End Sub
End Class