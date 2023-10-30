using System.Security.Cryptography.X509Certificates;

namespace Добрый_магазин_тортиков
{
    internal class Program
    {
            static string zakaz = "";
            static int price = 0;
        static void Main()
        {
            while (true) 
            {

                Console.WriteLine("Заказ тортов в магазине Добрый Отец, покупайте! ");
                Console.WriteLine("Выберите параметр торта");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("  Форма торта");
                Console.WriteLine("  Размер торта");
                Console.WriteLine("  Вкус коржей");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine($"Вы выбрали {zakaz}");
                Console.WriteLine($"Цена всего заказа равна:{price}");
                int pos = menu.Show(3, 9);

                if (pos == 3)
                {


                    Console.Clear();
                    Console.WriteLine("Выберите");
                    Console.WriteLine("Параметры:");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine("  Квадрат - 500");
                    Console.WriteLine("  Круг -- 300");
                    Console.WriteLine("  Сердечко -- 200");
                    Console.WriteLine("  Прямоугольник -- 340");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Main();
                    }
                    pos = menu.Show(3, 6);
                    if (pos == 3)
                    {
                        Console.Clear();
                        price += 500;
                        zakaz = zakaz + " Квадрат - 500";
                        Main();

                    }
                    else if (pos == 4)
                    {
                        Console.Clear();
                        price += 300;
                        zakaz = zakaz + " Круг -- 300";
                        Main();

                    }
                    else if (pos == 5)
                    {
                        Console.Clear();
                        price += 200;
                        zakaz = zakaz + " Сердечко -- 200";
                        Main();

                    }
                    else if (pos == 6)
                    {
                        Console.Clear();
                        price += 340;
                        zakaz = zakaz + " Прямоугольник -- 340";
                        Main();
                    }
                    continue;
                }
                if (pos == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите");
                    Console.WriteLine("Параметры:");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine("  Маленький (Диаметр - 16 см, 8 порций) - 1000");
                    Console.WriteLine("  Обычный (Диаметр - 18 см, 10 порций) - 1200");
                    Console.WriteLine("  Большой (Диаметр - 28 см, 24 порции) - 2000");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Main();
                    }
                    pos = menu.Show(3, 5);
                    if (pos == 3)
                    {
                        Console.Clear();
                        price += 1000;
                        zakaz = zakaz + "Маленький (Диаметр - 16 см, 8 порций) - 1000";
                        Main();

                    }
                    else if (pos == 4)
                    {
                        Console.Clear();
                        price += 1200;
                        zakaz = zakaz + "Обычный (Диаметр - 18 см, 10 порций) - 1200";
                        Main();
                    }
                    else if (pos == 5)
                    {
                        Console.Clear();
                        price += 2000;
                        zakaz = zakaz + "Большой (Диаметр - 28 см, 24 порции) - 2000";
                        Main();
                    }
                    continue;

                }
                if (pos == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите");
                    Console.WriteLine("Параметры:");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine("  Ванильный - 100");
                    Console.WriteLine("  Шоколадный - 100");
                    Console.WriteLine("  Карамельный - 150");
                    Console.WriteLine("  Ягодный - 200");
                    Console.WriteLine("  Кокосовый - 250");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Main();
                    }
                    pos = menu.Show(3, 7);
                    if (pos == 3)
                    {
                        Console.Clear();
                        price += 100;
                        zakaz = zakaz + "Ванильный - 100";
                        Main();

                    }
                    else if (pos == 4)
                    {
                        Console.Clear();
                        price += 100;
                        zakaz = zakaz + "Шоколадный - 100";
                        Main();
                    }
                    else if (pos == 5)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Карамельный - 150";
                        Main();

                    }
                    else if (pos == 6)
                    {
                        price += 200;
                        zakaz = zakaz + "Ягодный - 200";
                        Main();
                    }
                    else if (pos == 7)
                    {
                        price += 250;
                        zakaz = zakaz + "Кокосовый - 250";
                        Main();


                    }
                    continue;
                }
                if (pos == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите");
                    Console.WriteLine("Параметры:");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine("  1 корж - 200");
                    Console.WriteLine("  2 коржа - 400");
                    Console.WriteLine("  3 коржа - 600");
                    Console.WriteLine("  4 коржа - 800");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Main();
                    }
                    pos = menu.Show(3, 5);
                    if (pos == 3)
                    {
                        Console.Clear();
                        price += 200;
                        zakaz = zakaz + "1 корж - 200";
                        Main();

                    }
                    else if (pos == 4)
                    {
                        Console.Clear();
                        price += 400;
                        zakaz = zakaz + "2 коржа - 400";
                        Main();
                    }
                    else if (pos == 5)
                    {
                        Console.Clear();
                        price += 600;
                        zakaz = zakaz + "3 коржа - 600";
                        Main();
                    }
                    else if (pos == 6)
                    {
                        Console.Clear();
                        price += 800;
                        zakaz = zakaz + "4 коржа - 800";
                        Main();
                    }
                    continue;
                }
                if (pos == 7)
                {

                    Console.Clear();

                    Console.WriteLine("Выберите");
                    Console.WriteLine("Параметры:");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine("  Шоколад - 100");
                    Console.WriteLine("  Крем - 100");
                    Console.WriteLine("  Бизе - 150");
                    Console.WriteLine("  Драже -150");
                    Console.WriteLine("  Ягоды - 200");
                    Console.WriteLine("  Шоколадная - 150");
                    Console.WriteLine("  Ягодная - 150");
                    Console.WriteLine("  Кремовая - 150");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Main();
                    }
                    pos = menu.Show(3, 10);
                     if (pos == 3)
                    {
                        Console.Clear();
                        price += 100;
                        zakaz = zakaz + "Шоколад - 100";
                        Main();

                    }
                    else if (pos == 4)
                    {
                        Console.Clear();
                        price += 100;
                        zakaz = zakaz + "Крем - 100";
                        Main();
                    }
                    else if (pos == 5)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Бизе - 150";
                        Main();
                    }
                    else if (pos == 6)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Драже -150";
                        Main();
                    }
                    else if (pos == 7)
                    {
                        Console.Clear();
                        price += 200;
                        zakaz = zakaz + "Ягоды - 200";
                        Main();
                    }
                    else if (pos == 8)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Шоколадная - 150";
                        Main();
                    }
                    else if (pos == 9)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Ягодная - 150";
                        Main();
                    }
                    else if (pos == 10)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Кремовая - 150";
                        Main();
                    }
                    continue;

                }
                if (pos == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите");
                    Console.WriteLine("Параметры:");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine("  Шоколадyная - 150");
                    Console.WriteLine("  Ягодная - 150");
                    Console.WriteLine("  Кремовая - 150");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Main();
                    }
                    pos = menu.Show(3, 10);
                    if (pos == 3)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Шоколад - 150";
                        Main();

                    }
                    else if (pos == 4)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Ягодная - 150";
                        Main();
                    }
                    else if (pos == 5)
                    {
                        Console.Clear();
                        price += 150;
                        zakaz = zakaz + "Кремовая - 150";
                        Main();
                    }
                    continue;

                }
                if (pos == 9)
                {
                    Console.Clear ();
                    File.AppendAllText("заказ.txt", "\n Заказ от " + DateTime.Now);
                    File.AppendAllText("заказ.txt", $"\n Заказ: {zakaz}");
                    File.AppendAllText("заказ.txt", $"\n Цена: {price}");
                    break;
                    
                }


            } 


            






        }
    }
}