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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Z_Kütüphane
{
    public partial class FormCiktiAlma : Form
    {
        public FormCiktiAlma()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnsayfayikapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCiktiAlma_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select Ad,Soyad,[Okul Numarası],Sınıf,Adet,Sayfa from TblOkunanAdet inner join TblOgrenci on TblOkunanAdet.[Öğrenci Kart]=TblOgrenci.ID", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                }
            }
            catch (Exception)
            {

            }

        }

    }
}
