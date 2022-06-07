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
    public partial class FormKitapAyarlari : Form
    {
        public FormKitapAyarlari()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("update TblKitaplar set Adet=(Adet - 1) where [Barkod Numarası]=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbarkodsil.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("1 Adet silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (txtbarkodkayit.Text == "" || txtad.Text == "" || txtyazar.Text == "" || txtsayfa.Text == "" || txtadet.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlCommand komut = new SqlCommand("insert into TblKitaplar([Barkod Numarası],[Kitap Ad],Yazar,Sayfa,Adet,Yayınevi,[Basım Yılı]) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtbarkodkayit.Text);
                komut.Parameters.AddWithValue("@p2", txtad.Text);
                komut.Parameters.AddWithValue("@p3", txtyazar.Text);
                komut.Parameters.AddWithValue("@p4", txtsayfa.Text);
                komut.Parameters.AddWithValue("@p5", txtadet.Text);
                komut.Parameters.AddWithValue("@p6", txtyayinevi.Text);
                komut.Parameters.AddWithValue("@p7", txtbasimyili.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Kayıt yapıldı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bgl.baglanti().Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkitapadguncelle.Clear();
            txtyazarguncelle.Clear();
            txtsayfaguncelle.Clear();
            txtkitapadetguncelle.Clear();
            txtyayineviguncelle.Clear();
            txtbasimyiliguncelle.Clear();

            SqlCommand komut = new SqlCommand("select * from TblKitaplar where [Barkod Numarası]=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbarkodgetir.Text);
            komut.ExecuteNonQuery();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtkitapadguncelle.Text = dr[1].ToString();
                txtyazarguncelle.Text = dr[2].ToString();
                txtsayfaguncelle.Text = dr[3].ToString();
                txtkitapadetguncelle.Text = dr[4].ToString();
                txtyayineviguncelle.Text = dr[5].ToString();
                txtbasimyiliguncelle.Text = dr[6].ToString();
            }

            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblKitaplar set [Kitap Ad]=@p1,Yazar=@p2,Sayfa=@p3,Adet=@p4,Yayınevi=@p5,[Basım Yılı]=@p6 where [Barkod Numarası]=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkitapadguncelle.Text);
            komut.Parameters.AddWithValue("@p2", txtyazarguncelle.Text);
            komut.Parameters.AddWithValue("@p3", txtsayfaguncelle.Text);
            komut.Parameters.AddWithValue("@p4", txtkitapadetguncelle.Text);
            komut.Parameters.AddWithValue("@p5", txtyayineviguncelle.Text);
            komut.Parameters.AddWithValue("@p6", txtyayineviguncelle.Text);
            komut.Parameters.AddWithValue("@p7", txtbarkodgetir.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Güncelleme Yapıldı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();
        }

        private void btnkitabisil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblKitaplar where [Barkod Numarası]=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbarkodsil.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Kitap silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bgl.baglanti().Close();
        }

        private void txtyazar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
