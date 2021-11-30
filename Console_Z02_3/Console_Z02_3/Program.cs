using System;

namespace Console_Z02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Вывод чисел в заданном диапазоне\n| с заданным окончанием.");
            bool repit = true;
            while (repit == true)
            {
                try
                {
                    Console.WriteLine("| Введите диапазон.");
                    Console.Write("| A : ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("| B : ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("| Введите окончание.");
                    Console.Write("| X : ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("|---------------------------------------");
                    
                    if (a < b && (x.ToString().Length == 1 && x >= 0))
                    {
                       
                        Console.WriteLine("| While. ");
                        int numberWhile = a;
                        while (numberWhile <= b)
                        {
                            if (Math.Abs(numberWhile) % 10 == x)
                            {
                                Console.WriteLine("| : " + numberWhile);
                            }
                            ++numberWhile;
                        }

                        Console.WriteLine("|---------------------------------------");
                        Console.WriteLine("| Do While. ");
                        int numberDoWhile = a;
                        do 
                        {
                            if (Math.Abs(numberDoWhile) % 10 == x)
                            {
                                Console.WriteLine("| : " + numberDoWhile);
                            }
                            ++numberDoWhile;
                        } while (numberDoWhile <= b);

                        Console.WriteLine("|---------------------------------------");
                        Console.WriteLine("| For. ");
                        int numberFor = a;
                        for (int i = numberFor; i < b; i++)
                        {
                            if (Math.Abs(i) % 10 == x)
                            {
                                Console.WriteLine("| : " + i);
                            }
                        }

                        rep(out repit);
                    }
                    else
                    {
                        Console.WriteLine("| A должно быть меньше B и\n| X должно быть больше 0 ");
                        rep(out repit);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("|---------------------------------------");
                    Console.WriteLine("| Некорректный ввод данных!");
                    rep(out repit);
                }
            }
        }
        static void rep(out bool repit)
        {
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
