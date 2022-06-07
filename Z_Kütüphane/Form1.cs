using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Z_Kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void label5_Click(object sender, EventArgs e)
        {
            txtsifre.Clear();
            txtkartid.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                FormOgrenci formkk = new FormOgrenci();
                SqlCommand komut = new SqlCommand("select * from TblOgrenci where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkartid.Text);
                komut.ExecuteNonQuery();
                SqlDataReader kartiddr = komut.ExecuteReader();

                SqlCommand yoneticigiris = new SqlCommand("select * from TblYoneticiSifre where Sifre=@p1", bgl.baglanti());
                yoneticigiris.Parameters.AddWithValue("@p1", txtsifre.Text);
                yoneticigiris.ExecuteNonQuery();
                SqlDataReader yoneticigirisdr = yoneticigiris.ExecuteReader();

            if (kartiddr.Read())
            {
                formkk.Show();
                this.Hide();

            }

            else if (yoneticigirisdr.Read())
            {
                FormYonetici formyonetici = new FormYonetici();
                formyonetici.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Bilgilerinizi kontrol edin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtkartid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}


