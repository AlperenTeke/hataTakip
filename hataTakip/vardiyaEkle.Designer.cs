namespace hataTakip
{
    partial class vardiyaEkle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vardiya = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hataTakipDBDataSet3 = new hataTakip.hataTakipDBDataSet3();
            this.vardiyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vardiyaTableAdapter = new hataTakip.hataTakipDBDataSet3TableAdapters.vardiyaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataTakipDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vardiyaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_vardiya);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 693);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vardiya İşlemleri";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(315, 361);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(119, 44);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(315, 311);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(119, 44);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(315, 261);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(119, 44);
            this.btn_kaydet.TabIndex = 2;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vardiya";
            // 
            // txt_vardiya
            // 
            this.txt_vardiya.Location = new System.Drawing.Point(63, 320);
            this.txt_vardiya.Name = "txt_vardiya";
            this.txt_vardiya.Size = new System.Drawing.Size(232, 27);
            this.txt_vardiya.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(525, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 693);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mevcut Vardiyalar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vardiyaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vardiyaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(463, 667);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hataTakipDBDataSet3
            // 
            this.hataTakipDBDataSet3.DataSetName = "hataTakipDBDataSet3";
            this.hataTakipDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vardiyaBindingSource
            // 
            this.vardiyaBindingSource.DataMember = "vardiya";
            this.vardiyaBindingSource.DataSource = this.hataTakipDBDataSet3;
            // 
            // vardiyaTableAdapter
            // 
            this.vardiyaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vardiyaDataGridViewTextBoxColumn
            // 
            this.vardiyaDataGridViewTextBoxColumn.DataPropertyName = "vardiya";
            this.vardiyaDataGridViewTextBoxColumn.HeaderText = "vardiya";
            this.vardiyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vardiyaDataGridViewTextBoxColumn.Name = "vardiyaDataGridViewTextBoxColumn";
            this.vardiyaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vardiyaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "vardiyaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vardiya Kontrol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.vardiyaEkle_FormClosed);
            this.Load += new System.EventHandler(this.vardiyaEkle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hataTakipDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vardiyaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vardiya;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hataTakipDBDataSet3 hataTakipDBDataSet3;
        private System.Windows.Forms.BindingSource vardiyaBindingSource;
        private hataTakipDBDataSet3TableAdapters.vardiyaTableAdapter vardiyaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardiyaDataGridViewTextBoxColumn;
    }
}