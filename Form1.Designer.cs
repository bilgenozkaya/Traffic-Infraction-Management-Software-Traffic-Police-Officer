namespace TrafikPolisi
{
    partial class Form1
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
            this.btnCezaEkle = new System.Windows.Forms.Button();
            this.btnCezaSorgula = new System.Windows.Forms.Button();
            this.btnCezaSil = new System.Windows.Forms.Button();
            this.btnPolisEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCezaEkle
            // 
            this.btnCezaEkle.BackgroundImage = global::TrafikPolisi.Properties.Resources.trafik_polisi_logo_F3C2B75F5C_seeklogo_com;
            this.btnCezaEkle.Location = new System.Drawing.Point(305, 51);
            this.btnCezaEkle.Name = "btnCezaEkle";
            this.btnCezaEkle.Size = new System.Drawing.Size(146, 23);
            this.btnCezaEkle.TabIndex = 6;
            this.btnCezaEkle.Text = "CEZA EKLE";
            this.btnCezaEkle.UseVisualStyleBackColor = true;
            this.btnCezaEkle.Click += new System.EventHandler(this.btnCezaEkle_Click);
            // 
            // btnCezaSorgula
            // 
            this.btnCezaSorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCezaSorgula.Location = new System.Drawing.Point(1, 41);
            this.btnCezaSorgula.Name = "btnCezaSorgula";
            this.btnCezaSorgula.Size = new System.Drawing.Size(146, 23);
            this.btnCezaSorgula.TabIndex = 7;
            this.btnCezaSorgula.Text = "CEZALILARI  SORGULA";
            this.btnCezaSorgula.UseVisualStyleBackColor = true;
            this.btnCezaSorgula.Click += new System.EventHandler(this.btnCezaSorgula_Click);
            // 
            // btnCezaSil
            // 
            this.btnCezaSil.Location = new System.Drawing.Point(1, 12);
            this.btnCezaSil.Name = "btnCezaSil";
            this.btnCezaSil.Size = new System.Drawing.Size(146, 23);
            this.btnCezaSil.TabIndex = 8;
            this.btnCezaSil.Text = "CEZA SİL";
            this.btnCezaSil.UseVisualStyleBackColor = true;
            this.btnCezaSil.Click += new System.EventHandler(this.btnCezaGuncel_Click);
            // 
            // btnPolisEkle
            // 
            this.btnPolisEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnPolisEkle.Location = new System.Drawing.Point(305, 12);
            this.btnPolisEkle.Name = "btnPolisEkle";
            this.btnPolisEkle.Size = new System.Drawing.Size(146, 23);
            this.btnPolisEkle.TabIndex = 11;
            this.btnPolisEkle.Text = "TRAFİK POLİSİ KAYIT EKLE";
            this.btnPolisEkle.UseVisualStyleBackColor = false;
            this.btnPolisEkle.Click += new System.EventHandler(this.btnPolisEkle_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrafikPolisi.Properties.Resources.download__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(459, 276);
            this.Controls.Add(this.btnPolisEkle);
            this.Controls.Add(this.btnCezaSil);
            this.Controls.Add(this.btnCezaSorgula);
            this.Controls.Add(this.btnCezaEkle);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CEZA ÖDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCezaEkle;
        private System.Windows.Forms.Button btnCezaSorgula;
        private System.Windows.Forms.Button btnCezaSil;
        private System.Windows.Forms.Button btnPolisEkle;
    }
}

