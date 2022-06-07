
namespace Z_Kütüphane
{
    partial class FormYonetici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnciktialma = new System.Windows.Forms.Button();
            this.btnistatistikler = new System.Windows.Forms.Button();
            this.btnsifredegistir = new System.Windows.Forms.Button();
            this.btnverilenkitaplar = new System.Windows.Forms.Button();
            this.btnkva = new System.Windows.Forms.Button();
            this.btnkitapsayilari = new System.Windows.Forms.Button();
            this.btnkitapayarlari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnciktialma);
            this.panel1.Controls.Add(this.btnistatistikler);
            this.panel1.Controls.Add(this.btnsifredegistir);
            this.panel1.Controls.Add(this.btnverilenkitaplar);
            this.panel1.Controls.Add(this.btnkva);
            this.panel1.Controls.Add(this.btnkitapsayilari);
            this.panel1.Controls.Add(this.btnkitapayarlari);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 454);
            this.panel1.TabIndex = 0;
            // 
            // btnciktialma
            // 
            this.btnciktialma.BackgroundImage = global::Z_Kütüphane.Properties.Resources.indir;
            this.btnciktialma.Location = new System.Drawing.Point(3, 304);
            this.btnciktialma.Name = "btnciktialma";
            this.btnciktialma.Size = new System.Drawing.Size(152, 36);
            this.btnciktialma.TabIndex = 1;
            this.btnciktialma.Text = "Çıktı Alma";
            this.btnciktialma.UseVisualStyleBackColor = true;
            this.btnciktialma.Click += new System.EventHandler(this.btnciktialma_Click);
            // 
            // btnistatistikler
            // 
            this.btnistatistikler.BackgroundImage = global::Z_Kütüphane.Properties.Resources.indir;
            this.btnistatistikler.Location = new System.Drawing.Point(3, 262);
            this.btnistatistikler.Name = "btnistatistikler";
            this.btnistatistikler.Size = new System.Drawing.Size(152, 36);
            this.btnistatistikler.TabIndex = 1;
            this.btnistatistikler.Text = "İstatistikler";
            this.btnistatistikler.UseVisualStyleBackColor = true;
            this.btnistatistikler.Click += new System.EventHandler(this.btnistatistikler_Click);
            // 
            // btnsifredegistir
            // 
            this.btnsifredegistir.BackgroundImage = global::Z_Kütüphane.Properties.Resources.indir;
            this.btnsifredegistir.Location = new System.Drawing.Point(3, 220);
            this.btnsifredegistir.Name = "btnsifredegistir";
            this.btnsifredegistir.Size = new System.Drawing.Size(152, 36);
            this.btnsifredegistir.TabIndex = 1;
            this.btnsifredegistir.Text = "Yönetici Şifre Değiştir";
            this.btnsifredegistir.UseVisualStyleBackColor = true;
            this.btnsifredegistir.Click += new System.EventHandler(this.btnsifredegistir_Click);
            // 
            // btnverilenkitaplar
            // 
            this.btnverilenkitaplar.BackgroundImage = global::Z_Kütüphane.Properties.Resources.indir;
            this.btnverilenkitaplar.Location = new System.Drawing.Point(3, 178);
            this.btnverilenkitaplar.Name = "btnverilenkitaplar";
            this.btnverilenkitaplar.Size = new System.Drawing.Size(152, 36);
            this.btnverilenkitaplar.TabIndex = 1;
            this.btnverilenkitaplar.Text = "Verilen Kitaplar";
            this.btnverilenkitaplar.UseVisualStyleBackColor = true;
            this.btnverilenkitaplar.Click += new System.EventHandler(this.btnverilenkitaplar_Click_1);
            // 
            // btnkva
            // 
            this.btnkva.BackgroundImage = global::Z_Kütüphane.Properties.Resources.indir;
            this.btnkva.Location = new System.Drawing.Point(3, 94);
            this.btnkva.Name = "btnkva";
            this.btnkva.Size = new System.Drawing.Size(152, 36);
            this.btnkva.TabIndex = 1;
            this.btnkva.Text = "Kitap Verme Alma";
            this.btnkva.UseVisualStyleBackColor = true;
            this.btnkva.Click += new System.EventHandler(this.btnkva_Click);
            // 
            // btnkitapsayilari
            // 
            this.btnkitapsayilari.BackgroundImage = global::Z_Kütüphane.Properties.Resources.indir;
            this.btnkitapsayilari.Location = new System.Drawing.Point(3, 136);
            this.btnkitapsayilari.Name = "btnkitapsayilari";
            this.btnkitapsayilari.Size = new System.Drawing.Size(152, 36);
            this.btnkitapsayilari.TabIndex = 1;
            this.btnkitapsayilari.Text = "Kitap Sayıları";
            this.btnkitapsayilari.UseVisualStyleBackColor = true;
            this.btnkitapsayilari.Click += new System.EventHandler(this.btnkitapsayilari_Click);
            // 
            // btnkitapayarlari
            // 
            this.btnkitapayarlari.BackgroundImage = global::Z_Kütüphane.Properties.Resources.indir;
            this.btnkitapayarlari.Location = new System.Drawing.Point(3, 52);
            this.btnkitapayarlari.Name = "btnkitapayarlari";
            this.btnkitapayarlari.Size = new System.Drawing.Size(152, 36);
            this.btnkitapayarlari.TabIndex = 1;
            this.btnkitapayarlari.Text = "Kitap Ekle/Sil/Güncelle";
            this.btnkitapayarlari.UseVisualStyleBackColor = true;
            this.btnkitapayarlari.Click += new System.EventHandler(this.btnkitapayarlari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(755, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Çıkış";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Z_Kütüphane.Properties.Resources.WhatsApp_Image_2021_05_08_at_17_30_42__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYonetici";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnkitapayarlari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsifredegistir;
        private System.Windows.Forms.Button btnverilenkitaplar;
        private System.Windows.Forms.Button btnkitapsayilari;
        private System.Windows.Forms.Button btnciktialma;
        private System.Windows.Forms.Button btnistatistikler;
        private System.Windows.Forms.Button btnkva;
    }
}