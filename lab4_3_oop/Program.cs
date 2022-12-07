using System;
using lab4_3_oop;
using System.Diagnostics;

namespace lab4_3_oop
{

           internal class Program
          
    {
            static void Main(string[] args)
            {
                Class1 class1 = new Class1();
                class1.Name = "class1";
                Class2 class2 = new Class2();
                class2.Name = "class2";
                Class3 class3 = new Class3();
                class3.Name = "class3";
                Class4 class4 = new Class4();
                class4.Name = "class4";
                Debug.WriteLine(class1.Name + " " + class2.Name + " " + class3.Name + " " + class4.Name);
                Console.ReadKey();
            }
           
    }
   
}
    
