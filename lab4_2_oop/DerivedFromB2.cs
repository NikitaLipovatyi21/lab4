using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_2_oop
{
    class DerivedFromB2 : B
    {
        public override void Name()
        {
            Console.WriteLine("I am Derived Class from B number 2");
        }
        public override void Inheritance()
        {
            Console.WriteLine("I was derived from Base class B");
        }
        public override void Knowledge()
        {
            Console.WriteLine("I know evetything about my Base class");
        }
    }
}
