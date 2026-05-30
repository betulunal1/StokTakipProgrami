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
    public partial class Form_ParcaGuncelle : Form
    {
        public Form_ParcaGuncelle()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Kutuların boş olup olmadığını kontrol ediyoruz
            if (string.IsNullOrEmpty(txtBarkod.Text))
            {
                MessageBox.Show("Lütfen önce güncellenecek parçanın barkod numarasını girin!");
                return;
            }

            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                // SQL'deki UPDATE komutu mevcut verileri değiştirmeye yarar
                string sorgu = "UPDATE Urunler SET ParcaAdi = @YeniAd, SatisFiyati = @YeniFiyat, StokMiktari = @YeniStok WHERE ParcaNo = @Barkod";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // Yeni verileri SQL parametrelerine bağlıyoruz
                komut.Parameters.AddWithValue("@Barkod", txtBarkod.Text);
                komut.Parameters.AddWithValue("@YeniAd", txtYeniAd.Text);
                komut.Parameters.AddWithValue("@YeniFiyat", Convert.ToDecimal(txtYeniFiyat.Text));
                komut.Parameters.AddWithValue("@YeniStok", Convert.ToInt32(txtYeniStok.Text));

                baglanti.Open();
                int etkilenenSatir = komut.ExecuteNonQuery(); // Güncellemeyi çalıştır

                if (etkilenenSatir > 0)
                {
                    MessageBox.Show("Parça bilgileri ve stok başarıyla güncellendi!");

                    // İşlem bitince kutuları temizle
                    txtBarkod.Clear();
                    txtYeniAd.Clear();
                    txtYeniFiyat.Clear();
                    txtYeniStok.Clear();
                }
                else
                {
                    MessageBox.Show("Bu barkod numarasına ait bir parça bulunamadı!");
                }
            }
        }
    }
}
