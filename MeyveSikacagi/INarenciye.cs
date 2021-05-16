using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    //Sıkılabilen meyveler için arayüz
    interface INarenciye
    {
        //bu arayüzü kullanacak sınıflarda olması gereken fonksiyonları oluşturdum
        double VerimHesapla();
        double VitAHesapla(double verim);
        double VitCHesapla(double verim);
    }
}
