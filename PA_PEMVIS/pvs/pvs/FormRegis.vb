Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class FormRegis
    Private Sub FormRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click

        If String.IsNullOrWhiteSpace(tbUsername.Text) Then
            MessageBox.Show("Username harus diisi.")
            tbUsername.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(tbPassword.Text) Then
            MessageBox.Show("Password harus diisi.")
            tbPassword.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(tbEmail.Text) Then
            MessageBox.Show("Email harus diisi.")
            tbEmail.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(tbNama.Text) Then
            MessageBox.Show("Nama harus diisi.")
            tbNama.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(tbNotel.Text) Then
            MessageBox.Show("Nomor telepon harus diisi.")
            tbNotel.Focus()
            Exit Sub
        End If
        If Not Regex.IsMatch(tbNotel.Text, "^\d{12}$") Then
            MessageBox.Show("Nomor telepon harus terdiri dari 12 digit angka.")
            tbNotel.Focus()
            Exit Sub
        End If

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

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub tbNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
            MessageBox.Show("Nama hanya dapat berisi huruf dan spasi.")
        End If
    End Sub

    Private Sub tbNotel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNotel.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbNotel_Leave(sender As Object, e As EventArgs) Handles tbNotel.Leave
        If Not Regex.IsMatch(tbNotel.Text, "^\d{12}$") Then
            MessageBox.Show("Nomor telepon harus terdiri dari 12 digit angka.")
            tbNotel.Focus()
        End If
    End Sub
End Class
