using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            string text=Console.ReadLine();
            Console.WriteLine(text);


            //Task3

            double var1 = 3.2;
            string var2 = "name";
            char var3 = 'a';
            bool var4 = false;
            int var5 = 6;
            const int var6 = 7;

            Console.WriteLine(var1 + "\n" + var2 + "\n" + var3 + "\n" + var4 + "\n" + var5 + "\n" + var6);

            

            //Task3

            string[] cars = { "Mercedes", "Ford","BMW" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Number of Cars:" +cars.Length);

            //Task4

            Console.Write("Firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Lastname: ");
            string lastName = Console.ReadLine();

            Console.Write("Year of birth: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstName+" "+lastName+" "+birthYear);

            
            //Task(5-6)
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] task5 = new int[size];
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write("index-"+(i+1)+":");
                task5[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nElements in the array:");

            foreach (int element in task5)
            {
                Console.Write(element+" ");
            }

            Console.WriteLine();

            foreach (int element in task5)
            {
                sum += element;
            }

            Console.Write("Sum of all elements stored in the array is :"+sum);

            Console.WriteLine();
           

        }
    }
}
