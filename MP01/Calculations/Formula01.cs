﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Formula01 
    {
        // Библиотеки:
        private Colors.ForCLI c = new Colors.ForCLI();

        public Formula01() // Формула за обикновенна строителна яма
        { }

        // Парсване
        public void Calc(string userInput)
        {
            try
            {
                string[] param = userInput.Split(' ');

                if(param.Length>1 && userInput.Contains("-п"))
                {
                    // Помощ за командата
                    Hepl();
                                        
                }
                if (param.Length > 1 && !userInput.Contains("-п"))
                {
                    // Изчисления
                    double result = 0;
                    if(runCalculations(param, out result))
                    {
                        c.Default();  Console.Write("Обема на строителната яма е: ");
                        c.Result();   Console.Write(result.ToString("N2"));
                        c.Default(); Console.WriteLine(" м3\n");
                    }
                    else
                    {
                        c.Default();  Console.WriteLine(
                            "Има грешно въведени параметри. Можете да проверите синтаксиса с параметъра '-п'");
                    }
                }
            }
            catch { }
        }

        // Изчисление и изписване
        private bool runCalculations(string[] param, out double result)
        {
            try
            {
                double a1 = 0, b1 = 0, a2 = 0, b2 = 0, h = 0;
                // param[0] == име на команда
                double.TryParse(param[1], out a1);
                double.TryParse(param[2], out b1);
                double.TryParse(param[3], out a2);
                double.TryParse(param[4], out b2);
                double.TryParse(param[5], out h);

                double F1 = a1 * b1, F2 = a2 * b2;
                result = h * (F1 + F2) / 2;

                return true;
            }  catch   {
            }

            result = 0;
            return false;
        }

        // Помощ за командата
        private void Hepl()
        {
            c.Result(); Console.Write("[яма]");
            c.Default(); Console.WriteLine("- команда за пресмятане на строителна яма");

            c.Command(); Console.Write("параметри: ");
            c.Default(); Console.WriteLine("a1 b1 a2 b2 h\n");

            c.Command(); Console.Write("a1 и b1");
            c.Default(); Console.WriteLine(" - ширина и дължина на горната страна на изкопа");

            c.Command(); Console.Write("a2 и b2");
            c.Default(); Console.WriteLine(" - ширина и дължина на долната страна на изкопа");

            c.Command(); Console.Write("h ");
            c.Default(); Console.WriteLine(" - височина на изкопа\n");
        }
    }
}
