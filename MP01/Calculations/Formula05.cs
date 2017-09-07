using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    /// <summary>
    /// Формула за обем на канален изкоп (Формула 05)
    /// </summary>
    public class Formula05
    {
        private Colors.ForCLI cl = new Colors.ForCLI();

        /// <summary>
        /// Конструктор на Формула 05
        /// </summary>
        public Formula05()
        {
        }

        /// <summary>
        /// Метод за пресмятане на Формула 05
        /// </summary>
        public void Calc(string input)
        {
            try
            {
                string[] param = input.Split(' ');

                if (param.Length > 1 && input.ToLower().Contains("-п"))
                {
                    Help();
                }

                if (param.Length == 5)
                {
                    double result = 0;
                    if (runCalculate(param, out result))
                    {
                        cl.Default(); Console.Write("Обемът на канален изкоп е ");
                        cl.Result(); Console.Write(result.ToString("N2"));
                        cl.Default(); Console.WriteLine(" m3\n");
                    }
                    else
                    {
                        cl.Default(); Console.WriteLine("Има грешно въведени параметри. С параметъра '-п' можете\nда видите синтаксиса на командата.\n");
                    }
                }
            }
            catch
            {

            }
        }


        /// <summary>
        /// Вътрешен метод за пресмятане на Формула 05, след парсване на командата от потребителя
        /// </summary>
        /// <param name = "param">Това е масив от стрингове, който съдържа командата с параметрите от потребителя</param>
        /// <param name = "result">В тази променлива ще бъде върнат резултата от формулата</param>
        /// <returns>Метода връща true при успешно изпълнение</returns>
        private bool runCalculate(string[] param, out double result)
        {
            try
            {
                double a = 0; Double.TryParse(param[1], out a);
                double b = 0; Double.TryParse(param[2], out b);
                double l = 0; Double.TryParse(param[3], out l);
                double h = 0; Double.TryParse(param[4], out h);

                result = (a + b) / 2 * h * l;
                return true;
            }
            catch
            {
            }

            result = 0;
            return false;
        }

        /// <summary>
        /// Вътрешен метод показващ синтаксиса на командния ред
        /// </summary>
        private void Help()
        {
            cl.Result(); Console.Write("[изкоп]");
            cl.Default(); Console.WriteLine(" - канален изкоп");

            cl.Result(); Console.Write("параметри: ");
            cl.Default(); Console.WriteLine(" a, b, l и h\n");

            cl.Result(); Console.Write("a и b");
            cl.Default(); Console.WriteLine(" - горна и долна ширина");

            cl.Result(); Console.Write("l");
            cl.Default(); Console.WriteLine(" - дължина");

            cl.Result(); Console.Write("h");
            cl.Default(); Console.WriteLine(" - височина\n");
        }
    }
}
