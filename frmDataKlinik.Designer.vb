<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDataKlinik
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
        Me.btnTambahPasien = New System.Windows.Forms.Button()
        Me.btnHapusPasien = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fileDataDokter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUbahPasien = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTambahPasien
        '
        Me.btnTambahPasien.Location = New System.Drawing.Point(35, 79)
        Me.btnTambahPasien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTambahPasien.Name = "btnTambahPasien"
        Me.btnTambahPasien.Size = New System.Drawing.Size(90, 40)
        Me.btnTambahPasien.TabIndex = 0
        Me.btnTambahPasien.Text = "Tambah Pasien"
        Me.btnTambahPasien.UseVisualStyleBackColor = True
        '
        'btnHapusPasien
        '
        Me.btnHapusPasien.Location = New System.Drawing.Point(147, 79)
        Me.btnHapusPasien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHapusPasien.Name = "btnHapusPasien"
        Me.btnHapusPasien.Size = New System.Drawing.Size(90, 40)
        Me.btnHapusPasien.TabIndex = 1
        Me.btnHapusPasien.Text = "Hapus Pasien"
        Me.btnHapusPasien.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileDataDokter, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'fileDataDokter
        '
        Me.fileDataDokter.Name = "fileDataDokter"
        Me.fileDataDokter.Size = New System.Drawing.Size(136, 22)
        Me.fileDataDokter.Text = "Data &Dokter"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 140)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(727, 293)
        Me.DataGridView1.TabIndex = 3
        '
        'btnUbahPasien
        '
        Me.btnUbahPasien.Location = New System.Drawing.Point(259, 79)
        Me.btnUbahPasien.Name = "btnUbahPasien"
        Me.btnUbahPasien.Size = New System.Drawing.Size(90, 40)
        Me.btnUbahPasien.TabIndex = 10
        Me.btnUbahPasien.Text = "Ubah Data Pasien"
        Me.btnUbahPasien.UseVisualStyleBackColor = True
        '
        'frmDataKlinik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 455)
        Me.Controls.Add(Me.btnUbahPasien)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnHapusPasien)
        Me.Controls.Add(Me.btnTambahPasien)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frmDataKlinik"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Klinik"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTambahPasien As Button
    Friend WithEvents btnHapusPasien As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnUbahPasien As Button
    Friend WithEvents fileDataDokter As ToolStripMenuItem
End Class
