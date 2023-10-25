using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практос_5___4._0_ПОСЛЕДНЯЯ_ПОПЫТКА
{
    internal class Class2
    {
        public static int Arrow(int position, int min, int max, int cost, string zakaz)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine(">");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");


                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position == min - 1)
                        position = max;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position == max + 1)
                        position = min;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu.Menu1(position, cost , zakaz );
                }

            } while (key.Key != ConsoleKey.Enter);
            return position;
        }























    }
}
