Imports MySql.Data.MySqlClient

Public Class Etalase
    Private Sub Etalase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        tampilbarang()
    End Sub
    Private Sub tampilbarang()
        DataGridEtalase.Rows.Clear()
        Module1.CMD = New MySqlCommand("SELECT * FROM barang ", Module1.CONN)
        Module1.RD = Module1.CMD.ExecuteReader()
        While Module1.RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridEtalase)
            row.Cells(0).Value = Module1.RD("id_barang")
            row.Cells(1).Value = Module1.RD("nama_barang")
            row.Cells(2).Value = Module1.RD("jenis_barang")
            row.Cells(3).Value = Module1.RD("stok_barang")
            row.Cells(4).Value = Module1.RD("harga_barang")
            DataGridEtalase.Rows.Add(row)
        End While

        Module1.RD.Close()

    End Sub
End Class