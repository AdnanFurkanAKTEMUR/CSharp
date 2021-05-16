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
        FileInfo[] files;//resimlerin isimlerini almak için
        string[] dosyalar = Directory.GetFiles(@"resimler\", "*.jpg");//resimeri bir dizide tutmak için
        Random rnd = new Random();
        int sayac = 60;//timer için
        int rastGeleMeyve;
        int sikilanMeyveSayisi = 0;
        public Form1()
        {
            InitializeComponent(); 
            //resimler klasörüne eriştim
            DirectoryInfo d = new DirectoryInfo("resimler/");
            //bunları files içine aldım
            files = d.GetFiles("*.jpg");
        }

        private void Basla_btn_Click(object sender, EventArgs e)
        {
            //başla butonuna basıldğında timer başlatmak için
            timer1.Start();
            //Başladığında rastgele bir resim getirmek için
            RastgeleGetir();
        }

        private void Bekle_btn_Click(object sender, EventArgs e)
        {
            //timer durdurmak için
            timer1.Stop();
            //zaman durduğunda meyve sıkamamk için butonları kapattım
            narenciye_btn.Enabled = false;
            kati_meyve_btn.Enabled = false;
            Basla_btn.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer çalışırken sayac düşürmek için
            sayac--;
            KalanSaniye_lbl.Text = sayac.ToString();
            if (sayac == 0)//sayac değişkeni yani saniye 0 olduğunda tüm butonları kapatır ve timer durdurur
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

            if (files[rastGeleMeyve].Name == "portakal.jpg")//gelen resmin ismi portakal ise portakal için gerekli fonksiyonlar çalışır
            {
                Portakal portakal = new Portakal();//portakal sınıfından bir nesne üretir
                meyveAgirlik_lbl.Text = portakal.agirlik.ToString();//ağırlığı direkt kurucu fonksiyonda çalıştığı için hesaplanıp labela yazdırlırı
                double verim = portakal.VerimHesapla();//sınıfa ait fonksiyonlar çalıştırılır
                double vitA = portakal.VitAHesapla(verim);
                double vitC = portakal.VitCHesapla(verim);
                Topla(vitA, vitC);//Formda toplam vitamin değerlerini görmek için
                sonVerim_lbl.Text = verim.ToString();//herzaman son sıkılan meyvennin değerleri  gösterilir
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            else if(files[rastGeleMeyve].Name == "mandalina.jpg")//gelen resmin ismi mandalina ise mandalina için gerekli fonksiyonlar çalışır
            {
                Mandalina mandalina = new Mandalina();//mandalina sınıfından bir nesne üretir
                meyveAgirlik_lbl.Text = mandalina.agirlik.ToString();//ağırlığı direkt kurucu fonksiyonda çalıştığı için hesaplanıp labela 
                double verim = mandalina.VerimHesapla();//sınıfa ait fonksiyonlar çalıştırılır
                double vitA = mandalina.VitAHesapla(verim);
                double vitC = mandalina.VitCHesapla(verim);
                Topla(vitA, vitC);//Formda toplam vitamin değerlerini görmek için
                sonVerim_lbl.Text = verim.ToString();//herzaman son sıkılan meyvennin değerleri  gösterilir
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            else if(files[rastGeleMeyve].Name == "greyfurt.jpg")//gelen resmin ismi greyfurt ise greyfurt için gerekli fonksiyonlar çalışır
            {
                Greyfurt greyfurt = new Greyfurt();//greyfurt sınıfından bir nesne üretir
                meyveAgirlik_lbl.Text = greyfurt.agirlik.ToString();//ağırlığı direkt kurucu fonksiyonda çalıştığı için hesaplanıp labela 
                double verim = greyfurt.VerimHesapla();//sınıfa ait fonksiyonlar çalıştırılır
                double vitA = greyfurt.VitAHesapla(verim);
                double vitC = greyfurt.VitCHesapla(verim);
                Topla(vitA, vitC);//Formda toplam vitamin değerlerini görmek için
                sonVerim_lbl.Text = verim.ToString();//herzaman son sıkılan meyvennin değerleri  gösterilir
                sonAV_lbl.Text = vitA.ToString();
                sonCV_lbl.Text = vitC.ToString();
            }
            RastgeleGetir();
        }

        private void kati_meyve_btn_Click(object sender, EventArgs e)
        {
            sikilanMeyveSayisi++;
            toplamMeyve_lbl.Text = sikilanMeyveSayisi.ToString();

            if (files[rastGeleMeyve].Name == "cilek.jpg")//gelen resmin ismi cilek ise cilek için gerekli fonksiyonlar çalışır
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
            else if (files[rastGeleMeyve].Name == "armut.jpg")//gelen resmin ismi armut ise armut için gerekli fonksiyonlar çalışır
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
            else if (files[rastGeleMeyve].Name == "elma.jpg")//gelen resmin ismi elma ise elma için gerekli fonksiyonlar çalışır
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
            double toplamA = Convert.ToDouble(toplamAV_lbl.Text);//önceki A vitaminin toplam değeri alınır
            toplamA = toplamA + vitA;//yeni sıkılan meyvenin değerleri eklenir
            toplamA = Math.Round(toplamA, 2);//virgülden sonra iki haneye kadar yuvarlar
            toplamAV_lbl.Text = toplamA.ToString();//label'a yazar

            double toplamC = Convert.ToDouble(toplamCV_lbl.Text);//önceki C vitaminin toplam değeri alınır
            toplamC = toplamC + vitC;//yeni sıkılan meyvenin değerleri eklenir
            toplamC = Math.Round(toplamC, 2);//virgülden sonra iki haneye kadar yuvarlar
            toplamCV_lbl.Text = toplamC.ToString();//label'a yazar
        }
        private void RastgeleGetir()
        {
            rastGeleMeyve = rnd.Next(6);//6 resmimiz olduğu için 0 ile 6 arasında rastgele bir değer üretir
            pictureBox1.ImageLocation = dosyalar[rastGeleMeyve];//resmi formda görmek için

            //portakal greyfurt ve mandalina ise narenciye butonu aktif edilir kati meyve butonu deaktif edilir. Else kısmında tam tersi
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
