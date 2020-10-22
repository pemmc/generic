using System;
using System.Collections.Generic;

namespace Generics1.Services
{
    public class CalculationService
    {
        public int Max(List<int> list)
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia!");

            }

            //Para encontrar o maior da lista
            int max = list[0];

            //Procurando/Varrendo dentro dos outros elementos da lista
            for(int i = 1; i< list.Count; i++)
            {
                if(list[i] > max)
                {
                    max = list[i];

                }

            }

            return max;
        }
    }
}
