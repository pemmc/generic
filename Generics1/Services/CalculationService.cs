using System;
using System.Collections.Generic;

namespace Generics1.Services
{
    public class CalculationService
    {
        //agora a minha classe é normal, mas o MÉTODO que será GENÉRICO
        //a minha lista será de um tipo generico, desde que o meu objeto sera comparavel
        //duvida, assista: https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/learn/lecture/20039018#overview

        public TipoGenerico Max<TipoGenerico>(List<TipoGenerico> list) where TipoGenerico : IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia!");

            }

            //Para encontrar o maior da lista
            TipoGenerico max = list[0];

            //Procurando/Varrendo dentro dos outros elementos da lista
            for(int i = 1; i< list.Count; i++)
            {
                if(list[i].CompareTo(max) > 0)
                {
                    max = list[i];

                }

            }

            return max;
        }
    }
}
