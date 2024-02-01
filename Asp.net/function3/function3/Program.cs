using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace function3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Enter number one:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addNumber(num1, num2));


            //Task2

            Console.WriteLine("Enter a number:");
            string trimNumber = Console.ReadLine();
            Console.WriteLine(trimZero(trimNumber));


            //Task3
            Console.WriteLine("Enter the length of the array: ");
            int arrlength = Convert.ToInt32(Console.ReadLine());
            int[] secondMax = new int[arrlength];
            for (int i = 0; i < secondMax.Length; i++)
            {
                secondMax[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(secondMax);


            //Task4
            Console.WriteLine(repdigit(66));
            Console.WriteLine(repdigit(0));
            Console.WriteLine(repdigit(-11));

            //Task5
            Console.WriteLine("Enter string:");
            string arrStringLength = Console.ReadLine();
            Console.WriteLine(arrayStrings(arrStringLength));



            //Task6
            Console.WriteLine("Enter the length of the array:");
            int sevenArrayLength = Convert.ToInt32(Console.ReadLine());
            int[] sevenArray = new int[sevenArrayLength];
            for (int i = 0; i < sevenArray.Length; i++)
            {
                sevenArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(SevenBoom(sevenArray));



            //Task7
            string whiteSpace = Console.ReadLine();
            Console.WriteLine(insertWhitespace(whiteSpace));


            //Task8
            Console.WriteLine("Enter the length of the array:");
            int arrBoolLength = Convert.ToInt32(Console.ReadLine());
            bool[] boolArray = new bool[arrBoolLength];
            for (int i = 0; i < boolArray.Length; i++)
            {
                boolArray[i] = Convert.ToBoolean(Console.ReadLine());
            }
            countTrue(boolArray);



            //Task9
            Console.WriteLine(capToFront("hApPy"));
            Console.WriteLine(capToFront("moveMENT"));
            Console.WriteLine(capToFront("shOrtCAKE"));



            //Task10
            Console.WriteLine(matchLastItem(new string[] { "rsq", "6hi", "g", "rsq6hig" }));
            Console.WriteLine(matchLastItem(new object[] { 1, 1, 1, "11" }));
            Console.WriteLine(matchLastItem(new object[] { 8, "thunder", true, "8thundertrue" }));


            //Task11
            Console.WriteLine(findNaN(new double[] { 1, 2, double.NaN }));
            Console.WriteLine(findNaN(new double[] { double.NaN, 1, 2, 3, 4 }));
            Console.WriteLine(findNaN(new double[] { 0, 1, 2, 3, 4 }));



            //Task12
            Console.WriteLine(string.Join(", ", RemoveDups(new object[] { 1, 0, 1, 0 })));
            Console.WriteLine(string.Join(", ", RemoveDups(new string[] { "The", "big", "cat" })));
            Console.WriteLine(string.Join(", ", RemoveDups(new string[] { "John", "Taylor", "John" })));


            //Task13
            Console.WriteLine(convertTime("07:05:45PM"));
            Console.WriteLine(convertTime("12:40:22AM"));



            //Task14
            Console.WriteLine(removeLastVowel("Those who dare to fail miserably can achieve greatly."));



            //Task15

            Console.WriteLine(sumOfCubes(new int[] { 1, 5, 9 }));
        }

        static int addNumber(int num1, int num2)
        {
            return num1 + num2;
        }
        ///////////
        static string trimZero(string num)
        {
            string afterZero = num.TrimStart('0').TrimEnd('0');
            return afterZero;
        }
        /////////
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(arr[1]);
        }
        ///////
       static bool repdigit(int number)
        {
            string a = number.ToString();
            bool b = false;
            if (number < 0)
            {
                return false;
            }
            else if (number == 0)
            {
                b = true;
            }
            else for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] == a[i + 1])
                    {
                        b = true;
                    }
                }
            return b;
        }
        ///////
        static string arrayStrings(string sentence)
        {
            string[] strings = sentence.Split(' ');
            string reverse = "";
            for (int i = strings.Length-1; i >=0; i--) 
            {
                reverse += strings[i]+" ";
            }
            return reverse;
        }
        ///////
        static string SevenBoom(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (ContainsSeven(number))
                {
                    return "Boom!";
                }
            }

            return "There is no 7 in the array";
        }

        static bool ContainsSeven(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 7)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }
        ///////
        static void countTrue(bool[] arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if(item)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        ///////
        static string insertWhitespace(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                result += currentChar;

                if (i < input.Length - 1)
                {
                    char nextChar = input[i + 1];

                    if (char.IsLower(currentChar) && char.IsUpper(nextChar))
                    {
                        result += ' '; 
                    }
                }
            }

            return result;
        }

        ///////
        static string capToFront(string word)
        {
            string capitals = "";
            string lowercase = "";

            foreach (char c in word)
            {
                if (char.IsUpper(c))
                {
                    capitals += c;
                }
                else
                {
                    lowercase += c;
                }
            }

            return capitals + lowercase;
        }

        ///////
        static bool matchLastItem(object[] items)
        {
            if (items.Length == 0)
            {
                return true;
            }

            string lastItem = items[items.Length - 1].ToString();
            string concatenatedItems = "";

            for (int i = 0; i < items.Length - 1; i++)
            {
                concatenatedItems += items[i].ToString();
            }

            return lastItem == concatenatedItems;
        }

        ///////
        static int findNaN(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (double.IsNaN(numbers[i]))
                {
                    return i; 
                }
            }

            return -1;
        }
        //////////
        static T[] RemoveDups<T>(T[] items)
        {
            List<T> result = new List<T>();

            foreach (T item in items)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
        /////////
        static string convertTime(string time)
        {
            DateTime parsedTime = DateTime.ParseExact(time, "hh:mm:sstt", null);
            return parsedTime.ToString("HH:mm:ss");
        }

        ////////
        static string removeLastVowel(string word)
        {

            string[] words = word.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] characters = words[i].ToCharArray();
                for (int j = characters.Length - 1; j >= 0; j--)
                {
                    if ("aeiouAEIOU".Contains(characters[j]))
                    {
                        characters[j] = '\0';
                        break;
                    }
                   
                }
                words[i] = new string(characters).Replace("\0", "");
            }
            return string.Join(" ", words);
        }
        ////////
        static double sumOfCubes(int[] arr)
        {
            if(arr.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            foreach (var item in arr)
            {
                sum+=Math.Pow(item, 3);
            }
            return sum;
        }
    }
}
