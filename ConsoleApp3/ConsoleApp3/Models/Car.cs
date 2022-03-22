using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Car : MotoredVehicle
    {
        public double FuelUsedPerKm;
        public double FuelAmount;
        public string HorsePower;
        public string IsOn;

        public Car(string make, string model, string year, double FuelUsedPerKm, double FuelAmount, string HorsePower, string IsOn) : base(make, model, year)
        {
            this.FuelUsedPerKm = FuelUsedPerKm;
            this.FuelAmount = FuelAmount;
            this.HorsePower = HorsePower;
            this.IsOn = IsOn;
        }
        public void TurnOn()
        {
            IsOn = "working";
            Console.WriteLine(IsOn);
        }
        public void TurnOff()
        {
            IsOn = "Not working";
            Console.WriteLine(IsOn);
        }
        public void Go(double distance)
        {
            if (IsOn == "Not working")
            {
                Console.WriteLine("Masin ise salinmayib");
            }
            else if (IsOn == "working" && FuelAmount > distance * 0.09)
            {
                Console.WriteLine(distance + " km qet edile biler");
            }
            else
            {
                Console.WriteLine("Kifayet qeder benzin yoxdur");
            }
        }
        public void GetDetailedInfo(string make, string model, string year, double FuelAmount)
        {
            this.FuelAmount=FuelAmount;
            Console.WriteLine("Make is " + make + "    Model is " + model + "   Year is " + year+"    FuelAmount is "+FuelAmount);
        }
         } }
