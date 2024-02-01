using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1

            Console.WriteLine("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("The smaller number is: " + num1);
            }
            else
            {
                Console.WriteLine("The smaller number is: " + num2);
            }

            //Task2

            Console.WriteLine("Enter Number:");
            int sign = Convert.ToInt32(Console.ReadLine());
            if (sign > 0)
            {
                Console.WriteLine("The sign is +");
            }
            else if (sign < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else
            {
                Console.WriteLine(0);
            }


            //Task3
            Console.WriteLine("Enter First Number:");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number:");
            int three = Convert.ToInt32(Console.ReadLine());



            if (one > two && one > three)
            {
                if (two > three)
                {
                    Console.WriteLine(one + " " + two + " " + three);
                }
                else
                {
                    Console.WriteLine(one + " " + three + " " + two);
                }
            }
            else if (two > three && two > one)
            {
                if (one > three)
                {
                    Console.WriteLine(two + " " + one + " " + three);
                }
                else
                {
                    Console.WriteLine(two + " " + three + " " + one);
                }
            }
            else if (three > one && three > two)
            {
                if (one > two)
                {
                    Console.WriteLine(three + " " + one + " " + two);
                }
                else
                {
                    Console.WriteLine(three + " " + two + " " + one);
                }
            }

            //Task4

            int[] arr = new int[5];
            int max;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max number is: " + max);



            //Task5

            Console.Write("Enter speed in kilometers per hour: ");
            double Km = Convert.ToDouble(Console.ReadLine());

            const double convert = 0.6213712;

            double miles = Km * convert;

            Console.WriteLine(miles + " miles per hour");

            //Task6
            Console.Write("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int total = hours * 60 + minutes;

            Console.WriteLine(total + " minutes");


            //Task7
            Console.Write("Enter minutes: ");
            int Minutes = Convert.ToInt32(Console.ReadLine());

            int Hours = Minutes / 60;
            int leftMinutes = Minutes % 60;

            Console.WriteLine(Hours + " Hours," + leftMinutes + " Minutes");



            //Task8
            string[] arrString = new string[5];

            for (int i = 0; i < arrString.Length; i++)
            {
                Console.WriteLine("Enter a sentence: ");
                arrString[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter a fixed length: ");
            int fixedLength = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arrString.Length; i++)
            {
                if (arrString[i].Length > fixedLength)
                {
                    arrString[i] = arrString[i].Substring(0, fixedLength);
                }
            }
            foreach (var item in arrString)
            {
                Console.WriteLine(item);
            }


            //Task9
            Console.Write("Enter a string: ");
            string String = Console.ReadLine();

            string reversedString = reverseOdd(String);

            Console.WriteLine($"Reversed String: {reversedString}");



        }

        public static string reverseOdd(string input)
        {
            string emptyString="";
            string[] words=input.Split(' ');
            for (int i = 0;i<words.Length;i++)
            {
                if (words[i].Length%2!= 0)
                {
                    char[] charArr = words[i].ToCharArray();
                    for (int j = charArr.Length-1; j >=0; j--)
                    {
                        emptyString += charArr[j];
                    }

                }
                else
                {
                    emptyString += words[i];
                }

                emptyString += " ";
            }
            return emptyString;
        }
    }
}
