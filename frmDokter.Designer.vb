<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDokter
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDDokter = New System.Windows.Forms.TextBox()
        Me.txtNamaDokter = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtKelamin = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(618, 96)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(608, 612)
        Me.DataGridView1.TabIndex = 0
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(76, 542)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(192, 62)
        Me.btnTambah.TabIndex = 1
        Me.btnTambah.Text = "Tambah Dokter"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(76, 638)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(192, 62)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus Dokter"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Dokter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 294)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 379)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 463)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nomor Telepon"
        '
        'txtIDDokter
        '
        Me.txtIDDokter.Enabled = False
        Me.txtIDDokter.Location = New System.Drawing.Point(298, 119)
        Me.txtIDDokter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtIDDokter.Name = "txtIDDokter"
        Me.txtIDDokter.Size = New System.Drawing.Size(238, 31)
        Me.txtIDDokter.TabIndex = 8
        '
        'txtNamaDokter
        '
        Me.txtNamaDokter.Location = New System.Drawing.Point(298, 204)
        Me.txtNamaDokter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNamaDokter.Name = "txtNamaDokter"
        Me.txtNamaDokter.Size = New System.Drawing.Size(238, 31)
        Me.txtNamaDokter.TabIndex = 9
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(298, 373)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(238, 31)
        Me.txtAlamat.TabIndex = 10
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(298, 458)
        Me.txtNoTelp.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(238, 31)
        Me.txtNoTelp.TabIndex = 12
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(348, 542)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(192, 62)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(348, 644)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(192, 62)
        Me.btnBatal.TabIndex = 14
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtKelamin
        '
        Me.txtKelamin.Location = New System.Drawing.Point(298, 291)
        Me.txtKelamin.Name = "txtKelamin"
        Me.txtKelamin.Size = New System.Drawing.Size(242, 31)
        Me.txtKelamin.TabIndex = 15
        '
        'frmDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 785)
        Me.Controls.Add(Me.txtKelamin)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtNoTelp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNamaDokter)
        Me.Controls.Add(Me.txtIDDokter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDokter"
        Me.Text = "Data Dokter"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIDDokter As TextBox
    Friend WithEvents txtNamaDokter As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtKelamin As TextBox
End Class
