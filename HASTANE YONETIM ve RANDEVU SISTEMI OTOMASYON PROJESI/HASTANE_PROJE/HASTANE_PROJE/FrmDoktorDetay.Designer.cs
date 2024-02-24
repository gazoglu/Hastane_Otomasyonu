namespace HASTANE_PROJE
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.grbKisiBilgi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbHastaSikayet = new System.Windows.Forms.GroupBox();
            this.richTextBoxSikayet = new System.Windows.Forms.RichTextBox();
            this.grbRandevuListesi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnBilgiDuzenle = new System.Windows.Forms.Button();
            this.grbKisiBilgi.SuspendLayout();
            this.grbHastaSikayet.SuspendLayout();
            this.grbRandevuListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKisiBilgi
            // 
            this.grbKisiBilgi.Controls.Add(this.lblAdSoyad);
            this.grbKisiBilgi.Controls.Add(this.label3);
            this.grbKisiBilgi.Controls.Add(this.lblTC);
            this.grbKisiBilgi.Controls.Add(this.label1);
            this.grbKisiBilgi.Location = new System.Drawing.Point(12, 12);
            this.grbKisiBilgi.Name = "grbKisiBilgi";
            this.grbKisiBilgi.Size = new System.Drawing.Size(296, 135);
            this.grbKisiBilgi.TabIndex = 1;
            this.grbKisiBilgi.TabStop = false;
            this.grbKisiBilgi.Text = "Kisi Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(140, 88);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(82, 23);
            this.lblAdSoyad.TabIndex = 13;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ad Soyad :";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(140, 47);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 23);
            this.lblTC.TabIndex = 11;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC NO :";
            // 
            // grbHastaSikayet
            // 
            this.grbHastaSikayet.Controls.Add(this.richTextBoxSikayet);
            this.grbHastaSikayet.Location = new System.Drawing.Point(12, 153);
            this.grbHastaSikayet.Name = "grbHastaSikayet";
            this.grbHastaSikayet.Size = new System.Drawing.Size(296, 249);
            this.grbHastaSikayet.TabIndex = 14;
            this.grbHastaSikayet.TabStop = false;
            this.grbHastaSikayet.Text = "Hasta Sikayeti";
            // 
            // richTextBoxSikayet
            // 
            this.richTextBoxSikayet.Location = new System.Drawing.Point(6, 30);
            this.richTextBoxSikayet.Name = "richTextBoxSikayet";
            this.richTextBoxSikayet.Size = new System.Drawing.Size(284, 206);
            this.richTextBoxSikayet.TabIndex = 11;
            this.richTextBoxSikayet.Text = "";
            // 
            // grbRandevuListesi
            // 
            this.grbRandevuListesi.Controls.Add(this.dataGridView1);
            this.grbRandevuListesi.Location = new System.Drawing.Point(325, 12);
            this.grbRandevuListesi.Name = "grbRandevuListesi";
            this.grbRandevuListesi.Size = new System.Drawing.Size(827, 554);
            this.grbRandevuListesi.TabIndex = 15;
            this.grbRandevuListesi.TabStop = false;
            this.grbRandevuListesi.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 524);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCıkıs);
            this.groupBox1.Controls.Add(this.btnDuyurular);
            this.groupBox1.Controls.Add(this.btnBilgiDuzenle);
            this.groupBox1.Location = new System.Drawing.Point(12, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 158);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kisi Bilgi";
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Location = new System.Drawing.Point(16, 95);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(263, 35);
            this.btnCıkıs.TabIndex = 3;
            this.btnCıkıs.Text = "Cıkıs";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(154, 41);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(125, 35);
            this.btnDuyurular.TabIndex = 1;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnBilgiDuzenle
            // 
            this.btnBilgiDuzenle.Location = new System.Drawing.Point(16, 41);
            this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            this.btnBilgiDuzenle.Size = new System.Drawing.Size(125, 35);
            this.btnBilgiDuzenle.TabIndex = 0;
            this.btnBilgiDuzenle.Text = "Bilgi Duzenle";
            this.btnBilgiDuzenle.UseVisualStyleBackColor = true;
            this.btnBilgiDuzenle.Click += new System.EventHandler(this.btnBilgiDuzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1164, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbRandevuListesi);
            this.Controls.Add(this.grbHastaSikayet);
            this.Controls.Add(this.grbKisiBilgi);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.grbKisiBilgi.ResumeLayout(false);
            this.grbKisiBilgi.PerformLayout();
            this.grbHastaSikayet.ResumeLayout(false);
            this.grbRandevuListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKisiBilgi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbHastaSikayet;
        private System.Windows.Forms.RichTextBox richTextBoxSikayet;
        private System.Windows.Forms.GroupBox grbRandevuListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnBilgiDuzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}