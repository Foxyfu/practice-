using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Polynomial
    {
        private double _a, _b, _c;

       public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public double C
        {
            get { return _c; }
            set { _c = value; }
        }


        public Polynomial(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double Evaluate(double x)
        {
            // Вычисление значения многочлена для заданного аргумента
            return A * x * x + B * x + C;
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            // Сложение многочленов
            return new Polynomial(p1.A + p2.A, p1.B  + p2.B, p1.C + p2.C);
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            // Вычитание многочленов
            return new Polynomial(p1.A - p2.A, p1.B - p2.B, p1.C - p2.C);
        }

        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            // Умножение многочленов
            double a = p1.A * p2.A;
            double b = p1.A * p2.B + p1.B * p2.A;
            double c = p1.A * p2.C  + p1.B * p2.B + p1.C * p2.A;
            return new Polynomial(a, b, c);
        }

        public void Print()
        {
            Console.WriteLine("{0}x^2 + {1}x + {2}", A, B, C);
        }
    }
}
