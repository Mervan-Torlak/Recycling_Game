namespace B191210099_Proje
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
            this.components = new System.ComponentModel.Container();
            this.cikis_button1 = new System.Windows.Forms.Button();
            this.yeniOyun_button1 = new System.Windows.Forms.Button();
            this.atik_label1 = new System.Windows.Forms.Label();
            this.organikBosalt_button1 = new System.Windows.Forms.Button();
            this.camBosalt_button1 = new System.Windows.Forms.Button();
            this.kagitBosalt_button2 = new System.Windows.Forms.Button();
            this.metalBosalt_button3 = new System.Windows.Forms.Button();
            this.organikAtik_listBox1 = new System.Windows.Forms.ListBox();
            this.kagit_listBox2 = new System.Windows.Forms.ListBox();
            this.cam_listBox3 = new System.Windows.Forms.ListBox();
            this.metal_listBox4 = new System.Windows.Forms.ListBox();
            this.organikAtik_progressBar1 = new System.Windows.Forms.ProgressBar();
            this.kagit_progressBar2 = new System.Windows.Forms.ProgressBar();
            this.cam_progressBar3 = new System.Windows.Forms.ProgressBar();
            this.metal_progressBar4 = new System.Windows.Forms.ProgressBar();
            this.organikAtik_button1 = new System.Windows.Forms.Button();
            this.cam_button1 = new System.Windows.Forms.Button();
            this.metal_button2 = new System.Windows.Forms.Button();
            this.kagit_button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zaman_label1 = new System.Windows.Forms.Label();
            this.kronometre_timer1 = new System.Windows.Forms.Timer(this.components);
            this.atik_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.puan_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atik_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cikis_button1
            // 
            this.cikis_button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cikis_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cikis_button1.Location = new System.Drawing.Point(12, 501);
            this.cikis_button1.Name = "cikis_button1";
            this.cikis_button1.Size = new System.Drawing.Size(246, 52);
            this.cikis_button1.TabIndex = 0;
            this.cikis_button1.Text = "ÇIKIŞ";
            this.cikis_button1.UseVisualStyleBackColor = false;
            this.cikis_button1.Click += new System.EventHandler(this.cikis_button1_Click);
            // 
            // yeniOyun_button1
            // 
            this.yeniOyun_button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.yeniOyun_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyun_button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yeniOyun_button1.Location = new System.Drawing.Point(12, 240);
            this.yeniOyun_button1.Name = "yeniOyun_button1";
            this.yeniOyun_button1.Size = new System.Drawing.Size(246, 64);
            this.yeniOyun_button1.TabIndex = 1;
            this.yeniOyun_button1.Text = "YENİ OYUN";
            this.yeniOyun_button1.UseVisualStyleBackColor = false;
            this.yeniOyun_button1.Click += new System.EventHandler(this.yeniOyun_button1_Click);
            // 
            // atik_label1
            // 
            this.atik_label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.atik_label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.atik_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.atik_label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.atik_label1.Location = new System.Drawing.Point(359, 9);
            this.atik_label1.Name = "atik_label1";
            this.atik_label1.Size = new System.Drawing.Size(397, 47);
            this.atik_label1.TabIndex = 2;
            this.atik_label1.Text = "ATIK KUTULARI";
            this.atik_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // organikBosalt_button1
            // 
            this.organikBosalt_button1.Enabled = false;
            this.organikBosalt_button1.Location = new System.Drawing.Point(359, 281);
            this.organikBosalt_button1.Name = "organikBosalt_button1";
            this.organikBosalt_button1.Size = new System.Drawing.Size(120, 23);
            this.organikBosalt_button1.TabIndex = 3;
            this.organikBosalt_button1.Text = "BOŞALT";
            this.organikBosalt_button1.UseVisualStyleBackColor = true;
            this.organikBosalt_button1.Click += new System.EventHandler(this.organikBosalt_button1_Click);
            // 
            // camBosalt_button1
            // 
            this.camBosalt_button1.Enabled = false;
            this.camBosalt_button1.Location = new System.Drawing.Point(359, 530);
            this.camBosalt_button1.Name = "camBosalt_button1";
            this.camBosalt_button1.Size = new System.Drawing.Size(120, 23);
            this.camBosalt_button1.TabIndex = 4;
            this.camBosalt_button1.Text = "BOŞALT";
            this.camBosalt_button1.UseVisualStyleBackColor = true;
            this.camBosalt_button1.Click += new System.EventHandler(this.camBosalt_button1_Click);
            // 
            // kagitBosalt_button2
            // 
            this.kagitBosalt_button2.Enabled = false;
            this.kagitBosalt_button2.Location = new System.Drawing.Point(636, 281);
            this.kagitBosalt_button2.Name = "kagitBosalt_button2";
            this.kagitBosalt_button2.Size = new System.Drawing.Size(120, 23);
            this.kagitBosalt_button2.TabIndex = 5;
            this.kagitBosalt_button2.Text = "BOŞALT";
            this.kagitBosalt_button2.UseVisualStyleBackColor = true;
            this.kagitBosalt_button2.Click += new System.EventHandler(this.kagitBosalt_button2_Click);
            // 
            // metalBosalt_button3
            // 
            this.metalBosalt_button3.Enabled = false;
            this.metalBosalt_button3.Location = new System.Drawing.Point(636, 530);
            this.metalBosalt_button3.Name = "metalBosalt_button3";
            this.metalBosalt_button3.Size = new System.Drawing.Size(120, 23);
            this.metalBosalt_button3.TabIndex = 6;
            this.metalBosalt_button3.Text = "BOŞALT";
            this.metalBosalt_button3.UseVisualStyleBackColor = true;
            this.metalBosalt_button3.Click += new System.EventHandler(this.metalBosalt_button3_Click);
            // 
            // organikAtik_listBox1
            // 
            this.organikAtik_listBox1.FormattingEnabled = true;
            this.organikAtik_listBox1.ItemHeight = 16;
            this.organikAtik_listBox1.Location = new System.Drawing.Point(359, 108);
            this.organikAtik_listBox1.Name = "organikAtik_listBox1";
            this.organikAtik_listBox1.Size = new System.Drawing.Size(120, 132);
            this.organikAtik_listBox1.TabIndex = 7;
            // 
            // kagit_listBox2
            // 
            this.kagit_listBox2.FormattingEnabled = true;
            this.kagit_listBox2.ItemHeight = 16;
            this.kagit_listBox2.Location = new System.Drawing.Point(636, 108);
            this.kagit_listBox2.Name = "kagit_listBox2";
            this.kagit_listBox2.Size = new System.Drawing.Size(120, 132);
            this.kagit_listBox2.TabIndex = 8;
            // 
            // cam_listBox3
            // 
            this.cam_listBox3.FormattingEnabled = true;
            this.cam_listBox3.ItemHeight = 16;
            this.cam_listBox3.Location = new System.Drawing.Point(359, 363);
            this.cam_listBox3.Name = "cam_listBox3";
            this.cam_listBox3.Size = new System.Drawing.Size(120, 132);
            this.cam_listBox3.TabIndex = 9;
            // 
            // metal_listBox4
            // 
            this.metal_listBox4.FormattingEnabled = true;
            this.metal_listBox4.ItemHeight = 16;
            this.metal_listBox4.Location = new System.Drawing.Point(636, 363);
            this.metal_listBox4.Name = "metal_listBox4";
            this.metal_listBox4.Size = new System.Drawing.Size(120, 132);
            this.metal_listBox4.TabIndex = 10;
            // 
            // organikAtik_progressBar1
            // 
            this.organikAtik_progressBar1.Location = new System.Drawing.Point(359, 252);
            this.organikAtik_progressBar1.Name = "organikAtik_progressBar1";
            this.organikAtik_progressBar1.Size = new System.Drawing.Size(120, 23);
            this.organikAtik_progressBar1.TabIndex = 11;
            // 
            // kagit_progressBar2
            // 
            this.kagit_progressBar2.Location = new System.Drawing.Point(636, 252);
            this.kagit_progressBar2.Name = "kagit_progressBar2";
            this.kagit_progressBar2.Size = new System.Drawing.Size(120, 23);
            this.kagit_progressBar2.TabIndex = 12;
            // 
            // cam_progressBar3
            // 
            this.cam_progressBar3.Location = new System.Drawing.Point(359, 501);
            this.cam_progressBar3.Name = "cam_progressBar3";
            this.cam_progressBar3.Size = new System.Drawing.Size(120, 23);
            this.cam_progressBar3.TabIndex = 13;
            // 
            // metal_progressBar4
            // 
            this.metal_progressBar4.Location = new System.Drawing.Point(636, 501);
            this.metal_progressBar4.Name = "metal_progressBar4";
            this.metal_progressBar4.Size = new System.Drawing.Size(120, 23);
            this.metal_progressBar4.TabIndex = 14;
            // 
            // organikAtik_button1
            // 
            this.organikAtik_button1.Enabled = false;
            this.organikAtik_button1.Location = new System.Drawing.Point(359, 79);
            this.organikAtik_button1.Name = "organikAtik_button1";
            this.organikAtik_button1.Size = new System.Drawing.Size(120, 23);
            this.organikAtik_button1.TabIndex = 15;
            this.organikAtik_button1.Text = "ORGANİK ATIK";
            this.organikAtik_button1.UseVisualStyleBackColor = true;
            this.organikAtik_button1.Click += new System.EventHandler(this.organikAtik_button1_Click);
            // 
            // cam_button1
            // 
            this.cam_button1.Enabled = false;
            this.cam_button1.Location = new System.Drawing.Point(359, 334);
            this.cam_button1.Name = "cam_button1";
            this.cam_button1.Size = new System.Drawing.Size(120, 23);
            this.cam_button1.TabIndex = 16;
            this.cam_button1.Text = "CAM";
            this.cam_button1.UseVisualStyleBackColor = true;
            this.cam_button1.Click += new System.EventHandler(this.cam_button1_Click);
            // 
            // metal_button2
            // 
            this.metal_button2.Enabled = false;
            this.metal_button2.Location = new System.Drawing.Point(636, 334);
            this.metal_button2.Name = "metal_button2";
            this.metal_button2.Size = new System.Drawing.Size(120, 23);
            this.metal_button2.TabIndex = 17;
            this.metal_button2.Text = "METAL";
            this.metal_button2.UseVisualStyleBackColor = true;
            this.metal_button2.Click += new System.EventHandler(this.metal_button2_Click);
            // 
            // kagit_button3
            // 
            this.kagit_button3.Enabled = false;
            this.kagit_button3.Location = new System.Drawing.Point(636, 79);
            this.kagit_button3.Name = "kagit_button3";
            this.kagit_button3.Size = new System.Drawing.Size(120, 23);
            this.kagit_button3.TabIndex = 18;
            this.kagit_button3.Text = "KAĞIT";
            this.kagit_button3.UseVisualStyleBackColor = true;
            this.kagit_button3.Click += new System.EventHandler(this.kagit_button3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "SÜRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // zaman_label1
            // 
            this.zaman_label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.zaman_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman_label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.zaman_label1.Location = new System.Drawing.Point(13, 443);
            this.zaman_label1.Name = "zaman_label1";
            this.zaman_label1.Size = new System.Drawing.Size(245, 55);
            this.zaman_label1.TabIndex = 20;
            this.zaman_label1.Text = "60";
            this.zaman_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kronometre_timer1
            // 
            this.kronometre_timer1.Interval = 1000;
            this.kronometre_timer1.Tick += new System.EventHandler(this.kronometre_timer1_Tick);
            // 
            // atik_pictureBox1
            // 
            this.atik_pictureBox1.Location = new System.Drawing.Point(22, 13);
            this.atik_pictureBox1.Name = "atik_pictureBox1";
            this.atik_pictureBox1.Size = new System.Drawing.Size(318, 221);
            this.atik_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atik_pictureBox1.TabIndex = 21;
            this.atik_pictureBox1.TabStop = false;
            // 
            // puan_label1
            // 
            this.puan_label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.puan_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan_label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.puan_label1.Location = new System.Drawing.Point(12, 334);
            this.puan_label1.Name = "puan_label1";
            this.puan_label1.Size = new System.Drawing.Size(245, 52);
            this.puan_label1.TabIndex = 22;
            this.puan_label1.Text = "0";
            this.puan_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "PUAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puan_label1);
            this.Controls.Add(this.atik_pictureBox1);
            this.Controls.Add(this.zaman_label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kagit_button3);
            this.Controls.Add(this.metal_button2);
            this.Controls.Add(this.cam_button1);
            this.Controls.Add(this.organikAtik_button1);
            this.Controls.Add(this.metal_progressBar4);
            this.Controls.Add(this.cam_progressBar3);
            this.Controls.Add(this.kagit_progressBar2);
            this.Controls.Add(this.organikAtik_progressBar1);
            this.Controls.Add(this.metal_listBox4);
            this.Controls.Add(this.cam_listBox3);
            this.Controls.Add(this.kagit_listBox2);
            this.Controls.Add(this.organikAtik_listBox1);
            this.Controls.Add(this.metalBosalt_button3);
            this.Controls.Add(this.kagitBosalt_button2);
            this.Controls.Add(this.camBosalt_button1);
            this.Controls.Add(this.organikBosalt_button1);
            this.Controls.Add(this.atik_label1);
            this.Controls.Add(this.yeniOyun_button1);
            this.Controls.Add(this.cikis_button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(812, 618);
            this.Name = "Form1";
            this.Text = "Atık Toplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atik_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cikis_button1;
        private System.Windows.Forms.Button yeniOyun_button1;
        private System.Windows.Forms.Label atik_label1;
        private System.Windows.Forms.Button organikBosalt_button1;
        private System.Windows.Forms.Button camBosalt_button1;
        private System.Windows.Forms.Button kagitBosalt_button2;
        private System.Windows.Forms.Button metalBosalt_button3;
        private System.Windows.Forms.ListBox organikAtik_listBox1;
        private System.Windows.Forms.ListBox kagit_listBox2;
        private System.Windows.Forms.ListBox cam_listBox3;
        private System.Windows.Forms.ListBox metal_listBox4;
        private System.Windows.Forms.ProgressBar organikAtik_progressBar1;
        private System.Windows.Forms.ProgressBar kagit_progressBar2;
        private System.Windows.Forms.ProgressBar cam_progressBar3;
        private System.Windows.Forms.ProgressBar metal_progressBar4;
        private System.Windows.Forms.Button organikAtik_button1;
        private System.Windows.Forms.Button cam_button1;
        private System.Windows.Forms.Button metal_button2;
        private System.Windows.Forms.Button kagit_button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label zaman_label1;
        private System.Windows.Forms.Timer kronometre_timer1;
        private System.Windows.Forms.PictureBox atik_pictureBox1;
        private System.Windows.Forms.Label puan_label1;
        private System.Windows.Forms.Label label1;
    }
}

