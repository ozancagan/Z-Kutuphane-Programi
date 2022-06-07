
namespace Z_Kütüphane
{
    partial class FormOgrenci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtgorevlikart = new ZBobb.AlphaBlendTextBox();
            this.txtkart = new ZBobb.AlphaBlendTextBox();
            this.txtbarkod = new ZBobb.AlphaBlendTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnverilenkitaplar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnkitapsayilari = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btngetir = new System.Windows.Forms.Button();
            this.btniade = new System.Windows.Forms.Button();
            this.txtiadegorevli = new ZBobb.AlphaBlendTextBox();
            this.txtozguncumle = new ZBobb.AlphaBlendTextBox();
            this.txtiadeogrencikart = new ZBobb.AlphaBlendTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş geldin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barkod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğrenci Kart ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnkaydet);
            this.panel1.Controls.Add(this.txtgorevlikart);
            this.panel1.Controls.Add(this.txtkart);
            this.panel1.Controls.Add(this.txtbarkod);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 167);
            this.panel1.TabIndex = 6;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnkaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(3, 111);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(212, 38);
            this.btnkaydet.TabIndex = 10;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtgorevlikart
            // 
            this.txtgorevlikart.BackAlpha = 10;
            this.txtgorevlikart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtgorevlikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtgorevlikart.ForeColor = System.Drawing.Color.White;
            this.txtgorevlikart.Location = new System.Drawing.Point(119, 56);
            this.txtgorevlikart.Name = "txtgorevlikart";
            this.txtgorevlikart.Size = new System.Drawing.Size(100, 21);
            this.txtgorevlikart.TabIndex = 7;
            // 
            // txtkart
            // 
            this.txtkart.BackAlpha = 10;
            this.txtkart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtkart.ForeColor = System.Drawing.Color.White;
            this.txtkart.Location = new System.Drawing.Point(119, 30);
            this.txtkart.Name = "txtkart";
            this.txtkart.Size = new System.Drawing.Size(100, 21);
            this.txtkart.TabIndex = 7;
            // 
            // txtbarkod
            // 
            this.txtbarkod.BackAlpha = 10;
            this.txtbarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtbarkod.ForeColor = System.Drawing.Color.White;
            this.txtbarkod.Location = new System.Drawing.Point(119, 5);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(100, 21);
            this.txtbarkod.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Görevli Kart ID:";
            // 
            // btnverilenkitaplar
            // 
            this.btnverilenkitaplar.BackColor = System.Drawing.Color.White;
            this.btnverilenkitaplar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnverilenkitaplar.Location = new System.Drawing.Point(0, 10);
            this.btnverilenkitaplar.Name = "btnverilenkitaplar";
            this.btnverilenkitaplar.Size = new System.Drawing.Size(212, 49);
            this.btnverilenkitaplar.TabIndex = 7;
            this.btnverilenkitaplar.Text = "Verilen Kitaplar";
            this.btnverilenkitaplar.UseVisualStyleBackColor = false;
            this.btnverilenkitaplar.Click += new System.EventHandler(this.btnverilenkitaplar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnkitapsayilari);
            this.panel2.Controls.Add(this.btnverilenkitaplar);
            this.panel2.Location = new System.Drawing.Point(166, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 62);
            this.panel2.TabIndex = 8;
            // 
            // btnkitapsayilari
            // 
            this.btnkitapsayilari.BackColor = System.Drawing.Color.White;
            this.btnkitapsayilari.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitapsayilari.Location = new System.Drawing.Point(218, 10);
            this.btnkitapsayilari.Name = "btnkitapsayilari";
            this.btnkitapsayilari.Size = new System.Drawing.Size(212, 49);
            this.btnkitapsayilari.TabIndex = 8;
            this.btnkitapsayilari.Text = "Kitap Sayıları";
            this.btnkitapsayilari.UseVisualStyleBackColor = false;
            this.btnkitapsayilari.Click += new System.EventHandler(this.btnkitapsayilari_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(719, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Çıkış";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kitap Alış";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btngetir);
            this.panel3.Controls.Add(this.btniade);
            this.panel3.Controls.Add(this.txtiadegorevli);
            this.panel3.Controls.Add(this.txtozguncumle);
            this.panel3.Controls.Add(this.txtiadeogrencikart);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(518, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 167);
            this.panel3.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // btngetir
            // 
            this.btngetir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btngetir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngetir.Location = new System.Drawing.Point(8, 32);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(107, 25);
            this.btngetir.TabIndex = 10;
            this.btngetir.Text = "Getir";
            this.btngetir.UseVisualStyleBackColor = false;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // btniade
            // 
            this.btniade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btniade.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniade.Location = new System.Drawing.Point(8, 111);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(212, 38);
            this.btniade.TabIndex = 10;
            this.btniade.Text = "Kaydet";
            this.btniade.UseVisualStyleBackColor = false;
            this.btniade.Click += new System.EventHandler(this.btniade_Click);
            // 
            // txtiadegorevli
            // 
            this.txtiadegorevli.BackAlpha = 10;
            this.txtiadegorevli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtiadegorevli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtiadegorevli.ForeColor = System.Drawing.Color.White;
            this.txtiadegorevli.Location = new System.Drawing.Point(120, 85);
            this.txtiadegorevli.Name = "txtiadegorevli";
            this.txtiadegorevli.Size = new System.Drawing.Size(100, 21);
            this.txtiadegorevli.TabIndex = 7;
            // 
            // txtozguncumle
            // 
            this.txtozguncumle.BackAlpha = 10;
            this.txtozguncumle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtozguncumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtozguncumle.ForeColor = System.Drawing.Color.White;
            this.txtozguncumle.Location = new System.Drawing.Point(120, 59);
            this.txtozguncumle.Name = "txtozguncumle";
            this.txtozguncumle.Size = new System.Drawing.Size(100, 21);
            this.txtozguncumle.TabIndex = 7;
            // 
            // txtiadeogrencikart
            // 
            this.txtiadeogrencikart.BackAlpha = 10;
            this.txtiadeogrencikart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtiadeogrencikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtiadeogrencikart.ForeColor = System.Drawing.Color.White;
            this.txtiadeogrencikart.Location = new System.Drawing.Point(120, 5);
            this.txtiadeogrencikart.Name = "txtiadeogrencikart";
            this.txtiadeogrencikart.Size = new System.Drawing.Size(100, 21);
            this.txtiadeogrencikart.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(5, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Görevli Kart ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Özgün Cümle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Öğrenci Kart ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(597, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kitap İade";
            // 
            // FormOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Z_Kütüphane.Properties.Resources.WhatsApp_Image_2021_05_08_at_17_30_42__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 344);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ",";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitapKayit_FormClosed);
            this.Load += new System.EventHandler(this.FormKitapKayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnkaydet;
        private ZBobb.AlphaBlendTextBox txtkart;
        private ZBobb.AlphaBlendTextBox txtbarkod;
        private System.Windows.Forms.Button btnverilenkitaplar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnkitapsayilari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btniade;
        private ZBobb.AlphaBlendTextBox txtozguncumle;
        private ZBobb.AlphaBlendTextBox txtiadeogrencikart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private ZBobb.AlphaBlendTextBox txtgorevlikart;
        private System.Windows.Forms.Label label11;
        private ZBobb.AlphaBlendTextBox txtiadegorevli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btngetir;
    }
}