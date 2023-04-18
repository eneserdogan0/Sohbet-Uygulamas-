namespace Sohbet_Uygulaması
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.GirisYBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KullaniciTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SifreTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GirisYBtn
            // 
            this.GirisYBtn.Location = new System.Drawing.Point(242, 216);
            this.GirisYBtn.Name = "GirisYBtn";
            this.GirisYBtn.Size = new System.Drawing.Size(88, 29);
            this.GirisYBtn.TabIndex = 0;
            this.GirisYBtn.Text = "Giris Yap";
            this.GirisYBtn.UseVisualStyleBackColor = true;
            this.GirisYBtn.Click += new System.EventHandler(this.GirisYBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(174, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = " Giriş Ekranı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(188, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // KullaniciTB
            // 
            this.KullaniciTB.Location = new System.Drawing.Point(191, 121);
            this.KullaniciTB.Multiline = true;
            this.KullaniciTB.Name = "KullaniciTB";
            this.KullaniciTB.Size = new System.Drawing.Size(171, 27);
            this.KullaniciTB.TabIndex = 4;
            this.KullaniciTB.TextChanged += new System.EventHandler(this.KullaniciTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(191, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre:";
            // 
            // SifreTB
            // 
            this.SifreTB.Location = new System.Drawing.Point(191, 173);
            this.SifreTB.Multiline = true;
            this.SifreTB.Name = "SifreTB";
            this.SifreTB.Size = new System.Drawing.Size(171, 26);
            this.SifreTB.TabIndex = 6;
            this.SifreTB.TextChanged += new System.EventHandler(this.SifreTB_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 543);
            this.Controls.Add(this.SifreTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KullaniciTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisYBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisYBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KullaniciTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SifreTB;
    }
}

