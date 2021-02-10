using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeInfo.Classes;

namespace BikeInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Bike Motor = new Bike()
            {
                Id = 1,
                Marka = "Honda",
                Model = "CBR 929RR",
                Turu = Turler.SuperSport,
                Cc = 928.90,
                Tork = 55.2,
                Agirlik = 270,
                Yıl = new DateTime(1992,04,19)
            };

            
                Console.WriteLine("ID: " + Motor.Id);
                Console.WriteLine("Marka: " + Motor.Marka);
                Console.WriteLine("Model: " + Motor.Model);
                Console.WriteLine("Tür: " + Motor.Turu);
            Console.WriteLine("CC: " + Motor.Cc);
                Console.WriteLine("Tork: " + Motor.Tork);
                Console.WriteLine("Ağırlık: " + Motor.Agirlik + " Kg.");
                Console.WriteLine("Çıkış Yılı: " + Motor.Yıl);

                Console.WriteLine("----------------------------------");


                Bike Motor2 = new Bike()
                {
                    Id = 2,
                    Marka = "Suzuki",
                    Model = "GSXR 1300 Hayabusa",
                    Turu = Turler.SuperSport,
                    Cc = 1299.9,
                    Tork = 95.8,
                    Agirlik = 310,
                    Yıl = new DateTime(1999, 08, 15)
                };


                Console.WriteLine("ID: " + Motor2.Id);
                Console.WriteLine("Marka: " + Motor2.Marka);
                Console.WriteLine("Model: " + Motor2.Model);
                Console.WriteLine("Tür: " + Motor2.Turu);
                Console.WriteLine("CC: " + Motor2.Cc);
                Console.WriteLine("Tork: " + Motor2.Tork);
                Console.WriteLine("Ağırlık: " + Motor2.Agirlik + " Kg.");
                Console.WriteLine("Çıkış Yılı: " + Motor2.Yıl);

            Console.ReadLine();
        }
    }
}
