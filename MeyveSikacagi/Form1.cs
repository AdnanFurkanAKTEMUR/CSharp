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
        }

        private void Basla_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            RastgeleGetir();
        }

        private void Bekle_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            narenciye_btn.Enabled = false;
            kati_meyve_btn.Enabled = false;
            Basla_btn.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            KalanSaniye_lbl.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();
                Bekle_btn.Enabled = false;
                Basla_btn.Enabled = false;
                narenciye_btn.Enabled = false;
                kati_meyve_btn.Enabled = false;
            }
        }

        private void narenciye_btn_Click(object sender, EventArgs e)
        {
            sikilanMeyveSayisi++;
            toplamMeyve_lbl.Text = sikilanMeyveSayisi.ToString();

            if (files[rastGeleMeyve].Name == "portakal.jpg")
            {
                Portakal portakal = new Portakal();
                meyveAgirlik_lbl.Text = portakal.agirlik.ToString();
                double verim = portakal.VerimHesapla();
                double vitA = portakal.VitAHesapla(verim);
                double vitC = portakal.VitCHesapla(verim);
                Topla(vitA, vitC);
                sonVerim_lbl.Text = verim.ToString();
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            else if(files[rastGeleMeyve].Name == "mandalina.jpg")
            {
                Mandalina mandalina = new Mandalina();
                meyveAgirlik_lbl.Text = mandalina.agirlik.ToString();
                double verim = mandalina.VerimHesapla();
                double vitA = mandalina.VitAHesapla(verim);
                double vitC = mandalina.VitCHesapla(verim);
                Topla(vitA, vitC);
                sonVerim_lbl.Text = verim.ToString();
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            else if(files[rastGeleMeyve].Name == "greyfurt.jpg")
            {
                Greyfurt greyfurt = new Greyfurt();
                meyveAgirlik_lbl.Text = greyfurt.agirlik.ToString();
                double verim = greyfurt.VerimHesapla();
                double vitA = greyfurt.VitAHesapla(verim);
                double vitC = greyfurt.VitCHesapla(verim);
                Topla(vitA, vitC);
                sonVerim_lbl.Text = verim.ToString();
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            RastgeleGetir();
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
                double vitA = cilek.VitAHesapla(verim);
                double vitC = cilek.VitCHesapla(verim);
                Topla(vitA, vitC);
                sonVerim_lbl.Text = verim.ToString();
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text =vitC.ToString();
            }
            else if (files[rastGeleMeyve].Name == "armut.jpg")
            {
                Armut armut = new Armut();
                meyveAgirlik_lbl.Text = armut.agirlik.ToString();
                double verim = armut.VerimHesapla();
                double vitA = armut.VitAHesapla(verim);
                double vitC = armut.VitCHesapla(verim);
                Topla(vitA, vitC);
                sonVerim_lbl.Text = verim.ToString();
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            else if (files[rastGeleMeyve].Name == "elma.jpg")
            {
                Elma elma = new Elma();
                meyveAgirlik_lbl.Text = elma.agirlik.ToString();
                double verim = elma.VerimHesapla();
                double vitA = elma.VitAHesapla(verim);
                double vitC = elma.VitCHesapla(verim);
                Topla(vitA, vitC);
                sonVerim_lbl.Text = verim.ToString();
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            RastgeleGetir();
        }
        private void Topla(double vitA,double vitC)
        {
            double toplamA = Convert.ToDouble(toplamAV_lbl.Text);
            toplamA = toplamA + vitA;
            toplamA = Math.Round(toplamA, 2);
            toplamAV_lbl.Text = toplamA.ToString();

            double toplamC = Convert.ToDouble(toplamCV_lbl.Text);
            toplamC = toplamC + vitC;
            toplamC = Math.Round(toplamC, 2);
            toplamCV_lbl.Text = toplamC.ToString();
        }
        private void RastgeleGetir()
        {
            rastGeleMeyve = rnd.Next(6);
            pictureBox1.ImageLocation = dosyalar[rastGeleMeyve];

            if (files[rastGeleMeyve].Name == "portakal.jpg" || files[rastGeleMeyve].Name == "greyfurt.jpg" || files[rastGeleMeyve].Name == "mandalina.jpg")
            {
                narenciye_btn.Enabled = true;
                kati_meyve_btn.Enabled = false;
            }
            else
            {
                narenciye_btn.Enabled = false;
                kati_meyve_btn.Enabled = true;
            }
            Basla_btn.Enabled = false;
        }
    }
}
