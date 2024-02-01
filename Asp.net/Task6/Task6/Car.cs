using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Car:Vehicle
    {
        public string PalletNo { get; set; }
        public string Color { get; set; }

        
        public Car(string make, int year, string type, double price, string model, string palletNo, string color)
               : base(make, year, type, price, model)
        {
            PalletNo = palletNo;
            Color = color;
        }
        public string GetDetails()
        {
            return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price:C}, Model: {Model}, PalletNo: {PalletNo}, Color: {Color}";
        }


    }
}
