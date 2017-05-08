using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MainClass
    {
        // дефиниране на библиотеки
       public UserInput.UInput uInput = new UserInput.UInput();
       public About.Me about = new About.Me();

        static void Main(string[] args)
        {        
           // Console.WriteLine("OK");

            MainClass program = new MainClass();

            // Форматиране на програмата:
            Console.Title = program.about.shortName + ", " + program.about.version; // така на конзолата ще пише това!

            // program.uInput.justTesting(); // - програмата води към този метод justTesting()
            program.uInput.sayHello();
            program.uInput.getUserCommands();
        }
    }
}
