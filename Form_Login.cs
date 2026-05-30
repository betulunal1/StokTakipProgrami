using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Program
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını boş bırakmayınız!");
                return;
            }

            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                string sorgu = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@user AND Sifre=@pass";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@user", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@pass", txtSifre.Text);

                baglanti.Open();
                int sonuc = (int)komut.ExecuteScalar();

                if (sonuc > 0)
                {
                    MessageBox.Show("Giriş Başarılı! Elite Boutique OS Sistemi Başlatılıyor...");
                    this.DialogResult = DialogResult.OK; // Program.cs'e girişin onaylandığını haber veriyoruz
                    this.Close(); // Login ekranını kapat
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre! Lütfen tekrar deneyiniz.");
                }
            }
        }
    }
}
