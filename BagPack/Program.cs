/*
                                                        2020-2021 GUZ DONEMİ OPTİMİSAZYON DERSİ PROJE ODEVİ
                                                                SIRT ÇANTASI PROBLEMİ UYGULAMASI
                                                            
                                                ADNAN FURKAN AKTEMUR B141210013 b141210013@sakarya.edu.tr 2.ogretim A grubu
                                                MERT KARANİ B130910036 1.OGRETİM



*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagPack
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            

            Console.Write("SIRT CANTASI ALGORITMASI YAZILIMI\n\n1-)KENDI DEGERLERINIZI GIRIN(1)\n2-)RASTGELE DEGERLER UZERINDEN DEVAM EDIN(2)(BURADA KAPASITE, ESYA SAYISI VE ESYA DEGERLERI RASTGELEDIR.)\nSECIMINIZ:");
            secim = Convert.ToInt32(Console.ReadLine());


            if (secim == 1)
            {

                
                int deger;
                double kapasite;
                int kacEsya;

                Console.Write("Kac esya olacak:");
                kacEsya = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.Write("Canta kapasitesi ne kadar olacak:");
                kapasite = Convert.ToDouble(Console.ReadLine());

                int[,] esyalar = new int[kacEsya, 2];
                double[] birimDeger = new double[kacEsya];


                for (int i = 0; i < kacEsya; i++)//esyaların agirliklari ve degerlerini alır.
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write((i+1) + ". esyanin agirligini giriniz:");
                            deger = Convert.ToInt32(Console.ReadLine());
                            esyalar[i, j] = deger;
                        }
                        else
                        {
                            Console.Write((i + 1) + ". esyanin degerini giriniz:");
                            deger = Convert.ToInt32(Console.ReadLine());
                            esyalar[i, j] = deger;
                        }

                    }
                }
                Console.Clear();

                for (int i = 0; i < kacEsya; i++)//esyaların degerlerini hesaplar
                {
                    birimDeger[i] = (double)esyalar[i, 1] / esyalar[i, 0];
                }


                Console.WriteLine("        Agirlik " + "   Deger    " + " Birim Deger");
                for (int i = 0; i < kacEsya; i++)//esyalarin agırlık deger ve birim degerlerini konsola basar
                {
                    Console.Write(i + 1 + ". esya  ");
                    for (int j = 0; j < 2; j++)
                    {

                        Console.Write(esyalar[i, j] + "         ");

                    }
                    Console.Write(birimDeger[i]);
                    Console.WriteLine(" ");
                }
                Array.Sort(birimDeger);//Birim degerleri kucukten buyuge siralar
                Array.Reverse(birimDeger);//diziyi ters cevirir


                
                Console.WriteLine("\n\n");
                double toplam = 0.0;
                for (int i = 0; i < kacEsya; i++)//cantaya alinacak degerleri bulup cantaya ekler
                {

                    if (kapasite - toplam >= birimDeger[i])
                    {
                        toplam = toplam + birimDeger[i];
                        Console.WriteLine("Birim degeri:" + birimDeger[i] + " olan esyayi aldim.");
                        if (toplam > kapasite)//olurda kapasite asimi gerceklesirse son eklenen degeri cikarir ve donguden cikar
                        {
                            toplam = toplam - birimDeger[i];
                            Console.WriteLine("\nAlabildigimi aldim.\nCantamda:" + toplam + " degerinde esya var.");
                            break;
                        }
                    }

                }
                Console.WriteLine("\nAlabildigimi aldim.\nCantamda:" + toplam + " degerinde esya var.");
            }
            else if (secim == 2)
            {
                Random rast = new Random();
                int kapasite = rast.Next(10, 31);
                int kacEsya = rast.Next(5, 26);
                int deger;
                int[,] esyalar = new int[kacEsya, 2];
                double[] birimDeger = new double[kacEsya];

                for (int i = 0; i < kacEsya; i++)//rastgele degerler olusturur
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {          
                            deger = rast.Next(1, 26);
                            esyalar[i, j] = deger;
                        }
                        else
                        {   
                            deger = rast.Next(1, 26);
                            esyalar[i, j] = deger;
                        }

                    }
                }
                for (int i = 0; i < kacEsya; i++)//birim degerleri hesaplar
                {
                    birimDeger[i] = (double)esyalar[i, 1] / esyalar[i, 0];
                }
                Console.WriteLine("        Agirlik " + "   Deger    " + " Birim Deger");
                for (int i = 0; i < kacEsya; i++)//tabloyu konsola yazdirir
                {
                    Console.Write(i + 1 + ". esya  ");
                    for (int j = 0; j < 2; j++)
                    {

                        Console.Write(esyalar[i, j] + "         ");

                    }
                    Console.Write(birimDeger[i]);
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\nCANTA KAPASITEM:" + kapasite);

                Array.Sort(birimDeger);
                Array.Reverse(birimDeger);
                Console.WriteLine("\n");

                double toplam = 0.0;
                for (int i = 0; i < kacEsya; i++)//cantaya esyalari alir
                {

                    if (kapasite - toplam >= birimDeger[i])
                    {
                        toplam = toplam + birimDeger[i];
                        Console.WriteLine("Birim degeri:" + birimDeger[i] + " olan esyayi aldim.");
                        if (toplam > kapasite)//olrda tasma olursa son eklenen elemani cikarip dobnguyu bitirir
                        {
                            toplam = toplam - birimDeger[i];
                            Console.WriteLine("Alabildigimi aldim.\nCantamda:" + toplam + " degerinde esya var.");
                            break;
                        }
                    }

                }
                Console.WriteLine("\nAlabildigimi aldim.\nCantamda:" + toplam + " degerinde esya var.");


            }




            Console.ReadKey();
            


        }
    }
}
