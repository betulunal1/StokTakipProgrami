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
    public partial class Form_BorcListesi : Form
    {
        public Form_BorcListesi()
        {
            InitializeComponent();
        }

        private void Form_BorcListesi_Load(object sender, EventArgs e)
        {
            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                // SQL'den borçlular tablosundaki her şeyi seçiyoruz
                string sorgu = "SELECT MusteriAd AS [Adı], MusteriSoyad AS [Soyadı], Telefon, BorcTutari AS [Borç Miktarı], Tarih FROM Borclar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();

                baglanti.Open();
                da.Fill(dt); // SQL'den gelen verileri tabloya doldur

                dataGridView1.DataSource = dt; // Tabloyu ekrandaki grid içine yükle
            }
        }
    }
}
