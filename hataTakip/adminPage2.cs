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
    public partial class adminPage2 : Form
    {
        public adminPage2()
        {
            InitializeComponent();
        }

        Form1 girisPage = new Form1();
        private const string connString = "Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=hataTakipDB;Integrated Security=True;";

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string kullaniciAdi = txt_kullaniciAdi.Text;
                    string kullaniciSifre = txt_kullaniciSifre.Text;

                    if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(kullaniciSifre))
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Alanı Boş Bırakılamaz!","Başarısız İşlem!");
                        return;
                    }

                    string girisQuery = "SELECT COUNT(*) FROM adminUsers WHERE username = @Username AND password = @Password";

                    using(SqlCommand komut = new SqlCommand(girisQuery,conn))
                    {
                        string username = txt_kullaniciAdi.Text;
                        string password = txt_kullaniciSifre.Text;

                        komut.Parameters.AddWithValue("@Username", username);
                        komut.Parameters.AddWithValue("@Password", password);


                        int admin = (int)komut.ExecuteScalar();

                        if (admin > 0)
                        {
                            MessageBox.Show("Giriş Başarılı!\nSonraki Sayfaya Yönlendiriliyorsunuz...", "Başarılı İşlem!");
                            this.Hide();
                            durumEkle durumPage = new durumEkle();
                            durumPage.Show();
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
                MessageBox.Show($"Hata Durumu {hata}");
                throw;
            }
        }

        private void adminPage2_FormClosed(object sender, FormClosedEventArgs e)
        {
            girisPage.Show();
        }
    }
}
