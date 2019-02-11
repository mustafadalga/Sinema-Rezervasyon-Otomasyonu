namespace Sinema_Programı
{
    partial class YoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            this.btnkullanicisil = new System.Windows.Forms.Button();
            this.btnkullaniciduzenle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprev = new System.Windows.Forms.Button();
            this.kayitlikullanicilar = new System.Windows.Forms.ListBox();
            this.btnkullaniciekle = new System.Windows.Forms.Button();
            this.txtkullaniciadiekle = new System.Windows.Forms.TextBox();
            this.txtparolaekle = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkullanicisil
            // 
            this.btnkullanicisil.BackColor = System.Drawing.Color.Silver;
            this.btnkullanicisil.FlatAppearance.BorderSize = 0;
            this.btnkullanicisil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullanicisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullanicisil.Image = ((System.Drawing.Image)(resources.GetObject("btnkullanicisil.Image")));
            this.btnkullanicisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullanicisil.Location = new System.Drawing.Point(12, 352);
            this.btnkullanicisil.Name = "btnkullanicisil";
            this.btnkullanicisil.Size = new System.Drawing.Size(149, 40);
            this.btnkullanicisil.TabIndex = 40;
            this.btnkullanicisil.Text = "Kullanıcı Sil";
            this.btnkullanicisil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkullanicisil.UseVisualStyleBackColor = false;
            this.btnkullanicisil.Click += new System.EventHandler(this.btnkullanicisil_Click);
            // 
            // btnkullaniciduzenle
            // 
            this.btnkullaniciduzenle.BackColor = System.Drawing.Color.Silver;
            this.btnkullaniciduzenle.FlatAppearance.BorderSize = 0;
            this.btnkullaniciduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullaniciduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullaniciduzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnkullaniciduzenle.Image")));
            this.btnkullaniciduzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullaniciduzenle.Location = new System.Drawing.Point(178, 301);
            this.btnkullaniciduzenle.Name = "btnkullaniciduzenle";
            this.btnkullaniciduzenle.Size = new System.Drawing.Size(149, 40);
            this.btnkullaniciduzenle.TabIndex = 39;
            this.btnkullaniciduzenle.Text = "Parola Değiştir";
            this.btnkullaniciduzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkullaniciduzenle.UseVisualStyleBackColor = false;
            this.btnkullaniciduzenle.Click += new System.EventHandler(this.btnkullaniciduzenle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kayıtlı Kullanıcılar";
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.Color.Silver;
            this.btnprev.FlatAppearance.BorderSize = 0;
            this.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprev.Image = ((System.Drawing.Image)(resources.GetObject("btnprev.Image")));
            this.btnprev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprev.Location = new System.Drawing.Point(178, 352);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(149, 40);
            this.btnprev.TabIndex = 37;
            this.btnprev.Text = "Anasayfaya Dön";
            this.btnprev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprev.UseVisualStyleBackColor = false;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // kayitlikullanicilar
            // 
            this.kayitlikullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitlikullanicilar.FormattingEnabled = true;
            this.kayitlikullanicilar.ItemHeight = 20;
            this.kayitlikullanicilar.Location = new System.Drawing.Point(51, 34);
            this.kayitlikullanicilar.Name = "kayitlikullanicilar";
            this.kayitlikullanicilar.Size = new System.Drawing.Size(226, 144);
            this.kayitlikullanicilar.TabIndex = 36;
            this.kayitlikullanicilar.SelectedIndexChanged += new System.EventHandler(this.kayitlikullanicilar_SelectedIndexChanged);
            // 
            // btnkullaniciekle
            // 
            this.btnkullaniciekle.BackColor = System.Drawing.Color.Silver;
            this.btnkullaniciekle.FlatAppearance.BorderSize = 0;
            this.btnkullaniciekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkullaniciekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullaniciekle.Image = ((System.Drawing.Image)(resources.GetObject("btnkullaniciekle.Image")));
            this.btnkullaniciekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullaniciekle.Location = new System.Drawing.Point(12, 301);
            this.btnkullaniciekle.Name = "btnkullaniciekle";
            this.btnkullaniciekle.Size = new System.Drawing.Size(149, 40);
            this.btnkullaniciekle.TabIndex = 35;
            this.btnkullaniciekle.Text = "Kullanıcı Ekle";
            this.btnkullaniciekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkullaniciekle.UseVisualStyleBackColor = false;
            this.btnkullaniciekle.Click += new System.EventHandler(this.btnkullaniciekle_Click);
            // 
            // txtkullaniciadiekle
            // 
            this.txtkullaniciadiekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadiekle.Location = new System.Drawing.Point(102, 206);
            this.txtkullaniciadiekle.Multiline = true;
            this.txtkullaniciadiekle.Name = "txtkullaniciadiekle";
            this.txtkullaniciadiekle.Size = new System.Drawing.Size(175, 25);
            this.txtkullaniciadiekle.TabIndex = 33;
            this.txtkullaniciadiekle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkullaniciadiekle.Enter += new System.EventHandler(this.txtkullaniciadiekle_Enter);
            this.txtkullaniciadiekle.Leave += new System.EventHandler(this.txtkullaniciadiekle_Leave);
            // 
            // txtparolaekle
            // 
            this.txtparolaekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparolaekle.Location = new System.Drawing.Point(102, 246);
            this.txtparolaekle.Multiline = true;
            this.txtparolaekle.Name = "txtparolaekle";
            this.txtparolaekle.Size = new System.Drawing.Size(175, 25);
            this.txtparolaekle.TabIndex = 34;
            this.txtparolaekle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtparolaekle.Enter += new System.EventHandler(this.txtparolaekle_Enter);
            this.txtparolaekle.Leave += new System.EventHandler(this.txtparolaekle_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 32);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(344, 418);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnkullanicisil);
            this.Controls.Add(this.btnkullaniciduzenle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.kayitlikullanicilar);
            this.Controls.Add(this.btnkullaniciekle);
            this.Controls.Add(this.txtkullaniciadiekle);
            this.Controls.Add(this.txtparolaekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 457);
            this.MinimumSize = new System.Drawing.Size(360, 457);
            this.Name = "YoneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YoneticiPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkullanicisil;
        private System.Windows.Forms.Button btnkullaniciduzenle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.ListBox kayitlikullanicilar;
        private System.Windows.Forms.Button btnkullaniciekle;
        public System.Windows.Forms.TextBox txtkullaniciadiekle;
        public System.Windows.Forms.TextBox txtparolaekle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}