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
using System.Data.Sql;

namespace Z_Kütüphane
{
    public partial class Formİstatistikler : Form
    {
        public Formİstatistikler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnsayfayikapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formİstatistikler_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Ad,Soyad,Adet From TblOgrenci inner join TblOkunanAdet on TblOgrenci.ID=TblOkunanAdet.[Öğrenci Kart]", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Öğrenciler"].Points.AddXY(dr[0].ToString() +" " +dr[1].ToString(), dr[2].ToString());
            }

            bgl.baglanti().Close();
        }

       
    }
}
