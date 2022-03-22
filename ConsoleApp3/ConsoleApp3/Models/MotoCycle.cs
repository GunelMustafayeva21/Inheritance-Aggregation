using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal  class MotoCycle: MotoredVehicle
    {
        public string MotorSize;
        public string FuelTankSize;
        public MotoCycle(string make, string model, string year, string MotorSize, string FuelTankSize) : base(make, model, year)
        {
            this.MotorSize = MotorSize;
            this.FuelTankSize = FuelTankSize;

        }
    }

    
}
