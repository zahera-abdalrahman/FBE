using System;
using System.Security.Claims;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car G_Class = new Car("Mercedes", 2023, "SUV", 144150, "G-Class", "123456", "Silver");

            Console.WriteLine(G_Class.StartEngine());
            Console.WriteLine(G_Class.GetDetails());
            Console.WriteLine(G_Class.StopEngine());
        }
    }
}
