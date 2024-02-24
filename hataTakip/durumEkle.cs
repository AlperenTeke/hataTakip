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
    public partial class durumEkle : Form
    {
        public durumEkle()
        {
            InitializeComponent();
        }

        private const string connString = "Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=hataTakipDB;Integrated Security=True;";

        private void durumEkle_Load(object sender, EventArgs e)
        {
            this.durumTableAdapter.Fill(this.hataTakipDBDataSet2.durum);

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string kayitQuery = "INSERT INTO durum (durum) VALUES (@durum)";

                using (SqlCommand komut = new SqlCommand(kayitQuery, conn))
                {
                    string durum = txt_durum.Text;

                    komut.Parameters.AddWithValue("@durum", durum);

                    int kayit = komut.ExecuteNonQuery();

                    if (kayit > 0)
                    {
                        MessageBox.Show("Kayıt Başarıyla Eklendi!", "Başarılı İşlem!");
                        Temizle();
                        Listele();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Ekleme İşlemi Başarısız!\nLütfen Tekrar Deneyiniz.", "Başarısız İşlem!");
                    }
                }
            }
        }

        private void durumEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 girisPage = new Form1();
            girisPage.Show();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string yeniDurum = txt_durum.Text;

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();

                    string guncelleQuery = "UPDATE durum SET durum = @yeniDurum WHERE id = @id";

                    using (SqlCommand komut = new SqlCommand(guncelleQuery, conn))
                    {
                        komut.Parameters.AddWithValue("@yeniDurum", yeniDurum);
                        komut.Parameters.AddWithValue("@id", id);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Başarıyla Güncellendi!", "Başarılı İşlem!");
                            Listele();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarısız!", "Başarısız İşlem!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin.");
                }
            }
        }

        void Listele()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string listeleQuery = "SELECT * FROM durum";

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
            txt_durum.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();

                    string silQuery = "DELETE FROM durum where id = @id";

                    using (SqlCommand komut = new SqlCommand(silQuery, conn))
                    {
                        komut.Parameters.AddWithValue("@id", id);

                        int silinenBoyut = komut.ExecuteNonQuery();

                        if (silinenBoyut > 0)
                        {
                            MessageBox.Show("Başarıyla Silindi!", "Başarılı İşlem!");
                            Listele();
                        }
                        else
                        {
                            MessageBox.Show("Silme İşlemi Başarısız!", "Başarısız İşlem!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin.");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string durumDegeri = selectedRow.Cells[1].Value.ToString();

                txt_durum.Text = durumDegeri;
            }
        }
    }
}
