
namespace Z_Kütüphane
{
    partial class FormKitapSayilari
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbarkod = new ZBobb.AlphaBlendTextBox();
            this.btngetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkitapad = new System.Windows.Forms.Label();
            this.lbladet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(411, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sayfayı Kapat";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Barkod:";
            this.label1.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnbarkod
            // 
            this.btnbarkod.BackAlpha = 0;
            this.btnbarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnbarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnbarkod.ForeColor = System.Drawing.Color.White;
            this.btnbarkod.Location = new System.Drawing.Point(76, 25);
            this.btnbarkod.Name = "btnbarkod";
            this.btnbarkod.Size = new System.Drawing.Size(100, 21);
            this.btnbarkod.TabIndex = 12;
            // 
            // btngetir
            // 
            this.btngetir.BackColor = System.Drawing.Color.SteelBlue;
            this.btngetir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngetir.ForeColor = System.Drawing.Color.White;
            this.btngetir.Location = new System.Drawing.Point(182, 20);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(159, 29);
            this.btngetir.TabIndex = 13;
            this.btngetir.Text = "Getir";
            this.btngetir.UseVisualStyleBackColor = false;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kitap Adı:";
            this.label2.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adet:";
            this.label3.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblkitapad
            // 
            this.lblkitapad.AutoSize = true;
            this.lblkitapad.BackColor = System.Drawing.Color.Transparent;
            this.lblkitapad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkitapad.ForeColor = System.Drawing.Color.White;
            this.lblkitapad.Location = new System.Drawing.Point(89, 64);
            this.lblkitapad.Name = "lblkitapad";
            this.lblkitapad.Size = new System.Drawing.Size(15, 19);
            this.lblkitapad.TabIndex = 11;
            this.lblkitapad.Text = "-";
            this.lblkitapad.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbladet
            // 
            this.lbladet.AutoSize = true;
            this.lbladet.BackColor = System.Drawing.Color.Transparent;
            this.lbladet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladet.ForeColor = System.Drawing.Color.White;
            this.lbladet.Location = new System.Drawing.Point(89, 92);
            this.lbladet.Name = "lbladet";
            this.lbladet.Size = new System.Drawing.Size(15, 19);
            this.lbladet.TabIndex = 11;
            this.lbladet.Text = "-";
            this.lbladet.Click += new System.EventHandler(this.label8_Click);
            // 
            // FormKitapSayilari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Z_Kütüphane.Properties.Resources.WhatsApp_Image_2021_01_29_at_18_44_57_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 315);
            this.Controls.Add(this.btngetir);
            this.Controls.Add(this.btnbarkod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbladet);
            this.Controls.Add(this.lblkitapad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKitapSayilari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKitapSayilari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private ZBobb.AlphaBlendTextBox btnbarkod;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkitapad;
        private System.Windows.Forms.Label lbladet;
    }
}