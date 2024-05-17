Imports MySql.Data.MySqlClient
Public Class FormRegistrasi
    Private Sub FormRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Dim connStr As String = "server=localhost;user=root;password=;database=tokopancing"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO akun (idUser, Username, Password, email, usertype) VALUES (DEFAULT, @Username, @Password, @email, @usertype)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", label.Text)
                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text)
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text)
                    cmd.Parameters.AddWithValue("@usertype", "user")
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

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)

    End Sub
End Class