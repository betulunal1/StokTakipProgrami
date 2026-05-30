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
    public partial class Form_CiroRaporu : Form
    {
        public Form_CiroRaporu()
        {
            InitializeComponent();
        }

        private void Form_CiroRaporu_Load(object sender, EventArgs e)
        {
            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                // SQL'deki SUM komutu, sütundaki tüm sayıları otomatik toplar
                string sorgu = "SELECT SUM(Tutar) FROM Satislar";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                baglanti.Open();

                // SQL'den tek bir sayısal sonuç döneceği için ExecuteScalar kullanıyoruz
                object sonuc = komut.ExecuteScalar();

                // Eğer kasada hiç para yoksa hata vermesin diye kontrol ediyoruz
                if (sonuc != DBNull.Value && sonuc != null)
                {
                    decimal toplamCiro = Convert.ToDecimal(sonuc);
                    // Büyük yazımızın içine kasadaki toplam parayı yazdırıyoruz
                    lblToplamCiro.Text = toplamCiro.ToString("N2") + " TL";
                }
                else
                {
                    lblToplamCiro.Text = "0,00 TL";
                }
            }
        }
    }
}
