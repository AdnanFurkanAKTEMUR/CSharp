using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    class Cilek:IKatiMeyveler
    {
        public double VitA { get; set; }
        public double VitC { get; set; }
        public int agirlik { get; set; }
        public double verim { get; set; }
        public string resimYolu = "resimler/cilek.jpg";
        Random rnd;

        public Cilek()
        {
            rnd = new Random();
            agirlik = rnd.Next(70, 120);
        }

        public double VerimHesapla()
        {
            int yuzde = rnd.Next(80, 95);
            verim = Convert.ToDouble((agirlik * yuzde) / 100);
            return verim;
        }

        public double VitAHesapla(double verim)
        {
            VitA = (verim * 12) / 100;
            return VitA;
        }

        public double VitBHesapla(double verim)
        {
            VitC = (verim * 60) / 100;
            return VitC;
        }
    }
}
