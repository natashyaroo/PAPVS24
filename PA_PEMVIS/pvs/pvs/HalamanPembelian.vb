Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class HalamanPembelian
    Private itemNama As String
    Private itemMerek As String
    Private itemJenis As String
    Private itemStok As Integer
    Private itemHarga As Decimal

    Private Sub HalamanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilbarang()
        aturGrid()
    End Sub

    Sub tampilbarang()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM barang", CONN)
        da.Fill(dt)
        DataGridviewPembelian.DataSource = dt
    End Sub

    Sub aturGrid()
        DataGridviewPembelian.Columns(0).Width = 60
        DataGridviewPembelian.Columns(1).Width = 200
        DataGridviewPembelian.Columns(0).HeaderText = "ID Barang"
        DataGridviewPembelian.Columns(1).HeaderText = "Nama Barang"
        DataGridviewPembelian.Columns(2).HeaderText = "Merek"
        DataGridviewPembelian.Columns(3).HeaderText = "Jenis Barang"
        DataGridviewPembelian.Columns(4).HeaderText = "Stok Barang"
        DataGridviewPembelian.Columns(5).HeaderText = "Harga Barang"
    End Sub

    Private Sub tbIdBarang_TextChanged(sender As Object, e As EventArgs) Handles tbIdBarang.TextChanged
        Dim idBarang As Integer
        If Integer.TryParse(tbIdBarang.Text, idBarang) Then
            Using cmd As New MySqlCommand("SELECT * FROM barang WHERE id_barang = @idBarang", CONN)
                cmd.Parameters.AddWithValue("@idBarang", idBarang)
                Try
                    If CONN.State = ConnectionState.Closed Then
                        CONN.Open()
                    End If

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            itemNama = reader("nama_barang").ToString()
                            itemMerek = reader("merek").ToString()
                            itemJenis = reader("jenis_barang").ToString()
                            itemStok = Convert.ToInt32(reader("stok_barang"))
                            itemHarga = Convert.ToDecimal(reader("harga_barang"))
                        Else
                            ClearItemData()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    If CONN.State = ConnectionState.Open Then
                        CONN.Close()
                    End If
                End Try
            End Using
        Else
            ClearItemData()
        End If
    End Sub

    Private Sub tbJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbJumlah.TextChanged
        Dim jumlahBeli As Integer
        If Integer.TryParse(tbJumlah.Text, jumlahBeli) Then
            If jumlahBeli <= itemStok Then
                Dim totalHarga As Decimal = jumlahBeli * itemHarga
                tbTotal.Text = totalHarga.ToString("C2")
            Else
                tbTotal.Text = "Jumlah melebihi stok!"
            End If
        Else
            tbTotal.Text = ""
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim jumlahBeli As Integer
        If Not Integer.TryParse(tbJumlah.Text, jumlahBeli) Then
            MessageBox.Show("Masukkan jumlah pembelian yang valid.")
            Return
        End If

        If jumlahBeli > itemStok Then
            MessageBox.Show("Jumlah pembelian melebihi stok barang.")
            Return
        End If

        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12)
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim footerFont As New Font("Arial", 12, FontStyle.Italic)
        Dim y As Integer = e.MarginBounds.Top
        Dim centerX As Integer = e.MarginBounds.Left + (e.MarginBounds.Width / 2)

        Dim title As String = "Struk Belanja"
        Dim titleSize As SizeF = e.Graphics.MeasureString(title, titleFont)
        Dim titleX As Integer = centerX - (titleSize.Width / 2)
        e.Graphics.DrawString(title, titleFont, Brushes.Black, titleX, y)
        y += titleSize.Height + 20

        Dim content As String
        content = "Nama Barang: " & itemNama
        e.Graphics.DrawString(content, font, Brushes.Black, e.MarginBounds.Left, y)
        y += 30
        content = "Merek: " & itemMerek
        e.Graphics.DrawString(content, font, Brushes.Black, e.MarginBounds.Left, y)
        y += 30
        content = "Jenis Barang: " & itemJenis
        e.Graphics.DrawString(content, font, Brushes.Black, e.MarginBounds.Left, y)
        y += 30
        content = "Jumlah Beli: " & tbJumlah.Text
        e.Graphics.DrawString(content, font, Brushes.Black, e.MarginBounds.Left, y)
        y += 30
        content = "Total Harga: " & tbTotal.Text
        e.Graphics.DrawString(content, font, Brushes.Black, e.MarginBounds.Left, y)
        y += 30

        Dim footer As String = "Terimakasih Sudah Berbelanja"
        Dim footerSize As SizeF = e.Graphics.MeasureString(footer, footerFont)
        Dim footerY As Integer = e.MarginBounds.Bottom - footerSize.Height
        Dim footerX As Integer = centerX - (footerSize.Width / 2)
        e.Graphics.DrawString(footer, footerFont, Brushes.Black, footerX, footerY)
    End Sub

    Private Sub ClearItemData()
        itemNama = ""
        itemMerek = ""
        itemJenis = ""
        itemStok = 0
        itemHarga = 0
        tbTotal.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
