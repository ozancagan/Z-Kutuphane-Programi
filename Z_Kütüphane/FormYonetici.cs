using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_Kütüphane
{
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }

        private void btnkitapayarlari_Click(object sender, EventArgs e)
        {
            FormKitapAyarlari formka = new FormKitapAyarlari();
            formka.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnkitapsayilari_Click(object sender, EventArgs e)
        {
            FormKitapSayilari formks = new FormKitapSayilari();
            formks.Show();
        }

        private void btnverilenkitaplar_Click_1(object sender, EventArgs e)
        {
            FormVerilenKitaplar formvk = new FormVerilenKitaplar();
            formvk.Show();
        }

        private void btnsifredegistir_Click(object sender, EventArgs e)
        {
            FormYoneticiSifreDegistir formysd = new FormYoneticiSifreDegistir();
            formysd.Show();
        }

        private void btnistatistikler_Click(object sender, EventArgs e)
        {
            Formİstatistikler formi = new Formİstatistikler();
            formi.Show();
        }

        private void btnciktialma_Click(object sender, EventArgs e)
        {
            FormCiktiAlma formca = new FormCiktiAlma();
            formca.Show();
        }

        private void btnkva_Click(object sender, EventArgs e)
        {
            FormOgrenci formogrenci = new FormOgrenci();
            formogrenci.Show();
        }
    }
}
