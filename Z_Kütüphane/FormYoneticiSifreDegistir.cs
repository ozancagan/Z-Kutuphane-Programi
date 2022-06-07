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
    public partial class FormYoneticiSifreDegistir : Form
    {
        public FormYoneticiSifreDegistir()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void lblsayfayikapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TblYoneticiSifre", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    if (Convert.ToInt32(dr[0]) == Convert.ToInt32(txteskisifre.Text))
                    {
                        if (txtyenisifre.Text == txtyenisifretekrar.Text)
                        {
                            SqlCommand kmt = new SqlCommand("update TblYoneticiSifre set Sifre=@p1", bgl.baglanti());
                            kmt.Parameters.AddWithValue("@p1", txtyenisifre.Text);
                            kmt.ExecuteNonQuery();

                            MessageBox.Show("Şifre değiştirildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Yeni şifreler uyuşmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Eski şifrenizi kontrol edin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            bgl.baglanti().Close();
        }
    }
}
