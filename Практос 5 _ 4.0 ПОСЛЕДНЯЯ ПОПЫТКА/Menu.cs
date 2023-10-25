using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практос_5___4._0_ПОСЛЕДНЯЯ_ПОПЫТКА
{
    internal class Menu
    {
        public static void Menu1(int position, int cost, string zakaz)
        {
            Console.WriteLine("Заказ тортов *********\nВыберите параметры тортика \n-------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine(" ");
            Console.WriteLine("Цена:" + cost);
            Console.WriteLine("Ваш торт :\n" + zakaz);
            position = Class2.Arrow(position, 3, 9, cost, zakaz);
            характеристики_торта(position, cost, zakaz);

        }

        private static void характеристики_торта(int position, int cost, string zakaz)
        {
          
            {


                ConsoleKeyInfo key;

                if (position == 3) //форма
                {
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("------------------");
                    position = 3;
                    Console.WriteLine("  Круг - 500");
                    Console.WriteLine("  Квадртат - 500");
                    Console.WriteLine("  Прямоугольник - 500");
                    Console.WriteLine("  Сердечко - 700");
                    position = Class2.Arrow(position, 3, 6, cost, zakaz);
                    if (position == 3)
                    {
                        cost += 500;
                        zakaz += " Круг - 500 \n";


                    }
                    else if (position == 4)
                    {
                        cost += 500;
                        zakaz += " Квадртат - 500 \n";



                    }
                    else if (position == 5)
                    {
                        cost += 500;
                        zakaz += " Прямоугольник - 500 \n";




                    }
                    else if (position == 6)
                    {
                        cost += 700;
                        zakaz += " Сердечко - 700 \n";




                    }
                    Console.Clear ();
                    Menu1(position, cost, zakaz);



                } // форма
                else if (position == 4)
                {
                    position = 3;
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("------------------");
                    Console.WriteLine("  Маленький (Диаметр 16 см , 8 порций) - 1000");
                    Console.WriteLine("  Обычный (Диаметр 18 см , 10 порций) - 1200");
                    Console.WriteLine("  Большой (Диаметр 28 см , 24 порций) - 2000");
                    position = Class2.Arrow(position, 3, 5, cost, zakaz);
                    if (position == 3)  //маленький
                    {
                        cost += 1000;
                        zakaz += " Маленький (Диаметр 16 см , 8 порций) - 1000 \n";




                    }
                    if (position == 4)  // обычный
                    {
                        cost += 1200;
                        zakaz += " Обычный (Диаметр 18 см , 10 порций) - 1200 \n";




                    }
                    if (position == 5)  // большой
                    {
                        cost += 2000;
                        zakaz += " Большой (Диаметр 28 см , 24 порций) - 2000 \n";




                    }

                    Console.Clear();
                    Menu1(position, cost, zakaz);



                } //размер 
                else if (position == 5)
                {
                    position = 3;
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("------------------");
                    Console.WriteLine("  Ванильный - 100");
                    Console.WriteLine("  Шоколадный - 150");
                    Console.WriteLine("  Карамельный - 200");
                    Console.WriteLine("  Ягодный - 250");
                    Console.WriteLine("  Кокосовый - 300");
                    position = Class2.Arrow(position, 3, 7, cost, zakaz);

                    if (position == 3)// Ваниль
                    {
                        cost += 100;
                        zakaz += " Ванильный - 100 \n";




                    }
                    if (position == 4)// Шоколад
                    {
                        cost += 150;
                        zakaz += " Шоколадный - 150 \n";




                    }
                    if (position == 5) //Карамель
                    {
                        cost += 200;
                        zakaz += " Карамельный - 200 \n";




                    }
                    if (position == 6) // Ягодный
                    {
                        cost += 250;
                        zakaz += " Ягодный - 250 \n";




                    }
                    if (position == 7)// Кокс
                    {
                        cost += 300;
                        zakaz += " Кокосовый - 300 \n";




                    }

                    Console.Clear();
                    Menu1(position, cost, zakaz);
                } //вкус
                else if (position == 6)
                {
                    position = 3;
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("------------------");
                    Console.WriteLine("  1 корж - 200");
                    Console.WriteLine("  2 корж - 400");
                    Console.WriteLine("  3 корж - 600");
                    Console.WriteLine("  4 корж - 800");
                    position = Class2.Arrow(position, 3, 6, cost, zakaz);

                    if (position == 3)// 1
                    {
                        cost += 200;
                        zakaz += " 1 корж - 200 \n";




                    }
                    if (position == 4)// 2
                    {
                        cost += 400;
                        zakaz += " 2 корж - 400 \n";




                    }
                    if (position == 5) //3
                    {
                        cost += 600;
                        zakaz += " 3 корж - 600 \n";




                    }
                    if (position == 6) // 4
                    {
                        cost += 800;
                        zakaz += " 4 корж - 800 \n";




                    }
                    Console.Clear();
                    Menu1(position, cost, zakaz);

                } //Кол-во коржей 
                else if (position == 7)
                {
                    position = 3;
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("------------------");
                    Console.WriteLine("  Шоколад - 100");
                    Console.WriteLine("  Крем - 150");
                    Console.WriteLine("  Бизе - 200");
                    Console.WriteLine("  Драже - 250");
                    Console.WriteLine("  Ягоды - 300");
                    position = Class2.Arrow(position, 3, 7, cost, zakaz);


                    if (position == 3)// Шоколад
                    {
                        cost += 100;
                        zakaz += " Шоколад - 100 \n";




                    }
                    if (position == 4)// Крем
                    {
                        cost += 150;
                        zakaz += " Крем - 150 \n";




                    }
                    if (position == 5) //Бизе
                    {
                        cost += 200;
                        zakaz += " Бизе - 200 \n";




                    }
                    if (position == 6) // Драже
                    {
                        cost += 250;
                        zakaz += " Драже - 250 \n";




                    }
                    if (position == 7)// Ягоды
                    {
                        cost += 300;
                        zakaz += " Ягоды - 300 \n";




                    }

                    Console.Clear();
                    Menu1(position, cost, zakaz);

                } //Глазурь
                else if (position == 8)
                {
                    position = 3;
                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню:");
                    Console.WriteLine("------------------");
                    Console.WriteLine("  Шоколадная - 150");
                    Console.WriteLine("  Ягодная - 150");
                    Console.WriteLine("  Кремовая - 150");
                    position = Class2.Arrow(position, 3, 6, cost, zakaz);

                    if (position == 3)// Шоколад
                    {
                        cost += 150;
                        zakaz += " Шоколадная - 150 \n";




                    }
                    if (position == 4)// Ягода
                    {
                        cost += 150;
                        zakaz += " Ягодная - 150 \n";




                    }
                    if (position == 5) //Кремовая
                    {
                        cost += 150;
                        zakaz += " Кремовая - 150 \n";




                    }

                    Console.Clear();
                    Menu1(position, cost, zakaz);

                } //декор 
                else if (position == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Чек был создан , но если хотите ещё раз сделать заказ , нажмите ещё раз Enter");
                    File.AppendAllText("C:\\Users\\1\\Desktop\\История заказов.txt", "Заказ от: " + DateTime.Now + "\n");
                    File.AppendAllText("C:\\Users\\1\\Desktop\\История заказов.txt", zakaz + "\n");
                    File.AppendAllText("C:\\Users\\1\\Desktop\\История заказов.txt", "Итоговая сумма :" + cost);
                    cost = 0;
                    zakaz = "";
                    Class2.Arrow(position, 3, 6, cost, zakaz);






                }
               


            }





        }

        





    }
}
