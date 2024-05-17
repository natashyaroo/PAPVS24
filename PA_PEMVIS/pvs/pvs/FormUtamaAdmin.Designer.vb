<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtamaAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewAdmin = New System.Windows.Forms.DataGridView()
        Me.tbTambahNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTambahMerek = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTambahJenis = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTambahHarga = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbUbahHarga = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.tbUbahNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbUbahMerek = New System.Windows.Forms.TextBox()
        Me.cbUbahJenis = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.tbHapusNama = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbTambahStok = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbUbahStok = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Barang "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewAdmin
        '
        Me.DataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAdmin.Location = New System.Drawing.Point(71, 205)
        Me.DataGridViewAdmin.Name = "DataGridViewAdmin"
        Me.DataGridViewAdmin.RowHeadersWidth = 62
        Me.DataGridViewAdmin.Size = New System.Drawing.Size(458, 531)
        Me.DataGridViewAdmin.TabIndex = 2
        '
        'tbTambahNama
        '
        Me.tbTambahNama.Location = New System.Drawing.Point(20, 64)
        Me.tbTambahNama.Name = "tbTambahNama"
        Me.tbTambahNama.Size = New System.Drawing.Size(177, 25)
        Me.tbTambahNama.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(20, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(234, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Merek Barang"
        '
        'tbTambahMerek
        '
        Me.tbTambahMerek.Location = New System.Drawing.Point(234, 64)
        Me.tbTambahMerek.Name = "tbTambahMerek"
        Me.tbTambahMerek.Size = New System.Drawing.Size(177, 25)
        Me.tbTambahMerek.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(20, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jenis Barang"
        '
        'cbTambahJenis
        '
        Me.cbTambahJenis.FormattingEnabled = True
        Me.cbTambahJenis.Items.AddRange(New Object() {"Alat Pancing", "Joran", "Senar", "Mata Kail", "Pelet"})
        Me.cbTambahJenis.Location = New System.Drawing.Point(20, 142)
        Me.cbTambahJenis.Name = "cbTambahJenis"
        Me.cbTambahJenis.Size = New System.Drawing.Size(174, 26)
        Me.cbTambahJenis.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(237, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Harga Barang"
        '
        'tbTambahHarga
        '
        Me.tbTambahHarga.Location = New System.Drawing.Point(237, 143)
        Me.tbTambahHarga.Name = "tbTambahHarga"
        Me.tbTambahHarga.Size = New System.Drawing.Size(177, 25)
        Me.tbTambahHarga.TabIndex = 11
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(277, 197)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 13
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbTambahStok)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbTambahHarga)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.tbTambahNama)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbTambahMerek)
        Me.GroupBox1.Controls.Add(Me.cbTambahJenis)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(570, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 243)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Data Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbUbahStok)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbUbahHarga)
        Me.GroupBox2.Controls.Add(Me.btnUbah)
        Me.GroupBox2.Controls.Add(Me.tbUbahNama)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbUbahMerek)
        Me.GroupBox2.Controls.Add(Me.cbUbahJenis)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(570, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 243)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubah Data Barang"
        '
        'tbUbahHarga
        '
        Me.tbUbahHarga.Location = New System.Drawing.Point(237, 143)
        Me.tbUbahHarga.Name = "tbUbahHarga"
        Me.tbUbahHarga.Size = New System.Drawing.Size(177, 25)
        Me.tbUbahHarga.TabIndex = 11
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(277, 205)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 13
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'tbUbahNama
        '
        Me.tbUbahNama.Location = New System.Drawing.Point(20, 64)
        Me.tbUbahNama.Name = "tbUbahNama"
        Me.tbUbahNama.Size = New System.Drawing.Size(177, 25)
        Me.tbUbahNama.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Harga Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(20, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Barang"
        '
        'tbUbahMerek
        '
        Me.tbUbahMerek.Location = New System.Drawing.Point(234, 64)
        Me.tbUbahMerek.Name = "tbUbahMerek"
        Me.tbUbahMerek.Size = New System.Drawing.Size(177, 25)
        Me.tbUbahMerek.TabIndex = 6
        '
        'cbUbahJenis
        '
        Me.cbUbahJenis.FormattingEnabled = True
        Me.cbUbahJenis.Items.AddRange(New Object() {"Alat Pancing", "Joran", "Senar", "Mata Kail", "Pelet"})
        Me.cbUbahJenis.Location = New System.Drawing.Point(20, 142)
        Me.cbUbahJenis.Name = "cbUbahJenis"
        Me.cbUbahJenis.Size = New System.Drawing.Size(174, 26)
        Me.cbUbahJenis.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(234, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Merek Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(20, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Jenis Barang"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Controls.Add(Me.tbHapusNama)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(570, 584)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(431, 168)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hapus Data Barang"
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(174, 119)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'tbHapusNama
        '
        Me.tbHapusNama.Location = New System.Drawing.Point(133, 72)
        Me.tbHapusNama.Name = "tbHapusNama"
        Me.tbHapusNama.Size = New System.Drawing.Size(177, 25)
        Me.tbHapusNama.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(171, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Nama Barang"
        '
        'tbTambahStok
        '
        Me.tbTambahStok.Location = New System.Drawing.Point(437, 64)
        Me.tbTambahStok.Name = "tbTambahStok"
        Me.tbTambahStok.Size = New System.Drawing.Size(177, 25)
        Me.tbTambahStok.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(437, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Stok Barang"
        '
        'tbUbahStok
        '
        Me.tbUbahStok.Location = New System.Drawing.Point(440, 64)
        Me.tbUbahStok.Name = "tbUbahStok"
        Me.tbUbahStok.Size = New System.Drawing.Size(177, 25)
        Me.tbUbahStok.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(440, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Stok Barang"
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(1126, 729)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 17
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'FormUtamaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 803)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUtamaAdmin"
        Me.Text = "Form1"
        CType(Me.DataGridViewAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewAdmin As DataGridView
    Friend WithEvents tbTambahNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTambahMerek As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbTambahJenis As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTambahHarga As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbUbahHarga As TextBox
    Friend WithEvents btnUbah As Button
    Friend WithEvents tbUbahNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbUbahMerek As TextBox
    Friend WithEvents cbUbahJenis As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents tbHapusNama As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbTambahStok As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbUbahStok As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnKeluar As Button
End Class
