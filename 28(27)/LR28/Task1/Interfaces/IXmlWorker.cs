using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Task1.Models;

namespace Task1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string XmlPath);
        void Add(Record record);
        void Delete(string Surname);
        Record GetBySurname(string Surname);
        List<Record> GetAll();
    }
}
