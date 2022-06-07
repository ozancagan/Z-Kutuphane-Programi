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
    public partial class FormKitapSayilari : Form
    {
        public FormKitapSayilari()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btngetir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblKitaplar where [Barkod Numarası] = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1" , btnbarkod.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblkitapad.Text = dr[1].ToString();
                lbladet.Text = dr[4].ToString();
            }

            else
            {
                MessageBox.Show("Yanlış barkod numarası", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
