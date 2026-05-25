#define CUBE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 32;
            int b = 32;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(".");
            Console.CursorLeft = a;
            Console.CursorTop  = b;
            Console.Beep(32, 32);
            Console.ResetColor();

        }
    }
}
