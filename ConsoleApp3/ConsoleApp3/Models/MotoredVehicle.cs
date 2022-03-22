using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class MotoredVehicle
    {
        public string make;
        public string model;
        public string year;
        
        public MotoredVehicle()
        {

        }

        public MotoredVehicle(string make, string model, string year)
        {
            this.make= make;
            this.model= model;
            this.year= year;

        }

        public void GetInfo()
        {
            Console.WriteLine("You can get info about make, model and year of vehicle");
        }
        public void GetDetailedInfo()
        {
            Console.WriteLine("Make is "+make+"    Model is "+model+"   Year is "+year);
        }
    }
}
