using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hataTakip
{
    public partial class adminPage3 : Form
    {
        public adminPage3()
        {
            InitializeComponent();
        }
        private const string connString = "Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=hataTakipDB;Integrated Security=True;";
        private Form1 girisSayfasi = new Form1();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string kullaniciAdi = txt_kullaniciAdi.Text;
                    string kullaniciSifre = txt_kullaniciSifre.Text;

                    if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(kullaniciSifre))
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Alanı Boş Bırakılamaz!", "Başarısız İşlem!");
                        return;
                    }

                    string girisQuery = "SELECT COUNT(*) FROM adminUsers WHERE username = @Username AND password = @Password";

                    using (SqlCommand komut = new SqlCommand(girisQuery, conn))
                    {
                        komut.Parameters.AddWithValue("@Username", kullaniciAdi);
                        komut.Parameters.AddWithValue("@Password", kullaniciSifre);

                        conn.Open();

                        int admin = (int)komut.ExecuteScalar();

                        if (admin > 0)
                        {
                            MessageBox.Show("Giriş Başarılı!\nSonraki Sayfaya Yönlendiriliyorsunuz...", "Başarılı İşlem!");
                            this.Hide();
                            vardiyaEkle vardiyaPage = new vardiyaEkle();
                            vardiyaPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı!\nLütfen Yetkili Kişiye Başvurun...", "Başarısız İşlem!");
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show($"Bir Hata İle Karşılaşıldı \n {hata}");
                throw;
            }
        }

        private void adminPage3_FormClosed(object sender, FormClosedEventArgs e)
        {
            girisSayfasi.Show();
        }
    }
}
