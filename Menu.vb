Public Class Menu

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        Form1.TopLevel = False
        Panel2.Controls.Add(Form1)
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel2.Controls.Clear()
        Datadaftar.TopLevel = False
        Panel2.Controls.Add(Datadaftar)
        Datadaftar.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel2.Controls.Clear()
        statuslulus.TopLevel = False
        Panel2.Controls.Add(statuslulus)
        statuslulus.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        Datajalur.TopLevel = False
        Panel2.Controls.Add(Datajalur)
        Datajalur.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        pembayaran.TopLevel = False
        Panel2.Controls.Add(pembayaran)
        pembayaran.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel2.Controls.Clear()
        Home.TopLevel = False
        Panel2.Controls.Add(Home)
        Home.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Controls.Clear()
        Login.TopLevel = False
        Panel2.Controls.Add(Login)
        Login.Show()

    End Sub
End Class