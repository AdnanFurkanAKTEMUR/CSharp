using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    //Sıkılabilen meyveler için arayüz
    interface INarenciye
    {
        double VerimHesapla();
        double VitAHesapla(double verim);
        double VitCHesapla(double verim);
    }
}
