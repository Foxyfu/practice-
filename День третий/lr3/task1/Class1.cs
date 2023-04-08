using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class ClassA
    {
        private int _a;
        private int _b;

        public int a
        {
            get { return _a; }
            set { _a = value; }
        }

        public int b
        {
            get { return _b; }
            set { _b = value; }
        }

        public ClassA(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double Сalculation(int a, int b)
        {
            double rezult = (Math.Sin(b) + 4 )/(2*a);
            return rezult;
        }
        public double SquaringSum(int a, int b)
        {
            double rezult = Math.Pow(a + b, 2);
            return rezult;
        }

        public void Print(int a,int b)
        {
            Console.WriteLine("Вычесление равно: " + Сalculation(a, b));
            Console.WriteLine("Сумма квадратов равна:" + SquaringSum(a,b));
        }
    }
}
