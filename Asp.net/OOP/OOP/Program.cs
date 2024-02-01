using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            simpleClass word=new simpleClass();
            simpleClass name = new simpleClass("John");
            word.sentence();
            name.greeting();

            factorial number1 = new factorial();
            Console.WriteLine(number1.factorialNumber(5));

            arraySort arr=new arraySort();
            int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            arr.sort(array);

            ConvertDate dateObj = new ConvertDate();
            DateTime date1 = new DateTime(1981, 11, 03);
            DateTime date2 = new DateTime(2013, 09, 04);
            dateObj.date(date1, date2);
            Console.WriteLine(dateObj.ConvertToDateTime("2004-08-12"));
        }
    }
}
