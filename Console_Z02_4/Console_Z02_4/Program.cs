using System;

namespace Console_Z02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("| Не симетричная, |\n| не красивая ;(  |");

            int stroka = 5;
            int probel = 0;
            for (int i = 8; i > 3; i--)
            {   
                Console.Write("| ");
                for (int j = 0; j < stroka; j++)
                {
                    Console.Write("  " + i);
                }
                for (int n = 0; n < probel; n++)
                {
                    Console.Write("   ");
                }
                stroka--;
                probel++;
                Console.WriteLine(" |");
            }
        }
    }
}
