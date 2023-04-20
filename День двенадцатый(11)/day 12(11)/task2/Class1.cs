using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class Vector
    {
        protected string _name;

        public Vector(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"Имя: {_name}.";
        }

        public abstract double GetLength();
    }

    class TwoDimensionalVector : Vector
    {
        private double _x;
        private double _y;

        public TwoDimensionalVector(string name, double x, double y) : base(name)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return base.ToString() + $" Длина: {GetLength():f2}";
        }

        public override double GetLength()
        {
            return Math.Sqrt(_x * _x + _y * _y);
        }
    }

    class ThreeDimensionalVector : Vector
    {
        private double _x;
        private double _y;
        private double _z;

        public ThreeDimensionalVector(string name, double x, double y, double z) : base(name)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public override string ToString()
        {
            return base.ToString() + $" Длина: {GetLength():f2}";
        }

        public override double GetLength()
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }
    }
}
