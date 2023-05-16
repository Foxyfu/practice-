using System;
using System.Collections.ObjectModel;

namespace Task1.Models
{
    public record Record
    {
        private DateOnly _birthday;

        public string Surname { get; init; }
        public string Birthday
        {
            get { return _birthday.ToString("dd.MM.yyyy"); }
            init { _birthday = DateOnly.Parse(value); }
        }
        public string Phone { get; init; }

        public Record(string Surname, string Birthday, string Phone)
        {
            this.Surname = Surname;
            this.Birthday = Birthday;
            this.Phone = Phone;
        }

        public override string ToString()
        {
            return $"Фамилия: {Surname}\nДата рождения: {Birthday}\nНомер телефона: {Phone}\n";
        }
    }
}
