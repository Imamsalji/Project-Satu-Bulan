Public Class Datajalur
    Dim ket As String
    Private Sub Datajalur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("A")
        ComboBox1.Items.Add("B")
        ComboBox1.Items.Add("C")
        ComboBox1.Items.Add("D")
        ComboBox1.Items.Add("E")
        ComboBox2.Items.Add("A")
        ComboBox2.Items.Add("B")
        ComboBox2.Items.Add("C")
        ComboBox2.Items.Add("D")
        ComboBox2.Items.Add("E")
        ComboBox3.Items.Add("A")
        ComboBox3.Items.Add("B")
        ComboBox3.Items.Add("C")
        ComboBox3.Items.Add("D")
        ComboBox3.Items.Add("E")
        ComboBox4.Items.Add("A")
        ComboBox4.Items.Add("B")
        ComboBox4.Items.Add("C")
        ComboBox4.Items.Add("D")
        ComboBox4.Items.Add("E")
        ComboBox5.Items.Add("A")
        ComboBox5.Items.Add("B")
        ComboBox5.Items.Add("C")
        ComboBox5.Items.Add("D")
        ComboBox5.Items.Add("E")
        ComboBox6.Items.Add("A")
        ComboBox6.Items.Add("B")
        ComboBox6.Items.Add("C")
        ComboBox6.Items.Add("D")
        ComboBox6.Items.Add("E")
        ComboBox7.Items.Add("A")
        ComboBox7.Items.Add("B")
        ComboBox7.Items.Add("C")
        ComboBox7.Items.Add("D")
        ComboBox7.Items.Add("E")
        ComboBox8.Items.Add("A")
        ComboBox8.Items.Add("B")
        ComboBox8.Items.Add("C")
        ComboBox8.Items.Add("D")
        ComboBox8.Items.Add("E")
        ComboBox9.Items.Add("A")
        ComboBox9.Items.Add("B")
        ComboBox9.Items.Add("C")
        ComboBox9.Items.Add("D")
        ComboBox9.Items.Add("E")
        ComboBox10.Items.Add("A")
        ComboBox10.Items.Add("B")
        ComboBox10.Items.Add("C")
        ComboBox10.Items.Add("D")
        ComboBox10.Items.Add("E")
        If nil Or nal <= 40 Then
            ket = "LULUS"
        Else
            ket = "Tidak LULUS"
        End If
        kelulusan.Label20.Text = ket
        Button3.Enabled = False
    End Sub
    Dim nil As Integer
    Dim nal As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox6.Text = "" Or ComboBox7.Text = "" Or ComboBox8.Text = "" Or ComboBox9.Text = "" Or ComboBox10.Text = "" Then
            MsgBox("isi yang kosong terlebih dahulu")
        Else
            If ComboBox1.Text = "B" Then
                nal += 10
            End If
            If ComboBox2.Text = "A" Then
                nal += 10
            End If
            If ComboBox3.Text = "C" Then
                nal += 10
            End If
            If ComboBox4.Text = "B" Then
                nal += 10
            End If
            If ComboBox5.Text = "C" Then
                nal += 10
            End If
            If ComboBox6.Text = "E" Then
                nal += 10
            End If
            If ComboBox7.Text = "B" Then
                nal += 10
            End If
            If ComboBox8.Text = "E" Then
                nal += 10
            End If
            If ComboBox9.Text = "B" Then
                nal += 10
            End If
            If ComboBox10.Text = "B" Then
                nal += 10
            End If
            If nil Or nal <= 40 Then
                ket = "LULUS"
            Else
                ket = "Tidak LULUS"
            End If
            kelulusan.Label20.Text = ket
            Form1.TextBox10.Text = "sudah test"
            Form1.TextBox10.Enabled = False
            MsgBox("Hasil Test Telah Dikirim")
            Button1.Enabled = False
            Button3.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox6.Text = "" Or ComboBox7.Text = "" Or ComboBox8.Text = "" Or ComboBox9.Text = "" Or ComboBox10.Text = "" Then
            MsgBox("isi yang kosong terlebih dahulu")
        Else
            dalamlogin.Panel1.Controls.Clear()
            Form1.TopLevel = False
            dalamlogin.Panel1.Controls.Add(Form1)
            Form1.Show()
        End If

    End Sub
End Class