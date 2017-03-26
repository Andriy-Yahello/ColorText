using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumColor
{
    public static class Printer
    {
        public static void Print(string str, int color)
        {
            switch (color)
            {
                case (int)EnumT.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
                case (int)EnumT.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
                case (int)EnumT.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
                case (int)EnumT.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
                case (int)EnumT.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(str);
                    Console.ResetColor();
                    break;
            }
        }
    }
}
