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
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        Form1 formanasayfa = new Form1();
        public string kartid;

        private void FormKitapKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormKitapKayit_Load(object sender, EventArgs e)
        {
            if (kartid != null)
            {
                SqlCommand komut = new SqlCommand("select * from TblOgrenci where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", kartid);
                komut.ExecuteNonQuery();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    label2.Text = read[1] + " " + read[2];
                }
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnverilenkitaplar_Click(object sender, EventArgs e)
        {
            FormVerilenKitaplar formvk = new FormVerilenKitaplar();
            formvk.Show();
        }

        private void btnkitapsayilari_Click(object sender, EventArgs e)
        {
            FormKitapSayilari formks = new FormKitapSayilari();
            formks.Show();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.AddDays(+15).DayOfWeek == DayOfWeek.Saturday)
            {
                SqlCommand komut = new SqlCommand("insert into TblKitapVermeAlma  ([Öğrenci Kart], [Kitap Barkod], [Veren Görevli Kart], [Verilen Tarih], [Alınması Gereken Tarih]) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkart.Text);
                komut.Parameters.AddWithValue("@p2", txtbarkod.Text);
                komut.Parameters.AddWithValue("@p3", txtgorevlikart.Text);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);
                komut.Parameters.AddWithValue("@p5", DateTime.Now.AddDays(+17));
                komut.ExecuteNonQuery();

                bgl.baglanti().Close();

                MessageBox.Show("Başarıyla kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (DateTime.Now.AddDays(+15).DayOfWeek == DayOfWeek.Sunday)
            {
                SqlCommand komut = new SqlCommand("insert into TblKitapVermeAlma  ([Öğrenci Kart], [Kitap Barkod], [Veren Görevli Kart], [Verilen Tarih], [Alınması Gereken Tarih]) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkart.Text);
                komut.Parameters.AddWithValue("@p2", txtbarkod.Text);
                komut.Parameters.AddWithValue("@p3", txtgorevlikart.Text);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);
                komut.Parameters.AddWithValue("@p5", DateTime.Now.AddDays(+16));
                komut.ExecuteNonQuery();

                bgl.baglanti().Close();

                MessageBox.Show("Başarıyla kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                SqlCommand komut = new SqlCommand("insert into TblKitapVermeAlma  ([Öğrenci Kart], [Kitap Barkod], [Veren Görevli Kart], [Verilen Tarih], [Alınması Gereken Tarih]) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkart.Text);
                komut.Parameters.AddWithValue("@p2", txtbarkod.Text);
                komut.Parameters.AddWithValue("@p3", txtgorevlikart.Text);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);
                komut.Parameters.AddWithValue("@p5", DateTime.Now.AddDays(+15));
                komut.ExecuteNonQuery();

                bgl.baglanti().Close();

                MessageBox.Show("Başarıyla kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblKitapVermeAlma set [Özgün Cümle]=@p1, [Alınan Tarih]=@p2, [Alan Görevli Kart]=@p3 where [Öğrenci Kart]=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtozguncumle.Text);
            komut.Parameters.AddWithValue("@p2", DateTime.Now);
            komut.Parameters.AddWithValue("@p3", txtiadegorevli.Text);
            komut.Parameters.AddWithValue("@p4", txtiadeogrencikart.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Başarıyla Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngetir_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT [Kitap Ad] from TblKitapVermeAlma k1 inner join TblKitaplar k2 on k1.[Kitap Barkod]=k2.[Barkod Numarası]   where [Öğrenci Kart]=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtiadeogrencikart.Text);
            komut.ExecuteNonQuery();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
        }
    }
}
