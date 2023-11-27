namespace Apartman_Kayıt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textKullaniciAd = new System.Windows.Forms.TextBox();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.simpleButtonGiris = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // textKullaniciAd
            // 
            this.textKullaniciAd.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKullaniciAd.Location = new System.Drawing.Point(221, 6);
            this.textKullaniciAd.Name = "textKullaniciAd";
            this.textKullaniciAd.Size = new System.Drawing.Size(273, 39);
            this.textKullaniciAd.TabIndex = 2;
            // 
            // textSifre
            // 
            this.textSifre.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifre.Location = new System.Drawing.Point(221, 53);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(273, 39);
            this.textSifre.TabIndex = 3;
            this.textSifre.UseSystemPasswordChar = true;
            // 
            // simpleButtonGiris
            // 
            this.simpleButtonGiris.Appearance.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonGiris.Appearance.Options.UseFont = true;
            this.simpleButtonGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButtonGiris.Location = new System.Drawing.Point(153, 119);
            this.simpleButtonGiris.Name = "simpleButtonGiris";
            this.simpleButtonGiris.Size = new System.Drawing.Size(175, 46);
            this.simpleButtonGiris.TabIndex = 4;
            this.simpleButtonGiris.Text = "Giriş yap";
            this.simpleButtonGiris.Click += new System.EventHandler(this.simpleButtonGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 177);
            this.Controls.Add(this.simpleButtonGiris);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.textKullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Yönetici Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKullaniciAd;
        private System.Windows.Forms.TextBox textSifre;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGiris;
    }
}

