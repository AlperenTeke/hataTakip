namespace hataTakip
{
    partial class adminPage2
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kullaniciSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(286, 367);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(128, 48);
            this.btn_giris.TabIndex = 9;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // txt_kullaniciSifre
            // 
            this.txt_kullaniciSifre.Location = new System.Drawing.Point(222, 309);
            this.txt_kullaniciSifre.Name = "txt_kullaniciSifre";
            this.txt_kullaniciSifre.Size = new System.Drawing.Size(266, 27);
            this.txt_kullaniciSifre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(222, 236);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(266, 27);
            this.txt_kullaniciAdi.TabIndex = 5;
            // 
            // adminPage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 628);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kullaniciSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminPage2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Kontrolü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.adminPage2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kullaniciSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
    }
}