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
    public partial class Form_UrunSil : Form
    {
        public Form_UrunSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSilBarkod.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünün barkod numarasını girin!");
                return;
            }

            DialogResult eminMisin = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz? Bu işlem geri alınamaz!", "Ürün Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (eminMisin == DialogResult.Yes)
            {
                string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
                using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
                {
                    string sorgu = "DELETE FROM Urunler WHERE ParcaNo = @No";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@No", txtSilBarkod.Text);

                    baglanti.Open();
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Ürün başarıyla veritabanından silindi.");
                        txtSilBarkod.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bu barkod numarasına ait bir ürün bulunamadı!");
                    }
                }
            }
        }
    }
}
