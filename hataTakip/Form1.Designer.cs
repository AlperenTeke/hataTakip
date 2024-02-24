namespace hataTakip
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hataNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastikBoyutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hataKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hataTakipDBDataSet = new hataTakip.hataTakipDBDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_vardiya = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_durum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_lastik = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_boyut = new System.Windows.Forms.Button();
            this.btn_durum = new System.Windows.Forms.Button();
            this.btn_vardiya = new System.Windows.Forms.Button();
            this.hataTableAdapter = new hataTakip.hataTakipDBDataSetTableAdapters.hataTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataTakipDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYITLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hataNoDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.stokNoDataGridViewTextBoxColumn,
            this.lastikBoyutDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.hataKoduDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.vardiyaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // hataNoDataGridViewTextBoxColumn
            // 
            this.hataNoDataGridViewTextBoxColumn.DataPropertyName = "hataNo";
            this.hataNoDataGridViewTextBoxColumn.HeaderText = "hataNo";
            this.hataNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hataNoDataGridViewTextBoxColumn.Name = "hataNoDataGridViewTextBoxColumn";
            this.hataNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.FillWeight = 145F;
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // stokNoDataGridViewTextBoxColumn
            // 
            this.stokNoDataGridViewTextBoxColumn.DataPropertyName = "stokNo";
            this.stokNoDataGridViewTextBoxColumn.FillWeight = 80F;
            this.stokNoDataGridViewTextBoxColumn.HeaderText = "stokNo";
            this.stokNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokNoDataGridViewTextBoxColumn.Name = "stokNoDataGridViewTextBoxColumn";
            // 
            // lastikBoyutDataGridViewTextBoxColumn
            // 
            this.lastikBoyutDataGridViewTextBoxColumn.DataPropertyName = "lastikBoyut";
            this.lastikBoyutDataGridViewTextBoxColumn.FillWeight = 145F;
            this.lastikBoyutDataGridViewTextBoxColumn.HeaderText = "lastikBoyut";
            this.lastikBoyutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastikBoyutDataGridViewTextBoxColumn.Name = "lastikBoyutDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.FillWeight = 80F;
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // hataKoduDataGridViewTextBoxColumn
            // 
            this.hataKoduDataGridViewTextBoxColumn.DataPropertyName = "hataKodu";
            this.hataKoduDataGridViewTextBoxColumn.HeaderText = "hataKodu";
            this.hataKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hataKoduDataGridViewTextBoxColumn.Name = "hataKoduDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.FillWeight = 130F;
            this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // vardiyaDataGridViewTextBoxColumn
            // 
            this.vardiyaDataGridViewTextBoxColumn.DataPropertyName = "vardiya";
            this.vardiyaDataGridViewTextBoxColumn.FillWeight = 130F;
            this.vardiyaDataGridViewTextBoxColumn.HeaderText = "vardiya";
            this.vardiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vardiyaDataGridViewTextBoxColumn.Name = "vardiyaDataGridViewTextBoxColumn";
            // 
            // hataBindingSource
            // 
            this.hataBindingSource.DataMember = "hata";
            this.hataBindingSource.DataSource = this.hataTakipDBDataSet;
            // 
            // hataTakipDBDataSet
            // 
            this.hataTakipDBDataSet.DataSetName = "hataTakipDBDataSet";
            this.hataTakipDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.combo_vardiya);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.combo_durum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_adet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.combo_lastik);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_stok);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_hata);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTime_tarih);
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAYIT EKLE";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(283, 201);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(138, 53);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vardiya";
            // 
            // combo_vardiya
            // 
            this.combo_vardiya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_vardiya.FormattingEnabled = true;
            this.combo_vardiya.Location = new System.Drawing.Point(15, 381);
            this.combo_vardiya.Name = "combo_vardiya";
            this.combo_vardiya.Size = new System.Drawing.Size(237, 26);
            this.combo_vardiya.TabIndex = 12;
            this.combo_vardiya.Text = "Vardiya Seçiniz!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Durum";
            // 
            // combo_durum
            // 
            this.combo_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_durum.FormattingEnabled = true;
            this.combo_durum.Location = new System.Drawing.Point(15, 325);
            this.combo_durum.Name = "combo_durum";
            this.combo_durum.Size = new System.Drawing.Size(237, 26);
            this.combo_durum.TabIndex = 10;
            this.combo_durum.Text = "Durum Seçiniz!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adet";
            // 
            // txt_adet
            // 
            this.txt_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adet.Location = new System.Drawing.Point(15, 215);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(237, 24);
            this.txt_adet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lastik Boyutu";
            // 
            // combo_lastik
            // 
            this.combo_lastik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_lastik.FormattingEnabled = true;
            this.combo_lastik.Location = new System.Drawing.Point(15, 160);
            this.combo_lastik.Name = "combo_lastik";
            this.combo_lastik.Size = new System.Drawing.Size(237, 26);
            this.combo_lastik.TabIndex = 6;
            this.combo_lastik.Text = "Lastik Boyutu Seçiniz!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stok Kodu";
            // 
            // txt_stok
            // 
            this.txt_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stok.Location = new System.Drawing.Point(15, 106);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(237, 24);
            this.txt_stok.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hata Kodu";
            // 
            // txt_hata
            // 
            this.txt_hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hata.Location = new System.Drawing.Point(15, 270);
            this.txt_hata.Name = "txt_hata";
            this.txt_hata.Size = new System.Drawing.Size(237, 24);
            this.txt_hata.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih";
            // 
            // dateTime_tarih
            // 
            this.dateTime_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_tarih.Location = new System.Drawing.Point(15, 51);
            this.dateTime_tarih.Name = "dateTime_tarih";
            this.dateTime_tarih.Size = new System.Drawing.Size(237, 24);
            this.dateTime_tarih.TabIndex = 0;
            // 
            // btn_boyut
            // 
            this.btn_boyut.Location = new System.Drawing.Point(852, 20);
            this.btn_boyut.Name = "btn_boyut";
            this.btn_boyut.Size = new System.Drawing.Size(138, 53);
            this.btn_boyut.TabIndex = 15;
            this.btn_boyut.Text = "Boyut Ekle";
            this.btn_boyut.UseVisualStyleBackColor = true;
            this.btn_boyut.Click += new System.EventHandler(this.btn_boyut_Click);
            // 
            // btn_durum
            // 
            this.btn_durum.Location = new System.Drawing.Point(852, 79);
            this.btn_durum.Name = "btn_durum";
            this.btn_durum.Size = new System.Drawing.Size(138, 53);
            this.btn_durum.TabIndex = 16;
            this.btn_durum.Text = "Durum Ekle";
            this.btn_durum.UseVisualStyleBackColor = true;
            this.btn_durum.Click += new System.EventHandler(this.btn_durum_Click);
            // 
            // btn_vardiya
            // 
            this.btn_vardiya.Location = new System.Drawing.Point(852, 138);
            this.btn_vardiya.Name = "btn_vardiya";
            this.btn_vardiya.Size = new System.Drawing.Size(138, 53);
            this.btn_vardiya.TabIndex = 17;
            this.btn_vardiya.Text = "Vardiya Ekle";
            this.btn_vardiya.UseVisualStyleBackColor = true;
            this.btn_vardiya.Click += new System.EventHandler(this.btn_vardiya_Click);
            // 
            // hataTableAdapter
            // 
            this.hataTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 717);
            this.Controls.Add(this.btn_vardiya);
            this.Controls.Add(this.btn_durum);
            this.Controls.Add(this.btn_boyut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hata Takip Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataTakipDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_tarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_vardiya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_durum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_lastik;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_boyut;
        private System.Windows.Forms.Button btn_durum;
        private System.Windows.Forms.Button btn_vardiya;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hataTakipDBDataSet hataTakipDBDataSet;
        private System.Windows.Forms.BindingSource hataBindingSource;
        private hataTakipDBDataSetTableAdapters.hataTableAdapter hataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastikBoyutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hataKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardiyaDataGridViewTextBoxColumn;
    }
}

