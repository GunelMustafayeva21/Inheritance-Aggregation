using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Distance which you wanna to go");
            double distance=Convert.ToDouble(Console.ReadLine());
            
            //For Checking of GetDetailedInfo method
            MotoredVehicle Mt1 = new MotoredVehicle("Nissan", "Altima", "2021");
            Mt1.GetDetailedInfo();

            //For Checking of TurnOn and TurnOff method
            Car c1 = new Car("Nissan", "Altima", "2021", 0.09, 68, "248", "working");
            c1.TurnOn();

            //For Checking of Go method
            c1.Go(distance);

            //For Checking of second GetDetailedInfo method
            Car c2 = new Car("Ford", "Mustang", "2020", 0.12, 61, "400", "working");
            c2.GetDetailedInfo();
            
            //Use  method for child class
            c2.GetDetailedInfo("Ford", "Mustang", "2020", 61);
        }
    }
}
