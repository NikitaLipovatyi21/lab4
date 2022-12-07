using System;

namespace lab4_4_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationLicense license = new ApplicationLicense();
            Console.WriteLine("Write a key to get an access to version you have");
            license.Key = Console.ReadLine();
            license.Result();
            Console.ReadKey();
        }
    }
}
