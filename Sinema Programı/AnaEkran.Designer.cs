namespace Sinema_Programı
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.btnyonetici = new System.Windows.Forms.Button();
            this.btnkullanici = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyonetici
            // 
            this.btnyonetici.BackColor = System.Drawing.Color.Silver;
            this.btnyonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyonetici.FlatAppearance.BorderSize = 0;
            this.btnyonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyonetici.Image = ((System.Drawing.Image)(resources.GetObject("btnyonetici.Image")));
            this.btnyonetici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyonetici.Location = new System.Drawing.Point(187, 157);
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Size = new System.Drawing.Size(350, 85);
            this.btnyonetici.TabIndex = 0;
            this.btnyonetici.Text = "Yönetici Girişi";
            this.btnyonetici.UseVisualStyleBackColor = false;
            this.btnyonetici.Click += new System.EventHandler(this.btnyonetici_Click);
            // 
            // btnkullanici
            // 
            this.btnkullanici.BackColor = System.Drawing.Color.Silver;
            this.btnkullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkullanici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkullanici.FlatAppearance.BorderSize = 0;
            this.btnkullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullanici.Image = ((System.Drawing.Image)(resources.GetObject("btnkullanici.Image")));
            this.btnkullanici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullanici.Location = new System.Drawing.Point(187, 62);
            this.btnkullanici.Name = "btnkullanici";
            this.btnkullanici.Size = new System.Drawing.Size(350, 85);
            this.btnkullanici.TabIndex = 1;
            this.btnkullanici.Text = "Kullanıcı Girişi";
            this.btnkullanici.UseVisualStyleBackColor = false;
            this.btnkullanici.Click += new System.EventHandler(this.btnkullanici_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Silver;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.FlatAppearance.BorderSize = 0;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Image = ((System.Drawing.Image)(resources.GetObject("btncikis.Image")));
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(286, 248);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(150, 36);
            this.btncikis.TabIndex = 2;
            this.btncikis.Text = "Çıkış Yap";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(701, 288);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnyonetici);
            this.Controls.Add(this.btnkullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(717, 327);
            this.MinimumSize = new System.Drawing.Size(717, 327);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyonetici;
        private System.Windows.Forms.Button btnkullanici;
        private System.Windows.Forms.Button btncikis;
    }
}