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
    public partial class Form_UrunKaydet : Form
    {
       
        string resimYolu = ""; // Bu değişken seçilen resmin adresini hafızada tutacak
        public Form_UrunKaydet()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkod.Text) || string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("Lütfen Ürün Barkodu ve Adı alanlarını boş bırakmayın!");
                return;
            }

            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                // SQL'e "Urunler tablosuna bu yeni butik ürününü ekle" diyoruz
                string sorgu = "INSERT INTO Urunler (ParcaNo, ParcaAdi, Aciklama, AlisFiyati, SatisFiyati, StokMiktari, RafNo, ResimYolu) " +
               "VALUES (@No, @Ad, @Aciklama, @Alis, @Satis, @Stok, @Raf, @resim)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                // Parametreleri sadece burada, bir kez tanımlıyoruz
                komut.Parameters.AddWithValue("@No", txtBarkod.Text);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);
                komut.Parameters.AddWithValue("@Alis", Convert.ToDecimal(txtAlis.Text));
                komut.Parameters.AddWithValue("@Satis", Convert.ToDecimal(txtSatis.Text));
                komut.Parameters.AddWithValue("@Stok", Convert.ToInt32(txtStok.Text));
                komut.Parameters.AddWithValue("@Raf", txtRaf.Text);

                // @resim parametresini burada SADECE BİR KERE ekliyoruz
                if (picUrunResimKutusu.Tag != null)
                {
                    komut.Parameters.AddWithValue("@resim", picUrunResimKutusu.Tag.ToString());
                }
                else
                {
                    komut.Parameters.AddWithValue("@resim", DBNull.Value);
                }

                baglanti.Open();
                komut.ExecuteNonQuery();

                MessageBox.Show(txtAd.Text + " ürünü başarıyla stoğa eklendi!");

                // Temizlik: Kutuları boşalt
                txtBarkod.Clear(); txtAd.Clear(); txtAciklama.Clear();
                txtAlis.Clear(); txtSatis.Clear(); txtStok.Clear(); txtRaf.Clear();
                // Temizlik: Kutuları boşalt
                txtBarkod.Clear();
                txtAd.Clear();
                txtAciklama.Clear();
                txtAlis.Clear();
                txtSatis.Clear();
                txtStok.Clear();
                txtRaf.Clear();

                // Bunları da altına ekle:
                resimYolu = "";
                picUrunResimKutusu.Image = null;
                picUrunResimKutusu.Tag = null;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyaları (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            dosyaSecici.Title = "Ürün Fotoğrafı Seçiniz";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                // Seçilen resmi kutuda gösteriyoruz
                picUrunResimKutusu.ImageLocation = dosyaSecici.FileName;

                // Dosya yolunu kaydet butonunda kullanmak için Tag özelliğinde saklıyoruz
                picUrunResimKutusu.Tag = dosyaSecici.FileName;
            }
        }

       
    }
}
