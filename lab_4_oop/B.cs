using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_oop
{
    class B : A
    {
         internal override void WriteDebug(string String, int Int, double Double)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Param of type: " + String.GetType());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Param of type: " + Int.GetType());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Param of type: " + Double.GetType());

        }
    }
}
