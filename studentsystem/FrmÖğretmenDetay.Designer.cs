namespace studentsystem
{
    partial class FrmÖğretmenDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtS1 = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtS3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtS2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblKalanSayısı = new System.Windows.Forms.Label();
            this.LblGecenSayısı = new System.Windows.Forms.Label();
            this.LblOrtalama = new System.Windows.Forms.Label();
            this.LblKalan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbNoteRecordDataSet = new studentsystem.DbNoteRecordDataSet();
            this.tblLessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLessonTableAdapter = new studentsystem.DbNoteRecordDataSetTableAdapters.TblLessonTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MskNumara);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Öğrenci Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad: ";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(123, 153);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(195, 35);
            this.TxtSoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad: ";
            // 
            // MskNumara
            // 
            this.MskNumara.Location = new System.Drawing.Point(123, 62);
            this.MskNumara.Mask = "0000";
            this.MskNumara.Name = "MskNumara";
            this.MskNumara.Size = new System.Drawing.Size(195, 35);
            this.MskNumara.TabIndex = 2;
            this.MskNumara.ValidatingType = typeof(int);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(123, 108);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(195, 35);
            this.TxtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtS1);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtS3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtS2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 366);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Ekle";
            // 
            // TxtS1
            // 
            this.TxtS1.Location = new System.Drawing.Point(123, 62);
            this.TxtS1.Name = "TxtS1";
            this.TxtS1.Size = new System.Drawing.Size(195, 35);
            this.TxtS1.TabIndex = 7;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(123, 207);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(195, 37);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav3: ";
            // 
            // TxtS3
            // 
            this.TxtS3.Location = new System.Drawing.Point(123, 153);
            this.TxtS3.Name = "TxtS3";
            this.TxtS3.Size = new System.Drawing.Size(195, 35);
            this.TxtS3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav2: ";
            // 
            // TxtS2
            // 
            this.TxtS2.Location = new System.Drawing.Point(123, 108);
            this.TxtS2.Name = "TxtS2";
            this.TxtS2.Size = new System.Drawing.Size(195, 35);
            this.TxtS2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav1: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblKalanSayısı);
            this.groupBox3.Controls.Add(this.LblGecenSayısı);
            this.groupBox3.Controls.Add(this.LblOrtalama);
            this.groupBox3.Controls.Add(this.LblKalan);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(736, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 366);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            // 
            // LblKalanSayısı
            // 
            this.LblKalanSayısı.AutoSize = true;
            this.LblKalanSayısı.Location = new System.Drawing.Point(178, 166);
            this.LblKalanSayısı.Name = "LblKalanSayısı";
            this.LblKalanSayısı.Size = new System.Drawing.Size(43, 29);
            this.LblKalanSayısı.TabIndex = 9;
            this.LblKalanSayısı.Text = "00";
            // 
            // LblGecenSayısı
            // 
            this.LblGecenSayısı.AutoSize = true;
            this.LblGecenSayısı.Location = new System.Drawing.Point(178, 118);
            this.LblGecenSayısı.Name = "LblGecenSayısı";
            this.LblGecenSayısı.Size = new System.Drawing.Size(43, 29);
            this.LblGecenSayısı.TabIndex = 8;
            this.LblGecenSayısı.Text = "00";
            // 
            // LblOrtalama
            // 
            this.LblOrtalama.AutoSize = true;
            this.LblOrtalama.Location = new System.Drawing.Point(178, 65);
            this.LblOrtalama.Name = "LblOrtalama";
            this.LblOrtalama.Size = new System.Drawing.Size(43, 29);
            this.LblOrtalama.TabIndex = 7;
            this.LblOrtalama.Text = "00";
            // 
            // LblKalan
            // 
            this.LblKalan.AutoSize = true;
            this.LblKalan.Location = new System.Drawing.Point(12, 166);
            this.LblKalan.Name = "LblKalan";
            this.LblKalan.Size = new System.Drawing.Size(156, 29);
            this.LblKalan.TabIndex = 5;
            this.LblKalan.Text = "Kalan Sayısı: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Geçen Sayısı: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 396);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1080, 244);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.exam1DataGridViewTextBoxColumn,
            this.exam2DataGridViewTextBoxColumn,
            this.exam3DataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblLessonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbNoteRecordDataSet
            // 
            this.dbNoteRecordDataSet.DataSetName = "DbNoteRecordDataSet";
            this.dbNoteRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLessonBindingSource
            // 
            this.tblLessonBindingSource.DataMember = "TblLesson";
            this.tblLessonBindingSource.DataSource = this.dbNoteRecordDataSet;
            // 
            // tblLessonTableAdapter
            // 
            this.tblLessonTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // exam1DataGridViewTextBoxColumn
            // 
            this.exam1DataGridViewTextBoxColumn.DataPropertyName = "Exam1";
            this.exam1DataGridViewTextBoxColumn.HeaderText = "Exam1";
            this.exam1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.exam1DataGridViewTextBoxColumn.Name = "exam1DataGridViewTextBoxColumn";
            // 
            // exam2DataGridViewTextBoxColumn
            // 
            this.exam2DataGridViewTextBoxColumn.DataPropertyName = "Exam2";
            this.exam2DataGridViewTextBoxColumn.HeaderText = "Exam2";
            this.exam2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.exam2DataGridViewTextBoxColumn.Name = "exam2DataGridViewTextBoxColumn";
            // 
            // exam3DataGridViewTextBoxColumn
            // 
            this.exam3DataGridViewTextBoxColumn.DataPropertyName = "Exam3";
            this.exam3DataGridViewTextBoxColumn.HeaderText = "Exam3";
            this.exam3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.exam3DataGridViewTextBoxColumn.Name = "exam3DataGridViewTextBoxColumn";
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Average";
            this.averageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // FrmÖğretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1124, 652);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmÖğretmenDetay";
            this.Text = "FrmÖğretmenDetay";
            this.Load += new System.EventHandler(this.FrmÖğretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRecordDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskNumara;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtS1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtS3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtS2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblKalan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblKalanSayısı;
        private System.Windows.Forms.Label LblGecenSayısı;
        private System.Windows.Forms.Label LblOrtalama;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNoteRecordDataSet dbNoteRecordDataSet;
        private System.Windows.Forms.BindingSource tblLessonBindingSource;
        private DbNoteRecordDataSetTableAdapters.TblLessonTableAdapter tblLessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}