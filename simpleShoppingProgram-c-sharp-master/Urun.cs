using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210307_odev3
{
    class Urun
    {
        public string ad;
        public string model;
        public string ozellik;
        public int stokAdedi;
        public int hamFiyat;
        public int secilenAdet;
        Random rastgele = new Random((int)DateTime.Now.Ticks);
        public Urun()
        {

        }
        public Urun(string ad,string model,string ozellik, int hamFiyat, int secilenAdet)
        {
            
            this.ad = ad;
            this.model = model;
            this.ozellik = ozellik;
            this.hamFiyat = hamFiyat;
            this.secilenAdet = secilenAdet;
            stokAdedi = rastgele.Next(0, 100);
        }

    }
}
