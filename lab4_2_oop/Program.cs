using System;

namespace lab4_2_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.ThreeArguments(new DerivedFromB2(),new DerivedFromB1(), new B());
            
            Console.ReadKey();
        }
 
    }
}
