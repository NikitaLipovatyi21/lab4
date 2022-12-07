using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_2_oop
{
    class A
    {
        public void TwoArguments(B b1, B b2)
        {
            b1.Name();
            b2.Inheritance(); 
        }
        public void ThreeArguments(B b1, B b2, B b3)
        {
            b1.Name();
            b2.Inheritance();
            b3.Knowledge();
        }
    }
}
