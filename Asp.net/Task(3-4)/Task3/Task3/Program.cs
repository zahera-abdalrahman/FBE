using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //Task2
            string[] fruits ={"Tomato", "Banana", "Watermelon"};

            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            Console.WriteLine(Array.IndexOf(fruits, "Tomato"));

            //Task3
            string[] food= { "Pizza", "Burger", "Noodles", "Pasta", "Rice" };
            string[] sport= { "Tennis", "Basketball", "Soccer" };
            string[] Movie= { "Harry Potter", "The green mile", "one flew over the cuckoos nest", "shawshank redemption" };
            Console.WriteLine("Food:");
            foreach(string foodItem in food)
            {
                Console.Write(foodItem);
            }
            Console.WriteLine("Sport:");
            foreach (string sportItem in sport)
            {
                Console.WriteLine(sportItem);
            }
            Console.WriteLine("Movie:");
            foreach (string movieItem in Movie)
            {
                Console.WriteLine(movieItem);
            }


            //Task4
            Console.WriteLine("Enter three numbers:");
            int sum = 0;
            int[] arrSum= new int[3];
            for(int i = 0; i <arrSum.Length; i++)
            {
                arrSum[i] =Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in arrSum)
            {
                sum += item;
            }
            Console.WriteLine("The sum of three numbers: " + sum);


            //Task5
            int sumOdd = 0;
            for (int i = 1; i <= 100 ; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                    sumOdd += i;
                }
            }    
            Console.WriteLine("The Sum of odd Numbers is: " + sumOdd);

            //Task6
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }




            //Task7

            int counter = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(counter);
                    counter++;
                }

                Console.WriteLine();
            }


        }
    }
}
