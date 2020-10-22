using System;
using System.Collections.Generic;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("Quanto valores? ");

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                printService.addValue(x);

            }


            printService.print();
            Console.WriteLine();

            Console.WriteLine("First: " + printService.First());
           
        }
    }
}
