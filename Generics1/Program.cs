using System;
using System.Collections.Generic;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //USANDO O GENERICS... com a tipagem lá na classe printservice do tipo ===> PrintService<Tipo>
                PrintService<int> printServiceInt = new PrintService<int>();

                Console.Write("Quanto valores desejas entrar? (entre com números) ");

                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());

                    printServiceInt.addValue(x);

                }

                printServiceInt.print();
                Console.WriteLine();

                Console.WriteLine("First: " + printServiceInt.First());

                PrintService<string> printServiceString = new PrintService<string>();

                Console.Write("Quanto valores desejas entrar? (entre com strings) ");

                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string s = Console.ReadLine();

                    printServiceString.addValue(s);

                }

                printServiceString.print();
                Console.WriteLine();

                Console.WriteLine("First: " + printServiceString.First());

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
