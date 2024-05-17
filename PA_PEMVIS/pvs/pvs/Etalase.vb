Imports MySql.Data.MySqlClient

Public Class Etalase
    Private Sub Etalase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        tampilbarang()
        aturGrid()
    End Sub

    Sub tampilbarang()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM barang", CONN)
        da.Fill(dt)
        DataGridEtalase.DataSource = dt
    End Sub

    Sub aturGrid()
        DataGridEtalase.Columns(0).Width = 60
        DataGridEtalase.Columns(1).Width = 200
        DataGridEtalase.Columns(0).HeaderText = "ID Barang"
        DataGridEtalase.Columns(1).HeaderText = "Nama Barang"
        DataGridEtalase.Columns(2).HeaderText = "Merek"
        DataGridEtalase.Columns(3).HeaderText = "Jenis Barang"
        DataGridEtalase.Columns(4).HeaderText = "Stok Barang"
        DataGridEtalase.Columns(5).HeaderText = "Harga Barang"
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If Not String.IsNullOrWhiteSpace(tbCariId.Text) Then
            TampilDetailBarang(tbCariId.Text)
        Else
            MessageBox.Show("Masukkan ID Barang yang valid.")
            ClearLabels()
        End If
    End Sub

    Private Sub TampilDetailBarang(id_barang As String)
        Dim query As String = "SELECT * FROM barang WHERE id_barang = @id_barang"
        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@id_barang", id_barang)

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    lblNama.Text = reader("nama_barang").ToString()
                    lblMerek.Text = reader("merek").ToString()
                    lblJenis.Text = reader("jenis_barang").ToString()
                    lblStok.Text = reader("stok_barang").ToString()
                    lblHarga.Text = reader("harga_barang").ToString()
                Else
                    MessageBox.Show("Data barang tidak ditemukan.")
                    ClearLabels()
                End If
            End Using
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Using
    End Sub

    Private Sub ClearLabels()
        lblNama.Text = ""
        lblMerek.Text = ""
        lblJenis.Text = ""
        lblStok.Text = ""
        lblHarga.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
