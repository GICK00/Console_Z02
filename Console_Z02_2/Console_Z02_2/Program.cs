using System;
using System.Text.RegularExpressions;

namespace Console_Z02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Нахождения неизвестной даты");
            bool repit = true;
            while(repit == true)
            {
                try
                {                    
                    Console.WriteLine("| Введите текущию дату в формате дд.мм.гггг");
                    Console.Write("| : ");
                    string data = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("| Введите количество прошедших месяцев.");
                    Console.Write("| : ");
                    int mouthPast = Convert.ToInt32(Console.ReadLine());

                    Regex reg = new Regex(@"\d{1,4}");
                    Match n = reg.Match(data);

                    int day = Convert.ToInt32(Convert.ToString(n));
                    n = n.NextMatch();
                    int month = Convert.ToInt32(Convert.ToString(n));
                    n = n.NextMatch();
                    int year = Convert.ToInt32(Convert.ToString(n));
                    n = n.NextMatch();

                    if ((day.ToString().Length == 2 || day.ToString().Length == 1) && (month.ToString().Length == 2 || month.ToString().Length == 1) && (year.ToString().Length == 4) && day > 0 && day <= 31 && month <= 12 && month > 0)
                    {
                        while (mouthPast > 0)
                        {
                            month--;
                            if (month <= 0)
                            {
                                month = 12;
                                year--;
                            }
                            mouthPast--;
                        }

                        string TxTmonthLost = "";
                        switch (month)
                        {
                            case 01:
                                TxTmonthLost = "Января";
                                break;
                            case 02:
                                TxTmonthLost = "Февраля";
                                break;
                            case 03:
                                TxTmonthLost = "Марта";
                                break;
                            case 04:
                                TxTmonthLost = "Апреля";
                                break;
                            case 05:
                                TxTmonthLost = "Мая";
                                break;
                            case 06:
                                TxTmonthLost = "Июня";
                                break;
                            case 07:
                                TxTmonthLost = "Июля";
                                break;
                            case 08:
                                TxTmonthLost = "Августа";
                                break;
                            case 09:
                                TxTmonthLost = "Сентября";
                                break;
                            case 10:
                                TxTmonthLost = "Октября";
                                break;
                            case 11:
                                TxTmonthLost = "Ноября";
                                break;
                            case 12:
                                TxTmonthLost = "Декабря";
                                break;
                        }
                        Console.WriteLine("| Старая дата: {0:00} " + TxTmonthLost + " {1:0000}", day, year);
                        rep(out repit);
                    } 
                    else
                    {
                        Console.WriteLine("|---------------------------");
                        Console.WriteLine("| Неверный формат даты!");
                        rep(out repit);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("|---------------------------");
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
