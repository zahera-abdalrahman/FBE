using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ConvertDate
    {

        public DateTime firstDate { get; set; }
        public DateTime secondDate { get; set; }


        public void date(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan difference = firstDate - secondDate;
            int days= difference.Days%30;
            int years = difference.Days / 365;
            int months = (difference.Days % 365) / 30;
            Console.WriteLine($"{Math.Abs(years)} years, {Math.Abs(months)} months, {Math.Abs(months)} days.");
        }


        public DateTime ConvertToDateTime(string dateString)
        {
            return DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
        }
    }
}
