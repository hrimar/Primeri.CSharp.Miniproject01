using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    public class ForCLI
    {
        public ForCLI()
        {
        }

        public void Default()
        {
            Console.ForegroundColor = ConsoleColor.Gray; // задаване на цвят на текста
        }

        public void Prompt()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; // задаване на
        }

        public void Command()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; // задаване на командите на потребителя
        }
        public void Result()
        {
            Console.ForegroundColor = ConsoleColor.White; // задаване на
        }
    }
}
