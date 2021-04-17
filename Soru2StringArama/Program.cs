using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2StringArama
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dongu = true;
            while (dongu)
            {
                Console.WriteLine("1. String bir değişkende, string değeri substring kullanmadan ara");
                Console.WriteLine("2. String bir değişkende, string değeri substring kullanarak ara");
                Console.WriteLine("3. Alfabenin karakterleri bir string içinde ara ve kaç defa geçiyor bul ve çiz");
                Console.WriteLine("4. Çıkış");

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("String bir değer bir cümle giriniz:");
                            string deger = Console.ReadLine();
                            Console.WriteLine("Aranacak kelimeyi veya stringi giriniz:");
                            string aranacak = Console.ReadLine();

                            SubstringOlmadan(deger, aranacak);
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("String bir değer bir cümle giriniz:");
                            string deger = Console.ReadLine();
                            Console.WriteLine("Aranacak kelimeyi veya stringi giriniz:");
                            string aranacak = Console.ReadLine();
                            substringKullanarak(deger, aranacak);
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("String bir değer bir cümle giriniz:");
                            string deger = Console.ReadLine();
                            Alfabe(deger);
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Çıkışınız gerçekleşti");
                            dongu = false;
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Yanlış bir değer girdiniz");
                            break;
                        }
                }
                void SubstringOlmadan(string cumleParam, string aranacakParam)
                {
                    int cumleKadar = 0;
                    if (aranacakParam.Length == 1)
                    {//Birharf arıyorsak buraya girecek
                        for (int i = 0; i < cumleParam.Length; i++)//Gelen cümlenin uzunluğu kadar dönecek her harfi ile tek tek karşılaştırma yapmak için
                        {
                            if (cumleParam[i] == aranacakParam[0])//Aradığımız harfi bulursak konsola yazacak.
                            {
                                Console.WriteLine("karakter " + aranacakParam + " index:" + i);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < cumleParam.Length; i++)//Gelen cümlenin uzunluğu kadar dönecek
                        {
                            if (cumleParam[i] == aranacakParam[0])//eğer arnacak kelirnin ilk harfi bulunursa buraya girecek
                            {
                                for (int j = 0; j < aranacakParam.Length; j++)//aranacak kelimenin uznluğu kdar dönecek ki diğer harflerini kontol edelim
                                {
                                    if (cumleParam.Length - i >= aranacakParam.Length && cumleParam[i + j] == aranacakParam[j])
                                    {//cumlenin kalan unluğu ve kelimenin uzunluğunu karşılaştırır. ve bulunan harfden sonraki harfleri karşılaştırır.
                                        cumleKadar++;
                                        if (cumleKadar == aranacakParam.Length)//aranan kelimenin uzunluğu kadar aradık isek ve şartla doğru ise kelimeyi ekrana yazacak
                                        {
                                            Console.WriteLine("string " + aranacakParam + " index:" + i);
                                            cumleKadar = 0;
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
                void substringKullanarak(string cumleParam, string aranacakParam)
                {

                    if (aranacakParam.Length == 1)//Tek bir harf arıyorsam bu ife girecek.
                    {
                        for (int i = 0; i < cumleParam.Length; i++)
                        {
                            if (cumleParam.Substring(i, 1) == aranacakParam)
                            {
                                //string bulunan = cumleParam.Substring(i, 1);
                                Console.WriteLine("karakter " + aranacakParam + " index:" + i);

                            }
                        }
                    }
                    else//kelime arıyorsam buraya girecek andan furkan aktemuradnan
                    {
                        for (int i = 0; i < cumleParam.Length; i++)//Gelencümlenin uzunluğu kadar dönecek
                        {
                            if (cumleParam.Substring(i, 1)[0] == aranacakParam[0])
                            {
                                if (cumleParam.Length - i >= aranacakParam.Length && cumleParam.Substring(i, aranacakParam.Length) == aranacakParam)
                                {
                                    Console.WriteLine("string " + aranacakParam + " index:" + i);
                                }
                            }
                        }
                    }
                }

                void Alfabe(string paragraf)
                {
                    int[] karakterSayilari = new int[29];
                    for (int ver = 0; ver < karakterSayilari.Length; ver++)
                    {
                        karakterSayilari[ver] = 0;
                    }
                    char[] alfabemiz = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
                    paragraf = paragraf.ToUpper(new CultureInfo("tr-TR", false));
                    for (int sayac = 0; sayac < paragraf.Length; sayac++)//Gelen paragrafın uzunluğu kadar dönecek
                    {
                        for (int ic = 0; ic < alfabemiz.Length; ic++)//bu for da alfabe kadar dönecek.
                        {
                            if (paragraf[sayac] == alfabemiz[ic])
                            {
                                karakterSayilari[ic] = karakterSayilari[ic] + 1;
                            }
                        }

                    }


                    Console.WriteLine("KARAKTER SAYISI     GRAFİK GÖSTERİMİ");
                    Console.WriteLine("-------------------------------------");
                    for (int sayac2 = 0; sayac2 < alfabemiz.Length; sayac2++)
                    {
                        grafik(karakterSayilari[sayac2], alfabemiz[sayac2]);
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }

                }
                void grafik(int param, char karakter)
                {
                    Console.Write(karakter + "," + "sayısı:" + param + "            ");
                    for (int i = 0; i < param; i++)
                    {
                        Console.Write(" * ");
                    }
                }
            }
            
        }
    }
}
