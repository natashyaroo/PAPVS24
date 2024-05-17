Imports MySql.Data.MySqlClient
Public Class FormRegis
    Private Sub FormRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Dim connStr As String = "server=localhost;user=root;password=;database=tokopancing"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO akun (idUser, Username, Password, email, usertype, Nama, nomor_telepon) VALUES (DEFAULT, @Username, @Password, @email, @usertype, @Nama, @NomorTelepon)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", tbUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text)
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text)
                    cmd.Parameters.AddWithValue("@usertype", "user")
                    cmd.Parameters.AddWithValue("@Nama", tbNama.Text)
                    cmd.Parameters.AddWithValue("@NomorTelepon", tbNotel.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Registrasi berhasil!")
                    Me.Close()
                    FormLogin.Show()
                End Using
            Catch ex As Exception
                MessageBox.Show("Registrasi gagal: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs)
        FormLogin.Show()
        Me.Close()
    End Sub

End Class