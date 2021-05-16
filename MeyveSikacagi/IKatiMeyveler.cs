using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    interface IKatiMeyveler
    {
        //bu arayüzü kullanacak sınıflarda olması gereken fonksiyonları oluşturdum
        double VerimHesapla();
        double VitAHesapla(double verim);
        double VitCHesapla(double verim);
    }
}
