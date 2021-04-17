using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210307_odev3
{
    class Buzdolabi:Urun
    {
        public string icHacim;
        public string enerjiSinifi;
        Random rastgele = new Random();
        public Buzdolabi()
        {
            ad = "Liar";
            model = "Liar Series";
            ozellik = "cok soguk";
            hamFiyat = 12000;
            icHacim = "700 LT";
            enerjiSinifi = "A+++++";
            stokAdedi = rastgele.Next(0, 100);

        }
        public Buzdolabi(string ad, string model, string ozellik, int hamFiyat, int secilenAdet,string icHacim,string enerjiSinifi) : base(ad, model, ozellik, hamFiyat, secilenAdet)
        {
           
            this.icHacim = icHacim;
            this.enerjiSinifi = enerjiSinifi;
        }
    }
}
