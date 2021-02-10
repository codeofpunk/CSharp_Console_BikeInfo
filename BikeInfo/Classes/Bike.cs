using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeInfo.Classes
{
    class Bike
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Cc { get; set; }
        public double Tork { get; set; }
        public DateTime Yıl { get; set; }
        public int Agirlik { get; set; }
        public Turler Turu { get; set; }
    }
}
