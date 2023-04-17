using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class TestClass:Ix,Iy,Iz
    {
        public double val;

        public double IxF0(double key)
        {
            val = key;
            return Math.Log(val);
        }

        public double IxF1()
        {
            return Math.Log(val);
        }

        public double F0(double key)
        {
            val = key;
            return 2 / val;
        }

        public double F1()
        {
            return 2 /val;
        }

        double Iz.F0(double key)
        {
            val = key;
            return Math.Pow(val, 3); ;
            
        }

        double Iz.F1()
        {
            return Math.Pow(val, 3);
        }
    }
}
