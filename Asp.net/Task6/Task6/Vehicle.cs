using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Vehicle
    {

        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }


        public Vehicle(string Make, int Year, string Type, double Price, string Model)
        {
            this.Make = Make;
            this.Year = Year;
            this.Type = Type;
            this.Price = Price;
            this.Model = Model;
        }


        public string StartEngine()
        {
            return "Engine started";
        }

        public string StopEngine()
        {
            return "Engine stopped";
        }

      
    }
}

