using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210307_odev3
{
    class Laptop:Urun
    {
        public string ramKapasitesi;
        public string dahiliHafiza;
        public string ekranCozunurlugu;
        public string ekranBoyutu;
        public string pilGucu;

        Random rastgele1 = new Random((int)DateTime.Now.Ticks);
        public Laptop()
        {
            ad = "kespir";
            model = "high model";
            ozellik = "az ozellikli";
            hamFiyat = 5100;
            ramKapasitesi = "8 GB";
            dahiliHafiza = "1 TB";
            ekranBoyutu = "20 inc";
            ekranCozunurlugu = "1920x1920";
            pilGucu = "12000 mAh";
            stokAdedi = rastgele1.Next(0, 100);
        }
        public Laptop(string ad, string model, string ozellik, int hamFiyat, int secilenAdet, string ramKapasitesi,string dahiliHafiza,string ekranCozunurlugu, string ekranBoyutu,string pilGucu) : base(ad, model, ozellik, hamFiyat, secilenAdet)
        {
            
            this.ramKapasitesi = ramKapasitesi;
            this.dahiliHafiza = dahiliHafiza;
            this.ekranBoyutu = ekranBoyutu;
            this.ekranCozunurlugu = ekranCozunurlugu;
            this.pilGucu = pilGucu;
        }
    }
}
