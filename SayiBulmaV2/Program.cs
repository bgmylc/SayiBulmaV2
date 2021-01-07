using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulmaV2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rastgeleSayiUretici = new Random();
            int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
            bool sayiBulunduMu = false;


            while (!sayiBulunduMu) 
            {


                Console.WriteLine("Tahmininizi girin: ");
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

                if (uretilenSayi > tahminEdilenSayi)
                {
                    Console.WriteLine("Yukarı çık ");
                }
                else if (uretilenSayi < tahminEdilenSayi)
                {
                    Console.WriteLine("Aşağı in");
                }
                else
                {
                    Console.WriteLine("TEBRİKLER :D ");
                    Console.WriteLine("Bir daha oynayalım mı? (E/H): ");
                    string oynamaKabul = Console.ReadLine();
                    if (oynamaKabul == "E")
                    {

                        Random rastgeleSayi = new Random();
                        uretilenSayi = rastgeleSayi.Next(100);
                        continue;
                    }
                    else if (oynamaKabul == "H")
                    {
                        Console.WriteLine("Güle Güle!");
                        sayiBulunduMu = true;

                    }

                }

            }
            Console.ReadLine();
        }
    }
}
