using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorPosition
{
    static class SetCursorPosition // выставляем позицию курсора
    {
        public static void CursorPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}