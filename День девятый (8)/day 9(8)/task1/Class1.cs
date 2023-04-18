using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    struct Train
    {
        private string _destination;
        private int _number;
        private DateTime _time;

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public Train(string destination, int number, DateTime time)
        {
            _destination = destination;
            _number = number;
            _time = time;
        }

       /* public override string ToString()
        {
            return $"gfgfd"
        }*/
    }
}
