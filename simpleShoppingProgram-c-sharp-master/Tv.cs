using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210307_odev3
{
    class Tv:Urun
    {
        public string ekranBoyutu;
        public string cozunurluk;
        Random rastgele3 = new Random((int)DateTime.Now.Ticks);
        public Tv()
        {
            ekranBoyutu = "20 inc";
            cozunurluk = "1920x1440";
            ad = "Televizyon";
            model = "model 1";
            ozellik = "bu ne olaki?";
            hamFiyat = 3000;
            secilenAdet = 0;
            stokAdedi = rastgele3.Next(0, 100);
        }
        public Tv(string ad, string model, string ozellik, int hamFiyat, int secilenAdet, string ekranBoyutu,string cozunurluk) : base(ad, model, ozellik, hamFiyat, secilenAdet)
        {
                
            this.ekranBoyutu = ekranBoyutu;
            this.cozunurluk = cozunurluk;
        }
    }
}
