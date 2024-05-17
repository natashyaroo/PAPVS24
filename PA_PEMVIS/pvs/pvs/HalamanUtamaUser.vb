Public Class HalamanUtamaUser
    Private Sub HalamanUtamaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()

    End Sub


    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        Me.Hide()
        HalamanPembelian.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Etalase.Show()
    End Sub


End Class