
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:2
**				ÖĞRENCİ ADI............:Mervan Yuşa Torlak
**				ÖĞRENCİ NUMARASI.......:B191210099
**              DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210099_Proje
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int x;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Domates domates = new Domates();
            Salatalik salatalik = new Salatalik();
            KolaKutusu kola = new KolaKutusu();
            Dergi dergi = new Dergi();
            Bardak bardak = new Bardak();
            CamSise cam = new CamSise();
            Gazete gazete = new Gazete();
            SalcaKutusu salca = new SalcaKutusu();

            Object[] atiklar = { domates.Image, salatalik.Image, kola.Image, dergi.Image, bardak.Image, cam.Image, gazete.Image, salca.Image };

            x = rnd.Next(0, atiklar.Length);
            atik_pictureBox1.Image = (Image)atiklar[x];
        }

        public void resimOlustur()
        {
        Domates domates = new Domates();
        Salatalik salatalik = new Salatalik();
        KolaKutusu kola = new KolaKutusu();
        Dergi dergi = new Dergi();
        Bardak bardak = new Bardak();
        CamSise cam = new CamSise();
        Gazete gazete = new Gazete();
        SalcaKutusu salca = new SalcaKutusu();

        Object[] atiklar = { domates.Image, salatalik.Image, kola.Image, dergi.Image, bardak.Image, cam.Image, gazete.Image, salca.Image };

        x = rnd.Next(0, atiklar.Length);
        atik_pictureBox1.Image = (Image) atiklar[x];
        }

        private void cikis_button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yeniOyun_button1_Click(object sender, EventArgs e)
        {
            organikAtik_button1.Enabled = true;
            organikBosalt_button1.Enabled = true;

            kagitBosalt_button2.Enabled = true;
            kagit_button3.Enabled = true;

            metalBosalt_button3.Enabled = true;
            metal_button2.Enabled = true;

            camBosalt_button1.Enabled = true;
            cam_button1.Enabled = true;

            kronometre_timer1.Enabled = true;

            organikAtik_progressBar1.Minimum = 0;
            organikAtik_progressBar1.Maximum = 700;

            cam_progressBar3.Minimum = 0;
            cam_progressBar3.Maximum = 2200;

            metal_progressBar4.Minimum = 0;
            metal_progressBar4.Maximum = 2300;

            kagit_progressBar2.Minimum = 0;
            kagit_progressBar2.Maximum = 1200;
            int dakika = 60;
            int zaman = int.Parse(zaman_label1.Text);
            zaman--;
            zaman_label1.Text = zaman.ToString();
            zaman_label1.Text = dakika.ToString();
            puan_label1.Text = "0";

            organikAtik_listBox1.Items.Clear();
            metal_listBox4.Items.Clear();
            cam_listBox3.Items.Clear();
            kagit_listBox2.Items.Clear();
            organikAtik_progressBar1.Value = 0;
            metal_progressBar4.Value = 0;
            kagit_progressBar2.Value = 0;
            cam_progressBar3.Value = 0;
            cam_progressBar3.Value = 0;

        }

        private void kronometre_timer1_Tick(object sender, EventArgs e)
        {
            int dakika = 60;
            int zaman = int.Parse(zaman_label1.Text);
            zaman--;
            zaman_label1.Text = zaman.ToString();
            if(zaman==0)
            {
                organikAtik_button1.Enabled = false;
                organikBosalt_button1.Enabled = false;

                kagitBosalt_button2.Enabled = false;
                kagit_button3.Enabled = false;

                metalBosalt_button3.Enabled = false;
                metal_button2.Enabled = false;

                camBosalt_button1.Enabled = false;
                cam_button1.Enabled = false;

                kronometre_timer1.Enabled = false;
                zaman_label1.Text = dakika.ToString();
                
            }
        }

        private void organikAtik_button1_Click(object sender, EventArgs e)
        {
            Domates domates = new Domates();
            Salatalik salatalik = new Salatalik();
            
            if (organikAtik_progressBar1.Value < 525)
            {
                if(x== 0)
                {
                    organikAtik_listBox1.Items.Add("Domates(150)");
                    organikAtik_progressBar1.Value += domates.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 150;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }
                else if (x == 1)
                    {
                        organikAtik_listBox1.Items.Add("Salatalık(120)");
                        organikAtik_progressBar1.Value += salatalik.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 120;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }
               
            }
            else
            {

            }
            
        }

        private void organikBosalt_button1_Click(object sender, EventArgs e)
        {
            
            if (organikAtik_progressBar1.Value >= 525)
            {
                organikAtik_progressBar1.Value = 0;
                int kalanSüre = Convert.ToInt32(zaman_label1.Text);
                kalanSüre += 3;
                zaman_label1.Text = kalanSüre.ToString();
                organikAtik_listBox1.Items.Clear();
            }
        }

        private void kagitBosalt_button2_Click(object sender, EventArgs e)
        {
            if (kagit_progressBar2.Value >= 900)
            {
                kagit_progressBar2.Value = 0;
                int kalanSüre = Convert.ToInt32(zaman_label1.Text);
                kalanSüre += 3;
                zaman_label1.Text = kalanSüre.ToString();
                kagit_listBox2.Items.Clear();
                int puan = Convert.ToInt32(puan_label1.Text);
                puan += 1000;
                puan_label1.Text = puan.ToString();
            }
        }

        private void camBosalt_button1_Click(object sender, EventArgs e)
        {
            if (cam_progressBar3.Value >= 1650)
            {
                cam_progressBar3.Value = 0;
                int kalanSüre = Convert.ToInt32(zaman_label1.Text);
                kalanSüre += 3;
                zaman_label1.Text = kalanSüre.ToString();
                cam_listBox3.Items.Clear();
                int puan = Convert.ToInt32(puan_label1.Text);
                puan += 600;
                puan_label1.Text = puan.ToString();
            }
        }

        private void metalBosalt_button3_Click(object sender, EventArgs e)
        {
            if (metal_progressBar4.Value >= 1725)
            {
                metal_progressBar4.Value = 0;
                int kalanSüre = Convert.ToInt32(zaman_label1.Text);
                kalanSüre += 3;
                zaman_label1.Text = kalanSüre.ToString();
                metal_listBox4.Items.Clear();
                int puan = Convert.ToInt32(puan_label1.Text);
                puan += 800;
                puan_label1.Text = puan.ToString();
            }
        }

        private void metal_button2_Click(object sender, EventArgs e)
        {
            KolaKutusu kola = new KolaKutusu();
            SalcaKutusu salca = new SalcaKutusu();

            if (metal_progressBar4.Value < 1725)
            {
                if (x == 2)
                {
                    metal_listBox4.Items.Add("Kola Kutusu(350)");
                    metal_progressBar4.Value += kola.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 350;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }
                else if(x==7)
                {
                    metal_listBox4.Items.Add("Salça Kutusu(550)");
                    metal_progressBar4.Value += salca.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 550;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }
               
            }
            else
            {

            }
            
        }

        private void cam_button1_Click(object sender, EventArgs e)
        {
            Bardak bardak = new Bardak();
            CamSise cam = new CamSise();

            if (cam_progressBar3.Value < 1650)
            {
                if (x == 5)
                {
                    cam_listBox3.Items.Add("Cam Şişe(600)");
                    cam_progressBar3.Value += cam.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 600;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }
                else if (x == 4)
                {
                    cam_listBox3.Items.Add("Bardak(250)");
                    cam_progressBar3.Value += bardak.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 250;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }
               
            }
            else
            {

            }
            
        }

        private void kagit_button3_Click(object sender, EventArgs e)
        {
            Dergi dergi = new Dergi();
            Gazete gazete = new Gazete();
            if (kagit_progressBar2.Value < 900)
            {
                if (x == 6)
                {
                    kagit_listBox2.Items.Add("Gazete(250)");
                    kagit_progressBar2.Value += gazete.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 250;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }
                else if (x == 3)
                {
                    kagit_listBox2.Items.Add("Dergi(200)");
                    kagit_progressBar2.Value += dergi.Hacim;
                    int puan = int.Parse(puan_label1.Text);
                    puan += 200;
                    puan_label1.Text = puan.ToString();
                    resimOlustur();
                }

            }
            else
            {

            }
            
        }
    }
}
