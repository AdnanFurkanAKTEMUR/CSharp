﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    class Mandalina: INarenciye
    {
        public int agirlik { get; set; }

        private double _VitA;
        private double _VitC;
        private double _verim;

        Random rnd;

        public Mandalina()
        {
            rnd = new Random();
            agirlik = rnd.Next(70, 120);
        }

        public double VerimHesapla()
        {
            int yuzde = rnd.Next(30, 70);
            _verim = Convert.ToDouble((agirlik * yuzde) / 100);
            return _verim;
        }

        public double VitAHesapla(double verim)
        {
            _VitA = (verim * 681) / 100;
            return _VitA;
        }

        public double VitCHesapla(double verim)
        {
            _VitC = (verim * 26) / 100;
            return _VitC;
        }
    }
}
