using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs.Lab5
{
    internal class Matrica
    {
        private int _value1;
        private int _value2;
        private int[,] _massiv;

        public Matrica(int value1, int value2)
        {
            _value1 = value1;
            _value2 = value2;
            _massiv = new int[value1, value2];
        }



        public void Random()
        {
            Random rnd = new Random();
            for (int i = 0; i < _value1; i++)
            {
                for (int w = 0; w < _value2; w++)
                {
                    _massiv[i, w] = rnd.Next(0, 100);
                }
            }

        }
        public void Print()
        {
            for (int i = 0; i < _value1; i++)
            {
                Console.WriteLine();
                for (int w = 0; w < _value2; w++)
                {
                    Console.Write(_massiv[i, w] + "\t");
                }
            }

        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _massiv.GetLength(0); i++)
            {
                for (int w = 0; w < _massiv.GetLength(1); w++)
                {
                    sum += _massiv[i, w];
                }
            }
            return sum;
        }
        public void GlavDiag()
        {
            for (int i = 0; i < _value1; i++)
            {
                for (int w = 0; w < _value2; w++)
                {
                    if (i == w)
                    {
                        Console.WriteLine(_massiv[i, i]);
                    }
                }
            }

        }

        public void PassivDiag()
        {
            for (int i = 0; i < _massiv.GetLength(0); i++)
            {
                for (int w = 0; w < _massiv.GetLength(1); w++)
                {
                    if (i == w)
                    {
                        Console.WriteLine(_massiv[_massiv.GetLength(0) - i - 1, i]);
                    }
                }
            }

        }
    }
}
