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
    public partial class FormVerilenKitaplar : Form
    {
        public FormVerilenKitaplar()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormOgrenci formkk = new FormOgrenci();
            formkk.Show();
            this.Close();
        }

        private void FormVerilenKitaplar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Ad,Soyad,[Kitap Ad],[Veren Görevli Kart],[Alan Görevli Kart],[Verilen Tarih],[Alınan Tarih] FROM TblKitapVermeAlma  INNER JOIN TblKitaplar ON TblKitaplar.[Barkod Numarası] = TblKitapVermeAlma.[Kitap Barkod] INNER JOIN TblOgrenci ON TblOgrenci.ID = TblKitapVermeAlma.[Öğrenci Kart]", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            bgl.baglanti().Close();
        }
    }
}
