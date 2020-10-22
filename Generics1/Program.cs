using System;
using System.Collections.Generic;
using System.Globalization;

using Generics1.Services;
using Generics1.Entities;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            Console.WriteLine("Digite N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');

                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                list.Add(new Products(name, price));

            }

            CalculationService calculationService = new CalculationService();

            Products max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);

        }

    }
}
