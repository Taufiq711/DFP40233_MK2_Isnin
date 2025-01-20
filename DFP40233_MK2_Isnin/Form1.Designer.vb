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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        GroupBox3 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label9 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        Label10 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        GroupBox4 = New GroupBox()
        RichTextBox1 = New RichTextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(300, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 32)
        Label1.TabIndex = 0
        Label1.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "NAMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 2
        Label3.Text = "NO. TEL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 3
        Label4.Text = "ALAMAT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 4
        Label5.Text = "NEGERI"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"PERLIS", "KEDAH", "PULAU PINANG", "PERAK", "SELANGOR", "NEGERI SEMBILAN", "MELAKA", "JOHOR", "PAHANG", "TERENGGANU", "KELANTAN", "SABAH", "SARAWAK"})
        ComboBox1.Location = New Point(116, 293)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(36, 341)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 20)
        Label6.TabIndex = 6
        Label6.Text = "JANTINA"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Location = New Point(101, 364)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(161, 91)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(14, 60)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(115, 24)
        RadioButton2.TabIndex = 11
        RadioButton2.TabStop = True
        RadioButton2.Text = "PEREMPUAN"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(14, 24)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 24)
        RadioButton1.TabIndex = 10
        RadioButton1.TabStop = True
        RadioButton1.Text = "LELAKI"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(76, 113)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(247, 55)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(36, 470)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 20)
        Label7.TabIndex = 8
        Label7.Text = "KAEDAH BAYARAN"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton4)
        GroupBox3.Controls.Add(RadioButton3)
        GroupBox3.Location = New Point(102, 507)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(208, 76)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(12, 49)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(99, 24)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "CASHLESS"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(13, 20)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(68, 24)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "CASH"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(528, 112)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 20)
        Label9.TabIndex = 11
        Label9.Text = "PERISA"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(11, 11)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(65, 24)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "MILO"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(11, 41)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(62, 24)
        CheckBox2.TabIndex = 13
        CheckBox2.Text = "KOPI"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(11, 68)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(84, 24)
        CheckBox3.TabIndex = 14
        CheckBox3.Text = "COKLAT"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(11, 98)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(109, 24)
        CheckBox4.TabIndex = 15
        CheckBox4.Text = "STRAWBERI"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(11, 128)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(82, 24)
        CheckBox5.TabIndex = 16
        CheckBox5.Text = "PISANG"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(525, 315)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 20)
        Label10.TabIndex = 17
        Label10.Text = "TARIKH"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(604, 310)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 18
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(111, 116)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(360, 27)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(111, 162)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(360, 27)
        TextBox2.TabIndex = 20
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(CheckBox5)
        GroupBox4.Controls.Add(CheckBox4)
        GroupBox4.Controls.Add(CheckBox3)
        GroupBox4.Controls.Add(CheckBox2)
        GroupBox4.Controls.Add(CheckBox1)
        GroupBox4.Location = New Point(604, 107)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(179, 168)
        GroupBox4.TabIndex = 22
        GroupBox4.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(116, 213)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(355, 59)
        RichTextBox1.TabIndex = 23
        RichTextBox1.Text = ""
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(411, 424)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(434, 66)
        DataGridView1.TabIndex = 24
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "BIL"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "NAMA"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "NO TEL"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(411, 555)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 27)
        Button1.TabIndex = 25
        Button1.Text = "CREATE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(824, 556)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 27)
        Button2.TabIndex = 26
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(684, 556)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 27)
        Button3.TabIndex = 27
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(542, 555)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 27)
        Button4.TabIndex = 28
        Button4.Text = "READ"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(969, 617)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(RichTextBox1)
        Controls.Add(GroupBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(GroupBox3)
        Controls.Add(Label7)
        Controls.Add(GroupBox1)
        Controls.Add(Label6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
