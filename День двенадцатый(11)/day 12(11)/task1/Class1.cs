namespace task1
{
    class Vector
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

        public virtual double GetLength()
        {
            return 0.0;
        }
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
            return base.ToString() + $" Длина: {GetLength()}";
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
            return base.ToString() + $" Длина: {GetLength()}";
        }

        public override double GetLength()
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }
    }
}
