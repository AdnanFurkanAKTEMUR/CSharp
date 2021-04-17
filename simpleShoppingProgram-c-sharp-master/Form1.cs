/* 
 
                   ADNAN FURKAN AKTEMUR
                  adnanfurkan77@gmail.com
 
 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b191210307_odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void fiyatlariYerlestir()
        {
            Tv televizyon = new Tv();
            fiyat1lbl.Text = televizyon.hamFiyat.ToString();
            stok1lbl.Text = televizyon.stokAdedi.ToString();

            Buzdolabi buz = new Buzdolabi();
            fiyat2lbl.Text = buz.hamFiyat.ToString();
            stok2lbl.Text = buz.stokAdedi.ToString();

            Laptop pc = new Laptop();
            fiyat3lbl.Text = pc.hamFiyat.ToString();
            stok3lbl.Text = pc.stokAdedi.ToString();

            Telefon tel = new Telefon();
            fiyat4lbl.Text = tel.hamFiyat.ToString();
            stok4lbl.Text = tel.stokAdedi.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fiyatlariYerlestir();
            this.Text = "Shopping Timeee";
        }
        float toplamFiyat1 = 0;
        int ilktvs, ilkpcs, ilkbzs, ilktls;
        private void sptEkleBtn_Click(object sender, EventArgs e)
        {
            int tvs, pcs, bzs, tls;
            
            tvs = Convert.ToInt32(stok1lbl.Text);
            ilktvs= Convert.ToInt32(stok1lbl.Text);

            bzs = Convert.ToInt32(stok2lbl.Text);
            ilkbzs= Convert.ToInt32(stok2lbl.Text);

            pcs = Convert.ToInt32(stok3lbl.Text);
            ilkpcs=Convert.ToInt32(stok3lbl.Text);

            tls = Convert.ToInt32(stok4lbl.Text);
            ilktls= Convert.ToInt32(stok4lbl.Text);
            if (listBox1.Items != null)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                toplamFiyat1 = 0;
            }

            if (tvs>=numericUpDown1.Value && bzs>=numericUpDown2.Value && pcs>=numericUpDown3.Value && tls >= numericUpDown4.Value)
            {
                
                float kdvTv, kdvBz, kdvLap, kdvTel;
                    tvs = tvs - Convert.ToInt32(numericUpDown1.Value);
                    stok1lbl.Text = tvs.ToString();
                    bzs = bzs - Convert.ToInt32(numericUpDown2.Value);
                    stok2lbl.Text = bzs.ToString();
                    pcs = pcs - Convert.ToInt32(numericUpDown3.Value);
                    stok3lbl.Text = pcs.ToString();
                    tls = tls - Convert.ToInt32(numericUpDown4.Value);
                    stok4lbl.Text = tls.ToString();

                if (numericUpDown1.Value > 0)
                {
                    int x = Convert.ToInt32(numericUpDown1.Value);
                    listBox1.Items.Add(numericUpDown1.Value.ToString());
                    listBox2.Items.Add("Televizyon");
                    Tv tv1 = new Tv();
                    kdvTv = (tv1.hamFiyat * 18) / 100 + tv1.hamFiyat;
                    kdvTv = kdvTv * x;
                    listBox3.Items.Add(kdvTv.ToString() + "  TL");
                    toplamFiyat1 = toplamFiyat1 + kdvTv;
                    
                    
                }
                if (numericUpDown2.Value > 0)
                {
                    int y = Convert.ToInt32(numericUpDown2.Value);
                    listBox1.Items.Add(numericUpDown2.Value.ToString());
                    listBox2.Items.Add("Buzdolabı");

                    Buzdolabi buzdolabi = new Buzdolabi();
                    kdvBz = (buzdolabi.hamFiyat * 5) / 100 + buzdolabi.hamFiyat;
                    kdvBz = kdvBz * y;
                    listBox3.Items.Add(kdvBz.ToString() + "  TL");
                    toplamFiyat1 = toplamFiyat1 + kdvBz;
                }
                if (numericUpDown3.Value > 0)
                {
                    int z = Convert.ToInt32(numericUpDown3.Value);
                    listBox1.Items.Add(numericUpDown3.Value.ToString());
                    listBox2.Items.Add("Laptop");

                    Laptop laptop = new Laptop();
                    kdvLap = (laptop.hamFiyat * 15) / 100 + laptop.hamFiyat;
                    kdvLap = kdvLap * z;
                    listBox3.Items.Add(kdvLap.ToString() + "  TL");
                    toplamFiyat1 = toplamFiyat1 + kdvLap;
                }
                if (numericUpDown4.Value > 0)
                {
                    int i = Convert.ToInt32(numericUpDown4.Value);
                    listBox1.Items.Add(numericUpDown4.Value.ToString());
                    listBox2.Items.Add("Telefon");

                    Telefon telefon = new Telefon();
                    kdvTel = (telefon.hamFiyat * 20) / 100 + telefon.hamFiyat;
                    kdvTel = kdvTel * i;
                    listBox3.Items.Add(kdvTel.ToString() + "  TL");
                    toplamFiyat1 = toplamFiyat1 + kdvTel;

                }
                toplamFiyat.Text = toplamFiyat1.ToString() + "  TL";
            }

          else if (numericUpDown1.Value > tvs || numericUpDown2.Value > bzs || numericUpDown3.Value > pcs || numericUpDown4.Value > tls)
            {

                Alert alert = new Alert();
                if (numericUpDown1.Value > tvs)
                {
                    alert.alertLabel.Text = "Stokta Televizyon Kalmadı.\nVeya stok adedinden fazla girdiniz.";
                    alert.Show();
                    numericUpDown1.Value = 0;
                }

               else if (numericUpDown2.Value > bzs)
                {
                    alert.alertLabel.Text = "Stokta Buzdolabı Kalmadı.\nVeya stok adedinden fazla girdiniz.";
                    alert.Show();
                }

               else if (numericUpDown3.Value > pcs)
                {
                    alert.alertLabel.Text = "Stokta Laptop Kalmadı.\nVeya stok adedinden fazla girdiniz.";
                    alert.Show();
                }

                else if (numericUpDown4.Value > tls)
                {
                    alert.alertLabel.Text = "Stokta Telefon Kalmadı.\nVeya stok adedinden fazla girdiniz.";
                    alert.Show();
                }


           }
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
        }

        private void sepetTemizleBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            toplamFiyat.Text = "0  TL";
            stok1lbl.Text = ilktvs.ToString();
            stok2lbl.Text = ilkbzs.ToString();
            stok3lbl.Text = ilkpcs.ToString();
            stok4lbl.Text = ilktls.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
