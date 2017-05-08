using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    public class UInput
    {
        About.Me about= new About.Me();
        Colors.ForCLI c = new Colors.ForCLI();
        Calculations.Calculations calc = new Calculations.Calculations();

        public UInput()
        {

        }

        public void sayHello()
        {
            c.Default();  Console.WriteLine("Добре дошли в " + about.shortName+"\n"+about.version+"\n");
        }
        public void getUserCommands()
        {           
            string command = "";
            do
            {
                // Вземане на команда:
                c.Prompt(); Console.Write("$ ");
                c.Command();  command=Console.ReadLine();

                // Проверка за налични команди:

                //if (command.ToLower().Contains("команда1"))
                //{
                //    c.Default();  Console.Write("Стартирана е ");
                //    c.Result(); Console.WriteLine("Команда1");
                //}
                if (command.ToLower().Contains("яма")) calc.F01.Calc(command);

                if (command.ToLower().Contains("команда2")) Console.WriteLine("Стартирана е команда2");
                if (command.ToLower().Contains("команда3")) Console.WriteLine("Стартирана е команда3");

            } while (command.ToLower() != "изход");
        }

        public void justTesting()
        {
            Console.WriteLine("Стартиране на UserInput.UInput.justTesting()");
        }
    }
}
