using Day27Prac26.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27Prac26.Interfaces
{
    internal interface IXmlSweets
    {
        void Load(string xmlDokPath);
        void Add(SweetsSet sweets);
       SweetsSet FindBy(string typeSweet);



    }
}
