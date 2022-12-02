Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnHasilKurang_Click(sender As Object, e As EventArgs) Handles btnHasilKurang.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(txtAngka1.Text)
        angka2 = Val(txtAngka2.Text)
        hasil = angka1 - angka2
        txtHasil.Text = hasil
    End Sub
End Class