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
    public partial class Form_GelismisCiro : Form
    {
        public Form_GelismisCiro()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime secilenTarih = monthCalendar1.SelectionStart;

            string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                baglanti.Open();

                // 1. GÜNLÜK CİRO HESAPLAMA
                string gunlukSorgu = "SELECT SUM(Tutar) FROM Satislar WHERE DAY(Tarih) = @Gun AND MONTH(Tarih) = @Ay AND YEAR(Tarih) = @Yil";
                SqlCommand cmdGun = new SqlCommand(gunlukSorgu, baglanti);
                cmdGun.Parameters.AddWithValue("@Gun", secilenTarih.Day);
                cmdGun.Parameters.AddWithValue("@Ay", secilenTarih.Month);
                cmdGun.Parameters.AddWithValue("@Yil", secilenTarih.Year);

                object gunSonuc = cmdGun.ExecuteScalar();
                if (gunSonuc != DBNull.Value && gunSonuc != null)
                    txtGunlukCiro.Text = Convert.ToDecimal(gunSonuc).ToString("N2") + " TL";
                else
                    txtGunlukCiro.Text = "0,00 TL";

                // 2. AYLIK CİRO HESAPLAMA
                string aylikSorgu = "SELECT SUM(Tutar) FROM Satislar WHERE MONTH(Tarih) = @Ay AND YEAR(Tarih) = @Yil";
                SqlCommand cmdAy = new SqlCommand(aylikSorgu, baglanti);
                cmdAy.Parameters.AddWithValue("@Ay", secilenTarih.Month);
                cmdAy.Parameters.AddWithValue("@Yil", secilenTarih.Year);

                object aySonuc = cmdAy.ExecuteScalar();
                if (aySonuc != DBNull.Value && aySonuc != null)
                    txtAylikCiro.Text = Convert.ToDecimal(aySonuc).ToString("N2") + " TL";
                else
                    txtAylikCiro.Text = "0,00 TL";
            }
        }
    }
}
