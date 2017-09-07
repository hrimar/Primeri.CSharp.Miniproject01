using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Calculations
    {
        // Дефиниции
        public Formula01 F01=new Formula01();
        public Formula02 F02 = new Formula02();
        public Formula03 F03 = new Formula03();
        public Formula04 F04 = new Formula04();
        public Formula05 F05 = new Formula05();

        // Библиотеки
        private Colors.ForCLI cl = new Colors.ForCLI();

        public Calculations()
        {
        }

        public void commands()
        {
            cl.Default(); Console.WriteLine("Налични команди\n");

            cl.Command(); Console.Write("[яма]");
            cl.Default(); Console.WriteLine(" - пресмятане на строителна яма");

            cl.Command(); Console.Write("[въгъл]");
            cl.Default(); Console.WriteLine(" - пресмятане на вдлъбнат ъгъл");

            cl.Command(); Console.Write("[иъгъл]");
            cl.Default(); Console.WriteLine(" - пресмятане на изпъкнал ъгъл");

            cl.Command(); Console.Write("[съгъл]");
            cl.Default(); Console.WriteLine(" - пресмятане на страничен ъгъл");

            cl.Command(); Console.Write("[изкоп]");
            cl.Default(); Console.WriteLine(" - пресмятане на канален изкоп\n");

        }

    }
}
