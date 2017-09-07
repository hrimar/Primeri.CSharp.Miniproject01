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
            c.Default();
            Console.WriteLine("Добре дошли в " + about.shortName+"\n"+about.version+"\n");
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
                if (command.ToLower().Contains("яма"))      calc.F01.Calc(command);
                if (command.ToLower().Contains("въгъл"))    calc.F02.Calc(command);
                if (command.ToLower().Contains("иъгъл"))    calc.F03.Calc(command);
                if (command.ToLower().Contains("съгъл"))    calc.F04.Calc(command);
                if (command.ToLower().Contains("изкоп"))    calc.F05.Calc(command);

                if (command.ToLower().Contains("помощ") ||
                    command.ToLower() == "п")               calc.commands();

                if (command.ToLower() == "изчисти" ||
                    command.ToLower() == "и")
                {
                    Console.Clear();

                    c.Default();
                    Console.WriteLine("Добре дошли в " + about.shortName + "\n" + about.version + "\n");
                }


            } while (command.ToLower() != "изход");
        }

        public void justTesting()
        {
            Console.WriteLine("Стартиране на UserInput.UInput.justTesting()");
        }
    }
}
