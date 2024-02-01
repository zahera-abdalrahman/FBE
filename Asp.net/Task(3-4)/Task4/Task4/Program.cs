using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            int[] arrSum = new int[10];
            for (int i = 0; i < arrSum.Length; i++)
            {
                arrSum[i] = Convert.ToInt32(Console.ReadLine());
            }
            sumAndAvg(arrSum);



            //Task2
            Console.WriteLine("Input number of terms :");
            int number = Convert.ToInt32(Console.ReadLine());
            cube(number);



            //Task3
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            getYears(years);


            //Task4
            int ageInYears = Convert.ToInt32(Console.ReadLine());
            int ageInDays = Age(ageInYears);
            Console.WriteLine($"Age in days: {ageInDays}");


            //Task5
            Console.WriteLine("Enter number of chickens: ");
            int chicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of cows: ");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of pigs: ");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(animals(chicken, cows, pigs));


            //Task6
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine(login(userName, password));

            //Task7
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter base: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(power(num, baseNum));

            //Task8
            Console.Write("Enter a year between 1900 and 2024: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year >= 1900 && year <= 2024)
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a year within the specified range.");
            }


            //Task9
            Console.WriteLine("Enter number: ");
            int primeNum = Convert.ToInt32(Console.ReadLine());
            if(prime(primeNum))
            {
                Console.WriteLine(primeNum+" is prime number");
            }
            else
            {
                Console.WriteLine(primeNum + " is not prime number");
            }
            //Task10
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentenceLength(sentence));

        }

        static void sumAndAvg(int[] sumAndAvg)
        {
            int sum = 0;
            foreach (int i in sumAndAvg)
            {
                sum += i;
            }
            double avg = Convert.ToDouble(sum) / sumAndAvg.Length;
            Console.WriteLine("The sum of 10 no is : " + sum);
            Console.WriteLine("The Average is : " + avg);
        }


        static void cube(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{Math.Pow(i, 3)}");
            }
        }


        static void getYears(int[] years)
        {
            foreach (var item in years)
            {
                if (item > 1950)
                {
                    Console.WriteLine(item);
                }
            }
        }


        static int Age(int ageInYears)
        {
            int daysYear = 365;
            int ageInDays = (int)(ageInYears * daysYear);
            return ageInDays;
        }


        static int animals(int chickens, int cows, int pigs)
        {
            return chickens * 2 + cows * 4 + pigs * 4;
        }

        static string login(string username,string password)
        {
            string[] usernames = { "zainab", "nour", "sara" };
            string[] passwords = { "pass1", "pass2", "pass3" };
            for (int i = 0;i<username.Length;i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return "login successful";
                }
            }
            return "login failed";
        }

        static double power(int number,int baseNum)
        {
            return Math.Pow(number,baseNum);
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }

        static bool prime(int number)
        {
            int count = 0;
            if (number <= 3)
            {
                return true; 
            }

            for (int i = 1; i <= number; i++)
            {
                if(number% i == 0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                return true;
            }
            return false;
        }

        static int sentenceLength(string sentence)
        {
            int count = 1;
            foreach(char c in sentence)
            {
                if(c==' ')
                {
                    count++;
                }
            }
            return count;
        }

    }
}
