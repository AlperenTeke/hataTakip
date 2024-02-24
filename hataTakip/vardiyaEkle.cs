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
    public partial class vardiyaEkle : Form
    {
        public vardiyaEkle()
        {
            InitializeComponent();
        }

        private const string connString = "Data Source=ALPEREN\\SQLEXPRESS;Initial Catalog=hataTakipDB;Integrated Security=True;";

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string kayitQuery = "INSERT INTO vardiya (vardiya) VALUES (@vardiya)";

                using (SqlCommand komut = new SqlCommand(kayitQuery, conn))
                {
                    string vardiya = txt_vardiya.Text;

                    komut.Parameters.AddWithValue("@vardiya", vardiya);

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

        void Listele()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string listeleQuery = "SELECT * FROM vardiya";

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
            txt_vardiya.Clear();
        }

        private void vardiyaEkle_Load(object sender, EventArgs e)
        {
            this.vardiyaTableAdapter.Fill(this.hataTakipDBDataSet3.vardiya);
        }

        private void vardiyaEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 girisSayfasi = new Form1();
            girisSayfasi.Show();
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

                    string silQuery = "DELETE FROM vardiya where id = @id";

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

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string yeniVardiya = txt_vardiya.Text;

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();

                    string guncelleQuery = "UPDATE vardiya SET vardiya = @yeniVardiya WHERE id = @id";

                    using (SqlCommand komut = new SqlCommand(guncelleQuery, conn))
                    {
                        komut.Parameters.AddWithValue("@yeniVardiya", yeniVardiya);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string boyutDegeri = selectedRow.Cells[1].Value.ToString();

                txt_vardiya.Text = boyutDegeri;
            }
        }
    }
}
