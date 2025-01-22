<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTajuk = New Label()
        lblNama = New Label()
        lblNoTel = New Label()
        lblAlamat = New Label()
        lblNegeri = New Label()
        cbbNegeri = New ComboBox()
        lblJantina = New Label()
        gbxJantina = New GroupBox()
        rdbPerempuan = New RadioButton()
        rdbLelaki = New RadioButton()
        lblKaedahBayaran = New Label()
        gbxKaedahBayaran = New GroupBox()
        rdbCashless = New RadioButton()
        rdbCash = New RadioButton()
        lblPerisa = New Label()
        chbMilo = New CheckBox()
        chbKopi = New CheckBox()
        chbCoklat = New CheckBox()
        chbStrawberi = New CheckBox()
        chbPisang = New CheckBox()
        lblTarikh = New Label()
        dtpTarikh = New DateTimePicker()
        txtNama = New TextBox()
        txtNoTel = New TextBox()
        gbxPerisa = New GroupBox()
        rtbAlamat = New RichTextBox()
        dgvTable1 = New DataGridView()
        clmBil = New DataGridViewTextBoxColumn()
        clmNama = New DataGridViewTextBoxColumn()
        clmNoTel = New DataGridViewTextBoxColumn()
        BtnCreate = New Button()
        BtnDelete = New Button()
        BtnUpdate = New Button()
        BtnRead = New Button()
        gbxJantina.SuspendLayout()
        gbxKaedahBayaran.SuspendLayout()
        gbxPerisa.SuspendLayout()
        CType(dgvTable1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTajuk
        ' 
        lblTajuk.AutoSize = True
        lblTajuk.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTajuk.Location = New Point(300, 29)
        lblTajuk.Name = "lblTajuk"
        lblTajuk.Size = New Size(305, 32)
        lblTajuk.TabIndex = 0
        lblTajuk.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(30, 115)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(53, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "NAMA"
        ' 
        ' lblNoTel
        ' 
        lblNoTel.AutoSize = True
        lblNoTel.Location = New Point(31, 166)
        lblNoTel.Name = "lblNoTel"
        lblNoTel.Size = New Size(61, 20)
        lblNoTel.TabIndex = 2
        lblNoTel.Text = "NO. TEL"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(30, 209)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(66, 20)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "ALAMAT"
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(37, 296)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(59, 20)
        lblNegeri.TabIndex = 4
        lblNegeri.Text = "NEGERI"
        ' 
        ' cbbNegeri
        ' 
        cbbNegeri.FormattingEnabled = True
        cbbNegeri.Items.AddRange(New Object() {"PERLIS", "KEDAH", "PULAU PINANG", "PERAK", "SELANGOR", "NEGERI SEMBILAN", "MELAKA", "JOHOR", "PAHANG", "TERENGGANU", "KELANTAN", "SABAH", "SARAWAK"})
        cbbNegeri.Location = New Point(116, 293)
        cbbNegeri.Name = "cbbNegeri"
        cbbNegeri.Size = New Size(151, 28)
        cbbNegeri.TabIndex = 5
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Location = New Point(36, 341)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(68, 20)
        lblJantina.TabIndex = 6
        lblJantina.Text = "JANTINA"
        ' 
        ' gbxJantina
        ' 
        gbxJantina.Controls.Add(rdbPerempuan)
        gbxJantina.Controls.Add(rdbLelaki)
        gbxJantina.Location = New Point(101, 364)
        gbxJantina.Name = "gbxJantina"
        gbxJantina.Size = New Size(161, 91)
        gbxJantina.TabIndex = 7
        gbxJantina.TabStop = False
        ' 
        ' rdbPerempuan
        ' 
        rdbPerempuan.AutoSize = True
        rdbPerempuan.Location = New Point(14, 60)
        rdbPerempuan.Name = "rdbPerempuan"
        rdbPerempuan.Size = New Size(115, 24)
        rdbPerempuan.TabIndex = 11
        rdbPerempuan.TabStop = True
        rdbPerempuan.Text = "PEREMPUAN"
        rdbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rdbLelaki
        ' 
        rdbLelaki.AutoSize = True
        rdbLelaki.Location = New Point(14, 24)
        rdbLelaki.Name = "rdbLelaki"
        rdbLelaki.Size = New Size(75, 24)
        rdbLelaki.TabIndex = 10
        rdbLelaki.TabStop = True
        rdbLelaki.Text = "LELAKI"
        rdbLelaki.UseVisualStyleBackColor = True
        ' 
        ' lblKaedahBayaran
        ' 
        lblKaedahBayaran.AutoSize = True
        lblKaedahBayaran.Location = New Point(37, 484)
        lblKaedahBayaran.Name = "lblKaedahBayaran"
        lblKaedahBayaran.Size = New Size(137, 20)
        lblKaedahBayaran.TabIndex = 8
        lblKaedahBayaran.Text = "KAEDAH BAYARAN"
        ' 
        ' gbxKaedahBayaran
        ' 
        gbxKaedahBayaran.Controls.Add(rdbCashless)
        gbxKaedahBayaran.Controls.Add(rdbCash)
        gbxKaedahBayaran.Location = New Point(102, 507)
        gbxKaedahBayaran.Name = "gbxKaedahBayaran"
        gbxKaedahBayaran.Size = New Size(208, 76)
        gbxKaedahBayaran.TabIndex = 9
        gbxKaedahBayaran.TabStop = False
        ' 
        ' rdbCashless
        ' 
        rdbCashless.AutoSize = True
        rdbCashless.Location = New Point(12, 49)
        rdbCashless.Name = "rdbCashless"
        rdbCashless.Size = New Size(99, 24)
        rdbCashless.TabIndex = 1
        rdbCashless.TabStop = True
        rdbCashless.Text = "CASHLESS"
        rdbCashless.UseVisualStyleBackColor = True
        ' 
        ' rdbCash
        ' 
        rdbCash.AutoSize = True
        rdbCash.Location = New Point(13, 20)
        rdbCash.Name = "rdbCash"
        rdbCash.Size = New Size(68, 24)
        rdbCash.TabIndex = 0
        rdbCash.TabStop = True
        rdbCash.Text = "CASH"
        rdbCash.UseVisualStyleBackColor = True
        ' 
        ' lblPerisa
        ' 
        lblPerisa.AutoSize = True
        lblPerisa.Location = New Point(528, 112)
        lblPerisa.Name = "lblPerisa"
        lblPerisa.Size = New Size(56, 20)
        lblPerisa.TabIndex = 11
        lblPerisa.Text = "PERISA"
        ' 
        ' chbMilo
        ' 
        chbMilo.AutoSize = True
        chbMilo.Location = New Point(11, 11)
        chbMilo.Name = "chbMilo"
        chbMilo.Size = New Size(65, 24)
        chbMilo.TabIndex = 12
        chbMilo.Text = "MILO"
        chbMilo.UseVisualStyleBackColor = True
        ' 
        ' chbKopi
        ' 
        chbKopi.AutoSize = True
        chbKopi.Location = New Point(11, 41)
        chbKopi.Name = "chbKopi"
        chbKopi.Size = New Size(62, 24)
        chbKopi.TabIndex = 13
        chbKopi.Text = "KOPI"
        chbKopi.UseVisualStyleBackColor = True
        ' 
        ' chbCoklat
        ' 
        chbCoklat.AutoSize = True
        chbCoklat.Location = New Point(11, 68)
        chbCoklat.Name = "chbCoklat"
        chbCoklat.Size = New Size(84, 24)
        chbCoklat.TabIndex = 14
        chbCoklat.Text = "COKLAT"
        chbCoklat.UseVisualStyleBackColor = True
        ' 
        ' chbStrawberi
        ' 
        chbStrawberi.AutoSize = True
        chbStrawberi.Location = New Point(11, 98)
        chbStrawberi.Name = "chbStrawberi"
        chbStrawberi.Size = New Size(109, 24)
        chbStrawberi.TabIndex = 15
        chbStrawberi.Text = "STRAWBERI"
        chbStrawberi.UseVisualStyleBackColor = True
        ' 
        ' chbPisang
        ' 
        chbPisang.AutoSize = True
        chbPisang.Location = New Point(11, 128)
        chbPisang.Name = "chbPisang"
        chbPisang.Size = New Size(82, 24)
        chbPisang.TabIndex = 16
        chbPisang.Text = "PISANG"
        chbPisang.UseVisualStyleBackColor = True
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(525, 315)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(59, 20)
        lblTarikh.TabIndex = 17
        lblTarikh.Text = "TARIKH"
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(604, 310)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(250, 27)
        dtpTarikh.TabIndex = 18
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(111, 116)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(360, 27)
        txtNama.TabIndex = 19
        ' 
        ' txtNoTel
        ' 
        txtNoTel.Location = New Point(111, 162)
        txtNoTel.Name = "txtNoTel"
        txtNoTel.Size = New Size(360, 27)
        txtNoTel.TabIndex = 20
        ' 
        ' gbxPerisa
        ' 
        gbxPerisa.Controls.Add(chbPisang)
        gbxPerisa.Controls.Add(chbStrawberi)
        gbxPerisa.Controls.Add(chbCoklat)
        gbxPerisa.Controls.Add(chbKopi)
        gbxPerisa.Controls.Add(chbMilo)
        gbxPerisa.Location = New Point(604, 107)
        gbxPerisa.Name = "gbxPerisa"
        gbxPerisa.Size = New Size(179, 168)
        gbxPerisa.TabIndex = 22
        gbxPerisa.TabStop = False
        ' 
        ' rtbAlamat
        ' 
        rtbAlamat.Location = New Point(113, 213)
        rtbAlamat.Name = "rtbAlamat"
        rtbAlamat.Size = New Size(355, 59)
        rtbAlamat.TabIndex = 23
        rtbAlamat.Text = ""
        ' 
        ' dgvTable1
        ' 
        dgvTable1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTable1.Columns.AddRange(New DataGridViewColumn() {clmBil, clmNama, clmNoTel})
        dgvTable1.Location = New Point(411, 424)
        dgvTable1.Name = "dgvTable1"
        dgvTable1.RowHeadersWidth = 51
        dgvTable1.Size = New Size(434, 66)
        dgvTable1.TabIndex = 24
        ' 
        ' clmBil
        ' 
        clmBil.HeaderText = "BIL"
        clmBil.MinimumWidth = 6
        clmBil.Name = "clmBil"
        clmBil.Width = 125
        ' 
        ' clmNama
        ' 
        clmNama.HeaderText = "NAMA"
        clmNama.MinimumWidth = 6
        clmNama.Name = "clmNama"
        clmNama.Width = 125
        ' 
        ' clmNoTel
        ' 
        clmNoTel.HeaderText = "NO TEL"
        clmNoTel.MinimumWidth = 6
        clmNoTel.Name = "clmNoTel"
        clmNoTel.Width = 125
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(411, 555)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(112, 27)
        BtnCreate.TabIndex = 25
        BtnCreate.Text = "CREATE"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(824, 556)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(112, 27)
        BtnDelete.TabIndex = 26
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(684, 556)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(112, 27)
        BtnUpdate.TabIndex = 27
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(542, 555)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(112, 27)
        BtnRead.TabIndex = 28
        BtnRead.Text = "READ"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(939, 617)
        Controls.Add(BtnRead)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnDelete)
        Controls.Add(BtnCreate)
        Controls.Add(dgvTable1)
        Controls.Add(rtbAlamat)
        Controls.Add(gbxPerisa)
        Controls.Add(txtNoTel)
        Controls.Add(txtNama)
        Controls.Add(dtpTarikh)
        Controls.Add(lblTarikh)
        Controls.Add(lblPerisa)
        Controls.Add(gbxKaedahBayaran)
        Controls.Add(lblKaedahBayaran)
        Controls.Add(gbxJantina)
        Controls.Add(lblJantina)
        Controls.Add(cbbNegeri)
        Controls.Add(lblNegeri)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTel)
        Controls.Add(lblNama)
        Controls.Add(lblTajuk)
        Name = "Form1"
        Text = "Form1"
        gbxJantina.ResumeLayout(False)
        gbxJantina.PerformLayout()
        gbxKaedahBayaran.ResumeLayout(False)
        gbxKaedahBayaran.PerformLayout()
        gbxPerisa.ResumeLayout(False)
        gbxPerisa.PerformLayout()
        CType(dgvTable1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTajuk As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoTel As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents cbbNegeri As ComboBox
    Friend WithEvents lblJantina As Label
    Friend WithEvents gbxJantina As GroupBox
    Friend WithEvents lblKaedahBayaran As Label
    Friend WithEvents gbxKaedahBayaran As GroupBox
    Friend WithEvents lblPerisa As Label
    Friend WithEvents chbMilo As CheckBox
    Friend WithEvents chbKopi As CheckBox
    Friend WithEvents chbCoklat As CheckBox
    Friend WithEvents chbStrawberi As CheckBox
    Friend WithEvents chbPisang As CheckBox
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents txtNama As TextBox
    Friend WithEvents rdbPerempuan As RadioButton
    Friend WithEvents rdbLelaki As RadioButton
    Friend WithEvents rdbCashless As RadioButton
    Friend WithEvents rdbCash As RadioButton
    Friend WithEvents txtNoTel As TextBox
    Friend WithEvents gbxPerisa As GroupBox
    Friend WithEvents rtbAlamat As RichTextBox
    Friend WithEvents dgvTable1 As DataGridView
    Friend WithEvents clmBil As DataGridViewTextBoxColumn
    Friend WithEvents clmNama As DataGridViewTextBoxColumn
    Friend WithEvents clmNoTel As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnRead As Button

End Class
