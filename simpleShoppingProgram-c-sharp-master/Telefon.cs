using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b191210307_odev3
{
    class Telefon:Urun
    {
        public string dahiliHafiza;
        public string ramKapasitesi;
        public string pilGucu;
        Random rastgele2 = new Random((int)DateTime.Now.Ticks);
        public Telefon()
        {
            ad = "SEMSANG";
            model = "A1";
            ozellik = "cok ozellikli";
            hamFiyat = 1800;
            dahiliHafiza = "32 GB";
            ramKapasitesi = "8 GB";
            pilGucu = "5100 mAh";
            stokAdedi = rastgele2.Next(0, 100);
        }
        public Telefon(string ad, string model, string ozellik, int hamFiyat, int secilenAdet, string dahiliHafiza,string ramKapasitesi, string pilGucu) : base(ad, model, ozellik, hamFiyat, secilenAdet)
        {
            
            this.dahiliHafiza = dahiliHafiza;
            this.ramKapasitesi = ramKapasitesi;
            this.pilGucu = pilGucu;
        }
    }
}
