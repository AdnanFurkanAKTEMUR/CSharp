using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    class Cilek:IKatiMeyveler
    {
        public int agirlik { get; set; }
        
        private double _VitA;
        private double _VitC;
        private double _verim;

        Random rnd;

        public Cilek()
        {
            //Random sınıfından bir nesne ürettim
            rnd = new Random();
            //agirlik property'sine 70 ile 120 arasında rastgele bir deger atadım
            agirlik = rnd.Next(70, 120);
        }

        public double VerimHesapla()
        {
            //80 ile 95 arasında rastgele bir tam sayı atadıms
            int yuzde = rnd.Next(80, 95);
            _verim = Convert.ToDouble((agirlik * yuzde) / 100);
            return _verim;
        }

        public double VitAHesapla(double verim)
        {
            //verim üzerinden A vitamini değerini hesapladım
            _VitA = (verim * 12) / 100;
            return _VitA;
        }

        public double VitCHesapla(double verim)
        {
            //verim üzerinden C vitamini değerini hesapladım
            _VitC = (verim * 60) / 100;
            return _VitC;
        }
    }
}
