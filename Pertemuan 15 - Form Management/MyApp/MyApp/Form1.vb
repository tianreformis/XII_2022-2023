Public Class Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MsgBox("Yakin Keluar", MsgBoxStyle.DefaultButton1, AcceptButton)
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblTampilNama.Text = txtNama.Text
        lblTampilAlamat.Text = txtAlamat.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblTampilNama.Text = ""
        txtNama.Text = ""
        lblTampilAlamat.Text = ""
        txtAlamat.Text = ""
    End Sub

    Private Sub btnTampilData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
