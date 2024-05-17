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
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM barang", CONN)
        da.Fill(dt)
        DataGridViewAdmin.DataSource = dt
    End Sub
    Sub aturGrid()
        DataGridViewAdmin.Columns(0).Width = 60
        DataGridViewAdmin.Columns(1).Width = 200
        DataGridViewAdmin.Columns(0).HeaderText = "ID Barang "
        DataGridViewAdmin.Columns(1).HeaderText = "Nama Barang"
        DataGridViewAdmin.Columns(2).HeaderText = "Merek"
        DataGridViewAdmin.Columns(3).HeaderText = "Jenis Barang"
        DataGridViewAdmin.Columns(4).HeaderText = "Stok barang"
        DataGridViewAdmin.Columns(4).HeaderText = "Harga barang"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrWhiteSpace(tbTambahNama.Text) OrElse String.IsNullOrWhiteSpace(tbTambahMerek.Text) OrElse String.IsNullOrWhiteSpace(tbTambahStok.Text) OrElse String.IsNullOrWhiteSpace(tbTambahHarga.Text) Then
            MsgBox("Data Belum Lengkap")
            tbTambahNama.Focus()
        Else
            Try
                Dim query As String = "SELECT * FROM barang WHERE nama_barang = @nama_barang"
                Using cmd As New MySqlCommand(query, CONN)
                    cmd.Parameters.AddWithValue("@nama_barang", tbTambahNama.Text)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Close()
                            MsgBox("Data Tersebut Sudah Ada")
                        Else
                            reader.Close()
                            query = "INSERT INTO barang (nama_barang, merek, stok_barang, harga_barang, jenis_barang) VALUES (@nama_barang, @merek, @stok_barang, @harga_barang, @jenis_barang)"
                            Using cmdInsert As New MySqlCommand(query, CONN)
                                cmdInsert.Parameters.AddWithValue("@nama_barang", tbTambahNama.Text)
                                cmdInsert.Parameters.AddWithValue("@merek", tbTambahMerek.Text)
                                cmdInsert.Parameters.AddWithValue("@stok_barang", tbTambahStok.Text)
                                cmdInsert.Parameters.AddWithValue("@harga_barang", tbTambahHarga.Text)
                                cmdInsert.Parameters.AddWithValue("@jenis_barang", cbTambahJenis.Text)
                                cmdInsert.ExecuteNonQuery()
                            End Using
                            tampilbarang()
                            kosongGrouptambah()
                            MsgBox("Simpan Data Sukses!")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Terjadi kesalahan: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub FormUtamaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilbarang()
        aturGrid()
    End Sub
End Class
