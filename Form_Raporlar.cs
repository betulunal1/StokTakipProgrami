using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stok_Program
{
    public partial class Form_Raporlar : Form
    {
        // SQL bağlantı adresin (Eğer bilgisayarında farklıysa burayı güncelleyebilirsin)
        string baglantiYolu = @"Data Source=.\SQLEXPRESS;Initial Catalog=stok_program;Integrated Security=True;";

        public Form_Raporlar()
        {
            InitializeComponent();
        }

        private void Form_Raporlar_Load(object sender, EventArgs e)
        {
            RaporlariGetir();
            GrafigiDoldur();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            RaporlariGetir();
            GrafigiDoldur();
        }

        private void RaporlariGetir()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                try
                {
                    baglanti.Open();

                    // 1. TOPLAM CİRO HESAPLAMA (ToplamTutar yerine Tutar yazıldı)
                    SqlCommand komutCiro = new SqlCommand("SELECT SUM(Tutar) FROM Satislar", baglanti);
                    object ciro = komutCiro.ExecuteScalar();
                    txtToplamCiro.Text = ciro != DBNull.Value ? Convert.ToDecimal(ciro).ToString("C2") : "0,00 TL";

                    // 2. TOPLAM SATIŞ ADEDİ HESAPLAMA
                    SqlCommand komutAdet = new SqlCommand("SELECT COUNT(*) FROM Satislar", baglanti);
                    int adet = Convert.ToInt32(komutAdet.ExecuteScalar());
                    txtSatisAdedi.Text = adet.ToString() + " İşlem";

                    // 3. KRİTİK STOK LİSTESİ (Stokta 5 veya daha az kalanlar)
                    string stokSorgusu = "SELECT ParcaNo AS [Ürün No], ParcaAdi AS [Ürün Adı], StokMiktari AS [Kalan Stok] FROM Urunler WHERE StokMiktari <= 5";
                    SqlDataAdapter da = new SqlDataAdapter(stokSorgusu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridKritikStok.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Raporlar yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void GrafigiDoldur()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiYolu))
            {
                chartCiro.Series.Clear();
                chartCiro.Titles.Clear();
                chartCiro.Titles.Add("Günlük Satış Performansı");

                var seri = chartCiro.Series.Add("Ciro (TL)");
                seri.ChartType = SeriesChartType.Line;
                seri.BorderWidth = 3;
                seri.MarkerStyle = MarkerStyle.Circle;

                // GRAFİK SORĞUSU (SatisTarihi yerine Tarih, ToplamTutar yerine Tutar yazıldı)
                string sorgu = "SELECT Tarih, SUM(Tutar) AS GunlukCiro FROM Satislar GROUP BY Tarih ORDER BY Tarih ASC";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                try
                {
                    baglanti.Open();
                    SqlDataReader dr = komut.ExecuteReader();

                    while (dr.Read())
                    {
                        // Veritabanındaki Tarih sütununu okuyoruz
                        string tarih = Convert.ToDateTime(dr["Tarih"]).ToString("dd/MM/yyyy");
                        decimal ciro = Convert.ToDecimal(dr["GunlukCiro"]);
                        seri.Points.AddXY(tarih, ciro);
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Grafik yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}