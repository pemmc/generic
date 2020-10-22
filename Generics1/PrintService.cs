using System;

namespace Generics1
{
    public class PrintService<Tipo>
    {
        private Tipo[] _values = new Tipo[10];
        private int _count = 0;

        public void addValue(Tipo value)
        {
            if(_count ==10)
            {
                throw new InvalidOperationException("Vetor cheio");
            }

            _values[_count] = value;
            _count++;

        }

        public Tipo First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Vetor ainda vazio, não existe a posição zero");
            }

            return _values[0];

        }

        public void print()
        {

            if (_count == 0)
            {
                throw new InvalidOperationException("Vetor ainda vazio, não existem elementos");

            }

            Console.Write("[");


            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");

            }

            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);

            }

        Console.Write("]");

        }

    }
}
