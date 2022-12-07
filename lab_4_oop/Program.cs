using System;

namespace lab_4_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            a = b;
            a.WriteDebug("kdfdm", 56, 34.6);
            Console.ReadKey();
        }
    }
}
