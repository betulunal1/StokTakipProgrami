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
using System.Data;
using System.Data.SqlClient;


namespace Stok_Program
{
    public partial class Form_SatisRapor : Form
    {
        public Form_SatisRapor()
        {
            InitializeComponent();
        }

        private void Form_SatisRapor_Load(object sender, EventArgs e)
        {
            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                // Satışlar ile Ürünler tablosunu birleştirip satılan ürünün adını da ekrana getiriyoruz
                string sorgu = "SELECT S.ParcaNo AS [Ürün Kodu], S.Miktar AS [Satış Adedi], U.ParcaAdi AS [Ürün Adı], S.Tutar AS [Satış Tutarı] FROM Satislar S INNER JOIN Urunler U ON S.ParcaNo = U.ParcaNo";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();

                baglanti.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // Tabloya yansıt
            }
        }

        private void btnTumunuSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Tüm satış geçmişini silmek istediğinize emin misiniz? (Kasa sıfırlanacaktır)", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = "DELETE FROM Satislar";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Satış raporu başarıyla temizlendi!");
                    dataGridView1.DataSource = null; // Ekrandaki tabloyu da temizle
                }
            }
        }
    }
}
