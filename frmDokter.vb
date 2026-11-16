Imports MySql.Data.MySqlClient
Public Class frmDokter
    Dim strQuery As String
    Dim cmd As New MySqlCommand()
    Dim ask As DialogResult
    Dim i As Integer

    Sub ShowData()
        DataGridView1.DataSource = " "
        Dim bdSource As New BindingSource
        Try
            Dim sql As String = "SELECT * FROM dbpasien.tbldokter;"
            cmd = New MySqlCommand(sql, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt = New DataTable()
            da.Fill(dt)
            bdSource.DataSource = dt
            With DataGridView1
                .DataSource = bdSource
                .Columns(0).Width = 70
                .Columns(0).HeaderText = "ID Dokter"
                .Columns(1).HeaderText = "Nama Dokter"
                .Columns(2).HeaderText = "Jenis Kelamin"
                .Columns(3).HeaderText = "Alamat"
                .Columns(4).HeaderText = "No. Telp"
                .BorderStyle = BorderStyle.Fixed3D
                .AllowUserToAddRows = False
            End With
            DataGridView1.DataSource = bdSource
        Catch ex As Exception
            MessageBox.Show("Database tidak terkoneksi")
        End Try
    End Sub

    Sub ClearField()
        txtIDDokter.Clear()
        txtNamaDokter.Clear()
        txtKelamin.Clear()
        txtAlamat.Clear()
        txtNoTelp.Clear()
    End Sub
    Sub DisableField()
        txtIDDokter.Enabled = False
        txtNamaDokter.Enabled = False
        txtKelamin.Enabled = False
        txtAlamat.Enabled = False
        txtNoTelp.Enabled = False
    End Sub
    Sub EnableField()
        txtIDDokter.Enabled = True
        txtNamaDokter.Enabled = True
        txtKelamin.Enabled = True
        txtAlamat.Enabled = True
        txtNoTelp.Enabled = True
    End Sub

    Sub fillIdDokter()
        Dim idDokter As String
        Dim numDokter As Integer
        Dim rd As MySqlDataReader

        strQuery = String.Empty
        strQuery = "SELECT * FROM tbldokter ORDER BY IDDokter DESC"
        cmd = New MySqlCommand(strQuery, conn)
        rd = cmd.ExecuteReader

        If rd.HasRows = False Then
            txtIDDokter.Text = "D001"
        Else
            rd.Read()
            idDokter = rd("IDDokter").ToString
            numDokter = Val(idDokter.Substring(idDokter.Length - 3))
            numDokter += 1
            txtIDDokter.Text = "D" & numDokter.ToString("000")
        End If
        txtIDDokter.Enabled = False
        rd.Close()
    End Sub

    Private Sub frmDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        ShowData()
        DisableField()
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ClearField()
        EnableField()
        btnHapus.Enabled = False
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        fillIdDokter()
        txtNamaDokter.Focus()
    End Sub



    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearField()
        DisableField()
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambah.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            strQuery = String.Empty
            strQuery = "INSERT INTO tbldokter (IDDokter, NamaDokter, JenisKelamin, Alamat, NoTelp) VALUES" & "('" & txtIDDokter.Text & "'," &
            "'" & txtNamaDokter.Text & "'," & "'" & txtKelamin.Text & "'," & "'" & txtAlamat.Text & "', '" & txtNoTelp.Text & "');"

            If txtIDDokter.Text = "" Then
                MessageBox.Show("ID Dokter belum diisi!")
                txtNamaDokter.Focus()
            ElseIf txtNamaDokter.Text = "" Then
                MessageBox.Show("Nama Dokter belum diisi!")
                txtNamaDokter.Focus()
            ElseIf txtKelamin.Text = "" Then
                MessageBox.Show("Jenis Kelamin belum diisi!")
                txtNamaDokter.Focus()
            ElseIf txtAlamat.Text = "" Then
                MessageBox.Show("Alamat belum diisi!")
                txtNamaDokter.Focus()
            ElseIf txtNoTelp.Text = "" Then
                MessageBox.Show("NoTelp belum diisi!")
                txtNamaDokter.Focus()
            Else
                Dim cmd As New MySqlCommand(strQuery, conn)
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Data dokter sudah disimpan")
                Else
                    MessageBox.Show("Data dokter gagal disimpan")
                End If
            End If
        ElseIf btnSimpan.Text = "Ubah" Then
            strQuery = String.Empty
            strQuery = "UPDATE tbldokter SET " & "IDDokter = '" & txtIDDokter.Text & "'," &
                "NamaDokter = '" & txtNamaDokter.Text & "'," &
                "JenisKelamin = '" & txtKelamin.Text & "'," &
                "Alamat = '" & txtAlamat.Text & "'," &
                "NoTelp = '" & txtNoTelp.Text & "'" &
                " WHERE IDDokter = '" & txtIDDokter.Text & "'"
            cmd = New MySqlCommand(strQuery, conn)
            ask = MsgBox("Apakah anda yakin ingin mengubah data dokter : " & txtIDDokter.Text & "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = DialogResult.Yes Then
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Data dokter telah diubah")
                Else
                    MessageBox.Show("Data dokter gagal diubah")
                End If
            ElseIf ask = DialogResult.No Then
                MessageBox.Show("Data dokter batal diubah")
            End If
            btnSimpan.Text = "Simpan"
        End If


        ShowData()
        ClearField()
        DisableField()
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
        btnTambah.Enabled = True

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        strQuery = String.Empty
        strQuery = "DELETE FROM tbldokter WHERE IDDokter= '" & txtIDDokter.Text & "'"
        cmd = New MySqlCommand(strQuery, conn)
        ask = MsgBox("Apakah anda yakin ingin menghapus data dokter : " & txtIDDokter.Text & "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = DialogResult.Yes Then
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Data dokter telah dihapus")
            Else
                MessageBox.Show("Data dokter gagal dihapus")
            End If
        ElseIf ask = DialogResult.No Then
            MessageBox.Show("Data dokter batal dihapus")
        End If
        ShowData()
        ClearField()
        DisableField()
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ClearField()
        EnableField()
        btnTambah.Enabled = False
        btnSimpan.Enabled = True
        btnHapus.Enabled = True
        btnBatal.Enabled = True
        Dim i As Integer = DataGridView1.CurrentRow.Index
        txtIDDokter.Text = DataGridView1.Item(0, i).Value
        txtNamaDokter.Text = DataGridView1.Item(1, i).Value
        txtKelamin.Text = DataGridView1.Item(2, i).Value
        txtAlamat.Text = DataGridView1.Item(3, i).Value
        txtNoTelp.Text = DataGridView1.Item(3, i).Value
        txtIDDokter.Enabled = False
        txtNamaDokter.Focus()
        btnSimpan.Text = "Ubah"
    End Sub


End Class