using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_Kingdom
{
    static partial class Loading // Логика загрузки
    {
        private static void LogicLoading(int count = 0)
        {
            Console.WriteLine(load);
            while (count < 12)
            {
                if (count % 3 == 0)
                {
                    while (x < 10)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(".");
                        Sleep();
                        x++;
                    }
                }
                else
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");
                    Sleep();
                }
                x--;
                count++;
            }
        }

        private static void Sleep()
        {
            Thread.Sleep(700);
        }

        public static void PrintLoading()
        {
            ConsoleClear.Clear();
            LogicLoading();
            ConsoleClear.Clear();
        }
    }
}
