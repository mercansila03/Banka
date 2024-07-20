using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int para = 1000;
            bool devam = true;
            while (devam) { 
                
                Console.WriteLine("1-Para çek,2-Para yatır,3-Bakiye gör,4-Çıkış");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.Write("Kaç tl çekmek istersiniz? ");
                    int cek = Convert.ToInt32(Console.ReadLine());
                    if (cek > para)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    else
                    {
                        para -= cek;
                        Console.WriteLine("Çekim işi yapıldı.");
                    }   
                }
                else if (secim == 2)
                {
                    Console.Write("Kaç tl yatırmak istiyorsunuz? ");
                    int yatir = Convert.ToInt32(Console.ReadLine());
                    para += yatir;
                }
                else if (secim == 3)
                {
                    Console.Write("Bakiye gör ");
                    Console.WriteLine("Bakiye:"+para);
                }
                else if (secim == 4) {
                    
                    devam = false;            
                }

                Console.Write("çıkış yapılıyor!!");
                Console.ReadKey();
            }

            


        }
    }
}
