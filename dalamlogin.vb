Public Class dalamlogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Panel1.Controls.Clear()
        Form1.TopLevel = False
        Panel1.Controls.Add(Form1)
        Form1.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel1.Controls.Clear()
        Datajalur.TopLevel = False
        Panel1.Controls.Add(Datajalur)
        Datajalur.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel1.Controls.Clear()
        pembayaran.TopLevel = False
        Panel1.Controls.Add(pembayaran)
        pembayaran.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Controls.Clear()
        kelulusan.TopLevel = False
        Panel1.Controls.Add(kelulusan)
        kelulusan.Show()
    End Sub
    Dim b As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        b = TextBox1.Text
        Form1.TextBox3.Text = b
        pembayaran.TextBox6.Text = b
        pembayaran.TextBox6.Enabled = False
        Form1.TextBox3.Enabled = False
        Panel1.Controls.Clear()
        Datajalur.TopLevel = False
        Panel1.Controls.Add(Datajalur)
        Datajalur.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Controls.Clear()
        hasildaftar.TopLevel = False
        Panel1.Controls.Add(hasildaftar)
        hasildaftar.Show()
    End Sub
End Class