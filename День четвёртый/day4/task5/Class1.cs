using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Notebook
    {
        private List<Record> _records;

        public Notebook()
        {
            _records = new List<Record>();
        }

        public void AddRecord(Record record)
        {
            _records.Add(record);
        }

        public void DeleteRecord(Record record)
        {
            _records.Remove(record);
        }

        public List<Record> GetRecordByPhone(string phoneNumber)
        {
            List<Record> finded = _records.Where(x => x.PhoneNumber.StartsWith(phoneNumber)).ToList();
            if (finded.Count == 0)
            {
                throw new Exception("Не найден человек с таким номером");
            }
            return finded;
        }

        public List<Record> GetRecordByBirthday(string date = "now")
        {
            if (date == "now")
            {
                return _records.Where(x => x.Date.Month.Equals(DateTime.Today.Month) && x.Date.Day.Equals(DateTime.Today.Day)).ToList();
            }
            else
            {
                DateOnly parsedDate = DateOnly.Parse(date);
                return _records.Where(x => x.Date.Month.Equals(parsedDate.Month) && x.Date.Day.Equals(parsedDate.Day)).ToList();
            }
        }

        public List<Record> GetRecordByBirthdayOnNextWeek()
        {
            DateTime sundayOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 6);
            return _records.Where(x => x.Date.Month.Equals(sundayOfWeek.Month) && Enumerable.Range(sundayOfWeek.Day, 7).Contains(x.Date.Day)).ToList();
        }

    }

    class Record
    {
        private string _name;
        private string _phoneNumber;
        private DateOnly _date;

        public string Name
        {
            get { return _name; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public DateOnly Date
        {
            get { return _date; }
        }

        public Record(string name, string phoneNumber, string date)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _date = DateOnly.Parse(date);
        }
        public override string ToString()
        {
            return $"Имя: {_name}, Номер телефона: {_phoneNumber}, Дата рождения: {_date}";
        }
    }
}
