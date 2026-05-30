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
    public partial class Form_UrunListesi : Form
    {
        public Form_UrunListesi()
        {
            InitializeComponent();
        }

        private void Form_UrunListesi_Load(object sender, EventArgs e)
        {
            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                string sorgu = "SELECT ParcaNo AS [Ürün Kodu], ParcaAdi AS [Ürün Adı], Aciklama AS [Açıklama], AlisFiyati AS [Alış Fiyatı], SatisFiyati AS [Satış Fiyatı], StokMiktari AS [Stok Adedi], RafNo AS [Raf/Reyon] FROM Urunler";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();

                baglanti.Open();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
