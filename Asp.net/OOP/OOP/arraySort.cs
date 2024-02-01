using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class arraySort
    {
        public int[] array { get; set; }

        public int[] sort(int[] arr)
        {
            int[] array2 = new int[arr.Length];
            Array.Copy(arr, array2, arr.Length);
            Array.Sort(array2);
            return array2;
        }
    }
}
