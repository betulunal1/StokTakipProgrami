using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ParcaSatis satisEkrani = new Form_ParcaSatis();
            satisEkrani.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_BorcListesi borcEkrani = new Form_BorcListesi();
            borcEkrani.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_CiroRaporu ciroEkrani = new Form_CiroRaporu();
            ciroEkrani.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ParcaGuncelle guncelleEkrani = new Form_ParcaGuncelle();
            guncelleEkrani.Show();
        }

        private void btnUyari_Click(object sender, EventArgs e)
        {
            Form_Uyari uyariEkrani = new Form_Uyari();
            uyariEkrani.Show();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            Form_UrunKaydet kaydetEkrani = new Form_UrunKaydet();
            kaydetEkrani.Show();
        }

        private void btnSatisRaporEkrani_Click(object sender, EventArgs e)
        {
            Form_SatisRapor raporEkrani = new Form_SatisRapor();
            raporEkrani.Show();
        }

        private void btnGunlukCiroEkrani_Click(object sender, EventArgs e)
        {
            Form_GelismisCiro ciroEkrani = new Form_GelismisCiro();
            ciroEkrani.Show();
        }

        private void btnUrunSilEkrani_Click(object sender, EventArgs e)
        {
            Form_UrunSil silEkrani = new Form_UrunSil();
            silEkrani.Show();
        }

        private void btnUrunleriGoruntuleEkrani_Click(object sender, EventArgs e)
        {
            Form_UrunListesi listeEkrani = new Form_UrunListesi();
            listeEkrani.Show();
        }

        private void btnRaporlarGit_Click(object sender, EventArgs e)
        {
            Form_Raporlar frmRapor = new Form_Raporlar();
            frmRapor.Show(); // Raporlar ekranını açar
        }
    }
}
