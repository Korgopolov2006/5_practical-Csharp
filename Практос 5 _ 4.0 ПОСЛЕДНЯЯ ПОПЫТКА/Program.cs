namespace Практос_5___4._0_ПОСЛЕДНЯЯ_ПОПЫТКА
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zakaz = "";
            int cost = 0;
            int position = 3;
            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Menu.Menu1(position, cost, zakaz);

            } while (true);
        }
    }
}