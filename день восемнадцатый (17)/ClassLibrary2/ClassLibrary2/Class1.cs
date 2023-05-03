using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace GeometryLibrary
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be positive numbers.");
            }

            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Invalid triangle.");
            }

            sideA = a;
            sideB = b;
            sideC = c;
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }

        public double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public string Type()
        {
            if (sideA == sideB && sideB == sideC)
            {
                return "Equilateral";
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }

    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            if (l <= 0 || w <= 0)
            {
                throw new ArgumentException("Sides must be positive numbers.");
            }

            length = l;
            width = w;
        }

        public double Perimeter()
        {
            return 2 * (length + width);
        }

        public double Area()
        {
            return length * width;
        }
    }
}

