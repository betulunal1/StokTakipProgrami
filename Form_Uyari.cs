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
    public partial class Form_Uyari : Form
    {
        public Form_Uyari()
        {
            InitializeComponent();
        }

        private void Form_Uyari_Load(object sender, EventArgs e)
        {
            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                // SQL'e "StokMiktari 5'ten küçük olan ürünleri getir" diyoruz
                string sorgu = "SELECT ParcaNo AS [Ürün Kodu], ParcaAdi AS [Ürün Adı], SatisFiyati AS [Fiyat], StokMiktari AS [Stok Adet], RafNo AS [Raf No] FROM Urunler WHERE StokMiktari < 5";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();

                baglanti.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // Tabloya yansıt
            }
        }
    }
}
