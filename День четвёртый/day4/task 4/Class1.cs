using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Array2D
    {
        private double[,] _array;
        private int _row;
        private int _column;

        public int Row
        {
            get { return _row; }
        }

        public int Column
        {
            get { return _column; }
        }

        public double this[int row, int column]
        {
            get { return _array[row, column]; }
            set { _array[row, column] = value; }
        }

        public Array2D(int row, int column)
        {
            _array = new double[row, column];
            _row = row;
            _column = column;
        }

        public void GenerateArray(int from, int to)
        {
            Random random = new Random();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    _array[i, j] = random.Next(from, to - 1);
                    _array[i, j] += random.NextDouble();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    sb.Append($"{_array[i, j]:f2} ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static Array2D operator +(Array2D array, int column)
        {
            if (column < array._column + 1)
            {
                for (int i = 0; i < array._row; i++)
                {
                    array[i, 0] += array[i, column - 1];
                }
                return array;
            }
            else
            {
                throw new Exception("Нет такого столбца");
            }
        }
    }
}
