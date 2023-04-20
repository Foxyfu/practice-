using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
        class Class1
        {
            public delegate double CalcFigure(double R);

            public static double Get_Length(double R)
            {
                double D = 2 * Math.PI * R;
                return D;
            }

            public static double Get_Area(double R)
            {
                double S = Math.PI * R * R;
                return S;
            }

            public static double Get_Volume(double R)
            {
                double V = 4/3 * Math.PI * Math.Pow(R, 3);
                return V;
            }
        }
}
