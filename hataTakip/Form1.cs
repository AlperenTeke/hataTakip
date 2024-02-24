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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string connString = "Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=hataTakipDB;Integrated Security=True;";

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTime_tarih.Value;
            int stokNo = Convert.ToInt16(txt_stok.Text);
            string lastikBoyut = combo_lastik.Text;
            int adet = Convert.ToInt16(txt_adet.Text);
            int hataKodu = Convert.ToInt16(txt_hata.Text);
            string durum = combo_durum.Text;
            string vardiya = combo_vardiya.Text;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string kayitQuery = "INSERT INTO hata (tarih,stokNo,lastikBoyut,adet,hataKodu,durum,vardiya) VALUES (@tarih,@stokNo,@lastikBoyut,@adet,@hataKodu,@durum,@vardiya)";

                using (SqlCommand komut = new SqlCommand(kayitQuery, conn))
                {
                    komut.Parameters.AddWithValue("@tarih", tarih);
                    komut.Parameters.AddWithValue("@stokNo", stokNo);
                    komut.Parameters.AddWithValue("@lastikBoyut", lastikBoyut);
                    komut.Parameters.AddWithValue("@adet", adet);
                    komut.Parameters.AddWithValue("@hataKodu", hataKodu);
                    komut.Parameters.AddWithValue("@durum", durum);
                    komut.Parameters.AddWithValue("@vardiya", vardiya);

                    int kayitIslemi = komut.ExecuteNonQuery();

                    if (kayitIslemi > 0)
                    {
                        Listele();
                        MessageBox.Show("Kayıt Başarıyla Eklendi!", "Başarılı İşlem");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Eklenmedi! \n Lütfen Tekrar Deneyiniz.", "Başarısız İşlem");
                    }
                    Temizle();
                }

                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.hataTableAdapter.Fill(this.hataTakipDBDataSet.hata);
            boyutGetir();
            durumGetir();
            vardiyaGetir();
        }

        void Listele()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string listeleQuery = "SELECT * FROM hata";

                using (SqlDataAdapter dtAdapter = new SqlDataAdapter(listeleQuery, conn))
                {
                    DataTable dataTable = new DataTable();
                    dtAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }

                conn.Close();
            }
        }

        void Temizle()
        {
            txt_adet.Clear();
            txt_hata.Clear();
            txt_stok.Clear();
            combo_durum.Text = "Durum Seçiniz!";
            combo_lastik.Text = "Lastik Boyutu Seçiniz!";
            combo_vardiya.Text = "Vardiya Seçiniz!";
        }

        private void btn_boyut_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPage kontrolSayfasi = new adminPage();
            kontrolSayfasi.Show();
        }

        private void btn_durum_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPage2 kontrolSayfasi = new adminPage2();
            kontrolSayfasi.Show();
        }

        private void btn_vardiya_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPage3 kontrolSayfasi = new adminPage3();
            kontrolSayfasi.Show();
        }

        void vardiyaGetir()
        {
            //VARDİYA DEĞERLERİNİ GETİR
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string vardiyaQuery = "SELECT vardiya FROM vardiya";

                using (SqlCommand komut = new SqlCommand(vardiyaQuery, conn))
                {
                    using (SqlDataAdapter dtAdapter = new SqlDataAdapter(komut))
                    {
                        DataTable dataTable = new DataTable();
                        dtAdapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            var vardiyaDeger = row["vardiya"];

                            combo_vardiya.Items.Add(vardiyaDeger);
                        }
                    }
                }
            }
        }
        void durumGetir()
        {
            //DURUM DEĞERLERİNİ GETİR 
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string durumQuery = "SELECT durum FROM durum";

                using (SqlCommand komut = new SqlCommand(durumQuery, conn))
                {
                    using (SqlDataAdapter dtAdapter = new SqlDataAdapter(komut))
                    {
                        DataTable dataTable = new DataTable();
                        dtAdapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            var durumDeger = row["durum"];

                            combo_durum.Items.Add(durumDeger);
                        }
                    }
                }
                conn.Close();
            }
        }

        void boyutGetir()
        {
            //BOYUT DEĞERLERİNİ GETİR
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string boyutQuery = "SELECT boyut FROM boyut";

                using (SqlCommand komut = new SqlCommand(boyutQuery, conn))
                {
                    using (SqlDataAdapter dtAdapter = new SqlDataAdapter(komut))
                    {
                        DataTable dataTable = new DataTable();
                        dtAdapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            var boyutDeger = row["boyut"];

                            combo_lastik.Items.Add(boyutDeger);
                        }
                    }
                }
                conn.Close();
            }
        }
    }
}
