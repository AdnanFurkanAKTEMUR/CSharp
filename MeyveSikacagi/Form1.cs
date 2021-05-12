using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MeyveSikacagi
{
    public partial class Form1 : Form
    {
        FileInfo[] files;
        string[] dosyalar = Directory.GetFiles(@"resimler\", "*.jpg");
        Random rnd = new Random();
        int sayac = 60;
        int rastGeleMeyve;
        int sikilanMeyveSayisi = 0;
        public Form1()
        {
            InitializeComponent();
            
            DirectoryInfo d = new DirectoryInfo("resimler/");
            files = d.GetFiles("*.jpg");
            //sonAV_lbl.Text = files[1].Name;
                
            
        }

        private void Basla_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            rastGeleMeyve = rnd.Next(6);
            pictureBox1.ImageLocation = dosyalar[rastGeleMeyve];
            //sonAV_lbl.Text = files[rast].Name;
            if(files[rastGeleMeyve].Name=="portakal.jpg" || files[rastGeleMeyve].Name == "greyfurt.jpg" || files[rastGeleMeyve].Name == "mandalina.jpg")
            {
                narenciye_btn.Enabled = true;
                kati_meyve_btn.Enabled = false;
            }
            else
            {
                narenciye_btn.Enabled = false;
                kati_meyve_btn.Enabled = true;
            }
        }

        private void Bekle_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            KalanSaniye_lbl.Text = sayac.ToString();
        }

        private void narenciye_btn_Click(object sender, EventArgs e)
        {
            sikilanMeyveSayisi++;
            toplamMeyve_lbl.Text = sikilanMeyveSayisi.ToString();

            if (files[rastGeleMeyve].Name == "portakal.jpg")
            {

            }
            else if(files[rastGeleMeyve].Name == "mandalina.jpg")
            {

            }
            else if(files[rastGeleMeyve].Name == "greyfurt.jpg")
            {

            }
        }

        private void kati_meyve_btn_Click(object sender, EventArgs e)
        {
            sikilanMeyveSayisi++;
            toplamMeyve_lbl.Text = sikilanMeyveSayisi.ToString();

            if (files[rastGeleMeyve].Name == "cilek.jpg")
            {
                Cilek cilek = new Cilek();
                meyveAgirlik_lbl.Text = cilek.agirlik.ToString();
                double verim = cilek.VerimHesapla();
                sonVerim_lbl.Text = verim.ToString();
                sonAV_lbl.Text = cilek.VitAHesapla(verim).ToString();
                sonCV_lbl.Text = cilek.VitCHesapla(verim).ToString();
            }
            else if (files[rastGeleMeyve].Name == "armut.jpg")
            {

            }
            else if (files[rastGeleMeyve].Name == "elma.jpg")
            {

            }
        }
    }
}
