using System;
using System.Collections.Generic;
using System.Text;

namespace MeyveSikacagi
{
    interface IKatiMeyveler
    {
        double VerimHesapla();
        double VitAHesapla(double verim);
        double VitCHesapla(double verim);
    }
}
