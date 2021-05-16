using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    class Greyfurt: INarenciye
    {
        public int agirlik { get; set; }

        private double _VitA;
        private double _VitC;
        private double _verim;

        Random rnd;

        public Greyfurt()
        {
            //Random sınıfından bir nesne ürettim
            rnd = new Random();
            //agirlik property'sine 70 ile 120 arasında rastgele bir deger atadım
            agirlik = rnd.Next(70, 120);
        }

        public double VerimHesapla()
        {
            //30 ile 70 arasında rastgele bir tam sayı atadıms
            int yuzde = rnd.Next(30, 70);
            //Yukarıda oluşan değere gçre rastgele bir verim değeri oluşturdum.
            _verim = Convert.ToDouble((agirlik * yuzde) / 100);
            return _verim;
        }

        public double VitAHesapla(double verim)
        {
            //verim üzerinden A vitamini değerini hesapladım
            _VitA = (verim * 3) / 100;
            return _VitA;
        }

        public double VitCHesapla(double verim)
        {
            //verim üzerinden C vitamini değerini hesapaldım
            _VitC = (verim * 44) / 100;
            return _VitC;
        }
    }
}
