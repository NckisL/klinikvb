<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPasien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIDBerobat = New System.Windows.Forms.TextBox()
        Me.txtIDPasien = New System.Windows.Forms.TextBox()
        Me.txtNamaPasien = New System.Windows.Forms.TextBox()
        Me.txtAsalKota = New System.Windows.Forms.TextBox()
        Me.cBoxUmur = New System.Windows.Forms.ComboBox()
        Me.cBoxKelamin = New System.Windows.Forms.ComboBox()
        Me.DPickerBerobat = New System.Windows.Forms.DateTimePicker()
        Me.cBoxPenatalaksanaan = New System.Windows.Forms.ComboBox()
        Me.cBoxIDDokter = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTarif = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(110, 758)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(186, 65)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(434, 758)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(186, 65)
        Me.btnBatal.TabIndex = 1
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Berobat :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Pasien :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Pasien :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 281)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Umur :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 348)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jenis Kelamin :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 415)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Asal Kota :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 483)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tanggal Berobat :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(104, 550)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Penatalaksanaan :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(181, 614)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "ID Dokter :"
        '
        'txtIDBerobat
        '
        Me.txtIDBerobat.Location = New System.Drawing.Point(348, 73)
        Me.txtIDBerobat.Margin = New System.Windows.Forms.Padding(6)
        Me.txtIDBerobat.Name = "txtIDBerobat"
        Me.txtIDBerobat.ReadOnly = True
        Me.txtIDBerobat.Size = New System.Drawing.Size(272, 31)
        Me.txtIDBerobat.TabIndex = 11
        '
        'txtIDPasien
        '
        Me.txtIDPasien.Location = New System.Drawing.Point(348, 140)
        Me.txtIDPasien.Margin = New System.Windows.Forms.Padding(6)
        Me.txtIDPasien.Name = "txtIDPasien"
        Me.txtIDPasien.ReadOnly = True
        Me.txtIDPasien.Size = New System.Drawing.Size(272, 31)
        Me.txtIDPasien.TabIndex = 12
        '
        'txtNamaPasien
        '
        Me.txtNamaPasien.Location = New System.Drawing.Point(348, 208)
        Me.txtNamaPasien.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNamaPasien.Name = "txtNamaPasien"
        Me.txtNamaPasien.Size = New System.Drawing.Size(272, 31)
        Me.txtNamaPasien.TabIndex = 13
        '
        'txtAsalKota
        '
        Me.txtAsalKota.Location = New System.Drawing.Point(348, 410)
        Me.txtAsalKota.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAsalKota.Name = "txtAsalKota"
        Me.txtAsalKota.Size = New System.Drawing.Size(272, 31)
        Me.txtAsalKota.TabIndex = 16
        '
        'cBoxUmur
        '
        Me.cBoxUmur.FormattingEnabled = True
        Me.cBoxUmur.Location = New System.Drawing.Point(348, 275)
        Me.cBoxUmur.Margin = New System.Windows.Forms.Padding(6)
        Me.cBoxUmur.Name = "cBoxUmur"
        Me.cBoxUmur.Size = New System.Drawing.Size(100, 33)
        Me.cBoxUmur.TabIndex = 20
        '
        'cBoxKelamin
        '
        Me.cBoxKelamin.FormattingEnabled = True
        Me.cBoxKelamin.Location = New System.Drawing.Point(348, 342)
        Me.cBoxKelamin.Margin = New System.Windows.Forms.Padding(6)
        Me.cBoxKelamin.Name = "cBoxKelamin"
        Me.cBoxKelamin.Size = New System.Drawing.Size(272, 33)
        Me.cBoxKelamin.TabIndex = 21
        '
        'DPickerBerobat
        '
        Me.DPickerBerobat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPickerBerobat.Location = New System.Drawing.Point(348, 471)
        Me.DPickerBerobat.Margin = New System.Windows.Forms.Padding(6)
        Me.DPickerBerobat.Name = "DPickerBerobat"
        Me.DPickerBerobat.Size = New System.Drawing.Size(192, 31)
        Me.DPickerBerobat.TabIndex = 22
        Me.DPickerBerobat.Value = New Date(2023, 7, 27, 0, 0, 0, 0)
        '
        'cBoxPenatalaksanaan
        '
        Me.cBoxPenatalaksanaan.FormattingEnabled = True
        Me.cBoxPenatalaksanaan.Location = New System.Drawing.Point(348, 544)
        Me.cBoxPenatalaksanaan.Margin = New System.Windows.Forms.Padding(6)
        Me.cBoxPenatalaksanaan.Name = "cBoxPenatalaksanaan"
        Me.cBoxPenatalaksanaan.Size = New System.Drawing.Size(272, 33)
        Me.cBoxPenatalaksanaan.TabIndex = 23
        '
        'cBoxIDDokter
        '
        Me.cBoxIDDokter.FormattingEnabled = True
        Me.cBoxIDDokter.Location = New System.Drawing.Point(348, 611)
        Me.cBoxIDDokter.Margin = New System.Windows.Forms.Padding(6)
        Me.cBoxIDDokter.Name = "cBoxIDDokter"
        Me.cBoxIDDokter.Size = New System.Drawing.Size(272, 33)
        Me.cBoxIDDokter.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(343, 674)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 25)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Tarif :"
        '
        'txtTarif
        '
        Me.txtTarif.Location = New System.Drawing.Point(440, 671)
        Me.txtTarif.Name = "txtTarif"
        Me.txtTarif.ReadOnly = True
        Me.txtTarif.Size = New System.Drawing.Size(180, 31)
        Me.txtTarif.TabIndex = 29
        '
        'frmPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 860)
        Me.Controls.Add(Me.txtTarif)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cBoxIDDokter)
        Me.Controls.Add(Me.cBoxPenatalaksanaan)
        Me.Controls.Add(Me.DPickerBerobat)
        Me.Controls.Add(Me.cBoxKelamin)
        Me.Controls.Add(Me.cBoxUmur)
        Me.Controls.Add(Me.txtAsalKota)
        Me.Controls.Add(Me.txtNamaPasien)
        Me.Controls.Add(Me.txtIDPasien)
        Me.Controls.Add(Me.txtIDBerobat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Pasien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIDBerobat As TextBox
    Friend WithEvents txtIDPasien As TextBox
    Friend WithEvents txtNamaPasien As TextBox
    Friend WithEvents txtAsalKota As TextBox
    Friend WithEvents cBoxUmur As ComboBox
    Friend WithEvents cBoxKelamin As ComboBox
    Friend WithEvents DPickerBerobat As DateTimePicker
    Friend WithEvents cBoxPenatalaksanaan As ComboBox
    Friend WithEvents cBoxIDDokter As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTarif As TextBox
End Class
