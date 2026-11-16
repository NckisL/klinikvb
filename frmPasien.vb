Imports MySql.Data.MySqlClient
Public Class frmPasien
    Dim strQuery As String
    Dim cmd As New MySqlCommand()
    Dim ask As DialogResult
    Dim i As Integer

    Public Sub SetData(idBerobat As String, idPasien As String, namaPasien As String, umur As String, jenisKelamin As String, asalKota As String, tglBerobat As String, penatalaksanaan As String, idDokter As String)
        txtIDBerobat.Text = idBerobat
        txtIDPasien.Text = idPasien
        txtNamaPasien.Text = namaPasien
        cBoxUmur.Text = umur
        cBoxKelamin.Text = jenisKelamin
        txtAsalKota.Text = asalKota
        DPickerBerobat.Text = tglBerobat
        cBoxPenatalaksanaan.Text = penatalaksanaan
        cBoxIDDokter.Text = idDokter
    End Sub

    Sub ComboBox()
        For i As Integer = 1 To 99
            cBoxUmur.Items.Add(i.ToString())
        Next i

        cBoxKelamin.Items.Add("Laki - Laki")
        cBoxKelamin.Items.Add("Perempuan")

        cBoxPenatalaksanaan.Items.Add("Rawat Jalan")
        cBoxPenatalaksanaan.Items.Add("Rawat Inap")
        cBoxPenatalaksanaan.Items.Add("Rujuk")
        cBoxPenatalaksanaan.Items.Add("Konsul")
        cBoxPenatalaksanaan.Items.Add("Rawat Jalan (Asuransi)")
        cBoxPenatalaksanaan.Items.Add("Rawat Inap (Asuransi)")
        cBoxPenatalaksanaan.Items.Add("Rujuk (Asuransi)")
        cBoxPenatalaksanaan.Items.Add("Konsul (Asuransi)")

        Dim sql As String = "SELECT IDDokter FROM tbldokter;"
        cmd = New MySqlCommand(sql, conn)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cBoxIDDokter.Items.Add(reader("IDDokter").ToString())
        End While
        reader.Close()

    End Sub

    Function getTarif() As Integer

        If cBoxPenatalaksanaan.Text = "Rawat Jalan" Then
            txtTarif.Text = "100000"
        ElseIf cBoxPenatalaksanaan.Text = "Rawat Inap" Then
            txtTarif.Text = "50000"
        ElseIf cBoxPenatalaksanaan.Text = "Rujuk" Then
            txtTarif.Text = "15000"
        ElseIf cBoxPenatalaksanaan.Text = "Konsul" Then
            txtTarif.Text = "20000"
        ElseIf cBoxPenatalaksanaan.Text = "Rawat Jalan (Asuransi)" Then
            txtTarif.Text = "65000"
        ElseIf cBoxPenatalaksanaan.Text = "Rawat Inap (Asuransi)" Then
            txtTarif.Text = "29000"
        ElseIf cBoxPenatalaksanaan.Text = "Rujuk (Asuransi)" Then
            txtTarif.Text = "8000"
        ElseIf cBoxPenatalaksanaan.Text = "Konsul (Asuransi)" Then
            txtTarif.Text = "12000"
        End If

    End Function
    Public Sub fillIdBerobat()
        Dim idBerobat As String
        Dim numBerobat As Integer
        Dim rd As MySqlDataReader

        strQuery = String.Empty
        strQuery = "SELECT * FROM tblberobat ORDER BY IDBerobat DESC"
        cmd = New MySqlCommand(strQuery, conn)
        rd = cmd.ExecuteReader

        If rd.HasRows = False Then
            txtIDBerobat.Text = "100101"
        Else
            rd.Read()
            idBerobat = rd("IDBerobat").ToString
            numBerobat = Val(idBerobat.Substring(idBerobat.Length - 6))
            numBerobat += 1
            txtIDBerobat.Text = numBerobat.ToString("000000")
        End If
        rd.Close()
    End Sub
    Public Sub fillIdPasien()
        Dim idPasien As String
        Dim numPasien As Integer
        Dim rd As MySqlDataReader

        strQuery = String.Empty
        strQuery = "SELECT * FROM tblpasien ORDER BY IDPasien DESC"
        cmd = New MySqlCommand(strQuery, conn)
        rd = cmd.ExecuteReader

        If rd.HasRows = False Then
            txtIDPasien.Text = "P001"
        Else
            rd.Read()
            idPasien = rd("IDPasien").ToString
            numPasien = Val(idPasien.Substring(idPasien.Length - 3))
            numPasien += 1
            txtIDPasien.Text = "P" & numPasien.ToString("000")
        End If
        rd.Close()
    End Sub

    Sub ClearField()
        txtIDBerobat.Clear()
        txtIDPasien.Clear()
        txtNamaPasien.Clear()
        txtAsalKota.Clear()
        cBoxKelamin.Items.Clear()
        cBoxPenatalaksanaan.Items.Clear()
        cBoxIDDokter.Items.Clear()
        cBoxUmur.Items.Clear()
    End Sub

    Private Sub frmPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        ComboBox()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim DateFormat As String = DPickerBerobat.Value.ToString("yyyy-MM-dd")
        If btnSimpan.Text = "Simpan" Then
            strQuery = String.Empty
            strQuery = "INSERT INTO tblpasien (IDPasien, NamaPasien, Umur, JenisKelamin, AsalKota) 
            VALUES" & "('" & txtIDPasien.Text & "'," & "'" & txtNamaPasien.Text &
            "'," & "'" & cBoxUmur.Text & "'," & "'" & cBoxKelamin.Text & "'," & "'" & txtAsalKota.Text & "');" &
            " INSERT INTO tblberobat (IDBerobat, IDPasien, IDDokter, TglBerobat, penatalaksanaan) 
            VALUES" & "('" & txtIDBerobat.Text & "'," & "'" & txtIDPasien.Text & "'," & "'" & cBoxIDDokter.Text &
            "'," & "'" & DateFormat & "'," & "'" & cBoxPenatalaksanaan.Text & "');"

            If txtNamaPasien.Text = "" Then
                MessageBox.Show("Nama Pasien belum diisi!")
                txtIDBerobat.Focus()
            ElseIf cBoxUmur.Text = "" Then
                MessageBox.Show("Umur belum diisi!")
                txtIDBerobat.Focus()
            ElseIf cBoxKelamin.Text = "" Then
                MessageBox.Show("Jenis Kelamin belum diisi!")
                txtIDBerobat.Focus()
            ElseIf txtAsalKota.Text = "" Then
                MessageBox.Show("Asal Kota belum diisi!")
                txtIDBerobat.Focus()
            Else
                Dim cmd As New MySqlCommand(strQuery, conn)
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Data pasien sudah disimpan")
                Else
                    MessageBox.Show("Data pasien gagal disimpan")
                End If

            End If
        ElseIf btnSimpan.Text = "Ubah" Then
            strQuery = String.Empty
            strQuery = "UPDATE tblpasien SET " & "IDPasien = '" & txtIDPasien.Text & "'," &
            "NamaPasien = '" & txtNamaPasien.Text & "'," & "Umur = '" & cBoxUmur.Text & "'," &
            "JenisKelamin = '" & cBoxKelamin.Text & "'," & "AsalKota = '" & txtAsalKota.Text &
            "'" & " WHERE IDPasien = '" & txtIDPasien.Text & "';" &
            " UPDATE tblberobat SET " & "IDBerobat = '" & txtIDBerobat.Text & "', IDPasien = '" & txtIDPasien.Text & "', IDDokter = '" & cBoxIDDokter.Text &
            "', TglBerobat = '" & DateFormat & "', penatalaksanaan = '" & cBoxPenatalaksanaan.Text & "'
            WHERE IDBerobat = '" & txtIDBerobat.Text & "'"
            cmd = New MySqlCommand(strQuery, conn)

            ask = MsgBox("Apakah anda yakin ingin mengubah data pasien : " & txtIDPasien.Text & "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = DialogResult.Yes Then
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Data pasien telah diubah")
                Else
                    MessageBox.Show("Data pasien gagal diubah")
                End If
            ElseIf ask = DialogResult.No Then
                MessageBox.Show("Data pasien batal diubah")
            End If
            frmDataKlinik.btnHapusPasien.Enabled = False
            frmDataKlinik.btnUbahPasien.Enabled = False
        End If

        frmDataKlinik.ShowDataKlinik()
        frmDataKlinik.btnHapusPasien.Enabled = False
        frmDataKlinik.btnUbahPasien.Enabled = False
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
        frmDataKlinik.btnHapusPasien.Enabled = False
        frmDataKlinik.btnUbahPasien.Enabled = False
    End Sub

    Private Sub cBoxPenatalaksanaan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxPenatalaksanaan.SelectedIndexChanged
        getTarif()
    End Sub
End Class