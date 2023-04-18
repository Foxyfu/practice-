using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tsak_1
{
    class Student
    {
        private string _name;
        private double _sr;
        private int _scholarship;

        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }

        public double Sr
        {
            get { return _sr; }
        }

        public int Scholarship
        {
            get { return _scholarship; }
        }

        public Student(string name, double sr)
        {
            _name = name;
            _sr = sr;
            _scholarship = 0;
        }

        public int СountingScholarship()
        {
            return 300000 + 10000 * ((int)Sr - 5);
             
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Cредний балл: {Sr} , Степендия: {СountingScholarship()}  ";
        }
    }

    class Master : Student
    {
        private string _specialization;

        public string Specialization
        {
            get { return _specialization; }
        }

        public Master(string specialization, string name, double sr) : base(name, sr)
        {
            _specialization = specialization;
        }

        public int СountingScholarship(int m)
        {
            return 300000 + 10000 * ((int)Sr - 5) + m;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Cредний балл: {Sr} ,Специальность: {Specialization}";
        }


    }
}
