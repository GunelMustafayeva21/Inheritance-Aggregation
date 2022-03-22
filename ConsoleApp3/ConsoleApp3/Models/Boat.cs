using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Boat:MotoredVehicle
    {
        public string PassangerCount;
        public string Transmission;
        public string Color;

        public Boat(string make, string model, string year, string PassangerCount, string Transmission, string Color):base(make, model, year)
        {
            this.PassangerCount=PassangerCount;
            this.Transmission=Transmission;
            this.Color=Color;
        }
    }
}
