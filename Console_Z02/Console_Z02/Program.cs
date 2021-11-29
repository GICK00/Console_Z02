using System;

namespace Console_Z02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Проверка точки на нахождение в заштрихованной области");
            bool repit = true;
            while (repit == true)
            {
                try
                { 
                    Console.WriteLine("| Ведите точку.");
                    Console.Write("| x = ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("| y = ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    if (y == -100 || y == (-1) * Math.Abs(x))
                    {
                        Console.WriteLine("| На границе");
                    }
                    else if (y > -100 && y < 0 && y < (-1) * Math.Abs(x))
                    {
                        Console.WriteLine("| Внутри");
                    }
                    else
                    {
                        Console.WriteLine("| Вне");
                    }

                    Console.WriteLine("|---------------------------");
                    Console.WriteLine("| Попробовать снова? Да / Нет");
                    Console.Write("| : ");
                    string repitTxT = Convert.ToString(Console.ReadLine());

                    if (repitTxT == "Да")
                    {
                        repit = true;
                        Console.WriteLine("|---------------------------");
                    }
                    else if (repitTxT == "Нет")
                        repit = false;
                    else
                    {
                        Console.WriteLine("|---------------------------");
                        Console.WriteLine("| Некорректный ввод данных!");
                        repit = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("|---------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    Console.WriteLine("| Попробовать снова? Да / Нет");
                    Console.Write("| : ");
                    string repitTxT = Convert.ToString(Console.ReadLine());

                    if (repitTxT == "Да")
                    {
                        repit = true;
                        Console.WriteLine("|---------------------------");
                    }
                    else if (repitTxT == "Нет")
                        repit = false;
                    else
                    {
                        Console.WriteLine("|---------------------------");
                        Console.WriteLine("| Некорректный ввод данных!");
                        repit = false;
                    }
                }
            }
        }
    }
}
