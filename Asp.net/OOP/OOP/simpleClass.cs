using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class simpleClass
    {

        private string Name { get; set; }

        public simpleClass()
        {
        }

        public simpleClass(string name)
        {
            this.Name = name;
        }

        public void sentence()
        {
            Console.WriteLine("MyClass class has initialized!");
        }

        public void greeting()
        {
            Console.WriteLine($"Hello All, I am {Name}");
        }
    }
}
