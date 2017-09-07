using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    /// <summary>
    /// Формула за вдлъбнат ъгъл (Формула 02)
    /// </summary>
    public class Formula02
    {
        Colors.ForCLI cl = new Colors.ForCLI();

        /// <summary>
        /// Конструктор на Формула 02
        /// </summary>
        public Formula02()
        {

        }

        /// <summary>
        /// Метод за пресмятане на Формула 02
        /// </summary>
        public void Calc(string input)
        {
            try
            {
                string[] param = input.Split(' ');

                if(param.Length>1 && input.ToLower().Contains("-п"))
                {
                    Help();
                }

                if(param.Length == 4)
                {
                    double result = 0;
                    if(runCalculate(param, out result))
                    {
                        cl.Default();    Console.Write("Обемът на вдлъбнатия ъгъл е ");
                        cl.Result();     Console.Write(result.ToString("N2"));
                        cl.Default();    Console.WriteLine(" m3\n");
                    }
                    else
                    {
                        cl.Default();    Console.WriteLine("Има грешно въведени параметри. С параметъра '-п' можете\nда видите синтаксиса на командата.\n");
                    }
                }
            }
            catch 
            {
                
            }
        }


        /// <summary>
        /// Вътрешен метод за пресмятане на Формула 02, след парсване на командата от потребителя
        /// </summary>
        /// <param name = "param">Това е масив от стрингове, който съдържа командата с параметрите от потребителя</param>
        /// <param name = "result">В тази променлива ще бъде върнат резултата от формулата</param>
        /// <returns>Метода връща true при успешно изпълнение</returns>
        private bool runCalculate(string[]param, out double result)
        {
            try
            {
                double a = 0; Double.TryParse(param[1], out a);
                double b = 0; Double.TryParse(param[2], out b);
                double h = 0; Double.TryParse(param[3], out h);

                result = a * b * h / 3;
                return true;
            }
            catch {
            }

            result = 0;
            return false;
        }

        /// <summary>
        /// Вътрешен метод показващ синтаксиса на командния ред
        /// </summary>
        private void Help()
        {
            cl.Result();     Console.Write("[въгъл]");
            cl.Default();    Console.WriteLine(" - вдлъбнат ъгъл");

            cl.Result();     Console.Write("параметри: ");
            cl.Default();    Console.WriteLine(" a, b и h\n");

            cl.Result();     Console.Write("a и b");
            cl.Default();    Console.WriteLine(" - ширина и дължина");

            cl.Result();     Console.Write("h");
            cl.Default();    Console.WriteLine(" - височина\n");
        }
    }
}
