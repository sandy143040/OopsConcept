using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    class Program:Interface_One,Interface_Two
    {
        static void Main(string[] args)
        {
            Interface_One interface_One = new Program();
            interface_One.One();

           Interface_Two interface_Two = new Program();
            interface_Two.Two();
            Interface_One interface_Second = new InterfaceSecond();
            interface_Second.One();
            Console.ReadLine();
        }

        public void One()
        {
            Console.WriteLine("Sandeep");
        }

        public void Two()
        {
            Console.WriteLine("Singh");
        }
    }
}
