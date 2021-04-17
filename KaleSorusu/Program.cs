using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleSorusu
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] tahta = new char[8, 8];

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    tahta[i, j] = '0';
                }
            }

            Console.WriteLine("Satranç Tahtası oluşturuldu aşağıdaki gibidir");

            void yazdir(char[,] matris)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(matris[i, j] + " ");
                    }
                    Console.WriteLine("");
                }
            }
            yazdir(tahta);
            
            bool yedimi(int x,int y)
            {
                for(int i = 0; i < 8; i++)
                {
                    if (tahta[x, i] == 'K' )
                    {
                        return false;
                    }
                    if(tahta[i, y] == 'K')
                    {
                        return false;
                    }
                    
                }

                return true;
            }
           
            Random rnd = new Random();
            int kaleSayisi = 0;
            void rastGele()
            {
                
                int Xkoord = rnd.Next(8);
                int Ykoord = rnd.Next(8);
                while (kaleSayisi < 8)
                {
                    bool sonuc=yedimi(Xkoord,Ykoord);
                    if (sonuc==false)
                    {
                        //Console.WriteLine("Aynı koordinatta kale var");
                        rastGele();
                    }
                    else
                    {
                        tahta[Xkoord, Ykoord] = 'K';
                        Console.WriteLine("**********************");
                        Console.WriteLine("Adım:"+(kaleSayisi+1));
                        Console.WriteLine("X:" + (Ykoord+1) + " Y:" + (Xkoord+1)+ " koordinatına Kale yerleştirildi(1-8)");
                        yazdir(tahta);
                        Console.WriteLine("**********************");
                        kaleSayisi++;
                    }
                }
                
            }
            rastGele();
            Console.ReadLine();

        }
    }
}
