<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etalase
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
        Me.DataGridEtalase = New System.Windows.Forms.DataGridView()
        Me.tbCariId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblMerek = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridEtalase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridEtalase
        '
        Me.DataGridEtalase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEtalase.Location = New System.Drawing.Point(40, 121)
        Me.DataGridEtalase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridEtalase.Name = "DataGridEtalase"
        Me.DataGridEtalase.RowHeadersWidth = 62
        Me.DataGridEtalase.Size = New System.Drawing.Size(807, 770)
        Me.DataGridEtalase.TabIndex = 0
        '
        'tbCariId
        '
        Me.tbCariId.Location = New System.Drawing.Point(907, 167)
        Me.tbCariId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCariId.Multiline = True
        Me.tbCariId.Name = "tbCariId"
        Me.tbCariId.Size = New System.Drawing.Size(264, 30)
        Me.tbCariId.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(903, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cari Barang Berdasarkan ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(899, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(899, 359)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Merek"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(903, 440)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jenis Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(903, 519)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Stok Tersedia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(903, 612)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Harga Barang"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblHarga.Location = New System.Drawing.Point(1067, 612)
        Me.lblHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(16, 23)
        Me.lblHarga.TabIndex = 13
        Me.lblHarga.Text = ":"
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblStok.Location = New System.Drawing.Point(1067, 519)
        Me.lblStok.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(16, 23)
        Me.lblStok.TabIndex = 14
        Me.lblStok.Text = ":"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblJenis.Location = New System.Drawing.Point(1067, 440)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(16, 23)
        Me.lblJenis.TabIndex = 16
        Me.lblJenis.Text = ":"
        '
        'lblMerek
        '
        Me.lblMerek.AutoSize = True
        Me.lblMerek.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblMerek.Location = New System.Drawing.Point(1067, 359)
        Me.lblMerek.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMerek.Name = "lblMerek"
        Me.lblMerek.Size = New System.Drawing.Size(16, 23)
        Me.lblMerek.TabIndex = 15
        Me.lblMerek.Text = ":"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblNama.Location = New System.Drawing.Point(1067, 284)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(16, 23)
        Me.lblNama.TabIndex = 17
        Me.lblNama.Text = ":"
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(1207, 167)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(95, 30)
        Me.btnCari.TabIndex = 18
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1200, 857)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Etalase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 1014)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.lblMerek)
        Me.Controls.Add(Me.lblStok)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCariId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridEtalase)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Etalase"
        Me.Text = "etalase_toko"
        CType(Me.DataGridEtalase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridEtalase As DataGridView
    Friend WithEvents tbCariId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblMerek As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents Button1 As Button
End Class
