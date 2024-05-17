
Imports MySql.Data.MySqlClient
Public Class FormLogin
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connStr As String = "server=localhost;user=root;password=;database=tokopancing"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT usertype FROM akun WHERE username = @username AND password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", tbUsernameLogin.Text)
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Dim userType As String = reader("usertype").ToString()

                            If usertype = "admin" Then
                                MessageBox.Show("Login berhasil sebagai admin!")
                                Me.Hide()
                                Dim formUtamaAdmin As New FormUtamaAdmin()
                                formUtamaAdmin.ShowDialog()

                            ElseIf usertype = "user" Then
                                MessageBox.Show("Login berhasil sebagai user!")
                                Me.Hide()
                                Dim HalamanUtamaUser As New HalamanUtamaUser()
                                HalamanUtamaUser.ShowDialog()

                            End If
                        Else
                            MessageBox.Show("Login gagal. Periksa kembali username dan password Anda.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Login gagal: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FormRegis.Show()
        Me.Hide()
    End Sub
End Class