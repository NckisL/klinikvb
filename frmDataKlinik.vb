Imports MySql.Data.MySqlClient
Public Class frmDataKlinik
    Dim strQuery As String
    Dim cmd As New MySqlCommand()
    Dim ask As DialogResult
    Dim i As Integer
    Dim j As Integer


    Sub ShowDataKlinik()
        DataGridView1.DataSource = " "
        Dim bdSource As New BindingSource
        Try
            Dim sql As String = "SELECT berobat.IDBerobat, pasien.IDPasien, pasien.NamaPasien, pasien.Umur, 
                            pasien.JenisKelamin, pasien.AsalKota, berobat.TglBerobat, berobat.penatalaksanaan,
                            dokter.IDDokter, dokter.NamaDokter, tarif.Tarif FROM tblberobat berobat 
                            JOIN tblpasien pasien ON berobat.IDPasien = pasien.IDPasien 
                            JOIN tbldokter dokter ON berobat.IDDokter = dokter.IDDokter
                            JOIN tbltarif tarif ON berobat.penatalaksanaan = tarif.penatalaksanaan;"
            cmd = New MySqlCommand(sql, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            da.Fill(dt)
            bdSource.DataSource = dt
            With DataGridView1
                .DataSource = bdSource
                .Columns(0).Width = 100
                .Columns(0).HeaderText = "ID Berobat"
                .Columns(1).HeaderText = "ID Pasien"
                .Columns(2).HeaderText = "Nama Pasien"
                .Columns(3).HeaderText = "Umur"
                .Columns(4).HeaderText = "Jenis Kelamin"
                .Columns(5).HeaderText = "Asal Kota"
                .Columns(6).HeaderText = "Tanggal Berobat"
                .Columns(7).HeaderText = "Penatalaksanaan"
                .Columns(8).HeaderText = "ID Dokter"
                .Columns(9).HeaderText = "Nama Dokter"
                .Columns(10).HeaderText = "Tarif Pasien"
                .BorderStyle = BorderStyle.Fixed3D
                .AllowUserToAddRows = False

            End With
            DataGridView1.DataSource = bdSource
        Catch ex As Exception
            MessageBox.Show("Database tidak terkoneksi")
        End Try
    End Sub

    Private Sub frmDataKlinik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        ShowDataKlinik()
        btnHapusPasien.Enabled = False
        btnUbahPasien.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub fileDataDokter_Click(sender As Object, e As EventArgs) Handles fileDataDokter.Click
        Dim fileDataDokter As New frmDokter
        fileDataDokter.ShowDialog()
    End Sub

    Private Sub btnTambahPasien_Click(sender As Object, e As EventArgs) Handles btnTambahPasien.Click
        frmPasien.ClearField()
        frmPasien.fillIdBerobat()
        frmPasien.fillIdPasien()
        frmPasien.ShowDialog()

    End Sub

    Private Sub btnUbahPasien_Click(sender As Object, e As EventArgs) Handles btnUbahPasien.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex

        Dim idBerobat As String = DataGridView1.Rows(i).Cells(0).Value.ToString()
        Dim idPasien As String = DataGridView1.Rows(i).Cells(1).Value.ToString()
        Dim namaPasien As String = DataGridView1.Rows(i).Cells(2).Value.ToString()
        Dim umur As String = DataGridView1.Rows(i).Cells(3).Value.ToString()
        Dim jenisKelamin As String = DataGridView1.Rows(i).Cells(4).Value.ToString()
        Dim asalKota As String = DataGridView1.Rows(i).Cells(5).Value.ToString()
        Dim tglBerobat As String = DataGridView1.Rows(i).Cells(6).Value.ToString()
        Dim penatalaksanaan As String = DataGridView1.Rows(i).Cells(7).Value.ToString()
        Dim idDokter As String = DataGridView1.Rows(i).Cells(8).Value.ToString()

        Dim frmpasien As New frmPasien()

        frmpasien.btnSimpan.Text = "Ubah"
        frmpasien.SetData(idBerobat, idPasien, namaPasien, umur, jenisKelamin, asalKota, tglBerobat, penatalaksanaan, idDokter)
        frmpasien.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnHapusPasien.Enabled = True
        btnUbahPasien.Enabled = True
        frmPasien.ClearField()
    End Sub

    Private Sub btnHapusPasien_Click(sender As Object, e As EventArgs) Handles btnHapusPasien.Click
        Dim j As Integer = DataGridView1.CurrentRow.Index
        Dim idBerobat As String = DataGridView1.Item(0, j).Value
        Dim idPasien As String = DataGridView1.Item(1, j).Value
        strQuery = String.Empty
        strQuery = "DELETE FROM tblpasien WHERE IDPasien = '" & idPasien & "';" &
            " DELETE FROM tblberobat WHERE IDBerobat = '" & idBerobat & "';"
        cmd = New MySqlCommand(strQuery, conn)

        ask = MsgBox("Apakah anda yakin ingin menghapus data pasien : " & idPasien & "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = DialogResult.Yes Then
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Data pasien telah dihapus")
            Else
                MessageBox.Show("Data pasien gagal dihapus")
            End If
        ElseIf ask = DialogResult.No Then
            MessageBox.Show("Data pasien batal dihapus")
        End If

        ShowDataKlinik()
        btnHapusPasien.Enabled = False
        btnUbahPasien.Enabled = False

    End Sub

    Private Sub frmDataKlinik_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        DisconnectDatabase()
    End Sub
End Class
