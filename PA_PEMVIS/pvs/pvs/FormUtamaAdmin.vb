Imports MySql.Data.MySqlClient
Public Class FormUtamaAdmin
    Sub kosongGrouptambah()
        tbTambahHarga.Clear()
        tbTambahMerek.Clear()
        tbTambahNama.Clear()
        tbTambahStok.Clear()
    End Sub
    Sub kosongGroupUbah()
        tbUbahHarga.Clear()
        tbUbahMerek.Clear()
        tbUbahNama.Clear()
        tbUbahStok.Clear()
    End Sub
    Sub tampilbarang()
        DataGridViewAdmin.Rows.Clear()
        CMD = New MySqlCommand("select * from barang", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridViewAdmin)
            row.Cells(0).Value = RD("id_barang")
            row.Cells(1).Value = RD("nama_barang")
            row.Cells(2).Value = RD("tipe_barang")
            row.Cells(3).Value = RD("stok_barang")
            row.Cells(4).Value = RD("harga_barang")
            DataGridViewAdmin.Rows.Add(row)
        End While
        RD.Close()
    End Sub
    Sub aturGrid()
        DataGridViewAdmin.Columns(0).Width = 60
        DataGridViewAdmin.Columns(1).Width = 200
        DataGridViewAdmin.Columns(0).HeaderText = "Nama Barang "
        DataGridViewAdmin.Columns(1).HeaderText = "Merek"
        DataGridViewAdmin.Columns(2).HeaderText = "Jenis Barang"
        DataGridViewAdmin.Columns(3).HeaderText = "Stok Barang"
        DataGridViewAdmin.Columns(4).HeaderText = "Harga"
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbTambahNama.Text = Nothing And tbTambahHarga.Text = Nothing And tbTambahMerek.Text = Nothing And tbTambahStok.Text = Nothing Then
            MsgBox("Data Belum Lengkap")
            tbTambahNama.Focus()
        Else
            CMD = New MySqlCommand("Select * from barang where id_barang = '" & tbTambahNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into barang values ('" & tbTambahNama.Text & "', '" & tbTambahMerek.Text & "', '" & tbTambahStok.Text & "', '" & tbTambahHarga.Text & "', '" & cbTambahJenis.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                tampilbarang()
                kosongGrouptambah()
                MsgBox("Simpan Data Sukses!")
            Else
                RD.Close()
                MsgBox("Data Tersebut Sudah Ada")
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class
