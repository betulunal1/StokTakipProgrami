using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;

namespace Stok_Program
{
    public partial class Form_ParcaSatis : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True");
        public Form_ParcaSatis()
        {
            InitializeComponent();
            picSatisUrun.ErrorImage = null;
            picSatisUrun.InitialImage = null;
        }

        private void Form_ParcaSatis_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            textBox6.Visible = false;
            textBox8.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                textBox3.Visible = false;
                textBox6.Visible = false;
                textBox8.Visible = false;
            }
            if (checkBox1.Checked == true)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                textBox3.Visible = true;
                textBox6.Visible = true;
                textBox8.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                string sorgu = "SELECT ResimYolu FROM Urunler WHERE ParcaNo = @parcano";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@parcano", textBox4.Text);

                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    if (oku["ResimYolu"] != DBNull.Value && oku["ResimYolu"] != null)
                    {
                        picSatisUrun.ImageLocation = oku["ResimYolu"].ToString();
                    }
                    else
                    {
                        picSatisUrun.Image = null;
                    }
                }
                else
                {
                    picSatisUrun.Image = null;
                }
                oku.Close();
                baglanti.Close();
            }
            else
            {
                picSatisUrun.Image = null;
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer klavyeden ENTER tuşuna basıldıysa
            if (e.KeyCode == Keys.Enter)
            {
                // SQL Server'a bağlanma adresimiz
                string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";

                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    // SQL'e "bize bu parça numarasındaki ürünü getir" diyoruz
                    string sorgu = "SELECT * FROM Urunler WHERE ParcaNo = @ParcaNo";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@ParcaNo", textBox4.Text);

                    baglanti.Open();
                    SqlDataReader oku = komut.ExecuteReader();

                    // Eğer aranan parça veritabanında bulunduysa
                    if (oku.Read())
                    {
                        textBox5.Text = oku["ParcaAdi"].ToString();       // Parça Adını yazdır
                        textBox2.Text = oku["SatisFiyati"].ToString();   // Tekli fiyatını gizli kutuya al
                        textBox1.Text = oku["StokMiktari"].ToString();   // Kalan stoğu gizli kutuya al

                        textBox9.Text = "1"; // Varsayılan olarak miktar kutusuna 1 yaz
                        textBox7.Text = oku["SatisFiyati"].ToString();   // Toplam tutara da fiyatı yaz

                        if (oku["ResimYolu"] != DBNull.Value && oku["ResimYolu"] != null)
                        {
                            string gelenYol = oku["ResimYolu"].ToString();
                            picSatisUrun.ImageLocation = gelenYol;
                        }
                        else
                        {
                            picSatisUrun.Image = null;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Aradığınız parça stokta bulunamadı! Lütfen numarayı kontrol edin.");
                    }
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // Eğer miktar kutusu boş değilse ve içeriği gerçekten bir sayıysa
            if (int.TryParse(textBox9.Text, out int miktar))
            {
                // Gizli kutuya (textBox2) kaydettiğimiz tekli fiyatı alıyoruz
                if (decimal.TryParse(textBox2.Text, out decimal tekliFiyat))
                {
                    // Miktar ile tekli fiyatı çarpıyoruz
                    decimal toplamTutar = miktar * tekliFiyat;

                    // Çıkan sonucu Toplam Tutar kutusuna (textBox7) yazdırıyoruz
                    textBox7.Text = toplamTutar.ToString();
                }
            }
            else
            {
                // Eğer kullanıcı adeti silerse veya yanlış bir şey yazarsa tutarı sıfırla
                textBox7.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kutuların boş olup olmadığını kontrol ediyoruz
            if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Lütfen önce geçerli bir parça barkodu okutun ve miktar girin!");
                return;
            }
            // --- KASAYA (SATISLAR TABLOSUNA) NAKİT KAYIT KODU ---
            string kasaBaglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection conKasa = new SqlConnection(kasaBaglantiYolu))
            {
                // Satışlar tablosuna hangi parçadan kaç adet ve kaç TL'lik satıldığını kaydediyoruz
                string kasaSorgu = "INSERT INTO Satislar (ParcaNo, Miktar, Tutar) VALUES (@ParcaNo, @Miktar, @Tutar)";
                SqlCommand cmdKasa = new SqlCommand(kasaSorgu, conKasa);

                cmdKasa.Parameters.AddWithValue("@ParcaNo", textBox4.Text); // Barkod No
                cmdKasa.Parameters.AddWithValue("@Miktar", Convert.ToInt32(textBox9.Text)); // Satış Adeti
                cmdKasa.Parameters.AddWithValue("@Tutar", Convert.ToDecimal(textBox7.Text)); // Toplam Tutar

                conKasa.Open();
                cmdKasa.ExecuteNonQuery(); // SQL'e gönder
            }
            // ----------------------------------------------------

            // Sağdaki 1. Listeye (listBox1) ürünün adını ve satılan adeti ekliyoruz
            listBox1.Items.Add(textBox5.Text + " x " + textBox9.Text + " Adet");

            // Sağdaki 2. Listeye (listBox2) ise toplam tutarı ekliyoruz
            listBox2.Items.Add(textBox7.Text + " TL");

            // Eğer kullanıcı "Borca Satış" kutucuğunu işaretlediyse
            if (checkBox1.Checked == true)
            {
                // SQL Server bağlantı adresimiz
                string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";

                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    // SQL'e "Borclar tablosuna bu bilgileri kaydet" diyoruz
                    string borcSorgusu = "INSERT INTO Borclar (MusteriAd, MusteriSoyad, Telefon, BorcTutari) VALUES (@Ad, @Soyad, @Tel, @Tutar)";

                    SqlCommand borcKomutu = new SqlCommand(borcSorgusu, baglanti);

                    // Kutulardaki verileri SQL satırlarına eşliyoruz
                    borcKomutu.Parameters.AddWithValue("@Ad", textBox3.Text);    // Müşteri Adı
                    borcKomutu.Parameters.AddWithValue("@Soyad", textBox6.Text); // Müşteri Soyadı
                    borcKomutu.Parameters.AddWithValue("@Tel", textBox8.Text);   // Telefon No
                    borcKomutu.Parameters.AddWithValue("@Tutar", Convert.ToDecimal(textBox7.Text)); // Toplam Borç Tutarı

                    baglanti.Open();
                    borcKomutu.ExecuteNonQuery(); // Kodları SQL'e gönder ve çalıştır
                }

                MessageBox.Show("Müşteri borç kaydı veritabanına başarıyla eklendi!");

                // Satış bittiği için müşteri kutularını da temizleyelim
                textBox3.Clear();
                textBox6.Clear();
                textBox8.Clear();
            }

            MessageBox.Show("Ürün sepete eklendi!");

            // Yeni bir ürün okutabilmek için giriş kutularını temizliyoruz
            textBox4.Clear(); // Barkod kutusunu sil
            textBox5.Clear(); // Parça adı kutusunu sil
            textBox9.Clear(); // Miktar kutusunu sil
            textBox7.Clear(); // Tutar kutusunu sil
            textBox4.Focus(); // İmleci tekrar barkod kutusuna getir (yeni satış için)
        }
    }
}
