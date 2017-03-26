using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumColor
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type string and color");

            string a = Console.ReadLine();
            int b = Int32.Parse(Console.ReadLine());

            Printer.Print(a, b);


            Console.ReadKey();
        }
    }
}
