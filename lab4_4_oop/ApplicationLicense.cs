using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_4_oop
{
    class ApplicationLicense
    {
        public string Key;

        public void Result()
        {
            if (Key is "3mcA34pAn9c") AllowTrial();
            else if (Key is "pr8Cgh75n0") AllowPro();
            else AllowCommon();
        }
        private void AllowTrial()
        {
                Console.WriteLine("Trial version");
            Console.WriteLine("You can use almost all the fantastic features the app has");
        }
        private void AllowCommon()
        {
                Console.WriteLine("You didn't write any proper keys so you are allowed only free subscription on 30 days");
            Console.WriteLine("You are allowed only default attrubutes");
        }
        private void AllowPro()
        {
                Console.WriteLine("Pro version");
            Console.WriteLine("You have access to all benefits of the app");
        }  
    }
}
